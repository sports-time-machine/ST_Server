using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using System.Net;
using System.Collections.Generic;
using System.Media;
using ST_Server.Properties;
using System.Net.Sockets;

namespace ST_Server
{
	public partial class Form1 : Form
	{
		// @init-shortcuts
		void initShortcuts()
		{
			newShortCut(Keys.F1, buttonDepth);
			newShortCut(Keys.F2, buttonBlack);
		}


		const int UDP_SERVER_RECV = 38702;
		const int UDP_CLIENT_RECV = 38708;
		const int UDP_DAEMON_SEND = 37723;

		private static Form1 self;
		private static bool quit_receive = false;
		UdpClient udp_send;
		UdpClient udp_recv;
		UdpClient udp_daemon;
		Dictionary<Keys, Button> shortcuts;

		public Form1()
		{
			InitializeComponent();
			shortcuts = new Dictionary<Keys, Button>();
		}

		public static void ReceiveProc()
		{
			Debug.Print("begin receive thread");
			while (!quit_receive)
			{
				self.ReceiveThreadProc();
				Thread.Sleep(1);
			}
			Debug.Print("end of receive thread");
		}

		void UpdateSendLog(string text)
		{
			textBoxLog.Text = textBoxLog.Text+"$ "+text+"\r\n";
			textBoxLog.SelectionStart = textBoxLog.Text.Length;
			textBoxLog.Focus();
			textBoxLog.ScrollToCaret();
			textBox1.Focus();
		}

		void UpdateRecvLog(string text)
		{
			textBoxLog.Text = textBoxLog.Text+" > "+text+"\r\n";
			textBoxLog.SelectionStart = textBoxLog.Text.Length;
			textBoxLog.Focus();
			textBoxLog.ScrollToCaret();
			textBox1.Focus();
		}

		delegate void UpdateTextDelegate(string out_text);

		private void send_log(string s)
		{
			self.Invoke(new UpdateTextDelegate(UpdateSendLog), s);
		}

		private void recv_log(string s)
		{
			self.Invoke(new UpdateTextDelegate(UpdateRecvLog), s);
		}

		delegate void DoCommandDelegate(string cmd, string[] arg);

		private void doCommand(string cmd, string[] arg)
		{
			if (cmd=="PONG")
			{
				DataGridViewRow rows = new DataGridViewRow();
				rows.CreateCells(clientsSheet);
				rows.Cells[0].Value = arg[1];  // computer name
				rows.Cells[1].Value = arg[2];  // IP address
				rows.Cells[2].Value = arg[3];  // computer number
				rows.Cells[2].Style.Alignment = DataGridViewContentAlignment.BottomRight;
				rows.Cells[3].Value = "pong";
				rows.Cells[3].Style.Alignment = DataGridViewContentAlignment.BottomCenter;
				clientsSheet.Rows.Add(rows);
				return;
			}

			if (cmd=="STATUS")
			{
				if (arg.Length<2)
				{
					recv_log("STATUS ERROR");
				}
				else
				{
					string name   = arg[1];
					string status = arg[2];
					var rows = clientsSheet.Rows;
					for (int i=0; i<rows.Count; ++i)
					{
						if (rows[i].Cells["computername"].Value.ToString()==name)
						{
							rows[i].Cells["status"].Value = status;
							break;
						}
					}
				}
			}
		}

		private void ReceiveThreadProc()
		{
			var enc = System.Text.Encoding.UTF8;

			if (udp_recv.Available<=0)
				return;
			
			// Receive udp data
			IPEndPoint remoteEP = null;
			byte[] rcvBytes = udp_recv.Receive(ref remoteEP);
			if (rcvBytes.Length<=0)
				return;
			
			Debug.Print("[udp recv] "+rcvBytes.Length.ToString()+" bytes received");
			string rcvMsg = enc.GetString(rcvBytes);
			string[] cmds = rcvMsg.Split(new char[]{' ','\t'});
			if (cmds.Length>=1)
			{
				cmds[0] = cmds[0].ToUpper();
				self.Invoke(new DoCommandDelegate(doCommand), cmds[0], cmds);
			}

			recv_log(rcvMsg);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			send_data(textBox1.Text);
			textBox1.Text = "";
		}


		private void newShortCut(Keys key, Button button)
		{
			shortcuts[key] = button;
			button.Text += " ("+key.ToString()+")";
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			labelPlayerId.Text = "----";
			labelGameId.Text = "----";

#if true//for DEBUG
			labelPlayerId.Text = "AJ3M";
			labelGameId.Text = "99N3B";
#endif


			clientsSheet.Columns.Add("computername","PC名");
			clientsSheet.Columns["computername"].Width = 220;
			clientsSheet.Columns.Add("address", "IPアドレス");
			clientsSheet.Columns["address"].Width = 180;
			clientsSheet.Columns.Add("number", "Number");
			clientsSheet.Columns["number"].Width = 120;
			clientsSheet.Columns.Add("status", "Status");
			clientsSheet.Columns["status"].Width = 120;
			buttonRestart.Enabled = false;
			buttonAbort.Enabled = false;

			initShortcuts();

			self = this;
			udp_send = new UdpClient();
			udp_recv = new UdpClient(UDP_SERVER_RECV);
			udp_daemon = new UdpClient();

			rcv_thread = new Thread(ReceiveProc);
			rcv_thread.Start();
		}

		Thread rcv_thread;

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			quit_receive = true;
		}

		void send_data_raw(string s)
		{
			const string multicast = "255.255.255.255";

			var enc = System.Text.Encoding.UTF8;
			byte[] sendBytes = enc.GetBytes(s+"\n");
			udp_send.Send(sendBytes, sendBytes.Length, multicast, UDP_CLIENT_RECV);
			udp_send.Send(sendBytes, sendBytes.Length, multicast, UDP_SERVER_RECV);
			
			Thread.Sleep(50);

			send_log(s);
		}

		void send_data(string s)
		{
			send_data_raw(s);
		}

		private void buttonPicture1_Click(object sender, EventArgs e)
		{
			send_data("PICT 01.jpg");
		}

		private void buttonPicture2_Click(object sender, EventArgs e)
		{
			send_data("PICT 02.jpg");
		}

		private void buttonPicture3_Click(object sender, EventArgs e)
		{
			send_data("PICT 03.jpg");
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void buttonBlack_Click(object sender, EventArgs e)
		{
			send_data("BLACK");
		}

		private void buttonDepth_Click(object sender, EventArgs e)
		{
			send_data("DEPTH");
		}

		private void buttonInit_Click(object sender, EventArgs e)
		{
			string hostname = Dns.GetHostName();

			// ホスト名からIPアドレスを取得する
			IPAddress[] adrList = Dns.GetHostAddresses(hostname);
			string ip_address = "(unknown)";
			foreach (IPAddress address in adrList)
			{
				// IPv4 only
				if (address.AddressFamily==AddressFamily.InterNetwork)
				{
					Debug.Print(address.ToString());
					ip_address = address.ToString();
				}
			}

			clientsSheet.Rows.Clear();
			
			// DUMMY DATA desu!
			for (int i=0; i<0; ++i)
			{
				DataGridViewRow rows = new DataGridViewRow();
				rows.CreateCells(clientsSheet);
				rows.Cells[0].Value = "computer name";
				rows.Cells[1].Value = "IP address";
				rows.Cells[2].Value = "computer number";
				rows.Cells[2].Style.Alignment = DataGridViewContentAlignment.BottomRight;
				rows.Cells[3].Value = "pong";
				rows.Cells[3].Style.Alignment = DataGridViewContentAlignment.BottomCenter;
				clientsSheet.Rows.Add(rows);
			}

			send_data("PING "+ip_address);
		}

		private void buttonMirror_Click(object sender, EventArgs e)
		{
			send_data("MIRROR");
		}

		private void button3_Click(object sender, EventArgs e)
		{
			send_data("BORDERLINE");
		}

		private void button5_Click(object sender, EventArgs e)
		{
			send_data("FUNCTION2");
		}

		private void button4_Click(object sender, EventArgs e)
		{
			send_data("FUNCTION3");
		}

		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			if (shortcuts.ContainsKey(e.KeyCode))
			{
				shortcuts[e.KeyCode].PerformClick();
			}
		}

		private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void tabPage1_Click(object sender, EventArgs e)
		{

		}

		private void buttonUpdateStatus_Click(object sender, EventArgs e)
		{
			send_data_raw("STATUS");
		}

		private void groupBox1_Enter_1(object sender, EventArgs e)
		{

		}

		private void buttonStart_Click(object sender, EventArgs e)
		{
			StartGame();
		}


		// すべてのクライアント状態がstateならば真
		bool CheckAllClientStatusIs(string state)
		{
			var rows = clientsSheet.Rows;
			for (int i=0; i<rows.Count; ++i)
			{
				string st = rows[i].Cells["status"].Value.ToString();
				if (st!=state)
				{
					Debug.Print("CLIENT STATUS: "+st);
					return false;
				}
			}
			Debug.Print("CLIENT STATUS: ALL CLIENT is "+state);
			return true;
		}

		void ServerRecv_GameReady()
		{
			const int TIMEOUT = 20;
			for (int i=1; i<=TIMEOUT; ++i)
			{
				Thread.Sleep(30);
				if (CheckAllClientStatusIs("GAMEREADY"))
				{
					Debug.Print("all clients are ready!");
					break;
				}
				Debug.Print("wait for ready of all clients : "+i.ToString());
				if (i==TIMEOUT)
				{
					Debug.Print("TIMEOUT!");
					return;
				}
			}

			SoundPlayer[] snd = {
				new SoundPlayer(Resources.se_sad07),
				new SoundPlayer(Resources.se_sad07),
				new SoundPlayer(Resources.se_sad07),
				new SoundPlayer(Resources.se_sad05),
				};

			send_data_raw("COUNTDOWN3");
			snd[0].Play();
			Thread.Sleep(1000);
	
			send_data_raw("COUNTDOWN2");
			snd[1].Play();
			Thread.Sleep(1000);

			send_data_raw("COUNTDOWN1");
			snd[2].Play();
			Thread.Sleep(1000);

			send_data_raw("START");
			snd[3].Play();

			buttonStart.Enabled = false;
			buttonRestart.Enabled = true;
			buttonAbort.Enabled = true;
		}

		void StartGame()
		{
			// IDENT sv->cl
			string player_id = labelPlayerId.Text;
			string game_id = labelGameId.Text;
			send_data_raw(String.Format("IDENT {0} {1}", player_id, game_id));
			ServerRecv_GameReady();
		}

		private void buttonRestart_Click(object sender, EventArgs e)
		{
			buttonStart.Enabled = false;
			buttonRestart.Enabled = true;
			buttonAbort.Enabled = true;

			var snd = new SoundPlayer(Resources.se_maoudamashii_onepoint28);
			snd.Play();

			Thread.Sleep(2000);
			StartGame();
		}

		private void buttonAbort_Click(object sender, EventArgs e)
		{
			buttonStart.Enabled = true;
			buttonRestart.Enabled = false;
			buttonAbort.Enabled = false;

			var snd = new SoundPlayer(Resources.se_maoudamashii_onepoint24);
			snd.Play();
		}

		void SendDaemon(string s)
		{
			var enc = System.Text.Encoding.UTF8;
			byte[] sendBytes = enc.GetBytes("#"+s+"\n");
			udp_send.Send(sendBytes, sendBytes.Length, "255.255.255.255", UDP_DAEMON_SEND);
		}

		private void buttonReboot_Click(object sender, EventArgs e)
			{ SendDaemon("REBOOT"); }
		private void buttonExitClient_Click(object sender, EventArgs e)
			{ SendDaemon("TERMINATE"); }
		private void buttonBootClient_Click(object sender, EventArgs e)
			{ SendDaemon("BOOT"); }
		private void buttonReloadConfig_Click(object sender, EventArgs e)
			{ send_data_raw("RELOAD-CONFIG"); }
		private void buttonInitFloor_Click(object sender, EventArgs e)
			{ send_data_raw("BEGIN-INIT-FLOOR"); }
		private void buttonInitFloorEnd_Click(object sender, EventArgs e)
			{ send_data_raw("END-INIT-FLOOR"); }
	}
}

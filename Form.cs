using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using System.Net;
using System.Collections.Generic;

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


		const int UDP_SERVER_SEND = 38701;
		const int UDP_SERVER_RECV = 38702;
		const int UDP_CLIENT_RECV = 38708;

		int client_count = 0;

		private static Form1 self;
		private static bool quit_receive = false;
		System.Net.Sockets.UdpClient udp_send;
		System.Net.Sockets.UdpClient udp_recv;
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
				self.Receive();
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
				++client_count;
				
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
					recv_log("STATUS PROTOCOL ERROR");
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

		private void Receive()
		{
			var enc = System.Text.Encoding.UTF8;

			System.Net.IPEndPoint remoteEP = null;
			if (udp_recv.Available>0)
			{
				byte[] rcvBytes = udp_recv.Receive(ref remoteEP);
				if (rcvBytes.Length>0)
				{
					Debug.Print(rcvBytes.Length.ToString()+" bytes received");
					string rcvMsg = enc.GetString(rcvBytes);

					string[] cmds = rcvMsg.Split(new char[]{' ','\t'});
					if (cmds.Length>=1)
					{
						cmds[0] = cmds[0].ToUpper();
						self.Invoke(new DoCommandDelegate(doCommand), cmds[0], cmds);
					}

					recv_log(rcvMsg);
				}
			}
			else
			{
				//Debug.Print("no received");
			}
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
			clientsSheet.Columns.Add("computername", "PC名");
			clientsSheet.Columns.Add("address", "IPアドレス");
			clientsSheet.Columns.Add("number", "番号");
			clientsSheet.Columns.Add("status", "ステータス");

			initShortcuts();

			self = this;
			udp_send = new System.Net.Sockets.UdpClient();
			udp_recv = new System.Net.Sockets.UdpClient(UDP_SERVER_RECV);

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
			string remoteHost = "255.255.255.255";

			var enc = System.Text.Encoding.UTF8;
			byte[] sendBytes = enc.GetBytes(s);
			udp_send.Send(sendBytes, sendBytes.Length, remoteHost, UDP_CLIENT_RECV);
			udp_send.Send(sendBytes, sendBytes.Length, remoteHost, UDP_SERVER_RECV);

			send_log(s);
		}

		void send_data(string s)
		{
			send_data_raw(s);
			Thread.Sleep(30*2); // wait for 2 frames
			send_data_raw("STATUS");
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
				if (address.AddressFamily==System.Net.Sockets.AddressFamily.InterNetwork)
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

			client_count = 0;
			send_data("PING "+ip_address);
		}

		private void buttonMirror_Click(object sender, EventArgs e)
		{
			send_data("MIRROR");
		}

		private void button3_Click(object sender, EventArgs e)
		{
			send_data("FUNCTION1");
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

		}


	}
}

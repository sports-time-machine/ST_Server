using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace ST_Server
{
	public partial class Form1 : Form
	{
		const int ST_UDP_PORT = 38707;

		public Form1()
		{
			InitializeComponent();
		}

		private static Form1 self;
		private static bool quit_receive = false;

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

		System.Net.Sockets.UdpClient udp;

		string out_text;

		void UpdateText()
		{
			textBox1.Text = out_text;
		}

		delegate void UpdateTextDelegate();

		private void Receive()
		{
			var enc = System.Text.Encoding.UTF8;

			System.Net.IPEndPoint remoteEP = null;
			if (udp.Available>0)
			{
				byte[] rcvBytes = udp.Receive(ref remoteEP);
				if (rcvBytes.Length>0)
				{
					Debug.Print(rcvBytes.Length.ToString()+" bytes received");
					string rcvMsg = enc.GetString(rcvBytes);
					out_text = rcvMsg;
					self.Invoke(new UpdateTextDelegate(UpdateText));
				}
			}
			else
			{
				Debug.Print("no received");
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			send_data();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			self = this;
		}

		private void buttonServer_Click(object sender, EventArgs e)
		{
			textBox1.Visible = true;
			button1.Visible = true;
			textBox1.Focus();
			buttonClient.Visible = false;
			buttonServer.Visible = false;

			udp = new System.Net.Sockets.UdpClient();
		}

		Thread rcv_thread;

		private void buttonClient_Click(object sender, EventArgs e)
		{
			textBox1.Visible = true;
			button1.Visible = false;
			buttonClient.Visible = false;
			buttonServer.Visible = false;

			udp = new System.Net.Sockets.UdpClient(ST_UDP_PORT);

			rcv_thread = new Thread(ReceiveProc);
			rcv_thread.Start();
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			quit_receive = true;
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
		//	send_data();
		}

		void send_data()
		{
			var enc = System.Text.Encoding.UTF8;
			string remoteHost = "255.255.255.255";
			
			string sendMsg = textBox1.Text;
			byte[] sendBytes = enc.GetBytes(sendMsg);

			udp.Send(sendBytes, sendBytes.Length, remoteHost, ST_UDP_PORT);

			textBox1.Text = "";
		}
	}
}

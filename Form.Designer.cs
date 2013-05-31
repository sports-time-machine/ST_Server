namespace ST_Server
{
	partial class Form1
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.buttonPicture1 = new System.Windows.Forms.Button();
			this.buttonPicture2 = new System.Windows.Forms.Button();
			this.buttonPicture3 = new System.Windows.Forms.Button();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.tabControl2 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.buttonRestart = new System.Windows.Forms.Button();
			this.buttonAbort = new System.Windows.Forms.Button();
			this.buttonStart = new System.Windows.Forms.Button();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.buttonBlack = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.buttonDepth = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.buttonMirror = new System.Windows.Forms.Button();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.buttonUpdateStatus = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonInit = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPageClients = new System.Windows.Forms.TabPage();
			this.clientsSheet = new System.Windows.Forms.DataGridView();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.textBoxLog = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.tabControl2.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.tabPage4.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPageClients.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.clientsSheet)).BeginInit();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(372, 169);
			this.button1.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(124, 39);
			this.button1.TabIndex = 0;
			this.button1.Text = "送信";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.UseWaitCursor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Courier New", 12F);
			this.textBox1.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.textBox1.Location = new System.Drawing.Point(26, 178);
			this.textBox1.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(338, 26);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "Hello World";
			// 
			// buttonPicture1
			// 
			this.buttonPicture1.Location = new System.Drawing.Point(9, 153);
			this.buttonPicture1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonPicture1.Name = "buttonPicture1";
			this.buttonPicture1.Size = new System.Drawing.Size(92, 61);
			this.buttonPicture1.TabIndex = 6;
			this.buttonPicture1.Text = "画像1";
			this.buttonPicture1.UseVisualStyleBackColor = true;
			this.buttonPicture1.Click += new System.EventHandler(this.buttonPicture1_Click);
			// 
			// buttonPicture2
			// 
			this.buttonPicture2.Location = new System.Drawing.Point(109, 153);
			this.buttonPicture2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonPicture2.Name = "buttonPicture2";
			this.buttonPicture2.Size = new System.Drawing.Size(92, 61);
			this.buttonPicture2.TabIndex = 7;
			this.buttonPicture2.Text = "画像2";
			this.buttonPicture2.UseVisualStyleBackColor = true;
			this.buttonPicture2.Click += new System.EventHandler(this.buttonPicture2_Click);
			// 
			// buttonPicture3
			// 
			this.buttonPicture3.Location = new System.Drawing.Point(209, 153);
			this.buttonPicture3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonPicture3.Name = "buttonPicture3";
			this.buttonPicture3.Size = new System.Drawing.Size(92, 61);
			this.buttonPicture3.TabIndex = 8;
			this.buttonPicture3.Text = "画像3";
			this.buttonPicture3.UseVisualStyleBackColor = true;
			this.buttonPicture3.Click += new System.EventHandler(this.buttonPicture3_Click);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Control;
			this.splitContainer1.Panel1.Controls.Add(this.tabControl2);
			this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
			this.splitContainer1.Size = new System.Drawing.Size(544, 480);
			this.splitContainer1.SplitterDistance = 252;
			this.splitContainer1.SplitterWidth = 7;
			this.splitContainer1.TabIndex = 6;
			// 
			// tabControl2
			// 
			this.tabControl2.Controls.Add(this.tabPage1);
			this.tabControl2.Controls.Add(this.tabPage3);
			this.tabControl2.Controls.Add(this.tabPage4);
			this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl2.Location = new System.Drawing.Point(0, 0);
			this.tabControl2.Margin = new System.Windows.Forms.Padding(4);
			this.tabControl2.Name = "tabControl2";
			this.tabControl2.SelectedIndex = 0;
			this.tabControl2.Size = new System.Drawing.Size(544, 252);
			this.tabControl2.TabIndex = 22;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.buttonRestart);
			this.tabPage1.Controls.Add(this.buttonAbort);
			this.tabPage1.Controls.Add(this.buttonStart);
			this.tabPage1.Location = new System.Drawing.Point(4, 29);
			this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
			this.tabPage1.Size = new System.Drawing.Size(536, 219);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "ゲームの開始と終了";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// buttonRestart
			// 
			this.buttonRestart.BackgroundImage = global::ST_Server.Properties.Resources._1369988331_Refresh;
			this.buttonRestart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonRestart.FlatAppearance.BorderSize = 0;
			this.buttonRestart.Location = new System.Drawing.Point(197, 25);
			this.buttonRestart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonRestart.Name = "buttonRestart";
			this.buttonRestart.Size = new System.Drawing.Size(130, 130);
			this.buttonRestart.TabIndex = 21;
			this.buttonRestart.Text = "再スタート";
			this.buttonRestart.UseVisualStyleBackColor = true;
			// 
			// buttonAbort
			// 
			this.buttonAbort.BackgroundImage = global::ST_Server.Properties.Resources._1369988327_Delete;
			this.buttonAbort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonAbort.FlatAppearance.BorderSize = 0;
			this.buttonAbort.Location = new System.Drawing.Point(367, 25);
			this.buttonAbort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonAbort.Name = "buttonAbort";
			this.buttonAbort.Size = new System.Drawing.Size(130, 130);
			this.buttonAbort.TabIndex = 20;
			this.buttonAbort.Text = "中断";
			this.buttonAbort.UseVisualStyleBackColor = true;
			// 
			// buttonStart
			// 
			this.buttonStart.BackgroundImage = global::ST_Server.Properties.Resources._1369988293_5;
			this.buttonStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonStart.FlatAppearance.BorderSize = 0;
			this.buttonStart.Location = new System.Drawing.Point(26, 25);
			this.buttonStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonStart.Name = "buttonStart";
			this.buttonStart.Size = new System.Drawing.Size(131, 130);
			this.buttonStart.TabIndex = 20;
			this.buttonStart.Text = "スタート";
			this.buttonStart.UseVisualStyleBackColor = true;
			this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.buttonBlack);
			this.tabPage3.Controls.Add(this.button5);
			this.tabPage3.Controls.Add(this.buttonDepth);
			this.tabPage3.Controls.Add(this.button4);
			this.tabPage3.Controls.Add(this.button3);
			this.tabPage3.Controls.Add(this.buttonPicture1);
			this.tabPage3.Controls.Add(this.buttonMirror);
			this.tabPage3.Controls.Add(this.buttonPicture2);
			this.tabPage3.Controls.Add(this.buttonPicture3);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
			this.tabPage3.Size = new System.Drawing.Size(536, 226);
			this.tabPage3.TabIndex = 1;
			this.tabPage3.Text = "画面の効果";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// buttonBlack
			// 
			this.buttonBlack.Location = new System.Drawing.Point(9, 11);
			this.buttonBlack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonBlack.Name = "buttonBlack";
			this.buttonBlack.Size = new System.Drawing.Size(92, 61);
			this.buttonBlack.TabIndex = 10;
			this.buttonBlack.Text = "黒画面";
			this.buttonBlack.UseVisualStyleBackColor = true;
			this.buttonBlack.Click += new System.EventHandler(this.buttonBlack_Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(209, 82);
			this.button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(92, 61);
			this.button5.TabIndex = 18;
			this.button5.Text = "機能2";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// buttonDepth
			// 
			this.buttonDepth.Location = new System.Drawing.Point(109, 11);
			this.buttonDepth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonDepth.Name = "buttonDepth";
			this.buttonDepth.Size = new System.Drawing.Size(92, 61);
			this.buttonDepth.TabIndex = 11;
			this.buttonDepth.Text = "デプス";
			this.buttonDepth.UseVisualStyleBackColor = true;
			this.buttonDepth.Click += new System.EventHandler(this.buttonDepth_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(309, 82);
			this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(92, 61);
			this.button4.TabIndex = 17;
			this.button4.Text = "機能3";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(109, 82);
			this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(92, 61);
			this.button3.TabIndex = 16;
			this.button3.Text = "機能1";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// buttonMirror
			// 
			this.buttonMirror.Location = new System.Drawing.Point(9, 82);
			this.buttonMirror.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonMirror.Name = "buttonMirror";
			this.buttonMirror.Size = new System.Drawing.Size(92, 61);
			this.buttonMirror.TabIndex = 15;
			this.buttonMirror.Text = "ミラー";
			this.buttonMirror.UseVisualStyleBackColor = true;
			this.buttonMirror.Click += new System.EventHandler(this.buttonMirror_Click);
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.Add(this.buttonUpdateStatus);
			this.tabPage4.Controls.Add(this.label1);
			this.tabPage4.Controls.Add(this.textBox1);
			this.tabPage4.Controls.Add(this.buttonInit);
			this.tabPage4.Controls.Add(this.button1);
			this.tabPage4.Location = new System.Drawing.Point(4, 29);
			this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Padding = new System.Windows.Forms.Padding(4);
			this.tabPage4.Size = new System.Drawing.Size(536, 219);
			this.tabPage4.TabIndex = 2;
			this.tabPage4.Text = "初期化";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// buttonUpdateStatus
			// 
			this.buttonUpdateStatus.BackgroundImage = global::ST_Server.Properties.Resources._1369988320_Synchronize;
			this.buttonUpdateStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonUpdateStatus.Location = new System.Drawing.Point(27, 18);
			this.buttonUpdateStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonUpdateStatus.Name = "buttonUpdateStatus";
			this.buttonUpdateStatus.Size = new System.Drawing.Size(160, 108);
			this.buttonUpdateStatus.TabIndex = 19;
			this.buttonUpdateStatus.Text = "ステータス更新";
			this.buttonUpdateStatus.UseVisualStyleBackColor = true;
			this.buttonUpdateStatus.Click += new System.EventHandler(this.buttonUpdateStatus_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(22, 151);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 20);
			this.label1.TabIndex = 9;
			this.label1.Text = "任意のコマンド";
			// 
			// buttonInit
			// 
			this.buttonInit.BackgroundImage = global::ST_Server.Properties.Resources._1369992004_Positive;
			this.buttonInit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonInit.Location = new System.Drawing.Point(195, 18);
			this.buttonInit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonInit.Name = "buttonInit";
			this.buttonInit.Size = new System.Drawing.Size(160, 108);
			this.buttonInit.TabIndex = 12;
			this.buttonInit.Text = "クライアント初期化";
			this.buttonInit.UseVisualStyleBackColor = true;
			this.buttonInit.Click += new System.EventHandler(this.buttonInit_Click);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPageClients);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(544, 221);
			this.tabControl1.TabIndex = 19;
			// 
			// tabPageClients
			// 
			this.tabPageClients.Controls.Add(this.clientsSheet);
			this.tabPageClients.Location = new System.Drawing.Point(4, 29);
			this.tabPageClients.Margin = new System.Windows.Forms.Padding(4);
			this.tabPageClients.Name = "tabPageClients";
			this.tabPageClients.Padding = new System.Windows.Forms.Padding(4);
			this.tabPageClients.Size = new System.Drawing.Size(536, 188);
			this.tabPageClients.TabIndex = 0;
			this.tabPageClients.Text = "クライアント情報";
			this.tabPageClients.UseVisualStyleBackColor = true;
			// 
			// clientsSheet
			// 
			this.clientsSheet.AllowUserToAddRows = false;
			this.clientsSheet.AllowUserToDeleteRows = false;
			this.clientsSheet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.clientsSheet.Dock = System.Windows.Forms.DockStyle.Fill;
			this.clientsSheet.Location = new System.Drawing.Point(4, 4);
			this.clientsSheet.Margin = new System.Windows.Forms.Padding(4);
			this.clientsSheet.Name = "clientsSheet";
			this.clientsSheet.ReadOnly = true;
			this.clientsSheet.RowTemplate.Height = 21;
			this.clientsSheet.Size = new System.Drawing.Size(528, 180);
			this.clientsSheet.TabIndex = 0;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.textBoxLog);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
			this.tabPage2.Size = new System.Drawing.Size(536, 195);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "通信ログ";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// textBoxLog
			// 
			this.textBoxLog.BackColor = System.Drawing.Color.Black;
			this.textBoxLog.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxLog.Font = new System.Drawing.Font("Courier New", 9F);
			this.textBoxLog.ForeColor = System.Drawing.Color.LimeGreen;
			this.textBoxLog.Location = new System.Drawing.Point(4, 4);
			this.textBoxLog.Margin = new System.Windows.Forms.Padding(4);
			this.textBoxLog.Multiline = true;
			this.textBoxLog.Name = "textBoxLog";
			this.textBoxLog.ReadOnly = true;
			this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBoxLog.Size = new System.Drawing.Size(528, 180);
			this.textBoxLog.TabIndex = 2;
			// 
			// Form1
			// 
			this.AcceptButton = this.button1;
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.ClientSize = new System.Drawing.Size(544, 480);
			this.Controls.Add(this.splitContainer1);
			this.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.KeyPreview = true;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Form1";
			this.Text = "スポーツタイムマシン サーバーコンソール";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.tabControl2.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.tabPage4.ResumeLayout(false);
			this.tabPage4.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tabPageClients.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.clientsSheet)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button buttonPicture3;
		private System.Windows.Forms.Button buttonPicture2;
		private System.Windows.Forms.Button buttonPicture1;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Button buttonDepth;
		private System.Windows.Forms.Button buttonBlack;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonInit;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button buttonMirror;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPageClients;
		private System.Windows.Forms.DataGridView clientsSheet;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TextBox textBoxLog;
		private System.Windows.Forms.Button buttonUpdateStatus;
		private System.Windows.Forms.Button buttonStart;
		private System.Windows.Forms.Button buttonAbort;
		private System.Windows.Forms.TabControl tabControl2;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.Button buttonRestart;
	}
}


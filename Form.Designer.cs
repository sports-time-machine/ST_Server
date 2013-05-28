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
			this.buttonServer = new System.Windows.Forms.Button();
			this.buttonClient = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(197, 227);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "送信";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Visible = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(12, 202);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(260, 19);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "Hello World";
			this.textBox1.Visible = false;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// buttonServer
			// 
			this.buttonServer.Location = new System.Drawing.Point(12, 12);
			this.buttonServer.Name = "buttonServer";
			this.buttonServer.Size = new System.Drawing.Size(75, 23);
			this.buttonServer.TabIndex = 3;
			this.buttonServer.Text = "サーバー";
			this.buttonServer.UseVisualStyleBackColor = true;
			this.buttonServer.Click += new System.EventHandler(this.buttonServer_Click);
			// 
			// buttonClient
			// 
			this.buttonClient.Location = new System.Drawing.Point(197, 12);
			this.buttonClient.Name = "buttonClient";
			this.buttonClient.Size = new System.Drawing.Size(75, 23);
			this.buttonClient.TabIndex = 4;
			this.buttonClient.Text = "クライアント";
			this.buttonClient.UseVisualStyleBackColor = true;
			this.buttonClient.Click += new System.EventHandler(this.buttonClient_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.buttonClient);
			this.Controls.Add(this.buttonServer);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button buttonServer;
		private System.Windows.Forms.Button buttonClient;
	}
}


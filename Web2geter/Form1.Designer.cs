namespace Web2geter
{
	partial class form_Main
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
			this.tb_html = new System.Windows.Forms.TextBox();
			this.rtb_Main = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(397, 300);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "取得";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// tb_html
			// 
			this.tb_html.Location = new System.Drawing.Point(30, 300);
			this.tb_html.Name = "tb_html";
			this.tb_html.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.tb_html.Size = new System.Drawing.Size(343, 19);
			this.tb_html.TabIndex = 1;
			// 
			// rtb_Main
			// 
			this.rtb_Main.Location = new System.Drawing.Point(28, 10);
			this.rtb_Main.Multiline = true;
			this.rtb_Main.Name = "rtb_Main";
			this.rtb_Main.ReadOnly = true;
			this.rtb_Main.Size = new System.Drawing.Size(345, 270);
			this.rtb_Main.TabIndex = 2;
			this.rtb_Main.TextChanged += new System.EventHandler(this.rtb_Main_TextChanged);
			// 
			// form_Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(495, 353);
			this.Controls.Add(this.rtb_Main);
			this.Controls.Add(this.tb_html);
			this.Controls.Add(this.button1);
			this.Name = "form_Main";
			this.Text = "Webから取得";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox tb_html;
		private System.Windows.Forms.TextBox rtb_Main;
	}
}


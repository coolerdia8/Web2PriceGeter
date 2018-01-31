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
			this.Price1 = new System.Windows.Forms.TextBox();
			this.Del1 = new System.Windows.Forms.Button();
			this.labelURL = new System.Windows.Forms.Label();
			this.URL_Clear = new System.Windows.Forms.Button();
			this.Save1 = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(373, 84);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(52, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "取得";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// tb_html
			// 
			this.tb_html.Location = new System.Drawing.Point(23, 32);
			this.tb_html.Name = "tb_html";
			this.tb_html.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.tb_html.Size = new System.Drawing.Size(343, 19);
			this.tb_html.TabIndex = 1;
			// 
			// Price1
			// 
			this.Price1.Location = new System.Drawing.Point(194, 84);
			this.Price1.Multiline = true;
			this.Price1.Name = "Price1";
			this.Price1.ReadOnly = true;
			this.Price1.Size = new System.Drawing.Size(105, 23);
			this.Price1.TabIndex = 2;
			// 
			// Del1
			// 
			this.Del1.Location = new System.Drawing.Point(431, 84);
			this.Del1.Name = "Del1";
			this.Del1.Size = new System.Drawing.Size(52, 23);
			this.Del1.TabIndex = 3;
			this.Del1.Text = "Del";
			this.Del1.UseVisualStyleBackColor = true;
			this.Del1.Click += new System.EventHandler(this.Del1_Click);
			// 
			// labelURL
			// 
			this.labelURL.AutoSize = true;
			this.labelURL.ForeColor = System.Drawing.Color.DarkRed;
			this.labelURL.Location = new System.Drawing.Point(23, 14);
			this.labelURL.Name = "labelURL";
			this.labelURL.Size = new System.Drawing.Size(72, 12);
			this.labelURL.TabIndex = 4;
			this.labelURL.Text = "▼URLを入力";
			// 
			// URL_Clear
			// 
			this.URL_Clear.Location = new System.Drawing.Point(424, 30);
			this.URL_Clear.Name = "URL_Clear";
			this.URL_Clear.Size = new System.Drawing.Size(59, 23);
			this.URL_Clear.TabIndex = 5;
			this.URL_Clear.Text = "URLｸﾘｱ";
			this.URL_Clear.UseVisualStyleBackColor = true;
			this.URL_Clear.Click += new System.EventHandler(this.URL_Clear_Click);
			// 
			// Save1
			// 
			this.Save1.Location = new System.Drawing.Point(314, 84);
			this.Save1.Name = "Save1";
			this.Save1.Size = new System.Drawing.Size(52, 23);
			this.Save1.TabIndex = 6;
			this.Save1.Text = "Save";
			this.Save1.UseVisualStyleBackColor = true;
			this.Save1.Click += new System.EventHandler(this.Save1_Click);
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(25, 73);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(131, 20);
			this.comboBox1.TabIndex = 7;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// form_Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(495, 353);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.Save1);
			this.Controls.Add(this.URL_Clear);
			this.Controls.Add(this.labelURL);
			this.Controls.Add(this.Del1);
			this.Controls.Add(this.Price1);
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
		private System.Windows.Forms.TextBox Price1;
		private System.Windows.Forms.Button Del1;
		private System.Windows.Forms.Label labelURL;
		private System.Windows.Forms.Button URL_Clear;
		private System.Windows.Forms.Button Save1;
		private System.Windows.Forms.ComboBox comboBox1;
	}
}


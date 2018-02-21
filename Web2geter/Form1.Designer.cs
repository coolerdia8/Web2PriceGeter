namespace Web2geter
{
	partial class FormMain
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
            this.tb_html1 = new System.Windows.Forms.TextBox();
            this.Price1 = new System.Windows.Forms.TextBox();
            this.Del1 = new System.Windows.Forms.Button();
            this.labelURL = new System.Windows.Forms.Label();
            this.URL_Clear = new System.Windows.Forms.Button();
            this.Save1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.URLAdd = new System.Windows.Forms.Button();
            this.day1 = new System.Windows.Forms.Label();
            this.Name1 = new System.Windows.Forms.TextBox();
            this.URLSave = new System.Windows.Forms.Button();
            this.URLSet = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.OpenLog = new System.Windows.Forms.Button();
            this.GraphBtn = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
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
            // tb_html1
            // 
            this.tb_html1.Location = new System.Drawing.Point(23, 32);
            this.tb_html1.Name = "tb_html1";
            this.tb_html1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tb_html1.Size = new System.Drawing.Size(343, 19);
            this.tb_html1.TabIndex = 1;
            // 
            // Price1
            // 
            this.Price1.Location = new System.Drawing.Point(261, 84);
            this.Price1.Multiline = true;
            this.Price1.Name = "Price1";
            this.Price1.ReadOnly = true;
            this.Price1.Size = new System.Drawing.Size(105, 23);
            this.Price1.TabIndex = 2;
            this.Price1.Text = "ここに価格";
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
            this.URL_Clear.Location = new System.Drawing.Point(424, 12);
            this.URL_Clear.Name = "URL_Clear";
            this.URL_Clear.Size = new System.Drawing.Size(59, 23);
            this.URL_Clear.TabIndex = 5;
            this.URL_Clear.Text = "URLｸﾘｱ";
            this.URL_Clear.UseVisualStyleBackColor = true;
            this.URL_Clear.Click += new System.EventHandler(this.URL_Clear_Click);
            // 
            // Save1
            // 
            this.Save1.Location = new System.Drawing.Point(431, 113);
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
            this.comboBox1.Location = new System.Drawing.Point(25, 94);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(105, 20);
            this.comboBox1.TabIndex = 7;
            // 
            // URLAdd
            // 
            this.URLAdd.Location = new System.Drawing.Point(78, 57);
            this.URLAdd.Name = "URLAdd";
            this.URLAdd.Size = new System.Drawing.Size(52, 23);
            this.URLAdd.TabIndex = 8;
            this.URLAdd.Text = "↑追加";
            this.URLAdd.UseVisualStyleBackColor = true;
            this.URLAdd.Click += new System.EventHandler(this.URLadd_Click);
            // 
            // day1
            // 
            this.day1.AutoSize = true;
            this.day1.Location = new System.Drawing.Point(151, 94);
            this.day1.Name = "day1";
            this.day1.Size = new System.Drawing.Size(29, 12);
            this.day1.TabIndex = 10;
            this.day1.Text = "日時";
            // 
            // Name1
            // 
            this.Name1.Location = new System.Drawing.Point(261, 115);
            this.Name1.Name = "Name1";
            this.Name1.Size = new System.Drawing.Size(134, 19);
            this.Name1.TabIndex = 11;
            // 
            // URLSave
            // 
            this.URLSave.Font = new System.Drawing.Font("MS UI Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.URLSave.Location = new System.Drawing.Point(424, 41);
            this.URLSave.Name = "URLSave";
            this.URLSave.Size = new System.Drawing.Size(59, 23);
            this.URLSave.TabIndex = 12;
            this.URLSave.Text = "URLSave";
            this.URLSave.UseVisualStyleBackColor = true;
            this.URLSave.Click += new System.EventHandler(this.URLSave_Click);
            // 
            // URLSet
            // 
            this.URLSet.Location = new System.Drawing.Point(60, 121);
            this.URLSet.Name = "URLSet";
            this.URLSet.Size = new System.Drawing.Size(70, 23);
            this.URLSet.TabIndex = 13;
            this.URLSet.Text = "URL読込";
            this.URLSet.UseVisualStyleBackColor = true;
            this.URLSet.Click += new System.EventHandler(this.URLSet_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(261, 186);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 14;
            // 
            // OpenLog
            // 
            this.OpenLog.Location = new System.Drawing.Point(408, 142);
            this.OpenLog.Name = "OpenLog";
            this.OpenLog.Size = new System.Drawing.Size(75, 23);
            this.OpenLog.TabIndex = 15;
            this.OpenLog.Text = "ログ確認";
            this.OpenLog.UseVisualStyleBackColor = true;
            this.OpenLog.Click += new System.EventHandler(this.OpenLog_Click);
            // 
            // GraphBtn
            // 
            this.GraphBtn.Location = new System.Drawing.Point(408, 186);
            this.GraphBtn.Name = "GraphBtn";
            this.GraphBtn.Size = new System.Drawing.Size(75, 23);
            this.GraphBtn.TabIndex = 16;
            this.GraphBtn.Text = "グラフ表示";
            this.GraphBtn.UseVisualStyleBackColor = true;
            this.GraphBtn.Click += new System.EventHandler(this.GraphBtn_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(431, 318);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(52, 23);
            this.Exit.TabIndex = 17;
            this.Exit.Text = "終了";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 353);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.GraphBtn);
            this.Controls.Add(this.OpenLog);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.URLSet);
            this.Controls.Add(this.URLSave);
            this.Controls.Add(this.Name1);
            this.Controls.Add(this.day1);
            this.Controls.Add(this.URLAdd);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Save1);
            this.Controls.Add(this.URL_Clear);
            this.Controls.Add(this.labelURL);
            this.Controls.Add(this.Del1);
            this.Controls.Add(this.Price1);
            this.Controls.Add(this.tb_html1);
            this.Controls.Add(this.button1);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Webから取得";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox tb_html1;
		private System.Windows.Forms.TextBox Price1;
		private System.Windows.Forms.Button Del1;
		private System.Windows.Forms.Label labelURL;
		private System.Windows.Forms.Button URL_Clear;
		private System.Windows.Forms.Button Save1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button URLAdd;
		private System.Windows.Forms.Label day1;
		private System.Windows.Forms.TextBox Name1;
        private System.Windows.Forms.Button URLSave;
        private System.Windows.Forms.Button URLSet;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button OpenLog;
        private System.Windows.Forms.Button GraphBtn;
        private System.Windows.Forms.Button Exit;
    }
}


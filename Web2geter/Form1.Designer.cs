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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
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
            this.GraphBtn = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Sort = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
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
            this.tb_html1.Location = new System.Drawing.Point(12, 54);
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
            this.labelURL.Location = new System.Drawing.Point(23, 30);
            this.labelURL.Name = "labelURL";
            this.labelURL.Size = new System.Drawing.Size(72, 12);
            this.labelURL.TabIndex = 4;
            this.labelURL.Text = "▼URLを入力";
            // 
            // URL_Clear
            // 
            this.URL_Clear.Location = new System.Drawing.Point(366, 50);
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
            this.comboBox1.Location = new System.Drawing.Point(25, 113);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(105, 20);
            this.comboBox1.TabIndex = 7;
            // 
            // URLAdd
            // 
            this.URLAdd.Location = new System.Drawing.Point(78, 79);
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
            this.day1.Location = new System.Drawing.Point(151, 84);
            this.day1.Name = "day1";
            this.day1.Size = new System.Drawing.Size(29, 12);
            this.day1.TabIndex = 10;
            this.day1.Text = "日時";
            // 
            // Name1
            // 
            this.Name1.Location = new System.Drawing.Point(261, 115);
            this.Name1.Name = "Name1";
            this.Name1.ReadOnly = true;
            this.Name1.Size = new System.Drawing.Size(134, 19);
            this.Name1.TabIndex = 11;
            this.Name1.Text = "ここにホテル名表示";
            // 
            // URLSave
            // 
            this.URLSave.Font = new System.Drawing.Font("MS UI Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.URLSave.Location = new System.Drawing.Point(431, 50);
            this.URLSave.Name = "URLSave";
            this.URLSave.Size = new System.Drawing.Size(59, 23);
            this.URLSave.TabIndex = 12;
            this.URLSave.Text = "URLSave";
            this.URLSave.UseVisualStyleBackColor = true;
            this.URLSave.Click += new System.EventHandler(this.URLSave_Click);
            // 
            // URLSet
            // 
            this.URLSet.Location = new System.Drawing.Point(60, 142);
            this.URLSet.Name = "URLSet";
            this.URLSet.Size = new System.Drawing.Size(70, 23);
            this.URLSet.TabIndex = 13;
            this.URLSet.Text = "URL読込";
            this.URLSet.UseVisualStyleBackColor = true;
            this.URLSet.Click += new System.EventHandler(this.URLSet_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(30, 300);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 14;
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
            this.Exit.Location = new System.Drawing.Point(431, 305);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(52, 23);
            this.Exit.TabIndex = 17;
            this.Exit.Text = "終了";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Sort
            // 
            this.Sort.Location = new System.Drawing.Point(320, 186);
            this.Sort.Name = "Sort";
            this.Sort.Size = new System.Drawing.Size(75, 23);
            this.Sort.TabIndex = 18;
            this.Sort.Text = "MIN/MAX";
            this.Sort.UseVisualStyleBackColor = true;
            this.Sort.Click += new System.EventHandler(this.Sort_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 330);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(495, 23);
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(56, 18);
            this.toolStripStatusLabel1.Text = "準備完了";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(495, 26);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(57, 22);
            this.toolStripMenuItem1.Text = "File(&F)";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(54, 22);
            this.toolStripMenuItem2.Text = "Log(&l)";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 26);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(495, 25);
            this.toolStrip1.TabIndex = 22;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 22);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 353);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Sort);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.GraphBtn);
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
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Webから取得";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
        private System.Windows.Forms.Button GraphBtn;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Sort;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
    }
}


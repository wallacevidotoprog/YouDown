namespace YouDown
{
	partial class YouDown
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YouDown));
			this.textBox_URL = new System.Windows.Forms.TextBox();
			this.label_duracao = new System.Windows.Forms.Label();
			this.radioButton_MP4 = new System.Windows.Forms.RadioButton();
			this.radioButton_MP3 = new System.Windows.Forms.RadioButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.progressBar = new System.Windows.Forms.ProgressBar();
			this.richTextBox_DESC = new System.Windows.Forms.RichTextBox();
			this.pictureBox_IMG = new System.Windows.Forms.PictureBox();
			this.label_canal = new System.Windows.Forms.Label();
			this.label_tite_canal = new System.Windows.Forms.Label();
			this.pictureBox_verificar = new System.Windows.Forms.PictureBox();
			this.toolTip_titulo = new System.Windows.Forms.ToolTip(this.components);
			this.toolTip_C2 = new System.Windows.Forms.ToolTip(this.components);
			this.panel2 = new System.Windows.Forms.Panel();
			this.pictureBox_download = new System.Windows.Forms.PictureBox();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.button1 = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_IMG)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_verificar)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_download)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox_URL
			// 
			this.textBox_URL.BackColor = System.Drawing.Color.DimGray;
			this.textBox_URL.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox_URL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_URL.ForeColor = System.Drawing.Color.White;
			this.textBox_URL.Location = new System.Drawing.Point(3, 3);
			this.textBox_URL.Multiline = true;
			this.textBox_URL.Name = "textBox_URL";
			this.textBox_URL.Size = new System.Drawing.Size(271, 20);
			this.textBox_URL.TabIndex = 1;
			this.textBox_URL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label_duracao
			// 
			this.label_duracao.AutoSize = true;
			this.label_duracao.BackColor = System.Drawing.Color.Black;
			this.label_duracao.ForeColor = System.Drawing.Color.White;
			this.label_duracao.Location = new System.Drawing.Point(3, 196);
			this.label_duracao.Name = "label_duracao";
			this.label_duracao.Size = new System.Drawing.Size(34, 13);
			this.label_duracao.TabIndex = 2;
			this.label_duracao.Text = "00:00";
			// 
			// radioButton_MP4
			// 
			this.radioButton_MP4.Appearance = System.Windows.Forms.Appearance.Button;
			this.radioButton_MP4.AutoSize = true;
			this.radioButton_MP4.BackColor = System.Drawing.Color.DimGray;
			this.radioButton_MP4.Cursor = System.Windows.Forms.Cursors.Hand;
			this.radioButton_MP4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
			this.radioButton_MP4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.radioButton_MP4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButton_MP4.ForeColor = System.Drawing.Color.Black;
			this.radioButton_MP4.Location = new System.Drawing.Point(104, 7);
			this.radioButton_MP4.Name = "radioButton_MP4";
			this.radioButton_MP4.Size = new System.Drawing.Size(99, 51);
			this.radioButton_MP4.TabIndex = 4;
			this.radioButton_MP4.Text = "MP4";
			this.radioButton_MP4.UseVisualStyleBackColor = false;
			// 
			// radioButton_MP3
			// 
			this.radioButton_MP3.Appearance = System.Windows.Forms.Appearance.Button;
			this.radioButton_MP3.AutoSize = true;
			this.radioButton_MP3.BackColor = System.Drawing.Color.DimGray;
			this.radioButton_MP3.Checked = true;
			this.radioButton_MP3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.radioButton_MP3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
			this.radioButton_MP3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.radioButton_MP3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButton_MP3.ForeColor = System.Drawing.Color.Black;
			this.radioButton_MP3.Location = new System.Drawing.Point(1, 7);
			this.radioButton_MP3.Name = "radioButton_MP3";
			this.radioButton_MP3.Size = new System.Drawing.Size(99, 51);
			this.radioButton_MP3.TabIndex = 4;
			this.radioButton_MP3.TabStop = true;
			this.radioButton_MP3.Text = "MP3";
			this.radioButton_MP3.UseVisualStyleBackColor = false;
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.progressBar);
			this.panel1.Controls.Add(this.richTextBox_DESC);
			this.panel1.Controls.Add(this.label_duracao);
			this.panel1.Controls.Add(this.textBox_URL);
			this.panel1.Controls.Add(this.pictureBox_IMG);
			this.panel1.Controls.Add(this.label_canal);
			this.panel1.Controls.Add(this.label_tite_canal);
			this.panel1.Controls.Add(this.pictureBox_verificar);
			this.panel1.Location = new System.Drawing.Point(3, 6);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(323, 309);
			this.panel1.TabIndex = 6;
			// 
			// progressBar
			// 
			this.progressBar.Location = new System.Drawing.Point(38, 199);
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(280, 10);
			this.progressBar.TabIndex = 8;
			this.progressBar.Visible = false;
			// 
			// richTextBox_DESC
			// 
			this.richTextBox_DESC.Location = new System.Drawing.Point(1, 229);
			this.richTextBox_DESC.Name = "richTextBox_DESC";
			this.richTextBox_DESC.ReadOnly = true;
			this.richTextBox_DESC.Size = new System.Drawing.Size(317, 72);
			this.richTextBox_DESC.TabIndex = 7;
			this.richTextBox_DESC.Text = "DESCRIÇÃO";
			// 
			// pictureBox_IMG
			// 
			this.pictureBox_IMG.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.pictureBox_IMG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox_IMG.Location = new System.Drawing.Point(3, 57);
			this.pictureBox_IMG.Name = "pictureBox_IMG";
			this.pictureBox_IMG.Size = new System.Drawing.Size(317, 152);
			this.pictureBox_IMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox_IMG.TabIndex = 5;
			this.pictureBox_IMG.TabStop = false;
			// 
			// label_canal
			// 
			this.label_canal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_canal.Location = new System.Drawing.Point(3, 212);
			this.label_canal.Name = "label_canal";
			this.label_canal.Size = new System.Drawing.Size(317, 13);
			this.label_canal.TabIndex = 2;
			this.label_canal.Text = "CANAL:";
			// 
			// label_tite_canal
			// 
			this.label_tite_canal.AutoEllipsis = true;
			this.label_tite_canal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_tite_canal.Location = new System.Drawing.Point(3, 30);
			this.label_tite_canal.Name = "label_tite_canal";
			this.label_tite_canal.Size = new System.Drawing.Size(315, 24);
			this.label_tite_canal.TabIndex = 2;
			this.label_tite_canal.Text = "TÍTULO";
			this.label_tite_canal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBox_verificar
			// 
			this.pictureBox_verificar.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.pictureBox_verificar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox_verificar.Image = global::YouDown.Properties.Resources.buscar;
			this.pictureBox_verificar.Location = new System.Drawing.Point(278, 3);
			this.pictureBox_verificar.Name = "pictureBox_verificar";
			this.pictureBox_verificar.Size = new System.Drawing.Size(40, 20);
			this.pictureBox_verificar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox_verificar.TabIndex = 3;
			this.pictureBox_verificar.TabStop = false;
			this.pictureBox_verificar.Click += new System.EventHandler(this.pictureBox_verificar_Click);
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.pictureBox_download);
			this.panel2.Controls.Add(this.radioButton_MP4);
			this.panel2.Controls.Add(this.radioButton_MP3);
			this.panel2.Location = new System.Drawing.Point(3, 321);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(323, 65);
			this.panel2.TabIndex = 7;
			// 
			// pictureBox_download
			// 
			this.pictureBox_download.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox_download.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox_download.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox_download.Image = global::YouDown.Properties.Resources.download;
			this.pictureBox_download.Location = new System.Drawing.Point(207, 7);
			this.pictureBox_download.Name = "pictureBox_download";
			this.pictureBox_download.Size = new System.Drawing.Size(111, 50);
			this.pictureBox_download.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox_download.TabIndex = 3;
			this.pictureBox_download.TabStop = false;
			this.pictureBox_download.Click += new System.EventHandler(this.pictureBox_download_Click);
			// 
			// backgroundWorker1
			// 
			this.backgroundWorker1.WorkerReportsProgress = true;
			this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
			this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
			this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(207, 253);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 9;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// YouDown
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(329, 391);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.ForeColor = System.Drawing.Color.White;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "YouDown";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "YouDown";
			this.Load += new System.EventHandler(this.YouDown_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_IMG)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_verificar)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_download)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.TextBox textBox_URL;
		private System.Windows.Forms.Label label_duracao;
		private System.Windows.Forms.PictureBox pictureBox_verificar;
		private System.Windows.Forms.PictureBox pictureBox_download;
		private System.Windows.Forms.RadioButton radioButton_MP4;
		private System.Windows.Forms.RadioButton radioButton_MP3;
		private System.Windows.Forms.PictureBox pictureBox_IMG;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RichTextBox richTextBox_DESC;
		private System.Windows.Forms.Label label_tite_canal;
		private System.Windows.Forms.Label label_canal;
		private System.Windows.Forms.ToolTip toolTip_titulo;
		private System.Windows.Forms.ToolTip toolTip_C2;
		private System.Windows.Forms.Panel panel2;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.ProgressBar progressBar;
		private System.Windows.Forms.Button button1;
	}
}


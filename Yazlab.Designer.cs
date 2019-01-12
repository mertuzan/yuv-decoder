namespace Yazlab
{
	partial class Yazlab
	{
		/// <summary>
		///Gerekli tasarımcı değişkeni.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///Kullanılan tüm kaynakları temizleyin.
		/// </summary>
		///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer üretilen kod

		/// <summary>
		/// Tasarımcı desteği için gerekli metot - bu metodun 
		///içeriğini kod düzenleyici ile değiştirmeyin.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Yazlab));
			this.Settings = new System.Windows.Forms.TabPage();
			this.label4 = new System.Windows.Forms.Label();
			this.format = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.height_ = new System.Windows.Forms.TextBox();
			this.width_ = new System.Windows.Forms.TextBox();
			this.Converter = new System.Windows.Forms.TabPage();
			this.label5 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.save = new System.Windows.Forms.Button();
			this.open = new System.Windows.Forms.Button();
			this.picture = new System.Windows.Forms.PictureBox();
			this.convert = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.Player = new System.Windows.Forms.TabPage();
			this.label6 = new System.Windows.Forms.Label();
			this.play = new System.Windows.Forms.Button();
			this.pictureplayer = new System.Windows.Forms.PictureBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.Settings.SuspendLayout();
			this.Converter.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.Player.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureplayer)).BeginInit();
			this.SuspendLayout();
			// 
			// Settings
			// 
			this.Settings.Controls.Add(this.label4);
			this.Settings.Controls.Add(this.format);
			this.Settings.Controls.Add(this.label3);
			this.Settings.Controls.Add(this.label2);
			this.Settings.Controls.Add(this.height_);
			this.Settings.Controls.Add(this.width_);
			this.Settings.Location = new System.Drawing.Point(4, 22);
			this.Settings.Name = "Settings";
			this.Settings.Size = new System.Drawing.Size(839, 645);
			this.Settings.TabIndex = 2;
			this.Settings.Text = "Settings";
			this.Settings.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(31, 119);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(39, 13);
			this.label4.TabIndex = 15;
			this.label4.Text = "Format";
			// 
			// format
			// 
			this.format.FormattingEnabled = true;
			this.format.Items.AddRange(new object[] {
            "4:2:0",
            "4:2:2",
            "4:4:4"});
			this.format.Location = new System.Drawing.Point(34, 135);
			this.format.Name = "format";
			this.format.Size = new System.Drawing.Size(121, 21);
			this.format.TabIndex = 14;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(31, 66);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(38, 13);
			this.label3.TabIndex = 13;
			this.label3.Text = "Height";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(31, 17);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 12;
			this.label2.Text = "Width";
			// 
			// height_
			// 
			this.height_.Location = new System.Drawing.Point(34, 82);
			this.height_.Name = "height_";
			this.height_.Size = new System.Drawing.Size(75, 20);
			this.height_.TabIndex = 11;
			// 
			// width_
			// 
			this.width_.Location = new System.Drawing.Point(34, 33);
			this.width_.Name = "width_";
			this.width_.Size = new System.Drawing.Size(75, 20);
			this.width_.TabIndex = 10;
			// 
			// Converter
			// 
			this.Converter.Controls.Add(this.label5);
			this.Converter.Controls.Add(this.label7);
			this.Converter.Controls.Add(this.label1);
			this.Converter.Controls.Add(this.save);
			this.Converter.Controls.Add(this.open);
			this.Converter.Controls.Add(this.picture);
			this.Converter.Controls.Add(this.convert);
			this.Converter.Location = new System.Drawing.Point(4, 22);
			this.Converter.Name = "Converter";
			this.Converter.Padding = new System.Windows.Forms.Padding(3);
			this.Converter.Size = new System.Drawing.Size(839, 645);
			this.Converter.TabIndex = 0;
			this.Converter.Text = "Converter";
			this.Converter.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
			this.label5.Location = new System.Drawing.Point(3, 62);
			this.label5.MaximumSize = new System.Drawing.Size(24, 24);
			this.label5.MinimumSize = new System.Drawing.Size(24, 24);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(24, 24);
			this.label5.TabIndex = 9;
			this.label5.Text = "     ";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
			this.label7.Location = new System.Drawing.Point(3, 106);
			this.label7.MaximumSize = new System.Drawing.Size(24, 24);
			this.label7.MinimumSize = new System.Drawing.Size(24, 24);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(24, 24);
			this.label7.TabIndex = 8;
			this.label7.Text = "     ";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
			this.label1.Location = new System.Drawing.Point(3, 19);
			this.label1.MaximumSize = new System.Drawing.Size(24, 24);
			this.label1.MinimumSize = new System.Drawing.Size(24, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(24, 24);
			this.label1.TabIndex = 5;
			this.label1.Text = "     ";
			// 
			// save
			// 
			this.save.AccessibleName = "";
			this.save.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.save.Location = new System.Drawing.Point(36, 106);
			this.save.Name = "save";
			this.save.Size = new System.Drawing.Size(76, 24);
			this.save.TabIndex = 4;
			this.save.Text = "Save BMP";
			this.save.UseVisualStyleBackColor = true;
			this.save.Click += new System.EventHandler(this.save_Click);
			// 
			// open
			// 
			this.open.Location = new System.Drawing.Point(36, 20);
			this.open.Name = "open";
			this.open.Size = new System.Drawing.Size(76, 23);
			this.open.TabIndex = 1;
			this.open.Text = "Open File";
			this.open.UseVisualStyleBackColor = true;
			this.open.Click += new System.EventHandler(this.open_Click);
			// 
			// picture
			// 
			this.picture.Location = new System.Drawing.Point(122, 20);
			this.picture.Name = "picture";
			this.picture.Size = new System.Drawing.Size(710, 618);
			this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.picture.TabIndex = 3;
			this.picture.TabStop = false;
			// 
			// convert
			// 
			this.convert.Location = new System.Drawing.Point(36, 63);
			this.convert.Name = "convert";
			this.convert.Size = new System.Drawing.Size(76, 23);
			this.convert.TabIndex = 0;
			this.convert.Text = "Convert";
			this.convert.UseVisualStyleBackColor = true;
			this.convert.Click += new System.EventHandler(this.convert_Click);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.Converter);
			this.tabControl1.Controls.Add(this.Player);
			this.tabControl1.Controls.Add(this.Settings);
			this.tabControl1.Location = new System.Drawing.Point(3, 2);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(847, 671);
			this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
			this.tabControl1.TabIndex = 6;
			// 
			// Player
			// 
			this.Player.Controls.Add(this.label6);
			this.Player.Controls.Add(this.play);
			this.Player.Controls.Add(this.pictureplayer);
			this.Player.Location = new System.Drawing.Point(4, 22);
			this.Player.Name = "Player";
			this.Player.Padding = new System.Windows.Forms.Padding(3);
			this.Player.Size = new System.Drawing.Size(839, 645);
			this.Player.TabIndex = 1;
			this.Player.Text = "Player";
			this.Player.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
			this.label6.Location = new System.Drawing.Point(5, 19);
			this.label6.MaximumSize = new System.Drawing.Size(24, 24);
			this.label6.MinimumSize = new System.Drawing.Size(24, 24);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(24, 24);
			this.label6.TabIndex = 6;
			this.label6.Text = "     ";
			// 
			// play
			// 
			this.play.Location = new System.Drawing.Point(36, 19);
			this.play.Name = "play";
			this.play.Size = new System.Drawing.Size(67, 23);
			this.play.TabIndex = 1;
			this.play.Text = "Play";
			this.play.UseVisualStyleBackColor = true;
			this.play.Click += new System.EventHandler(this.play_Click);
			// 
			// pictureplayer
			// 
			this.pictureplayer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureplayer.Location = new System.Drawing.Point(109, 7);
			this.pictureplayer.Name = "pictureplayer";
			this.pictureplayer.Size = new System.Drawing.Size(724, 632);
			this.pictureplayer.TabIndex = 0;
			this.pictureplayer.TabStop = false;
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// Yazlab
			// 
			this.ClientSize = new System.Drawing.Size(853, 674);
			this.Controls.Add(this.tabControl1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Yazlab";
			this.Text = "YUV to BMP";
			this.Settings.ResumeLayout(false);
			this.Settings.PerformLayout();
			this.Converter.ResumeLayout(false);
			this.Converter.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.Player.ResumeLayout(false);
			this.Player.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureplayer)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabPage Settings;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox format;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox height_;
		private System.Windows.Forms.TextBox width_;
		private System.Windows.Forms.TabPage Converter;
		private System.Windows.Forms.Button save;
		private System.Windows.Forms.Button open;
		private System.Windows.Forms.PictureBox picture;
		private System.Windows.Forms.Button convert;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage Player;
		private System.Windows.Forms.Button play;
		private System.Windows.Forms.PictureBox pictureplayer;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label6;
	}
}


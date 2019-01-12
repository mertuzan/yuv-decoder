using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace Yazlab
{
	public partial class Yazlab : Form
	{

		public Yazlab()
		{
			InitializeComponent();
		}

		OpenFileDialog of = new OpenFileDialog();
		Bitmap[] frames;
		byte[] r;
		byte[] g;
		byte[] b;
		Bitmap bmp;
		static int width;
		static int height;
		long length;
		int count_of_frames;
		int timer_counter = 0;
		int frame_counter = 0;
		int frame_display_count = 0;
		double size_multiplier;
		int imgSize;
		byte[] tmp = new byte[1];
		byte[] y;
		byte[] u;
		byte[] v;

		void yuv()
		{
			FileStream fs = File.OpenRead(of.FileName);
			BinaryReader br = new BinaryReader(fs);
			int size = (int)(imgSize * size_multiplier);

			for (int frame = 0; frame < count_of_frames; frame++)
			{
				for (int i = 0; i < size; i++)
				{
					if (i < size / size_multiplier)
						y[i] = br.ReadByte();
					else
						tmp[0] = br.ReadByte();

				}
				yuv2rgb(y, u, v, imgSize);
				rgb2bmp();
				Console.WriteLine("Frame#" + frame + " converted");
			}
			Console.WriteLine("All frames converted.");
		}


		private void convert_Click(object sender, EventArgs e)
		{

			frame_counter = 0;
			length = new System.IO.FileInfo(of.FileName).Length;
			width = Int32.Parse(width_.Text);
			height = Int32.Parse(height_.Text);
			imgSize = width * height;
			y = new byte[imgSize];
			u = new byte[imgSize];
			v = new byte[imgSize];
			r = new byte[imgSize];
			g = new byte[imgSize];
			b = new byte[imgSize];

			if (format.Text.Equals("4:2:0"))
			{
				size_multiplier = 1.5;
				count_of_frames = (int)(length / (float)(width * height * 1.5));
				Console.WriteLine(count_of_frames + " frames");
				frames = new Bitmap[count_of_frames];
				yuv();
			}
			else if (format.Text.Equals("4:2:2"))
			{
				size_multiplier = 2;
				count_of_frames = (int)(length / (float)(width * height * 2));
				frames = new Bitmap[count_of_frames];
				yuv();
			}
			else if (format.Text.Equals("4:4:4"))
			{
				size_multiplier = 3;
				count_of_frames = (int)(length / (float)(width * height * 3));
				frames = new Bitmap[count_of_frames];
				yuv();
			}
		}

		void rgb2bmp()
		{
			Bitmap bmp_ = new Bitmap(width, height);
			int i = 0;
			for (int y = 0; y < height; y++)
			{
				for (int x = 0; x < width; x++)
				{
					bmp_.SetPixel(x, y, Color.FromArgb(255, r[i], g[i], b[i]));
					i++;
				}
			}
			picture.Image = bmp_;
			frames[frame_counter] = bmp_;
			frame_counter++;
		}

		void yuv2rgb(byte[] y, byte[] u, byte[] v, int size)
		{
			for (int i = 0; i < size; i++)
			{
				r[i] = (byte)(1.164 * (y[i] - 16));
				g[i] = (byte)(1.164 * (y[i] - 16));
				b[i] = (byte)(1.164 * (y[i] - 16));
			}
		}
		private void open_Click(object sender, EventArgs e)
		{
			of.ShowDialog();
		}
		void save_()
		{
			for (int i = 0; i < frame_counter; i++)
			{
				frames[i].Save("frame" + frame_display_count + ".bmp", ImageFormat.Bmp);
				frame_display_count++;
			}
			Console.WriteLine("Saved.");
		}
		private void save_Click(object sender, EventArgs e)
		{
			frame_display_count = 0;
			save_();
		}

		private void play_Click(object sender, EventArgs e)
		{
			timer1.Start();
			frame_display_count = count_of_frames;

		}
		Bitmap bmp_;

		private void timer_Tick(object sender, EventArgs e)
		{
			pictureplayer.SizeMode = PictureBoxSizeMode.CenterImage;
			if (timer_counter == frame_display_count)
			{
				timer1.Stop();
				timer_counter = 0;
				bmp_ = new Bitmap(@"logo.bmp");
				pictureplayer.Image = bmp_;

			}
			else
			{
				//KAYDEDILMIS BMPLERI GÖSTERMEK ICIN
				//String file = "frame" + timer_counter + ".bmp";
				bmp_ = new Bitmap(frames[timer_counter]);//@"" + file
				pictureplayer.Image = bmp_;
				timer_counter++;
			}
		}
	}
}

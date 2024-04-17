using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExplode;
using VideoLibrary;
using MediaToolkit.Model;
using MediaToolkit;
using System.IO;
using System.ComponentModel;
using System.Collections.Generic;
using System.Threading;
using YoutubeExtractor;
using System.Linq;
using YoutubeExplode.Videos.Streams;

namespace YouDown
{
	public partial class YouDown : Form
	{
		public YouDown()
		{
			InitializeComponent();
			backgroundWorker1.WorkerReportsProgress = true;
			backgroundWorker1.WorkerSupportsCancellation = true;
		}
		bool AUTORIZADO;
		string SALVE = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\";
		string SALVE_temp = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos) + @"\";
		string ID_VIDEO; string NOME_VIDEO;

		async Task VERIFICAR()
		{
			try
			{
				var youtube = new YoutubeClient();

				// Você pode especificar o ID do vídeo ou o URL 
				var video = await youtube.Videos.GetAsync(textBox_URL.Text);

				var title = video.Title; // "Collections - Blender 2.80 Fundamentals"
				var author = video.Author.Title; NOME_VIDEO = video.Title;
				var duration = video.Duration;

				var ID = video.Id; ID_VIDEO = video.Id;
				var UploadDate = video.UploadDate;
				var Description = video.Description;
				var Keywords = video.Keywords;
				var Engagement = video.Engagement;
				var Thumbnails = video.Thumbnails;// 00:07:20

				toolTip_titulo.SetToolTip(label_tite_canal, title);

				label_tite_canal.Text = String.Format("{0}  ", title);
				label_canal.Text = String.Format("CANAL: {0} | LIKE:{1} | DISLIKE:{2}", author, Engagement.LikeCount, Engagement.DislikeCount);
				toolTip_C2.SetToolTip(label_canal, label_canal.Text);
				label_duracao.Text = String.Format("DURAÇÃO: {0}", Convert.ToString(duration));
				richTextBox_DESC.Text = Description;

				pictureBox_IMG.Load("https://img.youtube.com/vi/" + ID + "/0.jpg");

				if (title != string.Empty && author != string.Empty)
				{
					AUTORIZADO = true;
				}
				MessageBox.Show("Vídeo Verificado.");
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}

		}

		void Download(string URL)
		{
			try
			{
				var youTube = YouTube.Default;
				var video = youTube.GetVideo(URL);

				pictureBox_download.Image = Properties.Resources._5FRc;


				if (radioButton_MP3.Checked == true)
				{

					System.IO.File.WriteAllBytes(SALVE_temp + video.FullName, video.GetBytes());


					var inputFile = new MediaFile { Filename = SALVE_temp + video.FullName };
					var outputFile = new MediaFile { Filename = $"{SALVE + video.FullName.Replace(".mp4", "")}.mp3" };


					using (var engine = new Engine())
					{
						engine.GetMetadata(inputFile);

						engine.Convert(inputFile, outputFile);
					}
					File.Delete(SALVE + video.FullName);
					MessageBox.Show("Download Realizado com Sucesso.");


				}

			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}
			finally
			{
				pictureBox_download.Image = Properties.Resources.download;
			}



		}

		private void pictureBox_verificar_Click(object sender, EventArgs e)
		{
			VERIFICAR();
		}

		private void pictureBox_download_Click(object sender, EventArgs e)
		{
			if (AUTORIZADO == true)
			{



				if (backgroundWorker1.IsBusy != true)
				{

					backgroundWorker1.RunWorkerAsync();
				}
				else
				{
					MessageBox.Show("Download iniciado.\nAguarde.....");
				}
			}
			else
			{
				MessageBox.Show("Clique em Verificar para fazer o Download");
			}

		}

		private void YouDown_Load(object sender, EventArgs e)
		{

		}

		private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
		{


			if (radioButton_MP3.Checked == true)
			{
				Download(textBox_URL.Text);
			}
			if (radioButton_MP4.Checked == true)
			{
				XXAsync();
			}
		}

		private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
		{
			this.Text = "YouDown " + (e.ProgressPercentage.ToString() + " % ");
			label_tite_canal.Text = (e.ProgressPercentage.ToString() + "%");


		}

		private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
		{
			this.Text = "YouDown";
		}

		async Task XXAsync()
		{
			if (AUTORIZADO = true)
			{
				try
				{
					pictureBox_download.Image = Properties.Resources._5FRc;

					var youtube = new YoutubeClient();

					var streamManifest = await youtube.Videos.Streams.GetManifestAsync(ID_VIDEO);


					// Get highest quality muxed stream
					var streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();

					var stream = await youtube.Videos.Streams.GetAsync(streamInfo);

					// Download the stream to a file
					await youtube.Videos.Streams.DownloadAsync(streamInfo, SALVE + NOME_VIDEO + "." + streamInfo.Container);
					MessageBox.Show("Download Realizado com Sucesso.");
				}
				catch (Exception ex)
				{
					pictureBox_download.Image = Properties.Resources.download;

					MessageBox.Show("" + ex);
				}
				finally
				{
					pictureBox_download.Image = Properties.Resources.download;
				}

			}


		}



		private void Downloader_DownloadProgressChanged(object sender, ProgressEventArgs e)
		{
			//Update progressbar
			Invoke(new MethodInvoker(delegate ()
			{
				progressBar.Value = (int)e.ProgressPercentage;
				//lblPercentage.Text = $"{string.Format("{0:0.##}", e.ProgressPercentage)}%";//C# 6.0
				progressBar.Update();
			}));
		}

		private void button1_Click(object sender, EventArgs e)
		{
			XAsync();
		}



		async Task XAsync()
		{
			var youtube = new YoutubeClient();

			var streamManifest = await youtube.Videos.Streams.GetManifestAsync(ID_VIDEO);


			// Get highest quality muxed stream
			var streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();

			var stream = await youtube.Videos.Streams.GetAsync(streamInfo);

			// Download the stream to a file
			await youtube.Videos.Streams.DownloadAsync(streamInfo, SALVE + NOME_VIDEO + "." + streamInfo.Container);
		}
		



	}



	
}

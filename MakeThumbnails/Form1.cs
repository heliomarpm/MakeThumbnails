using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace MakeThumbnails
{
    public partial class Form1 : Form
    {
        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);

        [DllImport("User32.dll")]
        private static extern IntPtr GetWindowDC(IntPtr hWnd);
        protected override void WndProc(ref System.Windows.Forms.Message m)
        {
            const int WM_NCPAINT = 0x85;
            base.WndProc(ref m);

            if (m.Msg == WM_NCPAINT)
            {

                IntPtr hdc = GetWindowDC(m.HWnd);
                if ((int)hdc != 0)
                {
                    Graphics g = Graphics.FromHdc(hdc);
                    g.DrawLine(Pens.Red, 10, 10, 100, 10);
                    g.Flush();
                    ReleaseDC(m.HWnd, hdc);
                }

            }

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPathOrigem_Click(object sender, EventArgs e)
        {
            var dlg = openFileDialog1;

            dlg.Filter = "Jpg|*.jpeg|JPeg|*.jpeg|Png|*.png|Gif|*.gif|Bitmap|*.bmp";
            var result = dlg.ShowDialog();

            if (result == DialogResult.OK)
            {
                txtPathOrigem.Text = dlg.FileName;
            }
        }

        private void btnPathDestino_Click(object sender, EventArgs e)
        {
            var result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                txtPathDestino.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblMsg.Text = string.Empty;
            txtPathOrigem.Width = 621;
            rdbPorcent.Checked = true;

            chkManterTamanho.Checked = true;
        }

        private void btnProcessar_Click(object sender, EventArgs e)
        {
            btnProcessar.Text = "Cancelar";

            //var origem = new FileInfo(txtPathOrigem.Text);
            lblMsg.Text = "Redimensionando...";
            this.Refresh();

            if (File.Exists(txtPathOrigem.Text))
            {
                MakeNewImage(txtPathOrigem.Text, txtPathDestino.Text);
            }
            if (Directory.Exists(txtPathOrigem.Text))
            {
                ProcessarDiretorioImagens(txtPathOrigem.Text);
            }

            lblMsg.Text = "Finalizado!";
            btnProcessar.Text = "Iniciar";

        }

        private void ProcessarDiretorioImagens(string pathOrigem)
        {
            var files = Directory.GetFiles(pathOrigem, txtExtensao.Text);

            progressBar1.Maximum = files.Count();
            foreach (var file in files)
            {
                if (btnProcessar.Text != "Cancelar")
                    return;

                MakeNewImage(file, txtPathDestino.Text);
                progressBar1.Value += 1;
            }
            progressBar1.Value = 0;

            if (chkRecursivo.Checked)

                foreach (var sub in Directory.GetDirectories(pathOrigem))
                {
                    if (btnProcessar.Text != "Cancelar")
                        return;
                    
                    if (!sub.Contains(@"\_output"))
                        ProcessarDiretorioImagens(sub);
                }

        }

        void MakeNewImage(string sFile, string pastaDestino)
        {
            string fname = Path.GetFileNameWithoutExtension(sFile);
            string fpath = Path.GetDirectoryName(sFile);
            lblMsg.Text = fpath.Substring(fpath.LastIndexOf(@"\"))+ @"\" + fname;
            this.Refresh();

            //' create New image and bitmap objects. Load the image file and put into a resized bitmap.
            var imgOrigem = Image.FromFile(sFile);

            //Objeto vImagemFinal recebe vImagemOriginal
            //var imgDestino = new Bitmap(imgOrigem);

            //Redimensiona o tamanho da imagem
            float width = 0;
            float height = 0;

            bool retrato = imgOrigem.Width < imgOrigem.Height;

            if (rdbPorcent.Checked)
            {
                width = imgOrigem.Width * ((float)Convert.ToInt32(txtWidth.Text) / 100);
                height = imgOrigem.Height * ((float)Convert.ToInt32(txtHeight.Text) / 100);
            }
            else
            {
                width = 0;
                height = 0;

                if (retrato && txtWidth.Text != "")
                    width = Convert.ToInt32(txtWidth.Text);
                else if (txtWidth2.Text != "")
                    width = Convert.ToInt32(txtWidth2.Text);


                if (retrato && txtHeight.Text != "")
                    height = Convert.ToInt32(txtHeight.Text);
                else if (txtHeight2.Text != "")
                    height = Convert.ToInt32(txtHeight2.Text);


                if (chkManterTamanho.Checked)
                {
                    float percetual = 0;
                    if (width > 0)
                    {
                        if (width == imgOrigem.Width)
                        {
                            height = imgOrigem.Height; //mantem original
                        }
                        else
                        {
                            percetual = (float)width / imgOrigem.Width;
                            height = (imgOrigem.Height * percetual);
                        }
                    }
                    else if (height > 0)
                    {
                        if (height == imgOrigem.Height)
                        {
                            width = imgOrigem.Width; //mantem original
                        }
                        else
                        {
                            percetual = (float)height / imgOrigem.Height;
                            width = (imgOrigem.Width * percetual);
                        }
                    }

                    if (width == 0) width = imgOrigem.Width;
                    if (height == 0) height = imgOrigem.Height;
                }

                //if ((imgOrigem.Width / width) > (imgOrigem.Height / height))
                //{
                //    int newHeight = (imgOrigem.Height * (width / imgOrigem.Width));

                //    if (newHeight > height)
                //    {
                //        width = width * (height / newHeight);
                //    } else
                //    {
                //        height = newHeight;
                //    }
                //}
                //else
                //{
                //    var width2 = (int)(imgOrigem.Width * ((float)height / (float)imgOrigem.Height));

                //    if (width2 > width)
                //    {
                //        height = height * (width / width2);
                //    }
                //    else
                //    {
                //        width = width2;
                //    }
                //}
            }


            Bitmap imgOutput = new Bitmap(imgOrigem, (int)width, (int)height);

            string path = pastaDestino;

            if (string.IsNullOrEmpty(path))
                path = String.Format(@"{0}\_output", Path.GetDirectoryName(sFile));


            //string fname = string.Format("{0}_{1}x{2}", Path.GetFileNameWithoutExtension(sFile), largura, altura);
            //string fname = Path.GetFileNameWithoutExtension(sFile);
            string ext = Path.GetExtension(sFile).ToLower();

            if (!Directory.Exists(path)) Directory.CreateDirectory(path);
            path = String.Format(@"{0}\{1}{2}", path, fname, ext);

            var tipoImage = imgOrigem.RawFormat;
            imgOrigem.Dispose();

            //Salvando Imagem Redimensionada
            imgOutput.Save(path, tipoImage);
            imgOutput.Dispose();

        }

        private void MakeThumb(string sFile)
        {
            try
            {
                var imgOrigem = Image.FromFile(sFile);

                //Objeto vImagemFinal recebe vImagemOriginal
                //var imgDestino = new Bitmap(imgOrigem);

                //Redimensiona o tamanho da imagem
                int largura = imgOrigem.Width / 2;
                int altura = imgOrigem.Height / 2;
                var imgDestino = imgOrigem.GetThumbnailImage(largura, altura, null, System.IntPtr.Zero);

                string ext = Path.GetExtension(sFile).ToLower();
                string fname = string.Format("{0}x{1}_{2}", largura, altura, Path.GetFileName(sFile));

                //Salvando Imagem Redimensionada
                imgDestino.Save(String.Format("{0}{1}{2}",
                                Path.GetDirectoryName(sFile),
                                fname,
                                Path.GetExtension(sFile).ToLower()), ImageFormat.Jpeg);
                lblMsg.Text = fname;

                //Dim Grafico As Graphics = Graphics.FromImage(ImagemFinal)
                //Transformar Fundo de GIFs transparente em Branco
                //Dim sb = New SolidBrush(System.Drawing.Color.White)
                //Grafico.FillRectangle(sb, 0, 0, ImagemFinal.Width, ImagemFinal.Height)
                //Recriar a imagem com Height e Width denfinido
                //Grafico.DrawImage(ImagemOriginal, 0, 0, ImagemFinal.Width, ImagemFinal.Height)


            }
            catch (Exception e)
            {
                lblMsg.Text = e.Message;
            }
        }

        private void rdbPorcent_CheckedChanged(object sender, EventArgs e)
        {
            lblRetrato.Text = "% de Redução";
            lblPaisagem.Visible = false;
            txtWidth2.Visible = false;
            txtHeight2.Visible = false;

            txtWidth.Text = "90";
            txtHeight.Text = "90";
            txtWidth.Focus();
        }

        private void rdbPixel_CheckedChanged(object sender, EventArgs e)
        {
            lblRetrato.Text = $"Formato{Environment.NewLine}Retrato";
            lblPaisagem.Visible = true;
            txtWidth2.Visible = true;
            txtHeight2.Visible = true;

            txtWidth.Text = "";
            txtHeight.Text = "";
            txtWidth2.Text = "";
            txtHeight2.Text = "";

            txtWidth.Focus();
        }

        private void txtWidth_KeyUp(object sender, KeyEventArgs e)
        {
            if (chkManterTamanho.Checked && rdbPorcent.Checked)
                txtHeight.Text = txtWidth.Text;
        }

        private void txtHeight_KeyUp(object sender, KeyEventArgs e)
        {
            if (chkManterTamanho.Checked && rdbPorcent.Checked)
                txtWidth.Text = txtHeight.Text;
        }

        private void txtPathOrigem_TextChanged(object sender, EventArgs e)
        {
            if (btnProcessar.Text == "Iniciar")
            {
                if (File.Exists(txtPathOrigem.Text))
                {
                    picOrigem.ImageLocation = txtPathOrigem.Text;
                    txtPathOrigem.Width = 621;
                    txtExtensao.Visible = false;
                }
                else
                {
                    picOrigem.Image = null;

                    txtPathOrigem.Width = 558;
                    txtExtensao.Visible = true;
                }
            }
            else
                picOrigem.Image = null;
        }

        private void chkManterTamanho_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPixel.Checked)
            {
                txtHeight.Text = "";
                txtHeight.Enabled = !chkManterTamanho.Checked;

                txtHeight2.Text = "";
                txtHeight2.Enabled = !chkManterTamanho.Checked;


            }
        }

    }
}


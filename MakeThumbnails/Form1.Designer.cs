namespace MakeThumbnails
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblOrigem = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.txtPathOrigem = new System.Windows.Forms.TextBox();
            this.txtPathDestino = new System.Windows.Forms.TextBox();
            this.lblDestino = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnProcessar = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.chkManterTamanho = new System.Windows.Forms.CheckBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblRetrato = new System.Windows.Forms.Label();
            this.lblPaisagem = new System.Windows.Forms.Label();
            this.txtHeight2 = new System.Windows.Forms.MaskedTextBox();
            this.txtWidth2 = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtHeight = new System.Windows.Forms.MaskedTextBox();
            this.txtWidth = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdbPixel = new System.Windows.Forms.RadioButton();
            this.rdbPorcent = new System.Windows.Forms.RadioButton();
            this.btnPathDestino = new System.Windows.Forms.Button();
            this.btnPathOrigem = new System.Windows.Forms.Button();
            this.chkRecursivo = new System.Windows.Forms.CheckBox();
            this.picOrigem = new System.Windows.Forms.PictureBox();
            this.txtExtensao = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOrigem)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOrigem
            // 
            this.lblOrigem.AutoSize = true;
            this.lblOrigem.Location = new System.Drawing.Point(19, 20);
            this.lblOrigem.Name = "lblOrigem";
            this.lblOrigem.Size = new System.Drawing.Size(178, 19);
            this.lblOrigem.TabIndex = 0;
            this.lblOrigem.Text = "Imagen ou Pasta de origem";
            // 
            // txtPathOrigem
            // 
            this.txtPathOrigem.Location = new System.Drawing.Point(22, 43);
            this.txtPathOrigem.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtPathOrigem.Name = "txtPathOrigem";
            this.txtPathOrigem.Size = new System.Drawing.Size(558, 24);
            this.txtPathOrigem.TabIndex = 1;
            this.txtPathOrigem.TextChanged += new System.EventHandler(this.txtPathOrigem_TextChanged);
            // 
            // txtPathDestino
            // 
            this.txtPathDestino.Location = new System.Drawing.Point(22, 101);
            this.txtPathDestino.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtPathDestino.Name = "txtPathDestino";
            this.txtPathDestino.Size = new System.Drawing.Size(621, 24);
            this.txtPathDestino.TabIndex = 4;
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(19, 77);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(248, 19);
            this.lblDestino.TabIndex = 3;
            this.lblDestino.Text = "Imagem ou Pasta de destino (opcional)";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnProcessar
            // 
            this.btnProcessar.Location = new System.Drawing.Point(550, 339);
            this.btnProcessar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnProcessar.Name = "btnProcessar";
            this.btnProcessar.Size = new System.Drawing.Size(136, 56);
            this.btnProcessar.TabIndex = 6;
            this.btnProcessar.Text = "Iniciar";
            this.btnProcessar.UseVisualStyleBackColor = true;
            this.btnProcessar.Click += new System.EventHandler(this.btnProcessar_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.Location = new System.Drawing.Point(12, 398);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(41, 16);
            this.lblMsg.TabIndex = 7;
            this.lblMsg.Text = "label3";
            // 
            // chkManterTamanho
            // 
            this.chkManterTamanho.AutoSize = true;
            this.chkManterTamanho.Location = new System.Drawing.Point(177, 202);
            this.chkManterTamanho.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.chkManterTamanho.Name = "chkManterTamanho";
            this.chkManterTamanho.Size = new System.Drawing.Size(141, 23);
            this.chkManterTamanho.TabIndex = 8;
            this.chkManterTamanho.Text = "Manter proporção";
            this.chkManterTamanho.UseVisualStyleBackColor = true;
            this.chkManterTamanho.CheckedChanged += new System.EventHandler(this.chkManterTamanho_CheckedChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 419);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(704, 17);
            this.progressBar1.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblRetrato);
            this.groupBox1.Controls.Add(this.lblPaisagem);
            this.groupBox1.Controls.Add(this.txtHeight2);
            this.groupBox1.Controls.Add(this.txtWidth2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txtHeight);
            this.groupBox1.Controls.Add(this.txtWidth);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.rdbPixel);
            this.groupBox1.Controls.Add(this.rdbPorcent);
            this.groupBox1.Controls.Add(this.chkManterTamanho);
            this.groupBox1.Location = new System.Drawing.Point(23, 155);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Size = new System.Drawing.Size(363, 229);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Redimensionar";
            // 
            // lblRetrato
            // 
            this.lblRetrato.AutoSize = true;
            this.lblRetrato.Location = new System.Drawing.Point(169, 65);
            this.lblRetrato.Name = "lblRetrato";
            this.lblRetrato.Size = new System.Drawing.Size(61, 38);
            this.lblRetrato.TabIndex = 19;
            this.lblRetrato.Text = "Formato\r\nRetrato";
            // 
            // lblPaisagem
            // 
            this.lblPaisagem.AutoSize = true;
            this.lblPaisagem.Location = new System.Drawing.Point(268, 65);
            this.lblPaisagem.Name = "lblPaisagem";
            this.lblPaisagem.Size = new System.Drawing.Size(67, 38);
            this.lblPaisagem.TabIndex = 18;
            this.lblPaisagem.Text = "Formato\r\nPaisagem";
            // 
            // txtHeight2
            // 
            this.txtHeight2.Location = new System.Drawing.Point(272, 153);
            this.txtHeight2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtHeight2.Mask = "000000";
            this.txtHeight2.Name = "txtHeight2";
            this.txtHeight2.Size = new System.Drawing.Size(62, 24);
            this.txtHeight2.TabIndex = 17;
            this.txtHeight2.Text = "100";
            this.txtHeight2.ValidatingType = typeof(int);
            // 
            // txtWidth2
            // 
            this.txtWidth2.Location = new System.Drawing.Point(272, 108);
            this.txtWidth2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtWidth2.Mask = "000000";
            this.txtWidth2.Name = "txtWidth2";
            this.txtWidth2.Size = new System.Drawing.Size(62, 24);
            this.txtWidth2.TabIndex = 16;
            this.txtWidth2.Text = "100";
            this.txtWidth2.ValidatingType = typeof(int);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MakeThumbnails.Properties.Resources.redimensionar;
            this.pictureBox1.Location = new System.Drawing.Point(22, 96);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 102);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(173, 153);
            this.txtHeight.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtHeight.Mask = "000000";
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(62, 24);
            this.txtHeight.TabIndex = 14;
            this.txtHeight.Text = "100";
            this.txtHeight.ValidatingType = typeof(int);
            this.txtHeight.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtHeight_KeyUp);
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(173, 108);
            this.txtWidth.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtWidth.Mask = "000000";
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(63, 24);
            this.txtWidth.TabIndex = 13;
            this.txtWidth.Text = "100";
            this.txtWidth.ValidatingType = typeof(int);
            this.txtWidth.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtWidth_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Vertical";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Horizontal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Por:";
            // 
            // rdbPixel
            // 
            this.rdbPixel.AutoSize = true;
            this.rdbPixel.Location = new System.Drawing.Point(190, 26);
            this.rdbPixel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.rdbPixel.Name = "rdbPixel";
            this.rdbPixel.Size = new System.Drawing.Size(55, 23);
            this.rdbPixel.TabIndex = 9;
            this.rdbPixel.Text = "Pixel";
            this.rdbPixel.UseVisualStyleBackColor = true;
            this.rdbPixel.CheckedChanged += new System.EventHandler(this.rdbPixel_CheckedChanged);
            // 
            // rdbPorcent
            // 
            this.rdbPorcent.AutoSize = true;
            this.rdbPorcent.Location = new System.Drawing.Point(57, 24);
            this.rdbPorcent.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.rdbPorcent.Name = "rdbPorcent";
            this.rdbPorcent.Size = new System.Drawing.Size(109, 23);
            this.rdbPorcent.TabIndex = 9;
            this.rdbPorcent.Text = "Porcentagem";
            this.rdbPorcent.UseVisualStyleBackColor = true;
            this.rdbPorcent.CheckedChanged += new System.EventHandler(this.rdbPorcent_CheckedChanged);
            // 
            // btnPathDestino
            // 
            this.btnPathDestino.Image = global::MakeThumbnails.Properties.Resources.open_folder;
            this.btnPathDestino.Location = new System.Drawing.Point(651, 100);
            this.btnPathDestino.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnPathDestino.Name = "btnPathDestino";
            this.btnPathDestino.Size = new System.Drawing.Size(26, 25);
            this.btnPathDestino.TabIndex = 5;
            this.btnPathDestino.UseVisualStyleBackColor = true;
            this.btnPathDestino.Click += new System.EventHandler(this.btnPathDestino_Click);
            // 
            // btnPathOrigem
            // 
            this.btnPathOrigem.Image = global::MakeThumbnails.Properties.Resources.open_folder;
            this.btnPathOrigem.Location = new System.Drawing.Point(651, 43);
            this.btnPathOrigem.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnPathOrigem.Name = "btnPathOrigem";
            this.btnPathOrigem.Size = new System.Drawing.Size(26, 24);
            this.btnPathOrigem.TabIndex = 2;
            this.btnPathOrigem.UseVisualStyleBackColor = true;
            this.btnPathOrigem.Click += new System.EventHandler(this.btnPathOrigem_Click);
            // 
            // chkRecursivo
            // 
            this.chkRecursivo.AutoSize = true;
            this.chkRecursivo.Checked = true;
            this.chkRecursivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRecursivo.Location = new System.Drawing.Point(213, 19);
            this.chkRecursivo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.chkRecursivo.Name = "chkRecursivo";
            this.chkRecursivo.Size = new System.Drawing.Size(182, 23);
            this.chkRecursivo.TabIndex = 20;
            this.chkRecursivo.Text = "Processamento recursivo";
            this.chkRecursivo.UseVisualStyleBackColor = true;
            // 
            // picOrigem
            // 
            this.picOrigem.Location = new System.Drawing.Point(429, 155);
            this.picOrigem.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.picOrigem.Name = "picOrigem";
            this.picOrigem.Size = new System.Drawing.Size(257, 175);
            this.picOrigem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOrigem.TabIndex = 21;
            this.picOrigem.TabStop = false;
            // 
            // txtExtensao
            // 
            this.txtExtensao.Location = new System.Drawing.Point(590, 43);
            this.txtExtensao.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtExtensao.Name = "txtExtensao";
            this.txtExtensao.Size = new System.Drawing.Size(53, 24);
            this.txtExtensao.TabIndex = 22;
            this.txtExtensao.Text = "*.jpg";
            this.txtExtensao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtExtensao.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 436);
            this.Controls.Add(this.txtExtensao);
            this.Controls.Add(this.picOrigem);
            this.Controls.Add(this.txtPathOrigem);
            this.Controls.Add(this.chkRecursivo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.btnProcessar);
            this.Controls.Add(this.btnPathDestino);
            this.Controls.Add(this.txtPathDestino);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.btnPathOrigem);
            this.Controls.Add(this.lblOrigem);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Make your Thumbnails";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOrigem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrigem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox txtPathOrigem;
        private System.Windows.Forms.Button btnPathOrigem;
        private System.Windows.Forms.Button btnPathDestino;
        private System.Windows.Forms.TextBox txtPathDestino;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnProcessar;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.CheckBox chkManterTamanho;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox txtHeight;
        private System.Windows.Forms.MaskedTextBox txtWidth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdbPixel;
        private System.Windows.Forms.RadioButton rdbPorcent;
        private System.Windows.Forms.Label lblRetrato;
        private System.Windows.Forms.Label lblPaisagem;
        private System.Windows.Forms.MaskedTextBox txtHeight2;
        private System.Windows.Forms.MaskedTextBox txtWidth2;
        private System.Windows.Forms.CheckBox chkRecursivo;
        private System.Windows.Forms.PictureBox picOrigem;
        private System.Windows.Forms.TextBox txtExtensao;
    }
}


namespace c_sharp_in_24_h__1h
{
    partial class fclsViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fclsViewer));
            this.btnSelect_picture = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.picShowPicture = new System.Windows.Forms.PictureBox();
            this.ofdSelectPicture = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picShowPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelect_picture
            // 
            this.btnSelect_picture.Location = new System.Drawing.Point(709, 12);
            this.btnSelect_picture.Name = "btnSelect_picture";
            this.btnSelect_picture.Size = new System.Drawing.Size(85, 53);
            this.btnSelect_picture.TabIndex = 0;
            this.btnSelect_picture.Text = "select picture";
            this.btnSelect_picture.UseVisualStyleBackColor = true;
            this.btnSelect_picture.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(709, 71);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(85, 35);
            this.btnQuit.TabIndex = 1;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.button2_Click);
            // 
            // picShowPicture
            // 
            this.picShowPicture.Location = new System.Drawing.Point(4, 6);
            this.picShowPicture.Name = "picShowPicture";
            this.picShowPicture.Size = new System.Drawing.Size(699, 400);
            this.picShowPicture.TabIndex = 2;
            this.picShowPicture.TabStop = false;
            // 
            // ofdSelectPicture
            // 
            this.ofdSelectPicture.FileName = "ofdSelectPicture1";
            this.ofdSelectPicture.Filter = "Windows Bitmaps |*.BMP|JPEG File|*.JPG";
            this.ofdSelectPicture.Title = "Select Picture";
            this.ofdSelectPicture.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // fclsViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 418);
            this.Controls.Add(this.picShowPicture);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnSelect_picture);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fclsViewer";
            this.Text = "Picture Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.picShowPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSelect_picture;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.PictureBox picShowPicture;
        private System.Windows.Forms.OpenFileDialog ofdSelectPicture;
    }
}


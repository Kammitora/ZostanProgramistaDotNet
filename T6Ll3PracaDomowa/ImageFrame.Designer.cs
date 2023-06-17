
namespace T6Ll3PracaDomowa
{
    partial class ImageFrame
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
            this.ptrbxMain = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptrbxMain)).BeginInit();
            this.SuspendLayout();
            // 
            // ptrbxMain
            // 
            this.ptrbxMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ptrbxMain.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ptrbxMain.Location = new System.Drawing.Point(98, 12);
            this.ptrbxMain.Name = "ptrbxMain";
            this.ptrbxMain.Size = new System.Drawing.Size(690, 426);
            this.ptrbxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptrbxMain.TabIndex = 0;
            this.ptrbxMain.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(13, 13);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(13, 43);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Usuń";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ImageFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.ptrbxMain);
            this.Name = "ImageFrame";
            this.Text = "Ramka do zdjęć";
            ((System.ComponentModel.ISupportInitialize)(this.ptrbxMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.PictureBox ptrbxMain;
    }
}


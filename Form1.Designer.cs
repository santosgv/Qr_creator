
namespace Qr_creator
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
            this.btngera = new System.Windows.Forms.Button();
            this.txtqr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btngera
            // 
            this.btngera.BackColor = System.Drawing.Color.Red;
            this.btngera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngera.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngera.ForeColor = System.Drawing.Color.White;
            this.btngera.Location = new System.Drawing.Point(390, 29);
            this.btngera.Name = "btngera";
            this.btngera.Size = new System.Drawing.Size(91, 36);
            this.btngera.TabIndex = 0;
            this.btngera.Text = "Criar";
            this.btngera.UseVisualStyleBackColor = false;
            this.btngera.Click += new System.EventHandler(this.btngera_Click);
            // 
            // txtqr
            // 
            this.txtqr.Location = new System.Drawing.Point(81, 36);
            this.txtqr.Name = "txtqr";
            this.txtqr.Size = new System.Drawing.Size(299, 20);
            this.txtqr.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Texto";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(81, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(299, 217);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(502, 329);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtqr);
            this.Controls.Add(this.btngera);
            this.Name = "Form1";
            this.Text = "Gerador de QRcode";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btngera;
        private System.Windows.Forms.TextBox txtqr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


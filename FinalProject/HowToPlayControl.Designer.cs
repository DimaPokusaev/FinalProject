namespace FinalProject
{
    partial class HowToPlayControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HowToPlayControl));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.MM = new System.Windows.Forms.Button();
            this.lable1 = new System.Windows.Forms.Label();
            this.backDrop = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.backDrop)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(191)))), ((int)(((byte)(48)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(71, 141);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ShortcutsEnabled = false;
            this.richTextBox1.Size = new System.Drawing.Size(899, 440);
            this.richTextBox1.TabIndex = 38;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // MM
            // 
            this.MM.FlatAppearance.BorderSize = 2;
            this.MM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MM.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MM.Image = ((System.Drawing.Image)(resources.GetObject("MM.Image")));
            this.MM.Location = new System.Drawing.Point(826, 11);
            this.MM.Name = "MM";
            this.MM.Size = new System.Drawing.Size(190, 52);
            this.MM.TabIndex = 37;
            this.MM.Text = "Main Menu";
            this.MM.UseVisualStyleBackColor = true;
            this.MM.Click += new System.EventHandler(this.MM_Click);
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable1.Image = global::FinalProject.Properties.Resources.velvet2;
            this.lable1.Location = new System.Drawing.Point(250, 23);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(488, 95);
            this.lable1.TabIndex = 36;
            this.lable1.Text = "How to Play";
            // 
            // backDrop
            // 
            this.backDrop.Image = ((System.Drawing.Image)(resources.GetObject("backDrop.Image")));
            this.backDrop.InitialImage = ((System.Drawing.Image)(resources.GetObject("backDrop.InitialImage")));
            this.backDrop.Location = new System.Drawing.Point(0, 0);
            this.backDrop.Name = "backDrop";
            this.backDrop.Size = new System.Drawing.Size(1029, 636);
            this.backDrop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backDrop.TabIndex = 35;
            this.backDrop.TabStop = false;
            // 
            // HowToPlayControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.MM);
            this.Controls.Add(this.lable1);
            this.Controls.Add(this.backDrop);
            this.Name = "HowToPlayControl";
            this.Size = new System.Drawing.Size(1024, 635);
            ((System.ComponentModel.ISupportInitialize)(this.backDrop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button MM;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.PictureBox backDrop;
    }
}

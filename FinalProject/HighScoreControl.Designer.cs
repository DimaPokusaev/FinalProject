namespace FinalProject
{
    partial class HighScoreControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HighScoreControl));
            this.label1 = new System.Windows.Forms.Label();
            this.MM = new System.Windows.Forms.Button();
            this.backDrop = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.backDrop)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::FinalProject.Properties.Resources.velvet2;
            this.label1.Location = new System.Drawing.Point(365, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 58);
            this.label1.TabIndex = 33;
            this.label1.Text = "High Score";
            // 
            // MM
            // 
            this.MM.FlatAppearance.BorderSize = 2;
            this.MM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MM.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MM.Image = ((System.Drawing.Image)(resources.GetObject("MM.Image")));
            this.MM.Location = new System.Drawing.Point(822, 16);
            this.MM.Name = "MM";
            this.MM.Size = new System.Drawing.Size(190, 52);
            this.MM.TabIndex = 32;
            this.MM.Text = "Main Menu";
            this.MM.UseVisualStyleBackColor = true;
            this.MM.Click += new System.EventHandler(this.MM_Click);
            // 
            // backDrop
            // 
            this.backDrop.Image = ((System.Drawing.Image)(resources.GetObject("backDrop.Image")));
            this.backDrop.InitialImage = ((System.Drawing.Image)(resources.GetObject("backDrop.InitialImage")));
            this.backDrop.Location = new System.Drawing.Point(0, 0);
            this.backDrop.Name = "backDrop";
            this.backDrop.Size = new System.Drawing.Size(1029, 636);
            this.backDrop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backDrop.TabIndex = 31;
            this.backDrop.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Lime;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.richTextBox1.Location = new System.Drawing.Point(171, 143);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(735, 459);
            this.richTextBox1.TabIndex = 34;
            this.richTextBox1.Text = "No scores to record";
            // 
            // HighScoreControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MM);
            this.Controls.Add(this.backDrop);
            this.Name = "HighScoreControl";
            this.Size = new System.Drawing.Size(1024, 636);
            ((System.ComponentModel.ISupportInitialize)(this.backDrop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MM;
        private System.Windows.Forms.PictureBox backDrop;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

namespace FinalProject
{
    partial class StartControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartControl));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.startLable = new System.Windows.Forms.Button();
            this.scoreLable = new System.Windows.Forms.Label();
            this.backDrop = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.backDrop)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Chartreuse;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox1.Location = new System.Drawing.Point(183, 283);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(611, 36);
            this.textBox1.TabIndex = 46;
            // 
            // startLable
            // 
            this.startLable.FlatAppearance.BorderSize = 2;
            this.startLable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startLable.Image = ((System.Drawing.Image)(resources.GetObject("startLable.Image")));
            this.startLable.Location = new System.Drawing.Point(735, 512);
            this.startLable.Name = "startLable";
            this.startLable.Size = new System.Drawing.Size(190, 52);
            this.startLable.TabIndex = 45;
            this.startLable.Text = "Enter";
            this.startLable.UseVisualStyleBackColor = true;
            this.startLable.Click += new System.EventHandler(this.startLable_Click);
            // 
            // scoreLable
            // 
            this.scoreLable.AutoSize = true;
            this.scoreLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.scoreLable.Image = global::FinalProject.Properties.Resources.velvet2;
            this.scoreLable.Location = new System.Drawing.Point(274, 123);
            this.scoreLable.Name = "scoreLable";
            this.scoreLable.Size = new System.Drawing.Size(404, 39);
            this.scoreLable.TabIndex = 44;
            this.scoreLable.Text = "Please Enter \'Your Name\'";
            // 
            // backDrop
            // 
            this.backDrop.Image = ((System.Drawing.Image)(resources.GetObject("backDrop.Image")));
            this.backDrop.InitialImage = ((System.Drawing.Image)(resources.GetObject("backDrop.InitialImage")));
            this.backDrop.Location = new System.Drawing.Point(0, 0);
            this.backDrop.Name = "backDrop";
            this.backDrop.Size = new System.Drawing.Size(1029, 636);
            this.backDrop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backDrop.TabIndex = 43;
            this.backDrop.TabStop = false;
            // 
            // StartControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.startLable);
            this.Controls.Add(this.scoreLable);
            this.Controls.Add(this.backDrop);
            this.Name = "StartControl";
            this.Size = new System.Drawing.Size(1026, 634);
            ((System.ComponentModel.ISupportInitialize)(this.backDrop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button startLable;
        protected System.Windows.Forms.Label scoreLable;
        private System.Windows.Forms.PictureBox backDrop;
    }
}

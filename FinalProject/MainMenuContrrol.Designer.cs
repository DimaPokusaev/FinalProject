namespace FinalProject
{
    partial class MainMenuContrrol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuContrrol));
            this.lable1 = new System.Windows.Forms.Label();
            this.Score = new System.Windows.Forms.Button();
            this.How = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.backDrop = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.backDrop)).BeginInit();
            this.SuspendLayout();
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable1.Image = global::FinalProject.Properties.Resources.velvet2;
            this.lable1.Location = new System.Drawing.Point(106, 77);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(852, 95);
            this.lable1.TabIndex = 36;
            this.lable1.Text = "Welcome to BADJack";
            // 
            // Score
            // 
            this.Score.FlatAppearance.BorderSize = 2;
            this.Score.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.Image = ((System.Drawing.Image)(resources.GetObject("Score.Image")));
            this.Score.Location = new System.Drawing.Point(192, 186);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(667, 131);
            this.Score.TabIndex = 35;
            this.Score.Text = "High Scores";
            this.Score.UseVisualStyleBackColor = true;
            this.Score.Click += new System.EventHandler(this.Score_Click);
            // 
            // How
            // 
            this.How.FlatAppearance.BorderSize = 2;
            this.How.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.How.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.How.Image = ((System.Drawing.Image)(resources.GetObject("How.Image")));
            this.How.Location = new System.Drawing.Point(192, 483);
            this.How.Name = "How";
            this.How.Size = new System.Drawing.Size(667, 131);
            this.How.TabIndex = 34;
            this.How.Text = "How To Play";
            this.How.UseVisualStyleBackColor = true;
            this.How.Click += new System.EventHandler(this.How_Click);
            // 
            // startButton
            // 
            this.startButton.FlatAppearance.BorderSize = 2;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Image = ((System.Drawing.Image)(resources.GetObject("startButton.Image")));
            this.startButton.Location = new System.Drawing.Point(192, 334);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(667, 131);
            this.startButton.TabIndex = 33;
            this.startButton.Text = "Play";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.Start_Click);
            // 
            // backDrop
            // 
            this.backDrop.Image = ((System.Drawing.Image)(resources.GetObject("backDrop.Image")));
            this.backDrop.InitialImage = ((System.Drawing.Image)(resources.GetObject("backDrop.InitialImage")));
            this.backDrop.Location = new System.Drawing.Point(0, 0);
            this.backDrop.Name = "backDrop";
            this.backDrop.Size = new System.Drawing.Size(1029, 636);
            this.backDrop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backDrop.TabIndex = 32;
            this.backDrop.TabStop = false;
            // 
            // MainMenuContrrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lable1);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.How);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.backDrop);
            this.Name = "MainMenuContrrol";
            this.Size = new System.Drawing.Size(1023, 630);
            ((System.ComponentModel.ISupportInitialize)(this.backDrop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.Button Score;
        private System.Windows.Forms.Button How;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.PictureBox backDrop;
    }
}

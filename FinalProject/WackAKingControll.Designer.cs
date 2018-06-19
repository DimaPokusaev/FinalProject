namespace FinalProject
{
    partial class WackAKingControll
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WackAKingControll));
            this.startLable = new System.Windows.Forms.Button();
            this.scoreLable = new System.Windows.Forms.Label();
            this.MM = new System.Windows.Forms.Button();
            this.backDrop = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.backDrop)).BeginInit();
            this.SuspendLayout();
            // 
            // startLable
            // 
            this.startLable.FlatAppearance.BorderSize = 2;
            this.startLable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startLable.Image = ((System.Drawing.Image)(resources.GetObject("startLable.Image")));
            this.startLable.Location = new System.Drawing.Point(822, 74);
            this.startLable.Name = "startLable";
            this.startLable.Size = new System.Drawing.Size(190, 52);
            this.startLable.TabIndex = 43;
            this.startLable.Text = "Start";
            this.startLable.UseVisualStyleBackColor = true;
            this.startLable.Click += new System.EventHandler(this.startLable_Click);
            // 
            // scoreLable
            // 
            this.scoreLable.AutoSize = true;
            this.scoreLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLable.Image = global::FinalProject.Properties.Resources.velvet2;
            this.scoreLable.Location = new System.Drawing.Point(274, 16);
            this.scoreLable.Name = "scoreLable";
            this.scoreLable.Size = new System.Drawing.Size(352, 95);
            this.scoreLable.TabIndex = 42;
            this.scoreLable.Text = "Score: 0";
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
            this.MM.TabIndex = 41;
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
            this.backDrop.TabIndex = 40;
            this.backDrop.TabStop = false;
            this.backDrop.Click += new System.EventHandler(this.backDrop_Click_1);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_2);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.Location = new System.Drawing.Point(31, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 237);
            this.button1.TabIndex = 44;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // WackAKingControll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.startLable);
            this.Controls.Add(this.scoreLable);
            this.Controls.Add(this.MM);
            this.Controls.Add(this.backDrop);
            this.Name = "WackAKingControll";
            this.Size = new System.Drawing.Size(1028, 630);
            ((System.ComponentModel.ISupportInitialize)(this.backDrop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startLable;
        protected System.Windows.Forms.Label scoreLable;
        private System.Windows.Forms.Button MM;
        private System.Windows.Forms.PictureBox backDrop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
    }
}

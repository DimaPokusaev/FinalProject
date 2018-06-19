namespace FinalProject
{
    partial class MiniGameListControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MiniGameListControl));
            this.lable1 = new System.Windows.Forms.Label();
            this.WackAKing = new System.Windows.Forms.Button();
            this.SimonDdeals = new System.Windows.Forms.Button();
            this.backDrop = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.backDrop)).BeginInit();
            this.SuspendLayout();
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable1.Image = global::FinalProject.Properties.Resources.velvet2;
            this.lable1.Location = new System.Drawing.Point(312, 41);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(426, 95);
            this.lable1.TabIndex = 39;
            this.lable1.Text = "MiniGame";
            // 
            // WackAKing
            // 
            this.WackAKing.FlatAppearance.BorderSize = 2;
            this.WackAKing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WackAKing.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WackAKing.Image = ((System.Drawing.Image)(resources.GetObject("WackAKing.Image")));
            this.WackAKing.Location = new System.Drawing.Point(175, 161);
            this.WackAKing.Name = "WackAKing";
            this.WackAKing.Size = new System.Drawing.Size(667, 131);
            this.WackAKing.TabIndex = 38;
            this.WackAKing.Text = "WackAKing";
            this.WackAKing.UseVisualStyleBackColor = true;
            this.WackAKing.Click += new System.EventHandler(this.WackAKing_Click);
            // 
            // SimonDdeals
            // 
            this.SimonDdeals.FlatAppearance.BorderSize = 2;
            this.SimonDdeals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SimonDdeals.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimonDdeals.Image = ((System.Drawing.Image)(resources.GetObject("SimonDdeals.Image")));
            this.SimonDdeals.Location = new System.Drawing.Point(175, 309);
            this.SimonDdeals.Name = "SimonDdeals";
            this.SimonDdeals.Size = new System.Drawing.Size(667, 131);
            this.SimonDdeals.TabIndex = 37;
            this.SimonDdeals.Text = "Simon Deals";
            this.SimonDdeals.UseVisualStyleBackColor = true;
            this.SimonDdeals.Click += new System.EventHandler(this.SimonDdeals_Click);
            // 
            // backDrop
            // 
            this.backDrop.Image = ((System.Drawing.Image)(resources.GetObject("backDrop.Image")));
            this.backDrop.InitialImage = ((System.Drawing.Image)(resources.GetObject("backDrop.InitialImage")));
            this.backDrop.Location = new System.Drawing.Point(0, 0);
            this.backDrop.Name = "backDrop";
            this.backDrop.Size = new System.Drawing.Size(1029, 636);
            this.backDrop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backDrop.TabIndex = 36;
            this.backDrop.TabStop = false;
            // 
            // MiniGameListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lable1);
            this.Controls.Add(this.WackAKing);
            this.Controls.Add(this.SimonDdeals);
            this.Controls.Add(this.backDrop);
            this.Name = "MiniGameListControl";
            this.Size = new System.Drawing.Size(1023, 634);
            ((System.ComponentModel.ISupportInitialize)(this.backDrop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label lable1;
        private System.Windows.Forms.Button WackAKing;
        private System.Windows.Forms.Button SimonDdeals;
        private System.Windows.Forms.PictureBox backDrop;
        private System.Windows.Forms.Timer timer1;
    }
}

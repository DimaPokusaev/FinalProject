namespace FinalProject
{
    partial class MainGameControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGameControl));
            this.game = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.resultLable = new System.Windows.Forms.Label();
            this.CashLable = new System.Windows.Forms.Label();
            this.potLable = new System.Windows.Forms.Label();
            this.playerLable = new System.Windows.Forms.Label();
            this.p7 = new System.Windows.Forms.PictureBox();
            this.p6 = new System.Windows.Forms.PictureBox();
            this.p5 = new System.Windows.Forms.PictureBox();
            this.p4 = new System.Windows.Forms.PictureBox();
            this.p3 = new System.Windows.Forms.PictureBox();
            this.p2 = new System.Windows.Forms.PictureBox();
            this.p1 = new System.Windows.Forms.PictureBox();
            this.d5 = new System.Windows.Forms.PictureBox();
            this.d4 = new System.Windows.Forms.PictureBox();
            this.d3 = new System.Windows.Forms.PictureBox();
            this.d2 = new System.Windows.Forms.PictureBox();
            this.bet50 = new System.Windows.Forms.Button();
            this.bet100 = new System.Windows.Forms.Button();
            this.bet5 = new System.Windows.Forms.Button();
            this.d1 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.backDrop = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.p7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backDrop)).BeginInit();
            this.SuspendLayout();
            // 
            // game
            // 
            this.game.FlatAppearance.BorderSize = 2;
            this.game.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.game.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.game.Image = ((System.Drawing.Image)(resources.GetObject("game.Image")));
            this.game.Location = new System.Drawing.Point(824, 75);
            this.game.Name = "game";
            this.game.Size = new System.Drawing.Size(190, 52);
            this.game.TabIndex = 54;
            this.game.Text = "Mini Game";
            this.game.UseVisualStyleBackColor = true;
            this.game.Click += new System.EventHandler(this.game_Click);
            // 
            // Exit
            // 
            this.Exit.FlatAppearance.BorderSize = 2;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
            this.Exit.Location = new System.Drawing.Point(824, 17);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(190, 52);
            this.Exit.TabIndex = 53;
            this.Exit.Text = "Cash Out";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // resultLable
            // 
            this.resultLable.AutoSize = true;
            this.resultLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLable.Location = new System.Drawing.Point(642, 110);
            this.resultLable.Name = "resultLable";
            this.resultLable.Size = new System.Drawing.Size(0, 58);
            this.resultLable.TabIndex = 51;
            // 
            // CashLable
            // 
            this.CashLable.AutoSize = true;
            this.CashLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CashLable.Image = ((System.Drawing.Image)(resources.GetObject("CashLable.Image")));
            this.CashLable.Location = new System.Drawing.Point(25, 543);
            this.CashLable.Name = "CashLable";
            this.CashLable.Size = new System.Drawing.Size(85, 20);
            this.CashLable.TabIndex = 50;
            this.CashLable.Text = "Cash: 300";
            // 
            // potLable
            // 
            this.potLable.AutoSize = true;
            this.potLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.potLable.Image = ((System.Drawing.Image)(resources.GetObject("potLable.Image")));
            this.potLable.Location = new System.Drawing.Point(13, 374);
            this.potLable.Name = "potLable";
            this.potLable.Size = new System.Drawing.Size(53, 20);
            this.potLable.TabIndex = 49;
            this.potLable.Text = "Pot: 0";
            // 
            // playerLable
            // 
            this.playerLable.AutoSize = true;
            this.playerLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.playerLable.Image = global::FinalProject.Properties.Resources.velvet2;
            this.playerLable.Location = new System.Drawing.Point(944, 355);
            this.playerLable.Name = "playerLable";
            this.playerLable.Size = new System.Drawing.Size(65, 20);
            this.playerLable.TabIndex = 48;
            this.playerLable.Text = "Total: 0";
            // 
            // p7
            // 
            this.p7.Location = new System.Drawing.Point(840, 261);
            this.p7.Name = "p7";
            this.p7.Size = new System.Drawing.Size(98, 198);
            this.p7.TabIndex = 47;
            this.p7.TabStop = false;
            this.p7.Visible = false;
            // 
            // p6
            // 
            this.p6.Location = new System.Drawing.Point(736, 261);
            this.p6.Name = "p6";
            this.p6.Size = new System.Drawing.Size(98, 198);
            this.p6.TabIndex = 46;
            this.p6.TabStop = false;
            this.p6.Visible = false;
            // 
            // p5
            // 
            this.p5.Location = new System.Drawing.Point(632, 261);
            this.p5.Name = "p5";
            this.p5.Size = new System.Drawing.Size(98, 198);
            this.p5.TabIndex = 45;
            this.p5.TabStop = false;
            this.p5.Visible = false;
            // 
            // p4
            // 
            this.p4.Location = new System.Drawing.Point(528, 261);
            this.p4.Name = "p4";
            this.p4.Size = new System.Drawing.Size(98, 198);
            this.p4.TabIndex = 44;
            this.p4.TabStop = false;
            this.p4.Visible = false;
            // 
            // p3
            // 
            this.p3.Location = new System.Drawing.Point(424, 261);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(98, 198);
            this.p3.TabIndex = 43;
            this.p3.TabStop = false;
            this.p3.Visible = false;
            // 
            // p2
            // 
            this.p2.Location = new System.Drawing.Point(322, 261);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(98, 198);
            this.p2.TabIndex = 41;
            this.p2.TabStop = false;
            this.p2.Visible = false;
            // 
            // p1
            // 
            this.p1.Location = new System.Drawing.Point(218, 261);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(98, 198);
            this.p1.TabIndex = 42;
            this.p1.TabStop = false;
            this.p1.Visible = false;
            // 
            // d5
            // 
            this.d5.Location = new System.Drawing.Point(389, 38);
            this.d5.Name = "d5";
            this.d5.Size = new System.Drawing.Size(91, 198);
            this.d5.TabIndex = 40;
            this.d5.TabStop = false;
            this.d5.Visible = false;
            // 
            // d4
            // 
            this.d4.Location = new System.Drawing.Point(296, 38);
            this.d4.Name = "d4";
            this.d4.Size = new System.Drawing.Size(91, 198);
            this.d4.TabIndex = 39;
            this.d4.TabStop = false;
            this.d4.Visible = false;
            // 
            // d3
            // 
            this.d3.Location = new System.Drawing.Point(202, 38);
            this.d3.Name = "d3";
            this.d3.Size = new System.Drawing.Size(91, 198);
            this.d3.TabIndex = 38;
            this.d3.TabStop = false;
            this.d3.Visible = false;
            // 
            // d2
            // 
            this.d2.Location = new System.Drawing.Point(109, 38);
            this.d2.Name = "d2";
            this.d2.Size = new System.Drawing.Size(91, 198);
            this.d2.TabIndex = 33;
            this.d2.TabStop = false;
            this.d2.Visible = false;
            // 
            // bet50
            // 
            this.bet50.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bet50.Image = ((System.Drawing.Image)(resources.GetObject("bet50.Image")));
            this.bet50.Location = new System.Drawing.Point(98, 445);
            this.bet50.Name = "bet50";
            this.bet50.Size = new System.Drawing.Size(57, 54);
            this.bet50.TabIndex = 37;
            this.bet50.UseVisualStyleBackColor = true;
            this.bet50.Click += new System.EventHandler(this.bet50_Click);
            // 
            // bet100
            // 
            this.bet100.AccessibleDescription = "";
            this.bet100.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bet100.Image = ((System.Drawing.Image)(resources.GetObject("bet100.Image")));
            this.bet100.Location = new System.Drawing.Point(16, 481);
            this.bet100.Name = "bet100";
            this.bet100.Size = new System.Drawing.Size(57, 54);
            this.bet100.TabIndex = 36;
            this.bet100.UseVisualStyleBackColor = true;
            this.bet100.Click += new System.EventHandler(this.bet100_Click);
            // 
            // bet5
            // 
            this.bet5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bet5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bet5.Image = ((System.Drawing.Image)(resources.GetObject("bet5.Image")));
            this.bet5.Location = new System.Drawing.Point(28, 405);
            this.bet5.Name = "bet5";
            this.bet5.Size = new System.Drawing.Size(56, 54);
            this.bet5.TabIndex = 35;
            this.bet5.UseVisualStyleBackColor = true;
            this.bet5.Click += new System.EventHandler(this.bet5_Click);
            // 
            // d1
            // 
            this.d1.Location = new System.Drawing.Point(16, 38);
            this.d1.Name = "d1";
            this.d1.Size = new System.Drawing.Size(91, 198);
            this.d1.TabIndex = 34;
            this.d1.TabStop = false;
            this.d1.Visible = false;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 2;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(761, 530);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(141, 52);
            this.button5.TabIndex = 32;
            this.button5.Text = "Stand";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 2;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(565, 530);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(190, 52);
            this.button4.TabIndex = 31;
            this.button4.Text = "Double";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(369, 530);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(190, 52);
            this.button3.TabIndex = 30;
            this.button3.Text = "Split";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(173, 530);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(190, 52);
            this.button2.TabIndex = 29;
            this.button2.Text = "Hit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // backDrop
            // 
            this.backDrop.Image = ((System.Drawing.Image)(resources.GetObject("backDrop.Image")));
            this.backDrop.InitialImage = ((System.Drawing.Image)(resources.GetObject("backDrop.InitialImage")));
            this.backDrop.Location = new System.Drawing.Point(0, 0);
            this.backDrop.Name = "backDrop";
            this.backDrop.Size = new System.Drawing.Size(1029, 636);
            this.backDrop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backDrop.TabIndex = 52;
            this.backDrop.TabStop = false;
            // 
            // MainGameControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.game);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.resultLable);
            this.Controls.Add(this.CashLable);
            this.Controls.Add(this.potLable);
            this.Controls.Add(this.playerLable);
            this.Controls.Add(this.p7);
            this.Controls.Add(this.p6);
            this.Controls.Add(this.p5);
            this.Controls.Add(this.p4);
            this.Controls.Add(this.p3);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.d5);
            this.Controls.Add(this.d4);
            this.Controls.Add(this.d3);
            this.Controls.Add(this.d2);
            this.Controls.Add(this.bet50);
            this.Controls.Add(this.bet100);
            this.Controls.Add(this.bet5);
            this.Controls.Add(this.d1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.backDrop);
            this.Name = "MainGameControl";
            this.Size = new System.Drawing.Size(1028, 630);
            ((System.ComponentModel.ISupportInitialize)(this.p7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backDrop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button game;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label resultLable;
        private System.Windows.Forms.Label CashLable;
        private System.Windows.Forms.Label potLable;
        private System.Windows.Forms.Label playerLable;
        private System.Windows.Forms.PictureBox p7;
        private System.Windows.Forms.PictureBox p6;
        private System.Windows.Forms.PictureBox p5;
        private System.Windows.Forms.PictureBox p4;
        private System.Windows.Forms.PictureBox p3;
        private System.Windows.Forms.PictureBox p2;
        private System.Windows.Forms.PictureBox p1;
        private System.Windows.Forms.PictureBox d5;
        private System.Windows.Forms.PictureBox d4;
        private System.Windows.Forms.PictureBox d3;
        private System.Windows.Forms.PictureBox d2;
        private System.Windows.Forms.Button bet50;
        private System.Windows.Forms.Button bet100;
        private System.Windows.Forms.Button bet5;
        private System.Windows.Forms.PictureBox d1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox backDrop;
    }
}

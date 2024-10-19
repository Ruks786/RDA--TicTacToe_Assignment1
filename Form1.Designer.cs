namespace TicTacToe_Assignment1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            btnExit = new Button();
            btnReset = new Button();
            btnNewGame = new Button();
            panel3 = new Panel();
            lblPlayerO = new Label();
            lblPlayerX = new Label();
            label3 = new Label();
            label2 = new Label();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCoral;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(14, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(807, 103);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.BackColor = Color.LightCoral;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Yet R", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(16, 18);
            label1.Name = "label1";
            label1.Size = new Size(773, 64);
            label1.TabIndex = 0;
            label1.Text = "!!!*** Tic Tac Toe ***!!!";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(btnExit);
            panel2.Controls.Add(btnReset);
            panel2.Controls.Add(btnNewGame);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(467, 129);
            panel2.Name = "panel2";
            panel2.Size = new Size(354, 372);
            panel2.TabIndex = 1;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.SeaShell;
            btnExit.Font = new Font("Yet R", 24F);
            btnExit.ForeColor = Color.Maroon;
            btnExit.Location = new Point(174, 275);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(162, 85);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.SeaShell;
            btnReset.Font = new Font("Yet R", 24F);
            btnReset.ForeColor = Color.Maroon;
            btnReset.Location = new Point(6, 276);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(162, 85);
            btnReset.TabIndex = 2;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnNewGame
            // 
            btnNewGame.BackColor = Color.SeaShell;
            btnNewGame.Font = new Font("Yet R", 24F);
            btnNewGame.ForeColor = Color.Maroon;
            btnNewGame.Location = new Point(6, 180);
            btnNewGame.Name = "btnNewGame";
            btnNewGame.Size = new Size(333, 92);
            btnNewGame.TabIndex = 1;
            btnNewGame.Text = "New Game";
            btnNewGame.UseVisualStyleBackColor = false;
            btnNewGame.Click += btnNewGame_Click;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(lblPlayerO);
            panel3.Controls.Add(lblPlayerX);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(11, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(333, 171);
            panel3.TabIndex = 0;
            // 
            // lblPlayerO
            // 
            lblPlayerO.BorderStyle = BorderStyle.Fixed3D;
            lblPlayerO.Font = new Font("Yet R", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblPlayerO.ForeColor = Color.Maroon;
            lblPlayerO.Location = new Point(183, 105);
            lblPlayerO.Name = "lblPlayerO";
            lblPlayerO.Size = new Size(143, 36);
            lblPlayerO.TabIndex = 3;
            lblPlayerO.Text = "0";
            lblPlayerO.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPlayerX
            // 
            lblPlayerX.BorderStyle = BorderStyle.Fixed3D;
            lblPlayerX.Font = new Font("Yet R", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblPlayerX.ForeColor = Color.Maroon;
            lblPlayerX.Location = new Point(183, 40);
            lblPlayerX.Name = "lblPlayerX";
            lblPlayerX.Size = new Size(143, 36);
            lblPlayerX.TabIndex = 2;
            lblPlayerX.Text = "0";
            lblPlayerX.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yet R", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label3.ForeColor = Color.Maroon;
            label3.Location = new Point(6, 105);
            label3.Name = "label3";
            label3.Size = new Size(171, 36);
            label3.TabIndex = 1;
            label3.Text = "Player O: ";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yet R", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(7, 40);
            label2.Name = "label2";
            label2.Size = new Size(170, 36);
            label2.TabIndex = 0;
            label2.Text = "Player X: ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn1
            // 
            btn1.BackColor = Color.SeaShell;
            btn1.Font = new Font("Yet R", 36F);
            btn1.ForeColor = Color.Maroon;
            btn1.Location = new Point(14, 129);
            btn1.Name = "btn1";
            btn1.Size = new Size(140, 120);
            btn1.TabIndex = 2;
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += Button_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.SeaShell;
            btn2.Font = new Font("Yet R", 36F);
            btn2.ForeColor = Color.Maroon;
            btn2.Location = new Point(160, 129);
            btn2.Name = "btn2";
            btn2.Size = new Size(140, 120);
            btn2.TabIndex = 3;
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += Button_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.SeaShell;
            btn3.Font = new Font("Yet R", 36F);
            btn3.ForeColor = Color.Maroon;
            btn3.Location = new Point(306, 129);
            btn3.Name = "btn3";
            btn3.Size = new Size(140, 120);
            btn3.TabIndex = 4;
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += Button_Click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.SeaShell;
            btn4.Font = new Font("Yet R", 36F);
            btn4.ForeColor = Color.Maroon;
            btn4.Location = new Point(14, 255);
            btn4.Name = "btn4";
            btn4.Size = new Size(140, 120);
            btn4.TabIndex = 5;
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += Button_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.SeaShell;
            btn5.Font = new Font("Yet R", 36F);
            btn5.ForeColor = Color.Maroon;
            btn5.Location = new Point(160, 255);
            btn5.Name = "btn5";
            btn5.Size = new Size(140, 120);
            btn5.TabIndex = 6;
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += Button_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.SeaShell;
            btn6.Font = new Font("Yet R", 36F);
            btn6.ForeColor = Color.Maroon;
            btn6.Location = new Point(306, 255);
            btn6.Name = "btn6";
            btn6.Size = new Size(140, 120);
            btn6.TabIndex = 7;
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += Button_Click;
            // 
            // btn7
            // 
            btn7.BackColor = Color.SeaShell;
            btn7.Font = new Font("Yet R", 36F);
            btn7.ForeColor = Color.Maroon;
            btn7.Location = new Point(11, 381);
            btn7.Name = "btn7";
            btn7.Size = new Size(140, 120);
            btn7.TabIndex = 8;
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += Button_Click;
            // 
            // btn8
            // 
            btn8.BackColor = Color.SeaShell;
            btn8.Font = new Font("Yet R", 36F);
            btn8.ForeColor = Color.Maroon;
            btn8.Location = new Point(160, 381);
            btn8.Name = "btn8";
            btn8.Size = new Size(140, 120);
            btn8.TabIndex = 9;
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += Button_Click;
            // 
            // btn9
            // 
            btn9.BackColor = Color.SeaShell;
            btn9.Font = new Font("Yet R", 36F);
            btn9.ForeColor = Color.Maroon;
            btn9.Location = new Point(306, 381);
            btn9.Name = "btn9";
            btn9.Size = new Size(140, 120);
            btn9.TabIndex = 10;
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += Button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(834, 511);
            Controls.Add(btn9);
            Controls.Add(btn7);
            Controls.Add(btn8);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Label lblPlayerO;
        private Label lblPlayerX;
        private Label label3;
        private Label label2;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnExit;
        private Button btnReset;
        private Button btnNewGame;
    }
}

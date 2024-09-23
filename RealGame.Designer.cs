namespace TicTacToee
{
    partial class RealGame
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 22F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(108, 44);
            label1.Name = "label1";
            label1.Size = new Size(264, 60);
            label1.TabIndex = 2;
            label1.Text = "Tic Tac Toe";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 26F);
            button1.Location = new Point(58, 138);
            button1.Name = "button1";
            button1.Size = new Size(112, 103);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = true;
            button1.Click += ButtonClicked;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 26F);
            button2.Location = new Point(176, 138);
            button2.Name = "button2";
            button2.Size = new Size(112, 103);
            button2.TabIndex = 4;
            button2.UseVisualStyleBackColor = true;
            button2.Click += ButtonClicked;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 26F);
            button3.Location = new Point(294, 138);
            button3.Name = "button3";
            button3.Size = new Size(112, 103);
            button3.TabIndex = 5;
            button3.UseVisualStyleBackColor = true;
            button3.Click += ButtonClicked;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 26F);
            button4.Location = new Point(58, 247);
            button4.Name = "button4";
            button4.Size = new Size(112, 103);
            button4.TabIndex = 6;
            button4.UseVisualStyleBackColor = true;
            button4.Click += ButtonClicked;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 26F);
            button5.Location = new Point(176, 247);
            button5.Name = "button5";
            button5.Size = new Size(112, 103);
            button5.TabIndex = 7;
            button5.UseVisualStyleBackColor = true;
            button5.Click += ButtonClicked;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 26F);
            button6.Location = new Point(294, 247);
            button6.Name = "button6";
            button6.Size = new Size(112, 103);
            button6.TabIndex = 8;
            button6.UseVisualStyleBackColor = true;
            button6.Click += ButtonClicked;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 26F);
            button7.Location = new Point(58, 356);
            button7.Name = "button7";
            button7.Size = new Size(112, 103);
            button7.TabIndex = 9;
            button7.UseVisualStyleBackColor = true;
            button7.Click += ButtonClicked;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 26F);
            button8.Location = new Point(176, 356);
            button8.Name = "button8";
            button8.Size = new Size(112, 103);
            button8.TabIndex = 10;
            button8.UseVisualStyleBackColor = true;
            button8.Click += ButtonClicked;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 26F);
            button9.Location = new Point(294, 356);
            button9.Name = "button9";
            button9.Size = new Size(112, 103);
            button9.TabIndex = 11;
            button9.UseVisualStyleBackColor = true;
            button9.Click += ButtonClicked;
            // 
            // button10
            // 
            button10.Location = new Point(160, 483);
            button10.Name = "button10";
            button10.Size = new Size(142, 64);
            button10.TabIndex = 12;
            button10.Text = "Restart Game";
            button10.UseVisualStyleBackColor = true;
            button10.Click += RestartGame;
            // 
            // RealGame
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 646);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "RealGame";
            Text = "RealGame";
            
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
    }
}
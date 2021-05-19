
namespace Recursion_Exercises
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
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.Btn_Solve_Maze = new System.Windows.Forms.Button();
            this.Btn_Fibonacci_Sequence = new System.Windows.Forms.Button();
            this.Btn_SquareRoots = new System.Windows.Forms.Button();
            this.Btn_SquareRoot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDisplay.Location = new System.Drawing.Point(12, 12);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDisplay.Size = new System.Drawing.Size(401, 123);
            this.TxtDisplay.TabIndex = 0;
            // 
            // Btn_Solve_Maze
            // 
            this.Btn_Solve_Maze.Location = new System.Drawing.Point(12, 317);
            this.Btn_Solve_Maze.Name = "Btn_Solve_Maze";
            this.Btn_Solve_Maze.Size = new System.Drawing.Size(401, 30);
            this.Btn_Solve_Maze.TabIndex = 1;
            this.Btn_Solve_Maze.Text = "Solve Maze";
            this.Btn_Solve_Maze.UseVisualStyleBackColor = true;
            this.Btn_Solve_Maze.Click += new System.EventHandler(this.Btn_Solve_Maze_Click);
            // 
            // Btn_Fibonacci_Sequence
            // 
            this.Btn_Fibonacci_Sequence.Location = new System.Drawing.Point(12, 141);
            this.Btn_Fibonacci_Sequence.Name = "Btn_Fibonacci_Sequence";
            this.Btn_Fibonacci_Sequence.Size = new System.Drawing.Size(401, 30);
            this.Btn_Fibonacci_Sequence.TabIndex = 2;
            this.Btn_Fibonacci_Sequence.Text = "Fibonacci Sequence";
            this.Btn_Fibonacci_Sequence.UseVisualStyleBackColor = true;
            this.Btn_Fibonacci_Sequence.Click += new System.EventHandler(this.Btn_Fibonacci_Sequence_Click);
            // 
            // Btn_SquareRoots
            // 
            this.Btn_SquareRoots.Location = new System.Drawing.Point(12, 177);
            this.Btn_SquareRoots.Name = "Btn_SquareRoots";
            this.Btn_SquareRoots.Size = new System.Drawing.Size(401, 30);
            this.Btn_SquareRoots.TabIndex = 3;
            this.Btn_SquareRoots.Text = "Factorial Calculator";
            this.Btn_SquareRoots.UseVisualStyleBackColor = true;
            this.Btn_SquareRoots.Click += new System.EventHandler(this.Btn_SquareRoots_Click);
            // 
            // Btn_SquareRoot
            // 
            this.Btn_SquareRoot.Location = new System.Drawing.Point(12, 213);
            this.Btn_SquareRoot.Name = "Btn_SquareRoot";
            this.Btn_SquareRoot.Size = new System.Drawing.Size(401, 30);
            this.Btn_SquareRoot.TabIndex = 4;
            this.Btn_SquareRoot.Text = "Square Calculator";
            this.Btn_SquareRoot.UseVisualStyleBackColor = true;
            this.Btn_SquareRoot.Click += new System.EventHandler(this.Btn_SquareRoot_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 359);
            this.Controls.Add(this.Btn_SquareRoot);
            this.Controls.Add(this.Btn_SquareRoots);
            this.Controls.Add(this.Btn_Fibonacci_Sequence);
            this.Controls.Add(this.Btn_Solve_Maze);
            this.Controls.Add(this.TxtDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtDisplay;
        private System.Windows.Forms.Button Btn_Solve_Maze;
        private System.Windows.Forms.Button Btn_Fibonacci_Sequence;
        private System.Windows.Forms.Button Btn_SquareRoots;
        private System.Windows.Forms.Button Btn_SquareRoot;
    }
}


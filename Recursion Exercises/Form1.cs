using Microsoft.VisualBasic;
using System;
using System.IO;
using System.Windows.Forms;

namespace Recursion_Exercises
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /* Write the recursive method.
         * Sequence 1: 0,1,1,2,3,5,8,13,21, .....
         * x[n] = x[n-1] + x[n-2]*/
        private void Btn_Fibonacci_Sequence_Click(object sender, EventArgs e) // get the starting and ending positions for the sequence
        {
            TxtDisplay.Text = "";
            int startingPosition = Convert.ToInt32(Interaction.InputBox("Enter the starting position."));
            int endingPosition = Convert.ToInt32(Interaction.InputBox("Enter the ending position."));

            for (int position = startingPosition; position <= endingPosition; position++)
                TxtDisplay.Text += "Position: " + position + "\t" + "Sequence Value: " + Fibonacci_Calculator(position) + Environment.NewLine;
        }
        int Fibonacci_Calculator(int _position)
        {
            if (_position == 0) // Base Case: Root of the sequence
                return 0;
            else if (_position == 1) // Base Case: Root of the sequence
                return 1;
            else
                return _ = Fibonacci_Calculator(_position - 1) + Fibonacci_Calculator(_position - 2);
        }

        /* recursive loop for working out factorials
         * 5! = 5 x 4 x 3 x 2 x 1
         * 5! = 120 */
        private void Btn_SquareRoots_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text = "";
            int factorial = Convert.ToInt32(Interaction.InputBox("Enter the number you wish to factorise."));

            TxtDisplay.Text = factorial + "\t" + "Factorial: " + Factorial_Calculater(factorial) + Environment.NewLine;

        }
        int Factorial_Calculater(int _factorial)
        {
            if (_factorial == 1)
                return 1;
            else
                return _ = _factorial * Factorial_Calculater(_factorial - 1);
        }

        /* Recursive loop for working out squares
         * square[n] = square[n-1] + 2[n] - 1 */
        private void Btn_SquareRoot_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text = "";
            int square = Convert.ToInt32(Interaction.InputBox("Enter the number you wish to square."));
            TxtDisplay.Text += square + "\t" + "Square: " + Square_Calculator(square) + Environment.NewLine;
        }
        int Square_Calculator(int _square)
        {
            if (_square <= 0)
                return 0;
            else
                return _ = Square_Calculator(_square - 1) + 2 * _square - 1;
        }

        /* loading in a file and solving a maze using a 2d array */
        string[,] grid;
        private void Btn_Solve_Maze_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text = "";
            Load_From_File();
            Display_Grid(grid, "Original Maze");
            int startX = Find_Coordinates_By_Value(grid, "S").Item1;
            int startY = Find_Coordinates_By_Value(grid, "S").Item2;

            if (Solve_Maze(startX, startY))
            {
                TxtDisplay.Text += "End of maze reached" + Environment.NewLine;
                Display_Grid(grid, "Solved Path");
            }
            else
                TxtDisplay.Text += "There is no possible path";
        }
        void Load_From_File()
        {
            string path = Application.StartupPath + "/Maze1.txt";

            // Load the grid into an array
            using (StreamReader reader = new StreamReader(path))
            {
                int rows = Convert.ToInt32(reader.ReadLine());
                int columns = Convert.ToInt32(reader.ReadLine());
                grid = new string[rows, columns];

                for (int row = 0; row < grid.GetLength(0); row++)
                {
                    string currentRow = reader.ReadLine(); // grab the whole row and store it in a local string

                    for (int column = 0; column < grid.GetLength(1); column++)
                    {
                        grid[row, column] = currentRow.Substring(column, 1); // populate the columns by the string split into individual cells on the row
                    }
                }
            }
        }
        void Display_Grid(string [,] _grid, string _info)
        {
            TxtDisplay.Text += _info + Environment.NewLine;
            for (int x = 0; x < _grid.GetLength(0); x++)
            {
                for (int y = 0; y < _grid.GetLength(1); y++)
                {
                    TxtDisplay.Text += grid[x, y];
                }
                TxtDisplay.Text += Environment.NewLine;
            }
        }
        bool Solve_Maze(int _x, int _y)
        {
            bool isFinished = false;

            if (Is_Valid_Position(_x, _y))
            {

                if (_x == Find_Coordinates_By_Value(grid, "E").Item1 && _y == Find_Coordinates_By_Value(grid, "E").Item2) // if we land on the coordinates of the Exit
                    isFinished = true;
                else
                {
                    grid[_x, _y] = "!"; // marks the current position in the maze as well as where we've been before

                    isFinished = Solve_Maze(_x + 1, _y); // go right
                    if (!isFinished)
                        isFinished = Solve_Maze(_x - 1, _y); // go left
                    if (!isFinished)
                        isFinished = Solve_Maze(_x, _y + 1); // go down
                    if (!isFinished)
                        isFinished = Solve_Maze(_x, _y - 1); // go up
                }

                if (isFinished) // once we have the correct path, mark it with a "."
                {
                    grid[_x, _y] = ".";
                }
                
            }

            return isFinished;
        }
        Tuple<int, int> Find_Coordinates_By_Value(string[,] _grid, string _value)
        {
            int width = _grid.GetLength(0);
            int height = _grid.GetLength(1);

            for (int x = 0; x < width; ++x)
            {
                for (int y = 0; y < height; ++y)
                {
                    if (_grid[x, y] == _value)
                        return Tuple.Create(x, y); // returns the coordinates as a Tuple in the array for the first value matching _value
                }
            }

            return Tuple.Create(-1, -1); // if there is no value that matches _value then return a Tuple with (-1,-1)
        }
        bool Is_Valid_Position(int _x, int _y)
        {
            bool isValid = false;

            int rows = grid.GetLength(0);
            int columns = grid.GetLength(1);

            if (_x >= 0 && _x < rows && _y >= 0 && _y < columns) // ensures that we stay within the bounds of the array
            {
                if (grid[_x, _y] == "0" || grid[_x, _y] == "S" || grid[_x, _y] == "E") // "0" is a valid block that hasn’t been explored yet
                    isValid = true;
            }

            return isValid;
        }
    }
}

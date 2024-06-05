using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_Work_Graphics
{
    public partial class Game : Form
    {
        // Змінні для символів гравців та інформації про хід
        string player1, player2;
        private bool currentPlayer;
        private string[,] board = new string[3, 3];
        private Label currentPlayerLabel;

        public Game()
        {
            InitializeComponent();
            this.FormClosing += Game_FormClosing;
            this.Shown += Game_Shown;

            // Налаштування Label для відображення поточного гравця
            currentPlayerLabel = new Label();
            currentPlayerLabel.Text = "Ходить гравець 1";
            currentPlayerLabel.Location = new Point(165, 475);
            currentPlayerLabel.Size = new Size(270, 30);
            currentPlayerLabel.Font = new Font("Comic Sans MS", 18f);
            currentPlayerLabel.ForeColor = Color.LightSeaGreen;
            currentPlayerLabel.BackColor = Color.Transparent;
            this.Controls.Add(currentPlayerLabel);
        }

        // Обробник події Shown для відображення діалогового вікна вибору символів
        private void Game_Shown(object sender, EventArgs e)
        {
            ShowSymbolChoiceDialog();
        }

        // Відображення діалогового вікна вибору символів
        private void ShowSymbolChoiceDialog()
        {
            Form dialog = new Form();
            dialog.Text = "Хрестики нулики";
            dialog.StartPosition = FormStartPosition.CenterParent;
            dialog.FormBorderStyle = FormBorderStyle.FixedSingle;
            dialog.ControlBox = false;
            dialog.MaximizeBox = false;
            dialog.MinimizeBox = false;
            dialog.Size = new Size(300, 150);

            Label label = new Label();
            label.Text = "Оберіть символ для гравця 1 (X/O)";
            label.Location = new Point(15, 15);
            label.Size = new Size(270, 30);
            dialog.Controls.Add(label);

            Button xButton = new Button();
            xButton.Text = "X";
            xButton.Location = new Point(15, 60);
            xButton.Size = new Size(75, 30);
            xButton.Click += (sender, e) =>
            {
                player1 = "X";
                player2 = "O";
                dialog.Close();
            };
            dialog.Controls.Add(xButton);

            Button oButton = new Button();
            oButton.Text = "O";
            oButton.Location = new Point(105, 60);
            oButton.Size = new Size(75, 30);
            oButton.Click += (sender, e) =>
            {
                player1 = "O";
                player2 = "X";
                dialog.Close();
            };
            dialog.Controls.Add(oButton);

            dialog.ShowDialog();
            currentPlayer = true;
        }

        // Закриття форми
        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        // Обробник події натискання на кнопку-комірку ігрового поля
        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            if (clickedButton.Text == string.Empty)
            {
                string symbol = currentPlayer ? player1 : player2;
                clickedButton.Text = symbol;

                int row = clickedButton.TabIndex / 3;
                int col = clickedButton.TabIndex % 3;
                board[row, col] = symbol;

                Point[] winningCombination = CheckForWinner(row, col);
                if (winningCombination != null)
                {
                    HighlightWinningCells(winningCombination);
                    MessageBox.Show($"{symbol} переміг!");
                    AskToPlayAgain();
                }
                else if (CheckForDraw())
                {
                    MessageBox.Show("Нічия!");
                    AskToPlayAgain();
                }

                currentPlayer = !currentPlayer;
                UpdateCurrentPlayerLabel();
            }
        }

        // Перевірка наявності виграшної комбінації
        private Point[] CheckForWinner(int row, int col)
        {
            string symbol = board[row, col];
            Point[] winningCombination = new Point[3];

            // Перевірка рядка
            if (board[row, 0] == symbol && board[row, 1] == symbol && board[row, 2] == symbol)
            {
                return new Point[] { new Point(row, 0), new Point(row, 1), new Point(row, 2) };
            }

            // Перевірка стовпця
            if (board[0, col] == symbol && board[1, col] == symbol && board[2, col] == symbol)
            {
                return new Point[] { new Point(0, col), new Point(1, col), new Point(2, col) };
            }

            // Перевірка діагоналі
            if (board[0, 0] == symbol && board[1, 1] == symbol && board[2, 2] == symbol)
            {
                return new Point[] { new Point(0, 0), new Point(1, 1), new Point(2, 2) };
            }

            if (board[0, 2] == symbol && board[1, 1] == symbol && board[2, 0] == symbol)
            {
                return new Point[] { new Point(0, 2), new Point(1, 1), new Point(2, 0) };
            }

            return null;
        }

        // Підсвічування виграшних комірок
        private void HighlightWinningCells(Point[] winningCombination)
        {
            foreach (Point point in winningCombination)
            {
                foreach (Control control in Controls)
                {
                    if (control is Button button && button.Name.StartsWith("button"))
                    {
                        int index = button.TabIndex;
                        int row = index / 3;
                        int col = index % 3;
                        if (row == point.X && col == point.Y)
                        {
                            button.BackColor = Color.PaleTurquoise;
                        }
                    }
                }
            }
        }

        // Метод для перевірки наявності нічиєї
        private bool CheckForDraw()
        {
            foreach (string cell in board)
            {
                if (string.IsNullOrEmpty(cell))
                {
                    return false;
                }
            }
            return true;
        }

        // Відображення діалогового вікна з питанням про продовження гри
        private void AskToPlayAgain()
        {
            Form dialog = new Form();
            dialog.Text = "Гра завершена";
            dialog.StartPosition = FormStartPosition.CenterParent;
            dialog.FormBorderStyle = FormBorderStyle.FixedSingle;
            dialog.ControlBox = false;
            dialog.MaximizeBox = false;
            dialog.MinimizeBox = false;
            dialog.Size = new Size(300, 150);

            Label label = new Label();
            label.Text = "Бажаєте зіграти ще раз?";
            label.Location = new Point(15, 15);
            label.Size = new Size(270, 30);
            dialog.Controls.Add(label);

            Button yesButton = new Button();
            yesButton.Text = "Так";
            yesButton.Location = new Point(15, 60);
            yesButton.Size = new Size(75, 30);
            yesButton.Click += (sender, e) =>
            {
                dialog.Close();
                ResetGame();
            };
            dialog.Controls.Add(yesButton);

            Button noButton = new Button();
            noButton.Text = "Ні";
            noButton.Location = new Point(105, 60);
            noButton.Size = new Size(75, 30);
            noButton.Click += (sender, e) =>
            {
                dialog.Close();
                Application.Exit();
            };
            dialog.Controls.Add(noButton);
            dialog.ShowDialog();
        }

        // Метод для скидання гри
        private void ResetGame()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = null;
                }
            }

            foreach (Control control in Controls)
            {
                if (control is Button button && button.Name.StartsWith("button"))
                {
                    button.Text = string.Empty;
                    button.BackColor = Color.Silver;
                }
            }

            currentPlayer = true;
            UpdateCurrentPlayerLabel(); // Оновлення Label про поточного гравця при ресеті гри
        }

        // Повернення в Menu
        private void ButBackToMenu_Click(object sender, EventArgs e)
        {
            Menu MenuForm = new Menu(); // Ініціалізуємо форму правил
            MenuForm.Show(); // Відображаємо форму правил
            this.Hide(); // Приховуємо поточну форму
        }

        // Завершення роботи
        private void ButClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Метод для оновлення інформації про поточного гравця
        private void UpdateCurrentPlayerLabel()
        {
            currentPlayerLabel.Text = currentPlayer ? "Ходить гравець 1" : "Ходить гравець 2";
        }
    }
}


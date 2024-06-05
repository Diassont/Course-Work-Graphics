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
    public partial class Rules : Form
    {
        // Ініціалізація компонентів форми Rules
        public Rules()
        {
            InitializeComponent();
            this.FormClosing += Rules_FormClosing; // Закриття форми
        }

        private void ButBackToMenu_Click(object sender, EventArgs e)
        {
            Menu MenuForm = new Menu(); // Створюємо екземпляр форми Menu
            MenuForm.Show(); // Відображаємо форму Menu
            this.Hide(); // Приховуємо поточну форму Rules
        }

        private void Rules_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit(); // Завершення роботи
            }
        }

        private void ButGame_Click(object sender, EventArgs e)
        {
            Game GameForm = new Game(); // Створюємо екземпляр форми Game
            GameForm.Show(); // Відображаємо форму Game
            this.Hide(); // Приховуємо поточну форму Rules
        }
    }
}


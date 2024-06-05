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
    public partial class Menu : Form
    {
        // Ініціалізація компонентів форми Menu
        public Menu()
        {
            InitializeComponent();
            this.FormClosing += Menu_FormClosing; //  Закриття форми
        }

        private void ButRules_Click(object sender, EventArgs e)
        {
            Rules RulesForm = new Rules(); // Створюємо екземпляр форми Rules
            RulesForm.Show(); // Відображаємо форму Rules
            this.Hide(); // Приховуємо поточну форму Menu
        }

        private void ButClose_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Завершення роботи
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
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
            this.Hide(); // Приховуємо поточну форму Menu
        }
    }
}

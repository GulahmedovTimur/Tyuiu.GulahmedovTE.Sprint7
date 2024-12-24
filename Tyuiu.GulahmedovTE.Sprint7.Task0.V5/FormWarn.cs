using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.GulahmedovTE.Sprint7.Task0.V5
{
    public partial class FormWarn : Form
    {
        public bool ConfirmationResult { get; private set; }

        public FormWarn()
        {
            InitializeComponent();
            ConfirmationResult = false;
        }

        private void buttonYes_GTE_Click(object sender, EventArgs e)
        {
            ConfirmationResult = true; // Устанавливаем результат - согласие на очистку
            this.Close();
        }

        private void buttonNo_GTE_Click(object sender, EventArgs e)
        {
            ConfirmationResult = false; // Устанавливаем результат - отказ от очистки
            this.Close();
        }

        private void buttonYes_GTE_MouseEnter(object sender, EventArgs e)
        {
            buttonYes_GTE.BackColor = Color.Red;
        }

        private void buttonYes_GTE_MouseLeave(object sender, EventArgs e)
        {
            buttonYes_GTE.BackColor = SystemColors.Control;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shoes
{
    public partial class Authorization : Form
    {

        bool check;
        System.Timers.Timer timer;

        public Authorization()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Кнопк закрытия приложения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BrExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Кнопка входа в систему
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtEnter_Click(object sender, EventArgs e)
        {
            var filterUser = Program.logic.UserRowFilter(TbLogin.Text, TbPassword.Text);
            if (filterUser != null)
            {
                ListProducts listProducts = new ListProducts();
                switch (filterUser.IdRole)
                {
                    case 1:
                        MessageBox.Show("Вы вошли как админ");
                        Hide();
                        listProducts.ShowDialog();
                        Show();
                        break;
                    case 2:
                        MessageBox.Show("Вы вошли как менеджер");
                        Hide();
                        listProducts.ShowDialog();
                        Show();
                        break;
                    case 3:
                        MessageBox.Show("Вы вошли как клиент");
                        Hide();
                        listProducts.ShowDialog();
                        Show();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Вы ввели неверные данные");
                StartTimer();
            }               
        }

        private void StartTimer()
        {
            check = true;
            BtEnter.Text = "Заблокировано";
            timer = new System.Timers.Timer(10000);
            timer.Elapsed += Access;
            timer.Start();
            BtEnter.Enabled = false;
        }

        private void Access(object sender, EventArgs e)
        {
            BtEnter.BeginInvoke(new Action(() =>
            {
                BtEnter.Text = "Войти";
                BtEnter.Enabled = true;
            }));
            check = false;
            timer.Close();
        }

        /// <summary>
        /// Метод скрытия и отображения введенных данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (CbCheck.Checked)
            {
                TbLogin.UseSystemPasswordChar = true;
                TbPassword.UseSystemPasswordChar = true;
            }
            else
            {
                TbLogin.UseSystemPasswordChar = false;
                TbPassword.UseSystemPasswordChar = false;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Program.param.auth = true;

            ListProducts listProducts = new ListProducts();
            Hide();
            listProducts.ShowDialog();
            Show();
        }
    }
}

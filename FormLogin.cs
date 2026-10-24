using ShoesTest1.Models;
using System.Data;

namespace ShoesTest1
{
    public partial class FormLogin : Form
    {
        public User CurrentUser { get; private set; }
        public bool IsGuest { get; private set; }
        public FormLogin()
        {
            InitializeComponent();
        }

        private void BntLogin_Click(object sender, EventArgs e)
        {
            if (
                String.IsNullOrWhiteSpace(txtLogin.Text)
            )
            {
                MessageBox.Show(
                    "Введите логин",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            using (var db = new MagShoes1Context())
            {
                var user = db.Users
                    .Where(w => w.Login == txtLogin.Text)
                    .FirstOrDefault();
                if (user != null)
                {
                    CurrentUser = user;
                    IsGuest = false;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(
                        "Неверный логин",
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }
        private void BigGuest_Click(object sender, EventArgs e)
        {
            CurrentUser = null;
            IsGuest = true;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

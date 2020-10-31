using BLL.Services;
using BLL.Views;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms.MenuForms
{
    public partial class ProfileForm : Form
    {
        readonly private UserRegistrationModel _user;
        readonly private UserService _userService;
        public ProfileForm(UserRegistrationModel user, UserService userService)
        {
            _user = user;
            _userService = userService;

            InitializeComponent();
            SetUpForm();
        }

        private void SetUpForm()
        {
            textBox_name.Text = _user.Name;
            textBox_login.Text = _user.Login;
            textBox_pwd.Text = _user.Password;
            textBox_age.Text = _user.Age.ToString();
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {

        }

        private void button_save_Click(object sender, EventArgs e)
        {
            UserRegistrationModel model = new UserRegistrationModel();
            if(textBox_login.Text == _user.Login || _userService.IsLoginExists(textBox_login.Text))
            {
                model.Id = _user.Id;
                model.Name = textBox_name.Text;
                model.Login = textBox_login.Text;
                model.Password = textBox_pwd.Text;
                model.Age = Convert.ToInt32(textBox_age.Text);

                var user = _userService.RegToUser(model);
                if(_userService.UpdateUser(user))
                {
                    MessageBox.Show(
                        "User succesfully updated!",
                        "Ok",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(
                        "Invalid data!",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(
                    "User with the same login already exists!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            this.Close();
        }
    }
}

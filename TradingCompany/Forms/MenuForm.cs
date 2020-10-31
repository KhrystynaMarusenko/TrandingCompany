using BLL.Services;
using BLL.Views;
using DTO;
using Forms.MenuForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TradingCompany.BLL;

namespace Forms
{
    public partial class MenuForm : Form
    {
        private readonly ItemService _itemService;
        private readonly ReviewService _reviewService;
        private readonly CategoryService _categoryService;
        private readonly UserService _userService;
        private readonly UserDTO _user;


        public MenuForm(ItemService itemService, ReviewService reviewService,
            CategoryService categoryService, UserService userService, UserDTO user)
        {
            _itemService = itemService;
            _reviewService = reviewService;
            _categoryService = categoryService;
            _userService = userService;
            _user = user;

            InitializeComponent();
            SetUpForm();
        }

        private void SetUpForm()
        {
            label_name.Text = string.Format("Hello, {0}!\n{1}", _user.Name, _user.Login);
        }

        private void button_sign_out_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_profile_Click(object sender, EventArgs e)
        {
            ProfileForm profile = DependencyInjectorBLL.Resolve<ProfileForm>(
                );
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tradingCompanyDataSet.Review' table. You can move, or remove it, as needed.
            //this.reviewTableAdapter.Fill(this.tradingCompanyDataSet.Review);
            reviewBindingSource.DataSource = _reviewService.GetByItem("Pants");
            // TODO: This line of code loads data into the 'tradingCompanyDataSet.Item' table. You can move, or remove it, as needed.
            //this.itemTableAdapter.Fill(this.tradingCompanyDataSet.Item);
            // TODO: This line of code loads data into the 'tradingCompanyDataSet1.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.tradingCompanyDataSet1.Category);
            //this.reviewViewModelBindingSource.Fill(this.tradingCompanyDataSet.Review);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            itemBindingSource.DataSource = _itemService.GetByCategory(comboBox_category.Text);
        }

        private void dataGridViewItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int i = dataGridViewItems.CurrentCell.RowIndex;
            reviewViewModelBindingSource.DataSource = _reviewService.GetByItem(dataGridViewItems[0, i].Value.ToString());

        }
    }
}

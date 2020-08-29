using ControlTienda.Data;
using ControlTienda.Data.Entities;
using ControlTienda.Encrypt;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ControlTienda.FrondEnd
{
    /// <summary>
    /// Lógica de interacción para UserWindow.xaml
    /// </summary>
    public partial class UserWindow : Window
    {
        public UserWindow()
        {
            InitializeComponent();

            RefreshDataGrid();
            RefreshComboBox();
        }

   
        private void btnRol_Click(object sender, RoutedEventArgs e)
        {
            RolManager rolManager = new RolManager();
            rolManager.Show();
        }
        private void RefreshDataGrid()
        {
            dgUser.ItemsSource = null;
            dgUser.ItemsSource = UserRepository.UserToList();
        }
        public void RefreshComboBox()
        {
            cbRol.ItemsSource = RolRepository.AllRolTolist();
            cbRol.DisplayMemberPath ="Name";
            cbRol.DisplayMemberPath = "Id";
        }
        

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            string name, address, phone, nickname, password;
            User user = new User();Rol rol = new Rol();
            Encrypting encrypting = new Encrypting();
            DataContext context = new DataContext();
            UserRepository repository = new UserRepository(context);
            RolRepository rolRepository = new RolRepository(context);

            name = tbName.Text;
            address = tbAddress.Text;
            nickname = tbNickNme.Text;
            phone = tbPhone.Text;
            password = tbPassword.Password;
            int id = (from u in context.users
                      where u.Nickname == nickname
                      select u.Id).FirstOrDefault();
            if (!repository.Exist(id))
            {
                user.Name = name;
                user.Nickname = nickname;
                user.Address = address;
                user.Password = password;
                user.Phone = phone;
                user.RolId = Convert.ToInt32(cbRol.SelectedValue);
                repository.Create(user);
                MessageBox.Show("User Created");
                RefreshDataGrid();
            }
            else
                MessageBox.Show("The User Nick exist, change it please");
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            int id = (int)((Button)sender).CommandParameter;
            DataContext context = new DataContext();
            UserRepository userrepository = new UserRepository(context);
            var UserDel = userrepository.GetById(id);
            userrepository.Delete(UserDel);
            RefreshDataGrid();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            DataContext context = new DataContext();
            UserRepository userRepository = new UserRepository(context);
            Encrypting encrypting = new Encrypting();

            int Id = (int)((Button)sender).CommandParameter;
            var user = userRepository.GetById(Id);
            user.Name = tbName.Text;
            user.Address = tbAddress.Text;
            user.Phone = tbPhone.Text;
            user.Nickname = tbNickNme.Text;
            user.Password = encrypting.GetSha256(tbPassword.Password);
            user.RolId = Convert.ToInt16(cbRol.SelectedValue);
            userRepository.Update(user);
            RefreshDataGrid();
        }

        private void DgUser_mouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var UserSelect = dgUser.SelectedItem as User;
            FILLTextBox(UserSelect);
        }
        private void FILLTextBox(User user)
        {
            tbName.Text = user.Name; tbAddress.Text = user.Address;
            tbPhone.Text = user.Phone; tbNickNme.Text = user.Nickname;
            tbPassword.Password = user.Password;
        }
    }
}

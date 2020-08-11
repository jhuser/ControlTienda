


namespace ControlTienda
{
    using ControlTienda.Data;
    using ControlTienda.Data.Entities;
    using ControlTienda.Encrypt;
    using System;
    using System.Collections.Generic;
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
    using System.Windows.Navigation;
    using System.Windows.Shapes;
    
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btnaceptar_Click(object sender, RoutedEventArgs e)
        {
           
            DataContext context = new DataContext();
            GenericRepository<User> generic = new GenericRepository<User>(context);
            Encrypting en = new Encrypting();
            string nick = tbUserName.Text;         
            var user = (from u in context.users where u.Nickname == nick select u).FirstOrDefault();
            if (!(user == null))
            {
                if (!generic.Exist(user.Id))
                    MessageBox.Show("user does not exist.. ", "WARNING");
                else
                {

                    string pass = tbPassword.Password;
                    if (en.GetSha256(pass) == user.Password)
                    {
                        MessageBox.Show("Logueado.. "+user.Name);
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Password");
                    }
                }

            }
            else
            {
                MessageBox.Show("user does not exist....", " WARNING");
            }
            

          
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}

using ControlTienda.Data;
using ControlTienda.Data.Entities;
using ControlTienda.Encrypt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
    /// Lógica de interacción para RolManager.xaml
    /// </summary>
    public partial class RolManager : Window
    {
        public RolManager()
        {
            InitializeComponent();
            RefreshGrid();
           
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            Rol rol = new Rol();
            DataContext context = new DataContext();
            RolRepository rolRepository = new RolRepository(context);
            UserWindow window = new UserWindow();
            string name, details;
            name = tbName.Text;
            details = tbDetail.Text;
            if (!rolRepository.Exist(rolRepository.ObtainId(name)))
            {
                rol.Name = name;
                rol.Details = details;
                rolRepository.Create(rol);
                MessageBox.Show("Rol Created! " + name);
                window.RefreshComboBox();
                RefreshGrid();
            }
            else
                MessageBox.Show("Rol exist, change the name.");

        }
        private void RefreshGrid()
        {
            Rol rol = new Rol();
            dgRol.ItemsSource = null;
            dgRol.ItemsSource = RolRepository.AllRolTolist().OrderBy(r => r.Name);
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            int id = (int)((Button)sender).CommandParameter;
            DataContext context = new DataContext();
            RolRepository rolrepository = new RolRepository(context);
            var RolDel = rolrepository.GetById(id);
            rolrepository.Delete(RolDel);
            RefreshGrid();
        }
        private void Window_Closed(object sender, EventArgs e)
        {
            UserWindow window = new UserWindow();
            window.RefreshComboBox();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            DataContext context = new DataContext();
            RolRepository rolRepository = new RolRepository(context);

            int Id = (int)((Button)sender).CommandParameter;

            var rol = rolRepository.GetById(Id);
            rol.Name = tbName.Text;
            rol.Details = tbDetail.Text;

            rolRepository.Update(rol);
            RefreshGrid();
        }
        private void DgRols_mouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var RolSelected = dgRol.SelectedItem as Rol;
            FillTextBox(RolSelected);
        }
        private void FillTextBox(Rol rolSelected)
        {
            tbName.Text = rolSelected.Name;
            tbDetail.Text = rolSelected.Details;
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}

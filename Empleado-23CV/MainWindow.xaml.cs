using Empleado_23CV.Context;
using Empleado_23CV.Entities;
using Empleado_23CV.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

namespace Empleado_23CV
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        Empleado empl = new Empleado();
        EmpleadoServices services = new EmpleadoServices();
        public void Button_Click(object sender, RoutedEventArgs e)
        {
           

            empl.Nombre = txtNombre.Text;
            empl.Apellido = txtApellido.Text;
            empl.Correo = txtCorreo.Text;

            services.Add(empl);

            txtNombre.Clear();
            txtApellido.Clear();
            txtCorreo.Clear();
            MessageBox.Show("Los datos se guardaron correctamente");
        }

        public void Button_Ver_Click(object sender, RoutedEventArgs e)
        {
            EmpleadoServices services=new EmpleadoServices();
            int id= int.Parse(txtID.Text);
            var response = services.Equals(id);
            txtNombre.Text = response.ToString();
            txtApellido.Text = response.ToString();
            txtCorreo.Text = response.ToString();


        }

        public void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(txtID.Text, out int id))
            {
                Empleado empleadoActualizado = new Empleado()
                {
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Correo = txtCorreo.Text,
                    FechaIngreso = DateTime.Now
                };

                services.Editar(id, empleadoActualizado);

                MessageBox.Show("Empleado actualizado correctamente");

                txtID.Clear();
                txtNombre.Clear();
                txtApellido.Clear();
                txtCorreo.Clear();
                txtFechaIngreso.Clear();
            }
            else
            {
                MessageBox.Show("Ocurrior un erro");
            }
        }

        public void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(txtID.Text, out int id))
            {
                services.Eliminar(id);

                MessageBox.Show("Empleado eliminado correctamente");

                txtID.Clear();
                txtNombre.Clear();
                txtApellido.Clear();
                txtCorreo.Clear();
                txtFechaIngreso.Clear();
            }
            else
            {
                MessageBox.Show("Ocurrio un error");
            }
        }

        public void Button_Click_3(object sender, RoutedEventArgs e)
        {
            txtID.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtCorreo.Clear();
            txtFechaIngreso.Clear();
        }
    }
}

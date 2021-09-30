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
using System.Windows.Shapes;

namespace _99_Listado_Alumnos
{
    /// <summary>
    /// Lógica de interacción para EditarAlumno.xaml
    /// </summary>
    public partial class EditarAlumno : Window
    {
        public Alumno editar { get; set; }
        public EditarAlumno()
        {
            InitializeComponent();
        }

        private void editarAlumno_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string nombre = editarNombre.Text;
                string apellido = editarApellido.Text;
                string dni = editarDNI.Text;
                string legajo = editarLegajo.Text;
                string ciudad = editarCiudad.Text;
                Alumno alumnoEditado = new Alumno(nombre, apellido, dni, legajo, ciudad);

                if(alumnoEditado != null)
                {
                    ((MainWindow)Application.Current.MainWindow).Alumnos.Remove(editar);
                    ((MainWindow)Application.Current.MainWindow).AgregarAlumno(alumnoEditado);
                }             
                this.Close();
            }
            catch (Exception)
            {

            }
        }

        private void eliminarAlumno_Click(object sender, RoutedEventArgs e)
        {
            // Initializes the variables to pass to the MessageBox.Show method.
            string message = "Está seguro que desea eliminar este elemento?.";
            string caption = "Atención. Usted está por eliminar un elemento.";
            MessageBoxButton buttons = MessageBoxButton.YesNo;

            // Displays the MessageBox.
            var result = MessageBox.Show(message, caption, buttons);

            if (result.ToString() == "Yes")
            {
                ((MainWindow)Application.Current.MainWindow).Alumnos.Remove(editar);
                this.Close();
            }            
        }
    }
}

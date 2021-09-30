using System;
using System.Windows;

namespace _99_Listado_Alumnos
{
    /// <summary>
    /// Lógica de interacción para AgregarAlumno.xaml
    /// </summary>
    public partial class AgregarAlumno : Window
    {
        public AgregarAlumno()
        {
            InitializeComponent();
        }

        private void agregarAlumno_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string nombre = ingresarNombre.Text;
                string apellido = ingresarApellido.Text;
                string dni = ingresarDNI.Text;
                string legajo = ingresarLegajo.Text;
                string ciudad = ingresarCiudad.Text;

                Alumno nuevoAlumno = new Alumno(nombre, apellido, dni, legajo, ciudad);

                ((MainWindow)Application.Current.MainWindow).AgregarAlumno(nuevoAlumno);
                this.Close();
            }
            catch (Exception)
            {

            }
        }
    }
}

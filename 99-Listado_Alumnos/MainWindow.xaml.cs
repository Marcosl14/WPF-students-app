using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace _99_Listado_Alumnos
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Alumno> Alumnos { get; set; }

        public MainWindow()
        {
            Alumnos = new List<Alumno>();

            OpenFileDialog abrirArchivo = new OpenFileDialog();
            abrirArchivo.Filter = "TXT files|*.txt";
            abrirArchivo.FileName = @"..\..\ListadoAlumnos.txt"; //dos veces porque salimos de la carpeta debug, salimos de la carpeta bin, y entramos en la carpeta principal.

            AbrirArchivo(abrirArchivo.FileName);

            

            InitializeComponent();
        }

        #region Eventos
        private void MenuItem_AbrirArchivo_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog abrirArchivo = new OpenFileDialog();
            abrirArchivo.Filter = "TXT files|*.txt";
            /*
            Antes de la | solo se pasa info para el usuario. Luego de la barra vertical, se informa al sistema, 
            que archivos están permitidos, separados por punto y coma (*.png;*.jpg;*.jpeg).
            Además, se puede agregar una segunda barra vertical, para establece otro método de búsqueda alternativo. 
            Finalmente quedaría: "Image Files (*.png; *.jpg)|*.png;*.jpg;*.jpeg|All files(*.*)|*.*"
            */
            abrirArchivo.FileName = @"D:\Visual Studio\WPF\99-Listado_Alumnos\99-Listado_Alumnos\ListadoAlumnos.txt";

            if (abrirArchivo.ShowDialog() == true)
            {
                AbrirArchivo(abrirArchivo.FileName);
                listadoAlumnosListBox.Items.Refresh();
            }
        }

        private void MenuItem_GuardarArchivo_Click(object sender, RoutedEventArgs e)
        {
            string texto = "";

            foreach (Alumno alumno in Alumnos)
            {
                texto += string.Format("{0}/{1}/{2}/{3}/{4}\n", alumno.Nombre, alumno.Apellido, alumno.DNI, alumno.Legajo, alumno.Ciudad);
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "ListadoAlumnos";
            saveFileDialog.DefaultExt = ".txt";
            saveFileDialog.Filter = "Text documents (.txt)|*.txt";
            saveFileDialog.InitialDirectory = @"D:\Visual Studio\WPF\99-Listado_Alumnos\99-Listado_Alumnos\ListadoAlumnos.txt";

            if (saveFileDialog.ShowDialog() == true)
            {
                File.WriteAllText(saveFileDialog.FileName, texto);
            }
        }

        private void MenuItem_CerrarArchivo_Click(object sender, RoutedEventArgs e)
        {
            Alumnos.Clear();
            listadoAlumnosListBox.Items.Refresh();
        }

        private void MenuItem_NuevoArchivo_Click(object sender, RoutedEventArgs e)
        {
            Alumnos.Clear();
            listadoAlumnosListBox.Items.Refresh();
        }

        private void NuevoAlumno_Click(object sender, RoutedEventArgs e)
        {
            AgregarAlumno nuevaVentana = new AgregarAlumno();
            nuevaVentana.ShowDialog(); //ShowDialog para bloquear la ventana principal, cuando esta ventana secundaria se abre.
        }

        private void listadoAlumnosListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            EditarAlumno editarAlumno = new EditarAlumno();

            if (listadoAlumnosListBox.SelectedItem != null)
            {
                Alumno alumno = listadoAlumnosListBox.SelectedItem as Alumno;

                editarAlumno.editar = alumno;

                editarAlumno.editarNombre.Text = alumno.Nombre;
                editarAlumno.editarApellido.Text = alumno.Apellido;
                editarAlumno.editarDNI.Text = alumno.DNI;
                editarAlumno.editarLegajo.Text = alumno.Legajo;
                editarAlumno.editarCiudad.Text = alumno.Ciudad;

                editarAlumno.ShowDialog();
                listadoAlumnosListBox.Items.Refresh();
            }

            else
            {
                editarAlumno.Close();
            }
        }

        private void botonBuscar_Click(object sender, RoutedEventArgs e)
        {
            if (buscarTextBox.Text == string.Empty)
            {
                listadoAlumnosListBox.ItemsSource = Alumnos;
            }
            else
            {
                List<Alumno> alumnosFiltrados = new List<Alumno>();
                listadoAlumnosListBox.ItemsSource = alumnosFiltrados;

                foreach (Alumno alumno in Alumnos)
                {
                    string buscar = buscarTextBox.Text.ToLower();

                    if (alumno.Nombre.ToLower().Contains(buscar) || alumno.Apellido.ToLower().Contains(buscar) || alumno.Ciudad.ToLower().Contains(buscar) || alumno.DNI.ToString().Contains(buscar) || alumno.Legajo.ToString().Contains(buscar))
                    {
                        alumnosFiltrados.Add(alumno);
                    }
                }
            }
            listadoAlumnosListBox.Items.Refresh();
        }

        private void botonLimpiarBusqueda_Click(object sender, RoutedEventArgs e)
        {
            buscarTextBox.Text = string.Empty;
            listadoAlumnosListBox.ItemsSource = Alumnos;
            listadoAlumnosListBox.Items.Refresh();
        }
        #endregion


        #region Métodos
        public void AgregarAlumno(Alumno nuevoAlumno)
        {
            if (!ComprobarExistenciaAlumno(nuevoAlumno))
            {
                Alumnos.Add(nuevoAlumno);

                List<Alumno> nuevaListaOrdenada = Alumnos.OrderBy(elemento => elemento.Apellido).ToList();
                Alumnos.Clear();
                foreach (Alumno alumno in nuevaListaOrdenada)
                {
                    Alumnos.Add(alumno);
                }
                listadoAlumnosListBox.Items.Refresh();
            }
        }

        public bool ComprobarExistenciaAlumno(Alumno alumno)
        {
            foreach (Alumno nuevo in Alumnos)
            {
                if (Alumnos.Contains(alumno))
                {
                    MessageBox.Show("Ya existe este alumno.");
                    throw new Exception("Ya existe este alumno.");
                }
                if(nuevo.DNI == alumno.DNI)
                {
                    MessageBox.Show("Ya existe un alumno con este DNI.");
                    throw new Exception("Ya existe un alumno con este DNI.");
                }
                if(nuevo.Legajo == alumno.Legajo)
                {
                    MessageBox.Show("Ya existe un alumno con este Legajo.");
                    throw new Exception("Ya existe un alumno con este Legajo.");
                }
            }
            return false;
        }

        public void AbrirArchivo(string nombreArchivo)
        {
            Alumnos.Clear();

            string[] lineasTexto = File.ReadAllLines(nombreArchivo);
            foreach (string linea in lineasTexto)
            {
                string[] elementos = new string[5];
                elementos = linea.Split('/');

                Alumno alumno = new Alumno(elementos[0], elementos[1], elementos[2], elementos[3], elementos[4]);

                Alumnos.Add(alumno);
            }
        }
        #endregion






    }
}

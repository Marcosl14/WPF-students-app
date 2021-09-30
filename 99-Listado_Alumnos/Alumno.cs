using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace _99_Listado_Alumnos
{
    public class Alumno
    {
        //no olvidad de agregar public delante de class Alumno!!!
        #region Atributos
        private string nombre;
        private string apellido;
        private int dni;
        private int legajo;
        private string ciudad;
        #endregion

        #region Propiedades
        public string Nombre
        {
            set
            {
                bool nombreCorrecto = controlNombre(value, "Nombres");
                if (nombreCorrecto)
                {
                    string nombreNuevo = NombreOptimizado(value);
                    nombre = nombreNuevo;
                }
                else
                {
                    throw new Exception("Ingresar un valor correcto.");
                }
            }
            get
            {
                return nombre;
            }
        }
        public string Apellido
        {
            set
            {
                bool apellidoCorrecto = controlNombre(value, "Apellidos");
                if (apellidoCorrecto)
                {
                    string apellidoNuevo = NombreOptimizado(value);
                    apellido = apellidoNuevo;
                }
                else
                {
                    throw new Exception("Ingresar un valor correcto.");
                }
            }
            get
            {
                return apellido;
            }
        }
        public string DNI
        {
            set
            {
                string valorInicial = value;
                bool numeroCorrecto = controlNumero(valorInicial, "DNI", 8);
                if (numeroCorrecto)
                {
                    dni = int.Parse(value);
                }
                else
                {
                    throw new Exception("Ingresar un valor correcto.");
                }
            }
            get
            {
                return dni.ToString();
            }
        }
        public string Legajo
        {
            set
            {
                string valorInicial = value;
                bool numeroCorrecto = controlNumero(valorInicial, "Legajo", 5);
                if (numeroCorrecto)
                {
                    legajo = int.Parse(value);
                }
                else
                {
                    throw new Exception("Ingresar un valor correcto.");
                }
            }
            get
            {
                return legajo.ToString();
            }
        }
        public string Ciudad
        {
            set
            {
                bool ciudadCorrecta = controlNombre(value, "Nombres de las Ciudaded");
                if (ciudadCorrecta)
                {
                    string ciudadNueva = NombreOptimizado(value);
                    ciudad = ciudadNueva;
                }
                else
                {
                    throw new Exception("Ingresar un valor correcto.");
                }
            }
            get
            {
                return ciudad;
            }
        }
        public string AlumnoListBox
        {
            get
            {
                return (this.Apellido + ", " + this.Nombre + " (" + this.Legajo + ")");
            }
        }
        #endregion

        #region Constructores
        public Alumno(string nombre, string apellido, string dni, string legajo, string ciudad)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.DNI = dni;
            this.Legajo = legajo;
            this.Ciudad = ciudad;
        }
        #endregion

        #region Metodos

        private bool controlNombre(string texto, string tipo)
        {
            string[] listaTexto = texto.Split(' ');
            List<string> descomposicionTexto = new List<string>();

            foreach (string elemento in listaTexto)
            {
                if (elemento != "")
                {
                    descomposicionTexto.Add(elemento);
                }
            }

            if (descomposicionTexto.Count > 3)
            {
                MessageBox.Show(string.Format("Solo se permiten 3 {0}s como máximo.", tipo));
                return false;
            }
            else
            {
                foreach (string elemento in descomposicionTexto)
                {
                    if (elemento.Length < 3)
                    {
                        MessageBox.Show(string.Format("Los {0} deben contener más de 3 caractéres.", tipo));
                        return false;
                    }
                }

                foreach (char a in texto)
                {
                    if (!char.IsLetter(a) && a != ' ')
                    {
                        MessageBox.Show(string.Format("Los {0} solo pueden estar formado por letras y/o espacios.", tipo));
                        return false;
                    }
                }

                return true;
            }
        }

        public string NombreOptimizado(string texto)
        {
            string textoOptimizado = "";
            for (int i = 0; i < texto.Length; i++)
            {
                if (i == 0)
                {
                    textoOptimizado += texto[i].ToString().ToUpper();
                }
                else if (texto[i] == ' ')
                {
                    if (texto[i + 1] != ' ')
                    {
                        textoOptimizado += ' ';
                        textoOptimizado += texto[i + 1].ToString().ToUpper();
                        i++;
                    }
                }
                else
                {
                    textoOptimizado += texto[i].ToString().ToLower();
                }
            }
            return (textoOptimizado);
        }

        private bool controlNumero(string valor, string tipo, int cantidadNumeros)
        {

            foreach (char a in valor)
            {
                if (!char.IsDigit(a))
                {
                    MessageBox.Show(string.Format("El {0} solo debe contener números.", tipo));
                    return false;
                }
            }

            if (valor.Length != cantidadNumeros)
            {
                MessageBox.Show(string.Format("El {0} debe contener {1} caractéres.", tipo, cantidadNumeros));
                return false;
            }

            return true;
        }

        #endregion

    }
}

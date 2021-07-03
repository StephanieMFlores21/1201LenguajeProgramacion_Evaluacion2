using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Evaluacion2
{
    public class PromedioClase
    {
        //NOMBRE: STEPHANIE MARIELA FLORES CASTRO
        //N° CUENTA: 20181001362

        //ATRIBUTOS
        public string NombreEstudiante { get; set; }
        public long NumeroCuenta { get; set; }
        public int Nota1 { get; set; }
        public int Nota2 { get; set; }
        public int Nota3 { get; set; }
        public int Nota4 { get; set; }
        public int PromedioF { get; set; }
        public string Observacion { get; set; }

        //CONSTRUCTORES
        public PromedioClase() { }

        public PromedioClase(string _nombreEstudiante, long _numeroCuenta)
        {
            NombreEstudiante = _nombreEstudiante;
            NumeroCuenta = _numeroCuenta;
        }

        public PromedioClase(int _nota1, int _nota2, int _nota3, int _nota4, int _promediof, string _observacion)
        {
            //PROPIEDADES IGUAL A  PARÁMETROS
            Nota1 = _nota1;
            Nota2 = _nota2;
            Nota3 = _nota3;
            Nota4 = _nota4;
            PromedioF = _promediof;
            Observacion = _observacion;
        }

        //METODOS
        public string MostrarPromedioEstudiante()
        {
            PromedioF = (Nota1 + Nota2 + Nota3 + Nota4)/4;

            return "Nombre del Estudiante: " + NombreEstudiante + "; " + "Número de Cuenta: " + NumeroCuenta + "; " + "Promedio Final: " + Convert.ToInt32(PromedioF);
        }

        public string MostrarObservacion()
        {
            if (PromedioF >= 70)
            {
                Observacion = "Aprobó la asignatura";
            }
            else
            {
                Observacion = "Reprobo la asignatura";
            }

            return "Observación: " + Observacion;
        }
    }
}

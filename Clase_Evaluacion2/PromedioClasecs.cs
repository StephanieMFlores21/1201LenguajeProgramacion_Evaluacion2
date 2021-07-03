using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_Evaluacion2
{
    //NOMBRE: STEPHANIE MARIELA FLORES CASTRO
    //N° CUENTA: 20181001362

    public partial class PromedioClasecs : Form
    {
        public PromedioClasecs()
        {
            InitializeComponent();
        }

        private void Ejecutarbutton_Click(object sender, EventArgs e)
        {
            PromedioClase Stephanie = new PromedioClase();

            Stephanie.NombreEstudiante = NombreEstudianteTextBox.Text;
            Stephanie.NumeroCuenta = Convert.ToInt64(NumeroCuentatextBox.Text);
            Stephanie.Nota1 = Convert.ToInt32(Nota1textBox.Text);
            Stephanie.Nota2 = Convert.ToInt32(Nota2textBox.Text);
            Stephanie.Nota3 = Convert.ToInt32(Nota3textBox.Text);
            Stephanie.Nota4 = Convert.ToInt32(Nota4textBox.Text);

            MessageBox.Show(Stephanie.MostrarPromedioEstudiante());
            MessageBox.Show(Stephanie.MostrarObservacion());
        }
    }
}

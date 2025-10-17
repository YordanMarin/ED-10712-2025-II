using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arbol_Binario_Busqueda
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void btnInsertar_Click(object sender, EventArgs e)
    {
      try
      {
        //copia y pega todo
      }
      catch (Exception)
      {
        MessageBox.Show("Solo se permiten numeros");
      }
    }
  }
}

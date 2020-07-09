using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Indices
{
    public partial class Form1 : Form
    {
        string copy;
        private Stack<string> pila = new Stack<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void txtbNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lstbNombres.Items.Add(txtbNombre.Text);
                pila.Push(txtbNombre.Text);
                txtbNombre.Clear();
            }
        }

        private void lstbNombres_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstbNombres.SelectedIndex != -1)
            {
                lstbNombres.ContextMenuStrip = ctmenuOpcLista;
            }
            else
            {
                lstbNombres.ContextMenuStrip = null;
            }            
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstbNombres.SelectedIndex != -1)
            {
                lstbNombres.Items.RemoveAt(lstbNombres.SelectedIndex);
            }
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copy = (lstbNombres.SelectedItem).ToString();
        }

        private void moverAntesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstbNombres.SelectedIndex != -1)
            {
                lstbNombres.Items.Insert(lstbNombres.SelectedIndex - 1, lstbNombres.SelectedItem);
                lstbNombres.Items.RemoveAt(lstbNombres.SelectedIndex);
            }
        }

        private void moverDespuésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstbNombres.SelectedIndex != -1)
            {
                lstbNombres.Items.Insert(lstbNombres.SelectedIndex + 2, lstbNombres.SelectedItem);
                lstbNombres.Items.RemoveAt(lstbNombres.SelectedIndex);
            }
        }

        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstbNombres.Items.Insert(lstbNombres.SelectedIndex + 1, copy);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.ExceptionServices;

namespace Practica_SQL
{
    public partial class UI_Main : Form
    {
        List<List<string>> comboList = new List<List<string>>()
        {
            new List<string>(){ "ID", "Nombre", "Edad" },
            new List<string>(){ "Id", "Nombre", "Edad" }
        };

        DAL DAL = new DAL("localhost","db_testing");

        public UI_Main()
        {
            InitializeComponent();

            combo_Buscar.DataSource = comboList[0];
        }
        private void but_AbrirDB_Click(object sender, EventArgs e)
        {
            if (grid_Main.Columns.Count > 0)
                MessageBox.Show("La DB ya está abierta");
            else
                getAndShowTable("tbl_Personas");
        }
        private void but_CerrarDB_Click(object sender, EventArgs e)
        {
            if(grid_Main.Columns.Count == 0)
                MessageBox.Show("La DB no se encuentra abierta");
            else
                grid_Main.DataSource = null;
        }
        private void but_Eliminar_Click(object sender, EventArgs e)
        {
            if (grid_Main.Columns.Count == 0)
                MessageBox.Show("Debe cargar la base de datos primero");
            else if (grid_Main.SelectedRows.Count == 0)
                MessageBox.Show("No se ha seleccionado ninguna entrada");
            else
            {
                DAL.query_Delete("tbl_Personas", "Id", grid_Main.CurrentRow.Cells[0].Value.ToString());
                getAndShowTable("tbl_Personas");
            }
        }
        private void but_Editar_Click(object sender, EventArgs e)
        {
            if (grid_Main.Columns.Count == 0)
                MessageBox.Show("Debe cargar la base de datos primero");
            else if (grid_Main.SelectedRows.Count == 0)
                MessageBox.Show("No se ha seleccionado ninguna entrada");
            else
            {
                txt_ID.Text = grid_Main.CurrentRow.Cells[0].Value.ToString();
                txt_Nombre.Text = grid_Main.CurrentRow.Cells[1].Value.ToString();
                txt_Edad.Text = grid_Main.CurrentRow.Cells[2].Value.ToString();

                DAL.query_Delete("tbl_Personas", "Id", grid_Main.CurrentRow.Cells[0].Value.ToString());
                getAndShowTable("tbl_Personas");
            }
        }
        private void but_Agregar_Click(object sender, EventArgs e)
        {
            if (grid_Main.Columns.Count == 0)
                MessageBox.Show("Debe cargar la base de datos primero");
            else
            {
                DAL.query_Insert(
                    "tbl_Personas", 
                    new string[] { "Id", "Nombre", "Edad" }, 
                    new string[] { txt_ID.Text, txt_Nombre.Text, txt_Edad.Text });

                getAndShowTable("tbl_Personas");

                limpiarTextBoxes();
            }
        }
        private void but_Buscar_Click(object sender, EventArgs e)
        {
            if (grid_Main.Columns.Count == 0)
                MessageBox.Show("Debe cargar la base de datos primero");
            else if(txt_Buscar.Text == "")
                getAndShowTable("tbl_Personas");
            else
                getAndShowTable("tbl_Personas", comboList[1][combo_Buscar.SelectedIndex], txt_Buscar.Text);
        }
        void getAndShowTable(string table)
        {
            grid_Main.DataSource = DAL.query_Select(table);
            grid_Main.ClearSelection();
        }
        void getAndShowTable(string table, string column, string value)
        {
            grid_Main.DataSource = DAL.query_Select(table, column, value);
            grid_Main.ClearSelection();
        }
        void limpiarTextBoxes()
        {
            txt_ID.Text = "";
            txt_Nombre.Text = "";
            txt_Edad.Text = "";
        }
    }
}

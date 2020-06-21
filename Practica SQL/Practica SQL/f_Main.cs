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
    public partial class f_Main : Form
    {
        static string stringConnection = 
            "server= localhost; database=db_testing; integrated security= true";

        SqlConnection objConnection = new SqlConnection(stringConnection);

        public f_Main()
        {
            InitializeComponent();
        }
        private void but_AbrirDB_Click(object sender, EventArgs e)
        {
            if (grid_Main.Columns.Count > 0)
                MessageBox.Show("La DB ya está abierta");
            else
                getAndShowTable(querySelect());
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
            if (grid_Main.Rows.Count == 0)
                MessageBox.Show("Debe cargar la base de datos primero");
            else if (grid_Main.SelectedRows.Count == 0)
                MessageBox.Show("No se ha seleccionado ninguna entrada");
            else
            {
                executeNonQuery(queryDelete(grid_Main.CurrentRow.Cells[0].Value.ToString()));
                getAndShowTable(querySelect());
            }
        }
        private void but_Editar_Click(object sender, EventArgs e)
        {
            if (grid_Main.Rows.Count == 0)
                MessageBox.Show("Debe cargar la base de datos primero");
            else if (grid_Main.SelectedRows.Count == 0)
                MessageBox.Show("No se ha seleccionado ninguna entrada");
            else
            {
                txt_ID.Text = grid_Main.CurrentRow.Cells[0].Value.ToString();
                txt_Nombre.Text = grid_Main.CurrentRow.Cells[1].Value.ToString();
                txt_Edad.Text = grid_Main.CurrentRow.Cells[2].Value.ToString();

                executeNonQuery(queryDelete(grid_Main.CurrentRow.Cells[0].Value.ToString()));
                getAndShowTable(querySelect());
            }
        }
        private void but_Agregar_Click(object sender, EventArgs e)
        {
            if (grid_Main.Rows.Count == 0)
                MessageBox.Show("Debe cargar la base de datos primero");
            else
            {
                executeNonQuery(queryInsert(txt_ID.Text, txt_Nombre.Text, txt_Edad.Text));
                getAndShowTable(querySelect());

                limpiarTextBoxes();
            }
        }
        private void but_Buscar_Click(object sender, EventArgs e)
        {
            if (grid_Main.Rows.Count == 0)
                MessageBox.Show("Debe cargar la base de datos primero");
            else if(txt_Buscar.Text == "")
                getAndShowTable(querySelect());
            else
                getAndShowTable(querySelect(txt_Buscar.Text));
        }
        string queryInsert(string ID, string Nombre, string Edad)
        {
            return  "Insert into tbl_Personas ([Id],[Nombre],[Edad])" +
                "values ('"+ID+ "','"+Nombre+ "','"+Edad+"')";
        }
        string queryDelete(string ID)
        {
            return "Delete from tbl_Personas where Id = '" + ID + "'";
        }
        string querySelect()
        {
            return "Select * from tbl_Personas";
        }
        string querySelect(string Nombre)
        {
            return "Select * from tbl_Personas where Nombre = '" + Nombre + "'";
        }
        void getAndShowTable(string stringQuery)
        {
            SqlCommand objCommand = new SqlCommand(stringQuery, objConnection);
            SqlDataAdapter objDataAdapter = new SqlDataAdapter(objCommand);

            DataTable tbl_Main = new DataTable();
            objDataAdapter.Fill(tbl_Main);

            grid_Main.DataSource = tbl_Main;
            grid_Main.ClearSelection();
        }
        void executeNonQuery(string stringQuery)
        {
            objConnection.Open();
            try
            {
                SqlCommand objCommand = new SqlCommand(stringQuery, objConnection);
                objCommand.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                MessageBox.Show("Ya se encuentra el ID en la tabla");
            }
            objConnection.Close();
        }
        void limpiarTextBoxes()
        {
            txt_ID.Text = "";
            txt_Nombre.Text = "";
            txt_Edad.Text = "";
        }
    }
}

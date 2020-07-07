namespace Practica_SQL
{
    partial class UI_Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.but_AbrirDB = new System.Windows.Forms.Button();
            this.grid_Main = new System.Windows.Forms.DataGridView();
            this.but_Buscar = new System.Windows.Forms.Button();
            this.txt_Buscar = new System.Windows.Forms.TextBox();
            this.but_Agregar = new System.Windows.Forms.Button();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Edad = new System.Windows.Forms.TextBox();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_Edad = new System.Windows.Forms.Label();
            this.but_Editar = new System.Windows.Forms.Button();
            this.but_Eliminar = new System.Windows.Forms.Button();
            this.but_CerrarDB = new System.Windows.Forms.Button();
            this.combo_Buscar = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Main)).BeginInit();
            this.SuspendLayout();
            // 
            // but_AbrirDB
            // 
            this.but_AbrirDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.but_AbrirDB.Location = new System.Drawing.Point(27, 12);
            this.but_AbrirDB.Name = "but_AbrirDB";
            this.but_AbrirDB.Size = new System.Drawing.Size(206, 46);
            this.but_AbrirDB.TabIndex = 2;
            this.but_AbrirDB.Text = "Abrir DB";
            this.but_AbrirDB.UseVisualStyleBackColor = true;
            this.but_AbrirDB.Click += new System.EventHandler(this.but_AbrirDB_Click);
            // 
            // grid_Main
            // 
            this.grid_Main.AllowUserToAddRows = false;
            this.grid_Main.AllowUserToDeleteRows = false;
            this.grid_Main.AllowUserToResizeColumns = false;
            this.grid_Main.AllowUserToResizeRows = false;
            this.grid_Main.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_Main.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_Main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_Main.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid_Main.Location = new System.Drawing.Point(248, 12);
            this.grid_Main.Name = "grid_Main";
            this.grid_Main.ReadOnly = true;
            this.grid_Main.RowHeadersVisible = false;
            this.grid_Main.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_Main.Size = new System.Drawing.Size(833, 384);
            this.grid_Main.TabIndex = 4;
            // 
            // but_Buscar
            // 
            this.but_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.but_Buscar.Location = new System.Drawing.Point(27, 491);
            this.but_Buscar.Name = "but_Buscar";
            this.but_Buscar.Size = new System.Drawing.Size(206, 46);
            this.but_Buscar.TabIndex = 5;
            this.but_Buscar.Text = "Buscar";
            this.but_Buscar.UseVisualStyleBackColor = true;
            this.but_Buscar.Click += new System.EventHandler(this.but_Buscar_Click);
            // 
            // txt_Buscar
            // 
            this.txt_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.txt_Buscar.Location = new System.Drawing.Point(436, 496);
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.Size = new System.Drawing.Size(645, 35);
            this.txt_Buscar.TabIndex = 6;
            // 
            // but_Agregar
            // 
            this.but_Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.but_Agregar.Location = new System.Drawing.Point(27, 430);
            this.but_Agregar.Name = "but_Agregar";
            this.but_Agregar.Size = new System.Drawing.Size(206, 46);
            this.but_Agregar.TabIndex = 7;
            this.but_Agregar.Text = "Agregar";
            this.but_Agregar.UseVisualStyleBackColor = true;
            this.but_Agregar.Click += new System.EventHandler(this.but_Agregar_Click);
            // 
            // txt_ID
            // 
            this.txt_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.txt_ID.Location = new System.Drawing.Point(248, 435);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(265, 35);
            this.txt_ID.TabIndex = 8;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.txt_Nombre.Location = new System.Drawing.Point(532, 435);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(265, 35);
            this.txt_Nombre.TabIndex = 9;
            // 
            // txt_Edad
            // 
            this.txt_Edad.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.txt_Edad.Location = new System.Drawing.Point(816, 435);
            this.txt_Edad.Name = "txt_Edad";
            this.txt_Edad.Size = new System.Drawing.Size(265, 35);
            this.txt_Edad.TabIndex = 10;
            // 
            // lbl_ID
            // 
            this.lbl_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbl_ID.Location = new System.Drawing.Point(245, 400);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(268, 32);
            this.lbl_ID.TabIndex = 11;
            this.lbl_ID.Text = "ID";
            this.lbl_ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbl_Nombre.Location = new System.Drawing.Point(529, 400);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(268, 32);
            this.lbl_Nombre.TabIndex = 12;
            this.lbl_Nombre.Text = "Nombre";
            this.lbl_Nombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Edad
            // 
            this.lbl_Edad.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbl_Edad.Location = new System.Drawing.Point(813, 400);
            this.lbl_Edad.Name = "lbl_Edad";
            this.lbl_Edad.Size = new System.Drawing.Size(268, 32);
            this.lbl_Edad.TabIndex = 13;
            this.lbl_Edad.Text = "Edad";
            this.lbl_Edad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // but_Editar
            // 
            this.but_Editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.but_Editar.Location = new System.Drawing.Point(27, 350);
            this.but_Editar.Name = "but_Editar";
            this.but_Editar.Size = new System.Drawing.Size(206, 46);
            this.but_Editar.TabIndex = 14;
            this.but_Editar.Text = "Editar";
            this.but_Editar.UseVisualStyleBackColor = true;
            this.but_Editar.Click += new System.EventHandler(this.but_Editar_Click);
            // 
            // but_Eliminar
            // 
            this.but_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.but_Eliminar.Location = new System.Drawing.Point(27, 298);
            this.but_Eliminar.Name = "but_Eliminar";
            this.but_Eliminar.Size = new System.Drawing.Size(206, 46);
            this.but_Eliminar.TabIndex = 15;
            this.but_Eliminar.Text = "Eliminar";
            this.but_Eliminar.UseVisualStyleBackColor = true;
            this.but_Eliminar.Click += new System.EventHandler(this.but_Eliminar_Click);
            // 
            // but_CerrarDB
            // 
            this.but_CerrarDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.but_CerrarDB.Location = new System.Drawing.Point(27, 64);
            this.but_CerrarDB.Name = "but_CerrarDB";
            this.but_CerrarDB.Size = new System.Drawing.Size(206, 46);
            this.but_CerrarDB.TabIndex = 16;
            this.but_CerrarDB.Text = "Cerrar DB";
            this.but_CerrarDB.UseVisualStyleBackColor = true;
            this.but_CerrarDB.Click += new System.EventHandler(this.but_CerrarDB_Click);
            // 
            // combo_Buscar
            // 
            this.combo_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.combo_Buscar.FormattingEnabled = true;
            this.combo_Buscar.Location = new System.Drawing.Point(250, 497);
            this.combo_Buscar.Name = "combo_Buscar";
            this.combo_Buscar.Size = new System.Drawing.Size(169, 33);
            this.combo_Buscar.TabIndex = 17;
            // 
            // UI_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 548);
            this.Controls.Add(this.combo_Buscar);
            this.Controls.Add(this.but_CerrarDB);
            this.Controls.Add(this.but_Eliminar);
            this.Controls.Add(this.but_Editar);
            this.Controls.Add(this.lbl_Edad);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.txt_Edad);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.but_Agregar);
            this.Controls.Add(this.txt_Buscar);
            this.Controls.Add(this.but_Buscar);
            this.Controls.Add(this.grid_Main);
            this.Controls.Add(this.but_AbrirDB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "UI_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM por SQL";
            ((System.ComponentModel.ISupportInitialize)(this.grid_Main)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button but_AbrirDB;
        private System.Windows.Forms.DataGridView grid_Main;
        private System.Windows.Forms.Button but_Buscar;
        private System.Windows.Forms.TextBox txt_Buscar;
        private System.Windows.Forms.Button but_Agregar;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_Edad;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_Edad;
        private System.Windows.Forms.Button but_Editar;
        private System.Windows.Forms.Button but_Eliminar;
        private System.Windows.Forms.Button but_CerrarDB;
        private System.Windows.Forms.ComboBox combo_Buscar;
    }
}


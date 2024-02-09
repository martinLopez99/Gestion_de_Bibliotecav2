﻿namespace Gestion_de_Biblioteca.GUI.ChildForms
{
    partial class GestionLibroForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panelTabla = new Panel();
            textBusqueda = new TextBox();
            buttonBuscar = new Button();
            labelIngrese = new Label();
            buttonEliminar = new Button();
            gridLibros = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            isbn = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            autor = new DataGridViewTextBoxColumn();
            fechaPublicacion = new DataGridViewTextBoxColumn();
            editorial = new DataGridViewTextBoxColumn();
            categoria = new DataGridViewTextBoxColumn();
            ejemplaresButton = new Button();
            panelTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridLibros).BeginInit();
            SuspendLayout();
            // 
            // panelTabla
            // 
            panelTabla.BackColor = Color.FromArgb(46, 61, 66);
            panelTabla.Controls.Add(ejemplaresButton);
            panelTabla.Controls.Add(textBusqueda);
            panelTabla.Controls.Add(buttonBuscar);
            panelTabla.Controls.Add(labelIngrese);
            panelTabla.Controls.Add(buttonEliminar);
            panelTabla.Controls.Add(gridLibros);
            panelTabla.Dock = DockStyle.Fill;
            panelTabla.Location = new Point(0, 0);
            panelTabla.Margin = new Padding(2);
            panelTabla.Name = "panelTabla";
            panelTabla.Size = new Size(800, 474);
            panelTabla.TabIndex = 1;
            // 
            // textBusqueda
            // 
            textBusqueda.BackColor = Color.Gainsboro;
            textBusqueda.Location = new Point(378, 40);
            textBusqueda.Margin = new Padding(1);
            textBusqueda.Name = "textBusqueda";
            textBusqueda.Size = new Size(284, 23);
            textBusqueda.TabIndex = 6;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonBuscar.Location = new Point(674, 37);
            buttonBuscar.Margin = new Padding(2);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(89, 24);
            buttonBuscar.TabIndex = 5;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // labelIngrese
            // 
            labelIngrese.AutoSize = true;
            labelIngrese.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelIngrese.ForeColor = Color.Snow;
            labelIngrese.Location = new Point(233, 40);
            labelIngrese.Margin = new Padding(2, 0, 2, 0);
            labelIngrese.Name = "labelIngrese";
            labelIngrese.Size = new Size(121, 17);
            labelIngrese.TabIndex = 4;
            labelIngrese.Text = "Ingrese un campo";
            // 
            // buttonEliminar
            // 
            buttonEliminar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEliminar.Location = new Point(33, 81);
            buttonEliminar.Margin = new Padding(2);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(170, 38);
            buttonEliminar.TabIndex = 3;
            buttonEliminar.Text = "Eliminar Libro";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // gridLibros
            // 
            gridLibros.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridLibros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gridLibros.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            gridLibros.BackgroundColor = Color.FromArgb(37, 52, 57);
            gridLibros.BorderStyle = BorderStyle.None;
            gridLibros.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridLibros.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(30, 45, 57);
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 7.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            gridLibros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            gridLibros.ColumnHeadersHeight = 25;
            gridLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            gridLibros.Columns.AddRange(new DataGridViewColumn[] { id, isbn, nombre, autor, fechaPublicacion, editorial, categoria });
            gridLibros.EnableHeadersVisualStyles = false;
            gridLibros.GridColor = Color.FromArgb(30, 45, 57);
            gridLibros.Location = new Point(236, 81);
            gridLibros.Margin = new Padding(2);
            gridLibros.Name = "gridLibros";
            gridLibros.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(37, 52, 57);
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            gridLibros.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            gridLibros.RowHeadersVisible = false;
            gridLibros.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(37, 52, 57);
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 6.5F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(224, 224, 224);
            gridLibros.RowsDefaultCellStyle = dataGridViewCellStyle6;
            gridLibros.RowTemplate.Height = 24;
            gridLibros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridLibros.Size = new Size(527, 358);
            gridLibros.TabIndex = 0;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            id.Width = 44;
            // 
            // isbn
            // 
            isbn.HeaderText = "ISBN";
            isbn.MinimumWidth = 6;
            isbn.Name = "isbn";
            isbn.ReadOnly = true;
            isbn.Width = 59;
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombre";
            nombre.MinimumWidth = 6;
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            nombre.Width = 73;
            // 
            // autor
            // 
            autor.HeaderText = "Autor";
            autor.MinimumWidth = 6;
            autor.Name = "autor";
            autor.ReadOnly = true;
            autor.Width = 61;
            // 
            // fechaPublicacion
            // 
            fechaPublicacion.HeaderText = "Fecha de Publicación";
            fechaPublicacion.MinimumWidth = 6;
            fechaPublicacion.Name = "fechaPublicacion";
            fechaPublicacion.ReadOnly = true;
            fechaPublicacion.Width = 151;
            // 
            // editorial
            // 
            editorial.HeaderText = "Editorial";
            editorial.MinimumWidth = 6;
            editorial.Name = "editorial";
            editorial.ReadOnly = true;
            editorial.Width = 77;
            // 
            // categoria
            // 
            categoria.HeaderText = "Categoria";
            categoria.MinimumWidth = 6;
            categoria.Name = "categoria";
            categoria.ReadOnly = true;
            categoria.Width = 85;
            // 
            // ejemplaresButton
            // 
            ejemplaresButton.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ejemplaresButton.Location = new Point(33, 149);
            ejemplaresButton.Margin = new Padding(2);
            ejemplaresButton.Name = "ejemplaresButton";
            ejemplaresButton.Size = new Size(170, 38);
            ejemplaresButton.TabIndex = 7;
            ejemplaresButton.Text = "Ejemplares del Libro";
            ejemplaresButton.UseVisualStyleBackColor = true;
            ejemplaresButton.Click += ejemplaresButton_Click;
            // 
            // GestionLibroForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 474);
            Controls.Add(panelTabla);
            Margin = new Padding(2);
            Name = "GestionLibroForm";
            Text = "Gestión de Libros";
            panelTabla.ResumeLayout(false);
            panelTabla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridLibros).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel panelTabla;
        private System.Windows.Forms.DataGridView gridLibros;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Label labelIngrese;
        private System.Windows.Forms.TextBox textBusqueda;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaPublicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn editorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private Button ejemplaresButton;
    }
}

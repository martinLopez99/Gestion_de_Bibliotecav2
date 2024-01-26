﻿namespace Gestion_de_Biblioteca.GUI.ChildForms
{
    partial class GestionEjemplarForm
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
            buttonModificar = new Button();
            textBusqueda = new TextBox();
            buttonBuscar = new Button();
            labelIngrese = new Label();
            buttonEliminar = new Button();
            buttonNuevo = new Button();
            gridEjemplar = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            codigo = new DataGridViewTextBoxColumn();
            fechaAlta = new DataGridViewTextBoxColumn();
            fechaBaja = new DataGridViewTextBoxColumn();
            disponibilidad = new DataGridViewTextBoxColumn();
            panelTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridEjemplar).BeginInit();
            SuspendLayout();
            // 
            // panelTabla
            // 
            panelTabla.BackColor = Color.FromArgb(46, 61, 66);
            panelTabla.Controls.Add(buttonModificar);
            panelTabla.Controls.Add(textBusqueda);
            panelTabla.Controls.Add(buttonBuscar);
            panelTabla.Controls.Add(labelIngrese);
            panelTabla.Controls.Add(buttonEliminar);
            panelTabla.Controls.Add(buttonNuevo);
            panelTabla.Controls.Add(gridEjemplar);
            panelTabla.Dock = DockStyle.Fill;
            panelTabla.Location = new Point(0, 0);
            panelTabla.Name = "panelTabla";
            panelTabla.Size = new Size(800, 474);
            panelTabla.TabIndex = 1;
            // 
            // buttonModificar
            // 
            buttonModificar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonModificar.Location = new Point(34, 140);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(171, 38);
            buttonModificar.TabIndex = 7;
            buttonModificar.Text = "Modificar Ejemplar";
            buttonModificar.UseVisualStyleBackColor = true;
            buttonModificar.Click += buttonModificar_Click;
            // 
            // textBusqueda
            // 
            textBusqueda.BackColor = Color.Gainsboro;
            textBusqueda.Location = new Point(368, 40);
            textBusqueda.Margin = new Padding(1);
            textBusqueda.Name = "textBusqueda";
            textBusqueda.Size = new Size(294, 23);
            textBusqueda.TabIndex = 6;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonBuscar.Location = new Point(675, 38);
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
            labelIngrese.Location = new Point(234, 40);
            labelIngrese.Name = "labelIngrese";
            labelIngrese.Size = new Size(121, 17);
            labelIngrese.TabIndex = 4;
            labelIngrese.Text = "Ingrese un campo";
            // 
            // buttonEliminar
            // 
            buttonEliminar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEliminar.Location = new Point(34, 202);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(171, 38);
            buttonEliminar.TabIndex = 3;
            buttonEliminar.Text = "Eliminar Ejemplar";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // buttonNuevo
            // 
            buttonNuevo.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonNuevo.Location = new Point(34, 81);
            buttonNuevo.Name = "buttonNuevo";
            buttonNuevo.Size = new Size(171, 38);
            buttonNuevo.TabIndex = 1;
            buttonNuevo.Text = "Nuevo Ejemplar";
            buttonNuevo.UseVisualStyleBackColor = true;
            buttonNuevo.Click += buttonNuevo_Click;
            // 
            // gridEjemplar
            // 
            gridEjemplar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridEjemplar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gridEjemplar.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            gridEjemplar.BackgroundColor = Color.FromArgb(37, 52, 57);
            gridEjemplar.BorderStyle = BorderStyle.None;
            gridEjemplar.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridEjemplar.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(30, 45, 57);
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 7.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            gridEjemplar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            gridEjemplar.ColumnHeadersHeight = 25;
            gridEjemplar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            gridEjemplar.Columns.AddRange(new DataGridViewColumn[] { id, codigo, fechaAlta, fechaBaja, disponibilidad });
            gridEjemplar.EnableHeadersVisualStyles = false;
            gridEjemplar.GridColor = Color.FromArgb(30, 45, 57);
            gridEjemplar.Location = new Point(236, 81);
            gridEjemplar.Name = "gridEjemplar";
            gridEjemplar.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(37, 52, 57);
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            gridEjemplar.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            gridEjemplar.RowHeadersVisible = false;
            gridEjemplar.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(37, 52, 57);
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 6.5F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(224, 224, 224);
            gridEjemplar.RowsDefaultCellStyle = dataGridViewCellStyle6;
            gridEjemplar.RowTemplate.Height = 24;
            gridEjemplar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridEjemplar.Size = new Size(528, 358);
            gridEjemplar.TabIndex = 0;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            id.Width = 44;
            // 
            // codigo
            // 
            codigo.HeaderText = "Código";
            codigo.MinimumWidth = 6;
            codigo.Name = "codigo";
            codigo.ReadOnly = true;
            codigo.Width = 70;
            // 
            // fechaAlta
            // 
            fechaAlta.HeaderText = "Fecha de Alta";
            fechaAlta.MinimumWidth = 6;
            fechaAlta.Name = "fechaAlta";
            fechaAlta.ReadOnly = true;
            fechaAlta.Width = 109;
            // 
            // fechaBaja
            // 
            fechaBaja.HeaderText = "Fecha de Baja";
            fechaBaja.MinimumWidth = 6;
            fechaBaja.Name = "fechaBaja";
            fechaBaja.ReadOnly = true;
            fechaBaja.Width = 112;
            // 
            // disponibilidad
            // 
            disponibilidad.HeaderText = "Disponibilidad";
            disponibilidad.MinimumWidth = 6;
            disponibilidad.Name = "disponibilidad";
            disponibilidad.ReadOnly = true;
            disponibilidad.Width = 110;
            // 
            // GestionEjemplarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 474);
            Controls.Add(panelTabla);
            Name = "GestionEjemplarForm";
            Text = "Gestión de Ejemplares";
            panelTabla.ResumeLayout(false);
            panelTabla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridEjemplar).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel panelTabla;
        private System.Windows.Forms.DataGridView gridEjemplar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonNuevo;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Label labelIngrese;
        private System.Windows.Forms.TextBox textBusqueda;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaAlta;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaBaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn disponibilidad;
    }
}
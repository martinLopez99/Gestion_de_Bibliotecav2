﻿namespace Gestion_de_Biblioteca.GUI.ChildForms
{
    partial class GestionPrestamoForm
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
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTabla = new System.Windows.Forms.Panel();
            this.textBusqueda = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.labelIngrese = new System.Windows.Forms.Label();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonNuevo = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDevolucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTabla
            // 
            this.panelTabla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(66)))));
            this.panelTabla.Controls.Add(this.textBusqueda);
            this.panelTabla.Controls.Add(this.buttonBuscar);
            this.panelTabla.Controls.Add(this.labelIngrese);
            this.panelTabla.Controls.Add(this.buttonEliminar);
            this.panelTabla.Controls.Add(this.buttonModificar);
            this.panelTabla.Controls.Add(this.buttonNuevo);
            this.panelTabla.Controls.Add(this.dataGrid);
            this.panelTabla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTabla.Location = new System.Drawing.Point(0, 0);
            this.panelTabla.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelTabla.Name = "panelTabla";
            this.panelTabla.Size = new System.Drawing.Size(686, 411);
            this.panelTabla.TabIndex = 1;
            // 
            // textBusqueda
            // 
            this.textBusqueda.BackColor = System.Drawing.Color.Gainsboro;
            this.textBusqueda.Location = new System.Drawing.Point(388, 35);
            this.textBusqueda.Margin = new System.Windows.Forms.Padding(1);
            this.textBusqueda.Name = "textBusqueda";
            this.textBusqueda.Size = new System.Drawing.Size(180, 20);
            this.textBusqueda.TabIndex = 6;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonBuscar.Location = new System.Drawing.Point(578, 32);
            this.buttonBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(76, 21);
            this.buttonBuscar.TabIndex = 5;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // labelIngrese
            // 
            this.labelIngrese.AutoSize = true;
            this.labelIngrese.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelIngrese.ForeColor = System.Drawing.Color.Snow;
            this.labelIngrese.Location = new System.Drawing.Point(200, 35);
            this.labelIngrese.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIngrese.Name = "labelIngrese";
            this.labelIngrese.Size = new System.Drawing.Size(185, 17);
            this.labelIngrese.TabIndex = 4;
            this.labelIngrese.Text = "Ingrese un nombre o código";
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonEliminar.Location = new System.Drawing.Point(29, 182);
            this.buttonEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(146, 33);
            this.buttonEliminar.TabIndex = 3;
            this.buttonEliminar.Text = "Eliminar Préstamo";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonModificar.Location = new System.Drawing.Point(29, 126);
            this.buttonModificar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(146, 33);
            this.buttonModificar.TabIndex = 2;
            this.buttonModificar.Text = "Modificar Préstamo";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // buttonNuevo
            // 
            this.buttonNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonNuevo.Location = new System.Drawing.Point(29, 70);
            this.buttonNuevo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonNuevo.Name = "buttonNuevo";
            this.buttonNuevo.Size = new System.Drawing.Size(146, 33);
            this.buttonNuevo.TabIndex = 1;
            this.buttonNuevo.Text = "Nuevo Prestamo";
            this.buttonNuevo.UseVisualStyleBackColor = true;
            this.buttonNuevo.Click += new System.EventHandler(this.buttonNuevo_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(57)))));
            this.dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid.ColumnHeadersHeight = 25;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.fechaEntrega,
            this.fechaVencimiento,
            this.fechaDevolucion,
            this.notificacion});
            this.dataGrid.EnableHeadersVisualStyles = false;
            this.dataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.dataGrid.Location = new System.Drawing.Point(203, 70);
            this.dataGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGrid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrid.RowTemplate.Height = 24;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(452, 310);
            this.dataGrid.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 44;
            // 
            // fechaEntrega
            // 
            this.fechaEntrega.HeaderText = "Fecha de Entrega";
            this.fechaEntrega.MinimumWidth = 6;
            this.fechaEntrega.Name = "fechaEntrega";
            this.fechaEntrega.ReadOnly = true;
            this.fechaEntrega.Width = 131;
            // 
            // fechaVencimiento
            // 
            this.fechaVencimiento.HeaderText = "Fecha de Vencimiento";
            this.fechaVencimiento.MinimumWidth = 6;
            this.fechaVencimiento.Name = "fechaVencimiento";
            this.fechaVencimiento.ReadOnly = true;
            this.fechaVencimiento.Width = 155;
            // 
            // fechaDevolucion
            // 
            this.fechaDevolucion.HeaderText = "Fecha de Devolución";
            this.fechaDevolucion.MinimumWidth = 6;
            this.fechaDevolucion.Name = "fechaDevolucion";
            this.fechaDevolucion.ReadOnly = true;
            this.fechaDevolucion.Width = 150;
            // 
            // notificacion
            // 
            this.notificacion.HeaderText = "Notificación";
            this.notificacion.MinimumWidth = 6;
            this.notificacion.Name = "notificacion";
            this.notificacion.Width = 96;
            // 
            // GestionPrestamoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 411);
            this.Controls.Add(this.panelTabla);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "GestionPrestamoForm";
            this.Text = "Gestión de Préstamos";
            this.panelTabla.ResumeLayout(false);
            this.panelTabla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.Panel panelTabla;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonNuevo;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Label labelIngrese;
        private System.Windows.Forms.TextBox textBusqueda;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaEntrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaVencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDevolucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn notificacion;
    }
}
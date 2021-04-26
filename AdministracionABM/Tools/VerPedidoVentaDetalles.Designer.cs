namespace AdministracionABM.Tools
{
    partial class VerPedidoVentaDetalles
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
            this.components = new System.ComponentModel.Container();
            this.detalleDatagrid = new System.Windows.Forms.DataGridView();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordenesDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordenesDBDataSet = new AdministracionABM.OrdenesDBDataSet();
            this.clienteTableAdapter = new AdministracionABM.OrdenesDBDataSetTableAdapters.ClienteTableAdapter();
            this.pedidoVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordenesDBDataSet1 = new AdministracionABM.OrdenesDBDataSet1();
            this.pedidoVentaTableAdapter = new AdministracionABM.OrdenesDBDataSet1TableAdapters.PedidoVentaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.detalleDatagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenesDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenesDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoVentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenesDBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // detalleDatagrid
            // 
            this.detalleDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detalleDatagrid.Location = new System.Drawing.Point(12, 12);
            this.detalleDatagrid.Name = "detalleDatagrid";
            this.detalleDatagrid.Size = new System.Drawing.Size(742, 225);
            this.detalleDatagrid.TabIndex = 0;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.ordenesDBDataSetBindingSource;
            // 
            // ordenesDBDataSetBindingSource
            // 
            this.ordenesDBDataSetBindingSource.DataSource = this.ordenesDBDataSet;
            this.ordenesDBDataSetBindingSource.Position = 0;
            // 
            // ordenesDBDataSet
            // 
            this.ordenesDBDataSet.DataSetName = "OrdenesDBDataSet";
            this.ordenesDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // pedidoVentaBindingSource
            // 
            this.pedidoVentaBindingSource.DataMember = "PedidoVenta";
            this.pedidoVentaBindingSource.DataSource = this.ordenesDBDataSet1;
            // 
            // ordenesDBDataSet1
            // 
            this.ordenesDBDataSet1.DataSetName = "OrdenesDBDataSet1";
            this.ordenesDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pedidoVentaTableAdapter
            // 
            this.pedidoVentaTableAdapter.ClearBeforeFill = true;
            // 
            // VerPedidoVentaDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 253);
            this.Controls.Add(this.detalleDatagrid);
            this.Name = "VerPedidoVentaDetalles";
            this.Text = "VerPedidoVentaDetalles";
            this.Load += new System.EventHandler(this.VerPedidoVentaDetalles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.detalleDatagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenesDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenesDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoVentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenesDBDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView detalleDatagrid;
        private System.Windows.Forms.BindingSource ordenesDBDataSetBindingSource;
        private OrdenesDBDataSet ordenesDBDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private OrdenesDBDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private OrdenesDBDataSet1 ordenesDBDataSet1;
        private System.Windows.Forms.BindingSource pedidoVentaBindingSource;
        private OrdenesDBDataSet1TableAdapters.PedidoVentaTableAdapter pedidoVentaTableAdapter;
    }
}
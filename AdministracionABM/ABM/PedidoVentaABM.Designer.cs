namespace AdministracionABM
{
    partial class PedidoVentaABM
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
            this.label1 = new System.Windows.Forms.Label();
            this.gastosenviotxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nropedidotxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.subtotaltxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.montototaltxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordenesDBDataSet = new AdministracionABM.OrdenesDBDataSet();
            this.guardarbtn = new System.Windows.Forms.Button();
            this.clienteTableAdapter = new AdministracionABM.OrdenesDBDataSetTableAdapters.ClienteTableAdapter();
            this.fechaentregadp = new System.Windows.Forms.DateTimePicker();
            this.fechapedidodp = new System.Windows.Forms.DateTimePicker();
            this.clientecb = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridViewDetalle = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.articuloscb = new System.Windows.Forms.ComboBox();
            this.articuloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordenesDBDataSetArticulo = new AdministracionABM.OrdenesDBDataSetArticulo();
            this.articuloTableAdapter = new AdministracionABM.OrdenesDBDataSetArticuloTableAdapters.ArticuloTableAdapter();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cantidadarticulotxt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.descuentoarticulotxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.entregadochb = new System.Windows.Forms.CheckBox();
            this.precioventatxt = new System.Windows.Forms.Label();
            this.subtotalarticulotxt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.estadocb = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenesDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenesDBDataSetArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha estimada de entrerga";
            // 
            // gastosenviotxt
            // 
            this.gastosenviotxt.Location = new System.Drawing.Point(168, 61);
            this.gastosenviotxt.Name = "gastosenviotxt";
            this.gastosenviotxt.Size = new System.Drawing.Size(212, 20);
            this.gastosenviotxt.TabIndex = 3;
            this.gastosenviotxt.TextChanged += new System.EventHandler(this.gastosenviotxt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gastos de envio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha pedido";
            // 
            // nropedidotxt
            // 
            this.nropedidotxt.Location = new System.Drawing.Point(481, 7);
            this.nropedidotxt.Name = "nropedidotxt";
            this.nropedidotxt.Size = new System.Drawing.Size(212, 20);
            this.nropedidotxt.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(404, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "nro pedido";
            // 
            // subtotaltxt
            // 
            this.subtotaltxt.Location = new System.Drawing.Point(481, 33);
            this.subtotaltxt.Name = "subtotaltxt";
            this.subtotaltxt.Size = new System.Drawing.Size(212, 20);
            this.subtotaltxt.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(415, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Subtotal";
            // 
            // montototaltxt
            // 
            this.montototaltxt.Location = new System.Drawing.Point(481, 61);
            this.montototaltxt.Name = "montototaltxt";
            this.montototaltxt.Size = new System.Drawing.Size(212, 20);
            this.montototaltxt.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(404, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Monto Total";
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.ordenesDBDataSet;
            // 
            // ordenesDBDataSet
            // 
            this.ordenesDBDataSet.DataSetName = "OrdenesDBDataSet";
            this.ordenesDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // guardarbtn
            // 
            this.guardarbtn.Location = new System.Drawing.Point(791, 392);
            this.guardarbtn.Name = "guardarbtn";
            this.guardarbtn.Size = new System.Drawing.Size(75, 23);
            this.guardarbtn.TabIndex = 16;
            this.guardarbtn.Text = "GUARDAR";
            this.guardarbtn.UseVisualStyleBackColor = true;
            this.guardarbtn.Click += new System.EventHandler(this.guardarbtn_Click);
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // fechaentregadp
            // 
            this.fechaentregadp.Location = new System.Drawing.Point(168, 32);
            this.fechaentregadp.Name = "fechaentregadp";
            this.fechaentregadp.Size = new System.Drawing.Size(212, 20);
            this.fechaentregadp.TabIndex = 17;
            // 
            // fechapedidodp
            // 
            this.fechapedidodp.Location = new System.Drawing.Point(165, 113);
            this.fechapedidodp.Name = "fechapedidodp";
            this.fechapedidodp.Size = new System.Drawing.Size(212, 20);
            this.fechapedidodp.TabIndex = 18;
            // 
            // clientecb
            // 
            this.clientecb.DataSource = this.clienteBindingSource;
            this.clientecb.DisplayMember = "RazonSocial";
            this.clientecb.FormattingEnabled = true;
            this.clientecb.Location = new System.Drawing.Point(168, 5);
            this.clientecb.Name = "clientecb";
            this.clientecb.Size = new System.Drawing.Size(212, 21);
            this.clientecb.TabIndex = 20;
            this.clientecb.ValueMember = "Id";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Cliente";
            // 
            // dataGridViewDetalle
            // 
            this.dataGridViewDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetalle.Location = new System.Drawing.Point(13, 236);
            this.dataGridViewDetalle.Name = "dataGridViewDetalle";
            this.dataGridViewDetalle.Size = new System.Drawing.Size(853, 150);
            this.dataGridViewDetalle.TabIndex = 21;
            this.dataGridViewDetalle.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDetalle_CellClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Detalle";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Articulos";
            // 
            // articuloscb
            // 
            this.articuloscb.DataSource = this.articuloBindingSource;
            this.articuloscb.DisplayMember = "Denominacion";
            this.articuloscb.FormattingEnabled = true;
            this.articuloscb.Location = new System.Drawing.Point(65, 189);
            this.articuloscb.Name = "articuloscb";
            this.articuloscb.Size = new System.Drawing.Size(143, 21);
            this.articuloscb.TabIndex = 24;
            this.articuloscb.ValueMember = "Id";
            this.articuloscb.SelectedIndexChanged += new System.EventHandler(this.articuloscb_SelectedIndexChanged);
            // 
            // articuloBindingSource
            // 
            this.articuloBindingSource.DataMember = "Articulo";
            this.articuloBindingSource.DataSource = this.ordenesDBDataSetArticulo;
            // 
            // ordenesDBDataSetArticulo
            // 
            this.ordenesDBDataSetArticulo.DataSetName = "OrdenesDBDataSetArticulo";
            this.ordenesDBDataSetArticulo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // articuloTableAdapter
            // 
            this.articuloTableAdapter.ClearBeforeFill = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(474, 192);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Subtotal";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(333, 194);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Cantidad";
            // 
            // cantidadarticulotxt
            // 
            this.cantidadarticulotxt.Location = new System.Drawing.Point(388, 189);
            this.cantidadarticulotxt.Name = "cantidadarticulotxt";
            this.cantidadarticulotxt.Size = new System.Drawing.Size(80, 20);
            this.cantidadarticulotxt.TabIndex = 28;
            this.cantidadarticulotxt.TextChanged += new System.EventHandler(this.cantidadarticulotxt_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(579, 190);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Descuento";
            // 
            // descuentoarticulotxt
            // 
            this.descuentoarticulotxt.Location = new System.Drawing.Point(644, 187);
            this.descuentoarticulotxt.Name = "descuentoarticulotxt";
            this.descuentoarticulotxt.Size = new System.Drawing.Size(59, 20);
            this.descuentoarticulotxt.TabIndex = 30;
            this.descuentoarticulotxt.TextChanged += new System.EventHandler(this.descuentoarticulotxt_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(710, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(791, 185);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 32;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // entregadochb
            // 
            this.entregadochb.AutoSize = true;
            this.entregadochb.Location = new System.Drawing.Point(168, 90);
            this.entregadochb.Name = "entregadochb";
            this.entregadochb.Size = new System.Drawing.Size(75, 17);
            this.entregadochb.TabIndex = 33;
            this.entregadochb.Text = "Entregado";
            this.entregadochb.UseVisualStyleBackColor = true;
            // 
            // precioventatxt
            // 
            this.precioventatxt.AutoSize = true;
            this.precioventatxt.Location = new System.Drawing.Point(285, 194);
            this.precioventatxt.Name = "precioventatxt";
            this.precioventatxt.Size = new System.Drawing.Size(13, 13);
            this.precioventatxt.TabIndex = 34;
            this.precioventatxt.Text = "0";
            // 
            // subtotalarticulotxt
            // 
            this.subtotalarticulotxt.AutoSize = true;
            this.subtotalarticulotxt.Location = new System.Drawing.Point(527, 191);
            this.subtotalarticulotxt.Name = "subtotalarticulotxt";
            this.subtotalarticulotxt.Size = new System.Drawing.Size(0, 13);
            this.subtotalarticulotxt.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "PrecioVenta";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(404, 94);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 13);
            this.label14.TabIndex = 37;
            this.label14.Text = "Estado";
            // 
            // estadocb
            // 
            this.estadocb.FormattingEnabled = true;
            this.estadocb.Location = new System.Drawing.Point(481, 88);
            this.estadocb.Name = "estadocb";
            this.estadocb.Size = new System.Drawing.Size(212, 21);
            this.estadocb.TabIndex = 38;
            // 
            // PedidoVentaABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 421);
            this.Controls.Add(this.estadocb);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.subtotalarticulotxt);
            this.Controls.Add(this.precioventatxt);
            this.Controls.Add(this.entregadochb);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.descuentoarticulotxt);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cantidadarticulotxt);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.articuloscb);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridViewDetalle);
            this.Controls.Add(this.clientecb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.fechapedidodp);
            this.Controls.Add(this.fechaentregadp);
            this.Controls.Add(this.guardarbtn);
            this.Controls.Add(this.montototaltxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.subtotaltxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nropedidotxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gastosenviotxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PedidoVentaABM";
            this.Text = "AddPedido";
            this.Load += new System.EventHandler(this.PedidoVentaABM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenesDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenesDBDataSetArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox gastosenviotxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nropedidotxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox subtotaltxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox montototaltxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button guardarbtn;
        private OrdenesDBDataSet ordenesDBDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private OrdenesDBDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.DateTimePicker fechaentregadp;
        private System.Windows.Forms.DateTimePicker fechapedidodp;
        private System.Windows.Forms.ComboBox clientecb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridViewDetalle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox articuloscb;
        private OrdenesDBDataSetArticulo ordenesDBDataSetArticulo;
        private System.Windows.Forms.BindingSource articuloBindingSource;
        private OrdenesDBDataSetArticuloTableAdapters.ArticuloTableAdapter articuloTableAdapter;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox cantidadarticulotxt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox descuentoarticulotxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox entregadochb;
        private System.Windows.Forms.Label precioventatxt;
        private System.Windows.Forms.Label subtotalarticulotxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox estadocb;
    }
}
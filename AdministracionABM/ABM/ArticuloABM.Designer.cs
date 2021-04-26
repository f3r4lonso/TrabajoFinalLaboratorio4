namespace AdministracionABM
{
    partial class ArticuloABM
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
            this.denominaciontxt = new System.Windows.Forms.TextBox();
            this.ivatxt = new System.Windows.Forms.TextBox();
            this.precioventatxt = new System.Windows.Forms.TextBox();
            this.preciocompratxt = new System.Windows.Forms.TextBox();
            this.codigotxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.preciocompravalidator = new System.Windows.Forms.Label();
            this.precioventavalidator = new System.Windows.Forms.Label();
            this.ivavalidator = new System.Windows.Forms.Label();
            this.rubrovalidator = new System.Windows.Forms.Label();
            this.rubropadreidtxt = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.rubroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordenesDBDataSetRubroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordenesDBDataSetRubro = new AdministracionABM.OrdenesDBDataSetRubro();
            this.rubroTableAdapter = new AdministracionABM.OrdenesDBDataSetRubroTableAdapters.RubroTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.rubroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenesDBDataSetRubroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenesDBDataSetRubro)).BeginInit();
            this.SuspendLayout();
            // 
            // denominaciontxt
            // 
            this.denominaciontxt.Location = new System.Drawing.Point(148, 13);
            this.denominaciontxt.Name = "denominaciontxt";
            this.denominaciontxt.Size = new System.Drawing.Size(331, 20);
            this.denominaciontxt.TabIndex = 0;
            // 
            // ivatxt
            // 
            this.ivatxt.Location = new System.Drawing.Point(148, 121);
            this.ivatxt.Name = "ivatxt";
            this.ivatxt.Size = new System.Drawing.Size(331, 20);
            this.ivatxt.TabIndex = 2;
            this.ivatxt.TextChanged += new System.EventHandler(this.ivatxt_TextChanged);
            // 
            // precioventatxt
            // 
            this.precioventatxt.Location = new System.Drawing.Point(148, 95);
            this.precioventatxt.Name = "precioventatxt";
            this.precioventatxt.Size = new System.Drawing.Size(331, 20);
            this.precioventatxt.TabIndex = 3;
            this.precioventatxt.TextChanged += new System.EventHandler(this.precioventatxt_TextChanged);
            // 
            // preciocompratxt
            // 
            this.preciocompratxt.Location = new System.Drawing.Point(148, 65);
            this.preciocompratxt.Name = "preciocompratxt";
            this.preciocompratxt.Size = new System.Drawing.Size(331, 20);
            this.preciocompratxt.TabIndex = 4;
            this.preciocompratxt.TextChanged += new System.EventHandler(this.preciocompratxt_TextChanged);
            // 
            // codigotxt
            // 
            this.codigotxt.Location = new System.Drawing.Point(148, 39);
            this.codigotxt.Name = "codigotxt";
            this.codigotxt.Size = new System.Drawing.Size(331, 20);
            this.codigotxt.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Denominacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Codigo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "PrecioCompra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Precio Venta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Iva";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Rubro Padre ID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(255, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // preciocompravalidator
            // 
            this.preciocompravalidator.AutoSize = true;
            this.preciocompravalidator.Location = new System.Drawing.Point(486, 71);
            this.preciocompravalidator.Name = "preciocompravalidator";
            this.preciocompravalidator.Size = new System.Drawing.Size(0, 13);
            this.preciocompravalidator.TabIndex = 13;
            // 
            // precioventavalidator
            // 
            this.precioventavalidator.AutoSize = true;
            this.precioventavalidator.Location = new System.Drawing.Point(485, 102);
            this.precioventavalidator.Name = "precioventavalidator";
            this.precioventavalidator.Size = new System.Drawing.Size(0, 13);
            this.precioventavalidator.TabIndex = 14;
            // 
            // ivavalidator
            // 
            this.ivavalidator.AutoSize = true;
            this.ivavalidator.Location = new System.Drawing.Point(486, 128);
            this.ivavalidator.Name = "ivavalidator";
            this.ivavalidator.Size = new System.Drawing.Size(0, 13);
            this.ivavalidator.TabIndex = 15;
            // 
            // rubrovalidator
            // 
            this.rubrovalidator.AutoSize = true;
            this.rubrovalidator.Location = new System.Drawing.Point(486, 150);
            this.rubrovalidator.Name = "rubrovalidator";
            this.rubrovalidator.Size = new System.Drawing.Size(0, 13);
            this.rubrovalidator.TabIndex = 16;
            // 
            // rubropadreidtxt
            // 
            this.rubropadreidtxt.Location = new System.Drawing.Point(148, 147);
            this.rubropadreidtxt.Name = "rubropadreidtxt";
            this.rubropadreidtxt.Size = new System.Drawing.Size(85, 20);
            this.rubropadreidtxt.TabIndex = 1;
            this.rubropadreidtxt.TextChanged += new System.EventHandler(this.rubropadreidtxt_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.rubroBindingSource;
            this.comboBox1.DisplayMember = "Denominacion";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(239, 146);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(240, 21);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.ValueMember = "Id";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // rubroBindingSource
            // 
            this.rubroBindingSource.DataMember = "Rubro";
            this.rubroBindingSource.DataSource = this.ordenesDBDataSetRubroBindingSource;
            // 
            // ordenesDBDataSetRubroBindingSource
            // 
            this.ordenesDBDataSetRubroBindingSource.DataSource = this.ordenesDBDataSetRubro;
            this.ordenesDBDataSetRubroBindingSource.Position = 0;
            // 
            // ordenesDBDataSetRubro
            // 
            this.ordenesDBDataSetRubro.DataSetName = "OrdenesDBDataSetRubro";
            this.ordenesDBDataSetRubro.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rubroTableAdapter
            // 
            this.rubroTableAdapter.ClearBeforeFill = true;
            // 
            // ArticuloABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 206);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.rubrovalidator);
            this.Controls.Add(this.ivavalidator);
            this.Controls.Add(this.precioventavalidator);
            this.Controls.Add(this.preciocompravalidator);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.codigotxt);
            this.Controls.Add(this.preciocompratxt);
            this.Controls.Add(this.precioventatxt);
            this.Controls.Add(this.ivatxt);
            this.Controls.Add(this.rubropadreidtxt);
            this.Controls.Add(this.denominaciontxt);
            this.Name = "ArticuloABM";
            this.Text = "AddArticulo";
            this.Load += new System.EventHandler(this.AddArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rubroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenesDBDataSetRubroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenesDBDataSetRubro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox denominaciontxt;
        private System.Windows.Forms.TextBox ivatxt;
        private System.Windows.Forms.TextBox precioventatxt;
        private System.Windows.Forms.TextBox preciocompratxt;
        private System.Windows.Forms.TextBox codigotxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label preciocompravalidator;
        private System.Windows.Forms.Label precioventavalidator;
        private System.Windows.Forms.Label ivavalidator;
        private System.Windows.Forms.Label rubrovalidator;
        private System.Windows.Forms.TextBox rubropadreidtxt;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource ordenesDBDataSetRubroBindingSource;
        private OrdenesDBDataSetRubro ordenesDBDataSetRubro;
        private System.Windows.Forms.BindingSource rubroBindingSource;
        private OrdenesDBDataSetRubroTableAdapters.RubroTableAdapter rubroTableAdapter;
    }
}
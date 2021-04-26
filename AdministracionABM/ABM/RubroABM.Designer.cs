namespace AdministracionABM
{
    partial class RubroABM
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
            this.codigotxt = new System.Windows.Forms.TextBox();
            this.guardar = new System.Windows.Forms.Button();
            this.denominaciontxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rubropadretxt = new System.Windows.Forms.TextBox();
            this.rpadrecombo = new System.Windows.Forms.ComboBox();
            this.rubroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordenesDBDataSetRubro = new AdministracionABM.OrdenesDBDataSetRubro();
            this.rubroTableAdapter = new AdministracionABM.OrdenesDBDataSetRubroTableAdapters.RubroTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.rubroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenesDBDataSetRubro)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // codigotxt
            // 
            this.codigotxt.Location = new System.Drawing.Point(105, 12);
            this.codigotxt.Name = "codigotxt";
            this.codigotxt.Size = new System.Drawing.Size(306, 20);
            this.codigotxt.TabIndex = 1;
            // 
            // guardar
            // 
            this.guardar.Location = new System.Drawing.Point(168, 91);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(75, 23);
            this.guardar.TabIndex = 2;
            this.guardar.Text = "GUARDAR";
            this.guardar.UseVisualStyleBackColor = true;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // denominaciontxt
            // 
            this.denominaciontxt.Location = new System.Drawing.Point(105, 38);
            this.denominaciontxt.Name = "denominaciontxt";
            this.denominaciontxt.Size = new System.Drawing.Size(306, 20);
            this.denominaciontxt.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Denominacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Rubro Padre";
            // 
            // rubropadretxt
            // 
            this.rubropadretxt.Location = new System.Drawing.Point(105, 64);
            this.rubropadretxt.Name = "rubropadretxt";
            this.rubropadretxt.Size = new System.Drawing.Size(104, 20);
            this.rubropadretxt.TabIndex = 10;
            // 
            // rpadrecombo
            // 
            this.rpadrecombo.DataSource = this.rubroBindingSource;
            this.rpadrecombo.DisplayMember = "Denominacion";
            this.rpadrecombo.FormattingEnabled = true;
            this.rpadrecombo.Location = new System.Drawing.Point(210, 64);
            this.rpadrecombo.Name = "rpadrecombo";
            this.rpadrecombo.Size = new System.Drawing.Size(201, 21);
            this.rpadrecombo.TabIndex = 11;
            this.rpadrecombo.ValueMember = "Id";
            this.rpadrecombo.SelectedIndexChanged += new System.EventHandler(this.rpadrecombo_SelectedIndexChanged);
            // 
            // rubroBindingSource
            // 
            this.rubroBindingSource.DataMember = "Rubro";
            this.rubroBindingSource.DataSource = this.ordenesDBDataSetRubro;
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
            // AddRubro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 126);
            this.Controls.Add(this.rpadrecombo);
            this.Controls.Add(this.rubropadretxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.denominaciontxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.codigotxt);
            this.Controls.Add(this.label1);
            this.Name = "AddRubro";
            this.Text = "AddRubro";
            this.Load += new System.EventHandler(this.AddRubro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rubroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenesDBDataSetRubro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox codigotxt;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.TextBox denominaciontxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox rubropadretxt;
        private System.Windows.Forms.ComboBox rpadrecombo;
        private OrdenesDBDataSetRubro ordenesDBDataSetRubro;
        private System.Windows.Forms.BindingSource rubroBindingSource;
        private OrdenesDBDataSetRubroTableAdapters.RubroTableAdapter rubroTableAdapter;
    }
}
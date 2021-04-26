namespace AdministracionABM
{
    partial class MainWindows
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
            this.ClienteBtn = new System.Windows.Forms.Button();
            this.ArticuloBtn = new System.Windows.Forms.Button();
            this.PedidoBtn = new System.Windows.Forms.Button();
            this.RubroBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pedidoVentaDetalle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ClienteBtn
            // 
            this.ClienteBtn.Location = new System.Drawing.Point(12, 426);
            this.ClienteBtn.Name = "ClienteBtn";
            this.ClienteBtn.Size = new System.Drawing.Size(75, 23);
            this.ClienteBtn.TabIndex = 0;
            this.ClienteBtn.Text = "Cliente";
            this.ClienteBtn.UseVisualStyleBackColor = true;
            this.ClienteBtn.Click += new System.EventHandler(this.ClienteBtn_Click);
            // 
            // ArticuloBtn
            // 
            this.ArticuloBtn.Location = new System.Drawing.Point(93, 426);
            this.ArticuloBtn.Name = "ArticuloBtn";
            this.ArticuloBtn.Size = new System.Drawing.Size(75, 23);
            this.ArticuloBtn.TabIndex = 1;
            this.ArticuloBtn.Text = "Articulo";
            this.ArticuloBtn.UseVisualStyleBackColor = true;
            this.ArticuloBtn.Click += new System.EventHandler(this.ArticuloBtn_Click);
            // 
            // PedidoBtn
            // 
            this.PedidoBtn.Location = new System.Drawing.Point(174, 426);
            this.PedidoBtn.Name = "PedidoBtn";
            this.PedidoBtn.Size = new System.Drawing.Size(75, 23);
            this.PedidoBtn.TabIndex = 2;
            this.PedidoBtn.Text = "Pedido";
            this.PedidoBtn.UseVisualStyleBackColor = true;
            this.PedidoBtn.Click += new System.EventHandler(this.PedidoBtn_Click);
            // 
            // RubroBtn
            // 
            this.RubroBtn.Location = new System.Drawing.Point(336, 426);
            this.RubroBtn.Name = "RubroBtn";
            this.RubroBtn.Size = new System.Drawing.Size(75, 23);
            this.RubroBtn.TabIndex = 3;
            this.RubroBtn.Text = "Rubro";
            this.RubroBtn.UseVisualStyleBackColor = true;
            this.RubroBtn.Click += new System.EventHandler(this.RubroBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(696, 388);
            this.dataGridView1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(527, 427);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Editar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(446, 427);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Agregar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(608, 427);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Borrar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pedidoVentaDetalle
            // 
            this.pedidoVentaDetalle.Location = new System.Drawing.Point(255, 426);
            this.pedidoVentaDetalle.Name = "pedidoVentaDetalle";
            this.pedidoVentaDetalle.Size = new System.Drawing.Size(75, 23);
            this.pedidoVentaDetalle.TabIndex = 10;
            this.pedidoVentaDetalle.Text = "Detalle";
            this.pedidoVentaDetalle.UseVisualStyleBackColor = true;
            this.pedidoVentaDetalle.Click += new System.EventHandler(this.pedidoVentaDetalle_Click);
            // 
            // MainWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 461);
            this.Controls.Add(this.pedidoVentaDetalle);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RubroBtn);
            this.Controls.Add(this.PedidoBtn);
            this.Controls.Add(this.ArticuloBtn);
            this.Controls.Add(this.ClienteBtn);
            this.Name = "MainWindows";
            this.Text = "MainWindows";
            this.Load += new System.EventHandler(this.MainWindows_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ClienteBtn;
        private System.Windows.Forms.Button ArticuloBtn;
        private System.Windows.Forms.Button PedidoBtn;
        private System.Windows.Forms.Button RubroBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button pedidoVentaDetalle;
    }
}
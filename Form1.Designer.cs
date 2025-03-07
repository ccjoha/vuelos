namespace vuelos
{
    partial class Form1
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
            this.Codigo = new System.Windows.Forms.TextBox();
            this.Origen = new System.Windows.Forms.TextBox();
            this.Destino = new System.Windows.Forms.TextBox();
            this.AsientosDisponibles = new System.Windows.Forms.TextBox();
            this.FechaSalida = new System.Windows.Forms.DateTimePicker();
            this.btnAgregarVuelo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listBoxVuelos = new System.Windows.Forms.DataGridView();
            this.BUSCAR = new System.Windows.Forms.Button();
            this.ListReservas = new System.Windows.Forms.DataGridView();
            this.Reservar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.PReservas = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxVuelos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // Codigo
            // 
            this.Codigo.Location = new System.Drawing.Point(63, 99);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(232, 22);
            this.Codigo.TabIndex = 0;
            // 
            // Origen
            // 
            this.Origen.Location = new System.Drawing.Point(63, 205);
            this.Origen.Name = "Origen";
            this.Origen.Size = new System.Drawing.Size(232, 22);
            this.Origen.TabIndex = 1;
            // 
            // Destino
            // 
            this.Destino.Location = new System.Drawing.Point(63, 153);
            this.Destino.Name = "Destino";
            this.Destino.Size = new System.Drawing.Size(232, 22);
            this.Destino.TabIndex = 2;
            // 
            // AsientosDisponibles
            // 
            this.AsientosDisponibles.Location = new System.Drawing.Point(63, 318);
            this.AsientosDisponibles.Name = "AsientosDisponibles";
            this.AsientosDisponibles.Size = new System.Drawing.Size(232, 22);
            this.AsientosDisponibles.TabIndex = 3;
            // 
            // FechaSalida
            // 
            this.FechaSalida.Location = new System.Drawing.Point(63, 263);
            this.FechaSalida.Name = "FechaSalida";
            this.FechaSalida.Size = new System.Drawing.Size(307, 22);
            this.FechaSalida.TabIndex = 4;
            // 
            // btnAgregarVuelo
            // 
            this.btnAgregarVuelo.Location = new System.Drawing.Point(144, 418);
            this.btnAgregarVuelo.Name = "btnAgregarVuelo";
            this.btnAgregarVuelo.Size = new System.Drawing.Size(102, 39);
            this.btnAgregarVuelo.TabIndex = 5;
            this.btnAgregarVuelo.Text = "AGREGAR";
            this.btnAgregarVuelo.UseVisualStyleBackColor = true;
            this.btnAgregarVuelo.Click += new System.EventHandler(this.btnAgregarVuelo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "CODIGO DE VUELO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "ORIGEN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "DESTINO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "FECHA DE SALIDA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "ASIENTOS DISPONIBLES";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(300, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "AGENCIA DE VUELO";
            // 
            // listBoxVuelos
            // 
            this.listBoxVuelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listBoxVuelos.Location = new System.Drawing.Point(392, 80);
            this.listBoxVuelos.Name = "listBoxVuelos";
            this.listBoxVuelos.RowHeadersWidth = 51;
            this.listBoxVuelos.RowTemplate.Height = 24;
            this.listBoxVuelos.Size = new System.Drawing.Size(563, 192);
            this.listBoxVuelos.TabIndex = 13;
            // 
            // BUSCAR
            // 
            this.BUSCAR.Location = new System.Drawing.Point(28, 418);
            this.BUSCAR.Name = "BUSCAR";
            this.BUSCAR.Size = new System.Drawing.Size(102, 39);
            this.BUSCAR.TabIndex = 14;
            this.BUSCAR.Text = "BUSCAR";
            this.BUSCAR.UseVisualStyleBackColor = true;
            this.BUSCAR.Click += new System.EventHandler(this.BUSCAR_Click);
            // 
            // ListReservas
            // 
            this.ListReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListReservas.Location = new System.Drawing.Point(392, 299);
            this.ListReservas.Name = "ListReservas";
            this.ListReservas.RowHeadersWidth = 51;
            this.ListReservas.RowTemplate.Height = 24;
            this.ListReservas.Size = new System.Drawing.Size(563, 192);
            this.ListReservas.TabIndex = 15;
            // 
            // Reservar
            // 
            this.Reservar.Location = new System.Drawing.Point(268, 418);
            this.Reservar.Name = "Reservar";
            this.Reservar.Size = new System.Drawing.Size(102, 39);
            this.Reservar.TabIndex = 16;
            this.Reservar.Text = "RESERVAR";
            this.Reservar.UseVisualStyleBackColor = true;
            this.Reservar.Click += new System.EventHandler(this.Reservar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(66, 352);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "PUESTOS A RESERVAR";
            // 
            // PReservas
            // 
            this.PReservas.Location = new System.Drawing.Point(66, 371);
            this.PReservas.Name = "PReservas";
            this.PReservas.Size = new System.Drawing.Size(232, 22);
            this.PReservas.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 562);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PReservas);
            this.Controls.Add(this.Reservar);
            this.Controls.Add(this.ListReservas);
            this.Controls.Add(this.BUSCAR);
            this.Controls.Add(this.listBoxVuelos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregarVuelo);
            this.Controls.Add(this.FechaSalida);
            this.Controls.Add(this.AsientosDisponibles);
            this.Controls.Add(this.Destino);
            this.Controls.Add(this.Origen);
            this.Controls.Add(this.Codigo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listBoxVuelos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListReservas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Codigo;
        private System.Windows.Forms.TextBox Origen;
        private System.Windows.Forms.TextBox Destino;
        private System.Windows.Forms.TextBox AsientosDisponibles;
        private System.Windows.Forms.DateTimePicker FechaSalida;
        private System.Windows.Forms.Button btnAgregarVuelo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView listBoxVuelos;
        private System.Windows.Forms.Button BUSCAR;
        private System.Windows.Forms.DataGridView ListReservas;
        private System.Windows.Forms.Button Reservar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PReservas;
    }
}


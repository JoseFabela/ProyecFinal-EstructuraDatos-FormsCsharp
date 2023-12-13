namespace Proyecto_Final_3Sem
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.listBoxHistorialAcciones = new System.Windows.Forms.ListBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btnActualizarGrafica = new System.Windows.Forms.Button();
            this.chartGananciasPerdidas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnRetirar = new System.Windows.Forms.Button();
            this.lblGananciasPerdidas = new System.Windows.Forms.Label();
            this.txtAgregarInversion = new System.Windows.Forms.TextBox();
            this.btnInvertir = new System.Windows.Forms.Button();
            this.lsHistorialInversiones = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnCambiarOrden = new System.Windows.Forms.Button();
            this.lstHistorialFinanciero = new System.Windows.Forms.ListBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBeneficiario = new System.Windows.Forms.TextBox();
            this.txtCLABE = new System.Windows.Forms.TextBox();
            this.cmbCategoriaDeTransaccion = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AgregarTransaccion = new System.Windows.Forms.Button();
            this.txtDescripcionTransaccion = new System.Windows.Forms.TextBox();
            this.txtMontoTransaccion = new System.Windows.Forms.TextBox();
            this.dtpFechaTransaccion = new System.Windows.Forms.DateTimePicker();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.txtAgregarSaldo = new System.Windows.Forms.TextBox();
            this.btnAgregarSaldo = new System.Windows.Forms.Button();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.Trasacciones = new System.Windows.Forms.TabControl();
            this.tabPage7.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGananciasPerdidas)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.Trasacciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.listBoxHistorialAcciones);
            this.tabPage7.Location = new System.Drawing.Point(4, 25);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(1311, 488);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Historial De Acciones De Usuario";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // listBoxHistorialAcciones
            // 
            this.listBoxHistorialAcciones.FormattingEnabled = true;
            this.listBoxHistorialAcciones.ItemHeight = 16;
            this.listBoxHistorialAcciones.Location = new System.Drawing.Point(40, 21);
            this.listBoxHistorialAcciones.Name = "listBoxHistorialAcciones";
            this.listBoxHistorialAcciones.Size = new System.Drawing.Size(805, 436);
            this.listBoxHistorialAcciones.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.btnActualizarGrafica);
            this.tabPage5.Controls.Add(this.chartGananciasPerdidas);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1311, 488);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Estadísticas y Gráficos";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btnActualizarGrafica
            // 
            this.btnActualizarGrafica.Location = new System.Drawing.Point(831, 126);
            this.btnActualizarGrafica.Name = "btnActualizarGrafica";
            this.btnActualizarGrafica.Size = new System.Drawing.Size(97, 29);
            this.btnActualizarGrafica.TabIndex = 1;
            this.btnActualizarGrafica.Text = "Actualizar";
            this.btnActualizarGrafica.UseVisualStyleBackColor = true;
            this.btnActualizarGrafica.Click += new System.EventHandler(this.btnActualizarGrafica_Click);
            // 
            // chartGananciasPerdidas
            // 
            chartArea1.Name = "ChartArea1";
            this.chartGananciasPerdidas.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartGananciasPerdidas.Legends.Add(legend1);
            this.chartGananciasPerdidas.Location = new System.Drawing.Point(13, 0);
            this.chartGananciasPerdidas.Name = "chartGananciasPerdidas";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartGananciasPerdidas.Series.Add(series1);
            this.chartGananciasPerdidas.Size = new System.Drawing.Size(643, 485);
            this.chartGananciasPerdidas.TabIndex = 0;
            this.chartGananciasPerdidas.Text = "chart1";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnRetirar);
            this.tabPage4.Controls.Add(this.lblGananciasPerdidas);
            this.tabPage4.Controls.Add(this.txtAgregarInversion);
            this.tabPage4.Controls.Add(this.btnInvertir);
            this.tabPage4.Controls.Add(this.lsHistorialInversiones);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1311, 488);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Inversiones";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnRetirar
            // 
            this.btnRetirar.Location = new System.Drawing.Point(1061, 157);
            this.btnRetirar.Name = "btnRetirar";
            this.btnRetirar.Size = new System.Drawing.Size(174, 39);
            this.btnRetirar.TabIndex = 4;
            this.btnRetirar.Text = "Retirar";
            this.btnRetirar.UseVisualStyleBackColor = true;
            this.btnRetirar.Click += new System.EventHandler(this.btnRetirar_Click);
            // 
            // lblGananciasPerdidas
            // 
            this.lblGananciasPerdidas.AutoSize = true;
            this.lblGananciasPerdidas.Location = new System.Drawing.Point(734, 180);
            this.lblGananciasPerdidas.Name = "lblGananciasPerdidas";
            this.lblGananciasPerdidas.Size = new System.Drawing.Size(10, 16);
            this.lblGananciasPerdidas.TabIndex = 3;
            this.lblGananciasPerdidas.Text = ".";
            // 
            // txtAgregarInversion
            // 
            this.txtAgregarInversion.Location = new System.Drawing.Point(846, 101);
            this.txtAgregarInversion.Name = "txtAgregarInversion";
            this.txtAgregarInversion.Size = new System.Drawing.Size(195, 22);
            this.txtAgregarInversion.TabIndex = 2;
            // 
            // btnInvertir
            // 
            this.btnInvertir.Location = new System.Drawing.Point(1061, 101);
            this.btnInvertir.Name = "btnInvertir";
            this.btnInvertir.Size = new System.Drawing.Size(174, 36);
            this.btnInvertir.TabIndex = 1;
            this.btnInvertir.Text = "Invertir";
            this.btnInvertir.UseVisualStyleBackColor = true;
            this.btnInvertir.Click += new System.EventHandler(this.btnInvertir_Click);
            // 
            // lsHistorialInversiones
            // 
            this.lsHistorialInversiones.FormattingEnabled = true;
            this.lsHistorialInversiones.ItemHeight = 16;
            this.lsHistorialInversiones.Location = new System.Drawing.Point(23, 0);
            this.lsHistorialInversiones.Name = "lsHistorialInversiones";
            this.lsHistorialInversiones.Size = new System.Drawing.Size(645, 452);
            this.lsHistorialInversiones.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnCambiarOrden);
            this.tabPage2.Controls.Add(this.lstHistorialFinanciero);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1311, 488);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Visualización de Historial Financiero";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnCambiarOrden
            // 
            this.btnCambiarOrden.Location = new System.Drawing.Point(1115, 450);
            this.btnCambiarOrden.Name = "btnCambiarOrden";
            this.btnCambiarOrden.Size = new System.Drawing.Size(160, 38);
            this.btnCambiarOrden.TabIndex = 1;
            this.btnCambiarOrden.Text = "Ordenar";
            this.btnCambiarOrden.UseVisualStyleBackColor = true;
            this.btnCambiarOrden.Click += new System.EventHandler(this.btnCambiarOrden_Click);
            // 
            // lstHistorialFinanciero
            // 
            this.lstHistorialFinanciero.FormattingEnabled = true;
            this.lstHistorialFinanciero.ItemHeight = 16;
            this.lstHistorialFinanciero.Location = new System.Drawing.Point(21, 18);
            this.lstHistorialFinanciero.Name = "lstHistorialFinanciero";
            this.lstHistorialFinanciero.Size = new System.Drawing.Size(1254, 436);
            this.lstHistorialFinanciero.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtBeneficiario);
            this.tabPage1.Controls.Add(this.txtCLABE);
            this.tabPage1.Controls.Add(this.cmbCategoriaDeTransaccion);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.AgregarTransaccion);
            this.tabPage1.Controls.Add(this.txtDescripcionTransaccion);
            this.tabPage1.Controls.Add(this.txtMontoTransaccion);
            this.tabPage1.Controls.Add(this.dtpFechaTransaccion);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1311, 488);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registro de Transacciones";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Beneficiario:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "CLABE:";
            // 
            // txtBeneficiario
            // 
            this.txtBeneficiario.AcceptsTab = true;
            this.txtBeneficiario.Location = new System.Drawing.Point(17, 240);
            this.txtBeneficiario.Name = "txtBeneficiario";
            this.txtBeneficiario.Size = new System.Drawing.Size(420, 22);
            this.txtBeneficiario.TabIndex = 11;
            // 
            // txtCLABE
            // 
            this.txtCLABE.AcceptsTab = true;
            this.txtCLABE.Location = new System.Drawing.Point(17, 187);
            this.txtCLABE.Name = "txtCLABE";
            this.txtCLABE.Size = new System.Drawing.Size(420, 22);
            this.txtCLABE.TabIndex = 10;
            // 
            // cmbCategoriaDeTransaccion
            // 
            this.cmbCategoriaDeTransaccion.FormattingEnabled = true;
            this.cmbCategoriaDeTransaccion.Items.AddRange(new object[] {
            "Alimentación: Comestibles, restaurantes, comida para llevar, cafeterías, etc.",
            "Vivienda: Alquiler o hipoteca, servicios públicos, reparaciones, muebles, decorac" +
                "ión, etc.",
            "Transporte: Combustible, transporte público, mantenimiento del vehículo, estacion" +
                "amiento, peajes, etc.",
            "Salud: Seguro médico, medicamentos, consultas médicas, gimnasio, artículos de cui" +
                "dado personal, etc.",
            "Entretenimiento: Cine, conciertos, eventos deportivos, libros, suscripciones a se" +
                "rvicios de transmisión, etc.",
            "Educación: Matrícula, libros de texto, material de estudio, cursos en línea, etc." +
                "",
            "Ropa y Accesorios: Ropa, calzado, accesorios, productos de cuidado personal, etc." +
                "",
            "Ahorros e Inversiones: Contribuciones a cuentas de ahorro, inversiones, contribuc" +
                "iones a planes de jubilación, etc.",
            "Deudas: Pagos de préstamos, tarjetas de crédito, etc.",
            "Viajes: Boletos de avión, alojamiento, comidas, actividades, etc.",
            "Regalos y Donaciones: Regalos para cumpleaños, ocasiones especiales, donaciones a" +
                " organizaciones benéficas, etc.",
            "Ocio: Hobbies, juegos, actividades recreativas, etc."});
            this.cmbCategoriaDeTransaccion.Location = new System.Drawing.Point(17, 44);
            this.cmbCategoriaDeTransaccion.Name = "cmbCategoriaDeTransaccion";
            this.cmbCategoriaDeTransaccion.Size = new System.Drawing.Size(567, 24);
            this.cmbCategoriaDeTransaccion.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(732, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Monto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(732, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fecha de Transaccion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Categoria de Transaccion";
            // 
            // AgregarTransaccion
            // 
            this.AgregarTransaccion.Location = new System.Drawing.Point(944, 120);
            this.AgregarTransaccion.Name = "AgregarTransaccion";
            this.AgregarTransaccion.Size = new System.Drawing.Size(75, 23);
            this.AgregarTransaccion.TabIndex = 4;
            this.AgregarTransaccion.Text = "Agregar";
            this.AgregarTransaccion.UseVisualStyleBackColor = true;
            this.AgregarTransaccion.Click += new System.EventHandler(this.AgregarTransaccion_Click);
            // 
            // txtDescripcionTransaccion
            // 
            this.txtDescripcionTransaccion.Location = new System.Drawing.Point(643, 115);
            this.txtDescripcionTransaccion.Name = "txtDescripcionTransaccion";
            this.txtDescripcionTransaccion.Size = new System.Drawing.Size(243, 22);
            this.txtDescripcionTransaccion.TabIndex = 3;
            // 
            // txtMontoTransaccion
            // 
            this.txtMontoTransaccion.AcceptsTab = true;
            this.txtMontoTransaccion.Location = new System.Drawing.Point(17, 115);
            this.txtMontoTransaccion.Name = "txtMontoTransaccion";
            this.txtMontoTransaccion.Size = new System.Drawing.Size(265, 22);
            this.txtMontoTransaccion.TabIndex = 2;
            // 
            // dtpFechaTransaccion
            // 
            this.dtpFechaTransaccion.Location = new System.Drawing.Point(662, 46);
            this.dtpFechaTransaccion.Name = "dtpFechaTransaccion";
            this.dtpFechaTransaccion.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaTransaccion.TabIndex = 1;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.txtAgregarSaldo);
            this.tabPage8.Controls.Add(this.btnAgregarSaldo);
            this.tabPage8.Controls.Add(this.lblSaldo);
            this.tabPage8.Location = new System.Drawing.Point(4, 25);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(1311, 488);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "Saldo";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // txtAgregarSaldo
            // 
            this.txtAgregarSaldo.Location = new System.Drawing.Point(317, 146);
            this.txtAgregarSaldo.Name = "txtAgregarSaldo";
            this.txtAgregarSaldo.Size = new System.Drawing.Size(175, 22);
            this.txtAgregarSaldo.TabIndex = 2;
            // 
            // btnAgregarSaldo
            // 
            this.btnAgregarSaldo.Location = new System.Drawing.Point(561, 146);
            this.btnAgregarSaldo.Name = "btnAgregarSaldo";
            this.btnAgregarSaldo.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarSaldo.TabIndex = 1;
            this.btnAgregarSaldo.Text = "Agregar";
            this.btnAgregarSaldo.UseVisualStyleBackColor = true;
            this.btnAgregarSaldo.Click += new System.EventHandler(this.btnAgregarSaldo_Click);
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(342, 71);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(120, 16);
            this.lblSaldo.TabIndex = 0;
            this.lblSaldo.Text = "Saldo Actual: $0.00";
            // 
            // Trasacciones
            // 
            this.Trasacciones.Controls.Add(this.tabPage8);
            this.Trasacciones.Controls.Add(this.tabPage1);
            this.Trasacciones.Controls.Add(this.tabPage2);
            this.Trasacciones.Controls.Add(this.tabPage4);
            this.Trasacciones.Controls.Add(this.tabPage5);
            this.Trasacciones.Controls.Add(this.tabPage7);
            this.Trasacciones.Location = new System.Drawing.Point(12, 12);
            this.Trasacciones.Name = "Trasacciones";
            this.Trasacciones.SelectedIndex = 0;
            this.Trasacciones.Size = new System.Drawing.Size(1319, 517);
            this.Trasacciones.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 736);
            this.Controls.Add(this.Trasacciones);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage7.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartGananciasPerdidas)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            this.Trasacciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox lstHistorialFinanciero;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cmbCategoriaDeTransaccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AgregarTransaccion;
        private System.Windows.Forms.TextBox txtDescripcionTransaccion;
        private System.Windows.Forms.TextBox txtMontoTransaccion;
        private System.Windows.Forms.DateTimePicker dtpFechaTransaccion;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TextBox txtAgregarSaldo;
        private System.Windows.Forms.Button btnAgregarSaldo;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.TabControl Trasacciones;
        private System.Windows.Forms.Button btnCambiarOrden;
        private System.Windows.Forms.TextBox txtBeneficiario;
        private System.Windows.Forms.TextBox txtCLABE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lsHistorialInversiones;
        private System.Windows.Forms.TextBox txtAgregarInversion;
        private System.Windows.Forms.Button btnInvertir;
        private System.Windows.Forms.Label lblGananciasPerdidas;
        private System.Windows.Forms.Button btnRetirar;
        private System.Windows.Forms.ListBox listBoxHistorialAcciones;
        private System.Windows.Forms.Button btnActualizarGrafica;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGananciasPerdidas;
    }
}


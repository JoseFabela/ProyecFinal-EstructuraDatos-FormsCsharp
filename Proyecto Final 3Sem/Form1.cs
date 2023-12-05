using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Windows.Forms.DataVisualization.Charting;
namespace Proyecto_Final_3Sem
{
    public partial class Form1 : Form
    {
        //LISTAS
        private List<Transaccion> listaTransacciones = new List<Transaccion>();
        private List<CategoriaArbol> listaCategorias;
        // Dentro de tu clase Form1
        private PortafolioInversiones portafolio;
        private System.Windows.Forms.Timer timerInversion;

        private decimal inversionInicial = 0;  // La cantidad inicial invertida
        private decimal gananciaPorMinuto = 1;  // La cantidad que se gana por minuto

        GrafoFinanciero grafo = new GrafoFinanciero();

        private enum TipoOrden
        {
            Recientes,
            Antiguos,
            PorCategoria
        }
        private TipoOrden ordenActual = TipoOrden.Recientes;

        public Form1()
        {
            InitializeComponent();
            
            this.dtpFechaTransaccion.Enabled = false;
            // Inicializar la lista de categorías
            listaCategorias = new List<CategoriaArbol>();

            // Crear un árbol de categorías
            var categoriaAlimentacion = new CategoriaArbol("Alimentación");
            var categoriaVivienda = new CategoriaArbol("Vivienda");
            var categoriaTransporte = new CategoriaArbol("Transporte");
            var categoriaSalud = new CategoriaArbol("Salud");
            var categoriaEntretenimiento = new CategoriaArbol("Entretenimiento");
            var categoriaEducacion = new CategoriaArbol("Educación");
            var categoriaRopaAccesorios = new CategoriaArbol("Ropa y Accesorios");
            var categoriaAhorrosInversiones = new CategoriaArbol("Ahorros e Inversiones");
            var categoriaDeudas = new CategoriaArbol("Deudas");
            var categoriaViajes = new CategoriaArbol("Viajes");
            var categoriaRegalosDonaciones = new CategoriaArbol("Regalos y Donaciones");
            var categoriaOcio = new CategoriaArbol("Ocio");

            categoriaAlimentacion.AgregarSubcategoria(new CategoriaArbol("Comestibles"));
            categoriaAlimentacion.AgregarSubcategoria(new CategoriaArbol("Restaurantes"));
            categoriaAlimentacion.AgregarSubcategoria(new CategoriaArbol("Comida para llevar"));
            categoriaAlimentacion.AgregarSubcategoria(new CategoriaArbol("Cafeterías"));

            // Agregar las categorías a la lista
            listaCategorias.Add(categoriaAlimentacion);
            listaCategorias.Add(categoriaVivienda);
            listaCategorias.Add(categoriaTransporte);
            listaCategorias.Add(categoriaSalud);
            listaCategorias.Add(categoriaEntretenimiento);
            listaCategorias.Add(categoriaEducacion);
            listaCategorias.Add(categoriaRopaAccesorios);
            listaCategorias.Add(categoriaAhorrosInversiones);
            listaCategorias.Add(categoriaDeudas);
            listaCategorias.Add(categoriaViajes);
            listaCategorias.Add(categoriaRegalosDonaciones);
            listaCategorias.Add(categoriaOcio);

            // Llenar el ComboBox con las categorías al cargar el formulario

            btnCambiarOrden.Click += btnCambiarOrden_Click;
            // Inicializar y configurar el temporizador
            timerInversion = new System.Windows.Forms.Timer();
            timerInversion.Interval = 60000;  // 60000 milisegundos = 1 minuto
            timerInversion.Tick += TimerInversion_Tick;
            timerInversion.Start();

            // Crear activos
            Activo accion1 = new Activo("Accion1", 1000);
            Activo bono1 = new Activo("Bono1", 500);
            Activo fondoMutuo = new Activo("FondoMutuo", 1500);


            // Crear portafolio
            portafolio = new PortafolioInversiones();

            // Agregar activos al portafolio
            portafolio.AgregarActivo(accion1);
            portafolio.AgregarActivo(bono1);
            portafolio.AgregarActivo(fondoMutuo);

            // Establecer relaciones entre activos
            portafolio.AgregarRelacion(accion1, bono1);
            portafolio.AgregarRelacion(accion1, fondoMutuo);
          
            // Agrega nodos y transacciones de ejemplo
            grafo.AgregarNodo("Categoría1");
            grafo.AgregarNodo("Categoría2");
            grafo.AgregarTransaccion("Categoría1", "Categoría2", 1000);
            grafo.AgregarTransaccion("Categoría2", "Categoría1", -500);

            // Actualiza las ganancias y pérdidas
            //grafo.ActualizarGananciasPerdidas();

            // Muestra las estadísticas en el gráfico
            // Inicializar el grafo después de la primera inversión
            grafo = new GrafoFinanciero();
            RealizarInversion(0);
        }

        private void LimpiarCamposTransaccion()
        {
            // Limpiar campos de la interfaz después de agregar una transacción
            cmbCategoriaDeTransaccion.Text = "";
            dtpFechaTransaccion.Value = DateTime.Now;
            txtMontoTransaccion.Text = "";
            txtDescripcionTransaccion.Text = "";
            txtBeneficiario.Text = "";
            txtCLABE.Text = "";
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        private void AgregarTransaccion_Click(object sender, EventArgs e)
        {
            
                // Obtener detalles de la transacción desde los controles de la interfaz
                string categoria = cmbCategoriaDeTransaccion.Text;
                DateTime fecha = dtpFechaTransaccion.Value;
               // decimal monto = decimal.Parse(txtMontoTransaccion.Text);
                string descripcion = txtDescripcionTransaccion.Text;
                string nombreDestinatario=txtBeneficiario.Text;
                string clabeDestinatario=txtCLABE.Text;

            if (decimal.TryParse(txtMontoTransaccion.Text, out decimal monto))

            {
                if (saldo - monto >= 0)
                {
                    // Crear una nueva transacción
                    Transaccion nuevaTransaccion = new Transaccion
                    {
                        Categoria = categoria,
                        Fecha = fecha,
                        Monto = monto,
                        Descripcion = descripcion,
                        DestinatarioNombre = nombreDestinatario,
                        DestinatarioCLABE = clabeDestinatario
                    };

                    // Agregar la transacción a la lista
                    listaTransacciones.Add(nuevaTransaccion);

                    // Actualizar el saldo
                    saldo -= monto;
                    // Limpiar campos después de agregar
                    LimpiarCamposTransaccion();
                    // Actualizar la visualización financiera
                    ActualizarVisualizacionFinanciera();
                    ActualizarVisualizacionSaldo();

                    AgregarConfirmacion("Transacción exitosa");
                    RealizarAccion($"Nueva transacción: {categoria + " " + monto + " " + fecha + " " + nombreDestinatario + " " + descripcion}");

                }
                else
                {
                    MessageBox.Show("Fondos insuficientes para realizar esta transacción.");
                }
            }
            else
            {
                MessageBox.Show("INGRESA UN VALOR NUMERICO");
            }
        }

        // Dentro de la clase Form1
        private void MostrarHistorialFinanciero( )
         {
            lstHistorialFinanciero.Items.Clear();

            // Obtén la categoría seleccionada en el ComboBox
            CategoriaArbol categoriaSeleccionada = cmbCategoriaDeTransaccion.SelectedItem as CategoriaArbol;

            // Filtra las transacciones por la categoría seleccionada si hay una
            var transaccionesFiltradas = categoriaSeleccionada != null
                ? listaTransacciones.Where(t => t.Categoria == categoriaSeleccionada.Nombre).ToList()
                : listaTransacciones.ToList();

            // Aplica el orden según el tipo actual
            switch (ordenActual)
            {
                case TipoOrden.Recientes:
                    transaccionesFiltradas = transaccionesFiltradas.OrderByDescending(t => t.Fecha).ToList();
                    break;
                case TipoOrden.Antiguos:
                    transaccionesFiltradas = transaccionesFiltradas.OrderBy(t => t.Fecha).ToList();
                    break;
                case TipoOrden.PorCategoria:
                    transaccionesFiltradas = transaccionesFiltradas.OrderBy(t => t.Categoria).ToList();
                    break;
            }

            // Muestra las transacciones en el ListBox
            foreach (Transaccion transaccion in transaccionesFiltradas)
            {
                string infoDestinatario = $" - Destinatario: {transaccion.DestinatarioNombre}, CLABE: {transaccion.DestinatarioCLABE}";
                lstHistorialFinanciero.Items.Add($"{transaccion.Fecha.ToShortDateString()} - {transaccion.Categoria} \n - {transaccion.Monto:C} - {transaccion.Descripcion}{infoDestinatario}");
            }

        }
        // Llama a esta función después de agregar una transacción para actualizar la visualización
        private void ActualizarVisualizacionFinanciera()
         {
             MostrarHistorialFinanciero();
             // Puedes agregar aquí la lógica para mostrar estadísticas u otras visualizaciones financieras
         }
        // Dentro de la clase Form1
        private decimal saldo = 0;

        // ...

        private void ActualizarVisualizacionSaldo()
        {
            // Actualiza la interfaz para reflejar el saldo actual
            // Puedes mostrar el saldo en una etiqueta, por ejemplo
            lblSaldo.Text = $"Saldo Actual: {saldo:C}";
        }

        private void btnAgregarSaldo_Click(object sender, EventArgs e)
        {
            // Lógica para agregar un ingreso al saldo
            //decimal montoIngreso = decimal.Parse(txtAgregarSaldo.Text);
            if (decimal.TryParse(txtAgregarSaldo.Text, out decimal montoIngreso))
            {
                saldo += montoIngreso;

                // Registrar la transacción de ingreso en el historial
                // Esto podría ser una transacción especial con categoría "Ingreso" o similar

                // Actualizar la visualización del saldo
                ActualizarVisualizacionSaldo();
                AgregarConfirmacion("Saldo agregado exitosamente");
                RealizarAccion($"Agregado saldo: {montoIngreso:C}");

                txtAgregarSaldo.Clear();
            }
            else
            {
                MessageBox.Show("INGRESA UN VALOR NUMERICO");
            }
        }
        //COLA
        private Queue<string> colaConfirmaciones = new Queue<string>();

        // ...

        // Función para agregar una confirmación a la cola
        private void AgregarConfirmacion(string mensaje)
        {
            // Agrega la confirmación a la cola
            colaConfirmaciones.Enqueue(mensaje);

            // Muestra la confirmación inmediatamente o según sea necesario
            MostrarProximaConfirmacion();
        }

        // Función para mostrar la próxima confirmación al usuario
        private void MostrarProximaConfirmacion()
        {
            if (colaConfirmaciones.Count > 0)
            {
                // Muestra la próxima confirmación al usuario
                string proximaConfirmacion = colaConfirmaciones.Dequeue();
                MessageBox.Show(proximaConfirmacion);

                // Puedes realizar acciones adicionales según el tipo de confirmación
            }
        }

        private void btnCambiarOrden_Click(object sender, EventArgs e)
        {
            // Cambiar el orden actual
            switch (ordenActual)
            {
                case TipoOrden.Recientes:
                    ordenActual = TipoOrden.Antiguos;
                    btnCambiarOrden.Text = "Antiguos";
                    break;
                case TipoOrden.Antiguos:
                    ordenActual = TipoOrden.PorCategoria;
                    btnCambiarOrden.Text = "Por Categoría";
                    break;
                case TipoOrden.PorCategoria:
                    ordenActual = TipoOrden.Recientes;
                    btnCambiarOrden.Text = "Recientes";
                    break;
            }

            // Actualizar la ListBox según el nuevo orden
            ActualizarVisualizacionFinanciera();
        }

        
        // Variables para el capital acumulado y resultados de inversiones
        private decimal CapitalAcumulado = 0;
        private List<decimal> ResultadosInversiones = new List<decimal>();
        private void btnInvertir_Click(object sender, EventArgs e)
        {

            // decimal montoInversion = decimal.Parse(txtAgregarInversion.Text);
            if (decimal.TryParse(txtAgregarInversion.Text, out decimal montoInversion))
            {
                if (montoInversion <= saldo)
                {
                    saldo = saldo - montoInversion;
                    ActualizarVisualizacionSaldo();
                    // Registrar la transacción de inversión en el historial
                   
                    // Obtener la cantidad ingresada por el usuario
                    decimal cantidadInversion = decimal.Parse(txtAgregarInversion.Text);

                    // Agregar la cantidad al capital acumulado
                    CapitalAcumulado += cantidadInversion;


                    // Mostrar el historial de inversiones
                    MostrarHistorialInversiones();
                    RealizarAccion($"Inversión realizada: {cantidadInversion:C}");
                    Invertir(montoInversion);
                    txtAgregarInversion.Clear();
                }
                else
                {
                    MessageBox.Show("No tienes el saldo suficiente");
                }
            }
            else
            {
                MessageBox.Show("INGRESA UN VALOR NUMERICO");
            }
        }
        private void TimerInversion_Tick(object sender, EventArgs e)
        {
            // Cantidad a invertir por minuto (ajusta según tus necesidades)
            decimal cantidadInversionPorMinuto = 100;

            // Realizar la inversión utilizando el capital acumulado
            RealizarInversion(cantidadInversionPorMinuto);
            // Mostrar el historial de inversiones
            MostrarHistorialInversiones();
            SimularCambiosInversion();

        }

        public void RealizarInversion(decimal cantidadInversion)
        {
            // Simular si la inversión es positiva o negativa
            bool inversionPositiva = SimularInversionPositiva();

            // Ajustar la cantidad de acuerdo con el capital acumulado
            cantidadInversion *= (1 + CapitalAcumulado / 100);

            // Calcula el resultado de la inversión
            decimal resultadoInversion = inversionPositiva ? cantidadInversion * 0.1m : -cantidadInversion * 0.05m;

            // Actualiza el capital acumulado y agrega el resultado a la lista
            CapitalAcumulado += resultadoInversion;
            ResultadosInversiones.Add(resultadoInversion);

            // Resto de la lógica...

            // Actualizar la visualización del capital acumulado y los resultados

            MostrarHistorialInversiones();
        }

        private void MostrarHistorialInversiones()
        {
            // Limpiar el ListBox antes de mostrar el historial
            lsHistorialInversiones.Items.Clear();

            // Mostrar el capital acumulado y los resultados de inversiones en el ListBox
            lsHistorialInversiones.Items.Add($"Capital Acumulado: {CapitalAcumulado:C}");

            foreach (var resultado in ResultadosInversiones)
            {
                lsHistorialInversiones.Items.Add($"Resultado de Inversión: {resultado:C}");
            }
        }
        private void SimularCambiosInversion()
        {
            // Iterar a través de los activos y simular cambios en la inversión
            foreach (var activo in portafolio.Activos)
            {
                activo.SimularCambioInversion();
            }

            // Actualizar el historial de inversiones después de simular los cambios
            MostrarHistorialInversiones();
        }
        private bool SimularInversionPositiva()
        {
            // Utiliza un generador de números aleatorios para simular la variabilidad de las inversiones
            Random random = new Random();

            // Genera un número aleatorio entre 0 y 1
            double probabilidad = random.NextDouble();

            // Establece un umbral de probabilidad para determinar si la inversión es positiva o negativa
            double umbral = 0.5; // Puedes ajustar este umbral según tus preferencias

            // Devuelve true si la probabilidad es mayor que el umbral (inversión positiva), false en caso contrario
            return probabilidad > umbral;
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            // Verifica si hay inversiones para retirar
            if (CapitalAcumulado > 0)
            {
                // Agrega el capital acumulado al saldo
                saldo += CapitalAcumulado;

                // Muestra un mensaje informando sobre la retirada de inversiones
                MessageBox.Show($"Se han retirado las inversiones. Saldo actual: {saldo:C}");
                RealizarAccion($"Inversión retirada: {CapitalAcumulado:C}");
                //Después de cada inversión, actualiza ganancias y pérdidas en el grafo
                grafo.AgregarTransaccion("Origen", "Destino", CapitalAcumulado);  // Ajusta según tu lógica
                //grafo.ActualizarGananciasPerdidas();

                // Actualizar la gráfica con los datos actualizados del grafo
                //ActualizarChart();
                // Reinicia el capital acumulado a 0
                ResultadosInversiones.Clear();
                CapitalAcumulado = 0;

                // Desactiva el temporizador si el capital acumulado llega a 0
                if (CapitalAcumulado == 0)
                {
                   // timerInversion.Stop();
                    MessageBox.Show("El sistema de inversiones ha sido desactivado debido a la falta de capital acumulado.");
                }
            }
            else
            {
                MessageBox.Show("No hay inversiones para retirar.");
            }
        }
        //PILASS
        private Stack<Accion> historialAcciones = new Stack<Accion>();
        public class Accion
        {
            public string Descripcion { get; set; }

            // Puedes agregar más propiedades según las necesidades de tu aplicación
        }
        private void RealizarAccion(string descripcion)
        {
            // Realiza la acción específica, por ejemplo, agregar saldo, realizar transacción, etc.

            // Crea una instancia de la clase Accion y guárdala en la pila
            Accion accion = new Accion { Descripcion = descripcion };
            historialAcciones.Push(accion);

            // Actualiza la interfaz o realiza otras acciones necesarias
            ActualizarInterfaz();
        }
        private void ActualizarInterfaz()
        {
            // Actualiza la interfaz gráfica según sea necesario
            // Por ejemplo, muestra la lista de acciones en un ListBox, etc.
            listBoxHistorialAcciones.Items.Clear();

            // Agrega las acciones al ListBox
            foreach (var accion in historialAcciones)
            {
                listBoxHistorialAcciones.Items.Add(accion.Descripcion);
            }

        }


        public class NodoFinanciero
        {
            public string Categoria { get; set; }
            public decimal Ganancias { get; set; }
            public decimal Perdidas { get; set; }
        }

        public class GrafoFinanciero
        {
            private Dictionary<string, NodoFinanciero> nodos;
            private List<Tuple<string, string, decimal>> transacciones;

            public GrafoFinanciero()
            {
                nodos = new Dictionary<string, NodoFinanciero>();
                transacciones = new List<Tuple<string, string, decimal>>();
            }

            public void AgregarNodo(string categoria)
            {
                nodos[categoria] = new NodoFinanciero { Categoria = categoria };
            }

            public void AgregarTransaccion(string categoriaOrigen, string categoriaDestino, decimal monto)
            {
                transacciones.Add(Tuple.Create(categoriaOrigen, categoriaDestino, monto));
            }

            public void ActualizarGananciasPerdidas()
            {
                // Reiniciar los valores
                foreach (var nodo in nodos.Values)
                {
                    nodo.Ganancias = 0;
                    nodo.Perdidas = 0;
                }

                // Calcular ganancias y pérdidas
                foreach (var transaccion in transacciones)
                {
                    // Buscar o crear nodos de origen y destino
                    NodoFinanciero categoriaOrigen = ObtenerNodo(transaccion.Item1);
                    NodoFinanciero categoriaDestino = ObtenerNodo(transaccion.Item2);

                    var monto = transaccion.Item3;

                    // Realizar cálculos en los propios nodos
                    categoriaOrigen.Ganancias += monto;
                    categoriaDestino.Perdidas += monto;
                }
            }
            public Dictionary<string, NodoFinanciero> ObtenerNodos()
            {
                return nodos;
            }
            // Método para obtener nodos (puedes ajustarlo según tus necesidades)
            private NodoFinanciero ObtenerNodo(string categoria)
            {
                if (!nodos.ContainsKey(categoria))
                {
                    nodos[categoria] = new NodoFinanciero { Categoria = categoria };
                }
                return nodos[categoria];
            }
            // Aquí podrías implementar métodos para visualizar el grafo, calcular métricas, etc.
        }
        private void ActualizarChart(List<NodoFinanciero> nodos)
        {
            // Limpiar series existentes en el Chart
            chartGananciasPerdidas.Series.Clear();

            // Crear nuevas series para ganancias y pérdidas
            Series seriesGanancias = new Series("Ganancias");
            Series seriesPerdidas = new Series("Pérdidas");

            // Agregar las series al Chart
            chartGananciasPerdidas.Series.Add(seriesGanancias);
            chartGananciasPerdidas.Series.Add(seriesPerdidas);

            // Enlazar datos directamente con las series
            foreach (var nodo in nodos)
            {
                seriesGanancias.Points.AddXY(nodo.Categoria, nodo.Ganancias);
                seriesPerdidas.Points.AddXY(nodo.Categoria, nodo.Perdidas);
            }

            // Puedes personalizar el aspecto del Chart según tus necesidades
            // Por ejemplo, configurar el tipo de gráfico y otros aspectos visuales.
            chartGananciasPerdidas.ChartAreas[0].AxisX.Interval = 1;
            chartGananciasPerdidas.ChartAreas[0].AxisY.Interval = 1000; // Puedes ajustar esto según tus datos
        }

        private void btnActualizarGrafica_Click(object sender, EventArgs e)
        {
            // Actualiza las ganancias y pérdidas
            grafo.ActualizarGananciasPerdidas();

            // Obtiene los nodos actualizados del grafo
            var nodos = grafo.ObtenerNodos().Values.ToList();

            // Actualiza el gráfico con los datos actualizados del grafo
            ActualizarChart(nodos);
        }
       
        private void Invertir(decimal montoInversion)
        {
            // Realizar la inversión y obtener resultados (ajustar según tu lógica específica)
            RealizarInversion(montoInversion);

            // Después de cada inversión, actualiza ganancias y pérdidas en el grafo
            grafo.ActualizarGananciasPerdidas();

            // Obtén los nodos actualizados del grafo
            var nodos = grafo.ObtenerNodos();

            // Convierte los valores del diccionario en una lista
            var listaNodos = nodos.Values.ToList();

            // Actualizar la gráfica con los datos actualizados del grafo
            ActualizarChart(listaNodos);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

    }

}

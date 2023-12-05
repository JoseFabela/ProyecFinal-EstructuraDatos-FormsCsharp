using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_3Sem
{

    // Fuera de la clase del formulario (puedes agregarlo al mismo archivo o en un archivo separado)
    public class Transaccion
    {
        public string Categoria { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Monto { get; set; }
        public string Descripcion { get; set; }
        public string DestinatarioNombre { get; set; }
        public string DestinatarioCLABE { get; set; }
    }
    public class CategoriaArbol
    {
        public string Nombre { get; }
        public List<CategoriaArbol> Subcategorias { get; }

        public CategoriaArbol(string nombre)
        {
            Nombre = nombre;
            Subcategorias = new List<CategoriaArbol>();
        }

        public void AgregarSubcategoria(CategoriaArbol subcategoria)
        {
            Subcategorias.Add(subcategoria);
        }
    }
    public class Activo
    {
        public string Nombre { get; set; }
        public double Inversion { get; set; }
        public List<Activo> ActivosRelacionados { get; set; }

        public Activo(string nombre, double inversion)
        {
            Nombre = nombre;
            Inversion = inversion;
            ActivosRelacionados = new List<Activo>();
           // ValorInversion = inversionInicial;

        }

        // Método para simular la variación de la inversión en el tiempo
        public void SimularVariacion()
        {
            // Simulación simple: Incrementa o decrementa la inversión aleatoriamente
            Random random = new Random();
            int variacion = random.Next(-100, 101); // Variación entre -100 y 100
            Inversion += variacion;
            if (Inversion < 0) Inversion = 0; // La inversión no puede ser negativa
        }
        // Nueva propiedad para el valor de la inversión
        public double ValorInversion { get; set; }
        // Método para simular cambios en la inversión (ejemplo simple)
        public void SimularCambioInversion()
        {
            // Aquí puedes implementar la lógica de cómo cambia el valor de la inversión con el tiempo
            // En este ejemplo, simplemente aumentamos el valor aleatoriamente
            Random random = new Random();
            double factorCambio = random.NextDouble() * 0.1 + 0.95; // Un factor de cambio entre 0.95 y 1.05
            ValorInversion *= factorCambio;
        }
    }


    public class PortafolioInversiones
    {
       
            public List<Activo> Activos { get; set; }
            public double InversionTotal { get; set; }
            public double InversionTotalAnterior { get; set; }
        public double CapitalAcumulado { get; set; }
        public List<double> ResultadosInversiones { get; set; }

        public PortafolioInversiones()
            {
                Activos = new List<Activo>();
            ResultadosInversiones = new List<double>();
            CapitalAcumulado = 0;
        }

            public void AgregarActivo(Activo activo)
            {
                Activos.Add(activo);
            }

            public void AgregarRelacion(Activo activo1, Activo activo2)
            {
                activo1.ActivosRelacionados.Add(activo2);
                activo2.ActivosRelacionados.Add(activo1);
            }

            public void ActualizarInversionTotal()
            {
                // Lógica para calcular la inversión total, por ejemplo, sumando las inversiones de cada activo
                InversionTotalAnterior = InversionTotal; // Actualizar la inversión total anterior

                InversionTotal = Activos.Sum(activo => activo.Inversion);
            }
        }

    public class NodoFinanciero
    {
        public string Categoria { get; set; }
        public decimal Ganancias { get; set; }
        public decimal Perdidas { get; set; }
        public decimal BalanceNeto => Ganancias - Perdidas; // Propiedad adicional para el balance neto
    }

}


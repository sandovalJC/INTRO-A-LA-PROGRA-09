using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9
{
    internal class Automovil
    {
        private int modelo;
        private double precio;
        private string marca;
        private bool disponibilidad;
        private double tipodeCambio;
        private double descuentoAplicado;

        public Automovil()
        {
            this.modelo = 2019;
            this.precio = 10000.00;
            this.marca = "";
            this.disponibilidad = false;
            this.tipodeCambio = 7.50;
            this.descuentoAplicado = 0.0;
        }
        public void DefinirModelo(int unModelo)
        {
            this.modelo = unModelo;
        }
        public void DefinirPrecio(double unPrecio)
        {
            this.precio = unPrecio;
        }
        public void DefinirMarca(string unaMarca)
        {
            this.marca = unaMarca;
        }
        public void DefinirTipoCambio(double unTipodeCambio)
        {
            this.tipodeCambio = unTipodeCambio;
        }
        public void CambiarDisponibilidad()
        {
            this.disponibilidad = !this.disponibilidad;
        }
        public string MostrarDisponibilidad()
        {
            if (this.disponibilidad == true)
            {
                return "Disponible";
            }
            else{
                return "no se encuentra disponible";
            }
        }
        public string MostrarInformacio()
        {
            string resultado;
            resultado = "Marca: " + Convert.ToString(this.marca) + ". Modelo: " + Convert.ToString(this.modelo) + ". Precio de venta: Q" + Convert.ToString(this.precio) + ". Precio en dólares $" + Convert.ToString(this.precio/this.tipodeCambio) + ". " +MostrarDisponibilidad().;
            return resultado;
        }
    }
}

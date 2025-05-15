using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Prestamo
    {
        private int pre_numero;

        public int Pre_numero
        {
            get { return pre_numero; }
            set { pre_numero = value; }
        }
        private string cli_dni;

        public string Cli_dni
        {
            get { return cli_dni; }
            set { cli_dni = value; }
        }
        private int des_codigo;

        public int Des_codigo
        {
            get { return des_codigo; }
            set { des_codigo = value; }
        }
        private int per_codigo;

        public int Per_codigo
        {
            get { return per_codigo; }
            set { per_codigo = value; }
        }
        private int pre_fecha;

        public int Pre_fecha
        {
            get { return pre_fecha; }
            set { pre_fecha = value; }
        }
        private decimal pre_importe;

        public decimal Pre_importe
        {
            get { return pre_importe; }
            set { pre_importe = value; }
        }
        private double pre_tasaInteres;

        public double Pre_tasaInteres
        {
            get { return pre_tasaInteres; }
            set { pre_tasaInteres = value; }
        }
        private int pre_cantidadCuotas;

        public int Pre_cantidadCuotas
        {
            get { return pre_cantidadCuotas; }
            set { pre_cantidadCuotas = value; }
        }
        private string pre_estado;

        public string Pre_estado
        {
            get { return pre_estado; }
            set { pre_estado = value; }
        }
    }
}

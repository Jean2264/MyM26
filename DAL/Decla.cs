using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;


namespace MyM26.DAL
{
    public  static class Decla
    {
        public static string ConnectionString;
        public static SqlConnection cnn;
        //para cliente
        public static DataTable clienteTab= new DataTable();
        public static DataTable ClienteFilTab= new DataTable();
        public static DataTable bajaCli = new DataTable();

        //Para proveedor
        public static DataTable proveedorTab = new DataTable();
        public static DataTable bajaProv = new DataTable();
        public static DataTable ProvFil = new DataTable();
        public static DataTable ProvBox = new DataTable();


        //Para empleado
        public static DataTable EmpleadoTab = new DataTable();
        public static DataTable bajaEmpl = new DataTable();
        public static DataTable EmpleadoFil = new DataTable();

        //Para usuario
        public static DataTable bajaUsu = new DataTable();

        //Para articulo
        public static DataTable bajaArt = new DataTable();


        //Para categoria
        public static DataTable CatTab = new DataTable();
        public static DataTable CategoriaBox = new DataTable();

        //Para subcategoria
        public static DataTable SubCatTab = new DataTable();
        public static DataTable SubBox = new DataTable();

        //Para Compras
        public static DataTable CompraTab = new DataTable();
        public static DataTable CompraFil = new DataTable();

        //Para caja
        public static DataTable ClienteCaja = new DataTable();
        public static DataTable ArtCaja = new DataTable();

        //Para Venta y Detalle
       public static DataTable VentaTab = new DataTable();
        public static DataTable VentaFil = new DataTable();
        public static DataTable VentaDetTab = new DataTable();


        //Para Estado Contable
        public static DataTable GananciaXMes = new DataTable();

        public static DataTable VentaSemanaTb = new DataTable();
        public static DataTable TVentaSemanaTb = new DataTable();


        //Para contable---Movimiento
        public static DataTable MovTab = new DataTable();
        public static DataTable MovFil = new DataTable();

        //Para contable---salida
        public static DataTable SalTab = new DataTable();
    }
}

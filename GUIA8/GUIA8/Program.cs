using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIA8
{
    class Program
    {
        static void Main(string[] args)
        {

            estudiante estudiante1 = new estudiante();
            
            Console.Write("nombre:");
            estudiante1.nombre = Console.ReadLine();
            Console.Write("carnet: ");
            estudiante1.carnet = Console.ReadLine();
            Console.Write("carrera: ");
            estudiante1.carrera = Console.ReadLine();
            Console.Write("cum : ");
            estudiante1.setCum(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("");
            Console.WriteLine("nombre: {0}",estudiante1.nombre);
            Console.WriteLine("carnet: {0}",estudiante1.carnet);
            Console.WriteLine("carrera: {0}",estudiante1.carrera);
            Console.WriteLine("cum: {0}",estudiante1.getCum());
            Console.WriteLine("");
            Console.WriteLine("ejercicio  2");
            Console.WriteLine("");
            producto[] productos=new producto[1];
            int contador = 0;
            string opcion;
            while (true)
            {
                Console.Write("nombre: ");
                productos[contador].nombre = Console.ReadLine();
                Console.Write("cantidad: ");
                productos[contador].setCantidad(Convert.ToInt32(Console.ReadLine()));
                Console.Write("precio: ");
                productos[contador].setPrecio(Convert.ToDecimal(Console.ReadLine()));
                Console.WriteLine("agregar otro producto s/n");
                opcion = Console.ReadLine();
                opcion = opcion.ToLower();
                if (opcion.Equals("s"))
                {
                    Array.Resize(ref productos,contador+2);
                    contador++;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("total productos");
            decimal total=0.00m;
            for (int i = 0; i < productos.Length; i++)
            {
                Console.WriteLine("producto {0} ",i+1 );
                Console.WriteLine("nombre : {0}",productos[i].nombre);
                Console.WriteLine("cantidad: {0}",productos[i].getCantidad());
                Console.WriteLine("precio por unidad: {0}",productos[i].getPrecio().ToString("C2"));
                Console.WriteLine("TOTAL : {0}",(productos[i].getCantidad()*productos[i].getPrecio()));
                total = total + productos[i].getCantidad() * productos[i].getPrecio();
            }

            Console.WriteLine("total a pagar: {0}",total.ToString("C2"));

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("ejercicio  3");
            Console.Write("cantidad de alumnos:");
            
            int nA = Convert.ToInt32(Console.ReadLine());

            alumno[] alumnos = new alumno[nA];
            for (int i = 0; i < alumnos.Length; i++)
            {
                Console.WriteLine("nombre: ");
                alumnos[i].nombre = Console.ReadLine();
                Console.WriteLine("carnet:");
                alumnos[i].carnet = Console.ReadLine();
                Console.WriteLine("carrera:");
                alumnos[i].carrera = Console.ReadLine();
                
                
                    Console.WriteLine("materiad :");
                    Console.WriteLine("nombre materia:");
                alumnos[i].m1.nombre = Console.ReadLine();
                Console.WriteLine("nota: ");
                alumnos[i].m1.setNota(Convert.ToDouble(Console.ReadLine()));
                Console.WriteLine("nombre materia:");
                alumnos[i].m2.nombre = Console.ReadLine();
                Console.WriteLine("nota: ");
                alumnos[i].m2.setNota(Convert.ToDouble(Console.ReadLine()));
                Console.WriteLine("nombre materia:");
                alumnos[i].m3.nombre = Console.ReadLine();
                Console.WriteLine("nota: ");
                alumnos[i].m3.setNota(Convert.ToDouble(Console.ReadLine()));
                Console.WriteLine("nombre materia:");
                alumnos[i].m4.nombre = Console.ReadLine();
                Console.WriteLine("nota: ");
                alumnos[i].m4.setNota(Convert.ToDouble(Console.ReadLine()));



            }

            for (int j   = 0; j   < alumnos.Length; j  ++)
            {
                Console.WriteLine("nombre: {0}",alumnos[j].nombre);
                Console.WriteLine("carrera: {0}",alumnos[j].carrera);
                Console.WriteLine("carnet: {0}",alumnos[j].carnet);
                Console.WriteLine("materia    nota");
                Console.WriteLine("{0:-5}       {1}   {2} ",alumnos[j].m1.nombre, alumnos[j].m1.getNota(), alumnos[j].m1.resultado());
                Console.WriteLine("{0:-5}       {1}   {2}", alumnos[j].m2.nombre, alumnos[j].m2.getNota(), alumnos[j].m2.resultado());
                Console.WriteLine("{0:-5}       {1}   {2}", alumnos[j].m3.nombre, alumnos[j].m3.getNota(), alumnos[j].m3.resultado());
                Console.WriteLine("{0:-5}       {1}   {2}", alumnos[j].m4.nombre, alumnos[j].m4.getNota(), alumnos[j].m4.resultado());
            }
            Console.WriteLine("ejercicio 4");
            Console.Write("cantidad: ");
            int cantidad = Convert.ToInt32(Console.ReadLine());
 Console.Write("precio: ");
            double precio = Convert.ToDouble(Console.ReadLine());
            double total2 = 0;
 Console.WriteLine("forma de pago[1-debito  ,2-credito,   3-efectivo] ");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case (int)tipoPago.debito:
                    total2 = (cantidad * precio) * 0.15;
                    Console.WriteLine(total2);
                    break;
                case (int)tipoPago.credito:
                    total2 = (cantidad * precio) * 0.10;
                    Console.WriteLine(total2);
                    break;
                case (int)tipoPago.efectivo:
                    total2 = (cantidad * precio) * 0.05;
                    Console.WriteLine(total2);
                    break;
                default:
                    break;
            }



            Console.ReadKey();




        }

        public struct estudiante
        {
            public string carnet,nombre,carrera;
            private double cum;


            public void setCum(double cum)
            {
                while (true)
                {


                    if (cum >= 0 && cum <= 10.0)
                    {
                        this.cum = cum;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("valor incorrecto");
                        Console.Write("cum : ");
                        cum = Convert.ToDouble(Console.ReadLine());
                    }
                }
            }

            public double getCum()
            {
                return this.cum;
            }

        }


        public struct producto
        {
            public string nombre;
            private int cantidad;
            private decimal precio;

            public int getCantidad()
            {
                return this.cantidad;
            }

            public void setCantidad(int cantidad)
            {
                while (true)
                {
                    if (cantidad>0)
                    {
                        this.cantidad = cantidad;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("dato erroneo");
                        Console.Write("cantidad: ");
                        cantidad = Convert.ToInt32(Console.ReadLine());
                    }
                }
            }

            public decimal getPrecio()
            {
                decimal iva=this.precio*0.13m;
                return this.precio;
            }


            public void setPrecio(decimal precio)
            {
                while (true)
                {
                    if (precio > 0)
                    {
                        this.precio = precio;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("dato erroneo");
                        Console.Write("cantidad: ");
                        precio = Convert.ToDecimal(Console.ReadLine());
                    }
                }
            }

        }

        public struct materia
        {
            public string nombre;
            private double nota;

            public double getNota()
            {
                return nota;
            }

            public bool setNota(double nota)
            {
                
                    if (nota>0 && nota<10.1)
                    {
                    this.nota = nota;
                    return false;
                }
                else
                {
                    Console.WriteLine("dato no valido");
                    return true;
                }
               
            }

            public string resultado()
            {
                if (this.nota>=7)
                {
                    return "aprobado";
                }
                else
                {
                    return "reprobado";
                }
            }

        
        }

        public struct alumno
        {
            public string carnet, nombre, carrera;
            public materia m1, m2, m3, m4;
        }


        public enum tipoPago
        {
            efectivo = 0, debito = 1, credito = 2
        }




    }
}

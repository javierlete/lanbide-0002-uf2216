using System;
using POO.Entidades;
using con = System.Console;

namespace POO.Presentacion
{
    class Excepciones
    {
        static void Main()
        {
            int a = 5, b = 0, div;

            con.WriteLine("División:");

            try
            {
                // string s = null;

                // con.WriteLine(s.ToUpper());

                var p = new Persona();

                bool correcto = false;

                do
                {
                    con.Write("Introduce el nombre: ");
                    
                    try
                    {
                        int[] arr = new int[2];

                        //arr[2] = 10;

                        p.Nombre = con.ReadLine();
                        con.WriteLine(p);

                        correcto = true;
                    }
                    catch (EntidadesException e)
                    {
                        con.WriteLine(e.Message);
                    }
                } while (!correcto);

                div = a / b;
            }
            catch (DivideByZeroException e)
            {
                con.WriteLine(e.Message);
                div = int.MaxValue;
            }
            catch (EntidadesException e)
            {
                con.WriteLine("Ha habido un error de entidades");
                con.WriteLine(e.Message);
                return;
            }
            catch (Exception e)
            {
                con.WriteLine("Error no esperado");
                con.WriteLine(e.Message);
                con.WriteLine(e.Source);
                con.WriteLine(e.StackTrace);
                con.WriteLine(e.InnerException);
                con.WriteLine(DateTime.Now);
                return;
            }
            finally
            {
                con.WriteLine("Por mis *** que me ejecuto");
            }

            con.WriteLine(div);
        }
    }
}
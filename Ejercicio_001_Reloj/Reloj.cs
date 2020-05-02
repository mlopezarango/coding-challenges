using System;


public class Program
{
    public static void Main(string[] args)
    {
        int z = 0;
        while (z == 0)
        {
            int h;
            int m;
            string x = "";
            Console.WriteLine("Escriba la Hora, y unicamente la hora en el rango de 1 y 12");
            h = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Escriba los minutos, y unicamente los minutos en el rango de 0 y 59");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("");

            if (m == 0)
            {
                if (h != 12)
                {
                    h = 12 - h;
                }
                x = "00";
                Console.WriteLine("La hora reflajada en el espejo es:");
                Console.WriteLine("{0} : {1}", h, x);
            }
            else
            {
                if (h == 12)
                {
                    h = 11;
                }
                else if (h == 11)
                {
                    h = 12;
                }
                else
                {
                    h = 12 - h - 1;
                }
                m = 60 - m;
                if (m <= 9)
                {
                    x = "0" + m.ToString();
                }
                else
                {
                    x = m.ToString();
                }
                Console.WriteLine("La hora reflajada en el espejo es:");
                Console.WriteLine("{0} : {1}", h, x);
                Console.WriteLine("");
                Console.WriteLine("");
            }

            Console.WriteLine("Para continuar con una nueva hora ingrese 0");
            Console.WriteLine("Para salir 1");
            z = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("");
        }
    }
}


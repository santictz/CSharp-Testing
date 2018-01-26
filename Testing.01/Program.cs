using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing._01
{
    class Program
    {
        static void Main(string[] args)

        {
            AreaTriangulo();
        }

        //Testing methods without return values
        static void UserDetails()
        {
            string cityName;
            string userName;
            SByte userAage;
            int userPin;

            Console.WriteLine("Ingrese su nombre de usuario: ");
            userName = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre de su ciudad: ");
            cityName = Console.ReadLine();
            Console.WriteLine("Ingrese su edad: ");
            userAage = Convert.ToSByte(Console.ReadLine());
            Console.WriteLine("Ingrese su pin: ");
            userPin = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Sus datos son: \n Nombre: {0} \n Ciudad: {1} \n Edad: {2} \n Pin: {3}", userName, cityName, userAage, userPin);
            Console.Read();
        }
        static void GetLocalPath()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            Console.WriteLine("The path for Documents is :" + path);
        }
        static void SumNum()
        {
            int num1, num2, result;
            Console.WriteLine("Ingrese el primer valor");
            num1 = Int32.Parse(Console.ReadLine()); //c# acepta string por default
            Console.WriteLine("Ingrese el segundo valor");
            num2 = Convert.ToInt32(Console.ReadLine()); //Utilizar Convert.To para convertir tipos de variable
            result = num1 + num2;
            Console.WriteLine("El resultado de la suma de {0} y {1} es {2}", num1, num2, result); //Variables placeholders
            Console.Read();
        }
        static void AssignOperator()
        {
            int num1, num2;
            num1 = 10;
            num2 = 5;

            num1 += num2; // same as num1 = num1 + num2
            Console.WriteLine("Suma: {0}", num1);
            num1 -= num2; //same as num1 = num1 - num2
            Console.WriteLine("Resta: {0}", num1);
            num1 *= num2; //same as num1 = num1 * num2
            Console.WriteLine("Producto: {0}", num1);
            num1 %= num2; //same as num1 = num1 % num2
            Console.WriteLine("Módulo: {0}", num1);
            Console.ReadKey();
        }
        static void IncreDecre()
        {
            int i = 0;
            i++; // First executes code then increment value by 1
            Console.WriteLine("El valor de i es {0}", i);
            ++i; // First increment value then executes code. Same with -- decremental
            Console.WriteLine("El valor de i es {0}", i);
            Console.Read();
               
        }
        static void ComparisonOperators()
        {
            int num1, num2;
            Console.Write("Ingrese el primer número:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el segundo número:");
            num2 = Convert.ToInt32(Console.ReadLine());

            //Compare wich is the biggest
            if (num1 > num2)
            {
                Console.Write("{0} es mayor a {1}", num1, num2);
            }
            else if (num1 < num2)
            {
                Console.Write("{0} es menor que {1}", num1, num2);
            }
            else
            {
                Console.Write("{0} y {1} son iguales", num1, num2);
            }
            Console.Read();
        }
        static void LogicalOperators()
        {
            string name = "Santiago";
            string password = "1234";
            if(name == "Santiago" && password == "1234") //returns TRUE if ALL are true
            {
                Console.WriteLine("Sesion iniciada con exito");
            }
            else
            {
                Console.WriteLine("Datos incorrectos");
            }
        }
        static void OrLogicalOperator()
        {
            string username, password;
            label: //crear una etiqueta para luego utilizar con goto, redireccionar el codigo hacia la etiqueta
            Console.WriteLine("Ingrese su nombre de usuario");
            username = Console.ReadLine();
            Console.WriteLine("Ingrese su password");
            password = Console.ReadLine();

            try
            {
                if ((username == "Santiago" || username == "Fernando") && (password == "1234")) //con que solo una sea valida es suficiente para que continue
                {
                    Console.WriteLine("Inicio de sesion exitoso");
                }
                else
                {
                    Console.WriteLine("\nAcceso no autorizado. Abortando programa");
                }
                Console.Write("Presione Y o y para continuar. N o n para cancelar el programa");
                char answ = Convert.ToChar(Console.ReadLine());
                if(answ == 'y' || answ == 'Y')
                {
                    goto label; //retorna el programa hacia la seccion label
                }
                else
                {
                    Console.WriteLine("Cancelando programa...");
                    Console.ReadKey();
                    return;
                }
                
            }
            catch(Exception){

            }
            
        }
        static void NorOperator()
        {
            string username, password;
            Console.Write("Ingrese su nombre de usuario:\t");
            username = Console.ReadLine();
            Console.Write("Ingrese su password:\t");
            password = Console.ReadLine();
            if(!(username == "Santiago" && password == "1234")) //si es diferente a estos parametros, devuelve TRUE !((xx))
            {
                Console.Write("Acceso denegado. Abortando programa...");
            }
            else
            {
                Console.Write("Bienvenido {0}", username);
            }
            Console.Read();

        }
        static void EsVocal()
        {
            char ch;
            Console.Write("Ingrese una letra:\t");
            ch = Convert.ToChar(Console.ReadLine());
            if ( ch == 'A' || ch == 'a' || ch == 'e' || ch == 'E' || ch == 'i' || ch == 'I' || ch == 'o' || ch == 'O' || ch == 'u' || ch == 'U')
            {
                Console.WriteLine("{0} es vocal", ch);
            }
            else
            {
                Console.WriteLine("{0} no es vocal", ch);
            }
            Console.Read();
        }
        static void AreaRectangulo()
        {
            int area, altura, ancho;
            Console.Write("Ingrese la altura del rectángulo:");
            altura = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el ancho del rectángulo:");
            ancho = Convert.ToInt32(Console.ReadLine());

            area = ancho * altura;

            Console.Write("El área del rectángulo es: {0}", area);
            Console.Read();
        }
        static void PotenciaCuadrado()
        {
            int num1, num2, cuadrado;
            Console.WriteLine("Ingrese el primer número: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            if( num1 != 0 || num2 != 0)
            {
                cuadrado = (num1 * num1) + (num2 * num2) + (2 * num1 * num2);
                Console.WriteLine("El resultado de ({0} + {1})2 es {2}", num1, num2, cuadrado);
            }
            else
            {
                Console.WriteLine("Usted ha ingresado un número inválido. Cancelando programa...");
            }
            Console.Read();
        }
        static void CalculatePi()
        {
            double PI = Math.PI;
            Console.WriteLine("El valor de PI es {0}", PI);
        }
        static void AreaCirculo()
        {
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("El area de círculo es: {0:F2}", Math.PI + r + r); //{0:F2} formatea numericamente los resultados, en este caso le agrega fixed points, .00
            Console.Read();
        }
        static void ParImpar()
        {
            Console.Write("Ingrese un número. Este programa lo ayudará a detectar si es par o impar");
            int num1 = Convert.ToInt32(Console.ReadLine());
            if(num1%2 != 0)
            {
                Console.WriteLine("El número {0} es impar", num1);
            }
            else
            {
                Console.WriteLine("El número {0} es par", num1);
            }
            Console.Read();
        }
        static void CalcPotencia()
        {
            double numBase, potencia, resultado;
            Console.WriteLine("Ingrese el número base: ");
            numBase = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el expontente: ");
            potencia = Convert.ToDouble(Console.ReadLine());
            resultado = Math.Pow(numBase, potencia); //Método POW de clase MATH procesa la potencia, se maneja con double (double numero, double potencia)
            Console.WriteLine("El resultado es: {0}", resultado);
            Console.Read();

            //if (potencia == 0)
            //{
            //    resultado = 1;
            //    Console.WriteLine("El resultado es: {0}", resultado);
            //}
            //else
            //{
            //    for (int x = 2; x < potencia; x++)
            //    {
            //        numBase *= numBase;
            //    }
            //    Console.WriteLine("El resultado es: {0}", resultado);
            //}
        }
        static void AreaTriangulo()
        {
            double b, h, a;
            Console.WriteLine("Ingrese el valor de la base del triangulo: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la altura del triangulo: ");
            h = Convert.ToDouble(Console.ReadLine());

            a = (b * h) / 2;
            Console.WriteLine("El área del triangulo es: {0}", a);
            Console.Read();
        }
    }
}


//PROGRAMA QUE MUESTRE EN PANTALLA LOS NUMEROS DEL 1 AL 500 WHILE
internal class Numbersdel1al500
{
  private static void Main(string[] args)
  {
    int num = 1;

    while (num <= 500)
    {

      Console.WriteLine(num);
      num++;

    }
    Console.WriteLine(" Ya se acabo");
    Console.Read();
  }
}

////PROGRAMA QUE MUESTRE EN PANTALLA LOS NUMEROS DEL 1 AL 500 DO WHILE

/*internal class Program
{
    private static void Main(string[] args)
    {
        int num=1;

        do
        {
           Console.WriteLine (num);
          num ++; 
        } while (num <= 500); 
         Console.WriteLine (" Es hasta 500 , ya ya llegamos");
         Console.ReadLine();
    
         }
}*/
// PROGRAMA QUE MUESTRE EN PANTALLA LOS NUMEROS DEL 500 AL 1 While 
/*internal class Program
{
    private static void Main(string[] args)
    {
        int num=500;

     while (num >= 1)
     {
       
       Console.WriteLine (num);
       num --;
       
     }
     Console.WriteLine ( " Ya se acabo es hasta 1 " );
     Console.Read();
         }
}*/

// // PROGRAMA QUE MUESTRE EN PANTALLA LOS NUMEROS DEL 500 AL 1 DO While  

/*internal class Program
{
    private static void Main(string[] args)
    {
        int num=500;

        do
        {
           Console.WriteLine (num);
           num --;
        }
     while  (num >= 1);
     

     Console.WriteLine ( " Ya llegamos al 1 " );
     Console.Read();
         }
}*/

// PROGRAMA QUE MUESTRE EN PANTALLA LOS NUMEROS IMPARES COMPRENDIDOS ENTRE EL 1 Y EL 100  While 

/*internal class Program
{
    private static void Main(string[] args)
    {
        int num=1;
        
        while (num <= 99 )
        {
          Console.WriteLine(num);
          num = num + 2;
        }

    Console.WriteLine ( " aqui estan todos los impares entre el 1 y el 100  " );
     Console.Read();
         }
}*/

// PROGRAMA QUE MUESTRE EN PANTALLA LOS NUMEROS IMPARES COMPRENDIDOS ENTRE EL 1 Y EL 100 do While 

/*internal class Program
{
    private static void Main(string[] args)
    {
        int num=1;
        
        do
        {
           Console.WriteLine (num);
           num = num + 2 ;
        }
     while  (num <= 99);
     

     Console.WriteLine ( " aqui estan todos los impares entre el 1 y el 100 " );
     Console.Read();
         }
}*/
// // PROGRAMA QUE MUESTRE EN PANTALLA LOS NUMEROS DEL 0 AL 1000, INCREMENTANDO DE 5 EN 5  while

/*internal class Program
{
    private static void Main(string[] args)
    {
        int num=0;
        
  
     while  (num <= 1000)

     { 
     Console.WriteLine(num);
     num = num + 5;
     }
     
     Console.WriteLine ( " De 5 en 5 hasta el 1000 " );
     Console.Read();
         }
}/*


 // PROGRAMA QUE MUESTRE EN PANTALLA LOS NUMEROS DEL 0 AL 1000, INCREMENTANDO DE 5 EN 5 do while

 /*internal class Program
{
    private static void Main(string[] args)
    {
        int num=0;
        
        do
        {
           Console.WriteLine (num);
           num = num + 5 ;
        }
     while  (num <= 1000);
     

     Console.WriteLine ( " De 5 en 5 se llena la gallina el buche  " );
     Console.Read();
         }
}*/

//  PROGRAMA QUE PIDA AL USUARIO UN NUMERO, Y MUESTR EN PANTALLA LA SECUENCIA DESCENDENTE DESDE EL NUMERO INGRESADO HASTA 0 While 

/*internal class Seguencia_Desc
{
    private static void Main(string[] args)
    {
        int num,contador;
        Console.WriteLine(" Ingrese un numero mayor que 0 ");
        num = Convert.ToInt32 (Console.ReadLine()!);
        Console.WriteLine (" Todos los numeros desde  "+ num + " hasta 0 son estos ");
        {
          while (num >= 0)
         {
          Console.WriteLine(num); 
           contador = num --;
          }
          Console.Read();
        }
 }
}*/



//  PROGRAMA QUE PIDA AL USUARIO UN NUMERO, Y MUESTR EN PANTALLA LA SECUENCIA DESCENDENTE DESDE EL NUMERO INGRESADO HASTA 0  do While 

/*internal class Seguencia_Desc
{
    private static void Main(string[] args)
    {
        int num,contador;
        Console.WriteLine(" Ingrese un numero mayor que 0 ");
        num = Convert.ToInt32 (Console.ReadLine()!);
        Console.WriteLine (" Todos los numeros desde  "+ num + " hasta 0 son estos ");
        {
          do 
         {
          Console.WriteLine(num); 
           contador = num --;
          }
          while   (num >= 0);
        }
        Console.ReadLine();
 }
}*/

//PROGRAMA QUE PIDA AL USUARIO UN NUMERO. EL NUMERO RECIBIDO LO MULTIPLICARA POR 5. SI EL RESULTADO ES UN NUMERO PAR, 
//MOSTRARA EN PANTALLA LA SECUENCIA ASCENDENTE DESDE EL NUMERO RECIBIDO HASTA EL RESULTADO DE LA MULTIPLICACION. 
//EN CASO CONTRARIO, MOSTRARA LA SECUENCIA DESCENDENTE DESDE EL RESULTADO DE LA MULTIPLICACION HASTA EL NUMERO INGRESADO CON WHILE

/*internal class Seguencia_Desc
{
  private static void Main(string[] args)
  {
    int num,multi;
    Console.WriteLine(" Ingrese un numero mayor que 0 ");
    num = Convert.ToInt32 (Console.ReadLine()!);
    multi= num * 5;
      
    if (multi % 2 == 0 )
    {
      while ( num <= multi )
      {
        Console.WriteLine( num );
        num++;
      }       
        Console.WriteLine();
        Console.WriteLine(" Aqui los numeros ascedentes ya que resultado es par");
    }
    else
    {
    
    
      Console.WriteLine(" Aqui los numeros descendente ya que resultado es impar");
      while ( multi >= num)
      {
        Console.WriteLine( multi); 
        multi--;
      }
    } 
  }
}*/

//PROGRAMA QUE PIDA AL USUARIO UN NUMERO. EL NUMERO RECIBIDO LO MULTIPLICARA POR 5. SI EL RESULTADO ES UN NUMERO PAR, 
//MOSTRARA EN PANTALLA LA SECUENCIA ASCENDENTE DESDE EL NUMERO RECIBIDO HASTA EL RESULTADO DE LA MULTIPLICACION. 
//EN CASO CONTRARIO, MOSTRARA LA SECUENCIA DESCENDENTE DESDE EL RESULTADO DE LA MULTIPLICACION HASTA EL NUMERO INGRESADO CON do WHILE 

/*internal class Seguencia_Desc
{
  private static void Main(string[] args)
{
    int num,multi;
    Console.WriteLine(" Ingrese un numero mayor que 0 ");
    num = Convert.ToInt32 (Console.ReadLine()!);
    multi= num * 5;
      
   if (multi % 2 == 0 )
   {
      do 
        {
        Console.WriteLine( num );
        num++;
        }
          while (num<=multi);
          Console.WriteLine( " Aqui el listado ascendente ya que el resultado es par ");
    }
    else
    {
      do 
      { 
       Console.WriteLine( multi );
       multi--;
      } 
      while (multi>= num);
      Console.WriteLine( " Aqui el listado descendente ya que el resultado es impar ");
    }
 }
}*/

//PROGRAMA QUE PIDA AL USUARIO DOS NUMERO. SI EL 1ER NUMERO ES MAYOR QUE EL SEGUNDO, MOSTRARA LA SECUENCIA DESCENDENTE DESDE EL PRIMER NUMERO 
//HASTA EL SEGUNDO, EN CASO CONTRARIO MOSTRAR LA SECUENCIA ASCENDENTE. While
/*internal class Secuencia1
{
 private static void Main(string[] args)
  {
      int prim_num,seg_num;
      Console.WriteLine(" Ingrese un numero ");
      prim_num= Convert.ToInt32(Console.ReadLine());
      Console.WriteLine(" Ingrese otro numero ");
      seg_num= Convert.ToInt32(Console.ReadLine());
    
  if (prim_num > seg_num)
    {
      while (seg_num <= prim_num)
     
        { 
          Console.WriteLine("\n"+prim_num); 
          prim_num--;
        }
     Console.WriteLine( " Aqui la cadena descendente ya que el primero es mayor ");
    }
    else
    {
      while (seg_num >= prim_num)
        {
        Console.WriteLine("\n"+prim_num);
        prim_num++; 
        }
       Console.WriteLine( " Aqui la cadena ascendente ya que el segundo es mayor ");
    }
       Console.ReadLine();
    
  }   
}*/

//PROGRAMA QUE PIDA AL USUARIO DOS NUMERO. SI EL 1ER NUMERO ES MAYOR QUE EL SEGUNDO, MOSTRARA LA SECUENCIA DESCENDENTE DESDE EL PRIMER NUMERO 
//HASTA EL SEGUNDO, EN CASO CONTRARIO MOSTRAR LA SECUENCIA ASCENDENTE.  do While

/*using System;

public class Secuencia1do
{
    public static void Main(string[] args)
    {
        int prim_num, seg_num;
        Console.WriteLine("Ingrese un número:");
        prim_num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese otro número:");
        seg_num = Convert.ToInt32(Console.ReadLine());

        if (prim_num > seg_num)
        {
            do
            {
                Console.WriteLine( prim_num);
                prim_num--;
            } 
            while (prim_num >= seg_num);
            Console.WriteLine("Aquí la cadena descendente ya que el primero es mayor.");
        }
        else
        {
           do
            {
                Console.WriteLine( + prim_num);
                prim_num++;
            }
            while (seg_num >= prim_num);
              Console.WriteLine( " ");
              Console.WriteLine("Aquí la cadena ascendente ya que el segundo es mayor.");
        }
        
    }
    
}*/

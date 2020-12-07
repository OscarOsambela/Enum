using System;
using System.Collections.Generic;
using System.Linq;

/*
Enum.- conjunto de constantes con nombre
Sirve para representar y manejar valores fijos (constantes) en un programa con valores integer no permite strings
*/
public class Program
{
  public static void Main()
  {
    //se instancia el enum como un objeto de una clase 
    Estaciones alergia = Estaciones.Invierno;
    Console.WriteLine(alergia);

    Bono Oscar = Bono.simple;

    double bonusAntonio = (double)Oscar;
    double salarioOscar = bonusAntonio + 54.60;
    Console.WriteLine(salarioOscar);
    
		Empleado francisco = new Empleado(Bono.supreme, 3000);
    Console.WriteLine("El salario de Francisco más el bono \"supreme\" es: " + francisco.getSalario());

		Dias viernes = Dias.Vie;
		Dias sabado = Dias.Sab;
		Dias domingo = Dias.Dom;
		Dias libre = Dias.Sab;
		Console.WriteLine(sabado == libre);
		Console.WriteLine(viernes == domingo);
		//conocer el valor de un enum
		Console.WriteLine((int)Dias.Mar);

		Console.WriteLine("El mes de febrero es el número " + (int)Meses.Feb);

		//si se reasigna un valor de cualquier posicion, el siguiente constante tomara el numero consiguiente. Por ejemplo Oct = 500, ver el resultado en consola de noviembre (501) 
		Console.WriteLine((int)Meses.Nov);
  }
  //constantes en mayusculas por convencion
  //se asignara implicitamente un valor a cada constante empezando desde 0
  enum Estaciones{Primavera, Verano, Otoño, Invierno};

  //otro ejemplo de enum
  //modificamos los valores por defecto a cada constante 
  enum Bono{simple = 500, normal = 1000, excelsior = 1500, supreme = 2000};

  class Empleado{
    private double salario, bonus;

    public Empleado(Bono bonusEmpleado, double salario){
      bonus = (double)bonusEmpleado;
      this.salario = salario;  
    }
    public double getSalario(){
      return salario + bonus;
    }

  }

	enum Dias{Lun, Mar, Mie, Jue, Vie, Sab, Dom};

	enum Meses{Ene = 1,Feb, Mar, Abr, May, Jun, Jul, Ago, Set, Oct = 500, Nov, Dic};
}

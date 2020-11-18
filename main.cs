using System;
using System.Collections.Generic;
using System.Linq;

/*
Enum.- conjunto de constante con nombre
Sirve para representar y manejar valores fijos (constantes) en un programa
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
    Empleado Francisco = new Empleado(Bono.supreme, 3000);
    Console.WriteLine("El salario de Francisco más el bono \"supreme\" es: " + Francisco.getSalario());
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
}

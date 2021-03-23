using System;

namespace Salario_Mayor
{
 class Salario_Mayor
 {
 private string[] nombres;
 private float[] sueldos;
 public void Cargar()
 {
 nombres = new string[5];
 sueldos = new float[5];
 for (int f = 0; f < nombres.Length; f++)
 {
 Console.Write("Ingrese el nombre del empleado:");
 nombres[f] = Console.ReadLine();
 Console.Write("Ingrese el sueldo:");
 string linea;
 linea = Console.ReadLine();
 sueldos[f] = float.Parse(linea);
 }
 }
 public void MayorSueldo()
 {
     float mayor;
 int pos;
 mayor = sueldos[0];
 pos = 0;
 for (int f = 1; f < nombres.Length; f++)
 {
 if (sueldos[f] > mayor)
 {
 mayor = sueldos[f];
pos = f;
 }
 }
 Console.WriteLine("\n El empleado con sueldo mayor es " + nombres[pos]);
 Console.WriteLine("Tiene un sueldo:" + mayor);
 Console.ReadKey();
 }
 static void Main(string[] args)
 {
 Salario_Mayor one = new Salario_Mayor();
 one.Cargar();
 one.MayorSueldo();
 }
 }
}

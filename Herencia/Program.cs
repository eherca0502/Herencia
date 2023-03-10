using Herencia.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
         

            Estudiante Eduardo = new Estudiante();
            Eduardo.Apellidos = "Rios";
            Eduardo.Edad = 20;
            Eduardo.Genero = "M";
            Eduardo.Identificacion = "23456782";
            Eduardo.Nombres = "Wilmer";
            Eduardo.Programa = "Desarrollo de software";
            Eduardo.SemestreActual = "II";

            Console.WriteLine("---------Informacion del Estudiante-------");
            Console.WriteLine("Identificacion: " + Eduardo.Identificacion);
            Console.WriteLine("Nombres: " + Eduardo.Nombres);
            Console.WriteLine("Apellidos: " + Eduardo.Apellidos);
            Console.WriteLine("Edad: " + Eduardo.Edad);
            Console.WriteLine("Genero: " + Eduardo.Genero);
            Console.WriteLine("Programa: " + Eduardo.Programa);
            Console.WriteLine("Semestre: " + Eduardo.SemestreActual);
            Console.ReadLine();


            Docente Jaime = new Docente();
            Jaime.Apellidos = "Rodriguez";
            Jaime.Edad = 30;
            Jaime.Genero = "M";
            Jaime.Identificacion = "35678910";
            Jaime.Nombres = "Sergio";
            Jaime.MateriasAsignadas = 2;
            Jaime.Contrato ="TMVA575";

            Console.WriteLine("---------Informacion del Docente-------");
            Console.WriteLine("Identificacion: " + Jaime.Identificacion);
            Console.WriteLine("Nombres: " + Jaime.Nombres);
            Console.WriteLine("Apellidos: " + Jaime.Apellidos);
            Console.WriteLine("Edad: " + Jaime.Edad);
            Console.WriteLine("Genero: " + Jaime.Genero);
            Console.WriteLine("Materias: " + Jaime.MateriasAsignadas);
            Console.WriteLine("Contrato: " + Jaime.Contrato);


            Console.ReadLine();
            Administrativo Karla = new Administrativo();
            Karla.Apellidos = "Ayala";
            Karla.Edad = 47;
            Karla.Genero = "M";
            Karla.Identificacion = "572862";
            Karla.Nombres = "Karla";
            Karla.NombreJefe = "Gerardo Tapia";
            Karla.Area = "Sistemas";

            Console.WriteLine("---------Informacion del Administrativo-------");
            Console.WriteLine("Identificacion: " + Karla.Identificacion);
            Console.WriteLine("Nombres: " + Karla.Nombres);
            Console.WriteLine("Apellidos: " + Karla.Apellidos);
            Console.WriteLine("Edad: " + Karla.Edad);
            Console.WriteLine("Genero: " + Karla.Genero);
            Console.WriteLine("Nombre del jefe: " + Karla.NombreJefe);
            Console.WriteLine("Area: " + Karla.Area);

            

            Console.ReadLine();

        }
    }
}

using System;
using System.Reflection;

namespace reflection.assembly.@object
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();

            Console.WriteLine($"Nombre: {assembly.FullName}");
            AssemblyName name = assembly.GetName();
            Console.WriteLine($"Versión mayor: {name.Version.Major}");
            Console.WriteLine($"Versión menor: {name.Version.Minor}");
            Console.WriteLine($"¿En la caché global?: {assembly.GlobalAssemblyCache}");

            foreach (Module module in assembly.Modules)
            {
                Console.WriteLine($"Módulo: {module.Name}");
                foreach (Type tipo in module.GetTypes())
                {
                    Console.WriteLine($"    Tipo: {tipo.Name}");
                    foreach (MemberInfo miembro in tipo.GetMembers())
                    {
                        Console.WriteLine($"        Miembro: {miembro.Name}");
                    }
                }
            }

            Console.ReadKey();
        }
    }
}

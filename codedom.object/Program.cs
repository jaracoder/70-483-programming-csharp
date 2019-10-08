using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.IO;
using System.Reflection;

namespace codedom.@object
{
    class Program
    {
        static void Main(string[] args)
        {
            CodeCompileUnit unidadCompilacion = new CodeCompileUnit();

            // Crea nombre de espacio
            CodeNamespace personalNombreEspacio = new CodeNamespace("Personal");

            // Importa el nombre de espacio System
            personalNombreEspacio.Imports.Add(new CodeNamespaceImport("System"));

            // Crea clase Persona
            CodeTypeDeclaration clasePersona = new CodeTypeDeclaration("Persona");
            clasePersona.IsClass = true;
            clasePersona.TypeAttributes = TypeAttributes.Public;

            // Añade la clase persona al nombre de espacio
            personalNombreEspacio.Types.Add(clasePersona);

            // Crea campos en clase Persona
            CodeMemberField campoNombre = new CodeMemberField("String", "nombre");
            campoNombre.Attributes = MemberAttributes.Private;

            // Añade campo nombre a la clase Persona
            clasePersona.Members.Add(campoNombre);

            // Añade el nombre de espacio al documento
            unidadCompilacion.Namespaces.Add(personalNombreEspacio);

            // Parsea el documento y genera el código
            CodeDomProvider proveedor = CodeDomProvider.CreateProvider("CSharp");
            StringWriter s = new StringWriter();
            CodeGeneratorOptions opciones = new CodeGeneratorOptions();
            proveedor.GenerateCodeFromCompileUnit(unidadCompilacion, s, opciones);
            s.Close();

            // Muestra el código generado en pantalla
            Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}

using System.Xml;

class Program
{
    static void Main(string[] args)
    {
        // Crea una instancia de XmlDocument y carga el archivo XML
        XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("archivo.xml");

        // Obtén todos los elementos con el tag "usuario"
        XmlNodeList usuarios = xmlDoc.GetElementsByTagName("usuario");

        // Recorre todos los elementos y obtén los valores de los atributos y nodos hijos
        foreach (XmlNode usuario in usuarios)
        {
            string nombre = usuario.Attributes["nombre"].Value;
            string apellido = usuario.Attributes["apellido"].Value;
            string direccion = usuario.Attributes["direccion"].Value;
            string email = usuario.Attributes["email"].Value;
            string telefono = usuario.SelectSingleNode("telefono").InnerText;
            string fecha = usuario.SelectSingleNode("fecha").InnerText;

            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Apellido: " + apellido);
            Console.WriteLine("Direccion: " + direccion);
            Console.WriteLine("Email: " + email);
            Console.WriteLine("Teléfono: " + telefono);
            Console.WriteLine("Fecha: " + fecha);
        }

        Console.ReadLine();
    }
}

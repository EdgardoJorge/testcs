namespace Colegio.RequestResponse{
    public class PersonaResponse
    {
        public String  Nombre { get; set; } = string.Empty;
        public String ApellidoPaterno { get; set; } = string.Empty;
        public String ApellidoMaterno { get; set; } = string.Empty;
        public string Direccion { get; set; } = string.Empty;
        public DateTime FechaNacimiento { get; set; }
        public String NombreCompleto { 
            get
            {
                return $"{Nombre} {ApellidoMaterno} {ApellidoMaterno}";
            }
        }
        //forma antigua de un constructor vs 2015 hacia abajo
        /*public PersonaResponse()
        {
            Nombre = string.Empty;
            ApellidoPaterno = string.Empty;
            ApellidoMaterno = string.Empty;
            Direccion = string.Empty;
        }*/
    }
}
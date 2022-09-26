namespace Inventario.Models
{
    public class Employee : User
    {
        public string Occupation { get; set; }
        public int Department { get; set; }
    }
}

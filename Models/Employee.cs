using Mamba.Models.Base;

namespace Mamba.Models
{
    public class Employee:BaseEntity
    {
        public string Name{ get; set; }
        public string Surname{ get; set; }
        public string Image {  get; set; }
        public string Instagram { get; set; }
        public string Twitter { get; set; }
        public string Linkedin{ get; set; }
        public string Facebook{ get; set; }
        public int PositionId { get; set; }
        public Position Position { get; set; }
       
    }
}

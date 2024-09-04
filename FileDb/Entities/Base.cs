using System.ComponentModel.DataAnnotations;

namespace FileDb
{
    public class Base
    {
        public Base()
        {
            //Id = Guid.NewGuid();
            CreatedOn = DateTime.UtcNow;
        }

        [Key]
        public int Id { get; set; }

        public DateTime CreatedOn { get; set; }


        public DateTime UpdatedOn { get; set; }
    }
}

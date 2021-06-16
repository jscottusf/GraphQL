using System.ComponentModel.DataAnnotations;

namespace  CommanderGQL.Models
{
    public class Command
    {
        [Key]
        public int CommandId { get; set; }
        [Required]
        public string HowTo { get; set; }
        [Required]
        public string CommandLine { get; set; }
        [Required]
        public int PlatformId { get; set; }
    }
}
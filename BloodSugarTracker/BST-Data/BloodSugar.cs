using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST_Data
{
    /// <summary>
    /// BloodSugar represents one unit of entry for my application.  The tracker will consist of this 
    /// class plus some analytics of this said class.
    /// </summary>
    public class BloodSugar
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public int Amount { get; set; }
        public TimeOnly? TimeMessured { get; set; }
        [Required]
        public DateOnly DateMessured { get; set; }
        public String? Notes { get; set; }
    }
}

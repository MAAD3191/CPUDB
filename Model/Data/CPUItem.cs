
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPUDB.Model.Data
{
    public class CPUItem
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Brands")]
        public int BrandId { get; set; }
        public Brand Brand { get; set; }

        [ForeignKey("Models")]
        public int ModelId { get; set; }
        public CPUModel Model { get; set; }
        public float Clock_speed { get; set; }
        public int Core_amount { get; set; }
        public int Thread_amount { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace sweet.Data
{
    public class candy
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CID { get; set; }

        [Display(Name = "Candy Name")]
        public string CName { get; set; }

        [Display(Name = "Store Number")]
        public int snumber { get; set; }

        [ForeignKey("snumber")]
        public Store canstores { get; set; }

        [ForeignKey("onumber")]
        public orders cso { get; set; }
    }
}

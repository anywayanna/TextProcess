using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TextProcess.Database.Models
{
    [Table("Dictionary")]
    public class Dictionary
    {
        [Column("Id"), Required]
        public int id { get; set; }

        [Column("Word")]
        public string word { get; set; }

        [Column("WordCount")]
        public int wordCount { get; set; }

    }
}

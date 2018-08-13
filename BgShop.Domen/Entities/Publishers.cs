using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BgShop.Domen.Entities
{
    [Table("Publishers")]
    public class Publishers
    {
        public Publishers() => this.games = new Collection<Games>();

        [Column("id")]
        [Required]
        public int id { get; set; }

        [Column("name")]
        [Required]
        [MaxLength(50)]
        public string name { get; set; }

        public ICollection<Games> games { get; set; }
    }
}
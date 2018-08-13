using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BgShop.Domen.Entities
{
    [Table("Games")]
    public class Games
    {
        [Required]
        [Column("id")]
        public int id { get; set; }

        [Required]
        [Column("price")]
        public int price { get; set; }

        [Required]
        [Column("duration")]
        public int duration { get; set; }

        [Required]
        [Column("players")]
        [MaxLength(10)]
        public string players { get; set; }

        [Required]
        [Column("thumbnail")]
        [MaxLength(600)]
        public string thumbnail { get; set; }

        [Required]
        [Column("featured")]
        public bool featured { get; set; }

        public int publisherid { get; set; }

        [ForeignKey("publisherid")]
        public Publishers publishers { get; set; }

    }
}

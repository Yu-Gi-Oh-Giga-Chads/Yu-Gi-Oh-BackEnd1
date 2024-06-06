using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Card
    {
        [Key]
        public int CardId { get; set; }
        public string Name { get; set; }
        public string? CardType { get; set; }
        public string? Property { get; set; }

        public int Id { get; set; }

        public string? Attribute { get; set; }
        public int Level { get; set; }
        public int ATK { get; set; }
        public int DEF { get; set; }
        public string? EffectText { get; set; }
        public List<Deck> Decks { get; set; }

        public Card()
        {
            Decks = new List<Deck>();
        }
    }
}

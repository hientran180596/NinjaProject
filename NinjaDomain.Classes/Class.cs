using NinjaDomain.Classes.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NinjaDomain.Classes
{
    public class Class
    {
        public class Ninja
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public bool ServerInOniwaban { get; set; }
            public Clan Clan { get; set; }
            public int ClanId { get; set; }
            public List<NinjaEquipment> EquipmentOwned { get; set; }
        }
        public class Clan
        {
            public int Id { get; set; }
            public string ClanName { get; set; }
            public List<Ninja> Ninjas { get; set; }
        }
        public class NinjaEquipment
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public EquipmentType Type { get; set; }
            [Required]
            public Ninja Ninja { get; set; }
        }
    }
}

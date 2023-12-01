using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
namespace Ispas_Adelina_Lab7.Models
{
    public class ShopList
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [SQLite.MaxLengthAttribute(250), Unique]
        public string Description { get; set; }
        public DateTime Date { get; set; }
    }
}

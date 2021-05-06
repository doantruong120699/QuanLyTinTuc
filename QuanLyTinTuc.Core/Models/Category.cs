
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace QuanLyTinTuc.Core.Models
{
    [Table("Category")]
    public class Category
    {
        public Category()
        {
            TinTucs = new List<TinTuc>();
        }
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<TinTuc> TinTucs { get; set; }
    }
}
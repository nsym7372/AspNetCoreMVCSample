using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickMaster.Models
{
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    public class Book
    {
        public int Id { get; set; }

        [DisplayName("書籍名")]
        public string Title { get; set; }
        [DisplayName("価格")]
        [DataType(DataType.Currency)]
        public int Price { get; set; }
        [DisplayName("出版社")]
        public string Publisher { get; set; }
        [DisplayName("サンプルの有無")]
        public bool Sample { get; set; }
    }
}

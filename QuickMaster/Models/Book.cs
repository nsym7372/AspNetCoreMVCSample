using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickMaster.Models
{
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    public class Book : IValidatableObject
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0}は必須です")]
        [DisplayName("書籍名")]
        public string Title { get; set; }

        [Required(ErrorMessage = "{0}は必須です")]
        [Range(0, 10000, ErrorMessage = "{0}は{1}～{2}円以内で入力してください")]
        [DisplayName("価格")]
        [DataType(DataType.Currency)]
        public int Price { get; set; }
        [StringLength(20, ErrorMessage = "{0}は{1}文字以内で入力してください")]
        [DisplayName("出版社")]
        public string Publisher { get; set; }
        [DisplayName("サンプルの有無")]
        public bool Sample { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }


        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Publisher == "青空文庫" && Price != 0)
            {
                yield return new ValidationResult("青空文庫の価格は0円でなければいけません", new[] { "Price" });
            }
        }
    }
}

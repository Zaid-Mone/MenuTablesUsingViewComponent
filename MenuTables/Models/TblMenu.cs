using System.ComponentModel.DataAnnotations;

namespace MenuTables.Models
{
    public class TblMenu
    {
        public TblMenu()
        {
            
        }
        [Key]
        public Guid MenuId { get; set; }
        public string Url { get; set; } = string.Empty;
        public string  Icon { get; set; } = string.Empty;
        public string ArabicPageTitle { get; set; } = string.Empty;
        public string EnglishPageTitle { get; set; } = string.Empty;
        public bool IsShowInMenu { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<int> ParnetId { get; set; }
    }
}
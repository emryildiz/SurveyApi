using System.ComponentModel.DataAnnotations;


namespace SurveyApi.Common.Entities
{
    public class Choise : IEntity
    {
        [Key]
        public int Id { get; set; }

        public string ChoiseStr { get; set; }

        public Image Image { get; set; }
    }
}

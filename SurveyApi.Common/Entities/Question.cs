using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyApi.Common.Entities
{
    public class Question : IEntity
    {
        [Key]
        public int Id { get; set; }

        public string QuestionStr { get; set; }

        public List<Choise> Choises { get; set; }
    }
}

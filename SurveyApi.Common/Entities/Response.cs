using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyApi.Common.Entities
{
    public class Response : IEntity
    {
        [Key]
        public int Id { get; set; }

        public int SurveyId { get; set; }

        public int QuestionId { get; set; }

        public int ChoiseId { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
    }
}

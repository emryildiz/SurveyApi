using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyApi.Common.Entities
{
    public class Survey : IEntity
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public List<Question> Question { get; set; }

        public User Owner { get; set; }
        
        public DateTime CreatedDate { get; set; }

        public DateTime ExpiredDate { get; set;}
    }
}

using SurveyApi.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyApi.Common.Dtos
{
    public class SurveyDto
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public List<Question> Question { get; set; }

        public User Owner { get; set; }

        public DateTime ExpiredDate { get; set; }
    }

    public class SurveyCreateDto
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public List<Question> Question { get; set; }

        public User Owner { get; set; }

        public DateTime ExpiredDate { get; set; }
    }
}

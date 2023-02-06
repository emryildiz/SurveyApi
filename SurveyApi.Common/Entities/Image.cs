using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyApi.Common.Entities
{
    public class Image : IEntity
    {
        public int Id { get; set; }

        public byte[] ImageBytes { get; set; }
    }
}

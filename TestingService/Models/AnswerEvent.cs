using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestingService.Models.Base;

namespace TestingService.Models
{
    public class AnswerEvent : BaseModel
    {
        public Guid AnswerId { set; get; }
        AnswerEventTypeEnum Type { set; get; }
        public DateTime ClientTime { get; set; }
    }
}

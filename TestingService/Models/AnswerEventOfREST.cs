using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestingService.Models
{
    public class AnswerEventOfREST
    {   
        String Value { get; set; }
        AnswerEventTypeEnum Type { get; set; }
        DateTime ClientTime { get; set; }
    }
}

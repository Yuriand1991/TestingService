using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestingService.Models.Base;

namespace TestingService.Models
{
    public class Answer : BaseModel
    {
        public Guid QuestId;
        public int NumAnswer;
    }
}

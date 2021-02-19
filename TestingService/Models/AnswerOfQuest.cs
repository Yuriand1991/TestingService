using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestingService.Models.Base;

namespace TestingService.Models
{
    public class AnswerOfQuest : BaseModel
    {
        public Guid QuestId;
        public String AnswerText;
        public int NumAnswer;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestingService.Models.Base;

namespace TestingService.Models
{
    public class AnswerAttachment : BaseModel
    {
        public Guid AnswerId { get; set; }
        public DateTime Created { get; set; }
        public String FileName { get; set; }
        public String MimeType { get; set; }
        public Int32 Size { get; set; }
    }
}

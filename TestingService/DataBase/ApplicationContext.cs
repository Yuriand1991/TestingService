using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestingService.Models;

namespace TestingService.DataBase
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Answer> Answers { get; set; }
        public DbSet<AnswerAttachment> AnswerAttachments { get; set; }
        public DbSet<AnswerEvent> AnswerEvents { get; set; }
        public DbSet<Quest> Quests { get; set; }
        public DbSet<AnswerOfQuest> AnswerOfQuests { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}

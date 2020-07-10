using GameWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameWebApp.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any GameCreators.
            if (context.GameCreators.Any())
            {
                return;   // DB has been seeded
            }

            var GameCreators = new GameCreator[]
            {
            new GameCreator{CreatorId=1,CreatorName="Carson",Description="Alexander"},
            new GameCreator{CreatorId=2,CreatorName="Meredith",Description="Alonso"}
            };
            foreach (GameCreator s in GameCreators)
            {
                context.GameCreators.Add(s);
            }
            context.SaveChanges();

            var courses = new Game[]
            {
            new Game{GameId=1,GameName="Chemistry", Description="Test Game", CreatorId=2},
            new Game{GameId=2,GameName="Microeconomics",Description="Test Game", CreatorId=1}
            };
            foreach (Game c in courses)
            {
                context.Games.Add(c);
            }
            context.SaveChanges();

            context.SaveChanges();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;

namespace WebApplication1.Models
{
    public class OperasInitializer: DropCreateDatabaseAlways<OperaDBContext>
    {

        protected override void Seed(OperaDBContext context)
        {
            //base.Seed(context);

            var operas = new List<Opera>()
            {
                new Opera
                {
                   Title="Cosi Fan Tutte",
                   Year=1790,
                   Composer="Mozart"
                }
            };

            operas.ForEach(s => context.Operas.Add(s));
            context.SaveChanges();

        }
    }
}
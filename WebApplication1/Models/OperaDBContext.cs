using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;//EF


namespace WebApplication1.Models
{
    public class OperaDBContext:DbContext//EF
    {
        public OperaDBContext() : base("keyOperaDB") { }//constructor


        #region registrar modelos

        public DbSet<Opera> Operas { get; set; }

        #endregion

    }
}
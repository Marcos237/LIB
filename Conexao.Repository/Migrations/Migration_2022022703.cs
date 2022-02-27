using FluentMigrator;
using FluentMigrator.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conexao.Repository.Migrations
{
    [Migration(2022022703)]
    public class Migration_2022022703: Migration
    {
        public override void Down()
        {
            Delete.Table("TB_Conexao");
        }

        public override void Up()
        {
            Alter.Table("TB_Conexao")
                .AlterColumn("Banco").AsString(50).NotNullable();
        }
    }
}

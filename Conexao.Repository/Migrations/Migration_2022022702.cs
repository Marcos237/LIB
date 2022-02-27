using FluentMigrator;
using FluentMigrator.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conexao.Repository.Migrations
{
    [Migration(2022022702)]
    public class Migration_2022022702: Migration
    {
        public override void Down()
        {
            Delete.Table("TB_Conexao");
        }

        public override void Up()
        {
            Create.Table("TB_Conexao")
                .WithColumn("Id").AsInt32().NotNullable().PrimaryKey().Identity(1, 1).ForeignKey()
                .WithColumn("StringConexao").AsString(500).NotNullable()
                .WithColumn("Senha").AsString(16).NotNullable()
                .WithColumn("Banco").AsString(100).NotNullable()
                .WithColumn("DataCadastro").AsDateTime().NotNullable();
        }
    }
}

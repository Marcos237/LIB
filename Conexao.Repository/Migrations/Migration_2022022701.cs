using FluentMigrator;
using FluentMigrator.SqlServer;

namespace Conexao.Repository
{
    [Migration(2022022701)]
    public class Migration_2022022701: Migration
    {
        public override void Down()
        {
            Delete.Table("TB_Conexao");
        }

        public override void Up()
        {
            Create.Table("TB_Conexao")
                .WithColumn("Id").AsInt32().NotNullable().PrimaryKey().Identity(1, 1)
                .WithColumn("stringConexao").AsString().NotNullable()
                .WithColumn("senha").AsString().NotNullable()
                .WithColumn("banco").AsString().NotNullable()
                .WithColumn("dataCadastro").AsDateTime().NotNullable();
        }
    }
}

using Conexao.Repository;
using Conexao.Repository.Migrations;
using FluentMigrator.Runner;
using Microsoft.Extensions.Primitives;
using System.Reflection;

namespace Conexao_Web.AppStart
{

    public class FluentMigratorInitializer
    {

        public FluentMigratorInitializer()
        {

        }

        public void Initializer(IServiceCollection services)
        {
            services
                .AddFluentMigratorCore()
                .ConfigureRunner(rb => rb
                    .AddSqlServer2016()
                    .WithGlobalConnectionString("server=.; database=Conexao; Integrated Security=true")
                    .ScanIn(typeof(Migration_2022022703).Assembly).For.Migrations())
                .AddLogging(lb => lb.AddFluentMigratorConsole())
                .BuildServiceProvider(false);
        }
    }
}

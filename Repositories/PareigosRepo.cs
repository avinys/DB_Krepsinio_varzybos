using Krepsinio_varzybos.Models;

namespace Krepsinio_varzybos.Repositories
{
    public class PareigosRepo
    {
        public static List<Pareigos> List()
        {
            var query = $@"SELECT * FROM `pareigos`";
            var drc = Sql.Query(query);

            var result =
                Sql.MapAll<Pareigos>(drc, (dre, t) => {
                    t.Id = dre.From<int>("id_Pareigos");
                    t.Pavadinimas = dre.From<string>("Pavadinimas");
                });

            return result;
        }
    }
}

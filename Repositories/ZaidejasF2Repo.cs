using Krepsinio_varzybos.Models;

namespace Krepsinio_varzybos.Repositories
{
    public class ZaidejasF2Repo
    {
        public static List<ZaidejasF2> List()
        {
            string query = $@"SELECT * FROM `{Config.TblPrefix}zaidejai` ORDER BY z.id_Zaidejas ASC";
            var drc = Sql.Query(query);

            var result = Sql.MapAll<ZaidejasF2>(drc, (dre, z) =>
            {
                z.Id = dre.From<int>("id_Zaidejas");
                z.Vardas = dre.From<string>("Vardas");
                z.Pavarde = dre.From<string>("Pavarde");
            });

            return result;
        }
    }
}

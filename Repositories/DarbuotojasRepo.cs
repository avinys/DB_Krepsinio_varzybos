using Krepsinio_varzybos.Models;
using MySql.Data.MySqlClient;

namespace Krepsinio_varzybos.Repositories;

public class DarbuotojasRepo
{
    public static List<Darbuotojas> List()
    {
        string query = $@"SELECT * FROM `{Config.TblPrefix}darbuotojai` ORDER BY id_Darbuotojas ASC";
        var drc = Sql.Query(query);

        var result = Sql.MapAll<Darbuotojas>(drc, (dre, t) =>
        {
            t.Id = dre.From<int>("id_Darbuotojas");
            t.Vardas = dre.From<string>("Vardas");
            t.Pavarde = dre.From<string>("Pavarde");
            t.Pareigos = dre.From<string>("Pareigos");
            t.Patirtis = dre.From<int>("Patirtis");
            t.Sekretoriatas = dre.From<string>("fk_Sekretoriatasid_Sekretoriatas");
        });

        return result;
    }
}

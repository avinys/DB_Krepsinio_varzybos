namespace Krepsinio_varzybos.Repositories;

using Krepsinio_varzybos.Models;
using Krepsinio_varzybos;
using MySql.Data.MySqlClient;

using static System.Runtime.InteropServices.JavaScript.JSType;


public class ArenaRepo
{
    public static List<Arena> List()
    {
        string query = $@"SELECT * FROM `{Config.TblPrefix}arenos` ORDER BY id_Arena ASC";
        var drc = Sql.Query(query);

        var result =
            Sql.MapAll<Arena>(drc, (dre, t) => {
                t.Id = dre.From<int>("id_Arena");
                t.Pavadinimas = dre.From<string>("Pavadinimas");
                t.Miestas = dre.From<string>("Miestas");
                t.Talpa = dre.From<string>("Talpa");
                t.Savininkas = dre.From<string>("Savininkas");
                t.Atidarymas = dre.From<DateTime>("Atidarymas");
            });

        return result;
    }


}
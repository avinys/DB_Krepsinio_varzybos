namespace Krepsinio_varzybos.Repositories;

using MySql.Data.MySqlClient;
using Krepsinio_varzybos.Models;

public class KomandaRepo
{
    public static List<Komanda> List()
    {
        string query = $@"SELECT * FROM `{Config.TblPrefix}komandos` ORDER BY id_Komanda ASC";
        var drc = Sql.Query(query);

        var result = Sql.MapAll<Komanda>(drc, (dre, k) => {
            k.Id = dre.From<int>("id_Komanda");
            k.Pavadinimas = dre.From<string>("Pavadinimas");
            k.Salis = dre.From<string>("Salis");
            k.Miestas = dre.From<string>("Miestas");
            k.IkurimoData = dre.From<DateTime>("Ikurimo_data");
        });

        return result;
    }

    public static Komanda Find(int id)
    {
        var query = $@"SELECT * FROM `{Config.TblPrefix}komandos` WHERE id_Komanda=?id";
        //var drc = Sql.Query(query, new { id = id });
        var drc = Sql.Query(query, args => {
            args.Add("?id", id);
        });

        var result = Sql.MapOne<Komanda>(drc, (dre, k) => {
            k.Id = dre.From<int>("id_Komanda");
            k.Pavadinimas = dre.From<string>("Pavadinimas");
            k.Salis = dre.From<string>("Salis");
            k.Miestas = dre.From<string>("Miestas");
            k.IkurimoData = dre.From<DateTime>("Ikurimo_data");
        });

        return result;
    }

    public static void Update(Komanda komanda)
    {
        var query = $@"UPDATE `{Config.TblPrefix}komandos` SET
                        Pavadinimas=?Pavadinimas,
                        Salis=?Salis,
                        Miestas=?Miestas,
                        Ikurimo_data=?IkurimoData
                      WHERE id_Komanda=?Id";

        Sql.Update(query, args => {
            args.Add("?Id", komanda.Id);
            args.Add("?Pavadinimas", komanda.Pavadinimas);
            args.Add("?Salis", komanda.Salis);
            args.Add("?Miestas", komanda.Miestas);
            args.Add("?IkurimoData", komanda.IkurimoData);
        });
    }

    public static void Insert(Komanda komanda)
    {
        var query = $@"INSERT INTO `{Config.TblPrefix}komandos` (Pavadinimas, Salis, Miestas, Ikurimo_data) 
                       VALUES (?Pavadinimas, ?Salis, ?Miestas, ?IkurimoData)";

        Sql.Insert(query, args => {
            args.Add("?Pavadinimas", komanda.Pavadinimas);
            args.Add("?Salis", komanda.Salis);
            args.Add("?Miestas", komanda.Miestas);
            args.Add("?IkurimoData", komanda.IkurimoData);
        });
    }

    public static void Delete(int id)
    {
        var query = $@"DELETE FROM `{Config.TblPrefix}komandos` WHERE id_Komanda=?id";
        Sql.Delete(query, args =>
        {
            args.Add("?id", id);
        });
    }
}

using Krepsinio_varzybos;
using Krepsinio_varzybos.Models;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Krepsinio_varzybos.Repositories;

public class TrenerisRepo
{
	public static List<TrenerisL> List()
	{
		string query = $@"SELECT treneriai.*, komandos.Pavadinimas AS KomandosPavadinimas
                      FROM `{Config.TblPrefix}treneriai` AS treneriai
                      JOIN `{Config.TblPrefix}komandos` AS komandos ON treneriai.fk_Komandaid_Komanda = komandos.id_Komanda
                      ORDER BY treneriai.id_Treneris ASC";
		var drc = Sql.Query(query);

		var result = Sql.MapAll<TrenerisL>(drc, (dre, t) =>
		{
			t.Id = dre.From<int>("id_Treneris");
			t.Vardas = dre.From<string>("Vardas");
			t.Pavarde = dre.From<string>("Pavardė");
			t.Amzius = dre.From<int>("Amžius");
			t.Tautybe = dre.From<string>("Tautybė");
			t.Patirtis = dre.From<int>("Patirtis");
			t.Pareigos = dre.From<string>("Pareigos");
			t.Komanda = dre.From<string>("KomandosPavadinimas");  // Mapped from the JOINed komandos table
		});

		return result;
	}
	public static TrenerisCE FindTrenerisCE(int id)
	{
        var query = $@"SELECT * FROM `{Config.TblPrefix}treneriai` WHERE id_Treneris=?id";
		var drc = Sql.Query(query, args =>
		{
			args.Add("?id", id);
		});

		var result = Sql.MapOne<TrenerisCE>(drc, (dre, t) =>
        {
            var treneris = t.Treneris;
            treneris.Id = dre.From<int>("id_Treneris");
            treneris.Vardas = dre.From<string>("Vardas");
			treneris.Pavarde = dre.From<string>("Pavardė");
            treneris.Amzius = dre.From<int>("Amžius");
            treneris.Tautybe = dre.From<string>("Tautybė");
            treneris.Patirtis = dre.From<int>("Patirtis");
            treneris.Pareigos = dre.From<string>("Pareigos");
			treneris.FkKomanda = dre.From<int>("fk_Komandaid_Komanda");
        });
		return result;
    }

	public static void Update (TrenerisCE trenerisCE)
	{
        var query = $@"UPDATE `{Config.TblPrefix}treneriai` SET
                        Vardas=?vardas, Pavardė=?pavarde, Amžius=?amzius, Tautybė=?tautybe, Patirtis=?patirtis,
                        Pareigos=?pareigos, fk_Komandaid_Komanda=?komandaId
                       Where id_Treneris=?id";
        var tre = trenerisCE.Treneris;
        var drc = Sql.Update(query, args =>
        {
            args.Add("?id", tre.Id);
            args.Add("?vardas", tre.Vardas);
            args.Add("?pavarde", tre.Pavarde);
            args.Add("?amzius", tre.Amzius);
            args.Add("?tautybe", tre.Tautybe);
            args.Add("?patirtis", tre.Patirtis);
            args.Add("?pareigos", tre.Pareigos);
            args.Add("?komandaId", tre.FkKomanda);
        });
    }

    public static void Insert (TrenerisCE trenerisCE)
    {
        var query = $@"INSERT INTO `{Config.TblPrefix}treneriai` (Vardas, Pavardė, Amžius, Tautybė, Patirtis, Pareigos, fk_Komandaid_Komanda)
                        VALUES (?vardas, ?pavarde, ?amzius, ?tautybe, ?patirtis, ?pareigos, ?komandaId)";
        var tre = trenerisCE.Treneris;
        var drc = Sql.Insert(query, args =>
        {
            args.Add("?vardas", tre.Vardas);
            args.Add("?pavarde", tre.Pavarde);
            args.Add("?amzius", tre.Amzius);
            args.Add("?tautybe", tre.Tautybe);
            args.Add("?patirtis", tre.Patirtis);
            args.Add("?pareigos", tre.Pareigos);
            args.Add("?komandaId", tre.FkKomanda);
        });
    }
    public static void Delete(int id)
    {
        var query = $@"DELETE FROM `{Config.TblPrefix}treneriai` WHERE id_Treneris=?id";
        Sql.Delete(query, args =>
        {
            args.Add("?id", id);
        });
    }
}


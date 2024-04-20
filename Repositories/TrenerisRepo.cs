using Krepsinio_varzybos;
using Krepsinio_varzybos.Models;
using MySql.Data.MySqlClient;

using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Krepsinio_varzybos.Repositories;

public class TrenerisRepo
{
	public static List<Treneris> List()
	{
		string query = $@"SELECT treneriai.*, komandos.Pavadinimas AS KomandosPavadinimas
                      FROM `{Config.TblPrefix}treneriai` AS treneriai
                      JOIN `{Config.TblPrefix}komandos` AS komandos ON treneriai.fk_Komandaid_Komanda = komandos.id_Komanda
                      ORDER BY treneriai.id_Treneris ASC";
		var drc = Sql.Query(query);

		var result = Sql.MapAll<Treneris>(drc, (dre, t) =>
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
}


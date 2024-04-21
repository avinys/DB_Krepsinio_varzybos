using Krepsinio_varzybos.Models;
using MySql.Data.MySqlClient;

namespace Krepsinio_varzybos.Repositories;

public class ZaidejasRepo
{
	public static List<Zaidejas> ListZaidejas()
	{
		string query = $@"SELECT z.*, k.Pavadinimas AS KomandaPavadinimas
                          FROM `{Config.TblPrefix}zaidejai` AS z
                          JOIN `{Config.TblPrefix}komandos` AS k ON z.fk_Komandaid_Komanda = k.id_Komanda
                          ORDER BY z.id_Zaidejas ASC";
		var drc = Sql.Query(query);

		var result = Sql.MapAll<Zaidejas>(drc, (dre, z) =>
		{
			z.Id = dre.From<int>("id_Zaidejas");
			z.Vardas = dre.From<string>("Vardas");
			z.Pavarde = dre.From<string>("Pavarde");
			z.Ugis = dre.From<int>("Ugis");
			z.Svoris = dre.From<int>("Svoris");
			z.Amzius = dre.From<int>("Amzius");
			z.GimimoVieta = dre.From<string>("Gimimo_vieta");
			z.Tautybe = dre.From<string>("Tautybe");
			z.Pozicija = dre.From<string>("Pozicija");
			z.KomandaPavadinimas = dre.From<string>("KomandaPavadinimas");
		});

		return result;
	}

    public static ZaidejasCE FindZaidejasCE(int id)
    {
        var query = $@"SELECT * FROM `{Config.TblPrefix}zaidejai` WHERE id_Zaidejas=?id";

        var drc =
            Sql.Query(query, args => {
                args.Add("?id", id);
            });

        var result =
            Sql.MapOne<ZaidejasCE>(drc, (dre, t) => {
                // Shortcut to the zaidejas object within the ZaidejasCE composite entity
                var zaid = t.Zaidejas;

                // Mapping data from the data reader to the Zaidejas properties
                zaid.Id = dre.From<int>("id_Zaidejas");
                zaid.Vardas = dre.From<string>("Vardas");
                zaid.Pavarde = dre.From<string>("Pavarde");
                zaid.Ugis = dre.From<int>("Ugis");
                zaid.Svoris = dre.From<int>("Svoris");
                zaid.Amzius = dre.From<int>("Amzius");
                zaid.GimimoVieta = dre.From<string>("Gimimo_vieta");
                zaid.Tautybe = dre.From<string>("Tautybe");
                zaid.Pozicija = dre.From<string>("Pozicija");
                zaid.FkKomanda = dre.From<int>("fk_Komandaid_Komanda");
            });

        return result;
    }
    public static int InsertZaidejas(ZaidejasCE zaidejasCE)
    {
        var query =
            $@"INSERT INTO `{Config.TblPrefix}zaidejai`
			(
				`Vardas`,
				`Pavarde`,
				`Ugis`,
				`Svoris`,
				`Amzius`,
				`Gimimo_vieta`,
				`Tautybe`,
				`Pozicija`,
				`fk_Komandaid_Komanda`
			)
			VALUES (
				?v,
				?pv,
				?ugis,
				?svoris,
				?amzius,
				?gim,
				?tautybe,
				?poz,
				?fk_kom
			)";

        var nr = Sql.Insert(query, args => {
            var zaid = zaidejasCE.Zaidejas;

            args.Add("?v", zaid.Vardas);
            args.Add("?pv", zaid.Pavarde);
            args.Add("?ugis", zaid.Ugis);
            args.Add("?svoris", zaid.Svoris);
            args.Add("?amzius", zaid.Amzius);
            args.Add("?gim", zaid.GimimoVieta);
            args.Add("?tautybe", zaid.Tautybe);
            args.Add("?poz", zaid.Pozicija);
            args.Add("?fk_kom", zaid.FkKomanda);
        });
        return (int)nr;
    }

    public static void UpdateZaidejas(ZaidejasCE zaidejasCE)
    {
        var query =
            $@"UPDATE `{Config.TblPrefix}zaidejai`
        SET
            `Vardas` = ?v,
            `Pavarde` = ?pv,
            `Ugis` = ?ugis,
            `Svoris` = ?svoris,
            `Amzius` = ?amzius,
            `Gimimo_vieta` = ?gim,
            `Tautybe` = ?tautybe,
            `Pozicija` = ?poz,
            `fk_Komandaid_Komanda` = ?fk_kom
        WHERE
            `id_Zaidejas` = ?id";

        Sql.Update(query, args =>
        {
            // Shortcut to the zaidejas object
            var zaid = zaidejasCE.Zaidejas;

            // Adding parameters to the query
            args.Add("?v", zaid.Vardas);
            args.Add("?pv", zaid.Pavarde);
            args.Add("?ugis", zaid.Ugis);
            args.Add("?svoris", zaid.Svoris);
            args.Add("?amzius", zaid.Amzius);
            args.Add("?gim", zaid.GimimoVieta);
            args.Add("?tautybe", zaid.Tautybe);
            args.Add("?poz", zaid.Pozicija);
            args.Add("?fk_kom", zaid.FkKomanda);

            args.Add("?id", zaid.Id);
        });
    }

    public static void DeleteZaidejas(int id)
    {
        var query = $@"DELETE FROM `{Config.TblPrefix}zaidejai` WHERE id_Zaidejas=?id";
        Sql.Query(query, args => {
            args.Add("?id", id);
        });
    }
    public static List<ZaidejasCE.ZaidejoKarjerosEtapasM> ListZaidejoKarjerosEtapai(int zaidejasId)
    {
        var query =
                $@"SELECT
                    t.id_Karjeros_etapas,
                    t.Pradzios_data as pradzia,
                    t.Pabaigos_data as pabaiga,
                    t.Komanda as komanda,
                    pareigos.id_Pareigos as pareigos
                FROM
                    `karjeros_etapai` t
                    LEFT JOIN `pareigos` pareigos ON t.fk_Pareigosid_Pareigos=pareigos.id_Pareigos
                WHERE fk_Zaidejasid_Zaidejas=?zaidejasId"
    ;
        var drc = Sql.Query(query, args =>
        {
            args.Add("?zaidejasId", zaidejasId);
        });

        var result = Sql.MapAll<ZaidejasCE.ZaidejoKarjerosEtapasM>(drc, (dre, t) => {
            t.PradziosData = dre.From<DateTime>("pradzia");
            t.PabaigosData = dre.From<DateTime>("pabaiga");
            t.Komanda = dre.From<string>("komanda");
            t.FkPareigos = dre.From<int>("pareigos");
        });
        for (int i = 0; i < result.Count; i++)
            result[i].InListId = i;
        return result;
    }

    public static void InsertZaidejoKarjerosEtapas(int zaidejasId, ZaidejasCE.ZaidejoKarjerosEtapasM kar)
    {
        var query =
            $@"
                INSERT INTO `{Config.TblPrefix}karjeros_etapai`
                (
                    Pradzios_data,
                    Pabaigos_data,
                    Komanda,
                    fk_Zaidejasid_Zaidejas,
                    fk_Pareigosid_Pareigos
                )
                VALUES(
                    ?pradzia,
                    ?pabaiga,
                    ?komanda,
                    ?zaidejasId,
                    ?pareigosId
            )";
        Sql.Insert(query, args =>
        {
            args.Add("?pradzia", kar.PradziosData);
            args.Add("?pabaiga", kar.PabaigosData);
            args.Add("?komanda", kar.Komanda);
            args.Add("?zaidejasId", zaidejasId);
            args.Add("?pareigosId", kar.FkPareigos);
        });
    }

    public static void DeleteZaidejoKarjerosEtapai(int zaidejasId)
    {
        var query = $@"DELETE FROM karjeros_etapai WHERE fk_Zaidejasid_Zaidejas=?zaidId";
        Sql.Delete(query, args =>
        {
            args.Add("zaidId", zaidejasId);
        });
    }


    public static List<Komanda> ListKomanda()
    {
        var query = $@"SELECT * FROM `{Config.TblPrefix}komandos` ORDER BY id_Komanda ASC";
        var drc = Sql.Query(query);

        var result =
            Sql.MapAll<Komanda>(drc, (dre, t) => {
                t.Id = dre.From<int>("id_Komanda");
                t.Pavadinimas = dre.From<string>("Pavadinimas");
            });

        return result;
    }
}

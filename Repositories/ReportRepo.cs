using Krepsinio_varzybos.Models.Report;
namespace Krepsinio_varzybos.Repositories
{
    public class ReportRepo
    {
        public static List<KarjerosEtapas> GetKarjerosEtapai (DateTime? dateFrom, DateTime? dateTo, string? KEKomanda, string? vardas, string? pavarde, int? kiekis,  int? rikiavimas)
        {
            string rik;
            switch (rikiavimas)
            {
                case 1:
                    rik = "zaidsusk.Vardas ASC";
                    break;
                case 2:
                    rik = "zaidsusk.Vardas DESC";
                    break;
                case 3:
                    rik = "zaidsusk.Pavarde ASC";
                    break;
                case 4:
                    rik = "zaidsusk.Pavarde DESC";
                    break;
                case 5:
                    rik = "dbkomanda ASC";
                    break;
                case 6:
                    rik = "dbkomanda DESC";
                    break;
                default:
                    rik = "zaidsusk.Vardas ASC";
                    break;
            }

            var query = 
                $@"	SELECT * FROM 
                   (SELECT
                 	zaid.id_Zaidejas AS zaidId,
                    zaid.vardas,
                    zaid.pavarde,
                    ke.komanda,
                    IFNULL(kom.Pavadinimas, 'neaktyvus') AS dbkomanda,
                    ke.id_Karjeros_etapas AS keId,
                    pareigos.Pavadinimas,
                    ke.Pradzios_data AS pradzia,
                    ke.Pabaigos_data AS pabaiga,
                    DATEDIFF(ke.Pabaigos_data,ke.Pradzios_data) AS trukmeDienos,
                    SUM(DATEDIFF(ke.Pabaigos_data,ke.Pradzios_data)) OVER (PARTITION BY ke.fk_Zaidejasid_Zaidejas) AS visoDienu,
                    COUNT(ke.id_Karjeros_etapas) OVER (PARTITION BY ke.fk_Zaidejasid_Zaidejas) AS visoEtapu
                FROM
                    zaidejai AS zaid
                    LEFT JOIN komandos AS kom ON zaid.fk_Komandaid_Komanda = kom.id_Komanda
                    LEFT JOIN karjeros_etapai AS ke ON ke.fk_Zaidejasid_Zaidejas = zaid.id_Zaidejas
                    LEFT JOIN pareigos ON pareigos.id_Pareigos = ke.fk_Pareigosid_Pareigos
                WHERE
                    ke.Pradzios_data >= IFNULL(?nuo, ke.Pradzios_data)
                    AND ke.Pradzios_data <= IFNULL(?iki, ke.Pradzios_data)
                    AND LOWER(zaid.Vardas) LIKE IFNULL(NULL, LOWER(zaid.Vardas))
                    AND UPPER(zaid.Pavarde) LIKE IFNULL(?pavardeCheck, UPPER(zaid.Pavarde))
                    AND UPPER(IFNULL(kom.Pavadinimas, 'neaktyvus')) LIKE IFNULL(?komandaCheck, UPPER(IFNULL(kom.Pavadinimas, 'neaktyvus')))
                GROUP BY
                    zaid.Vardas, zaid.Pavarde, keId
                ) AS zaidsusk
                INNER JOIN karjeros_etapai AS ke on zaidsusk.zaidId = ke.fk_Zaidejasid_Zaidejas
                GROUP BY
                    keId
                ORDER BY {rik}
                ";


            string? vardasCheck;
            if (vardas != null)
                vardasCheck = String.Format("'{0}%'", vardas.ToLower());
            else
                vardasCheck = null;
            string? pavardeCheck;
            if (pavarde != null)
                pavardeCheck = "'" + pavarde.ToUpper() + "%'";
            else
                pavardeCheck = null;
            string? komandaCheck;
            if (KEKomanda != null)
                komandaCheck = "'" + KEKomanda.ToUpper() + "%'";
            else
                komandaCheck = null;


            
            var drc =
                Sql.Query(query, args =>
                {
                    args.Add("?nuo", dateFrom);
                    args.Add("?iki", dateTo);
                    args.Add("?vardasCheck", vardasCheck);
                    args.Add("?pavardeCheck", pavardeCheck);
                    args.Add("?komandaCheck", komandaCheck);
                });

            var result =
                Sql.MapAll<KarjerosEtapas>(drc, (dre, t) =>
                {
                    t.Id = dre.From<int>("zaidId");
                    t.Vardas = vardasCheck;
                    t.Pavarde = dre.From<string>("pavarde");
                    t.KomandaDabar = dre.From<string>("dbkomanda");
                    t.KarjerosEtapasId = dre.From<int>("keId");
                    t.Komanda = dre.From<string>("komanda");
                    t.Vardas = dre.From<string>("vardas");
                    t.Pareigos = dre.From<string>("Pavadinimas");
                    t.PradziosData = dre.From<DateTime>("pradzia");
                    t.PabaigosData = dre.From<DateTime>("pabaiga");
                    t.Trukme = dre.From<int>("trukmeDienos");
                    t.VisoDienu = dre.From<int>("visoDienu");
                    t.VisoEtapu = dre.From<int>("visoEtapu");
                });
            return result;
        }
    }
}

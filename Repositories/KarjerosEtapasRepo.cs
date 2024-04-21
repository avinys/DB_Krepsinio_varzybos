using Krepsinio_varzybos.Models;
using Mysqlx.Crud;
namespace Krepsinio_varzybos.Repositories
{
    public class KarjerosEtapasRepo
    {
        public static List<KarjerosEtapasL> ListKarjerosEtapas()
        {
            var query =
                $@"SELECT
                    t.id_Karjeros_etapas,
                    t.Pradzios_data as pradzia,
                    t.Pabaigos_data as pabaiga,
                    t.Komanda as komanda,
                    zaidejas.Vardas as vardas,
                    zaidejas.Pavarde as pavarde,
                    pareigos.Pavadinimas as pareigos
                FROM
                    `karjeros_etapai` t
                    LEFT JOIN `zaidejai` zaidejas ON t.fk_Zaidejasid_Zaidejas=zaidejas.id_Zaidejas
                    LEFT JOIN `pareigos` pareigos ON t.fk_Pareigosid_Pareigos=pareigos.id_Pareigos"
                ;
            var drc = Sql.Query(query);

            var result = Sql.MapAll<KarjerosEtapasL>(drc, (dre, t) => {
                t.Id = dre.From<int>("id_Karjeros_etapas");
                t.Pradzios_data = dre.From<DateTime>("pradzia");
                t.Pabaigos_data = dre.From<DateTime>("pabaiga");
                t.Komanda = dre.From<string>("komanda");
                t.ZaidejasVardas = dre.From<string>("vardas");
                t.ZaidejasPavarde = dre.From<string>("pavarde");
                t.PareigosPavadinimas = dre.From<string>("pareigos");
            });
            return result;
        }
        public static KarjerosEtapasCE FindKarjerosEtapasCE(int id)
        {
            var query = $@"SELECT * FROM `karjeros_etapai` WHERE id_Karjeros_etapas=?id";
            var drc =
                Sql.Query(query, args => {
                    args.Add("?id", id);
                });

            var result = Sql.MapOne<KarjerosEtapasCE> (drc, (dre, t) =>
            {
                var etapas = t.KarjerosEtapas;

                etapas.Id = dre.From<int>("id_Karjeros_etapas");
                etapas.Pradzios_data = dre.From<DateTime>("Pradzios_data");
                etapas.Pabaigos_data = dre.From<DateTime>("Pabaigos_data");
                etapas.Komanda = dre.From<string>("Komanda");
                etapas.FkZaidejas = dre.From<int>("fk_Zaidejasid_Zaidejas");
                etapas.FkPareigos = dre.From<int>("fk_Pareigosid_Pareigos");
            });
            return result;
        }
        public static void UpdateKarjerosEtapas(KarjerosEtapasCE karCE)
        {
            var query = $@"UPDATE `{Config.TblPrefix}karjeros_etapai` SET
                        Pradzios_data=?pradzia,
                        Pabaigos_data=?pabaiga,
                        Komanda=?komanda,
                        fk_Zaidejasid_Zaidejas=?zaidejasId,
                        fk_Pareigosid_Pareigos=?pareigosId
                      WHERE id_Karjeros_etapas=?Id";

            var karjera = karCE.KarjerosEtapas;
            Sql.Update(query, args => {
                args.Add("?Id", karjera.Id);
                args.Add("?pradzia", karjera.Pradzios_data);
                args.Add("?pabaiga", karjera.Pabaigos_data);
                args.Add("?komanda", karjera.Komanda);
                args.Add("?zaidejasId", karjera.FkZaidejas);
                args.Add("?pareigosId", karjera.FkPareigos);
            });
        }

        public static void Insert(KarjerosEtapasCE karCE)
        {
            var query = $@"INSERT INTO `{Config.TblPrefix}karjeros_etapai` (Pradzios_data, Pabaigos_data, Komanda, fk_Zaidejasid_Zaidejas, fk_Pareigosid_Pareigos) 
                       VALUES (?pradzia, ?pabaiga, ?komanda, ?zaidejas, ?pareigos)";
            var karjera = karCE.KarjerosEtapas;
            Sql.Insert(query, args => {
                args.Add("?pradzia", karjera.Pradzios_data);
                args.Add("?pabaiga", karjera.Pabaigos_data);
                args.Add("?komanda", karjera.Komanda);
                args.Add("?zaidejas", karjera.FkZaidejas);
                args.Add("?pareigos", karjera.FkPareigos);
            });
        }
        public static void Delete(int id)
        {
            var query = $@"DELETE FROM `{Config.TblPrefix}karjeros_etapai` WHERE id_Karjeros_etapas=?id";
            Sql.Delete(query, args =>
            {
                args.Add("?id", id);
            });
        }
    }
}

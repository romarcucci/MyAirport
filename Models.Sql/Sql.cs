using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyAirport.Pim.Entities;
using System.Configuration;
using System.Data.SqlClient;

namespace MyAirport.Pim.Models
{
    public class Sql : AbstractDefinition
    {
        string strCnx = ConfigurationManager.ConnectionStrings["MyAirport.Pim.Settings.DbConnect"].ConnectionString;

        string commandGetBagageIata =
            "SELECT b.ID_BAGAGE, c.NOM as compagnie, b.CODE_IATA, b.LIGNE, b.DATE_CREATION, b.ESCALE, b.CLASSE, cc.PRIORITAIRE, cast(iif(b.CONTINUATION='N',0,1) as bit) as Continuation, cast(iif(bp.PARTICULARITE is null, 0, 1) as bit) as 'RUSH' " +
            "FROM BAGAGE b " +
            "LEFT OUTER JOIN BAGAGE_A_POUR_PARTICULARITE bap on bap.ID_BAGAGE = b.ID_BAGAGE " +
            "LEFT OUTER JOIN BAGAGE_PARTICULARITE bp on bp.ID_PART = bap.ID_PARTICULARITE and bp.PARTICULARITE = 'RUSH' " +
            "LEFT OUTER JOIN COMPAGNIE c on c.CODE_IATA = b.COMPAGNIE " +
            "LEFT OUTER JOIN COMPAGNIE_CLASSE cc on cc.ID_COMPAGNIE = c.ID_COMPAGNIE and cc.CLASSE = b.CLASSE " +
            "WHERE b.CODE_IATA = @id";
        string commandGetBagageId =
            "SELECT b.ID_BAGAGE, c.NOM as compagnie, b.CODE_IATA, b.LIGNE, b.DATE_CREATION, b.ESCALE, b.CLASSE, cc.PRIORITAIRE, cast(iif(b.CONTINUATION='N',0,1) as bit) as Continuation, cast(iif(bp.PARTICULARITE is null, 0, 1) as bit) as 'RUSH' " +
            "FROM BAGAGE b " +
            "LEFT OUTER JOIN BAGAGE_A_POUR_PARTICULARITE bap on bap.ID_BAGAGE = b.ID_BAGAGE " +
            "LEFT OUTER JOIN BAGAGE_PARTICULARITE bp on bp.ID_PART = bap.ID_PARTICULARITE and bp.PARTICULARITE = 'RUSH' " +
            "LEFT OUTER JOIN COMPAGNIE c on c.CODE_IATA = b.COMPAGNIE " +
            "LEFT OUTER JOIN COMPAGNIE_CLASSE cc on cc.ID_COMPAGNIE = c.ID_COMPAGNIE and cc.CLASSE = b.CLASSE " +
            "WHERE b.id_bagage = @id";
        string commandInsertBagage =
                "INSERT INTO BAGAGE(CODE_IATA, ORIGINE_CREATION, DATE_CREATION, CLASSE, PRIORITAIRE, STA, LOCAL_TRANFERT, ISUR, DESTINATION, ESCALE, EMB, RECOLE, COMPAGNIE, LIGNE, JOUR_EXPLOITATION, CONTINUATION, DCS_EMETTEUR, ORIGINE_SAFIR, EN_CONTINUATION, EN_TRANSFERT)"
                + " VALUES(@codeIata, 'D', @dateCreation, 'Y', @prioritaire, 'B', 'T', 0, @itineraire, 'MIA', 1, 0, @compagnie, @ligne, 17, @continuation, 'SB46', 0, 0, 0); SELECT SCOPE_IDENTITY()";

        string commandInsertBagage2 = "INSERT INTO BAGAGE_A_POUR_PARTICULARITE VALUES (@idBagage, @particularite)";


        public override BagageDefinition GetBagage(int idBagage)
        {
            BagageDefinition bagRes = null;
            using (SqlConnection cnx = new SqlConnection(strCnx))
            {
                SqlCommand cmd = new SqlCommand(this.commandGetBagageId, cnx);
                cmd.Parameters.AddWithValue("@id", idBagage);
                cnx.Open();

                using (SqlDataReader sdr = cmd.ExecuteReader())
                {
                    if (sdr.Read())
                    {
                        bagRes = extSDR(sdr);
                    }
                }
            }
            return bagRes;
        }

        public override List<BagageDefinition> GetBagage(string codeIataBagage)
        {
            List<BagageDefinition> bagRes = new List<BagageDefinition>();
            using (SqlConnection cnx = new SqlConnection(strCnx))
            {
                SqlCommand cmd = new SqlCommand(this.commandGetBagageIata, cnx);
                cmd.Parameters.AddWithValue("@id", codeIataBagage);
                cnx.Open();

                using (SqlDataReader res = cmd.ExecuteReader())
                {
                    while (res.Read())
                    {
                        BagageDefinition bagage = extSDR(res);
                        bagRes.Add(bagage);
                    }
                }
            }
            return bagRes;
        }

        public override long CreateBagage(BagageDefinition bagage)
        {
            using (SqlConnection cnx = new SqlConnection(strCnx))
            {
                SqlCommand cmd = new SqlCommand(this.commandInsertBagage, cnx);
                SqlCommand cmd2 = new SqlCommand(this.commandInsertBagage2, cnx);

                cmd.Parameters.AddWithValue("@codeIata", bagage.CodeIata);
                cmd.Parameters.AddWithValue("@prioritaire", bagage.Prioritaire);
                cmd.Parameters.AddWithValue("@itineraire", bagage.Itineraire);
                cmd.Parameters.AddWithValue("@dateCreation", (System.Data.SqlTypes.SqlDateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))));
                cmd.Parameters.AddWithValue("@compagnie", bagage.Compagnie);
                cmd.Parameters.AddWithValue("@ligne", bagage.Ligne);
                cmd.Parameters.AddWithValue("@continuation", bagage.EnContinuation);
                cnx.Open();
                long res = Convert.ToInt32(cmd.ExecuteScalar());
                if (bagage.Rush == true)
                {
                    cmd2.Parameters.AddWithValue("@idBagage", res);
                    cmd2.Parameters.AddWithValue("@particularite", 10);
                    cmd2.ExecuteScalar();
                }
                return res;
            }
        }

        public BagageDefinition extSDR(SqlDataReader sdr)
        {
            BagageDefinition bag = new BagageDefinition
            {
                CodeIata = sdr.GetString(sdr.GetOrdinal("code_iata")),
                Compagnie = sdr.GetString(sdr.GetOrdinal("compagnie")),
                DateVol = sdr.GetDateTime(sdr.GetOrdinal("date_creation")),
                EnContinuation = sdr.GetBoolean(sdr.GetOrdinal("continuation")),
                IdBagage = sdr.GetInt32(sdr.GetOrdinal("id_bagage")),
                Itineraire = sdr.GetString(sdr.GetOrdinal("escale")),
                Ligne = sdr.GetString(sdr.GetOrdinal("ligne")),
                Prioritaire = sdr.GetBoolean(sdr.GetOrdinal("prioritaire")),
                Classe = sdr.GetString(sdr.GetOrdinal("classe")),
                Rush = sdr.GetBoolean(sdr.GetOrdinal("rush"))
            };

            return bag;
        }
    }
}
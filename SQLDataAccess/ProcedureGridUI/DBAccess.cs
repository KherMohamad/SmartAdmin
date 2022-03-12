using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Reflection;

namespace ProcedureGridUI
{
    public class DBAccess
    {
        public List<InfoAngajat> GetInfoAngajati(int idAngajat, string dataInceput, string dataFinal)
        {
            using (IDbConnection connection =
                new System.Data.SqlClient.SqlConnection(Helper.ConnStringVal("windsoftProjDB")))
            {
                var output = connection.Query<InfoAngajat>("dbo.spProject_GetEmployeeData @idAngajat, @dataInceput, @dataFinal",
                new
                {
                    @idAngajat = idAngajat,
                    @dataInceput = Convert.ToDateTime(dataInceput),
                    @dataFinal = Convert.ToDateTime(dataFinal)
                }).ToList();

                return output;
            }
        }

        public List<InfoDepartament> GetInfoDepartamente(string dataInceput, string dataFinal)
        {
            using (IDbConnection connection =
                new System.Data.SqlClient.SqlConnection(Helper.ConnStringVal("windsoftProjDB")))
            {
                var output = connection.Query<InfoDepartament>("dbo.spProject_getInfoDepartamente  @dataInceput, @dataFinal",
                new
                {
                    @dataInceput = Convert.ToDateTime(dataInceput),
                    @dataFinal = Convert.ToDateTime(dataFinal)
                }).ToList();
                return output;
            }  
        }

        public List<InfoIstoric> GetAngajariRecente()
        {
            using (IDbConnection connection =
               new System.Data.SqlClient.SqlConnection(Helper.ConnStringVal("windsoftProjDB")))
            {
                var output = connection.Query<InfoIstoric>("dbo.getAngajariRecente").ToList();
                return output;
            }
        }
    

        public void InsertAngajat(string nume, string prenume, string dataNasterii, string isManager, string numeDepartament)
        {
            using (IDbConnection connection =
               new System.Data.SqlClient.SqlConnection(Helper.ConnStringVal("windsoftProjDB")))
            {
                connection.Execute("dbo.spProject_insertAngajat @nume, @prenume, @dataNasterii, @isManager, @numeDepartament",
                    new
                    {
                        @nume = nume,
                        @prenume = prenume,
                        @dataNasterii = Convert.ToDateTime(dataNasterii),
                        @isManager = isManager,
                        @numeDepartament = numeDepartament
                    });
            }
        }

        public void InsertPlata(int idAngajat, int idTipPlata, int valoarePlata, int idValuta, string dataPlata)
        {
            using (IDbConnection connection =
              new System.Data.SqlClient.SqlConnection(Helper.ConnStringVal("windsoftProjDB")))
            {
                connection.Execute("dbo.spProject_insertPlata @idAngajat, @idTipPlata, @valoarePlata, @idValuta, @dataPlata",
                    new
                    {
                        @idAngajat = idAngajat,
                        @idTipPlata = idTipPlata,
                        @valoarePlata = valoarePlata,
                        @idValuta = idValuta,
                        @dataPlata = Convert.ToDateTime(dataPlata)
                    });
            }
        }
        

    }
}

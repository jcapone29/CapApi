using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Dapper;
using DataAccess.Entities;

namespace DataAccess.Repositories
{
    class PotatoRepository: IRepository
    {
        public async Task<IEnumerable<Potato>> GetPotatos(string id)
        {
            var sql = "Select * from PotatoUsers where Id in ('" + id + ")'";

            using (var conn = DataConnectionProvider.GetProdConnection())
            {
                return await conn.QueryAsync<Potato>(sql);
            }
        }

        public async Task<IEnumerable<Potato>> CreatePotato(Potato user)
        {
            var sql = "INSERT INTO [dbo].[PotatoUsers]  ([UserName] ,[Password] ,[Email] ,[FirstName] ,[LastName])" +
                      "VALUES (" +
                        "'" + user.UserName + "'" +
                        "'" + user.Password + "'" +
                        "'" + user.Email + "'" +
                        "'" + user.FirstName + "'" +
                        "'" + user.LastName + "')";

            using (var conn = DataConnectionProvider.GetProdConnection())
            {
                return await conn.QueryAsync<Potato>(sql);
            }
        }

        public async Task<IEnumerable<Leagues>> GetLeagues(Leagues league)
        {
            var sql = "SELECT * FROM [Leagues] WHERE (',' + RTRIM(MyColumn) + ',') LIKE '%,' + " + league.Id + " + ',%'";

            using (var conn = DataConnectionProvider.GetProdConnection())
            {
                return await conn.QueryAsync<Leagues>(sql);
            }
        }

        public async Task<IEnumerable<Leagues>> CreateLeague(Leagues league)
        {
            var sql = "";

            using (var conn = DataConnectionProvider.GetProdConnection())
            {
                return await conn.QueryAsync<Leagues>(sql);
            }
        }

        public async Task<IEnumerable<Scores>> AddScore(Scores scores)
        {
            var sql = "INSERT INTO [dbo].[Scores]  ([UserId] ,[Score] ,[Course] ,[RoundDate])" +
                      "VALUES (" +
                        "'" + scores.UserId + "'" +
                        "'" + scores.Score + "'" +
                        "'" + scores.Course + "'" +
                        "'" + scores.RoundDate + "')";

            using (var conn = DataConnectionProvider.GetProdConnection())
            {
                return await conn.QueryAsync<Scores>(sql);
            }
        }

        public async Task<IEnumerable<Scores>> GetScores(string id)
        {
            var sql = "SELECT * FROM [Scores] where Id in ('" + id + ")'";

            using (var conn = DataConnectionProvider.GetProdConnection())
            {
                return await conn.QueryAsync<Scores>(sql);
            }
        }
    }
}

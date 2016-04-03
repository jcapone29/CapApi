using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Dapper;
using DataAccess.Entities;

namespace DataAccess.Repositories
{
    class PotatoRepository: IRepository
    {
        public async Task<IEnumerable<Potato>> GetLeaguePotato()
        {
            var sql = "select Id, Username, Email, FirstName, LastName from [dbo].[PotatoUsers]";

            using (var conn = DataConnectionProvider.GetProdConnection())
            {
                return await conn.QueryAsync<Potato>(sql);
            }
        }

        public async Task<IEnumerable<Potato>> GetPotatos(string id)
        {
            var sql = "Select * from PotatoUsers where Id in ('" + id + "')";

            using (var conn = DataConnectionProvider.GetProdConnection())
            {
                return await conn.QueryAsync<Potato>(sql);
            }
        }

        public async Task<IEnumerable<Potato>> CreatePotato(Potato currentUser)
        {
            var sql = "INSERT INTO [dbo].[PotatoUsers]  ([UserName] ,[Password] ,[Email] ,[FirstName] ,[LastName])" +
                      "VALUES (" +
                        "'" + currentUser.UserName + "'," +
                        "'" + currentUser.Password + "'," +
                        "'" + currentUser.Email + "'," +
                        "'" + currentUser.FirstName + "'," +
                        "'" + currentUser.LastName + "')";

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
                        "'" + scores.UserId.Id + "'," +
                        "'" + scores.Score + "'," +
                        "'" + scores.Course.Name + "'," +
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

        public async Task<IEnumerable<Potato>> GetPotato(Potato currentUser)
        {
            var sql = "Select * from PotatoUsers where UserName = '" + currentUser.UserName + "' and Password = '" + currentUser.Password + "'";

            using (var conn = DataConnectionProvider.GetProdConnection())
            {
                return await conn.QueryAsync<Potato>(sql);
            }
        }

        public async Task<IEnumerable<string>> GetStates()
        {
            var sql = "select distinct [State] from  [dbo].[UsaCourseList] where [state] is not null and LEN([state]) < 4 order by [state] asc ";

            using (var conn = DataConnectionProvider.GetProdConnection())
            {
                return await conn.QueryAsync<string>(sql);
            }
        }

        public async Task<IEnumerable<Course>> GetCourseList(string state, string gender)
        {
            var sql = "select distinct  *  from [dbo].[UsaCourseList] where state = '" + state + "' and Gender = '" + gender + "' order by name asc";

            using (var conn = DataConnectionProvider.GetProdConnection())
            {
                return await conn.QueryAsync<Course>(sql);
            }
        }
    }
}

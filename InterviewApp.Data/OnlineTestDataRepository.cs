using Dapper;
using InterviewApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace InterviewApp.Data
{
    public class OnlineTestDataRepository: IRepository<QuestionAnswers>
    {
        private IDbConnection dbConnection = null;
        public OnlineTestDataRepository()
        {
            dbConnection = new SqlConnection();
        }

        public bool Add(QuestionAnswers questions)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<QuestionAnswers> GetAll()
        {
            string sql = ConfigReader.ReadAllCommand;
            var queryResult = dbConnection.Query<QuestionAnswers>(sql);

            return queryResult.ToList();
        }

        public QuestionAnswers GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(QuestionAnswers employee)
        {
            throw new NotImplementedException();
        }
    }
}

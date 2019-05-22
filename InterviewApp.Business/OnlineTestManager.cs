using Dapper;
using InterviewApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewApp.Business
{
    public class OnlineTestManager
    {
        public  static async Task<IEnumerable<QuestionAnswers>> GetQuestionAndAnswers(string connstr)
        {
            var result = new List<QuestionAnswers>();
            try
            {
                using (IDbConnection con = new SqlConnection(connstr))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();

                    var reader = await con.QueryMultipleAsync("sp_get_questions_answers",CommandType.StoredProcedure);
                    var questions = reader.Read<Questions>();
                }
                return result;
            }
            catch(Exception ex) {

            }
            return result;
        }

        //private static List<QuestionAnswers> AddQuestionAndAnswers(Task<SqlMapper.GridReader> reader)
        //{
        //    batchId = reader.Read<int>().FirstOrDefault();
        //    payment = reader.Read<Payment>().ToList();
        //}
    }
}

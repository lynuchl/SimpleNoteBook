using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBook.DBHelper
{
    class DBSqlString
    {

        /// <summary>
        /// 文本保存
        /// </summary>
        /// <param name="title"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public static string save (string title,string context) {

            //string sql="insert into user(id,username,password) values()"

            //string sql = string.Format("insert into text(title,context) values(@title,@context)",title,context);

            string sql = "insert into text (title,context) values('" + title + "','" + context + "')";
            return sql;
        }

        /// <summary>
        /// 根据标题查询
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        public static string query(string subTitle)
        {
            string sql = "select id,title,context from text where title like '%"+ subTitle+"%'";

            return sql;
        }
    }
}

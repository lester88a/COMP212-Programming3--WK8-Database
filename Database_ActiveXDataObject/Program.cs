using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_ActiveXDataObject
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * ADO > ActiveX Data Object
             * DAO > Data Access Object 
             *      Ist Link - Object
             *      
             * [ADO.Net for TEST2]
             *      > A set of object - oriented libraries
             *      > For database connectivity, also used for [text files, spreadsheets] connectivity.
             * 
             *  A. data providers [oracle, mysql...] ~~ Libaries:
             *      
             *      1. ODBC [object database connectivity] Data provider:  older databases.
             *      2. OLEDB [object Link Embedded Database] Data provider: new dbs + Access + Excel
             *      3. Oracle Data provider: for oracle database
             *      4. Sql Data provider: for Microsoft SQL Sever
             *      5. BDP [Burland] Data provider: for sql server, IBM, DB2, Oracle. 
             *      
             */

            /*
             * 5 ADO.Net Objects:
             *  1. The SqlConnection Object:
             *      ~is a must(Required)
             *      ~helps identifying the server, db name, user name, password and any other parameters
             *      ~used by sqlCommand object
             *      ~see example
             *      
             *  2. The Sql Command object:
             *      ~EXECUTES an action(command, i.e sql statement) with the help of the connection object
             * 
             *  3. The Sql DataReader Object:
             * 
             *  4. The Dataset Object:
             * 
             *  5. The SqlDataAdapter Object:
             */

            // The SqlConnection Object Example:
            // class name             constructor                        connection string
            SqlConnection conn = new SqlConnection("Data Source = Local; Initial Catalog = North Wind; Integrated Security = SSPI");
            SqlConnection conn2 = new SqlConnection("Data Source = Database Server; Initial Catalog = North Wind; User ID = XXX; Password = YYY");

            // The Sql Command object Example:
            SqlCommand cmd = new SqlCommand("SELECT * from students", conn2);

            // The Sql DataReader object Example [return something]:
            //  class |  object | command object
            SqlDataReader rdr = cmd.ExecuteReader(); //Cannot do SqlDataReader rdr = new SqlDataReader(); !!!

            // The Sql Command object Example: Inserting Data
            //1.prepare the string
            string insertString = "INSERT INTO students (stID, stName) VALUES('001', 'LiXu')";
            //2.create the command object
            SqlCommand cmd2 = new SqlCommand(insertString, conn2);
            //3. excute the non-query
            cmd2.ExecuteNonQuery(); // when insert then return nonthing, then use NonQuery

            /*
             * using System.Data.SqlClient; > will include all libraries needed
             * 
             */
        }
    }
}

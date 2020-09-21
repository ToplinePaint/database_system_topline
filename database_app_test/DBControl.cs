using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace database_app_test
{
    public class DBControl
    {
        private OleDbConnection dbconn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Paint-2020-Raw-Materials-copy-for-Josh.mdb");

        //cmd inputs
        private OleDbCommand dbcmd;

        //data usage
        public OleDbDataAdapter dbda;
        public DataTable dbdt;

        //query parameters
        public List<OleDbParameter> listParams = new List<OleDbParameter>();

        //query stats
        public int recordCount;
        //when things break, they are listed here
        public string exceptions;

        public void ExecQuery(string Query)
        {
            //reset vars for each query
            recordCount = 0;
            exceptions = "";

            //do this async to wait for the db
            try
            {
                //open connection to db
                dbconn.Open();

                //use connection
                dbcmd = new OleDbCommand(Query, dbconn);

                //load params
                foreach (OleDbParameter p in listParams)
                    dbcmd.Parameters.Add(p);

                //clear params
                listParams.Clear();

                //execute
                dbdt = new DataTable();
                dbda = new OleDbDataAdapter(dbcmd);

                recordCount = dbda.Fill(dbdt);
            }
            catch (Exception err)
            {
                //exception handling for when queries go wrong
                exceptions = err.Message;
            }

            //close connection
            if (dbconn.State == ConnectionState.Open)
            {
                dbconn.Close();
            }
        }

        //query and command parameters
        public void AddParam(string name, object value)
        {
            var newParam = new OleDbParameter(name, value);

            listParams.Add(newParam);
        }

    }
}

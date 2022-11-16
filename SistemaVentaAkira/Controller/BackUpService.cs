using SistemaVentaAkira.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentaAkira.Controller
{
    public class BackUpService
    {
        //Bakcup de la base de datos
        public bool BackUpGrabar(string p_Nombre, string ruta)
        {
            using (Akira_IndumentariaEntities dbAkira = new Akira_IndumentariaEntities())
            {
                string DB = dbAkira.Database.Connection.Database;
                string sqlCommand = "BACKUP DATABASE [{0}] TO  DISK = N'{1}' WITH NOFORMAT, NOINIT,  NAME = N'AkiraIndumentaria-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10";
                dbAkira.Database.ExecuteSqlCommand(System.Data.Entity.TransactionalBehavior.DoNotEnsureTransaction, string.Format(sqlCommand, DB, ruta));

                return true;
            }
        }
        //Restore de la base de datos
        public bool RestoreDB(string ruta)
        {
            using (Akira_IndumentariaEntities dbAkira = new Akira_IndumentariaEntities())
            {
                string DB = dbAkira.Database.Connection.Database;
                string sqlCommand = "USE[master] RESTORE DATABASE[{0}] FROM DISK = N'{1}' WITH FILE = 1, NOUNLOAD, STATS = 5";
                string sqlCommand1 = "USE[master] ALTER DATABASE [{0}] SET Single_User WITH Rollback Immediate";
                string sqlCommand2 = "USE[master] ALTER DATABASE [{0}] SET Multi_User";

                dbAkira.Database.ExecuteSqlCommand(System.Data.Entity.TransactionalBehavior.DoNotEnsureTransaction, string.Format(sqlCommand1, DB));
                dbAkira.Database.ExecuteSqlCommand(System.Data.Entity.TransactionalBehavior.DoNotEnsureTransaction, string.Format(sqlCommand, DB, ruta));
                dbAkira.Database.ExecuteSqlCommand(System.Data.Entity.TransactionalBehavior.DoNotEnsureTransaction, string.Format(sqlCommand2, DB));

                return true;
            }
        }
    }
}

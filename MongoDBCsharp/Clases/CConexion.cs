using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Windows.Forms;

namespace MongoDBCsharp.Clases
{
    class CConexion
    {

        static String servidor="localhost";
        static String puerto= "27017";

        public static MongoClient cliente = new MongoClient("mongodb://"+servidor+":"+puerto);

        public MongoClient establecerConexion() {
            try {
                List<String> NombresBasesDatos = cliente.ListDatabaseNames().ToList();

                foreach (var db in NombresBasesDatos) {

                    MessageBox.Show("Se pudo conectar correctamente a la Base de Datos: "+ db.ToString());
                }
            }
            catch (MongoClientException e) {

                MessageBox.Show("No se logró conectar a MongoDB, error: "+ e.ToString());
            
            }

            return cliente;
        }
    }
}

using System;
using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;
using Raven.Client.Documents;
using Raven.Client.Documents.BulkInsert;

namespace LoadDataJsonSNCF
{
    class Program
    {
        static void Main(string[] args)
        {
            var store = new DocumentStore
            {
                Urls = new[] { "http://localhost:8080" },
                Database = "Objets_Trouves"
            };
            store.Initialize();

            using (BulkInsertOperation bulkInsert = store.BulkInsert())
            using (StreamReader sr = new StreamReader("/Volumes/MicroSD/Olivier/1.Cnam/01.NFE204/donnees_projet/objets-trouves-restitution.json"))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                JsonSerializer serializer = new JsonSerializer();

                List<Record> rec = serializer.Deserialize<List<Record>>(reader);
                foreach (var repo in rec)
                {
                    var recdb = new RecDB
                    {

                        datasetid = repo.datasetid,
                        recordid = repo.recordid,
                        record_timestamp = repo.record_timestamp,
                        gc_obo_gare_origine_r_code_uic_c = repo.fields.gc_obo_gare_origine_r_code_uic_c,
                        gc_obo_nature_c = repo.fields.gc_obo_nature_c,
                        gc_obo_gare_origine_r_name = repo.fields.gc_obo_gare_origine_r_name,
                        date = repo.fields.date,
                        gc_obo_nom_recordtype_sc_c = repo.fields.gc_obo_nom_recordtype_sc_c,
                        gc_obo_type_c = repo.fields.gc_obo_type_c

                    };
                    bulkInsert.Store(recdb);
                }
                Console.WriteLine("FIN");
            }
        }
    }
}

using System;
using System.Collections.Generic;

namespace LoadDataJsonSNCF
{
    public class Parameters
    {
        public string dataset { get; set; }
        public string timezone { get; set; }
        public int rows { get; set; }
        public string format { get; set; }
        public List<string> facet { get; set; }
    }

    public class Fields
    {
        public string gc_obo_nature_c { get; set; }
        public string gc_obo_gare_origine_r_name { get; set; }
        public DateTime date { get; set; }
        public string gc_obo_nom_recordtype_sc_c { get; set; }
        public string gc_obo_type_c { get; set; }
        public string gc_obo_gare_origine_r_code_uic_c { get; set; }
    }

    public class Record
    {
        public string datasetid { get; set; }
        public string recordid { get; set; }
        public Fields fields { get; set; }
        public DateTime record_timestamp { get; set; }
    }

    public class RecDB
    {
        public string datasetid { get; set; }
        public string recordid { get; set; }
        public string gc_obo_nature_c { get; set; }
        public string gc_obo_gare_origine_r_name { get; set; }
        public DateTime date { get; set; }
        public string gc_obo_nom_recordtype_sc_c { get; set; }
        public string gc_obo_type_c { get; set; }
        public string gc_obo_gare_origine_r_code_uic_c { get; set; }
        public DateTime record_timestamp { get; set; }
    }

    public class Facet
    {
        public int count { get; set; }
        public string path { get; set; }
        public string state { get; set; }
        public string name { get; set; }
    }

    public class FacetGroup
    {
        public List<Facet> facets { get; set; }
        public string name { get; set; }
    }

    public class RootObject
    {
        public string datasetid { get; set; }
        public string recordid { get; set; }
        public Fields fields { get; set; }
        public DateTime record_timestamp { get; set; }
    }
}

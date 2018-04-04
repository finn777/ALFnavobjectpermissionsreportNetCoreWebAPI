using System;
using System.Collections.Generic;

namespace ALFnavobjectpermissionsreportNetCoreWebAPI
{
    public partial class Data
    {
        public int Dataid { get; set; }
        public string Modulename { get; set; }
        public string Objecttype { get; set; }
        public string Description { get; set; }
        public long? Rangefrom { get; set; }
        public long? Rangeto { get; set; }
        public string Pread { get; set; }
        public string Pinsert { get; set; }
        public string Pmodify { get; set; }
        public string Pdelete { get; set; }
        public string Pexecute { get; set; }
        public string Productline { get; set; }
        public long? Moduleid { get; set; }
        public string Versionname { get; set; }
    }
}

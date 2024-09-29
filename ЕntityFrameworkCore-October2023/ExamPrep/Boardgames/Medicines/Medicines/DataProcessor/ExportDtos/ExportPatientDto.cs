﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Medicines.DataProcessor.ExportDtos
{
    public class ExportPatientDto
    {
        [XmlAttribute("Gender")]
        public string Gender { get; set; }

        [XmlElement("Name")]
        public string FullName { get; set; }

        [XmlElement("AgeGroup")]
        public string AgeGroup { get; set; }

        [XmlArray("Medicines")]
        public ExportMedicineDto[] Medicines { get; set; }
    }
}

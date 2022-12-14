using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_12_2022
{
    [System.Xml.Serialization.XmlRoot("PsychiatricHospital")]
    public class PsychiatricHospital
    {
        [System.Xml.Serialization.XmlElement("doctors")]
        public Doctors Doctors { get; set; }
        [System.Xml.Serialization.XmlElement("patients")]
        public Patients Patients { get; set; }
        [System.Xml.Serialization.XmlElement("illness")]
        public Illneses Illneses { get; set; }
    }

    public class Doctors
    {
        [System.Xml.Serialization.XmlElement("doctor")]
        public Doctor[] DoctorsArray { get; set; }
    }

    public class Doctor
    {
        [System.Xml.Serialization.XmlAttribute("id", Namespace = "")]
        public int dId { get; set; }
        [System.Xml.Serialization.XmlElement("name", Namespace = "")]
        public string dName { get; set; }
        [System.Xml.Serialization.XmlElement("cfalification", Namespace = "")]
        public string dCfalification { get; set; }
        [System.Xml.Serialization.XmlElement("countPatients", Namespace = "")]
        public int dCountOfPatints { get; set; }

        [System.Xml.Serialization.XmlElement("education", Namespace = "")]
        public Education dEducation { get; set; }
        [System.Xml.Serialization.XmlElement("information", Namespace = "")]
        public DoctorInformation dInformation { get; set; }

    }
    public class Information
    {
        [System.Xml.Serialization.XmlElement("age", Namespace = "")]
        public int aGe { get; set; }
        [System.Xml.Serialization.XmlElement("familyStatus", Namespace = "")]
        public string fAmilyStatus { get; set; }
    }
    public class DoctorInformation : Information
    {

    }
    public class PatientInformation : Information
    {
        [System.Xml.Serialization.XmlElement("enteringYear", Namespace = "")]
        public int eNteringYear { get; set; }
    }
    public class Education
    {
        [System.Xml.Serialization.XmlElement("school", Namespace = "")]
        public School sChool { get; set; }
        [System.Xml.Serialization.XmlElement("institute", Namespace = "")]
        public Institute iNstitute { get; set; }
    }
    public class Study
    {
        [System.Xml.Serialization.XmlAttribute("code", Namespace = "")]
        public int cOde { get; set; }
        [System.Xml.Serialization.XmlAttribute("country", Namespace = "")]
        public string cOuntry { get; set; }
        [System.Xml.Serialization.XmlAttribute("city", Namespace = "")]
        public string cIty { get; set; }
    }
    public class School : Study
    {

    }
    public class Institute : Study
    {

    }
    public class Patients
    {
        [System.Xml.Serialization.XmlElement("patient")]
        public Patient[] PatientArray { get; set; }
    }
    public class Patient
    {
        [System.Xml.Serialization.XmlAttribute("number", Namespace = "")]
        public int pNumber { get; set; }
        [System.Xml.Serialization.XmlElement("name", Namespace = "")]
        public string pName { get; set; }
        [System.Xml.Serialization.XmlElement("information", Namespace = "")]
        public PatientInformation patientInformation { get; set; }
        [System.Xml.Serialization.XmlElement("ill", Namespace = "")]
        public int pIll { get; set; }

    }
    public class Illneses
    {
        [System.Xml.Serialization.XmlElement("ill")]
        public Illness[] IllnessArray { get; set; }
    }
    public class Illness
    {
        [System.Xml.Serialization.XmlAttribute("id", Namespace = "")]
        public int iId { get; set; }

        [System.Xml.Serialization.XmlElement("name", Namespace = "")]
        public string iName { get; set; }

        [System.Xml.Serialization.XmlElement("power", Namespace = "")]
        public Power iPower { get; set; }

        [System.Xml.Serialization.XmlElement("symptoms", Namespace = "")]
        public Symptoms iSymptoms { get; set; }
    }
    public class Power
    {
        [System.Xml.Serialization.XmlElement("level", Namespace = "")]
        public string pLevel { get; set; }
        [System.Xml.Serialization.XmlElement("inborn", Namespace = "")]
        public string pInborn { get; set; }
    }
    public class Symptoms
    {
        [System.Xml.Serialization.XmlElement("mainSymptoms", Namespace = "")]
        public List<MainSymptoms> sMainSymptoms { get; set; }

        [System.Xml.Serialization.XmlElement("secondarySymptoms", Namespace = "")]
        public List<SecondarySymptoms> sSecondarySymptoms { get; set; }
    }
    public class MainSymptoms
    {
        [System.Xml.Serialization.XmlElement("mainSymptom", Namespace = "")]
        public string mainSymptom { get; set; }
    }
    public class SecondarySymptoms
    {
        [System.Xml.Serialization.XmlElement("secondarySymptom", Namespace = "")]
        public string secondarySymptom { get; set; }
    }
}

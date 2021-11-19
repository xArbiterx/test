using LabTools;
using System.Xml.Serialization;

namespace TestingLab
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string resultXml = @"<DATA><MESSAGE_ID>CUMC20211118154946869</MESSAGE_ID><MESSAGE_TYPE>ADT</MESSAGE_TYPE><EVENT_CODE>A08</EVENT_CODE><CUMC_NUMBER>JIO2394</CUMC_NUMBER><VISIT_NUMBER>HN-21-137812-4</VISIT_NUMBER><DATE_OF_BIRTH>20211029</DATE_OF_BIRTH><SEX>F</SEX><VISIT_TYPE>1</VISIT_TYPE><PRIMARY_LOCATION>A07</PRIMARY_LOCATION><PATIENT_FIRST_NAME>Minnie</PATIENT_FIRST_NAME><PATIENT_LAST_NAME>CHAN</PATIENT_LAST_NAME><ADMIT_DATE>20211029143059</ADMIT_DATE><ALLERGY_CODE></ALLERGY_CODE><ALLERGY_DESCRIPTION></ALLERGY_DESCRIPTION><PRIMARY_DOCTOR_CODE>EMR01</PRIMARY_DOCTOR_CODE><PRIMARY_DOCTOR_NAME>FUNG Cheuk Man Ronald</PRIMARY_DOCTOR_NAME><ROOM_BED>A706</ROOM_BED><ROOM_NO>A706</ROOM_NO><CONFIDENTIAL>True</CONFIDENTIAL><BED_FINANCIAL>1-bed small</BED_FINANCIAL><PATIENT_CHINESE_NAME>陈铭迪</PATIENT_CHINESE_NAME><LOCATION_DESC>Ward(A7)-Obstetric</LOCATION_DESC><DOCUMENT_ID>UB945270(0)</DOCUMENT_ID><DOCUMENT_TYPE>PI</DOCUMENT_TYPE><DEATH_DATETIME></DEATH_DATETIME><EXACT_DOB>EDMY</EXACT_DOB></DATA>";
            XmlHelper<ADTChangeModel> xmlHelper = new XmlHelper<ADTChangeModel>(new StringReader(resultXml));
            var patientModel = xmlHelper.ToObject();
            CmdHelper cmdHelper = new CmdHelper();
            //while (true)
            //{
            //   var s = Console.ReadLine();
            //    if (!string.IsNullOrEmpty(s))
            //    {
            //        var ss = cmdHelper.Excute(s);
            //    }
            //}
        }
    }

    [XmlRoot(ElementName = "DATA", DataType = "string", IsNullable = false)]
    public class ADTChangeModel
    {
        /// <summary>
        /// Unique code
        /// "CUMC"+YYYYMMDDhhmmss+NNN
        /// NNN is a sequence number
        /// </summary>
        [XmlElement(ElementName = "MESSAGE_ID")]
        public string MessageId { get; set; }
        [XmlElement(ElementName = "MESSAGE_TYPE")]
        public string MessageType { get; set; }
        [XmlIgnore]
        public EventCode EventCode1 { get; set; }
        /// <summary>
        /// A01: Admit
        /// A02: Transfer
        /// A03: Discharge
        /// A08: patient update
        /// A11: Cancel Check-in/ Revert Admission
        /// </summary>
        [XmlElement(ElementName = "EVENT_CODE")]
        public string EventCodeString
        {
            get { return EventCode1.GetString(); }
            set
            {
                if (EventCode.Admit.GetString() == value)
                {
                    EventCode1 = EventCode.Admit;
                }
                else if(EventCode.Transfer.GetString() == value)
                {
                    EventCode1 = EventCode.Transfer;
                }
                else if(EventCode.PatientUpdate.GetString() == value)
                {
                    EventCode1 = EventCode.PatientUpdate;
                }
            }
        }
        [XmlElement(ElementName = "CUMC_NUMBER")]
        public string CUMCNumber { get; set; }
        /// <summary>
        /// Episode for patient 
        /// </summary>
        [XmlElement(ElementName = "VISIT_NUMBER")]
        public string VisitNumber { get; set; }
        [XmlIgnore]
        public DateTime DateOfBirth { get; set; }
        /// <summary>
        /// YYYYMMDD
        /// </summary>
        [XmlElement(ElementName = "DATE_OF_BIRTH")]
        public string DateOfBirthString
        {
            get
            {
                return DateOfBirth.ToString();
            }
            set
            {
                DateOfBirth = DateTime.ParseExact(value,
                    "yyyyMMdd",
                    System.Globalization.CultureInfo.CurrentCulture);
            }
        }
        /// <summary>
        /// M = male
        /// F = female
        /// U = unknown sex
        /// </summary>
        [XmlElement(ElementName = "SEX")]
        public string Sex { get; set; }
        /// <summary>
        /// 0: outpatient
        /// 1: inpatient
        /// </summary>
        [XmlElement(ElementName = "VISIT_TYPE")]
        public string VisitType { get; set; }
        /// <summary>
        /// Location of the patient at the moment, or destination location in the transfer event.
        /// It is a HIS internal code to identify a location
        /// </summary>
        [XmlElement(ElementName = "PRIMARY_LOCATION")]
        public string PrimaryLocation { get; set; }
        [XmlElement(ElementName = "PATIENT_FIRST_NAME")]
        public string PatientFirstName { get; set; }
        [XmlElement(ElementName = "PATIENT_LAST_NAME")]
        public string PatientLastName { get; set; }
        /// <summary>
        /// YYYYMMDDhhmmss
        /// </summary>
        [XmlElement(ElementName = "ADMIT_DATE")]
        public string AdmitDate { get; set; }
        /// <summary>
        /// Include drug and food allergy. 
        /// VTM or allergen group IDs in HIS which indicates drug allergens.Prepared for future allergy checking function
        /// </summary>
        [XmlElement(ElementName = "ALLERGY_CODE")]
        public string AllergyCode { get; set; }
        /// <summary>
        /// Including drug and food allergy.
        /// If "no known drug allergy" is ticked in HIS, will pass "NKDA"
        /// Free-text entry is included in this field
        /// </summary>
        [XmlElement(ElementName = "ALLERGY_DESCRIPTION")]
        public string AllergyDescription { get; set; }
        [XmlElement(ElementName = "PRIMARY_DOCTOR_CODE")]
        public string PrimaryDoctorCode { get; set; }
        [XmlElement(ElementName = "PRIMARY_DOCTOR_NAME")]
        public string PrimaryDoctorName { get; set; }
        [XmlElement(ElementName = "ROOM_BED")]
        public string RoomBed { get; set; }
        [XmlElement(ElementName = "ROOM_NO")]
        public string RoomNo { get; set; }
        /// <summary>
        /// True = is confidential
        /// False = is not confidential
        /// </summary>
        [XmlElement(ElementName = "CONFIDENTIAL")]
        public string Confidential { get; set; }
        /// <summary>
        /// Weighting Condition parameter:
        /// VIP 1-Bed
        /// 1-Bed
        /// 2-Bed
        /// 4-Bed
        /// Isolation
        /// NNU(Cot)
        /// Day Ward
        /// </summary>
        /// <remarks>The parameter maybe more than the above list in actual production environment</remarks>
        [XmlElement(ElementName = "BED_FINANCIAL")]
        public string BedFinancial { get; set; }
        [XmlElement(ElementName = "PATIENT_CHINESE_NAME")]
        public string PatientChineseName { get; set; }
        [XmlElement(ElementName = "LOCATION_DESC")]
        public string LocationDesc { get; set; }
        [XmlElement(ElementName = "DOCUMENT_ID")]
        public string DocumentId { get; set; }
        [XmlElement(ElementName = "DOCUMENT_TYPE")]
        public string DocumentType { get; set; }
        /// <summary>
        /// dd-MMM-yyyy hh:mm
        /// </summary>
        [XmlElement(ElementName = "DEATH_DATETIME")]
        public string DeathDatetime { get; set; }
        /// <summary>
        /// EDMY/EMY/EY
        /// </summary>
        [XmlElement(ElementName = "EXACT_DOB")]
        public string ExactDob { get; set; }
    }

    public enum EventCode
    {
        /// <summary>
        /// 入院
        /// </summary>
        Admit,
        /// <summary>
        /// 转院
        /// </summary>
        Transfer,
        /// <summary>
        /// 出院
        /// </summary>
        Discharge,
        /// <summary>
        /// 更新病人
        /// </summary>
        PatientUpdate,
        /// <summary>
        /// 取消入院
        /// </summary>
        RevertAdmission
    }

    public static class EventCodeExtensions
    {
        public static string GetString(this EventCode adts)
        {
            switch (adts)
            {
                case EventCode.Admit:
                    return "A01";
                case EventCode.Transfer:
                    return "A02";
                case EventCode.Discharge:
                    return "A03";
                case EventCode.PatientUpdate:
                    return "A08";
                case EventCode.RevertAdmission:
                    return "A11";
                default:
                    return null;
            }
        }
    }
}

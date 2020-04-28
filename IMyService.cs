using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace TestService
{
    [ServiceContract]
    interface IMyService
    {
        [OperationContract]
        string GetData();
       
        [OperationContract]
        string GetMessage(string name);
       
        [OperationContract]
        string GetResult(int Sid, string SName, int M1, int M2, int M3);

        [OperationContract]
        string GetResult1(Student S);
        [OperationContract]
        int GetMax(int[] ar);

        [OperationContract]
        int[] GetSorted(int[] ar);
        [OperationContract]
        List<Country> GetAllCountries();

        
    }
    [DataContract]
    class Student
    {
        [DataMember]
        public int Sid { get; set; }
        [DataMember]
        public string StudentName { get; set; }
        [DataMember]
        public int M1 { get; set; }
        [DataMember]
        public int M2 { get; set; }
        [DataMember]
        public int M3 { get; set; }
    }
    [DataContract]
    class Country
    {
        [DataMember]
        public string CountryRegionCode {get; set;}
        [DataMember]
        public string Name { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestService
{
    class MyService : IMyService
    {
        public string GetData()
        {
            return "Krishna Kumar chaudhary";
        }

        public string GetMessage(string name)
        {
            return "Hello Mr/Mrs" + name;
        }

        public string GetResult(int Sid, string SName, int M1, int M2, int M3)
        {
            double Avg = (M1 + M2 + M3) / 3.0;
            if (Avg < 35)
                return "Fail";
            else
                return "Pass";
        }

        public string GetResult1(Student S)
        {
            double Avg = (S.M1 + S.M2 + S.M3) / 3.0;
            if (Avg < 35)
                return "Fail";
            else
                return "Pass";
        }

        public int GetMax(int[] ar)
        {
            int max = ar[0];
            for (int i =0;i<ar.Length;i++)
            {
                if (ar[i] > max)
                    max = ar[i];
            }
            return max;
        }

        public int[] GetSorted(int[] ar)
        {
            Array.Sort(ar);
            return ar;

        }

       public List<Country> GetAllCountries()
        {
            List<Country> LC = new List<Country>();
            string ConStr = "data source=krishna-pc\\sqlexpress; initial catalog=AdventureWorks2014; integrated security=True";
            SqlConnection con = new SqlConnection(ConStr);
            SqlCommand cmd = new SqlCommand("SELECT [CountryRegionCode],[Name] FROM [Person].[CountryRegion]",con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                Country c = new Country();
                c.CountryRegionCode = dr[0].ToString();
                c.Name = dr[1].ToString();
                LC.Add(c);
            }
            dr.Close();
            con.Close();

            return LC;
            
        }
        
    }
}

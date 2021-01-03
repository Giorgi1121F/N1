using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Net.Http;
using System.Xml;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;




namespace N8
{
    class Program
    {
        static void Main(string[] args)
        {   // რსს გამოყენება xml  ის მისაღებად
            string url = " http://www.nbg.ge/rss.php";
            XmlReader reader = XmlReader.Create(url);
            SyndicationFeed feed = SyndicationFeed.Load(reader);
            reader.Close();
            //xml ით მანიპულირება
            foreach (SyndicationItem item in feed.Items)
            {
               //ვალუტის  არჩევა
                String summary = item.Summary.Text;

                Console.WriteLine(" Choose your currency N1 ");
               
                string V1 =  Console.ReadLine();
                Console.WriteLine(" Choose your currency N2 ");
                string V2 = Console.ReadLine();




                string str1 = summary;
                string[] strArrayOne = new string[] { "" };
                
                
                string[] separator1 = new string[]{"<td>"};
                strArrayOne = str1.Split(separator1,StringSplitOptions.None);

                // ფილრაცია 
                for (int i = 0; i < strArrayOne.Length; i++)
                {
                    strArrayOne[i] = strArrayOne[i].Replace("</td>", "");  
                    strArrayOne[i] = strArrayOne[i].Replace("\n", "");
                    strArrayOne[i] = strArrayOne[i].Replace("\t", "");
                    strArrayOne[i] = strArrayOne[i].Replace(" ", string.Empty);
                    //Console.WriteLine(strArrayOne[i] +"---" +i) testi;

                      }
                //შედარება და პასუხის გამოტანა
                  for  (int i = 0; i < strArrayOne.Length; i++)
                   {
                   
                    if (strArrayOne[i] == V1)
                        
                    {
                        Console.WriteLine(strArrayOne[i] + " = " +strArrayOne[i+2] + " GEL");
                    }
                    if (strArrayOne[i] == V2)

                    {
                        Console.WriteLine(strArrayOne[i] + " = " + strArrayOne[i + 2] + " GEL");
                    }

                }
               

                
               
                        
                

                




               
                Console.Read();
            }
        }

       
    }
}

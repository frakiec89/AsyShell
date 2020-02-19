using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyShell.BL
{
    public class SellerMamager
    {
        ASYSell_AhtymovEntities entities = new ASYSell_AhtymovEntities();

        public List<Seller> Sellers
        {
            get
            {
                try
                {
                    return entities.Seller.ToList();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error DB " + ex.Message);
                }
            }
        }

        /// <summary>
        /// Добавляет нового  продовца  
        /// </summary>
        /// <param name="name">Имя</param>
        /// <returns></returns>
        public  string SetSeller ( string  name)
        {
            
                if ( String.IsNullOrWhiteSpace(name))
                {
                    throw new Exception("Имя не  может  быть  пустым ");
                }

            try
            {
                entities.Seller.Add(new Seller { Name = name });
                entities.SaveChanges();
                return "сохранение  прошло  успешно";
            }
            catch (Exception ex)
            {
                throw new Exception("Error Db " + ex.Message);
            }
        }


        public List<string> GetSelerCB ()
        {
            List<string> seller = new List<string>();
            seller.Add("Все");
            try
            {
                var vs = entities.Seller.Select(x => x.Name);
                List<string> vs1 = vs.ToList();
                vs1.Sort();
                seller.AddRange(vs1);
            }
            catch
            {
                throw new Exception("Error db");
            }
            return seller;
        }
 

    }
}

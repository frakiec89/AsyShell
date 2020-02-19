using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyShell.BL
{
    
    public  class CustomerManager
    {
        private readonly ASYSell_AhtymovEntities entities = new ASYSell_AhtymovEntities();

        /// <summary>
        /// получает  список  продавцов 
        /// </summary>
        public List<Customer> customers 
        {
            get
            {
                try
                {
                    

                    return entities.Customer.ToList();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error bd " + ex.Message);
                }
            }
        }


        /// <summary>
        /// Добавляет  нового покупателя в БД
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public  string  SetCustomet ( string  name)
        {
            if ( String.IsNullOrWhiteSpace (name))
            {
                throw new Exception("Имя не  может  быть  пустым ");
            }

            try
            {
                entities.Customer.Add(new Customer { Name = name });
                entities.SaveChanges(); // сохранение результата  в  бд 

                return "сохранение  прошло  успешно";

            }
            catch (Exception ex)
            {
                throw new Exception("Error Db " + ex.Message);
            }
        }
    }
}

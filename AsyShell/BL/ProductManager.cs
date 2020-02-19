using System;

namespace AsyShell.BL
{
    public  class ProductManager
    {
        ASYSell_AhtymovEntities entities = new ASYSell_AhtymovEntities();
        
        public string SetProduct(string name, double price)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("название продукта  не  может быть  пустым", nameof(name));
            }
            if (price <= 0)
            {
                throw new ArgumentException("цена не может  быть  меньше нуля", nameof(price));
            }

            try
            {
                entities.Product.Add(new Product { Name = name, Price = price });
                return "сохранение  прошло  успешно";
            }
            catch (Exception ex)
            {
                throw new Exception("Error Db " + ex.Message);
            }
        }
    }

}
    


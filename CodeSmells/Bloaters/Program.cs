/*
 * Bloaters 
 * 
 * 1. Long Methods: One job at a time; Birim zamanda sadece bir iş yapmalı.
 * 
 *    * Extract Method gibi araçlarlar ile yeni metotlar inşa edin.
 *    * Yerel değişken yerine; metot parametresi kullanın.
 *    * Metodu, doğru nesnenin çalıştırdığına emin olun.
 *    
 * 2. Big Class (Fat Class) -> SUMO 
 *    * Sorumlukları başka sınıflar ile izole edin.
 *    * Inheritance'ı doğru bir biçimde kullanın.
 *    * Özellikle davranışsal operasyonları Interface'lere ayırın.
 *    * Eğer UI ile ilişki kuran bir Fat Class durumu varsa; bu durumda, UI davranışlarını; Domain Entity'lerine yansıtın.
 *    
 * 3. Primitive Obsession:
 *     * Value Object kavramıyla hareket edin (DDD)
 *     
 * 4. Uzun parametre listesi:    
 *     * Parametreleri, encapsulation yöntemi ile nesnelere dönüştürün  (DTO)
 * 
 * 5. Data clumps: Belirli kod bloğunun (ya da değişkenin) farklı modüller tarafından kullanılması:
 *     * Tekrar kod bloklarını; en kötü ihtimalle Helper sınıflarına ayırın.
 *     
 */
using Bloaters;

//Customer customer = new Customer();
//customer.ChangeAddress("Odunpazarı, Eskişehir");

Class1 class1 = new Class1();
class1.Calculate(100, 4, 5);

Customer customer = new Customer
{
    CustomerStatus = new AdvancedVIPCustomer(),
    TimeOfHavingAccountInYears = 4
};

DiscountManager discountManager = new DiscountManager { Customer = customer };
var discountedPrice = discountManager.ApplyDiscount(100);
Console.WriteLine(discountedPrice);


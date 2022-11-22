// See https://aka.ms/new-console-template for more information
using functions;

Console.WriteLine("Hello, World!");



//Bir fonksiyon, birim zamanda yalnızca 1 iş yapmalı.
string[] words = { "Ayna", "Golgi", "Fransa", "Ahududu", "Aygır", "Zebra", "Klavye", "Artık" };
var list = words.ToList();
showWordsStartsWith(words, "A");


CustomerService customerService = new CustomerService();
int spesificCustomerId = 3;
var customer = customerService.GetCustomerByIdWithLinq(id: 3);
var customerIsExist =  customerService.ProductIsExist(spesificCustomerId);


bool caseSensivityState = false;
var customers = customerService.SearchCustomerByName(name: "Doe", caseSensivityState);

//var sample = changeTitle("yeni başlık", false);


static void showWordsStartsWith(string[] words, string letter)
{
    foreach (var word in words)
    {
        writeWordWithCritrtia(letter, word);

    }

}

static void writeWordWithCritrtia(string letter, string word)
{
    if (word.StartsWith(letter))
    {
        Console.WriteLine(word);
    }
}

bool isEven(int number)
{
    return number % 2 == 0;
}



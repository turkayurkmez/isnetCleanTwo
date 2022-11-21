// See https://aka.ms/new-console-template for more information
using System.Data;

Console.WriteLine("Hello, World!");

// anlamlı isimler bulmak.
int x; // kullanıcının kaydından bu yana geçen süre....
int daysSinceUserCreation = 15;
int musteriKaydindanBuYanaGecenGunSayisi = 10; //Evrensel dil elbette ingilizce olmalı....

var hp = 1;
//1. Horse power
//2. Health Point
//3. HP laptop sayısı
//4. Hit Point...

var healthPoint = 100;
DataTable table = new DataTable();

List<string> emailAdresses = new List<string>();
List<string> emailList = new List<string>();

int intNumber = 0;

char charLetter = 'a';

var o = 0;
var l = 1;


if (o == l)
{

}

List<int[]> cells = new List<int[]>();

List<int[]> getFlaggedCellsOnGameBoard()
{
    List<int[]> flaggedCells = new List<int[]>();
    foreach (var cell in cells)
    {
        if (cell[0] == Flags.Flagged) //4 nedir? 
        {
            flaggedCells.Add(cell);
        }
    }
    return flaggedCells;
}



enum FlagState
{
    Empty = 0,
    Flagged = 4
};

public class Flags
{
    public const int Empty = 0;
    public const int Flagged = 4;
}

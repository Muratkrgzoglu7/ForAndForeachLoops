using System;

namespace Loopss
{
	class Program
	{
		static void Main(string[] args)
		{
			int number = 36;
			
			string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
			string kurs2 = "Proglamlama Başlangıç Temel Kursu";
			string kurs3 = "Java";
			string kurs4 = "C++";
			string kurs5 = "Python";
			Console.WriteLine(kurs1);
			Console.WriteLine(kurs2);
			Console.WriteLine(kurs3);
			Console.WriteLine(kurs4);
			Console.WriteLine(kurs5);


			string[] kurslar = new string[] {"Yazılım Geliştirici Yetiştirme Kampı","Proglamlama Başlangıç Temel Kursu","Java","C++","Python","JavaScript",
			};
			for (int i = 0; i < kurslar.Length; i++)
			{
				Console.WriteLine(kurslar[i]);				
			}
			Console.WriteLine("for bitti");
			foreach (string kurs in kurslar)
			{
				Console.WriteLine(kurs);
			}
			Console.WriteLine("sayfa sono- footer");
		}
	}
}

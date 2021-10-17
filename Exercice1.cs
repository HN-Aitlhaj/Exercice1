using System;

namespace Exercice1_NombrePremier
{
    class Program
    {
        static void Main(string[] args)
        {
		int i = 2;
		bool pre = true;

		while(true)
		{
			Console.Write("\nVeuillez entrer un nombre entier positif:\t");
                	string answer = Console.ReadLine();
			if (answer == "")
			{
				break;
			}
			else
			{
				int num = Convert.ToInt32(answer);
				if (num == 0 || num == 1)
				{
					Console.WriteLine("Ce nombre n'est pas un nombre premier");
				}
				else
				{
					while (i <= num / 2)
					{
						if (num % i == 0)
						{
							Console.WriteLine("Ce nombre n'est pas un nombre premier");
							pre = false;
							break;
						}
						i++;
					}
					if (pre == true)
					{
						Console.WriteLine("Ce nombre est un nombre premier");
					}
				}
			}
		}
  	}
    }
}


using System;


public class Premier
{
    public void Main()
    {
		int i=2;
		bool pre = true;
        while(true){
		Console.WriteLine("Veuillez entrer un nombre entier positif:\t");
        string number = Console.ReadLine();
		int num = Convert.ToInt32(number);
		if(num == 0 || num == 1){
			Console.WriteLine("Ce nombre n'est pas un nombre premier");			
		}else{
			while(i<=num/2){
				if(num%i == 0){
					Console.WriteLine("Ce nombre n'est pas un nombre premier");
					pre = false;
					break;
				}
				i++;
			}
			if(pre == true){
					Console.WriteLine("Ce nombre est un nombre premier");
				}
		}
    }
}
}

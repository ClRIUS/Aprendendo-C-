int firstNumber = 12;
int secondNumber = 7;
Console.WriteLine(firstNumber + secondNumber);

string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + widgetsSold + " widgets.");
//Caso de concatenação usando as variáveis acima
Console.WriteLine(firstName + " sold " + widgetsSold + 7 + " widgets.");
//Evitando a concatenação usando parênteses
Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.");

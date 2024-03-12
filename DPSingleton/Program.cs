//Call the GetInstance static method to get the Singleton Instance
using DPSingleton;

Singleton fromTeachaer = Singleton.GetInstance();
fromTeachaer.PrintDetails("From Teacher");
//Call the GetInstance static method to get the Singleton Instance
Singleton fromStudent = Singleton.GetInstance();
fromStudent.PrintDetails("From Student");

//Instantiating singleton from a Derived class. 
//This violates Singleton Pattern Pattern.

//Singleton.DerivedSingleton derivedObj = new Singleton.DerivedSingleton();
//derivedObj.PrintDetails("From Derived");

Console.ReadLine();

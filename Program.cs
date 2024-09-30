
using AbstraindoUmCelularComPOO.Models;

Nokia nokia = new Nokia();
Iphone iphone = new Iphone();  
nokia.Numero = "123456";
iphone.Numero = "7891011"; 

nokia.Ligar();
iphone.Ligar();

nokia.InstalarAplicativo("WhatsApp");
iphone.InstalarAplicativo("Facebook");

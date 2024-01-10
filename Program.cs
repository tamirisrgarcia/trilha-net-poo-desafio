using DesafioPOO.Models;

Nokia nokia = new Nokia("9999-8888", "1100", "1234567890", 32);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("whatsapp");


Iphone iphone = new Iphone("1111-5555", "12", "0987654321", 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("telegram");

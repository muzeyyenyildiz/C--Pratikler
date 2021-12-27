// See https://aka.ms/new-console-template for more information

int time = DateTime.Now.Hour;

if(time >= 6 && time <11){
     Console.WriteLine("Günaydın!");
}
else if (time >= 12 && time <= 18 ){
    Console.WriteLine("İyi Günler!");
}
else{
    Console.WriteLine("İyi Geceler!");
}

string sonuç = time <=18 ? "İyi Günler!" : "İyi Geceler!"; 
sonuç = time <11 && time >6 ? "Günaydın!": time<=18? "İyi Günler!": "İyi geceler";

Console.WriteLine(sonuç);
using OOP_18;

Personel personel = new Personel();
personel.Islem();

Musteri musteri = new Musteri();
musteri.Islem();

// personel. dediğimizde test metodu gelmiyor. çünkü test metodu IArayuz içinde gövdeli bir metot. 

IArayuz obj1 = new Personel();
IArayuz obj2 = new Musteri();

// bu şekilde bu interface i implement eden sınıfları aynı tipte ortak yerde tutmuş oluruz.

obj1.Test(); // test metoduna bu şekilde ulaşabiliriz.



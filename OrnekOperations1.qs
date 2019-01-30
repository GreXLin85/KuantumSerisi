//Not : Q#'da da // ifadesi yorum yazmak için kullanılır

namespace Quantum.QSharpApplication1
{
    //Kütüphaneleri dahil edelim
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;
    //Ana ünitimizi oluşturalım
    operation HelloQ () : Unit {
        //Ve ekrana "Merhaba QUANTUM!" yazdıralım :)
        Message("Merhaba QUANTUM!");
    }
}

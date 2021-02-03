using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>                              // string veya int gibi değişkenler diyerek dizimizi sınırlandırmamak için T'ye atıyoruz. her türlü veri tipi saklayabiliriz
    {
        T [] items;                              // dizimizi oluşturuyoruz. 0 elemanlı. eleman ekleyebilmek için new'lenme zorunluluğu var.

        //CONSTRUCTOR                            // CONSTRUCTOR bir class new'lediğinde çalışan bloğa denir.

        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items;               // alt satırda newleme işleminden sonra dizimiz kaybolmasın diye tempArraya(geçici diziye atıyoruz.
            items = new T[items.Length+1];       // dizi newlenince önceki heap adresini kaybediyor. yukarda başka bir adrese atayarak kaybolmasını engelliyoruz.

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];          // tempArraya atadığımız diziyi geri atamak için yaptık.
                                                  // her yeni eleman eklendiğinde sıfırlanan diziye temarray gelerek eski dizinin elemanlarını da ekler.
            }
            items[items.Length - 1] = item;       //Length - 1=en son eleman.
                                                  //Aslında eklenmek istenen elemanı ekliyoruz. item burda yukardan gelen item. 
        }
    }
}

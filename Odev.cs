using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Odev : MonoBehaviour
{
    void bolenleriBul(int a, int b)
    {
        string sayilar = "";
        string ikiyeBolunenler = "";
        string uceBolunenler = "";
        string dordeBolunenler = "";
        string beseBolunenler = "";

        for (int i = a; i < b + 1; i++)
        {
            sayilar += " - " + i;
            if (i % 2 == 0)
            {
                ikiyeBolunenler += " - " + i;
            }
            if (i % 3 == 0)
            {
                uceBolunenler += " - " + i;
            }
            if (i % 4 == 0)
            {
                dordeBolunenler += " - " + i;
            }
            if (i % 5 == 0)
            {
                beseBolunenler += " - " + i;
            }
        }

        print("Tüm Sayýlar: " + sayilar);

        
        //Ýkiye Bölünenler



        print("Ýkiye Bölünenler: " + ikiyeBolunenler);

        
        //Üçe Bölünenler




        print("Üçe Bölünenler: " + uceBolunenler);

        
        //Dörde Bölünenler





        print("Dörde Bölünenler: " + dordeBolunenler);

        
        //Beþe Bölünenler




        print("Beþe Bölünenler: " + beseBolunenler);

        

    }



    // Start is called before the first frame update
    void Start()
    {
        bolenleriBul(6, 40);
    }

    // Update is called once per frame
    void Update()
    {

    }



}

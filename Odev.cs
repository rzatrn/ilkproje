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

        print("T�m Say�lar: " + sayilar);

        
        //�kiye B�l�nenler



        print("�kiye B�l�nenler: " + ikiyeBolunenler);

        
        //��e B�l�nenler




        print("��e B�l�nenler: " + uceBolunenler);

        
        //D�rde B�l�nenler





        print("D�rde B�l�nenler: " + dordeBolunenler);

        
        //Be�e B�l�nenler




        print("Be�e B�l�nenler: " + beseBolunenler);

        

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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    public int a;
    public int b;


    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()

    {
       BolenBulma(a, b);
            }

    
    void BolenBulma(int a, int b)
    {
        string bolum1 = "";
        string bolum2 = "";
        string bolum3 = "";
        string bolum4 = "";
        string bolum5 = "";
         
        if (a > b)
        {
            for (int i = b; i <=a; i++)
            {
                bolum1 += i + "-";
            
                if (i % 2 == 0)
                {
                    bolum2 += i + "-";
                }
                if (i % 3 == 0)
                {
                    bolum3 += i + "-";
                }
                if (i % 4 == 0)
                {
                    bolum4 += i + "-";
                }
                if (i % 5 == 0)
                {
                    bolum5 += i + "-";
                }


            }


        }
        if (b>a)

        {
            for (int i = a; i <= b; i++)
            {
                bolum1 += i + "-";
                if (i % 2 == 0)
                {
                    bolum2 += i + "-";
                }
                if (i % 3 == 0)
                {
                    bolum3 += i + "-";
                }
                if (i % 4 == 0)
                {
                    bolum4 += i + "-";
                }
                if (i % 5 == 0)
                {
                    bolum5 += i+"-" ;
                }

            }
     
        }
   
print("tüm elemanlar :" +bolum1);
    print("2ye bolunenler :" +bolum2);
    print("3e bolunenler :" +bolum3);
    print("4e bolunenler :" +bolum4);
    print("5e bolunenler :" +bolum5);

    }
    
        
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio_5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        bool pares = false;
        //esta es la variable booleana
        if (pares == true)
        //con el condicional se reconoce el valor de la variable
        {
            int[] cifras = new int[21];
            int resultado = 0;
            for (int i = 0; i <= 20; i++)
            {
                cifras[i] = i;
            }
            resultado = cifras[0] + cifras[2] + cifras[4] + cifras[6] + cifras[8] + cifras[10] + cifras[12] + cifras[14] + cifras[16] + cifras[18] + cifras[20];
            Debug.Log(resultado);
            //asi es como se hace la suma de los pares
        }
        else
        {
            int[] cifras = new int[21];
            int resultado = 0;
            for (int i = 0; i <= 20; i++)
            {
                cifras[i] = i;
            }
            resultado = cifras[1] + cifras[3] + cifras[5] + cifras[7] + cifras[9] + cifras[11] + cifras[13] + cifras[15] + cifras[17] + cifras[19];
            Debug.Log(resultado);
            //asi es como se hace la suma de los impares
        }
    }

   
}

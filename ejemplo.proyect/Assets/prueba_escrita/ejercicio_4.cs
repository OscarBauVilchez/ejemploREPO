using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio_4 : MonoBehaviour
{
    void Start()
    {
        bool sumar = false;
        //esta es la variable booleana
        if(sumar==true)
        //con el condicional se reconoce el valor de la variable
        {
            int[] cifras = new int[11] ;
            int resultado = 0;
            for(int i =0;i <= 10;i++)
            {
                cifras[i] = i;
                Debug.Log(cifras[i]);
            }
            resultado = cifras[0] + cifras[1] + cifras[2] + cifras[3] + cifras[4] + cifras[5] + cifras[6] + cifras[7] + cifras[8] + cifras[9] + cifras[10];
            Debug.Log(resultado);
            //asi es como se hace la operacion
        }
        else
        {
            Debug.Log("No hay nada que calcular");
            //este es el mensaje que saldra si la variable tiene de valor false
        }
          
    }

}

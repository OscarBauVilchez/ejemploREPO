using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio_6 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] numerosEnteros = new int[] { 43, 7, 6, 12, 62, 4, 24, 2, 79, 20 };
        //este es el array que utilizaremos
        int opcion = 2;
        //esta es la variable que afecta al flujo del codigo
        if(opcion==1)
        //con el condicional se identifica el valor de la variable
        {
            int valorMinimo = 1000;
            //esta es la variable en la que se pondra el valor minimo
            for (int i = 0;i < numerosEnteros.Length;i++)
            //con el bucle pasamos por cada uno de los componetes del array
            {
                if(numerosEnteros[i]<valorMinimo)
                //y con el condicional comparamos el valor de los componentes del array con el valor que tenga registrado en ese momento la variablr valorMinimo
                {
                    valorMinimo = numerosEnteros[i];
                }
            }
            Debug.Log(valorMinimo);
        }
        if (opcion == 2)
        //con el condicional se identifica el valor de la variable
        {
            int valorMaximo = 0;
            //esta es la variable en la que se pondra el valor maximo
            for (int i = 0; i < numerosEnteros.Length; i++)
            //con el bucle pasamos por cada uno de los componetes del array
            {
                if (numerosEnteros[i] > valorMaximo)
                //y con el condicional comparamos el valor de los componentes del array con el valor que tenga registrado en ese momento la variablr valorMaximo
                {
                    valorMaximo = numerosEnteros[i];
                }
            }
            Debug.Log(valorMaximo);
        }
    }

   
}

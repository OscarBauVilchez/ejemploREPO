using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio_7 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        arrayMultiplicacion(6);
    }
    void arrayMultiplicacion(int arraylength)
    {
        int[]array = new int[arraylength];
        //esto determina la longitud del array
        string inicio = "a = \"";
        string final = "\"] => ";
        string mitad = "[";
        //estas tres lineas de codigo estan para mostrar los elementos del array
        int resultado = 1;
        //en esta variable se pondra el resultado de la multiplicacion de todos los valores del array
        for(int i = 0; i < arraylength; i++)
        //con el bucle pasamps por todos los elementos del array
        {
            array[i] = Random.Range(1,10);
            //este comando le asigna a cada elemento del array un valor aleatorio
            resultado=resultado*array[i];
            mitad = mitad + array[i] + ",";
        }
        string completo = inicio + mitad + final + resultado;
        Debug.Log(completo);
    }
}

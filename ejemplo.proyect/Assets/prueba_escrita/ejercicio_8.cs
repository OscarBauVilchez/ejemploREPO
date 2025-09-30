using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio_8 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        naveEnemiga nave=new naveEnemiga("Cassinni", "Frigata", 1);
        nave.mostrar();
        nave.impacto();   
    }
    public class naveEnemiga
    {
        public string nombreN;
        public string tagN;
        public bool tieneMunicion;
        public int vidaN;

        public naveEnemiga(string nombre, string tag, int nivelDeVida)
        {
            tieneMunicion = true;
             nombreN = nombre;
            tagN = tag;
            vidaN = nivelDeVida;
        }
        public void mostrar()
        {
            string nombreNave = "Nombre: " + nombreN + " ";
            string tagNave = "Tag: " + tagN + " ";
            string vidaNave = "Vida: " + vidaN + " ";
            string municion = "";
            if (tieneMunicion == true)
            {
                municion = "Armamento: Cargado.";
            }
            if (tieneMunicion == false)
            {
                municion = "Armamento: Descargado.";
            }
            string ordenador = nombreNave + tagNave + vidaNave + municion;
            Debug.Log(ordenador);

        }
        public void impacto()
        {
            vidaN--;
            string mensajeInicio = "La nave de nombre ";
            string mensajeFinal = " ha sido destruida";
            if (vidaN <= 0) ;
            {
                string mensajeCompleto = mensajeInicio + nombreN + mensajeFinal;
                Debug.Log(mensajeCompleto);
            }
        }
    }
    
}

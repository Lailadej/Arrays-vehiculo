using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehiculosManager : MonoBehaviour
{
    public Vehiculo vehiculoScript;

    // Start is called before the first frame update
    void Start()
    {
        int cantRuedasVehiculos = vehiculoScript.cantRuedas;

        Debug.Log("Cant ruedas: " + cantRuedasVehiculos);
        if (cantRuedasVehiculos < 6 )
        {
            vehiculoScript.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

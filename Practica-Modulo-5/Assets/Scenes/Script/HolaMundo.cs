using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class HolaMundo : MonoBehaviour
{
    int x;

    // Start is called before the first frame update
    void Start()
    {
        x = 0;
        Debug.Log("Algo Paso");
        Debug.LogWarning("Algo Salio Mal");
        Debug.LogError("Algo Salio Muy Mal");
    }

    // Update is called once per frame
    void Update()
    {
        //x = x + 1;
        //Debug.Log(x);
        Debug.Log("saludos desde la Update");    }
    private void OnDisable()
    {
        Debug.LogWarning("Objeto inhabilitado");
    }
    private void OnEnable()
    {
        Debug.LogWarning("Objeto habilitado");
    }
    private void LateUpdate()
    {
        Debug.Log("Hola desde LateUpdate");
    }
    private void FixedUpdate()
    {
        Debug.LogWarning("Hola Desde FixedUPdate");

    }
}



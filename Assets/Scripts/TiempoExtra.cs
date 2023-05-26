using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiempoExtra : MonoBehaviour
{
    [SerializeField] private float cantidadTiempo;
    [SerializeField] private Temporizador2 contadorTiempo;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            contadorTiempo.SumarTiempo(cantidadTiempo);
            Destroy(gameObject);
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comida : MonoBehaviour
{
    [SerializeField] private float cantidadPuntos;
    [SerializeField] private Puntuación puntaje;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            puntaje.SumarPuntos(cantidadPuntos);
            Destroy(gameObject);
        }
    }
}

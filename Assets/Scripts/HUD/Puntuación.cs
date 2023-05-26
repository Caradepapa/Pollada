using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Puntuación : MonoBehaviour
{
    private int puntos;
    private TextMeshProUGUI textMesh;

    private void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
        puntos = 0;
    }
    private void Update()
    {
        ActualizarPuntos();
    }

    public void SumarPuntos(float puntosEntrada)
    {
        puntos += (int)puntosEntrada;
    }

    private void ActualizarPuntos()
    {
        textMesh.text = puntos.ToString("000");
    }
}

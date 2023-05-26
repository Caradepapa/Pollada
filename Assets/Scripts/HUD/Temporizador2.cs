using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Temporizador2 : MonoBehaviour
{
    public float timer = 0;
    public TextMeshProUGUI textotempo;

    private void Update()
    {
        timer -= Time.deltaTime;
        textotempo.text = timer.ToString("f0");
    }

    public void SumarTiempo(float tiempo)
    {
        timer += tiempo;
    }
}
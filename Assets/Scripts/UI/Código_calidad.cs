using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Código_calidad : MonoBehaviour
{
    public TMP_Dropdown dropdown;
    public int calidad;
    void Start()
    {
        calidad = PlayerPrefs.GetInt("numeroDeCalidad", 2);
        dropdown.value = calidad;
        AjustarCalidad();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void AjustarCalidad()
    {
        QualitySettings.SetQualityLevel(dropdown.value);
        PlayerPrefs.SetInt("numeroDeCalidad", dropdown.value);
        calidad = dropdown.value;
    }
}

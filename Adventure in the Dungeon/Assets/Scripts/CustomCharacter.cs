using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CustomCharacter : MonoBehaviour
{
    public string nombreEnemigo;
    public int vida;
    public int mana;
    public int fuerza;
    public int defensa;
    public int destreza;
    public int agilidad;
    public int inteligencia;

    public TextMeshProUGUI valorNombreEnemigo;
    public TextMeshProUGUI valorVida;
    public TextMeshProUGUI valorMana;
    public TextMeshProUGUI valorFuerza;
    public TextMeshProUGUI valorDefensa;
    public TextMeshProUGUI valorDestreza;
    public TextMeshProUGUI valorAgilidad;
    public TextMeshProUGUI valorInteligencia;

    private void Start()
    {
        valorNombreEnemigo.text = nombreEnemigo;
        valorVida.text = vida.ToString();
        valorMana.text = mana.ToString();
        valorFuerza.text = fuerza.ToString();
        valorDefensa.text = defensa.ToString();
        valorDestreza.text = destreza.ToString();
        valorAgilidad.text = agilidad.ToString();
        valorInteligencia.text = inteligencia.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

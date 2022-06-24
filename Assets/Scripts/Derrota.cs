using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Derrota : MonoBehaviour
{
    public GameObject cartelDerrota;

    
    // Start is called before the first frame update
    void Start()
    {
        cartelDerrota.SetActive(false);

        GameEvents.OnGameOver += MostrarCartelDerrota;
    }


    private void OnDisable() {
        GameEvents.OnGameOver -= MostrarCartelDerrota;
    }

    private void MostrarCartelDerrota()
    {
        cartelDerrota.SetActive(true);
    }
}

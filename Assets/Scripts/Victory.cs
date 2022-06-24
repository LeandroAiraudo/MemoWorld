using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Victory : MonoBehaviour
{
    public GameObject cartelVictoria;
    
    // Start is called before the first frame update
    void Start()
    {
        cartelVictoria.SetActive(false);
    }

    private void OnEnable() {
        GameEvents.OnBoardCompleted += ShowCartelVictoria;    
    }

    private void OnDisable() {
        GameEvents.OnBoardCompleted -= ShowCartelVictoria; 
    }

    private void ShowCartelVictoria()
    {
        cartelVictoria.SetActive(true);
    }

    public void LoadNextLevel()
    {
        GameEvents.LoadNextLevelMethod();
    }

    
    
}

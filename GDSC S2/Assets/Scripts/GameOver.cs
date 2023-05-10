using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{

    public bool Is_Over = false;
    [SerializeField] private GameObject GameOverPanel;
    // Start is called before the first frame update
    private void Update()
    {
        if(Is_Over)
        {
            GameOverPanel.SetActive(true);
            Is_Over= false;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class H_S_TXT : MonoBehaviour
{
    [SerializeField] private TMP_Text H_S;
     public HeighestScore HS;
    private SpawnManager score;
    // Start is called before the first frame update
    void Start()
    {
        score = FindObjectOfType<SpawnManager>();
        H_S.text = $"Heighest Score : {HS.h_s.ToString()}";
    }

    // Update is called once per frame
    void Update()
    {
        if(score._counter > HS.h_s) 
        { 
            HS.h_s = score._counter;
            H_S.text = $"Heighest Score : {HS.h_s.ToString()}";
        }
        
    }
}

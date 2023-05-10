using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{
    
    [SerializeField] private TMP_Text timer;
    [SerializeField] private float time = 0f;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
      //  Debug.Log(Time.deltaTime);
        time += Time.deltaTime;
        timer.text = $"Time : {time.ToString("F2")}";
    }
}

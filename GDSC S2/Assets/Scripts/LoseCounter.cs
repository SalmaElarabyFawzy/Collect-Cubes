using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class LoseCounter : MonoBehaviour
{

    [SerializeField] private TMP_Text lose;
    [SerializeField] private Animator _anim;
    public Animation trythis;

    private void Start()
    {
        _anim= lose.gameObject.GetComponent<Animator>();
    }
    public void PlayCounter(int i)
    {
        lose.gameObject.SetActive(true);
   
        lose.text = i.ToString();
        _anim.SetBool("Start", true);
    }
    public void DisableCounter()
    {
        _anim.SetBool("Start", false);
        lose.gameObject.SetActive(false);   
    }
    public void Stop_anim()
    {
        _anim.SetBool("Start", false);
    }
}

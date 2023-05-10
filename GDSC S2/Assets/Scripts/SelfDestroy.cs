using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelfDestroy : MonoBehaviour
{
    public  bool is_destroyed = false;
    
    [SerializeField] private float destroy_seconds = 7f;
    private GameOver _gameover;
    private LoseCounter _counter;
    private void OnBecameVisible()
    {
        _gameover = FindObjectOfType<GameOver>();
        _counter = FindObjectOfType<LoseCounter>(); 
       // spawn = FindObjectOfType<SpawnManager>();
        StartCoroutine(self_Destroy());
        
    }

    private IEnumerator self_Destroy()
    {
        yield return new WaitForSeconds(destroy_seconds);
        for (int i=3;i>=0;i--)
        {
            _counter.PlayCounter(i);
            yield return new WaitForSeconds(1f);
            _counter.Stop_anim();
        }
       
       if(!is_destroyed) 
       {

            _gameover.Is_Over = true;
            _counter.DisableCounter();  
            Destroy(this.gameObject);
        } 
    }
}

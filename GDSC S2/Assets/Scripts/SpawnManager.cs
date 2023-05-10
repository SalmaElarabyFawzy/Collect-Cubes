using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class SpawnManager : MonoBehaviour
{
    [SerializeField] private Transform[] points;

    [SerializeField] private TMP_Text Score;
    [SerializeField] private TMP_Text CountDown;
    [SerializeField] private GameObject prefab;
    public int _counter = 0;



    private void Start()
    {
        Start_Coroutine();
    }

    private void OnTriggerEnter(Collider other)
    {
      GetComponent<Renderer>().material.color = other.GetComponent<Renderer>().material.color;
      
        _counter++;
        Score.text = $"Score : { _counter.ToString()}";
       
        other.GetComponent<SelfDestroy>().is_destroyed= true;
        Destroy(other.gameObject);
       
       if(_counter % (points.Length-1) ==0)
        {
             Start_Coroutine();
        }
    }


    


    private  IEnumerator spawn()
    {
        CountDown.gameObject.SetActive(true);
        for(int i=5;i>=0;i--)
        {
            CountDown.text =$"Time to respawn : { i.ToString()}";
            yield return new WaitForSeconds(.5f);
        }
        CountDown.gameObject.SetActive(false);
        int ind = Random.Range(0 , points.Length);
        for(int i =0;i<points.Length;i++)
        {
            if(i!=ind)
            {
                GameObject cube = Instantiate(prefab, points[i].position, Quaternion.identity);
                cube.GetComponent<Renderer>().material.color = new Color(Random.Range(0, 3), Random.Range(0, 3), Random.Range(0, 3));
            }
        }
       

    }

    public void Start_Coroutine()
    {
        StartCoroutine(spawn());
    }
}

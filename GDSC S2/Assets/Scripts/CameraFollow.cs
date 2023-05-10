using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    [SerializeField] private Transform Player;
    [SerializeField] private Vector3 Offset;
    

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = Player.transform.position + Offset;
        gameObject.transform.LookAt(Player);
    }
}

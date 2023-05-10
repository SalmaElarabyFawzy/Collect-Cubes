using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private bool paused = true;
    [SerializeField] private Rigidbody RB;
    public float speed = 4f;
   
    private float MovementX;
    private float MovementZ;
  //  private IEnumerator _ref;
    // Start is called before the first frame update
    void Start()
    {
       // _ref = ColorChange();
        RB = GetComponent<Rigidbody>();
 
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(MovementX, 0, MovementZ);
        RB.AddForce(movement * speed * Time.deltaTime , ForceMode.VelocityChange);
    }

    private void OnRoll(InputValue input)
    {
        Vector2 rollVector = input.Get<Vector2>();
        MovementX = rollVector.x;
        MovementZ = rollVector.y;
    }

   /* private void OnPressSpace( InputValue input)
    {
        if(paused)
        {
            StartCoroutine(ColorChange());
            paused = false;
            Debug.Log("Started !");
        }
        else
        {
            //StopCoroutine(ColorChange());
             StopCoroutine(_ref);
          
            paused= true;
            Debug.Log("Stoped!");
        }
    }
    private void OnTapSpace(InputValue input)
    {
       // Debug.Log("Tap!");
    }
    private void OnHoldSpace(InputValue input)
    {
       // Debug.Log("Hold for one second!");
    }
    private void OnHoldSpace2(InputValue input)
    {
      //  Debug.Log("Hold for two seconds!");
    }*/

    private IEnumerator ColorChange()
    {
        while(true) 
        {
            GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value);
            yield return new WaitForSeconds(1);
        }
      
        
    }


}

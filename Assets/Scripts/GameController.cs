using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public GameObject Pickup;
    public Transform yeet;
    

    private void Start()
    {
        Pickup = GameObject.FindWithTag("Pickup");
    }

    void Update()
    {
        if (Input.GetButtonDown("Submit"))
        {
            
            Instantiate(Pickup, yeet.position, yeet.rotation);
           
        }
    }



    public void GetInput(string guess)
    {
        Debug.Log("You Entered " + guess);
      
    }



}

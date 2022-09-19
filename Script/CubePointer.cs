using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubePointer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Response Pointer Touch the cube
    public void PointerEnter()
    {
        //Change the color of the cube to blue
        GetComponent<Renderer>().material.color = Color.blue;
    } 
    //Response Pointer Exit the cube
    public void PinterExit()
    {
        //change the color of the cube to white
        GetComponent<Renderer>().material.color = Color.white;

    }
    //Response to Pointer click Event
    public void PointerClick()
    {
        //kill the enemy
        Destroy(gameObject);
    }
}

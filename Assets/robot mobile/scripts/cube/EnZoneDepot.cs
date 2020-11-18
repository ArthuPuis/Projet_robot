using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnZoneDepot : MonoBehaviour
{
    
    public bool isIn = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool isInDepot()
    {
        return isIn;
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.name == "depot")
        {
            Debug.Log("entered");
            isIn = true;
        }
        
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.name == "depot")
        {
            Debug.Log("entered");
            isIn = false;
        }
    }
}

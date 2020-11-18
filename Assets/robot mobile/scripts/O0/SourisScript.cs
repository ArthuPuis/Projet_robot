using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SourisScript : MonoBehaviour
{
    public bool B1, B2, B3 = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Navigation
        if (Input.GetMouseButton(0))//B1
        {
            print("Left mouse click");
            B1 = true;
            B2 = false;
        }
        //selection
        else if (Input.GetMouseButton(1))//B2
        {
            print("Right mouse click");
            B1 = false;
            B2 = true;

            
        }
        //manipulation
        else if (Input.GetKeyDown("c") && B2 == true)//B3
        {
            print("Middle mouse click");
            B1 = false;
            B3 = true;

        }
        // out manipulation
        else if (Input.GetKeyDown("v")  && B3 == true)
        {
            B3 = false;
        }

        else
        {

        }
    }
}

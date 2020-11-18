using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionnableDistScript : MonoBehaviour
{

    public bool isSelectionnable = false;
    public ToColor colorc = null;
    public EnZoneDepot zoneDepot = null;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    // Update is called once per frame
    void Update()
    {
        if(zoneDepot.isIn == true)
        {
            colorc.To_Color(Color.green);
        }
        else if (isSelectionnable == true)
        {
            colorc.To_Color(Color.blue);
        }
        else if (isSelectionnable == false)
        {
            colorc.To_Color(Color.red);
        }
    }

    private void OnCollisionEnter(Collision other)//detection de collision avec la pince
    {
        if (other.gameObject.name == "Otool")
        {
            Debug.Log("Otool collision");
            isSelectionnable = true;
        }
    }

    private void OnCollisionExit(Collision other)//lorsque que la pince n'est plus en contact
    {
        if (other.gameObject.name == "Otool")
        {
            Debug.Log("entered");
            isSelectionnable = false;
        }
    }
}

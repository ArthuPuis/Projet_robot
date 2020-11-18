using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavigationScript : MonoBehaviour
{
    
    public MaterialScript In = null;
    public BougeBaseMobile Out = null;
    public Vector3 incrementVR;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (In.B1 == true)
        {
            Out.isNavig = true;
        }
        else
        {
            Out.isNavig = false;
        }
    }
}

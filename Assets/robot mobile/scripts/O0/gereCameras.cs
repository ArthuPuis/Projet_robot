using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gereCameras : MonoBehaviour
{
    public MaterialScript In = null;
    public Camera exocentrique = null;
    public Camera egocentrique1 = null;
    public Camera egocentrique2 = null;
    
    // Start is called before the first frame update
    void Start()
    {
        egocentrique1.enabled = false;
        egocentrique2.enabled = false;
        exocentrique.enabled = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(In.B1 )//navigation
        {
            egocentrique1.enabled = false;
            egocentrique2.enabled = false;
            exocentrique.enabled = true;
        }
        else if (In.B2)//selection
        {
            if (In.B3 == false)
            {
                egocentrique1.enabled = true;
                egocentrique2.enabled = false;
                exocentrique.enabled = false;
            }
            else if (In.B3)//manipulation
            {
                egocentrique1.enabled = false;
                egocentrique2.enabled = true;
                exocentrique.enabled = false;
            }
        }
        

    }
}

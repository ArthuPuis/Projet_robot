using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionScript : MonoBehaviour
{
    public gere_bras Out = null;
    public GenereObjetsScript genCube = null;
    public MaterialScript In = null;
    public Vector3 incrementVR;
    private bool bloque;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < genCube.numberObject; i++)
        {
            if (genCube.Ocube[i].GetComponent<SelectionnableDistScript>().isSelectionnable == true)
            {
                bloque = true;// bloque les deplacements du bras robot
            }

        }

        if (In.B2 == true && bloque ==false)
        {
            incrementVR = In.increment;
            Out.increment = incrementVR;

        }
        else if(In.B2 ==true && In.B3 == true)
        {
            incrementVR = In.increment;
            Out.increment = incrementVR;
        }
        bloque = false;
    }
}

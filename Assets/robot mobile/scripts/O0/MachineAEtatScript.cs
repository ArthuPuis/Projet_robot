using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineAEtatScript : MonoBehaviour
{
    public SourisScript In = null;
    public MaterialScript Out = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Out.B1 = In.B1;
        Out.B2 = In.B2;
        Out.B3 = In.B3;
    }
}

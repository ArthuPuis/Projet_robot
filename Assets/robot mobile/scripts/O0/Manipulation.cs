using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manipulation : MonoBehaviour
{
    public MaterialScript In = null;
    public GenereObjetsScript genCube = null;
    //selectionnabledist
    public PrendObjet prendObj = null;
    public LacheObjet lacheObj = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //pour chaque cube on verifie s'il est selectionnable et manipulable
        for (int i = 0; i < genCube.numberObject; i++) {
            if (genCube.Ocube[i].GetComponent<SelectionnableDistScript>().isSelectionnable == true)
            {
                print("is selectionnable");
                if (In.B3 == true)//ferme la pince si on est en mode manipulation
                {
                    prendObj.closePince(genCube.Ocube[i]);
                }
                else//ouvre la pince
                {
                    lacheObj.OpenPince(genCube.Ocube[i]);
                    In.B3 = false;
                }
            }
            
        }
        
    }
}

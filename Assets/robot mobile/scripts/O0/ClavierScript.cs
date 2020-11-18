using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClavierScript : MonoBehaviour
{
    
    public float step = 5.0f;
    public MaterialScript materialScript = null;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //getButton actif tant que le bouton est appuyé et quand etat navigation n'est pas actif
        if (Input.GetKeyDown(KeyCode.UpArrow) && materialScript.B1 == false)//axe z
        {
            print("Up key was released");
            materialScript.increment = new Vector3(0.0f, 0.0f, step);
        }
        else if (Input.GetKeyUp(KeyCode.DownArrow) && materialScript.B1 == false)
        {
            print("Down key was released");
            materialScript.increment = new Vector3(0.0f, 0.0f, -step);
        }
        else if (Input.GetKeyUp(KeyCode.RightArrow) && materialScript.B1 == false)//axe x
        {
            print("Right key was released");
            materialScript.increment = new Vector3(step, 0.0f, 0.0f);
        }
        else if (Input.GetKeyUp(KeyCode.LeftArrow) && materialScript.B1 == false)
        {
            print("Left key was released");
            materialScript.increment = new Vector3(-step, 0.0f, 0.0f);
        }
        else if (Input.GetKeyUp("z") && materialScript.B1 == false)//axe y
        {
            print("Z key was released");
            materialScript.increment = new Vector3(0.0f, step, 0.0f);
        }
        else if (Input.GetKeyUp("s") && materialScript.B1 == false)
        {
            print("S key was released");
            materialScript.increment = new Vector3(0.0f, -step, 0.0f);
        }
        else
        {
            materialScript.increment = new Vector3(0.0f, 0.0f, 0.0f);
        }
    }

}

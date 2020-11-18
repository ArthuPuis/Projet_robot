using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrendObjet : MonoBehaviour
{
    public GameObject Opince_d = null;
    public GameObject Opince_g = null;
    public GameObject obj = null ;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void closePince(GameObject cube)
    {
        Opince_d.transform.eulerAngles = new Vector3(90, 0, 0);
        Opince_g.transform.eulerAngles = new Vector3(90, 0, 0);
        cube.transform.SetParent(this.transform);
        cube.GetComponent<Rigidbody>().useGravity = false;
    }
}

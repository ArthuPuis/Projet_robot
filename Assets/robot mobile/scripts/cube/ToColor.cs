using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToColor : MonoBehaviour
{
    public GameObject cube = null;
    // Start is called before the first frame update
    void Start()
    {
        To_Color(Color.gray);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void To_Color(Color color)
    {
        this.cube.GetComponent<Renderer>().material.color = color;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BougeBaseMobile : MonoBehaviour
{
    public bool isNavig = false;
    public float speed = 1.0f;
    public float rotationSpeed = 100.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isNavig == true)
        {
            float translation = Input.GetAxis("Vertical") * speed;
            float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
            // Vitesse de 1 m par seconde
            translation *= Time.deltaTime;
            rotation *= Time.deltaTime;
            // translation sur l'axe z
            transform.Translate(translation, 0, 0);

            // Rotate around our y-axis
            transform.Rotate(0, rotation, 0);
        }
        
    }


}

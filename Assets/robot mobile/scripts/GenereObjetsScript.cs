using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenereObjetsScript : MonoBehaviour
{
    public GameObject cube = null;
    private Vector3 randomPos = new Vector3(0, 0, 0);
    private Vector3 nullRotation = new Vector3(0, 0, 0);
    public int numberObject = 3;
    public List<GameObject> Ocube = new List<GameObject>();
    bool endGame = false;
    int countRange = 0;
    // Start is called before the first frame update
    void Start()
    {
        for(int i =0; i < numberObject; i++)
        {
            //on affecte un position aléatoire en -10 et 10 de chaque axe
            randomPos = new Vector3(Random.Range(-2.0f, 4.0f), 0.5f, Random.Range(-1.7f, 1.7f));
            //on ajoute le cube dans la liste des objets
            Ocube.Add(Instantiate(cube.gameObject, randomPos, cube.gameObject.transform.rotation));
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        for(int i =0; i < numberObject; i++)
        {
            if(Ocube[i].GetComponent<EnZoneDepot>().isIn == false)
            {
                countRange++;
            }
        }
        if(countRange == 0)
        {
            print("YOU WIN");
        }
        countRange = 0;
    }
}

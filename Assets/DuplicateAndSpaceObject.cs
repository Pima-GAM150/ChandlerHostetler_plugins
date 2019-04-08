using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuplicateAndSpaceObject : MonoBehaviour
{
    public int numberOfDuplications;
    public List<GameObject> clones;
    public Transform mainObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void deleteClones() {

        foreach (GameObject clones in clones)
        {
            DestroyImmediate(clones);
        }
        while (clones.Count > 0)
        {
            for (int i = 0; i < clones.Count; i++)
            {
                clones.RemoveAt(i);
            }
        }
    }

    public void stackObjects() {
         mainObject = this.gameObject.transform;

        foreach (GameObject clone in clones) {
            for (int i = 0;  i< numberOfDuplications; i++)
            clones[i].transform.position = mainObject.TransformDirection(new Vector2(mainObject.position.x, mainObject.position.y - 1 - i));
        }
    }

    public void arrangeSideways() {
        mainObject = this.gameObject.transform;

        foreach (GameObject clone in clones)
        {
            for (int i = 0; i < numberOfDuplications; i++)
                clones[i].transform.position = mainObject.TransformDirection(new Vector2(mainObject.position.x + 1 + i, mainObject.position.y));
        }
    }

}

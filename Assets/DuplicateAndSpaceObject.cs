using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuplicateAndSpaceObject : MonoBehaviour
{
    public int numberOfDuplications;
    public List<GameObject> clones;
    public Transform mainObject;
    public int spacing;
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
             if(i == 0)
                clones[i].transform.position = mainObject.TransformDirection(new Vector2(mainObject.position.x, mainObject.position.y - spacing));
            else
                clones[i].transform.position = mainObject.TransformDirection(new Vector2(mainObject.position.x, mainObject.position.y - ((i+1) * spacing)));
        }
    }

    public void arrangeSideways() {
        mainObject = this.gameObject.transform;

        foreach (GameObject clone in clones)
        {
            for (int i = 0; i < numberOfDuplications; i++)
                if (i == 0) {
                    clones[i].transform.position = mainObject.TransformDirection(new Vector2(mainObject.position.x + spacing, mainObject.position.y));
                }
            else
                    clones[i].transform.position = mainObject.TransformDirection(new Vector2(mainObject.position.x  + ((i+1) * spacing), mainObject.position.y));
         
        }
    }

}

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

        foreach (GameObject clones in clones) {
            this.transform.position = mainObject.position + mainObject.TransformDirection(new Vector2(0, -1));
        }


    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuplicateAndSpaceObject : MonoBehaviour
{
    public int numberOfDuplications;
    public List<GameObject> clones;
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

}

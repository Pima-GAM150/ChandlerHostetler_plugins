using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(DuplicateAndSpaceObject))]
public class DuplicateAndSpace : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        DuplicateAndSpaceObject DandS = (DuplicateAndSpaceObject)target;

        if (GUILayout.Button("Duplicate"))
        {
            Object prefabRoot = PrefabUtility.GetCorrespondingObjectFromOriginalSource(Selection.activeGameObject);

            if (prefabRoot != null)
                PrefabUtility.InstantiatePrefab(prefabRoot);
            else
                for (int i = 0; i < DandS.numberOfDuplications; i++)
                {
                    Instantiate(Selection.activeGameObject);
                }
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbcBuilderOnly : MonoBehaviour {

    [SerializeField]
    private Transform sceneObjectsRootTransform;
    
    // Use this for initialization
	void Start ()
    {
        GameObject newGO = new GameObject("AGameObject");
        newGO.AddComponent<FirstBehavior>();

        newGO.transform.SetParent(sceneObjectsRootTransform);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class LoadGame : MonoBehaviour {

    public Flowchart flowchart;

	// Use this for initialization
	void Start () {

        flowchart.GetPublicVariables();
	}

    public void Load()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnCamera : MonoBehaviour {

    public GameObject mainCam;
	void Awake () {
        GameObject prefab = Instantiate(mainCam);
        prefab.SetActive(true);
        
	}
}

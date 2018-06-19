using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMusic : MonoBehaviour {

	void Start () {
		
	}

    private static BGMusic instance = null;
    public static BGMusic Instance
    {
        get { return instance; }
    }


	void Awake () {
		if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        DontDestroyOnLoad(this.gameObject);
	}
}

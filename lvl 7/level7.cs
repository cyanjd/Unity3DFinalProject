using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level7 : MonoBehaviour {

    public ParticleSystem ps;

	// Use this for initialization
	void Start () {
        ps = GetComponent<ParticleSystem>();
    }
	
	// Update is called once per frame
	void Update () {
        var main = ps.main;
        main.startColor = new Color(0.0F, 0.0F, 1.0F, 0.0F);
    }
}

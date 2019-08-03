using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour {

	Vector3 localScale;

    public GameObject Dog;

	// Use this for initialization
	void Start () {
		localScale = transform.localScale;

        localScale.x = 0;
        transform.localScale = localScale;
    }
	
	// Update is called once per frame
	void Update () {
		localScale.x = 2 - 2*Dog.GetComponent<Dog_Movement>().pet_bar();
		transform.localScale = localScale;
	}
}

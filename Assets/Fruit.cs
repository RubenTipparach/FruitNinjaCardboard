using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour {

    public GameObject halves;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	    	
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.attachedRigidbody.GetComponent<AttackSword>())
        {
            halves.SetActive(true);
            halves.transform.SetParent(null);

            gameObject.SetActive(false);
        }
    }
}

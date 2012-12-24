using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {
	
	private Weapon w=null;
	// Use this for initialization
	void Start () {
		w=GetComponent<Weapon>();
		Debug.Log(w);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

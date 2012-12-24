using UnityEngine;
using System.Collections;

public class FlameThrower_AI : MonoBehaviour, Weapon {
	private Transform target;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void setTarget(Transform target){
		this.target=target;
	}
}

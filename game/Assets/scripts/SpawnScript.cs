using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {
	public Transform prefab;
	
	public float delay=1;
	
	private float starttime=0;
	// Use this for initialization
	void Start () {
		starttime=Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.time>starttime+delay){
			starttime=Time.time;
			Instantiate(prefab,transform.position+new Vector3(4,2,0),transform.rotation);
		}
	}
}

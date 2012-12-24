using UnityEngine;
using System.Collections;

public class WalkTheLine_AI : MonoBehaviour {
	
	private GameObject target;
	public float updateDelay=1;
	private float last=0;
	
	public float speed=5;
	public float dist=10;
	
	//this will be used for moving the robot
	private CharacterMotor motor;
	// Use this for initialization
	void Start () {
		motor=GetComponent<CharacterMotor>();
	}
	
	// Update is called once per frame
	void Update () {
		
		//time to determine the closest enemy
		if(Time.time>last+updateDelay){
			last=Time.time;
			float mindistance=0;
			bool first=true;
			foreach(GameObject go in GameObject.FindGameObjectsWithTag("enemy")){
				if(first){
					mindistance=Vector3.Distance(transform.position,go.transform.position);
					target=go;
					first=false;
				}
				float distance=Vector3.Distance(transform.position,go.transform.position);
				if(distance<mindistance){
					target=go;
					mindistance=distance;
				}
			}
		}
		
		//let the hunt begin
		if(Vector3.Distance(target.transform.position,transform.position)<dist){
			motor.SetVelocity(Vector3.zero);
		}
		else{
			motor.SetVelocity((target.transform.position-transform.position).normalized*speed);
		}
	}
}

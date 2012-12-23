using UnityEngine;
using System.Collections;

public class Patrol_AI : MonoBehaviour {
	public Transform[] waypoints;
	public float speed=5;
	public float turndistance=4;

	private CharacterMotor motor;
	private Transform waypoint;
	private int index=0;
	// Use this for initialization
	void Start () {
		motor=GetComponent<CharacterMotor>();
		waypoint=waypoints[0];
	}
	
	// Update is called once per frame
	void Update () {
		if(Vector3.Distance(transform.position,waypoint.position)<turndistance){
			index++;
			if(index==waypoints.Length)index=0;
			waypoint=waypoints[index];
		}
		motor.SetVelocity((waypoint.position-transform.position).normalized*speed);
	}
}

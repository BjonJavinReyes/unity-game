#pragma strict

public var factory:Transform;

private var selected:Transform=null;

function Start () {

}

function Update () {
	if(Input.GetMouseButtonDown(0)){
		var hit:RaycastHit;
		var ray:Ray=Camera.main.ScreenPointToRay(Input.mousePosition);
		if(Physics.Raycast(ray,hit)){
			if(selected){
				Instantiate(selected,hit.point,Quaternion.Euler(0,0,0));
			}
		}
	}		
}

function OnGUI() {
	GUI.Box(Rect(10,10,50,20),"Tools");
	
	if(GUI.Button(Rect(10,40,50,20),"factory")){
		selected=factory;
	}
}
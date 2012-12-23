#pragma strict

function OnGUI(){
	GUI.Box(Rect(50,10,200,40),"welcome to our strategy game");
	
	if(GUI.Button(Rect(80,70,80,20),"level1")){
		print("watch out for ?");
		Application.LoadLevel(1);
	}
	
}
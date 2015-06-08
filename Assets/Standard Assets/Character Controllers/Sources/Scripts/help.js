#pragma strict

//var txtstyle:GUIStyle ;
var toolbarInt = 1;
var toolbarStrings : String[]=["返回","直流输电原理","换流变原理","换流变网侧线圈","换流变阀侧线圈","换流变铁心","换流变器身","高压交流套管","低压交流套管","阀侧套管","有载调压开关"];
var helpImage : String[]=["0","1","2","3","4","5","6","7","8","9","10"];


function OnGUI()
{
	//GUI.BeginGroup(Rect(10,10,120,300));
	
	toolbarInt = GUI.SelectionGrid(Rect(10,10,105,Screen.height-20),toolbarInt,toolbarStrings,1);
	//GUILayout.Button("返回");
	
	//GUI.EndGroup();
GUI.skin.window.fontSize=17;
GUI.skin.window.fontStyle=3;

	GUI.Window(0,Rect(125,10,Screen.width-130,Screen.height-20),WinFunction,toolbarStrings[toolbarInt]);

}

function WinFunction(windowID: int)
{

	if(toolbarInt==0)
	Application.LoadLevel("Mainsence"); 
	var image : Texture2D;
	image=Resources.Load(helpImage[toolbarInt],Texture2D);
	
	var asset : TextAsset;
	asset=Resources.Load(helpImage[toolbarInt],TextAsset);
	
	
	GUI.skin.label.alignment=1;
	GUI.Label(Rect(400,30,Screen.width-540,Screen.height-20),image);
	//GUI.Box(Rect(10,30,380,610),asset.text,EditorStyles.textField);
	
	//EditorStyles.textField.fontSize = 40px；
	//txtstyle = EditorStyles.textField;
	//txtstyle.fontSize = 19;
	GUI.skin.box.fontSize=19;
    GUI.skin.box.alignment=0;
	GUI.Box(Rect(10,30,380,Screen.height-20),asset.text);
}
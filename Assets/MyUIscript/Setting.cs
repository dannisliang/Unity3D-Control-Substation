using UnityEngine;
using System.Collections;

public class Setting : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnClick() {
		var camera = GameObject.Find ("Panel");
		//UICamera camera_ui= camera.GetComponent<UICamera>();
		GameObject _gridItem = NGUITools.AddChild(camera, (GameObject)Resources.Load("Draggable 1"));
		var anchor = GameObject.Find ("Anchor");
		Destroy (anchor);
	}
}

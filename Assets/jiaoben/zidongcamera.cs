using UnityEngine;
using System.Collections;

public class zidongcamera : MonoBehaviour {
	public static float  w=0;
	public static float x=0f;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
		float fov = Camera.main.fieldOfView;
		if(w!=0){
		if (w > 0) {
				w = w-x;
						fov = fov +x;
				} 
		else
			{w=w+x;
				fov=fov-x;
			}
			Camera.main.fieldOfView = fov;
		}
	}
}

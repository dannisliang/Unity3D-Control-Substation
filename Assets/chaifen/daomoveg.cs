using UnityEngine;
using System.Collections;

public class daomoveg : MonoBehaviour {

	public Transform goTransfom;
	private float vel=0.1f;
	// Use this for initialization
	void Start () {
		
		goTransfom = this.GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(goTransfom.transform.position.z>-2.3)
			goTransfom.Translate (Vector3.back * vel);
		
	}
}

using UnityEngine;
using System.Collections;

public class UIGridGabian : MonoBehaviour {
//	 GameObject ngui_grid = GameObject.Find("Grid").gameObject;
	public UIGrid grid;
	//ngui_grid.GetComponent<UIGrid>().enabled = true;
//	public UIGrid ngui_ui_grid = ngui_grid.GetComponent<UIGrid>();
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		grid.Reposition ();
	}
	void OnClick () {
	Destroy(this.transform.gameObject);
		grid.Reposition ();
		/*UIGrid
		ngui_ui_grid.repositionNow = true;
		ngui_ui_grid.Reposition();
		*/
	}
}

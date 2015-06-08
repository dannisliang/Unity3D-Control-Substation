using UnityEngine;
using System.Collections;

public class jindutiao : MonoBehaviour {
	private	float b = 0;
	public UISlider a;
	void Start()
	{
		}
	void Update () {
		
		b = (float)Loading.progress / 100;
		a.sliderValue = b;

	}


}

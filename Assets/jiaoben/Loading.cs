using UnityEngine;
using System.Collections;

public class Loading : MonoBehaviour {
//	public UISlider progress1;
	private float fps = 10.0f;
	private float time;
	//一组动画的贴图，在编辑器中赋值。

	public Texture2D []animations;
	private int nowFram;
	//异步对象
	AsyncOperation async;
	public static int  progress;
	private Rect rctBloodBar;
	void Start()
	{
		progress = 0;
		//在这里开启一个异步任务，
		//进入loadScene方法。
		StartCoroutine(loadScene());  
	}


	//注意这里返回值一定是 IEnumerator
	IEnumerator loadScene()
	{
		//异步读取场景。
		//Globe.loadName 就是A场景中需要读取的C场景名称。
		async = Application.LoadLevelAsync(kong.LoadName);
		
		//读取完毕后返回， 系统会自动进入C场景
		yield return async;
	}
	

	
	void Update()
	{
		progress = (int)(async.progress*100);
		//progress1.sliderValue = progress;
		//有了读取进度的数值，大家可以自行制作进度条啦。
		Debug.Log("xuanyusong" +progress);
	}
	void OnGUI()
	{
		//GUI.Label(new Rect(0,0,Screen.width,Screen.height), "lOADING!!!!!" + progress);
	}


	//这是一个简单绘制2D动画的方法，没什么好说的。
	void   DrawAnimation(Texture2D[] tex)
	{
		
		time += Time.deltaTime;
		
		if(time >= 1.0 / fps){
			
			nowFram++;
			
			time = 0;
			
			if(nowFram >= tex.Length)
			{
				nowFram = 0;
			}
		}
		GUI.DrawTexture(new Rect( 0,0,Screen.width,Screen.height) ,tex[nowFram] );
		
		//在这里显示读取的进度。
		GUI.Label(new Rect(0,0,Screen.width,Screen.height), "lOADING!!!!!" + progress);
		
	}
}

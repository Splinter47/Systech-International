using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {
	
	//Declare Variables
	public Texture branding;
	public Font guiFont;
	Rect logoCrop = new Rect(0f,0.625f,1.0f,0.375f);
	Rect logoPos = new Rect(32.0f,8.0f,128.0f,48.0f);
	Rect whiteCrop = new Rect (0.0f,0.25f,0.24f,0.24f);
	Rect barPos = new Rect(0.0f,0.0f,Screen.width,64.0f);
	Rect greyCrop = new Rect (0.25f,0.25f,0.25f,0.25f);
	Rect redCrop = new Rect (0.5f,0.25f,0.25f,0.25f);
	Rect purpleCrop = new Rect (0.75f,0.25f,0.25f,0.25f);
	Rect blueCrop = new Rect (0.0f,0.0f,0.25f,0.25f);
	Rect cyanCrop = new Rect (0.25f,0.0f,0.25f,0.25f);
	Rect orangeCrop = new Rect (0.5f,0.0f,0.25f,0.25f);
	Rect greenCrop = new Rect (0.75f,0.0f,0.25f,0.25f);
	Vector2 buttonSize = new Vector2(96.0f,64.0f);
	GUIStyle onStyle = new GUIStyle();
	GUIStyle offStyle = new GUIStyle();
	Color white = new Color(1.0f,1.0f,1.0f,1.0f);
	Color grey = new Color(0.5f,0.5f,0.5f,1.0f);
	Menu currentMenu = Menu.About;


	// Use this for initialization
	void Start () {
		GUI.depth = -999;
		//Initialize the gui Style;
		onStyle.alignment = TextAnchor.MiddleCenter;
		onStyle.font = guiFont;
		onStyle.fontSize = 16;
		onStyle.normal.textColor = grey;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI () {
		//Draw Menu Bar
		GUI.DrawTextureWithTexCoords(barPos, branding, whiteCrop);
	
		//Draw Menu Bar
		GUI.DrawTextureWithTexCoords(new Rect(0,0,Screen.width, Screen.height), branding, orangeCrop);
		//Draw Logo
		GUI.DrawTextureWithTexCoords(logoPos, branding, logoCrop);

		//Menu Titles
		for (int i =0; i<PresentationSystem.MenuTitle.Length; i++) {
					if(GUI.Button (new Rect (192.0f+(buttonSize.x*i)+20+(20*i),0.0f,buttonSize.x,buttonSize.y),PresentationSystem.MenuTitle[i],onStyle)){
						//currentMenu = Menu.[i];
					}
				}

	
	}
}

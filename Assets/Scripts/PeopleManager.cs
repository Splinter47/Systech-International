using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;

public class PeopleManager : MonoBehaviour {
	public Font infoFont;
	public Font mainFont;
	string fileName = "foo.txt";
	string info;
	float myOffset;
	Person[] people;
	Vector2 buttonSize = new Vector2(192,32);
	Vector2 textureSize = new Vector2(256,384);
	Rect titlePos = new Rect(0,0,10,10);
	int selectedPerson;
	Texture bigTex;
	string peepsnames;
	GUIStyle nameStyle = new GUIStyle();
	GUIStyle infoStyle = new GUIStyle();
	GUIStyle buttonStyle = new GUIStyle();
	GUIStyle offStyle = new GUIStyle();
	Color grey = new Color(0.5f,0.5f,0.5f,1.0f);

	// Use this for initialization
	void Start () {

		InitNames ();
		people = GetComponentsInChildren<Person> ();
		//Initialize the gui Style;
		//onStyle.alignment = TextAnchor.MiddleCenter;
		nameStyle.font = mainFont;
		nameStyle.fontSize = 64;
		nameStyle.normal.textColor = grey;
		infoStyle.font = infoFont;
		infoStyle.fontSize = 12;
		infoStyle.wordWrap = true;
		buttonStyle.alignment = TextAnchor.MiddleCenter;
		buttonStyle.font = mainFont;
		buttonStyle.fontSize = 16;
		buttonStyle.normal.textColor = grey;
		//StreamReader sr = new StreamReader (Application.dataPath + "/" + fileName);

	}

	void SetNameText(int v){
		peepsnames = "" +people[v].name;
		}

	void SetInfoText(int v){
		TextAsset descriptionText = Resources.Load("People/text/"+people[v].name) as TextAsset;
		info = descriptionText.text;
		}

	void OnMouseDrag () {
		//renderer.material.color -= Color.white * Time.deltaTime;
	}

	void InitNames(){
//		for (int i =0; i<people.Length; i++) {
//				}
		}
	/*
		var sr = new StreamReader(Application.dataPath + "/" + fileName);
		var fileContents = sr.ReadToEnd();
		sr.Close();
		
		var lines = fileContents.Split("\n"[0]);
		for (line in lines) {
			print (line);
		}
*/
	
	// Update is called once per frame
	void Update () {
		UpdateMenuPos ();
	}
	void UpdateMenuPos(){

			//update the offset here
		if (Input.GetMouseButtonDown && Input.mousePosition.x < 256 + 384 && Input.mousePosition.x > 256) {
			deltaMouse = 
			myOffset += deltaMouse;
				}
		}

	void OnGUI () {
		GUI.depth = 999;
		// draws the name box
		GUI.Label (new Rect (256.0f, 128.0f, 192.0f, 64.0f), peepsnames, nameStyle);


		// draws the info box
		GUI.Label (new Rect (256.0f, 256.0f+myOffset, 384.0f, 2044.0f), info, infoStyle);

		
		//Draw the buttons
		for(int i =0; i<people.Length;i++){
				if(GUI.Button(new Rect(0, 64+(buttonSize.y*i), buttonSize.x, buttonSize.y),"" +people[i].name, buttonStyle))
					{
						selectedPerson = i;
						LoadPerson (selectedPerson);
						SetInfoText(selectedPerson);
						SetNameText(selectedPerson);

					}
			}
		DrawPerson ();


		if(GUI.Button(new Rect(Screen.width-buttonSize.x, 0, buttonSize.x, buttonSize.y),"unload button"))
		{
			UnLoad ();
		}


		}

	//Draws the selected person on screen
	void DrawPerson () {
		if (bigTex != null) {
						GUI.DrawTexture (new Rect (704, 256, textureSize.x, textureSize.y), bigTex);
				}
		//GUI.Label(new Rect(
	}

	//Loads the texture from the resource folder - means you dont have to assign it yourself
	void LoadPerson (int v){
			bigTex = Resources.Load<Texture>("People/imgs/"+people[v].name);
		}

	//UNloads the 
	void UnLoad (){
		Destroy(bigTex);
		Resources.UnloadAsset(bigTex);
		Resources.UnloadUnusedAssets();
	}

	void SwapList(Level l){
				switch (l) {
					case Level.Managing:
						people = GetComponentsInChildren<ManagingDirector> ();
						break;
					case Level.Regional:
						people = GetComponentsInChildren<RegionalDirector> ();
						break;
					case Level.Service:
						people = GetComponentsInChildren<ServiceDirector> ();
						break;
					default:
						break;
			
				}
		}
}

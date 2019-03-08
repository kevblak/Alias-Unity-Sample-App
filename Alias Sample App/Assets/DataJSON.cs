using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;   

public class DataJSON : MonoBehaviour {
	public Data[] game_objects;
	public int DataIndex;

	public GameObject[] GAMEOBJ;

	private string FileName = "scene_contents.json";
	private string dataAsJson;

	// Use this for initialization
	void Start () {
		LoadGameData ();
		DataIndex = 0;
		GAMEOBJ = new  GameObject[3];
		EnterGameData ();

	}

	public Data GetData(){
		return game_objects [3];
	}
	
	// Reads JSON File and Stores it in Data Object
	void LoadGameData () {
		string filePath = Path.Combine (Application.streamingAssetsPath, FileName);

		if (File.Exists (filePath)) {
			dataAsJson = File.ReadAllText (filePath);
			GameData loadedData = JsonUtility.FromJson<GameData> (dataAsJson);
			game_objects = loadedData.game_objects;

		} else {
			Debug.LogError("Cannot load game data!");
		}
	}

	//Takes the information that was taken from the JSON File and applys it
	void EnterGameData(){
		for (DataIndex = 0; DataIndex<3; DataIndex ++) {
			Data GOData = game_objects [DataIndex];
			GAMEOBJ[DataIndex] = GameObject.Find (GOData.type);
			GAMEOBJ[DataIndex].transform.position = GOData.position;
			GAMEOBJ [DataIndex].AddComponent (Type.GetType(GOData.script));
			}
	}
}

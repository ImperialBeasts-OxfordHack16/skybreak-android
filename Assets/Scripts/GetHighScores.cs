using UnityEngine;
using System.Collections;
using System;


[Serializable]
public class PlayerStats {

	public string name;
	public int score;

	public PlayerStats(string name, int score) {
		this.name = name;
		this.score = score;
	}

}

public class JsonHelper {
	public static T[] getJsonArray<T>(string json) {
		string newJson = "{ \"array\": " + json + "}";
		Wrapper<T> wrapper = JsonUtility.FromJson<Wrapper<T>>(newJson);
		return wrapper.array;
	}

	[Serializable]
	private class Wrapper<T> {
		public T[] array;
	}
}

public class GetHighScores : MonoBehaviour {

	private int[] score;
	private string[] name;

	public GetHighScores() {
		score = new int[10];
		name = new string[10];
	}

	// Use this for initialization
	IEnumerator Start () {
		string url = "skybreak.szekelyszilv.com:591/highscore";
		WWW www = new WWW(url);
		yield return www;
		if (www.error != null) {
			Debug.LogError ("JSON data should not be empty!");
		}
		string jsonString = www.text;
		PlayerStats[] allTopPlayers = JsonHelper.getJsonArray<PlayerStats>(jsonString);
		for (int i = 0; i < 10; i++) {
			score[i] = allTopPlayers[i].score;
			name[i] = allTopPlayers[i].name;
		}
	}

	void OnGUI() {
//		GUILayout.BeginArea(new Rect(-2.57f, 1.68f, 4, 4));
		GUILayout.BeginArea(new Rect(120, 90, 200, 200));
		for (int i = 0; i < 5; i++) {
			GUILayout.Box((i + 1).ToString() + ". " + name[i] + " - " + score[i].ToString());
		}
		GUILayout.EndArea();
		GUILayout.BeginArea(new Rect(350, 90, 200, 200));
		for (int i = 5; i < 10; i++) {
			GUILayout.Box((i + 1).ToString() + ". " + name[i] + " - " + score[i].ToString());
		}
		GUILayout.EndArea();
	}

	// Update is called once per frame
	void Update () {
	
	}

}

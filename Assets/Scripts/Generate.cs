using UnityEngine;
using System.Collections;

public class Generate : MonoBehaviour {

	public GameObject clouds;

	// Use this for initialization
	void Start()
	{
		InvokeRepeating("CreateObstacle", 1f, 3f);
	}

	// Update is called once per frame
	void OnGUI () 
	{
		GUI.color = Color.black;
		GUILayout.Label(" Total money: " + Menu.money.ToString());
	}

	void CreateObstacle()
	{
		Instantiate(clouds);
		Menu.money+=5;
	}
}

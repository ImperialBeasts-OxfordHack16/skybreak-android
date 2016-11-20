using UnityEngine;
using System.Collections;

public class ButtonPlay : MonoBehaviour {
	int price = 300;
	public void NextLevelButton(int index)
	{
		Application.LoadLevel(index);
	}

	public void NextLevelButton(string levelName)
	{
		Menu.money -= price;
		Application.LoadLevel(levelName);
	}
}

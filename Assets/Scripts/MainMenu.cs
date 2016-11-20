using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Menu : MonoBehaviour
{
    public Canvas MainCanvas;
	static public int money = 1000;

    public void LoadOn()
	{
		Screen.SetResolution(1080, 1920, true);
		//DontDestroyOnLoad(money);
		Application.LoadLevel(1);
    }
}

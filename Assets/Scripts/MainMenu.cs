using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Menu : MonoBehaviour
{
    public Canvas MainCanvas;

    public void LoadOn()
    {
        Application.LoadLevel(1);
    }
}

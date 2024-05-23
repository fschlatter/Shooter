using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
	[SerializeField] private Button[] buttons;
	public void Start()
	{
		for (int i = 0; i < buttons.Length; i++)
		{
			if (i < PlayerController.Level)
			{
				buttons[i].interactable = true;
			}
			else
			{
				buttons[i].interactable = false;
			}
		}
	}
	// Load a level
	public void LoadLevel(int level)
	{
		SceneManager.LoadScene(level);
	}
	// Exit the game
	public void ExitGame()
	{
		Application.Quit();
	}
}

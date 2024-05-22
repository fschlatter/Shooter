using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager4 : MonoBehaviour
{
	private GameObject player;
	private GameObject[] enemies;
	[SerializeField] private int mags;
	[SerializeField] private GameObject escapeWall;
	[SerializeField] private GameObject text;
	[SerializeField] private GameObject wall;
	// Start is called before the first frame update
	void Start()
    {
		player = GameObject.Find("Player");
		player.GetComponent<PlayerController>().setMagAmount(mags);
		enemies = GameObject.FindGameObjectsWithTag("Enemy");
	}

    // Update is called once per frame
    void Update()
    {
		switch(enemies.Length)
		{
			case 0:
				escapeWall.SetActive(false);
				text.SetActive(true);
				break;
			case 16:
				wall.SetActive(false);
				break;
		}
		enemies = GameObject.FindGameObjectsWithTag("Enemy");
	}
	public void back()
	{
		SceneManager.LoadScene(0);
	}
}

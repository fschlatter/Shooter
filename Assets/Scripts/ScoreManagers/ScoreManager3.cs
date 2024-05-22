using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager3 : MonoBehaviour
{
	private GameObject player;
	private GameObject[] enemies;
	[SerializeField] private int mags;
	[SerializeField] private GameObject escapeWall;
	[SerializeField] private GameObject[] walls;
	[SerializeField] private GameObject text;
	private float delay = 0.4f;
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
		if (delay <= 0)
		{
			switch (enemies.Length)
			{
				case 0:
					escapeWall.SetActive(false);
					text.SetActive(true);
					break;
				case 60:
					walls[0].SetActive(false);
					break;
				case 54:
					walls[1].SetActive(false);
					break;
				case 42:
					walls[2].SetActive(false);
					break;
				case 24:
					walls[3].SetActive(false);
					break;
			}
		}
		else
		{
			delay -= Time.deltaTime;
		}
		
		enemies = GameObject.FindGameObjectsWithTag("Enemy");
		Debug.Log(enemies.Length);
	}
	public void back()
	{
		SceneManager.LoadScene(0);
	}
}

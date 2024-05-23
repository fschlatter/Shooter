using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager5 : MonoBehaviour
{
	private GameObject player;
	private GameObject[] enemies;
	[SerializeField] private int mags;
	[SerializeField] private GameObject escapeWall;
	[SerializeField] private GameObject text;
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
		if (enemies.Length == 0)
		{
			escapeWall.SetActive(false);
			text.SetActive(true);
		}
		else
		{
			Debug.Log(enemies.Length);
			enemies = GameObject.FindGameObjectsWithTag("Enemy");
		}
	}
	public void back()
	{
		SceneManager.LoadScene(0);
	}
}

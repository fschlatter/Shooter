using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager1 : MonoBehaviour
{
	private GameObject player;
	private GameObject[] enemies;
	[SerializeField] private int mags;
	[SerializeField] private GameObject escapeWall;
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
		}
		else
		{
			enemies = GameObject.FindGameObjectsWithTag("Enemy");
		}
	}
}

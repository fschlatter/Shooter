using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boss : MonoBehaviour
{
	private float HP = 100;
	[SerializeField] private GameObject deathParticles;
	[SerializeField] private RectTransform healthBar;
	private GameObject player;
	[SerializeField] private float cooldownRangeMin;
	[SerializeField] private float cooldownRangeMax;
	private float cooldown;
	private float explosiveAmount;
	[SerializeField] private GameObject bombPrefab;
	[SerializeField] private float bRange;
	// Start is called before the first frame FixedUpdate
	void Start()
    {
		cooldown = Random.Range(cooldownRangeMin, cooldownRangeMax);
		player = GameObject.Find("Player");
	}

    // FixedUpdate is called once per frame
    void FixedUpdate()
    {
		if (cooldown <= 0) 
		{
			explosiveAmount = Random.Range(2, 4);
			launchBomb();
			cooldown = Random.Range(cooldownRangeMin, cooldownRangeMax);
		}
		else
		{
			cooldown -= Time.deltaTime;
		}
	}
	private void launchBomb()
	{
		for (int i = 0; i < explosiveAmount; i++)
		{
			Instantiate(bombPrefab, new Vector3(player.transform.position.x + Random.Range(-bRange, bRange), player.transform.position.y + 10, player.transform.position.z + Random.Range(-bRange, bRange)), Quaternion.identity);
		}
	}
	public void hit(float multiplier)
	{
		if (HP > 0)
		{
			HP-=multiplier;
			healthBar.transform.localPosition = new Vector3(HP*5, healthBar.transform.localPosition.y, healthBar.transform.localPosition.z);
			healthBar.transform.localScale = new Vector3(HP/100, healthBar.transform.localScale.y, healthBar.transform.localScale.z);
		}
		else
		{
			Instantiate(deathParticles, new Vector3(transform.position.x-2.5f, transform.position.y, transform.position.z+2.5f), Quaternion.identity);
			deathParticles.transform.localScale = new Vector3(5, 5, 5);
			Destroy(gameObject);
		}
	}
	private void OnParticleCollision(GameObject other)
	{
		if (other.CompareTag("Explosion"))
		{
			hit(0.25f);
		}
	}
}

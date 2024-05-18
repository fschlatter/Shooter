using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
	[SerializeField] private GameObject deathParticles;
	private GameObject player;
	private Rigidbody rb;
	private readonly float forceMultiplier = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
		player = GameObject.Find("Player");
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
		rb.AddForce((player.transform.position - transform.position)* forceMultiplier);
    }
	public void death()
	{
		Instantiate(deathParticles, transform.position, Quaternion.identity);
		Destroy(gameObject);
	}
}

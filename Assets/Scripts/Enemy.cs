using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
	[SerializeField] private GameObject deathParticles;
	private GameObject player;
	private Rigidbody rb;
	private readonly float forceMultiplier = 0.3f;
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
	private void OnTriggerStay(Collider other)
	{
		if (other.CompareTag("FloorIce"))
		{
			Debug.Log("Ice");
			GetComponent<Rigidbody>().drag = 0.5f;
		}
		else if (other.CompareTag("FloorStone"))
		{
			Debug.Log("Stone");
			GetComponent<Rigidbody>().drag = 1.5f;
		}
		else
		{
			GetComponent<Rigidbody>().drag = 1f;
		}
	}
	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.CompareTag("Player"))
		{
			// endGame;
			Debug.Log("Game Over");
		}
	}
}

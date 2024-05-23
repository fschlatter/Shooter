using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
	[SerializeField] private GameObject deathParticles;
	private GameObject player;
	private Rigidbody rb;
	private readonly float forceMultiplier = 25f;
    // Start is called before the first frame FixedUpdate
    void Start()
    {
		player = GameObject.Find("Player");
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // FixedUpdate is called once per frame
    void FixedUpdate()
    {
		transform.rotation = Quaternion.LookRotation(player.transform.position - transform.position);
		rb.AddRelativeForce(Vector3.forward * forceMultiplier);
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
			GetComponent<Rigidbody>().drag = 0.5f;
		}
		else if (other.CompareTag("FloorStone"))
		{
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
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
	}
}

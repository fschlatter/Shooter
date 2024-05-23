using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
	[SerializeField] private GameObject explosion;
	private void OnCollisionEnter(Collision collision)
	{
		Instantiate(explosion, transform.position, Quaternion.identity);
		Destroy(gameObject);
	}
	private void Update()
	{
		transform.localScale = new Vector3(transform.position.y/10, transform.position.y/10, transform.position.y/10);
	}
}

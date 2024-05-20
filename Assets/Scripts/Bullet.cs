using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
	private float lifeTime = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       lifeTimeCheck();
    }
	// Check if the bullet has been alive for too long
	private void lifeTimeCheck()
	{
		if (lifeTime > 0)
		{
			lifeTime -= Time.deltaTime;
		}
		else
		{
			Destroy(gameObject);
		}
	}
	// Destroy the bullet when it collides with something
	private void OnTriggerEnter(Collider collision)
	{
		switch (collision.gameObject.tag)
		{
			case "Enemy":
				collision.gameObject.GetComponent<Enemy>().death();
				Destroy(gameObject);
				break;
			case "Wall":
				Destroy(gameObject);
				Debug.Log("Wall hit");
				break;
		}	
	}
}

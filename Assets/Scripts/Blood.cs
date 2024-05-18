using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blood : MonoBehaviour
{
	private ParticleSystem bloodParticles;
    // Start is called before the first frame update
    void Start()
    {
        bloodParticles = gameObject.GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!bloodParticles.isPlaying)
		{
			Destroy(gameObject);
		}
    }
}

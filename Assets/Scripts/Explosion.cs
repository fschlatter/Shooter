using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
	private ParticleSystem pS;
	// Start is called before the first frame update
	void Start()
    {
        pS = GetComponent<ParticleSystem>();
	}

    // Update is called once per frame
    void Update()
    {
        if (!pS.isPlaying)
		{
			Destroy(gameObject);
		}
    }
}

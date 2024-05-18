using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
	[SerializeField] private Camera mainCamera;
	[SerializeField] private CharacterController charController;
	[SerializeField] private GameObject bulletPrefab;
	[SerializeField] private ParticleSystem shootVFX;
	[SerializeField] private GameObject[] clip;
	private const float movementSpeed = 0.1f;
	private int ammo = 6;
	private int clips = 5;
	// Start is called before the first frame update
	void Start()
	{
		ammoManagement();
	}

	// Update is called once per frame
	void Update()
	{
		turnTowardsMouse();

		if (Input.GetButtonDown("Fire1"))
		{
			resolveFiring();
		}
	}
	// Sets the rotation of the player towards the mouse position relative to the camera
	private void turnTowardsMouse()
	{
		Ray ray = mainCamera.ScreenPointToRay(new Vector2(Mouse.current.position.x.magnitude, Mouse.current.position.y.magnitude));
		if (Physics.Raycast(ray, out RaycastHit raycastHit))
		{
			transform.LookAt(new Vector3(raycastHit.point.x, transform.position.y, raycastHit.point.z));
		}
	}
	// Resolves the firing of the gun by the player
	private void resolveFiring()
	{
		Vector3 playerPos = new Vector3(transform.position.x, transform.position.y+.235f,transform.position.z);
		GameObject bullet = Instantiate(bulletPrefab, playerPos, transform.rotation);
		bullet.transform.Translate(Vector3.forward);
		Vector3 bulletEuler = bullet.transform.eulerAngles;
		bulletEuler = new Vector3(bulletEuler.x, bulletEuler.y + 180, bulletEuler.z);
		bullet.transform.eulerAngles = bulletEuler;
		bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);
		shootVFX.Play();
		ammo--;
		ammoManagement();
	}
	private void ammoManagement()
	{
		if (ammo <= 0)
		{
			if (clips > 0)
			{
				clips--;
				ammo = 6;
			}
		}
		hideAllClips();
		clip[ammo].SetActive(true);
	}
	private void hideAllClips()
	{
		foreach (GameObject clip in clip)
		{
			clip.SetActive(false);
		}
	}
}

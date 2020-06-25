using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disable : MonoBehaviour
{
	public GameObject boost1;
	public GameObject boost4;


	private void OnTriggerEnter(Collider collision)
	{
		if (collision.CompareTag("Player"))
		{
			Destroy(boost1);
			boost4.SetActive(true);

		}
	}
}

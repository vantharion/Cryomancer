﻿using UnityEngine;
using System.Collections;

public class MusicVolume : MonoBehaviour 
{
	public bool triggered = false;
	public AudioClip music;
	public string clipName;

	void Start()
	{
		renderer.enabled = false;
	}

	void OnTriggerEnter(Collider collider)
	{
		if (!triggered)// && clipName.Length > 0)
		{
			if (collider.gameObject.tag == "Player")
			{
				triggered = true;

				GameObject child = collider.gameObject.transform.FindChild("AudioBus").gameObject;

				child.audio.clip = music;
				child.audio.Play();
				
			}
		}
	}
}
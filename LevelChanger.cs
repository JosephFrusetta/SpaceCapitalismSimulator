﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour {

	public Animator animator;
	private int levelToLoad;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void FadeToLevel (int levelIndex)
	{
	levelToLoad = levelIndex;
	animator.SetTrigger("FadeOut");
	}

	public void OnFadeComplete ()
	{
	SceneManager.LoadScene(levelToLoad);
	}
}

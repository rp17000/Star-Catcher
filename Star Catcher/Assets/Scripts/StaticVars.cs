﻿using UnityEngine;
using System.Collections;

public class StaticVars : MonoBehaviour 
{
	public static int score = 0;
	public static int starCount = 0;
	public static int starBarCount = 0;
	public static float distance = 0;
	public static float time = 0;
	public static int randomNegPos = 1;
	public static int secondsToAdd = 25;
	public static float speed;

	public static bool isPaused = false;
	public static bool isGrounded = false;
	public static bool gameOver = false;

	public enum Difficulty{Easy, Normal, Unfair}

	public static Difficulty currentDifficulty = Difficulty.Normal;

	public static void Reset()
	{
		score = 0;
		starCount = 0;
		starBarCount = 0;
		gameOver = false;
		isPaused = false;
	}

//	public static void GameOver()
//	{
//		gameOver = true;
//		isPaused = true;
//		int totalStars = starCount + PlayerPrefs.GetInt ("TotalStars", 0);
//		PlayerPrefs.SetInt("TotalStars", totalStars);
//	}		
}

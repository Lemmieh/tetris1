﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverManager : MonoBehaviour {

	public void PlayAgain () {
		Application.LoadLevel ("Tetris");
	}
}
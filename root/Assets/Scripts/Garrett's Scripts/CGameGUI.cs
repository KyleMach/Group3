﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CGameGUI : MonoBehaviour {
    [SerializeField]
    private Text health;
    [SerializeField]
    private Text monstersKilled;
    [SerializeField]
    private Text pickupTimer;
    private CScoreData scoreKeeper;

    void Awake()
    {
        scoreKeeper = GameObject.FindGameObjectWithTag("ScoreKeeper").GetComponent<CScoreData>();
    }
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        health.text ="Health: " + scoreKeeper.playerHealth;
        monstersKilled.text = "Monsters Killed: " + scoreKeeper.monstersKilled;
        pickupTimer.text = "Pickup Timer: " + scoreKeeper.pickupTimer;
    }

}

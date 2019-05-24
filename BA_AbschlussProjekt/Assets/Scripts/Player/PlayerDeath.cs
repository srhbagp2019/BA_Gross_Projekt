﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public delegate void PlayerDeathEvent();
    public static PlayerDeathEvent playerDeath;

    private void KillPlayer()
    {
        Destroy(gameObject); //TODO implement neat player death
    }

    private void OnEnable()
    {
        playerDeath += KillPlayer;
    }

    private void OnDisable()
    {
        playerDeath -= KillPlayer;
    }
}
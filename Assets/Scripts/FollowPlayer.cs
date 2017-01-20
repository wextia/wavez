﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {
    [SerializeField]
    float speed = 5;
    [SerializeField]
    float stunDuration = 2;
    bool paused = false;

	void Update () {
        if (paused)
            return;
        Vector2 playerPos = PlayerController.Instance.PlayerPos;
        transform.position = Vector2.MoveTowards(transform.position, playerPos, speed * Time.deltaTime);
    }

    public void PauseBehaviour()
    {
        paused = true;
    }

    public void ResumeBehaviour()
    {
        paused = false;
    }


}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diamond : PickUp
{
    public int points = 5;
    public override void Picked()
    {
        GameManager.gameManager.AddPoints(points);
        base.Picked();
    }

    private void Update()
    {
        Rotation();
    }
}

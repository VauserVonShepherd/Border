﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : Damageable {
    public override void TakeDamage(int damage)
    {
        base.TakeDamage(damage);
    }

    public override void Die()
    {
        base.Die();
    }
}

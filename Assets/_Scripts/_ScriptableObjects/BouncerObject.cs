using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Bounce", menuName = "PinGame/Bouncer", order = 1)]
public class BouncerObject : ScriptableObject
{
    public int score;
    public float bounceForce;
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAIAttacking : MonoBehaviour
{
    public Transform Defender;
    public Transform Attacker;
    public Transform Ball;
    public Rigidbody2D rbBall;
    public Rigidbody2D rbDefender;
    private float hitspeed = 10f, shootspeed = 20f;
    public float horispeed = 10f, verspeed = 10f;
    public float stopDistance = 0.1f; // Adjust this value
    public float proportionalGain = 1f; // Proportional control gain
    public float derivativeGain = 1f; // Derivative control gain
    private Vector3 prevErrorDefender = Vector3.zero;
    private Vector3 prevErrorAttacker = Vector3.zero;

    void Update()
    {
        if (Defender.position.x <= 0.5f)
        {
            Defender.position = new Vector3(Defender.position.x + 0.2f, Defender.position.y, 0f);
        }
        else if (Defender.position.x >= 6f)
        {
            Defender.position = new Vector3(Defender.position.x - 0.2f, Defender.position.y, 0f);
        }
        if (Attacker.position.x <= 7f)
        {
            Attacker.position = new Vector3(Attacker.position.x + 0.2f, Attacker.position.y, 0f);
        }

        Vector3 ballPosition = Ball.position;
        Vector3 defenderPosition = Defender.position;
        Vector3 attackerPosition = Attacker.position;

        Vector3 errorDefender = ballPosition - defenderPosition;
        Vector3 errorAttacker = ballPosition - attackerPosition;

        Vector3 dErrorDefender = (errorDefender - prevErrorDefender) / Time.deltaTime;
        Vector3 dErrorAttacker = (errorAttacker - prevErrorAttacker) / Time.deltaTime;

        Vector3 controlDefender = proportionalGain * errorDefender + derivativeGain * dErrorDefender;
        Vector3 controlAttacker = proportionalGain * errorAttacker + derivativeGain * dErrorAttacker;

        prevErrorDefender = errorDefender;
        prevErrorAttacker = errorAttacker;

        // Apply control to Defender
        if (isnotwithIt(Defender))
        {
            Defender.transform.position += controlDefender * Time.deltaTime;
        }

        // Apply control to Attacker
        if (isnotwithIt(Attacker))
        {
            Attacker.transform.position += controlAttacker * Time.deltaTime;
        }

        if (!isnotwithIt(Defender))
        {
            pass();
        }
        if (!isnotwithIt(Attacker))
        {
            shoot();
        }
    }

    bool isnotwithIt(Transform enemy)
    {
        return (Ball.position - enemy.position).sqrMagnitude > stopDistance * stopDistance;
    }

    void pass()
    {
        Vector3 dir = (Defender.position - Attacker.position).normalized;
        rbBall.velocity = dir * hitspeed;
    }

    void shoot()
    {
        Vector3 shootdir = (new Vector3(-9.5f, 0f, 0f) - Attacker.position).normalized;
        rbBall.velocity = shootdir * shootspeed;
    }
}

  using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDB : MonoBehaviour
{
    [SerializeField]
    private float health = 1f;
    [SerializeField]
    private float speed = 10f;
    [SerializeField]
    private float jump = 15f;
    [SerializeField]
    private int coinAmount = 0;
    [SerializeField]
    private bool isGround = false;
    public float getSpeed() {
        return this.speed;
    }
    public float getHealth()
    {
        return this.health;
    }
    public float getJump()
    {
        return this.jump;
    }

    public bool getisGround() {
        return this.isGround;
    }
    public void setisGround(bool isGround) {
        this.isGround = isGround;
    }

    public int getCoinAmount()
    {
        return this.coinAmount;
    }
    public void setCoinAmount(int coinAmount)
    {
        this.coinAmount = coinAmount;
    }

}

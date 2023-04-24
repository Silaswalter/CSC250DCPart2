using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class DeathMatch
{
    private Inhabitant dude1;
    private Inhabitant dude2;
    private GameObject dude1GO;
    private GameObject dude2GO;
    private Rigidbody rbDude1;
    private Rigidbody rbDude2;
    private bool dude1alive = true;
    private bool dude2alive = true;
    private int isTurn;


    public DeathMatch(Inhabitant dude1, Inhabitant dude2, GameObject dude1GO, GameObject dude2GO)
    {
        this.dude1 = dude1;
        this.dude2 = dude2;
        this.dude1GO = dude1GO;
        this.dude2GO = dude2GO;
        this.rbDude1 = this.dude1GO.GetComponent<Rigidbody>();
        this.rbDude2 = this.dude2GO.GetComponent<Rigidbody>();
        this.isTurn = 1;
    }

    public string fight()
    {
        System.Random r = new System.Random();
        string dialogue = "";
        if(this.dude2.getHp() <= 0)
        {
            MasterData.fightStillGoing = false;
            this.dude2GO.SetActive(false);
            return this.dude2.getName() + " Has fallen";
        }
        else if(this.dude1.getHp() <= 0)
        {
            MasterData.fightStillGoing = false;
            this.dude1GO.SetActive(false);
            return this.dude1.getName() + " Has fallen";
        }
        
        if(this.isTurn == 1)
        {
            this.rbDude1.AddForce(this.dude2GO.transform.position * 20.0f);
            if(this.dude2.Ac <= r.Next(1, 20))
            {
                dialogue = this.dude1.getName() + " attacked for " + this.dude1.getDamage();
                dude2.changeHp(this.dude2.getHp(), this.dude1.getDamage());
            }
            else
            {
                dialogue = this.dude1.getName() + "failed";
            }
            this.isTurn = 2;
        }
        else
        {
            this.rbDude2.AddForce(this.dude1GO.transform.position * 20.0f);
            if(this.dude1.Ac <= r.Next(1, 20))
            {
                dialogue = this.dude2.getName() + " attacked for " + this.dude2.getDamage();
                dude1.changeHp(this.dude1.getHp(), this.dude2.getDamage());
            }
            else
            {
                dialogue = this.dude1.getName() + "failed";
            }
            this.isTurn = 1;
        }
        
        return dialogue;
        
        

        
    }
    
    /*public void player2Attack()
    {
        if(dude2alive == true)
        {
        System.Random r = new System.Random();
        if(this.dude1.getAc() < r.Next(1, 20))
        {
            dude1.changeHp(this.dude1.getHp(), this.dude2.getDamage());
        }
        }

        if(this.dude2.getAc() < r.Next(1, 20))
        {
            dude2.changeHp(this.dude2.getHp(), this.dude1.getDamage());
        }
        
        

      
        System.Random r = new System.Random();
        if(this.dude1.getAc() < r.Next(1, 20))
        {
            dude1.changeHp(this.dude1.getHp(), this.dude2.getDamage());
        }

    }*/
}
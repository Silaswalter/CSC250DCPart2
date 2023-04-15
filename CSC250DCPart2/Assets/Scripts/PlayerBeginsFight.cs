using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class PlayerBeginsFight : MonoBehaviour
{
    public TextMeshProUGUI playerStats;
    public TextMeshProUGUI monster1Stats;
    public TextMeshProUGUI monster2Stats;
    /*public int playerHP;
    public int playerDF;
    public int playerAT;
    public int monsterHP;
    public int monsterDF;
    public int monsterAT;*/
    // Start is called before the first frame update
    void Start()
    {
    int playerHP = Random.Range(10, 20);
    int playerDF = Random.Range(10, 17);
    int playerAT = Random.Range(1, 5);
    
    int monster1HP = Random.Range(10, 20);
    int monster1DF = Random.Range(10, 17);
    int monster1AT = Random.Range(1, 5);
    
    int monster2HP = Random.Range(10, 20);
    int monster2DF = Random.Range(10, 17);
    int monster2AT = Random.Range(1, 5);
    
    this.playerStats.text = "Player stats: " + "HP " + playerHP + ":       " + "DF " + playerDF + ":      " + "AT " + playerAT + ":";
    this.monster1Stats.text = "Monster 1 stats: " + "HP " + monster1HP + ":             " + "DF " + monster1DF + ":                 " + "AT " + monster1AT + ":";
    this.monster2Stats.text = "Monster 2 stats: " + "HP " + monster2HP + ":             " + "DF " + monster2DF + ":                 " + "AT " + monster2AT + ":";
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

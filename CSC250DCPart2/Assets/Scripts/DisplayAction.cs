/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Threading;

public class DisplayAction : MonoBehaviour
{
    
    public TextMeshProUGUI playerAc, playerHp, playerDamage, monsterAc, monsterAc, monsterDamage;
    public GameObject playerStart;
    public GameObject monsterStart;
    public TextMeshProUGUI BattleStatus;
    protected bool j;
    private Monster theMonster;
    // Start is called before the first frame update
    void Start()
    {
        this.theMonster = new Monster("goblin");
        this.j = true;
        this.monsterAc.text = "Monster AC " + this.theMonster.getAc();
        this.monsterHp.text = "Monster HP " + this.theMonster.getHp();
        this.monsterDamage.text = "Monster Damage " + this.theMonster.getDamge();
        this.playerAc.text = "Player AC " + MasterData.p.getAc();
        this.playerHp.text = "Player HP " + MasterData.p.getHp();
        this.playerDamage.text = "Player Damage " + MasterData.p.getDamage();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
*/
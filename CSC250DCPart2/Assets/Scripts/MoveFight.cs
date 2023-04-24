using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoveFight : MonoBehaviour
{
    private Rigidbody rb;
    public GameObject start;
    public Vector3 startFrom;
    public Quaternion flip;
    public bool goes;
    //public TextMeshProUGI BattleStatus;
    
    // Start is called before the first frame update
    void Start()
    {
        this.rb = this.GetComponent<Rigidbody();
        this.startFrom = this.transform.position;
        this.flip = this.transform.rotation;
        this.goes = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Attack Direction"))
        {
            this.rb.angularVelocity = Vector3.zero;
            this.rb.velocity = Vector3.zero;
            this.rb.AddForce(this.origin.transform.position * 25.0f);
            this.goes = false;
        }
        if(other.gameObject.CompareTag("start") && goes)
        {
            this.rb.angularVelocity = Vector3.zero;
            this.rb.velocity = Vector3.zero;
            this.transform.rotation = this.flip;
            this.transform.position = this.startFrom;
            if(MasterData.fightStillGoing)
            {
                this.BattleStatus.text = MasterData.d.fight();
            }
        }
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}

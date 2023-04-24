using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveInFight : MonoBehaviour
{
    private Rigidbody rb;
    public GameObject MonsterBacking, MonsterAttackDirection;
    public GameObject PlayerBacking, PlayerAttackDirection;
    public float movementSpeed = 40.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Attack Direction"))
        {
            this.rb.velocity = Vector3.zero;
            this.rb.Sleep();
            //this.rb.angularVelocity = Vector3.zero;
        }
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}

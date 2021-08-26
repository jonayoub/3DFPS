using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost : Pickup
{
    public float speedAmount = 100;

    public override void DoOnPickup(Collider collision)
    {
        if (collision.tag == "Player")
        {
            PlayerController moveSpeed = collision.gameObject.GetComponent<PlayerController>();

            moveSpeed.newMovement(speedAmount);
            
        }
        //Destroy(this.gameObject);
        base.DoOnPickup(collision);
    }



    // // Start is called before the first frame update
    //  private void OnTriggerEnter2D(Collider2D collision)
    // {
    //     //  Only Heal if Collidiing with the player. 
    //     if(collision.tag == "Player")
    //     {
    //         PlayerController moveSpeed = collision.gameObject.GetComponent<PlayerController>();

    //         moveSpeed.newMovement(speedAmount);
            
    //         Destroy(this.gameObject);
    //     }

    // }
}

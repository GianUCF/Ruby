using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Jamal
public class SpeedCollectible : MonoBehaviour
{
    public AudioClip collectedClip;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>();

        if (controller != null)
        {
          
                controller.ChangeSpeed(8);
                Destroy(gameObject);
            
                controller.PlaySound(collectedClip);
            
        }

    }
}

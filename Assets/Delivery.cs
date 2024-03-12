using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] float destroyDelay = 0.5f;
    [SerializeField] Color32 hasPassengerColor = new Color32 (1, 1, 1, 1);
    [SerializeField] Color32 noPassengerColor = new Color32 (1, 1, 1, 1);
    bool hasPassenger = false;

    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    

    void OnTriggerEnter2D(Collider2D other)
    {
            if (other.tag =="Passenger" && !hasPassenger )
            {
                Debug.Log("Passenger Picked Up");
                hasPassenger = true;
                spriteRenderer.color = hasPassengerColor;
                Destroy(other.gameObject, destroyDelay);
            }
           
            if (other.tag == "DeliverySpot" && hasPassenger)
            {
                Debug.Log("Passenger Delivered");
                hasPassenger = false;
                spriteRenderer.color = noPassengerColor;
            }
    }

}

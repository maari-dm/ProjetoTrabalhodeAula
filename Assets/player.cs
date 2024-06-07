using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{public float Speed;
public float JumForce;

pivate Rigidbody2D rig;

    // Start is called before the first frame update
    void Start()
    {rig = GetComponent<rigidbody2D>();

        
    }

    // Update is called once per frame
    void Update()
    {rig.velocity = new Vector2(speed, rig.velocity.y);
        
    }
}

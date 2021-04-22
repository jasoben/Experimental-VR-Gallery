using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class PlayerMover : MonoBehaviour
{
    public SteamVR_Input_Sources hand;
    public float moveCoefficient;

    Vector2 direction;
    Vector3 remappedDirection;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (SteamVR_Actions.default_Move.GetChanged(hand))
        {
            direction = SteamVR_Actions.default_Move.GetAxis(hand);

            remappedDirection.x = direction.x;
            remappedDirection.z = direction.y;

            gameObject.transform.Translate(remappedDirection * moveCoefficient);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class ShowHead : MonoBehaviour
{
    public SteamVR_Input_Sources hand;

    public GameObject headModel, viewer;

    Quaternion headRotation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (SteamVR_Actions.default_ReorientBody.GetStateDown(hand))
        {
            headModel.SetActive(true);
        }
        if (SteamVR_Actions.default_ReorientBody.GetStateUp(hand))
        {
            headRotation = Quaternion.Euler(headModel.transform.rotation.eulerAngles);
            Debug.Log(headRotation.eulerAngles);
            viewer.transform.rotation = headRotation;
            headModel.SetActive(false);
        }
        
    }
}

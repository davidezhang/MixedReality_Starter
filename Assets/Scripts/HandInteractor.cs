using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandInteractor : MonoBehaviour
{
    public OVRHand hand;
    public GameObject pen;

    private bool isPinching = false;



    // Start is called before the first frame update
    void Start()
    {
        pen.GetComponent<TrailRenderer>().emitting = false;
    }

    // Update is called once per frame
    void Update()
    {
        checkPinching(OVRHand.HandFinger.Index);

        pen.GetComponent<TrailRenderer>().emitting = isPinching;

    }

    private void checkPinching(OVRHand.HandFinger finger)
    {
        isPinching = hand.GetFingerIsPinching(finger);
    }

}

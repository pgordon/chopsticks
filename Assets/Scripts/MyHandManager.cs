using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyHandManager : MonoBehaviour
{
    [SerializeField] Hand leftHand;
    [SerializeField] Hand rightHand;


    // Start is called before the first frame update
    void Start()
    {
        if(leftHand.GetNumberOfFingers() == 0)
            leftHand.TransferFingers(1);
        if(rightHand.GetNumberOfFingers() == 0)
            rightHand.TransferFingers(1);
    }

    public void HandleHandLoss()
    {
        if(leftHand.GetNumberOfFingers() == 0 && rightHand.GetNumberOfFingers()==0)
        {
            //this player has lost
            //Game over
            Debug.Log($"GAME OVER this person lost:{gameObject.name}");
            GameManager.instance.GameOver(this);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

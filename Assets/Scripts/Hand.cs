using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Hand : MonoBehaviour
{
    int fingers;
    MyHandManager handManager;
    [SerializeField] bool opponent;
    [SerializeField] Button button;
    [SerializeField] TextMeshProUGUI display;

    private void Start()
    {
        handManager = transform.parent.GetComponent<MyHandManager>();
        button.onClick.AddListener(delegate { TransferFingers(1); }) ;
    }

    public int GetNumberOfFingers()
    {
        return fingers;
    }

    public void TransferFingers(int numberOfFingers)
    {
        // must be between 1 and 4
        fingers += numberOfFingers;

        if(fingers == 5)
        {
            fingers = 0;
            Debug.Log("This hand is out");
            handManager.HandleHandLoss();
            if(opponent)
            {
                button.interactable = false;
            }
            
        }

        display.SetText($"{fingers}");

    }
}

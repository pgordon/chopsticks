using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Hand : MonoBehaviour
{
    int fingers;
    [SerializeField] bool opponent;
    [SerializeField] Button button;
    [SerializeField] TextMeshProUGUI display;

    private void Start()
    {
        button.onClick.AddListener(delegate { TransferFingers(1); }) ;
    }

    public void TransferFingers(int numberOfFingers)
    {
        // must be between 1 and 4
        fingers += numberOfFingers;

        if(fingers == 5)
        {
            fingers = 0;
            Debug.Log("This hand is out");
            if(opponent)
            {
                button.interactable = false;
            }
            
        }

        display.SetText($"{fingers}");

    }
}

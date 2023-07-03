using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] AIPlayer opponent;
    [SerializeField] MyHandManager player;

    [SerializeField] Text outcome;

    public static GameManager instance;
    private void Awake()
    {
        if (instance == null)
        { instance = this; }
    }

    public void GameOver(MyHandManager player)
    {
        outcome.text = $"{player.gameObject.name} has lost!";
        outcome.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

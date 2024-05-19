using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameController : MonoBehaviour
{
    [SerializeField]
    private Panel _panel;
    [SerializeField]
    private Statistics statistics;
    private bool _isGameOver;
    public bool GetIsGameOver => _isGameOver;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetWinner(CellStatus winner)
    {
        _isGameOver = true;
        _panel.OpenPanel();
        statistics.SaveWinner(winner);
        statistics.DisplayText();
    }
}
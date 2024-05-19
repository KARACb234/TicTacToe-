using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Statistics : MonoBehaviour
{
    private int crossWinCount;
    private int circleWinCount;
    private int drawWinCount;
    [SerializeField]
    private TextMeshProUGUI winnerText;
    [SerializeField]
    private TextMeshProUGUI statisticText;
    void Start()
    {
        crossWinCount = PlayerPrefs.GetInt("CROSS");
        circleWinCount = PlayerPrefs.GetInt("CIRCLE");
        drawWinCount = PlayerPrefs.GetInt("DRAW");
    }
    public void DisplayText()
    {
        statisticText.text = "Cross's Wins - " + crossWinCount + "\n" + "Circle's Wins - " + circleWinCount + "\n" + "Draw - " + drawWinCount;
    }

    public void DisplayText(CellStatus winner)
    {
        winnerText.text = "Winer: " + winner;
        statisticText.text = "Cross's Wins - " + crossWinCount + "\n" + "Circle's Wins - " + circleWinCount + "\n" + "Draw - " + drawWinCount;
    }

    public void SaveWinner(CellStatus winner)
    {
        if (winner == CellStatus.Cross)
        {
            crossWinCount++;
            PlayerPrefs.SetInt("CROSS", crossWinCount);
        }
        if (winner == CellStatus.Circle)
        {
            circleWinCount++;
            PlayerPrefs.SetInt("CIRCLE", circleWinCount);
        }
        if (winner == CellStatus.None)
        {
            drawWinCount++;
            PlayerPrefs.SetInt("DRAW", drawWinCount);
        }
        PlayerPrefs.Save();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private CellStatus _nextCellStatus = CellStatus.Cross;
    private CellStatus[,] _board = new CellStatus[3, 3];
    public CellStatus[,] GetBoard => _board;
    [SerializeField]
    private Statistics _statistics;
    [SerializeField]
    private EndGameController endGameController;
    [SerializeField]
    private LineController lineController;
    [SerializeField]
    private CellController[] _cells;
    public CellController[] GetCells => _cells;
    [SerializeField]
    private AIBot bot;


    // Update is called once per frame
    public void UpdateNextCellStatus(CellStatus currentCellStatus)
    {
        if(currentCellStatus == CellStatus.Cross)
        {
            _nextCellStatus = CellStatus.Circle;
        }
        if (currentCellStatus == CellStatus.Circle)
        {
            _nextCellStatus = CellStatus.Cross;
        }
    }
    public CellStatus GetNextCellStatus()
    {
        return _nextCellStatus;
    }
 
    bool CheckForWinner(CellStatus player)
    {
        for (int i = 0; i < 3; i++)
        {
            if (_board[i, 0] == player && _board[i, 1] == player && _board[i, 2] == player) // Проверка строк
            {
                lineController.OpenHorizontalLine(i);
                return true;
            }
            if (_board[0, i] == player && _board[1, i] == player && _board[2, i] == player) // Проверка столбцов
            {
                lineController.OpenVerticalLine(i);
                return true;
            }
        }
        if (_board[0, 0] == player && _board[1, 1] == player && _board[2, 2] == player)
        {
            lineController.OpenDiagonalLine(0);
            return true;
        }            // Проверка диагоналей


        if (_board[0, 2] == player && _board[1, 1] == player && _board[2, 0] == player)
        {
            lineController.OpenDiagonalLine(1);
            return true;
        }
        return false;
    }

    bool IsBoardFull()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (_board[i, j] == CellStatus.None)
                    return false;
            }
        }
        return true;
    }

    public void SetCellStatus(int row, int col, CellStatus cellStatus)
    {
        if (_board[row, col] == CellStatus.None) 
        {
            _board[row, col] = cellStatus;
            if(CheckForWinner(cellStatus) == true)
            {
                endGameController.SetWinner(cellStatus);
            }
            else if (IsBoardFull())
            {
                endGameController.SetWinner(CellStatus.None);
            }
            else
            {
                if(cellStatus == CellStatus.Cross)
                {
                    bot.Move();


                }
            }
        }

    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void GoMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}

public enum CellStatus
{
    None,
    Cross,
    Circle
}

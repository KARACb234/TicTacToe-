using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private CellStatus _nextCellStatus;
    private CellStatus[,] _board = new CellStatus[3, 3];
    void Start()
    {
        
    }

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
        if (currentCellStatus == CellStatus.None)
        {
            _nextCellStatus = CellStatus.Cross;
        }
    }
    public CellStatus GetNextCellStatus()
    {
        return _nextCellStatus;
    }
    public void CheckWin()
    {
    Debug.Log(_board[0, 0]);
        //проверка строк
        for(int row  = 0; row < 3; row++)
        {
            if(_board[row, 0] == CellStatus.Cross &&
                _board[row, 1] == CellStatus.Cross &&
                _board[row, 2] == CellStatus.Cross)
            {
                WinCross();
            }

        }
        for (int row = 0; row < 3; row++)
        {
            if (_board[row, 0] == CellStatus.Circle &&
                _board[row, 1] == CellStatus.Circle &&
                _board[row, 2] == CellStatus.Circle)
            {
                WinCircle();
            }
        }
        //проверка столбцов
        for (int col = 0; col < 3; col++)
        {
            if (_board[col, 0] == CellStatus.Cross &&
                _board[col, 1] == CellStatus.Cross &&
                _board[col, 2] == CellStatus.Cross)
            {
                WinCross();
            }

        }
        for (int col = 0; col < 3; col++)
        {
            if (_board[col, 0] == CellStatus.Circle &&
                _board[col, 1] == CellStatus.Circle &&
                _board[col, 2] == CellStatus.Circle)
            {
                WinCircle();
            }
        }

    }
    public void SetCellStatus(int row, int col, CellStatus cellStatus)
    {
        _board[row, col] = cellStatus;
    }
    private void WinCircle()
    {
        Debug.Log("Win Circle");
    }
    private void WinCross()
    {
        Debug.Log("Win Cross");
    }
    private void Draft()
    {

    }
}

public enum CellStatus
{
    None,
    Cross,
    Circle
}

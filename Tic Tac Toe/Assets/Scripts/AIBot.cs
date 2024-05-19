using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIBot : MonoBehaviour
{
    [SerializeField]
    private GameManager gameManager;

    public void Move()
    {
        CellStatus[,] boards = gameManager.GetBoard;
        CellController[] cells = gameManager.GetCells;
        List<CellController> emptyCells = new List<CellController>();
        for (int i = 0; i < 3; i++)
        {
            for(int j = 0; j < 3; j++)
            {
                if(boards[i,j] == CellStatus.None)
                {
                    foreach(CellController cell in cells)
                    {
                        if (cell.IsSuitable(j, i))
                        {
                            emptyCells.Add(cell);
                        }
                    }
                }
            }
        }
        CellController nextMove = GetBestChoise(emptyCells.ToArray());
        nextMove.SetCurrentCellStatus();


    }
     public CellController GetBestChoise(CellController[] empryCells)
     {
        int randomIndex = Random.Range(0, empryCells.Length);
        return empryCells[randomIndex];
     }

}

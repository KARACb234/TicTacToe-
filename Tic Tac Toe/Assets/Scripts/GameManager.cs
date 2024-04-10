using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private CellStatus _cellStatus;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public CellStatus GetNextCellStatus()
    {
        if(_cellStatus == CellStatus.None)
        {
            return CellStatus.Cross;
        }
        if (_cellStatus == CellStatus.Cross)
        {
            return CellStatus.Circle;
        }
        if (_cellStatus == CellStatus.Circle)
        {
            return CellStatus.Cross;
        }
        return _cellStatus;
    }
}

public enum CellStatus
{
    None,
    Cross,
    Circle
}

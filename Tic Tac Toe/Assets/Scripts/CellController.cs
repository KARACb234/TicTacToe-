using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellController : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer;
    [SerializeField]
    private Sprite[] _sprites;
    [SerializeField]
    private GameManager _gameManager;
    private CellStatus _currentCellStatus;
    [SerializeField]
    private int col;
    [SerializeField]
    private int row;
    [SerializeField]
    private EndGameController _endGameController;
    // Start is called before the first frame update
    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        
        if (_currentCellStatus == CellStatus.None && _endGameController.GetIsGameOver ==  false)
        {
            SetCurrentCellStatus();
        }
    }

    public void SetCurrentCellStatus()
    {
        CellStatus nextCellStatus = _gameManager.GetNextCellStatus();
        if (nextCellStatus == CellStatus.Circle)
        {
            _spriteRenderer.sprite = _sprites[1];
        }
        if (nextCellStatus == CellStatus.Cross)
        {
            _spriteRenderer.sprite = _sprites[0];
        }
        _gameManager.UpdateNextCellStatus(nextCellStatus);
        _currentCellStatus = nextCellStatus;
        _gameManager.SetCellStatus(row, col, _currentCellStatus);
    }
    public bool IsSuitable(int col, int row)
    {
        if (this.col == col && this.row == row)
        {
            return true;
        }
        else
        {
            return false;
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineController : MonoBehaviour
{
    [SerializeField]
    private GameObject[] _verticalLines;
    [SerializeField]
    private GameObject[] _horizontalLines;
    [SerializeField]
    private GameObject[] _diagonalLines;
    public void OpenHorizontalLine(int lineNumber)
    {
        _horizontalLines[lineNumber].SetActive(true);
    }

    public void OpenVerticalLine(int lineNumber)
    {
        _verticalLines[lineNumber].SetActive(true);
    }
    public void OpenDiagonalLine(int lineNumber)
    {
        _diagonalLines[lineNumber].SetActive(true);
    }
}

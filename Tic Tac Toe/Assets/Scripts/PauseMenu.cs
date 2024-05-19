using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [SerializeField]
    private GameObject exitCanvas;
    [SerializeField]
    private Collider2D[] _trigerColliders;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            OpenPanel();
        }
 
    }
private void OpenPanel()
    {
        exitCanvas.SetActive(true);
        SetTrigerActive(false);
    }
    public void ClosePanel()
    {
        exitCanvas.SetActive(false);
        SetTrigerActive(true);
    }
    private void SetTrigerActive(bool isActive)
    {
        foreach (Collider2D triger in _trigerColliders)
        {
            triger.enabled = isActive;
        }
    }
}

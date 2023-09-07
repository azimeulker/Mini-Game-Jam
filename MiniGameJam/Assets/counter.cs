using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class counter : MonoBehaviour
{
    [SerializeField] private GameObject lockPuzzle;
    public int objectCounter;

    void Start()
    {
        lockPuzzle.SetActive(false);
        objectCounter = 0;
    }

    public void AddToCounter()
    {
        objectCounter++;
    }

    private void Update()
    {
        if (objectCounter == 4)
        {
            lockPuzzle.SetActive(true);
        }
    }

    public void LoadLockPuzzle()
    {
        SceneManager.LoadScene("scene1_lp");
    }
}

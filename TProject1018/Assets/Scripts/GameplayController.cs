using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayController : MonoBehaviour
{
    public static GameplayController Instance;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
    }

    void Start()
    {

    }

    void Update()
    {
        
    }

    private void OnDestroy()
    {
        Instance = null;
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using Script.Enum;
using UnityEngine;

public class BaseGameController : MonoBehaviour
{
    private static BaseGameController _instance;

    public static BaseGameController Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new BaseGameController();
            }

            return _instance;
        }
    }
    private BaseGameController() {}
    private EGameState _gameState;

    public EGameState GameState
    {
        get { return _gameState;}
        set
        {
            _gameState = value;
            switch (_gameState)
            {
                case EGameState.Win:
                    break;
                case EGameState.Lose:
                    break;
                case EGameState.Draw:
                    break;
            }
        }
    }
    private void Start()
    {
        GameState = EGameState.Win;
    }
}

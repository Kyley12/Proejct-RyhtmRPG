using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBattleSystem : MonoBehaviour
{
    private PlayerAction playerAction;
    private float keyPressDuration = 0f;
    private bool isKeyPressed = false;
    private float attackGroggyTime = 1f;
    private float attackCounterTime = 1f;
    private bool attackChance = true;
    private int attackCount = 0;

    void Start()
    {
        
    }

    void Update()
    {
        
    }
    void Awake()
    {
        playerAction = new PlayerAction();
    }

    void OnEnable()
    {
        playerAction.Enable();
        playerAction.PlayerActions.Attack.performed += 
    }

    void OnDisable()
    {
        playerAction.Disable();
    }

    void Attack()
    {
        keyPressDuration += Time.deltaTimte;
    }
}

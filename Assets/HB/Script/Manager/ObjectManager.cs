using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    [Header("��ƼŬ")]
    public GameObject ground_EffectPrb;
    public GameObject spawn_EffectPrb;
    public GameObject roar_EffectPrb;

    [Header("�ȷο�Ĺ&�ڷ���Ʈ ��ƼŬ")]
    public GameObject followCatPrb;
    public GameObject teleportPrb;

    [Header("���Ÿ� ����")]
    public GameObject snakeAttackPrb;
    public GameObject flowerAttackPrb;

    public GameObject bossAAttack_1Prb; //���Ÿ� ����

    [Header("���Ϲ�")]
    public GameObject debrisAPrb;
    public GameObject debrisBPrb;
    public GameObject debrisCPrb;

    [Header("����")]
    public GameObject bossAPrb;
    public GameObject elitePrb;

    public GameObject mousePrb;
    public GameObject snakePrb;

    [Header("������")]
    public GameObject goldPrb;
    public GameObject silverPrb;
    public GameObject bronzePrb;
    public GameObject itemBoxPrb;


    [Header("�ھ�")]
    public GameObject rollCorePrb;
    public GameObject summonCorePrb;
    public GameObject dropCorePrb;

    public GameObject stateCorePrb;

    GameObject[] ground_Effect;
    GameObject[] spawn_Effect;
    GameObject[] roar_Effect;

    GameObject[] followCat;
    GameObject[] teleport;

    //Attack Object
    GameObject[] snakeAttack;
    GameObject[] flowerAttack;

    GameObject[] bossAAttack_1;

    GameObject[] debrisA;
    GameObject[] debrisB;
    GameObject[] debrisC;


    //Enemy
    GameObject[] bossA;
    GameObject[] elite;

    GameObject[] mouse;
    GameObject[] snake;

    //Item
    GameObject[] gold;
    GameObject[] silver;
    GameObject[] bronze;

    GameObject[] rollCore;
    GameObject[] summonCore;
    GameObject[] dropCore;

    GameObject[] stateCore;

    GameObject[] itemBox;



    GameObject[] targetPool;

    void Awake()
    {
        ground_Effect = new GameObject[25];
        spawn_Effect = new GameObject[5];
        roar_Effect = new GameObject[5];

        followCat = new GameObject[10];
        teleport = new GameObject[10];

        snakeAttack = new GameObject[15];
        flowerAttack = new GameObject[30];

        bossAAttack_1 = new GameObject[100];

        debrisA = new GameObject[20];
        debrisB= new GameObject[20];
        debrisC = new GameObject[20];

        bossA = new GameObject[2];
        elite = new GameObject[10];

        mouse = new GameObject[10];
        snake = new GameObject[10];

        gold = new GameObject[30];
        silver = new GameObject[30];
        bronze = new GameObject[30];

        rollCore = new GameObject[1];
        summonCore = new GameObject[1];
        dropCore = new GameObject[1];

        stateCore = new GameObject[5];

        itemBox = new GameObject[15];

        Generate();
    }
    void Generate()
    {
        for (int index = 0; index < ground_Effect.Length; index++)
        {
            ground_Effect[index] = Instantiate(ground_EffectPrb);
            ground_Effect[index].SetActive(false);
        }
        for (int index = 0; index < spawn_Effect.Length; index++)
        {
            spawn_Effect[index] = Instantiate(spawn_EffectPrb);
            spawn_Effect[index].SetActive(false);
        }
        for (int index = 0; index < roar_Effect.Length; index++)
        {
            roar_Effect[index] = Instantiate(roar_EffectPrb);
            roar_Effect[index].SetActive(false);
        } 

        for (int index = 0; index < followCat.Length; index++)
        {
            followCat[index] = Instantiate(followCatPrb);
            followCat[index].SetActive(false);
        } 
        for (int index = 0; index < teleport.Length; index++)
        {
            teleport[index] = Instantiate(teleportPrb);
            teleport[index].SetActive(false);
        }

        for (int index=0;index<snakeAttack.Length;index++)
        {
            snakeAttack[index] = Instantiate(snakeAttackPrb);
            snakeAttack[index].SetActive(false);
        }
        for (int index = 0; index < flowerAttack.Length; index++)
        {
            flowerAttack[index] = Instantiate(flowerAttackPrb);
            flowerAttack[index].SetActive(false);
        }

        for (int index = 0; index < bossAAttack_1.Length; index++)
        {
            bossAAttack_1[index] = Instantiate(bossAAttack_1Prb);
            bossAAttack_1[index].SetActive(false);
        }

        for (int index = 0; index < debrisA.Length; index++)
        {
            debrisA[index] = Instantiate(debrisAPrb);
            debrisA[index].SetActive(false);
        }
        for (int index = 0; index < debrisB.Length; index++)
        {
            debrisB[index] = Instantiate(debrisBPrb);
            debrisB[index].SetActive(false);
        }
        for (int index = 0; index < debrisC.Length; index++)
        {
            debrisC[index] = Instantiate(debrisCPrb);
            debrisC[index].SetActive(false);
        }

        for (int index = 0; index < bossA.Length; index++)
        {
            bossA[index] = Instantiate(bossAPrb);
            bossA[index].SetActive(false);
        } 
        for (int index = 0; index < elite.Length; index++)
        {
            elite[index] = Instantiate(elitePrb);
            elite[index].SetActive(false);
        }

        for (int index = 0; index < mouse.Length; index++)
        {
            mouse[index] = Instantiate(mousePrb);
            mouse[index].SetActive(false);
        }
        for (int index = 0; index < snake.Length; index++)
        {
            snake[index] = Instantiate(snakePrb);
            snake[index].SetActive(false);
        }

        for (int index = 0; index < gold.Length; index++)
        {
            gold[index] = Instantiate(goldPrb);
            gold[index].SetActive(false);
        }
        for (int index = 0; index < silver.Length; index++)
        {
            silver[index] = Instantiate(silverPrb);
            silver[index].SetActive(false);
        }
        for (int index = 0; index < bronze.Length; index++)
        {
            bronze[index] = Instantiate(bronzePrb);
            bronze[index].SetActive(false);
        }

        for (int index = 0; index < rollCore.Length; index++)
        {
            rollCore[index] = Instantiate(rollCorePrb);
            rollCore[index].SetActive(false);
        }
        for (int index = 0; index < summonCore.Length; index++)
        {
            summonCore[index] = Instantiate(summonCorePrb);
            summonCore[index].SetActive(false);
        }
        for (int index = 0; index < dropCore.Length; index++)
        {
            dropCore[index] = Instantiate(dropCorePrb);
            dropCore[index].SetActive(false);
        }

        for (int index = 0; index < stateCore.Length; index++)
        {
            stateCore[index] = Instantiate(stateCorePrb);
            stateCore[index].SetActive(false);
        }
        for (int index = 0; index < itemBox.Length; index++)
        {
            itemBox[index] = Instantiate(itemBoxPrb);
            itemBox[index].SetActive(false);
        }
    }
    public GameObject MakeObj(string type)
    {
        switch(type)
        {
            case "ground_Effect":
                targetPool = ground_Effect;
                break;

            case "spawn_Effect":
                targetPool = spawn_Effect;
                break;
            case "roar_Effect":
                targetPool = roar_Effect;
                break;  

            case "followCat":
                targetPool = followCat;
                break; 
            case "teleport":
                targetPool = teleport;
                break;

            case "snakeAttack":
                targetPool = snakeAttack;
                break;
            case "flowerAttack":
                targetPool = flowerAttack;
                break;

            case "bossAAttack_1":
                targetPool = bossAAttack_1;
                break;

            case "debrisA":
                targetPool = debrisA;
                break;
            case "debrisB":
                targetPool = debrisB;
                break;
            case "debrisC":
                targetPool = debrisC;
                break;

            case "bossA":
                targetPool = bossA;
                break;
            case "elite":
                targetPool = elite;
                break;

            case "mouse":
                targetPool = mouse;
                break;
            case "snake":
                targetPool = snake;
                break;

            case "gold":
                targetPool = gold;
                break;
            case "silver":
                targetPool = silver;
                break;
            case "bronze":
                targetPool = bronze;
                break;

            case "rollCore":
                targetPool = rollCore;
                break;
            case "summonCore":
                targetPool = summonCore;
                break;
            case "dropCore":
                targetPool = dropCore;
                break;

            case "stateCore":
                targetPool = stateCore;
                break;

            case "itemBox":
                targetPool = itemBox;
                break;
        }
        for(int index=0;index<targetPool.Length;index++)
        {
            if(!targetPool[index].activeSelf)
            {
                targetPool[index].SetActive(true);
                return targetPool[index];
            }
        }
        return null;
    }
}
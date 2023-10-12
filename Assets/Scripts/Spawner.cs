using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform[] Spawners;

    public int index = 0;
    float timer;

    private void Awake()
    {
        Spawners = GetComponentsInChildren<Transform>();
    }
    private void Update()
    {
        timer += Time.deltaTime;
        if(timer > 1f)
        {
            CreateMonster();
            timer = 0;
        }
    }

    void CreateMonster()
    {
        GameObject enemy = GameManager.Instance.Pool.Get(index);
        enemy.transform.position = Spawners[Random.Range(1, Spawners.Length)].position;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
    public GameObject[] Prefabs;
    List <GameObject>[] pools;

    private void Awake()
    {
        pools = new List<GameObject>[Prefabs.Length];

        for(int i = 0; i < pools.Length; i++)
        {
            pools[i] = new List <GameObject> ();
        }
    }

    public GameObject Get(int index)
    {
        GameObject select = null;
        foreach (GameObject enemy in pools[index])
        {
            if (!enemy.activeSelf)
            {
                select = enemy;
                select.SetActive (true);
                break;
            }
        }
        if(select == null)
        {
            select = Instantiate(Prefabs[index], transform);
            pools[index].Add (select);
        }

        return select;
    }
}

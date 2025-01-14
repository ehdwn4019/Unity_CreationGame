﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPoolingManager : MonoBehaviour
{
    //풀 생성 
    public static GameObject Create(string name, Vector3 pos, Quaternion rotation)
    {
        Object obj = Resources.Load("Prefab/Pooling/" + name);
        GameObject go = Instantiate(obj, pos, rotation) as GameObject;

        return go;
    }

    public static void Put(GameObject obj,List<GameObject> list)
    {
        list.Add(obj);
        obj.SetActive(false);
    }

    public static GameObject TakeOut(List<GameObject> list,Vector3 pos)
    {
        for(int i=0; i<list.Count; i++)
        {
            if(!list[i].activeInHierarchy)
            {
                list[i].SetActive(true);
                list[i].transform.position = pos;
                return list[i];
            }
        }

        return null;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{
    public GameObject[] element;
    public int repeat;

    [SerializeField] List<GameObject> elementList;


    void Start()
    {
        elementList = new List<GameObject>();
        int length = element.Length * repeat;
        int index = 0;
        for (int i = 0; i < length; i++)
        {
            index = i % element.Length;
            //print(index);
            CreateObject(index);
        }
    }

    public GameObject CreateObject(int idx)
    {
        GameObject go = Instantiate(element[idx], transform.position, transform.rotation);
        go.SetActive(false);
        elementList.Add(go);
        return go;
    }

    public GameObject ReturnObjectFromList()
    {
        GameObject go = null;
        if (elementList.Count > 0)
        {
            for (int i = 0; i < elementList.Count; i++)
            {
                if (!elementList[i].activeInHierarchy)
                {
                    go = elementList[i];
                }
            }
        }
        if (go == null)
        {
            go = CreateObject(0);
        }
        return go;
    }
}

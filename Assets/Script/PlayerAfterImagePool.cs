using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAfterImagePool : MonoBehaviour
{
    [SerializeField]
    private GameObject afterImagePrefab;
    private Queue<GameObject> availableObjects = new Queue<GameObject>();

    public static PlayerAfterImagePool Instance { get; private set; }

    // Start is called before the first frame update
    private void Awake()
    {
        Instance = this;
        GrowPool();
    }

    // Update is called once per frame
    private void GrowPool()
    {
        for (int i = 0; i < 10; i++)
        {
            var instanceToAdd = Instantiate(afterImagePrefab);
            instanceToAdd.transform.SetParent(transform);
            AddToPool(instanceToAdd);

        }
    }

    public void AddToPool(GameObject Instance)
    {
        Instance.SetActive(false);
        availableObjects.Enqueue(Instance);
    }

    public GameObject GetFromPool()
    {
        if(availableObjects.Count == 0)
        {
            GrowPool();
        }
        var instance = availableObjects.Dequeue();
        instance.SetActive(true);
        return instance;
    }
}

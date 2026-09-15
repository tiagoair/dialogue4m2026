using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class MoedaSpawnerController : MonoBehaviour
{
    [SerializeField] private Vector3 SpawnAreaLimit1;
    [SerializeField] private Vector3 SpawnAreaLimit2;

    
    private void Start()
    {
        InvokeRepeating("SpawnMoeda", 0f, 0.02f);
    }

    private void SpawnMoeda()
    {
        //if (MoedaPoolManager.Instance.MoedaPool.CountActive > MoedaPoolManager.Instance.maxSize) return;
        
        float randx = SpawnAreaLimit1.x+Random.Range(0f, 1f)*(SpawnAreaLimit2.x-SpawnAreaLimit1.x);
        float randz = SpawnAreaLimit1.z+Random.Range(0f, 1f)*(SpawnAreaLimit2.z-SpawnAreaLimit1.z);
        
        //Instantiate(MoedaPrefab, new Vector3(randx, 1f, randz), Quaternion.identity);
        MoedaPoolManager.Instance.MoedaPool.Get().transform.position = new Vector3(randx,2f,randz);
    }
}

using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class MoedaController : MonoBehaviour
{
    private void OnEnable()
    {
        Invoke("CollectMoeda", Random.Range(0,1f)*2f);
    }

    public void CollectMoeda()
    {
        //Destroy(gameObject);
        MoedaPoolManager.Instance.MoedaPool.Release(this);
    }
}

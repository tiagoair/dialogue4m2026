using System;
using DG.Tweening;
using UnityEngine;
using static UnityEngine.Quaternion;
using Random = UnityEngine.Random;

public class MoedaController : MonoBehaviour
{
    private void OnEnable()
    {
        Invoke("CollectMoeda", Random.Range(0,1f)*2f);
    }

    private void Update()
    {
       // transform.Rotate(Vector3.up*2);
        
    }

    public void CollectMoeda()
    {
        transform.DOPunchScale(Vector3.one*0.2f, 0.5f);
        transform.DOPunchRotation(Vector3.one * 10, 0.5f).onComplete += 
            () => MoedaPoolManager.Instance.MoedaPool.Release(this);
        //Destroy(gameObject);
        
    }
}

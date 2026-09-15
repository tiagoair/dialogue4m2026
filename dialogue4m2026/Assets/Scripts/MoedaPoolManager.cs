using System;
using UnityEngine;
using UnityEngine.Pool;

public class MoedaPoolManager : MonoBehaviour
{
    public static MoedaPoolManager Instance;
    
    public ObjectPool<MoedaController> MoedaPool;
    public GameObject MoedaPrefab;

    public int defaultCapacity = 100;
    public int maxSize = 1000;
    
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            return;
        }
        
        MoedaPool = new ObjectPool<MoedaController>(CreateMoeda, GetMoeda,
            ReleaseMoeda, DestroyMoeda, true, defaultCapacity, maxSize);
    }

    private MoedaController CreateMoeda()
    {
        GameObject moeda = Instantiate(MoedaPrefab, transform);
        return moeda.GetComponent<MoedaController>();
    }

    public void GetMoeda(MoedaController moeda)
    {
        moeda.gameObject.SetActive(true);
    }

    public void ReleaseMoeda(MoedaController moeda)
    {
        moeda.gameObject.SetActive(false);
    }

    public void DestroyMoeda(MoedaController moeda)
    {
        Destroy(moeda.gameObject);
    }
}

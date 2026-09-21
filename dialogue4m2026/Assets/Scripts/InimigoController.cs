using System.Collections.Generic;
using UnityEngine;

public class InimigoController : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    [SerializeField] private Animator inimigoSM;

    [SerializeField] private List<Transform> pontosDePatrulha;
    [SerializeField] private float velocidadeMovimento;
    
    
    public Transform PlayerTransform => playerTransform;
    public List<Transform> PontosDePatrulha => pontosDePatrulha;
    public float VelocidadeMovimento => velocidadeMovimento;
    public int indiceAtual;
    
    private float _distancia;
    
    void Update()
    {
        _distancia = Vector3.Distance(playerTransform.position, transform.position);
        inimigoSM.SetFloat("Distancia", _distancia);
    }
}

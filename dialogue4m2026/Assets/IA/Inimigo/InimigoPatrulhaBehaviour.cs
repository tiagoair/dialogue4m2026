using UnityEngine;

public class InimigoPatrulhaBehaviour : StateMachineBehaviour
{
    private InimigoController inimigo;
    private Transform pontoAtual;
    
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        inimigo = animator.gameObject.GetComponent<InimigoController>();
        pontoAtual = inimigo.PontosDePatrulha[inimigo.indiceAtual];
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (Vector3.Distance(inimigo.transform.position, pontoAtual.position) < 1)
        {
            inimigo.indiceAtual++;
            if (inimigo.indiceAtual >= inimigo.PontosDePatrulha.Count)
            {
                inimigo.indiceAtual = 0;
            }
            pontoAtual = inimigo.PontosDePatrulha[inimigo.indiceAtual];
        }
        
        inimigo.transform.position += (pontoAtual.position - inimigo.transform.position).normalized * inimigo.VelocidadeMovimento * Time.deltaTime;
    }
}

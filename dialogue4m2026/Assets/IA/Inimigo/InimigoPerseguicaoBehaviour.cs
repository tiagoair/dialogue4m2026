using UnityEngine;

namespace IA.Inimigo
{
    public class InimigoPerseguicaoBehaviour : StateMachineBehaviour
    {
        private Transform playerTransform;
        private float velocidade;
        private InimigoController inimigo;
        private Transform inimigoTransform;
        
        public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo,
            int layerIndex)
        {
            inimigo = animator.gameObject.GetComponent<InimigoController>();
            playerTransform = inimigo.PlayerTransform;
            velocidade = inimigo.VelocidadeMovimento;
            inimigoTransform = inimigo.transform;
        }

        public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo,
            int layerIndex)
        {
            inimigoTransform.position += (playerTransform.position - inimigoTransform.position).normalized * velocidade * Time.deltaTime;
        }
       
    }
}
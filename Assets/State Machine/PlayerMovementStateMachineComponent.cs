using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KevinCastejon.HierarchicalFiniteStateMachine;
namespace Player.Core.State
{
    public class PlayerMovementStateMachineComponent : MonoBehaviour
    {
        private PlayerMovementStateMachine _stateMachine;
        [Header("Dependency")]
        [SerializeField] Rigidbody Rb;
        private void Awake()
        {
            _stateMachine = AbstractHierarchicalFiniteStateMachine.CreateRootStateMachine<PlayerMovementStateMachine>("PlayerMovementStateMachine");
        }
        private void Start()
        {
            _stateMachine.OnEnter();
        }
        private void Update()
        {
            _stateMachine.OnUpdate();
        }
        private void FixedUpdate()
        {
            _stateMachine.OnFixedUpdate();
        }
    }
}

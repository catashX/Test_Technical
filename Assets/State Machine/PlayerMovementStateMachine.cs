using KevinCastejon.HierarchicalFiniteStateMachine;
namespace Player.Core.State
{
    public class PlayerMovementStateMachine : AbstractHierarchicalFiniteStateMachine
    {
        public enum PlayerMovementState
        {
            NEUTRAL,
            GROUNDED,
            HOVER
        }
        public PlayerMovementStateMachine()
        {
            Init(PlayerMovementState.NEUTRAL,
                Create<NeutralState, PlayerMovementState>(PlayerMovementState.NEUTRAL, this),
                Create<GroundedStateMachine, PlayerMovementState>(PlayerMovementState.GROUNDED, this),
                Create<HoverStateMachine, PlayerMovementState>(PlayerMovementState.HOVER, this)
            );
        }
        public override void OnExitFromSubStateMachine(AbstractHierarchicalFiniteStateMachine subStateMachine)
        {
        }
        public override void OnStateMachineEntry()
        {
        }
        public override void OnStateMachineExit()
        {
        }
        public class NeutralState : AbstractState
        {
            public override void OnEnter()
            {
            }
            public override void OnUpdate()
            {
            }
            public override void OnFixedUpdate()
            {
            }
            public override void OnExit()
            {
            }
        }
    }
}

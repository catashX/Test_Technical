using KevinCastejon.HierarchicalFiniteStateMachine;
namespace Player.Core.State
{
    public class HoverStateMachine : AbstractHierarchicalFiniteStateMachine
    {
        public enum MyState
        {
            FALLING,
            JUMPING,
            GLIDING
        }
        public HoverStateMachine()
        {
            Init(MyState.FALLING,
                Create<FallingState, MyState>(MyState.FALLING, this),
                Create<JumpingState, MyState>(MyState.JUMPING, this),
                Create<GlidingState, MyState>(MyState.GLIDING, this)
            );
        }
        public override void OnStateMachineEntry()
        {
        }
        public override void OnStateMachineExit()
        {
        }
        public class FallingState : AbstractState
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
        public class JumpingState : AbstractState
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
        public class GlidingState : AbstractState
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

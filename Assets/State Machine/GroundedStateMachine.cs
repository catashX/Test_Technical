using KevinCastejon.HierarchicalFiniteStateMachine;
namespace Player.Core.State
{
    public class GroundedStateMachine : AbstractHierarchicalFiniteStateMachine
    {
        public enum MyState
        {
            IDLE,
            WALK,
            RUN
        }
        public GroundedStateMachine()
        {
            Init(MyState.IDLE,
                Create<IdleState, MyState>(MyState.IDLE, this),
                Create<WalkState, MyState>(MyState.WALK, this),
                Create<RunState, MyState>(MyState.RUN, this)
            );
        }
        public override void OnStateMachineEntry()
        {
        }
        public override void OnStateMachineExit()
        {
        }
        public class IdleState : AbstractState
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
        public class WalkState : AbstractState
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
        public class RunState : AbstractState
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

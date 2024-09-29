using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityRigidbody2D
{
	public class SetIsKinematic : Action
	{
		public SharedGameObject targetGameObject;
		public SharedBool isKinematic;
	}
}

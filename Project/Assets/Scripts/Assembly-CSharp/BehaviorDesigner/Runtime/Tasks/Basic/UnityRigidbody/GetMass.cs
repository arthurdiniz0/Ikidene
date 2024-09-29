using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityRigidbody
{
	public class GetMass : Action
	{
		public SharedGameObject targetGameObject;
		public SharedFloat storeValue;
	}
}

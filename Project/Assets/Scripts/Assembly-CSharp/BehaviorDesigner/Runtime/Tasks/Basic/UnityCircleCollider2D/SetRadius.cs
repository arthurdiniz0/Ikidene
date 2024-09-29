using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityCircleCollider2D
{
	public class SetRadius : Action
	{
		public SharedGameObject targetGameObject;
		public SharedFloat radius;
	}
}

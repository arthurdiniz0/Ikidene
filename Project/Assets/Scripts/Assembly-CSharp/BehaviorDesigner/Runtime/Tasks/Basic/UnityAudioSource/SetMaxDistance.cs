using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityAudioSource
{
	public class SetMaxDistance : Action
	{
		public SharedGameObject targetGameObject;
		public SharedFloat maxDistance;
	}
}

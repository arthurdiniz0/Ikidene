using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityAudioSource
{
	public class PlayScheduled : Action
	{
		public SharedGameObject targetGameObject;
		public SharedFloat time;
	}
}

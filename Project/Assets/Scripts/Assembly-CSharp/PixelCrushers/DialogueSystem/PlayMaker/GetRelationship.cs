using HutongGames.PlayMaker;

namespace PixelCrushers.DialogueSystem.PlayMaker
{
	public class GetRelationship : FsmStateAction
	{
		public FsmString actor1Name;
		public FsmString actor2Name;
		public FsmString relationshipType;
		public FsmFloat storeResult;
	}
}

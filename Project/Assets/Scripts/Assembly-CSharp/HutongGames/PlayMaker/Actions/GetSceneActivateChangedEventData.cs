using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class GetSceneActivateChangedEventData : FsmStateAction
	{
		public FsmString newName;
		public FsmString newPath;
		public FsmBool newIsValid;
		public FsmInt newBuildIndex;
		public FsmBool newIsLoaded;
		public FsmBool newIsDirty;
		public FsmInt newRootCount;
		public FsmArray newRootGameObjects;
		public FsmString previousName;
		public FsmString previousPath;
		public FsmBool previousIsValid;
		public FsmInt previousBuildIndex;
		public FsmBool previousIsLoaded;
		public FsmBool previousIsDirty;
		public FsmInt previousRootCount;
		public FsmArray previousRootGameObjects;
	}
}

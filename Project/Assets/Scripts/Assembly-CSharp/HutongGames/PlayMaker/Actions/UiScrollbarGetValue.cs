using UnityEngine.UI;
using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class UiScrollbarGetValue : ComponentAction<Scrollbar>
	{
		public FsmOwnerDefault gameObject;
		public FsmFloat value;
		public bool everyFrame;
	}
}

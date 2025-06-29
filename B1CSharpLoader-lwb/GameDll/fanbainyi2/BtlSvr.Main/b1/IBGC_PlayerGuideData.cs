using System.Collections.Generic;
using GUR.Runtime;

namespace b1;

[NeedToUI]
public interface IBGC_PlayerGuideData
{
	BindListInt CheckListNodeGuideList { get; }

	BindListInt ProceedGroupGuideList { get; }

	BindListInt FinishedGroupGuideList { get; }

	bool IsGroupGuideCompleted(IList<int> InGroupGuideList);

	bool IsGroupGuideCompleted(int InGroupGuideId);
}

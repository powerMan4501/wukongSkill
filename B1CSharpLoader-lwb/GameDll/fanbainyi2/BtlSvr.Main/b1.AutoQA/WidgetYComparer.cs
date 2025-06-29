using System.Collections.Generic;
using UnrealEngine.UMG;

namespace b1.AutoQA;

internal class WidgetYComparer : IComparer<UUserWidget>
{
	public int Compare(UUserWidget A, UUserWidget B)
	{
		UGSE_UMGFuncLib.QAGetWidgetCenterPosition(A, out var WidgetPosition, out var CenterPosition, out var WidgetSize);
		UGSE_UMGFuncLib.QAGetWidgetCenterPosition(B, out WidgetSize, out var CenterPosition2, out WidgetPosition);
		if (CenterPosition.X == 0f && CenterPosition.Y == 0f)
		{
			return 1;
		}
		if (CenterPosition2.X == 0f && CenterPosition2.Y == 0f)
		{
			return -1;
		}
		return CenterPosition.Y.CompareTo(CenterPosition2.Y);
	}
}

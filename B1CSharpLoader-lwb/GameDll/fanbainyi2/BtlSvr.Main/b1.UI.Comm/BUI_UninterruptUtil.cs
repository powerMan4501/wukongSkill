using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1.UI.Comm;

[UClass]
public class BUI_UninterruptUtil
{
	[UFunction]
	public static float UninterruptUtilDecreaseValue(ref List<STBarUninterruptData> InUninterruptData, float InCurValue, float InDecreaseValue, float InConfTimeCount)
	{
		int index = ((InUninterruptData.Count == 0) ? (InUninterruptData.Count - 1) : 0);
		if (InUninterruptData.Count == 0 || 0f == InUninterruptData[index].TimeCountLeft)
		{
			InUninterruptData.Add(new STBarUninterruptData(0f, InCurValue, (InCurValue - InDecreaseValue > 0f) ? (InCurValue - InDecreaseValue) : 0f, InConfTimeCount));
			return InCurValue - ((InCurValue - InDecreaseValue > 0f) ? (InCurValue - InDecreaseValue) : 0f);
		}
		InUninterruptData[index] = new STBarUninterruptData(InUninterruptData[index].AnPlayerTime, InUninterruptData[index].RightValue, (InUninterruptData[index].LeftValue - InDecreaseValue > 0f) ? (InUninterruptData[index].LeftValue - InDecreaseValue) : 0f, InConfTimeCount);
		if (!(InUninterruptData[index].LeftValue - InUninterruptData[index].LeftValue - InDecreaseValue > 0f))
		{
			return 0f;
		}
		return InUninterruptData[index].LeftValue - InDecreaseValue;
	}

	[UFunction]
	public static void UninterruptUtilTickTime(ref List<STBarUninterruptData> InUninterruptData, float InDeltaTime)
	{
		InUninterruptData.ForEach(delegate(STBarUninterruptData element)
		{
			element.TimeCountLeft = ((element.TimeCountLeft - InDeltaTime > 0f) ? (element.TimeCountLeft - InDeltaTime) : 0f);
		});
	}

	[UFunction]
	public static void UninterruptUtilTickAnPlayTime(ref List<STBarUninterruptData> InUninterruptData, float InDeltaTime, float InAnTotalTime)
	{
		InUninterruptData.ForEach(delegate(STBarUninterruptData element)
		{
			if (element.TimeCountLeft == 0f && element.AnPlayerTime <= InAnTotalTime)
			{
				element.AnPlayerTime = ((element.AnPlayerTime + InDeltaTime < InAnTotalTime) ? (element.AnPlayerTime + InDeltaTime) : InAnTotalTime);
			}
		});
	}
}

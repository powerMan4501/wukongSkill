using System;
using UnrealEngine.Runtime;

namespace b1;

public struct HotZonePointInfo : IEquatable<HotZonePointInfo>
{
	public EGroupAIHotZoneType HotZoneIdx;

	public FVector2D RelativePos;

	public bool HasAlreadyBeenSelected;

	public static HotZonePointInfo Null => new HotZonePointInfo(EGroupAIHotZoneType.None);

	public HotZonePointInfo(EGroupAIHotZoneType _HotZoneIdx, FVector2D _RelativePos)
	{
		HotZoneIdx = _HotZoneIdx;
		RelativePos = _RelativePos;
		HasAlreadyBeenSelected = false;
	}

	private HotZonePointInfo(EGroupAIHotZoneType _HotZoneIdx)
	{
		HotZoneIdx = _HotZoneIdx;
		RelativePos = FVector2D.ZeroVector;
		HasAlreadyBeenSelected = false;
	}

	public bool Equals(HotZonePointInfo Other)
	{
		if (HotZoneIdx == Other.HotZoneIdx)
		{
			return RelativePos == Other.RelativePos;
		}
		return false;
	}

	public override bool Equals(object obj)
	{
		if (!(obj is HotZonePointInfo hotZonePointInfo))
		{
			return false;
		}
		if (HotZoneIdx == hotZonePointInfo.HotZoneIdx)
		{
			return RelativePos == hotZonePointInfo.RelativePos;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return (int)HotZoneIdx * 17 + RelativePos.GetHashCode();
	}
}

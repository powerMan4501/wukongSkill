using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

public static class URawAnimSequenceTrackExtensions_CsExtensions
{
	public static List<FVector> GetScaleKeys(this FRawAnimSequenceTrack Track)
	{
		return URawAnimSequenceTrackExtensions.GetScaleKeys(Track);
	}

	public static List<FQuat> GetRotationalKeys(this FRawAnimSequenceTrack Track)
	{
		return URawAnimSequenceTrackExtensions.GetRotationalKeys(Track);
	}

	public static List<FVector> GetPositionalKeys(this FRawAnimSequenceTrack Track)
	{
		return URawAnimSequenceTrackExtensions.GetPositionalKeys(Track);
	}
}

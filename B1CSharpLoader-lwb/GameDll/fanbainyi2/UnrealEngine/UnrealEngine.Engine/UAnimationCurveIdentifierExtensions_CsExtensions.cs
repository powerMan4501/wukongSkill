using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

public static class UAnimationCurveIdentifierExtensions_CsExtensions
{
	public static bool IsValid(this ref FAnimationCurveIdentifier Identifier)
	{
		return UAnimationCurveIdentifierExtensions.IsValid(ref Identifier);
	}

	public static ERawCurveTrackTypes GetType(this ref FAnimationCurveIdentifier Identifier)
	{
		return UAnimationCurveIdentifierExtensions.GetType(ref Identifier);
	}

	public static bool GetTransformChildCurveIdentifier(this ref FAnimationCurveIdentifier InOutIdentifier, ETransformCurveChannel Channel, EVectorCurveChannel Axis)
	{
		return UAnimationCurveIdentifierExtensions.GetTransformChildCurveIdentifier(ref InOutIdentifier, Channel, Axis);
	}

	public static FName GetName(this ref FAnimationCurveIdentifier Identifier)
	{
		return UAnimationCurveIdentifierExtensions.GetName(ref Identifier);
	}

	public static List<FAnimationCurveIdentifier> GetCurveIdentifiers(this USkeleton InSkeleton, ERawCurveTrackTypes CurveType)
	{
		return UAnimationCurveIdentifierExtensions.GetCurveIdentifiers(InSkeleton, CurveType);
	}

	public static FAnimationCurveIdentifier GetCurveIdentifier(this USkeleton InSkeleton, FName Name, ERawCurveTrackTypes CurveType)
	{
		return UAnimationCurveIdentifierExtensions.GetCurveIdentifier(InSkeleton, Name, CurveType);
	}

	public static FAnimationCurveIdentifier FindCurveIdentifier(this USkeleton InSkeleton, FName Name, ERawCurveTrackTypes CurveType)
	{
		return UAnimationCurveIdentifierExtensions.FindCurveIdentifier(InSkeleton, Name, CurveType);
	}
}

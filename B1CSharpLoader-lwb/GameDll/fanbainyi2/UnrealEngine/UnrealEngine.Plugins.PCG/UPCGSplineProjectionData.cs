using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGSplineProjectionData", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGSplineProjectionData : UPCGProjectionData
{
	private static bool ProjectedPosition_IsValid;

	private static int ProjectedPosition_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/PCG.PCGSplineProjectionData:ProjectedPosition")]
	public FInterpCurveVector2D ProjectedPosition
	{
		get
		{
			CheckDestroyed();
			if (!ProjectedPosition_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSplineProjectionData:ProjectedPosition");
				return default(FInterpCurveVector2D);
			}
			return FInterpCurveVector2D.FromNative(IntPtr.Add(base.Address, ProjectedPosition_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ProjectedPosition_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSplineProjectionData:ProjectedPosition");
			}
			else
			{
				FInterpCurveVector2D.ToNative(IntPtr.Add(base.Address, ProjectedPosition_Offset), value);
			}
		}
	}

	static UPCGSplineProjectionData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGSplineProjectionData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGSplineProjectionData));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGSplineProjectionData");
		ProjectedPosition_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ProjectedPosition");
		ProjectedPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ProjectedPosition", Classes.FStructProperty);
	}
}

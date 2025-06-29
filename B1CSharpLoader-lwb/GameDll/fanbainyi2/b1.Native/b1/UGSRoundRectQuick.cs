using System;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/UnrealExtent.GSRoundRectQuick", "UnrealExtent", UnrealModuleType.Game)]
public class UGSRoundRectQuick : UOverlay
{
	private static bool RadiusCfg_IsValid;

	private static int RadiusCfg_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.GSRoundRectQuick:RadiusCfg")]
	public FVector4 RadiusCfg
	{
		get
		{
			CheckDestroyed();
			if (!RadiusCfg_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSRoundRectQuick:RadiusCfg");
				return default(FVector4);
			}
			return BlittableTypeMarshaler<FVector4>.FromNative(IntPtr.Add(base.Address, RadiusCfg_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RadiusCfg_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSRoundRectQuick:RadiusCfg");
			}
			else
			{
				BlittableTypeMarshaler<FVector4>.ToNative(IntPtr.Add(base.Address, RadiusCfg_Offset), value);
			}
		}
	}

	static UGSRoundRectQuick()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSRoundRectQuick)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSRoundRectQuick));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/UnrealExtent.GSRoundRectQuick");
		RadiusCfg_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "RadiusCfg");
		RadiusCfg_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "RadiusCfg", Classes.FStructProperty);
	}
}

using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[Abstract]
[UClass(Flags = (ClassFlags)810033313uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.MaterialExpressionStrataLegacyConversion", "Engine", UnrealModuleType.Engine)]
public class UMaterialExpressionStrataLegacyConversion : UMaterialExpressionStrataBSDF
{
	private static bool SubsurfaceProfile_IsValid;

	private static int SubsurfaceProfile_Offset;

	[UProperty(Flags = (PropFlags)7881369141117461uL)]
	[UMetaPath("/Script/Engine.MaterialExpressionStrataLegacyConversion:SubsurfaceProfile")]
	public USubsurfaceProfile SubsurfaceProfile
	{
		get
		{
			CheckDestroyed();
			if (!SubsurfaceProfile_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MaterialExpressionStrataLegacyConversion:SubsurfaceProfile");
				return null;
			}
			return UObjectMarshaler<USubsurfaceProfile>.FromNative(IntPtr.Add(base.Address, SubsurfaceProfile_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SubsurfaceProfile_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MaterialExpressionStrataLegacyConversion:SubsurfaceProfile");
			}
			else
			{
				UObjectMarshaler<USubsurfaceProfile>.ToNative(IntPtr.Add(base.Address, SubsurfaceProfile_Offset), value);
			}
		}
	}

	static UMaterialExpressionStrataLegacyConversion()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMaterialExpressionStrataLegacyConversion)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMaterialExpressionStrataLegacyConversion));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.MaterialExpressionStrataLegacyConversion");
		SubsurfaceProfile_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SubsurfaceProfile");
		SubsurfaceProfile_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SubsurfaceProfile", Classes.FObjectProperty);
	}
}

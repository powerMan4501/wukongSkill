using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[Abstract]
[UClass(Flags = (ClassFlags)810033313uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.MaterialExpressionStrataSlabBSDF", "Engine", UnrealModuleType.Engine)]
public class UMaterialExpressionStrataSlabBSDF : UMaterialExpressionStrataBSDF
{
	private static bool SubsurfaceProfile_IsValid;

	private static int SubsurfaceProfile_Offset;

	[UProperty(Flags = (PropFlags)7881369141117461uL)]
	[UMetaPath("/Script/Engine.MaterialExpressionStrataSlabBSDF:SubsurfaceProfile")]
	public USubsurfaceProfile SubsurfaceProfile
	{
		get
		{
			CheckDestroyed();
			if (!SubsurfaceProfile_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MaterialExpressionStrataSlabBSDF:SubsurfaceProfile");
				return null;
			}
			return UObjectMarshaler<USubsurfaceProfile>.FromNative(IntPtr.Add(base.Address, SubsurfaceProfile_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SubsurfaceProfile_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MaterialExpressionStrataSlabBSDF:SubsurfaceProfile");
			}
			else
			{
				UObjectMarshaler<USubsurfaceProfile>.ToNative(IntPtr.Add(base.Address, SubsurfaceProfile_Offset), value);
			}
		}
	}

	static UMaterialExpressionStrataSlabBSDF()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMaterialExpressionStrataSlabBSDF)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMaterialExpressionStrataSlabBSDF));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.MaterialExpressionStrataSlabBSDF");
		SubsurfaceProfile_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SubsurfaceProfile");
		SubsurfaceProfile_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SubsurfaceProfile", Classes.FObjectProperty);
	}
}

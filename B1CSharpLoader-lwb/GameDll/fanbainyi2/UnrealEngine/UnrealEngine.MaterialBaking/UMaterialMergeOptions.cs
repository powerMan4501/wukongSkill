using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.MaterialBaking;

[UClass(Flags = (ClassFlags)810549412uL, Config = "Editor")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/MaterialBaking.MaterialMergeOptions", "MaterialBaking", UnrealModuleType.Engine)]
public class UMaterialMergeOptions : UObject
{
	private static bool BlendMode_IsValid;

	private static FFieldAddress BlendMode_PropertyAddress;

	private static int BlendMode_Offset;

	[UProperty(Flags = (PropFlags)7036944211001861uL)]
	[UMetaPath("/Script/MaterialBaking.MaterialMergeOptions:BlendMode")]
	public EBlendMode BlendMode
	{
		get
		{
			CheckDestroyed();
			if (!BlendMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MaterialBaking.MaterialMergeOptions:BlendMode");
				return EBlendMode.BLEND_Opaque;
			}
			return EnumMarshaler<EBlendMode>.FromNative(IntPtr.Add(base.Address, BlendMode_Offset), 0, BlendMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!BlendMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MaterialBaking.MaterialMergeOptions:BlendMode");
			}
			else
			{
				EnumMarshaler<EBlendMode>.ToNative(IntPtr.Add(base.Address, BlendMode_Offset), 0, BlendMode_PropertyAddress.Address, value);
			}
		}
	}

	static UMaterialMergeOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMaterialMergeOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMaterialMergeOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/MaterialBaking.MaterialMergeOptions");
		NativeReflectionCached.GetPropertyRef(ref BlendMode_PropertyAddress, unrealStruct, "BlendMode");
		BlendMode_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "BlendMode");
		BlendMode_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "BlendMode", Classes.FByteProperty);
	}
}

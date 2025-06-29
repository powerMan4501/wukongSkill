using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818413732uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Engine.VectorFieldVolume", "Engine", UnrealModuleType.Engine)]
public class AVectorFieldVolume : AActor
{
	private static bool VectorFieldComponent_IsValid;

	private static int VectorFieldComponent_Offset;

	[UProperty(Flags = (PropFlags)21392168023884317uL)]
	[UMetaPath("/Script/Engine.VectorFieldVolume:VectorFieldComponent")]
	public UVectorFieldComponent VectorFieldComponent
	{
		get
		{
			CheckDestroyed();
			if (!VectorFieldComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.VectorFieldVolume:VectorFieldComponent");
				return null;
			}
			return UObjectMarshaler<UVectorFieldComponent>.FromNative(IntPtr.Add(base.Address, VectorFieldComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VectorFieldComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.VectorFieldVolume:VectorFieldComponent");
			}
			else
			{
				UObjectMarshaler<UVectorFieldComponent>.ToNative(IntPtr.Add(base.Address, VectorFieldComponent_Offset), value);
			}
		}
	}

	static AVectorFieldVolume()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(AVectorFieldVolume)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AVectorFieldVolume));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.VectorFieldVolume");
		VectorFieldComponent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "VectorFieldComponent");
		VectorFieldComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "VectorFieldComponent", Classes.FObjectProperty);
	}
}

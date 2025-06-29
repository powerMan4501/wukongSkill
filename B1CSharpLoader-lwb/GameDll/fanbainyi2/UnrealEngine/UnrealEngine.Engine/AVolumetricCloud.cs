using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818413732uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.VolumetricCloud", "Engine", UnrealModuleType.Engine)]
public class AVolumetricCloud : AInfo
{
	private static bool VolumetricCloudComponent_IsValid;

	private static int VolumetricCloudComponent_Offset;

	[UProperty(Flags = (PropFlags)21392168023884317uL)]
	[UMetaPath("/Script/Engine.VolumetricCloud:VolumetricCloudComponent")]
	public UVolumetricCloudComponent VolumetricCloudComponent
	{
		get
		{
			CheckDestroyed();
			if (!VolumetricCloudComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.VolumetricCloud:VolumetricCloudComponent");
				return null;
			}
			return UObjectMarshaler<UVolumetricCloudComponent>.FromNative(IntPtr.Add(base.Address, VolumetricCloudComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VolumetricCloudComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.VolumetricCloud:VolumetricCloudComponent");
			}
			else
			{
				UObjectMarshaler<UVolumetricCloudComponent>.ToNative(IntPtr.Add(base.Address, VolumetricCloudComponent_Offset), value);
			}
		}
	}

	static AVolumetricCloud()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(AVolumetricCloud)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AVolumetricCloud));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.VolumetricCloud");
		VolumetricCloudComponent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "VolumetricCloudComponent");
		VolumetricCloudComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "VolumetricCloudComponent", Classes.FObjectProperty);
	}
}

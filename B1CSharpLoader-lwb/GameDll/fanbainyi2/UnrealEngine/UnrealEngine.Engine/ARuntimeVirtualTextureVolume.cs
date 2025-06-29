using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818413732uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Engine.RuntimeVirtualTextureVolume", "Engine", UnrealModuleType.Engine)]
public class ARuntimeVirtualTextureVolume : AActor
{
	private static bool VirtualTextureComponent_IsValid;

	private static int VirtualTextureComponent_Offset;

	[UProperty(Flags = (PropFlags)7881369141772829uL)]
	[UMetaPath("/Script/Engine.RuntimeVirtualTextureVolume:VirtualTextureComponent")]
	public URuntimeVirtualTextureComponent VirtualTextureComponent
	{
		get
		{
			CheckDestroyed();
			if (!VirtualTextureComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.RuntimeVirtualTextureVolume:VirtualTextureComponent");
				return null;
			}
			return UObjectMarshaler<URuntimeVirtualTextureComponent>.FromNative(IntPtr.Add(base.Address, VirtualTextureComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VirtualTextureComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.RuntimeVirtualTextureVolume:VirtualTextureComponent");
			}
			else
			{
				UObjectMarshaler<URuntimeVirtualTextureComponent>.ToNative(IntPtr.Add(base.Address, VirtualTextureComponent_Offset), value);
			}
		}
	}

	static ARuntimeVirtualTextureVolume()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ARuntimeVirtualTextureVolume)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ARuntimeVirtualTextureVolume));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.RuntimeVirtualTextureVolume");
		VirtualTextureComponent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "VirtualTextureComponent");
		VirtualTextureComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "VirtualTextureComponent", Classes.FObjectProperty);
	}
}

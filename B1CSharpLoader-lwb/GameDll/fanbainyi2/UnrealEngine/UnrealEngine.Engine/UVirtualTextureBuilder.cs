using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.VirtualTextureBuilder", "Engine", UnrealModuleType.Engine)]
public class UVirtualTextureBuilder : UObject
{
	private static bool Texture_IsValid;

	private static int Texture_Offset;

	[UProperty(Flags = (PropFlags)7881369141248533uL)]
	[UMetaPath("/Script/Engine.VirtualTextureBuilder:Texture")]
	public UVirtualTexture2D Texture
	{
		get
		{
			CheckDestroyed();
			if (!Texture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.VirtualTextureBuilder:Texture");
				return null;
			}
			return UObjectMarshaler<UVirtualTexture2D>.FromNative(IntPtr.Add(base.Address, Texture_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Texture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.VirtualTextureBuilder:Texture");
			}
			else
			{
				UObjectMarshaler<UVirtualTexture2D>.ToNative(IntPtr.Add(base.Address, Texture_Offset), value);
			}
		}
	}

	static UVirtualTextureBuilder()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UVirtualTextureBuilder)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UVirtualTextureBuilder));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.VirtualTextureBuilder");
		Texture_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Texture");
		Texture_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Texture", Classes.FObjectProperty);
	}
}

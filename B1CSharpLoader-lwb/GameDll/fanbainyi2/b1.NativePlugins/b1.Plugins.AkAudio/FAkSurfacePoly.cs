using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/AkAudio.AkSurfacePoly", "AkAudio", UnrealModuleType.GamePlugin)]
public struct FAkSurfacePoly
{
	private static bool Texture_IsValid;

	private static int Texture_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AkAudio.AkSurfacePoly:Texture")]
	public UAkAcousticTexture Texture;

	private static bool Occlusion_IsValid;

	private static int Occlusion_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AkAudio.AkSurfacePoly:Occlusion")]
	public float Occlusion;

	private static bool EnableSurface_IsValid;

	private static FFieldAddress EnableSurface_PropertyAddress;

	private static int EnableSurface_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AkAudio.AkSurfacePoly:EnableSurface")]
	public bool EnableSurface;

	private static bool FAkSurfacePoly_IsValid;

	private static int FAkSurfacePoly_StructSize;

	public FAkSurfacePoly Copy()
	{
		return this;
	}

	public static FAkSurfacePoly FromNative(IntPtr nativeBuffer)
	{
		return new FAkSurfacePoly(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAkSurfacePoly value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAkSurfacePoly FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAkSurfacePoly(nativeBuffer + arrayIndex * FAkSurfacePoly_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAkSurfacePoly value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAkSurfacePoly_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAkSurfacePoly_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AkAudio.AkSurfacePoly");
			return;
		}
		UObjectMarshaler<UAkAcousticTexture>.ToNative(IntPtr.Add(nativeStruct, Texture_Offset), Texture);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Occlusion_Offset), Occlusion);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, EnableSurface_Offset), 0, EnableSurface_PropertyAddress.Address, EnableSurface);
	}

	public FAkSurfacePoly(IntPtr nativeStruct)
	{
		if (!FAkSurfacePoly_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AkAudio.AkSurfacePoly");
			Texture = null;
			Occlusion = 0f;
			EnableSurface = false;
		}
		else
		{
			Texture = UObjectMarshaler<UAkAcousticTexture>.FromNative(IntPtr.Add(nativeStruct, Texture_Offset));
			Occlusion = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Occlusion_Offset));
			EnableSurface = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, EnableSurface_Offset), 0, EnableSurface_PropertyAddress.Address);
		}
	}

	static FAkSurfacePoly()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAkSurfacePoly)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAkSurfacePoly));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AkAudio.AkSurfacePoly");
		FAkSurfacePoly_StructSize = NativeReflection.GetStructSize(intPtr);
		Texture_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Texture");
		Texture_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Texture", Classes.FObjectProperty);
		Occlusion_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Occlusion");
		Occlusion_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Occlusion", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableSurface_PropertyAddress, intPtr, "EnableSurface");
		EnableSurface_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "EnableSurface");
		EnableSurface_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "EnableSurface", Classes.FBoolProperty);
		FAkSurfacePoly_IsValid = intPtr != IntPtr.Zero && Texture_IsValid && Occlusion_IsValid && EnableSurface_IsValid;
		NativeReflection.LogStructIsValid("/Script/AkAudio.AkSurfacePoly", FAkSurfacePoly_IsValid);
	}
}

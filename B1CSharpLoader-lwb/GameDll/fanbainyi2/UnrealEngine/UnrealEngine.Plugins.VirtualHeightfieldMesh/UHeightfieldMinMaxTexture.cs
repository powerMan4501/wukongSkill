using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.VirtualHeightfieldMesh;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/VirtualHeightfieldMesh.HeightfieldMinMaxTexture", "VirtualHeightfieldMesh", UnrealModuleType.EnginePlugin)]
public class UHeightfieldMinMaxTexture : UObject
{
	private static bool Texture_IsValid;

	private static int Texture_Offset;

	private static bool LodBiasTexture_IsValid;

	private static int LodBiasTexture_Offset;

	private static bool LodBiasMinMaxTexture_IsValid;

	private static int LodBiasMinMaxTexture_Offset;

	private static bool MaxCPULevels_IsValid;

	private static int MaxCPULevels_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/VirtualHeightfieldMesh.HeightfieldMinMaxTexture:Texture")]
	public UTexture2D Texture
	{
		get
		{
			CheckDestroyed();
			if (!Texture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/VirtualHeightfieldMesh.HeightfieldMinMaxTexture:Texture");
				return null;
			}
			return UObjectMarshaler<UTexture2D>.FromNative(IntPtr.Add(base.Address, Texture_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Texture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/VirtualHeightfieldMesh.HeightfieldMinMaxTexture:Texture");
			}
			else
			{
				UObjectMarshaler<UTexture2D>.ToNative(IntPtr.Add(base.Address, Texture_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/VirtualHeightfieldMesh.HeightfieldMinMaxTexture:LodBiasTexture")]
	public UTexture2D LodBiasTexture
	{
		get
		{
			CheckDestroyed();
			if (!LodBiasTexture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/VirtualHeightfieldMesh.HeightfieldMinMaxTexture:LodBiasTexture");
				return null;
			}
			return UObjectMarshaler<UTexture2D>.FromNative(IntPtr.Add(base.Address, LodBiasTexture_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LodBiasTexture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/VirtualHeightfieldMesh.HeightfieldMinMaxTexture:LodBiasTexture");
			}
			else
			{
				UObjectMarshaler<UTexture2D>.ToNative(IntPtr.Add(base.Address, LodBiasTexture_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/VirtualHeightfieldMesh.HeightfieldMinMaxTexture:LodBiasMinMaxTexture")]
	public UTexture2D LodBiasMinMaxTexture
	{
		get
		{
			CheckDestroyed();
			if (!LodBiasMinMaxTexture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/VirtualHeightfieldMesh.HeightfieldMinMaxTexture:LodBiasMinMaxTexture");
				return null;
			}
			return UObjectMarshaler<UTexture2D>.FromNative(IntPtr.Add(base.Address, LodBiasMinMaxTexture_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LodBiasMinMaxTexture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/VirtualHeightfieldMesh.HeightfieldMinMaxTexture:LodBiasMinMaxTexture");
			}
			else
			{
				UObjectMarshaler<UTexture2D>.ToNative(IntPtr.Add(base.Address, LodBiasMinMaxTexture_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667541uL)]
	[UMetaPath("/Script/VirtualHeightfieldMesh.HeightfieldMinMaxTexture:MaxCPULevels")]
	protected int MaxCPULevels
	{
		get
		{
			CheckDestroyed();
			if (!MaxCPULevels_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/VirtualHeightfieldMesh.HeightfieldMinMaxTexture:MaxCPULevels");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, MaxCPULevels_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxCPULevels_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/VirtualHeightfieldMesh.HeightfieldMinMaxTexture:MaxCPULevels");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, MaxCPULevels_Offset), value);
			}
		}
	}

	static UHeightfieldMinMaxTexture()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UHeightfieldMinMaxTexture)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UHeightfieldMinMaxTexture));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/VirtualHeightfieldMesh.HeightfieldMinMaxTexture");
		Texture_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Texture");
		Texture_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Texture", Classes.FObjectProperty);
		LodBiasTexture_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "LodBiasTexture");
		LodBiasTexture_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "LodBiasTexture", Classes.FObjectProperty);
		LodBiasMinMaxTexture_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "LodBiasMinMaxTexture");
		LodBiasMinMaxTexture_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "LodBiasMinMaxTexture", Classes.FObjectProperty);
		MaxCPULevels_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "MaxCPULevels");
		MaxCPULevels_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "MaxCPULevels", Classes.FIntProperty);
	}
}

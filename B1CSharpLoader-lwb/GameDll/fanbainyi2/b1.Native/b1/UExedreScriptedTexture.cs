using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/UnrealExtent.ExedreScriptedTexture", "UnrealExtent", UnrealModuleType.Game)]
public class UExedreScriptedTexture : USceneComponent
{
	private static bool UseMipMaps_IsValid;

	private static FFieldAddress UseMipMaps_PropertyAddress;

	private static int UseMipMaps_Offset;

	private static bool RTFormat_IsValid;

	private static FFieldAddress RTFormat_PropertyAddress;

	private static int RTFormat_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UnrealExtent.ExedreScriptedTexture:UseMipMaps")]
	public bool UseMipMaps
	{
		get
		{
			CheckDestroyed();
			if (!UseMipMaps_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.ExedreScriptedTexture:UseMipMaps");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseMipMaps_Offset), 0, UseMipMaps_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseMipMaps_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.ExedreScriptedTexture:UseMipMaps");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseMipMaps_Offset), 0, UseMipMaps_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UnrealExtent.ExedreScriptedTexture:RTFormat")]
	public ETextureRenderTargetFormat RTFormat
	{
		get
		{
			CheckDestroyed();
			if (!RTFormat_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.ExedreScriptedTexture:RTFormat");
				return ETextureRenderTargetFormat.RTF_R8;
			}
			return EnumMarshaler<ETextureRenderTargetFormat>.FromNative(IntPtr.Add(base.Address, RTFormat_Offset), 0, RTFormat_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!RTFormat_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.ExedreScriptedTexture:RTFormat");
			}
			else
			{
				EnumMarshaler<ETextureRenderTargetFormat>.ToNative(IntPtr.Add(base.Address, RTFormat_Offset), 0, RTFormat_PropertyAddress.Address, value);
			}
		}
	}

	static UExedreScriptedTexture()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UExedreScriptedTexture)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UExedreScriptedTexture));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/UnrealExtent.ExedreScriptedTexture");
		NativeReflectionCached.GetPropertyRef(ref UseMipMaps_PropertyAddress, unrealStruct, "UseMipMaps");
		UseMipMaps_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "UseMipMaps");
		UseMipMaps_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "UseMipMaps", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RTFormat_PropertyAddress, unrealStruct, "RTFormat");
		RTFormat_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "RTFormat");
		RTFormat_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "RTFormat", Classes.FByteProperty);
	}
}

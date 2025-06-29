using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.StaminaTextureInfo")]
public struct StaminaTextureInfo
{
	[EditAnywhere]
	[Tooltip("贴图列表")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.StaminaTextureInfo:StaminaTextureConfig")]
	public Dictionary<FName, UTexture> StaminaTextureConfig;

	[EditAnywhere]
	[UProperty]
	[Tooltip("消耗效果贴图列表")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.StaminaTextureInfo:StaminaCostTextureConfig")]
	public Dictionary<FName, UTexture> StaminaCostTextureConfig;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Tooltip("回复效果Color列表")]
	[USharpPath("/Script/b1-Managed.StaminaTextureInfo:StaminaRecoverColorConfig")]
	public Dictionary<FName, FLinearColor> StaminaRecoverColorConfig;

	private static int StaminaTextureInfo_StructSize;

	private static int StaminaTextureInfo_IsValid;

	private static bool StaminaTextureConfig_IsValid;

	private static int StaminaTextureConfig_Offset;

	private static FFieldAddress StaminaTextureConfig_PropertyAddress;

	private static bool StaminaCostTextureConfig_IsValid;

	private static int StaminaCostTextureConfig_Offset;

	private static FFieldAddress StaminaCostTextureConfig_PropertyAddress;

	private static bool StaminaRecoverColorConfig_IsValid;

	private static int StaminaRecoverColorConfig_Offset;

	private static FFieldAddress StaminaRecoverColorConfig_PropertyAddress;

	public StaminaTextureInfo Copy()
	{
		StaminaTextureInfo result = this;
		if (StaminaTextureConfig != null)
		{
			result.StaminaTextureConfig = new Dictionary<FName, UTexture>(StaminaTextureConfig);
		}
		if (StaminaCostTextureConfig != null)
		{
			result.StaminaCostTextureConfig = new Dictionary<FName, UTexture>(StaminaCostTextureConfig);
		}
		if (StaminaRecoverColorConfig != null)
		{
			result.StaminaRecoverColorConfig = new Dictionary<FName, FLinearColor>(StaminaRecoverColorConfig);
		}
		return result;
	}

	public static StaminaTextureInfo FromNative(IntPtr nativeBuffer)
	{
		return new StaminaTextureInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, StaminaTextureInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static StaminaTextureInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new StaminaTextureInfo(IntPtr.Add(nativeBuffer, arrayIndex * StaminaTextureInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, StaminaTextureInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * StaminaTextureInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (StaminaTextureInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.StaminaTextureInfo");
			return;
		}
		new TMapCopyMarshaler<FName, UTexture>(1, StaminaTextureConfig_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative, CachedMarshalingDelegates<UTexture, UObjectMarshaler<UTexture>>.FromNative, CachedMarshalingDelegates<UTexture, UObjectMarshaler<UTexture>>.ToNative).ToNative(IntPtr.Add(nativeStruct, StaminaTextureConfig_Offset), StaminaTextureConfig);
		new TMapCopyMarshaler<FName, UTexture>(1, StaminaCostTextureConfig_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative, CachedMarshalingDelegates<UTexture, UObjectMarshaler<UTexture>>.FromNative, CachedMarshalingDelegates<UTexture, UObjectMarshaler<UTexture>>.ToNative).ToNative(IntPtr.Add(nativeStruct, StaminaCostTextureConfig_Offset), StaminaCostTextureConfig);
		new TMapCopyMarshaler<FName, FLinearColor>(1, StaminaRecoverColorConfig_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative, CachedMarshalingDelegates<FLinearColor, BlittableTypeMarshaler<FLinearColor>>.FromNative, CachedMarshalingDelegates<FLinearColor, BlittableTypeMarshaler<FLinearColor>>.ToNative).ToNative(IntPtr.Add(nativeStruct, StaminaRecoverColorConfig_Offset), StaminaRecoverColorConfig);
	}

	public StaminaTextureInfo(IntPtr nativeStruct)
	{
		if (StaminaTextureInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.StaminaTextureInfo");
			StaminaTextureConfig = null;
			StaminaCostTextureConfig = null;
			StaminaRecoverColorConfig = null;
		}
		else
		{
			StaminaTextureConfig = new TMapCopyMarshaler<FName, UTexture>(1, StaminaTextureConfig_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative, CachedMarshalingDelegates<UTexture, UObjectMarshaler<UTexture>>.FromNative, CachedMarshalingDelegates<UTexture, UObjectMarshaler<UTexture>>.ToNative).FromNative(IntPtr.Add(nativeStruct, StaminaTextureConfig_Offset));
			StaminaCostTextureConfig = new TMapCopyMarshaler<FName, UTexture>(1, StaminaCostTextureConfig_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative, CachedMarshalingDelegates<UTexture, UObjectMarshaler<UTexture>>.FromNative, CachedMarshalingDelegates<UTexture, UObjectMarshaler<UTexture>>.ToNative).FromNative(IntPtr.Add(nativeStruct, StaminaCostTextureConfig_Offset));
			StaminaRecoverColorConfig = new TMapCopyMarshaler<FName, FLinearColor>(1, StaminaRecoverColorConfig_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative, CachedMarshalingDelegates<FLinearColor, BlittableTypeMarshaler<FLinearColor>>.FromNative, CachedMarshalingDelegates<FLinearColor, BlittableTypeMarshaler<FLinearColor>>.ToNative).FromNative(IntPtr.Add(nativeStruct, StaminaRecoverColorConfig_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.StaminaTextureInfo");
		StaminaTextureInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref StaminaTextureConfig_PropertyAddress, intPtr, "StaminaTextureConfig");
		StaminaTextureConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "StaminaTextureConfig");
		StaminaTextureConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StaminaTextureConfig", Classes.FMapProperty);
		NativeReflection.GetPropertyRef(ref StaminaCostTextureConfig_PropertyAddress, intPtr, "StaminaCostTextureConfig");
		StaminaCostTextureConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "StaminaCostTextureConfig");
		StaminaCostTextureConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StaminaCostTextureConfig", Classes.FMapProperty);
		NativeReflection.GetPropertyRef(ref StaminaRecoverColorConfig_PropertyAddress, intPtr, "StaminaRecoverColorConfig");
		StaminaRecoverColorConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "StaminaRecoverColorConfig");
		StaminaRecoverColorConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StaminaRecoverColorConfig", Classes.FMapProperty);
		StaminaTextureInfo_IsValid = ((intPtr != IntPtr.Zero && StaminaTextureConfig_IsValid && StaminaCostTextureConfig_IsValid && StaminaRecoverColorConfig_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.StaminaTextureInfo", (byte)StaminaTextureInfo_IsValid != 0);
	}

	static StaminaTextureInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(StaminaTextureInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(StaminaTextureInfo));
	}
}

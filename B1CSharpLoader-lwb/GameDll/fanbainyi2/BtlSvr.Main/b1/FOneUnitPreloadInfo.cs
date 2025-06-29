using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.OneUnitPreloadInfo")]
public struct FOneUnitPreloadInfo
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("允许预加载变身单位")]
	[USharpPath("/Script/b1-Managed.OneUnitPreloadInfo:EnableUnitTransPreloadPreload")]
	public bool EnableUnitTransPreloadPreload;

	[DisplayName("白名单Preload技能类型")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.OneUnitPreloadInfo:WhiteListPreloadTypeMap")]
	public Dictionary<string, bool> WhiteListPreloadTypeMap;

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("白名单Preload技能类型对应ID序列")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.OneUnitPreloadInfo:WhiteListPreloadTypeInfoMap")]
	public Dictionary<string, SkillTypeInfo> WhiteListPreloadTypeInfoMap;

	private static int OneUnitPreloadInfo_StructSize;

	private static int OneUnitPreloadInfo_IsValid;

	private static bool EnableUnitTransPreloadPreload_IsValid;

	private static int EnableUnitTransPreloadPreload_Offset;

	private static FFieldAddress EnableUnitTransPreloadPreload_PropertyAddress;

	private static bool WhiteListPreloadTypeMap_IsValid;

	private static int WhiteListPreloadTypeMap_Offset;

	private static FFieldAddress WhiteListPreloadTypeMap_PropertyAddress;

	private static bool WhiteListPreloadTypeInfoMap_IsValid;

	private static int WhiteListPreloadTypeInfoMap_Offset;

	private static FFieldAddress WhiteListPreloadTypeInfoMap_PropertyAddress;

	public FOneUnitPreloadInfo Copy()
	{
		FOneUnitPreloadInfo result = this;
		if (WhiteListPreloadTypeMap != null)
		{
			result.WhiteListPreloadTypeMap = new Dictionary<string, bool>(WhiteListPreloadTypeMap);
		}
		if (WhiteListPreloadTypeInfoMap != null)
		{
			result.WhiteListPreloadTypeInfoMap = new Dictionary<string, SkillTypeInfo>(WhiteListPreloadTypeInfoMap);
		}
		return result;
	}

	public static FOneUnitPreloadInfo FromNative(IntPtr nativeBuffer)
	{
		return new FOneUnitPreloadInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FOneUnitPreloadInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FOneUnitPreloadInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FOneUnitPreloadInfo(IntPtr.Add(nativeBuffer, arrayIndex * OneUnitPreloadInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FOneUnitPreloadInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * OneUnitPreloadInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (OneUnitPreloadInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.OneUnitPreloadInfo");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, EnableUnitTransPreloadPreload_Offset), 0, EnableUnitTransPreloadPreload_PropertyAddress.Address, EnableUnitTransPreloadPreload);
		new TMapCopyMarshaler<string, bool>(1, WhiteListPreloadTypeMap_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<bool, BoolMarshaler>.FromNative, CachedMarshalingDelegates<bool, BoolMarshaler>.ToNative).ToNative(IntPtr.Add(nativeStruct, WhiteListPreloadTypeMap_Offset), WhiteListPreloadTypeMap);
		new TMapCopyMarshaler<string, SkillTypeInfo>(1, WhiteListPreloadTypeInfoMap_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<SkillTypeInfo, SkillTypeInfo>.FromNative, CachedMarshalingDelegates<SkillTypeInfo, SkillTypeInfo>.ToNative).ToNative(IntPtr.Add(nativeStruct, WhiteListPreloadTypeInfoMap_Offset), WhiteListPreloadTypeInfoMap);
	}

	public FOneUnitPreloadInfo(IntPtr nativeStruct)
	{
		if (OneUnitPreloadInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.OneUnitPreloadInfo");
			EnableUnitTransPreloadPreload = false;
			WhiteListPreloadTypeMap = null;
			WhiteListPreloadTypeInfoMap = null;
		}
		else
		{
			EnableUnitTransPreloadPreload = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, EnableUnitTransPreloadPreload_Offset), 0, EnableUnitTransPreloadPreload_PropertyAddress.Address);
			WhiteListPreloadTypeMap = new TMapCopyMarshaler<string, bool>(1, WhiteListPreloadTypeMap_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<bool, BoolMarshaler>.FromNative, CachedMarshalingDelegates<bool, BoolMarshaler>.ToNative).FromNative(IntPtr.Add(nativeStruct, WhiteListPreloadTypeMap_Offset));
			WhiteListPreloadTypeInfoMap = new TMapCopyMarshaler<string, SkillTypeInfo>(1, WhiteListPreloadTypeInfoMap_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<SkillTypeInfo, SkillTypeInfo>.FromNative, CachedMarshalingDelegates<SkillTypeInfo, SkillTypeInfo>.ToNative).FromNative(IntPtr.Add(nativeStruct, WhiteListPreloadTypeInfoMap_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.OneUnitPreloadInfo");
		OneUnitPreloadInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref EnableUnitTransPreloadPreload_PropertyAddress, intPtr, "EnableUnitTransPreloadPreload");
		EnableUnitTransPreloadPreload_Offset = NativeReflection.GetPropertyOffset(intPtr, "EnableUnitTransPreloadPreload");
		EnableUnitTransPreloadPreload_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EnableUnitTransPreloadPreload", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref WhiteListPreloadTypeMap_PropertyAddress, intPtr, "WhiteListPreloadTypeMap");
		WhiteListPreloadTypeMap_Offset = NativeReflection.GetPropertyOffset(intPtr, "WhiteListPreloadTypeMap");
		WhiteListPreloadTypeMap_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "WhiteListPreloadTypeMap", Classes.FMapProperty);
		NativeReflection.GetPropertyRef(ref WhiteListPreloadTypeInfoMap_PropertyAddress, intPtr, "WhiteListPreloadTypeInfoMap");
		WhiteListPreloadTypeInfoMap_Offset = NativeReflection.GetPropertyOffset(intPtr, "WhiteListPreloadTypeInfoMap");
		WhiteListPreloadTypeInfoMap_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "WhiteListPreloadTypeInfoMap", Classes.FMapProperty);
		OneUnitPreloadInfo_IsValid = ((intPtr != IntPtr.Zero && EnableUnitTransPreloadPreload_IsValid && WhiteListPreloadTypeMap_IsValid && WhiteListPreloadTypeInfoMap_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.OneUnitPreloadInfo", (byte)OneUnitPreloadInfo_IsValid != 0);
	}

	static FOneUnitPreloadInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FOneUnitPreloadInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FOneUnitPreloadInfo));
	}
}

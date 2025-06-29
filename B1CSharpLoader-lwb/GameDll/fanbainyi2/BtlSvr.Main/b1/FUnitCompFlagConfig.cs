using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.UnitCompFlagConfig")]
public struct FUnitCompFlagConfig
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.UnitCompFlagConfig:UnitTemplateType")]
	public EUnitTagType UnitTemplateType;

	[BlueprintReadWrite]
	[UProperty]
	[VisibleAnywhere]
	[USharpPath("/Script/b1-Managed.UnitCompFlagConfig:PlayerAlterTags")]
	public Dictionary<string, bool> PlayerAlterTags;

	[UProperty]
	[VisibleAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.UnitCompFlagConfig:MonsterAlterTags")]
	public Dictionary<string, bool> MonsterAlterTags;

	[UProperty]
	[VisibleAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.UnitCompFlagConfig:MonsterRejectTags")]
	public Dictionary<string, bool> MonsterRejectTags;

	private static int UnitCompFlagConfig_StructSize;

	private static int UnitCompFlagConfig_IsValid;

	private static bool UnitTemplateType_IsValid;

	private static int UnitTemplateType_Offset;

	private static FFieldAddress UnitTemplateType_PropertyAddress;

	private static bool PlayerAlterTags_IsValid;

	private static int PlayerAlterTags_Offset;

	private static FFieldAddress PlayerAlterTags_PropertyAddress;

	private static bool MonsterAlterTags_IsValid;

	private static int MonsterAlterTags_Offset;

	private static FFieldAddress MonsterAlterTags_PropertyAddress;

	private static bool MonsterRejectTags_IsValid;

	private static int MonsterRejectTags_Offset;

	private static FFieldAddress MonsterRejectTags_PropertyAddress;

	public FUnitCompFlagConfig Copy()
	{
		FUnitCompFlagConfig result = this;
		if (PlayerAlterTags != null)
		{
			result.PlayerAlterTags = new Dictionary<string, bool>(PlayerAlterTags);
		}
		if (MonsterAlterTags != null)
		{
			result.MonsterAlterTags = new Dictionary<string, bool>(MonsterAlterTags);
		}
		if (MonsterRejectTags != null)
		{
			result.MonsterRejectTags = new Dictionary<string, bool>(MonsterRejectTags);
		}
		return result;
	}

	public static FUnitCompFlagConfig FromNative(IntPtr nativeBuffer)
	{
		return new FUnitCompFlagConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FUnitCompFlagConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FUnitCompFlagConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FUnitCompFlagConfig(IntPtr.Add(nativeBuffer, arrayIndex * UnitCompFlagConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FUnitCompFlagConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * UnitCompFlagConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (UnitCompFlagConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.UnitCompFlagConfig");
			return;
		}
		EnumMarshaler<EUnitTagType>.ToNative(IntPtr.Add(nativeStruct, UnitTemplateType_Offset), 0, UnitTemplateType_PropertyAddress.Address, UnitTemplateType);
		new TMapCopyMarshaler<string, bool>(1, PlayerAlterTags_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<bool, BoolMarshaler>.FromNative, CachedMarshalingDelegates<bool, BoolMarshaler>.ToNative).ToNative(IntPtr.Add(nativeStruct, PlayerAlterTags_Offset), PlayerAlterTags);
		new TMapCopyMarshaler<string, bool>(1, MonsterAlterTags_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<bool, BoolMarshaler>.FromNative, CachedMarshalingDelegates<bool, BoolMarshaler>.ToNative).ToNative(IntPtr.Add(nativeStruct, MonsterAlterTags_Offset), MonsterAlterTags);
		new TMapCopyMarshaler<string, bool>(1, MonsterRejectTags_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<bool, BoolMarshaler>.FromNative, CachedMarshalingDelegates<bool, BoolMarshaler>.ToNative).ToNative(IntPtr.Add(nativeStruct, MonsterRejectTags_Offset), MonsterRejectTags);
	}

	public FUnitCompFlagConfig(IntPtr nativeStruct)
	{
		if (UnitCompFlagConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.UnitCompFlagConfig");
			UnitTemplateType = EUnitTagType.NormalMonster;
			PlayerAlterTags = null;
			MonsterAlterTags = null;
			MonsterRejectTags = null;
		}
		else
		{
			UnitTemplateType = EnumMarshaler<EUnitTagType>.FromNative(IntPtr.Add(nativeStruct, UnitTemplateType_Offset), 0, UnitTemplateType_PropertyAddress.Address);
			PlayerAlterTags = new TMapCopyMarshaler<string, bool>(1, PlayerAlterTags_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<bool, BoolMarshaler>.FromNative, CachedMarshalingDelegates<bool, BoolMarshaler>.ToNative).FromNative(IntPtr.Add(nativeStruct, PlayerAlterTags_Offset));
			MonsterAlterTags = new TMapCopyMarshaler<string, bool>(1, MonsterAlterTags_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<bool, BoolMarshaler>.FromNative, CachedMarshalingDelegates<bool, BoolMarshaler>.ToNative).FromNative(IntPtr.Add(nativeStruct, MonsterAlterTags_Offset));
			MonsterRejectTags = new TMapCopyMarshaler<string, bool>(1, MonsterRejectTags_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<bool, BoolMarshaler>.FromNative, CachedMarshalingDelegates<bool, BoolMarshaler>.ToNative).FromNative(IntPtr.Add(nativeStruct, MonsterRejectTags_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.UnitCompFlagConfig");
		UnitCompFlagConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref UnitTemplateType_PropertyAddress, intPtr, "UnitTemplateType");
		UnitTemplateType_Offset = NativeReflection.GetPropertyOffset(intPtr, "UnitTemplateType");
		UnitTemplateType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UnitTemplateType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref PlayerAlterTags_PropertyAddress, intPtr, "PlayerAlterTags");
		PlayerAlterTags_Offset = NativeReflection.GetPropertyOffset(intPtr, "PlayerAlterTags");
		PlayerAlterTags_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PlayerAlterTags", Classes.FMapProperty);
		NativeReflection.GetPropertyRef(ref MonsterAlterTags_PropertyAddress, intPtr, "MonsterAlterTags");
		MonsterAlterTags_Offset = NativeReflection.GetPropertyOffset(intPtr, "MonsterAlterTags");
		MonsterAlterTags_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MonsterAlterTags", Classes.FMapProperty);
		NativeReflection.GetPropertyRef(ref MonsterRejectTags_PropertyAddress, intPtr, "MonsterRejectTags");
		MonsterRejectTags_Offset = NativeReflection.GetPropertyOffset(intPtr, "MonsterRejectTags");
		MonsterRejectTags_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MonsterRejectTags", Classes.FMapProperty);
		UnitCompFlagConfig_IsValid = ((intPtr != IntPtr.Zero && UnitTemplateType_IsValid && PlayerAlterTags_IsValid && MonsterAlterTags_IsValid && MonsterRejectTags_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.UnitCompFlagConfig", (byte)UnitCompFlagConfig_IsValid != 0);
	}

	static FUnitCompFlagConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FUnitCompFlagConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FUnitCompFlagConfig));
	}
}

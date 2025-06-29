using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.ManagedLevelStates")]
public struct FManagedLevelStates
{
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.ManagedLevelStates:LevelState")]
	public EGSLevelState LevelState;

	[BlueprintReadWrite]
	[DisplayName("禁用关卡名模糊匹配")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.ManagedLevelStates:bDisableKeyword")]
	public bool bDisableKeyword;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.ManagedLevelStates:LevelNames")]
	public List<string> LevelNames;

	private static int ManagedLevelStates_StructSize;

	private static int ManagedLevelStates_IsValid;

	private static bool LevelState_IsValid;

	private static int LevelState_Offset;

	private static FFieldAddress LevelState_PropertyAddress;

	private static bool bDisableKeyword_IsValid;

	private static int bDisableKeyword_Offset;

	private static FFieldAddress bDisableKeyword_PropertyAddress;

	private static bool LevelNames_IsValid;

	private static int LevelNames_Offset;

	private static FFieldAddress LevelNames_PropertyAddress;

	public FManagedLevelStates Copy()
	{
		FManagedLevelStates result = this;
		if (LevelNames != null)
		{
			result.LevelNames = new List<string>(LevelNames);
		}
		return result;
	}

	public static FManagedLevelStates FromNative(IntPtr nativeBuffer)
	{
		return new FManagedLevelStates(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FManagedLevelStates value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FManagedLevelStates FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FManagedLevelStates(IntPtr.Add(nativeBuffer, arrayIndex * ManagedLevelStates_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FManagedLevelStates value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * ManagedLevelStates_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (ManagedLevelStates_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.ManagedLevelStates");
			return;
		}
		EnumMarshaler<EGSLevelState>.ToNative(IntPtr.Add(nativeStruct, LevelState_Offset), 0, LevelState_PropertyAddress.Address, LevelState);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bDisableKeyword_Offset), 0, bDisableKeyword_PropertyAddress.Address, bDisableKeyword);
		new TArrayCopyMarshaler<string>(1, LevelNames_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(nativeStruct, LevelNames_Offset), LevelNames);
	}

	public FManagedLevelStates(IntPtr nativeStruct)
	{
		if (ManagedLevelStates_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.ManagedLevelStates");
			LevelState = EGSLevelState.Auto;
			bDisableKeyword = false;
			LevelNames = null;
		}
		else
		{
			LevelState = EnumMarshaler<EGSLevelState>.FromNative(IntPtr.Add(nativeStruct, LevelState_Offset), 0, LevelState_PropertyAddress.Address);
			bDisableKeyword = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bDisableKeyword_Offset), 0, bDisableKeyword_PropertyAddress.Address);
			LevelNames = new TArrayCopyMarshaler<string>(1, LevelNames_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(nativeStruct, LevelNames_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.ManagedLevelStates");
		ManagedLevelStates_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref LevelState_PropertyAddress, intPtr, "LevelState");
		LevelState_Offset = NativeReflection.GetPropertyOffset(intPtr, "LevelState");
		LevelState_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LevelState", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref bDisableKeyword_PropertyAddress, intPtr, "bDisableKeyword");
		bDisableKeyword_Offset = NativeReflection.GetPropertyOffset(intPtr, "bDisableKeyword");
		bDisableKeyword_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bDisableKeyword", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref LevelNames_PropertyAddress, intPtr, "LevelNames");
		LevelNames_Offset = NativeReflection.GetPropertyOffset(intPtr, "LevelNames");
		LevelNames_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LevelNames", Classes.FArrayProperty);
		ManagedLevelStates_IsValid = ((intPtr != IntPtr.Zero && LevelState_IsValid && bDisableKeyword_IsValid && LevelNames_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.ManagedLevelStates", (byte)ManagedLevelStates_IsValid != 0);
	}

	static FManagedLevelStates()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FManagedLevelStates)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FManagedLevelStates));
	}
}

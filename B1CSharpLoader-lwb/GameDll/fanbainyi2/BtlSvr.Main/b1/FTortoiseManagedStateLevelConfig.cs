using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.TortoiseManagedStateLevelConfig")]
public struct FTortoiseManagedStateLevelConfig
{
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.TortoiseManagedStateLevelConfig:ManagedStateLevels")]
	public Dictionary<EGSLevelState, FTortoiseLevelGroupConfig> ManagedStateLevels;

	private static int TortoiseManagedStateLevelConfig_StructSize;

	private static int TortoiseManagedStateLevelConfig_IsValid;

	private static bool ManagedStateLevels_IsValid;

	private static int ManagedStateLevels_Offset;

	private static FFieldAddress ManagedStateLevels_PropertyAddress;

	public FGSSubLevelStates ToConfigInfo(EGSLevelStateInfoLayerType StateLayer, string RequesterName)
	{
		FGSSubLevelStates fGSSubLevelStates = new FGSSubLevelStates();
		foreach (KeyValuePair<EGSLevelState, FTortoiseLevelGroupConfig> managedStateLevel in ManagedStateLevels)
		{
			foreach (string managedLevel in managedStateLevel.Value.ManagedLevels)
			{
				fGSSubLevelStates.ManagedLevels.Add(managedLevel, new FGSLevelStateInfo(managedLevel, managedStateLevel.Key, disableKeyword: false, StateLayer, RequesterName));
			}
		}
		return fGSSubLevelStates;
	}

	public FTortoiseManagedStateLevelConfig Copy()
	{
		FTortoiseManagedStateLevelConfig result = this;
		if (ManagedStateLevels != null)
		{
			result.ManagedStateLevels = new Dictionary<EGSLevelState, FTortoiseLevelGroupConfig>(ManagedStateLevels);
		}
		return result;
	}

	public static FTortoiseManagedStateLevelConfig FromNative(IntPtr nativeBuffer)
	{
		return new FTortoiseManagedStateLevelConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FTortoiseManagedStateLevelConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FTortoiseManagedStateLevelConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FTortoiseManagedStateLevelConfig(IntPtr.Add(nativeBuffer, arrayIndex * TortoiseManagedStateLevelConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FTortoiseManagedStateLevelConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * TortoiseManagedStateLevelConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (TortoiseManagedStateLevelConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.TortoiseManagedStateLevelConfig");
		}
		else
		{
			new TMapCopyMarshaler<EGSLevelState, FTortoiseLevelGroupConfig>(1, ManagedStateLevels_PropertyAddress, CachedMarshalingDelegates<EGSLevelState, EnumMarshaler<EGSLevelState>>.FromNative, CachedMarshalingDelegates<EGSLevelState, EnumMarshaler<EGSLevelState>>.ToNative, CachedMarshalingDelegates<FTortoiseLevelGroupConfig, FTortoiseLevelGroupConfig>.FromNative, CachedMarshalingDelegates<FTortoiseLevelGroupConfig, FTortoiseLevelGroupConfig>.ToNative).ToNative(IntPtr.Add(nativeStruct, ManagedStateLevels_Offset), ManagedStateLevels);
		}
	}

	public FTortoiseManagedStateLevelConfig(IntPtr nativeStruct)
	{
		if (TortoiseManagedStateLevelConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.TortoiseManagedStateLevelConfig");
			ManagedStateLevels = null;
		}
		else
		{
			ManagedStateLevels = new TMapCopyMarshaler<EGSLevelState, FTortoiseLevelGroupConfig>(1, ManagedStateLevels_PropertyAddress, CachedMarshalingDelegates<EGSLevelState, EnumMarshaler<EGSLevelState>>.FromNative, CachedMarshalingDelegates<EGSLevelState, EnumMarshaler<EGSLevelState>>.ToNative, CachedMarshalingDelegates<FTortoiseLevelGroupConfig, FTortoiseLevelGroupConfig>.FromNative, CachedMarshalingDelegates<FTortoiseLevelGroupConfig, FTortoiseLevelGroupConfig>.ToNative).FromNative(IntPtr.Add(nativeStruct, ManagedStateLevels_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.TortoiseManagedStateLevelConfig");
		TortoiseManagedStateLevelConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref ManagedStateLevels_PropertyAddress, intPtr, "ManagedStateLevels");
		ManagedStateLevels_Offset = NativeReflection.GetPropertyOffset(intPtr, "ManagedStateLevels");
		ManagedStateLevels_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ManagedStateLevels", Classes.FMapProperty);
		TortoiseManagedStateLevelConfig_IsValid = ((intPtr != IntPtr.Zero && ManagedStateLevels_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.TortoiseManagedStateLevelConfig", (byte)TortoiseManagedStateLevelConfig_IsValid != 0);
	}

	static FTortoiseManagedStateLevelConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FTortoiseManagedStateLevelConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FTortoiseManagedStateLevelConfig));
	}
}

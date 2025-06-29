using System;
using System.Collections.Generic;
using b1.AutoQA;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.ManagedStreamingLevelStateConfig")]
public struct FManagedStreamingLevelStateConfig
{
	[DisplayName("配置描述")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.ManagedStreamingLevelStateConfig:Description")]
	public string Description;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.ManagedStreamingLevelStateConfig:LevelStateConfigs")]
	public List<FManagedLevelStates> LevelStateConfigs;

	private static int ManagedStreamingLevelStateConfig_StructSize;

	private static int ManagedStreamingLevelStateConfig_IsValid;

	private static bool Description_IsValid;

	private static int Description_Offset;

	private static bool LevelStateConfigs_IsValid;

	private static int LevelStateConfigs_Offset;

	private static FFieldAddress LevelStateConfigs_PropertyAddress;

	public FGSSubLevelStates ToConfigInfo(EGSLevelStateInfoLayerType StateLayer, string RequesterName)
	{
		FGSSubLevelStates fGSSubLevelStates = new FGSSubLevelStates();
		foreach (FManagedLevelStates levelStateConfig in LevelStateConfigs)
		{
			foreach (string levelName in levelStateConfig.LevelNames)
			{
				fGSSubLevelStates.ManagedLevels[levelName] = new FGSLevelStateInfo(levelName, levelStateConfig.LevelState, levelStateConfig.bDisableKeyword, StateLayer, RequesterName);
			}
		}
		return fGSSubLevelStates;
	}

	public bool GetConfiguredStateOfLevel(string SubLevelName, out List<EGSLevelState> LevelStates)
	{
		LevelStates = new List<EGSLevelState>();
		foreach (FManagedLevelStates levelStateConfig in LevelStateConfigs)
		{
			foreach (string levelName in levelStateConfig.LevelNames)
			{
				if (SubLevelName.Contains(levelName))
				{
					ListExtensions.AddUnique(LevelStates, levelStateConfig.LevelState);
					break;
				}
			}
		}
		return LevelStates.Count > 0;
	}

	public FManagedStreamingLevelStateConfig Copy()
	{
		FManagedStreamingLevelStateConfig result = this;
		if (LevelStateConfigs != null)
		{
			result.LevelStateConfigs = new List<FManagedLevelStates>(LevelStateConfigs);
		}
		return result;
	}

	public static FManagedStreamingLevelStateConfig FromNative(IntPtr nativeBuffer)
	{
		return new FManagedStreamingLevelStateConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FManagedStreamingLevelStateConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FManagedStreamingLevelStateConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FManagedStreamingLevelStateConfig(IntPtr.Add(nativeBuffer, arrayIndex * ManagedStreamingLevelStateConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FManagedStreamingLevelStateConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * ManagedStreamingLevelStateConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (ManagedStreamingLevelStateConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.ManagedStreamingLevelStateConfig");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, Description_Offset), Description);
		new TArrayCopyMarshaler<FManagedLevelStates>(1, LevelStateConfigs_PropertyAddress, CachedMarshalingDelegates<FManagedLevelStates, FManagedLevelStates>.FromNative, CachedMarshalingDelegates<FManagedLevelStates, FManagedLevelStates>.ToNative).ToNative(IntPtr.Add(nativeStruct, LevelStateConfigs_Offset), LevelStateConfigs);
	}

	public FManagedStreamingLevelStateConfig(IntPtr nativeStruct)
	{
		if (ManagedStreamingLevelStateConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.ManagedStreamingLevelStateConfig");
			Description = null;
			LevelStateConfigs = null;
		}
		else
		{
			Description = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, Description_Offset));
			LevelStateConfigs = new TArrayCopyMarshaler<FManagedLevelStates>(1, LevelStateConfigs_PropertyAddress, CachedMarshalingDelegates<FManagedLevelStates, FManagedLevelStates>.FromNative, CachedMarshalingDelegates<FManagedLevelStates, FManagedLevelStates>.ToNative).FromNative(IntPtr.Add(nativeStruct, LevelStateConfigs_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.ManagedStreamingLevelStateConfig");
		ManagedStreamingLevelStateConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		Description_Offset = NativeReflection.GetPropertyOffset(intPtr, "Description");
		Description_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Description", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref LevelStateConfigs_PropertyAddress, intPtr, "LevelStateConfigs");
		LevelStateConfigs_Offset = NativeReflection.GetPropertyOffset(intPtr, "LevelStateConfigs");
		LevelStateConfigs_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LevelStateConfigs", Classes.FArrayProperty);
		ManagedStreamingLevelStateConfig_IsValid = ((intPtr != IntPtr.Zero && Description_IsValid && LevelStateConfigs_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.ManagedStreamingLevelStateConfig", (byte)ManagedStreamingLevelStateConfig_IsValid != 0);
	}

	static FManagedStreamingLevelStateConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FManagedStreamingLevelStateConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FManagedStreamingLevelStateConfig));
	}
}

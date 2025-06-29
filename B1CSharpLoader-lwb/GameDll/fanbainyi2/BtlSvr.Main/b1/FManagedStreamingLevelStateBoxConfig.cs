using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.ManagedStreamingLevelStateBoxConfig")]
public struct FManagedStreamingLevelStateBoxConfig
{
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.ManagedStreamingLevelStateBoxConfig:Actor")]
	public FGsActorGuidReference Actor;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.ManagedStreamingLevelStateBoxConfig:ManagedStateLevelsConfig")]
	public FManagedStreamingLevelStateConfig ManagedStateLevelsConfig;

	private static int ManagedStreamingLevelStateBoxConfig_StructSize;

	private static int ManagedStreamingLevelStateBoxConfig_IsValid;

	private static bool Actor_IsValid;

	private static int Actor_Offset;

	private static bool ManagedStateLevelsConfig_IsValid;

	private static int ManagedStateLevelsConfig_Offset;

	public FManagedStreamingLevelStateBoxConfig Copy()
	{
		return this;
	}

	public static FManagedStreamingLevelStateBoxConfig FromNative(IntPtr nativeBuffer)
	{
		return new FManagedStreamingLevelStateBoxConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FManagedStreamingLevelStateBoxConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FManagedStreamingLevelStateBoxConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FManagedStreamingLevelStateBoxConfig(IntPtr.Add(nativeBuffer, arrayIndex * ManagedStreamingLevelStateBoxConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FManagedStreamingLevelStateBoxConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * ManagedStreamingLevelStateBoxConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (ManagedStreamingLevelStateBoxConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.ManagedStreamingLevelStateBoxConfig");
			return;
		}
		FGsActorGuidReference.ToNative(IntPtr.Add(nativeStruct, Actor_Offset), Actor);
		FManagedStreamingLevelStateConfig.ToNative(IntPtr.Add(nativeStruct, ManagedStateLevelsConfig_Offset), ManagedStateLevelsConfig);
	}

	public FManagedStreamingLevelStateBoxConfig(IntPtr nativeStruct)
	{
		if (ManagedStreamingLevelStateBoxConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.ManagedStreamingLevelStateBoxConfig");
			Actor = default(FGsActorGuidReference);
			ManagedStateLevelsConfig = default(FManagedStreamingLevelStateConfig);
		}
		else
		{
			Actor = FGsActorGuidReference.FromNative(IntPtr.Add(nativeStruct, Actor_Offset));
			ManagedStateLevelsConfig = FManagedStreamingLevelStateConfig.FromNative(IntPtr.Add(nativeStruct, ManagedStateLevelsConfig_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.ManagedStreamingLevelStateBoxConfig");
		ManagedStreamingLevelStateBoxConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		Actor_Offset = NativeReflection.GetPropertyOffset(intPtr, "Actor");
		Actor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Actor", Classes.FStructProperty);
		ManagedStateLevelsConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "ManagedStateLevelsConfig");
		ManagedStateLevelsConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ManagedStateLevelsConfig", Classes.FStructProperty);
		ManagedStreamingLevelStateBoxConfig_IsValid = ((intPtr != IntPtr.Zero && Actor_IsValid && ManagedStateLevelsConfig_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.ManagedStreamingLevelStateBoxConfig", (byte)ManagedStreamingLevelStateBoxConfig_IsValid != 0);
	}

	static FManagedStreamingLevelStateBoxConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FManagedStreamingLevelStateBoxConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FManagedStreamingLevelStateBoxConfig));
	}
}

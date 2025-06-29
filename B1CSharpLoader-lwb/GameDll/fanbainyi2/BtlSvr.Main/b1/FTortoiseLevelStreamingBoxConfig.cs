using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.TortoiseLevelStreamingBoxConfig")]
public struct FTortoiseLevelStreamingBoxConfig
{
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.TortoiseLevelStreamingBoxConfig:Actor")]
	public FGsActorGuidReference Actor;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.TortoiseLevelStreamingBoxConfig:ManagedStateLevelsConfig")]
	public FTortoiseManagedStateLevelConfig ManagedStateLevelsConfig;

	private static int TortoiseLevelStreamingBoxConfig_StructSize;

	private static int TortoiseLevelStreamingBoxConfig_IsValid;

	private static bool Actor_IsValid;

	private static int Actor_Offset;

	private static bool ManagedStateLevelsConfig_IsValid;

	private static int ManagedStateLevelsConfig_Offset;

	public FTortoiseLevelStreamingBoxConfig Copy()
	{
		return this;
	}

	public static FTortoiseLevelStreamingBoxConfig FromNative(IntPtr nativeBuffer)
	{
		return new FTortoiseLevelStreamingBoxConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FTortoiseLevelStreamingBoxConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FTortoiseLevelStreamingBoxConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FTortoiseLevelStreamingBoxConfig(IntPtr.Add(nativeBuffer, arrayIndex * TortoiseLevelStreamingBoxConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FTortoiseLevelStreamingBoxConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * TortoiseLevelStreamingBoxConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (TortoiseLevelStreamingBoxConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.TortoiseLevelStreamingBoxConfig");
			return;
		}
		FGsActorGuidReference.ToNative(IntPtr.Add(nativeStruct, Actor_Offset), Actor);
		FTortoiseManagedStateLevelConfig.ToNative(IntPtr.Add(nativeStruct, ManagedStateLevelsConfig_Offset), ManagedStateLevelsConfig);
	}

	public FTortoiseLevelStreamingBoxConfig(IntPtr nativeStruct)
	{
		if (TortoiseLevelStreamingBoxConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.TortoiseLevelStreamingBoxConfig");
			Actor = default(FGsActorGuidReference);
			ManagedStateLevelsConfig = default(FTortoiseManagedStateLevelConfig);
		}
		else
		{
			Actor = FGsActorGuidReference.FromNative(IntPtr.Add(nativeStruct, Actor_Offset));
			ManagedStateLevelsConfig = FTortoiseManagedStateLevelConfig.FromNative(IntPtr.Add(nativeStruct, ManagedStateLevelsConfig_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.TortoiseLevelStreamingBoxConfig");
		TortoiseLevelStreamingBoxConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		Actor_Offset = NativeReflection.GetPropertyOffset(intPtr, "Actor");
		Actor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Actor", Classes.FStructProperty);
		ManagedStateLevelsConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "ManagedStateLevelsConfig");
		ManagedStateLevelsConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ManagedStateLevelsConfig", Classes.FStructProperty);
		TortoiseLevelStreamingBoxConfig_IsValid = ((intPtr != IntPtr.Zero && Actor_IsValid && ManagedStateLevelsConfig_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.TortoiseLevelStreamingBoxConfig", (byte)TortoiseLevelStreamingBoxConfig_IsValid != 0);
	}

	static FTortoiseLevelStreamingBoxConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FTortoiseLevelStreamingBoxConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FTortoiseLevelStreamingBoxConfig));
	}
}

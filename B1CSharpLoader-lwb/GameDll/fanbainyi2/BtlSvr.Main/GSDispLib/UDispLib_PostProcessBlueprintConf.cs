using System;
using UnrealEngine.Runtime;

namespace GSDispLib;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.UDispLib_PostProcessBlueprintConf")]
public struct UDispLib_PostProcessBlueprintConf
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("蓝图")]
	[USharpPath("/Script/b1-Managed.UDispLib_PostProcessBlueprintConf:Blueprint")]
	public TSubclassOf<GSDispLib_PostProcessActor> Blueprint;

	private static int UDispLib_PostProcessBlueprintConf_StructSize;

	private static int UDispLib_PostProcessBlueprintConf_IsValid;

	private static bool Blueprint_IsValid;

	private static int Blueprint_Offset;

	public UDispLib_PostProcessBlueprintConf Copy()
	{
		return this;
	}

	public static UDispLib_PostProcessBlueprintConf FromNative(IntPtr nativeBuffer)
	{
		return new UDispLib_PostProcessBlueprintConf(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, UDispLib_PostProcessBlueprintConf value)
	{
		value.ToNative(nativeBuffer);
	}

	public static UDispLib_PostProcessBlueprintConf FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new UDispLib_PostProcessBlueprintConf(IntPtr.Add(nativeBuffer, arrayIndex * UDispLib_PostProcessBlueprintConf_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, UDispLib_PostProcessBlueprintConf value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * UDispLib_PostProcessBlueprintConf_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (UDispLib_PostProcessBlueprintConf_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.UDispLib_PostProcessBlueprintConf");
		}
		else
		{
			TSubclassOfMarshaler<GSDispLib_PostProcessActor>.ToNative(IntPtr.Add(nativeStruct, Blueprint_Offset), Blueprint);
		}
	}

	public UDispLib_PostProcessBlueprintConf(IntPtr nativeStruct)
	{
		if (UDispLib_PostProcessBlueprintConf_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.UDispLib_PostProcessBlueprintConf");
			Blueprint = default(TSubclassOf<GSDispLib_PostProcessActor>);
		}
		else
		{
			Blueprint = TSubclassOfMarshaler<GSDispLib_PostProcessActor>.FromNative(IntPtr.Add(nativeStruct, Blueprint_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.UDispLib_PostProcessBlueprintConf");
		UDispLib_PostProcessBlueprintConf_StructSize = NativeReflection.GetStructSize(intPtr);
		Blueprint_Offset = NativeReflection.GetPropertyOffset(intPtr, "Blueprint");
		Blueprint_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Blueprint", Classes.FClassProperty);
		UDispLib_PostProcessBlueprintConf_IsValid = ((intPtr != IntPtr.Zero && Blueprint_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.UDispLib_PostProcessBlueprintConf", (byte)UDispLib_PostProcessBlueprintConf_IsValid != 0);
	}

	static UDispLib_PostProcessBlueprintConf()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(UDispLib_PostProcessBlueprintConf)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UDispLib_PostProcessBlueprintConf));
	}
}

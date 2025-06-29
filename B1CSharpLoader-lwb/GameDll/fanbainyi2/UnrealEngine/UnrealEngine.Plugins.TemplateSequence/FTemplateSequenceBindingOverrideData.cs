using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.TemplateSequence;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/TemplateSequence.TemplateSequenceBindingOverrideData", "TemplateSequence", UnrealModuleType.EnginePlugin)]
public struct FTemplateSequenceBindingOverrideData
{
	private static bool FTemplateSequenceBindingOverrideData_IsValid;

	private static int FTemplateSequenceBindingOverrideData_StructSize;

	public FTemplateSequenceBindingOverrideData Copy()
	{
		return this;
	}

	public static FTemplateSequenceBindingOverrideData FromNative(IntPtr nativeBuffer)
	{
		return new FTemplateSequenceBindingOverrideData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FTemplateSequenceBindingOverrideData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FTemplateSequenceBindingOverrideData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FTemplateSequenceBindingOverrideData(nativeBuffer + arrayIndex * FTemplateSequenceBindingOverrideData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FTemplateSequenceBindingOverrideData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FTemplateSequenceBindingOverrideData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FTemplateSequenceBindingOverrideData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/TemplateSequence.TemplateSequenceBindingOverrideData");
		}
	}

	public FTemplateSequenceBindingOverrideData(IntPtr nativeStruct)
	{
		if (!FTemplateSequenceBindingOverrideData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/TemplateSequence.TemplateSequenceBindingOverrideData");
		}
	}

	static FTemplateSequenceBindingOverrideData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FTemplateSequenceBindingOverrideData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FTemplateSequenceBindingOverrideData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/TemplateSequence.TemplateSequenceBindingOverrideData");
		FTemplateSequenceBindingOverrideData_StructSize = NativeReflection.GetStructSize(intPtr);
		FTemplateSequenceBindingOverrideData_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/TemplateSequence.TemplateSequenceBindingOverrideData", FTemplateSequenceBindingOverrideData_IsValid);
	}
}

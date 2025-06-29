using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGDeterminismSettings", "PCG", UnrealModuleType.EnginePlugin)]
public struct FPCGDeterminismSettings
{
	private static bool NativeTests_IsValid;

	private static FFieldAddress NativeTests_PropertyAddress;

	private static int NativeTests_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGDeterminismSettings:bNativeTests")]
	public bool NativeTests;

	private static bool UseBlueprintDeterminismTest_IsValid;

	private static FFieldAddress UseBlueprintDeterminismTest_PropertyAddress;

	private static int UseBlueprintDeterminismTest_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGDeterminismSettings:bUseBlueprintDeterminismTest")]
	public bool UseBlueprintDeterminismTest;

	private static bool DeterminismTestBlueprint_IsValid;

	private static int DeterminismTestBlueprint_Offset;

	[UProperty(Flags = (PropFlags)7881369141117461uL)]
	[UMetaPath("/Script/PCG.PCGDeterminismSettings:DeterminismTestBlueprint")]
	public TSubclassOf<UPCGDeterminismTestBlueprintBase> DeterminismTestBlueprint;

	private static bool FPCGDeterminismSettings_IsValid;

	private static int FPCGDeterminismSettings_StructSize;

	public FPCGDeterminismSettings Copy()
	{
		return this;
	}

	public static FPCGDeterminismSettings FromNative(IntPtr nativeBuffer)
	{
		return new FPCGDeterminismSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FPCGDeterminismSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FPCGDeterminismSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FPCGDeterminismSettings(nativeBuffer + arrayIndex * FPCGDeterminismSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FPCGDeterminismSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FPCGDeterminismSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FPCGDeterminismSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/PCG.PCGDeterminismSettings");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, NativeTests_Offset), 0, NativeTests_PropertyAddress.Address, NativeTests);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UseBlueprintDeterminismTest_Offset), 0, UseBlueprintDeterminismTest_PropertyAddress.Address, UseBlueprintDeterminismTest);
		TSubclassOfMarshaler<UPCGDeterminismTestBlueprintBase>.ToNative(IntPtr.Add(nativeStruct, DeterminismTestBlueprint_Offset), DeterminismTestBlueprint);
	}

	public FPCGDeterminismSettings(IntPtr nativeStruct)
	{
		if (!FPCGDeterminismSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/PCG.PCGDeterminismSettings");
			NativeTests = false;
			UseBlueprintDeterminismTest = false;
			DeterminismTestBlueprint = default(TSubclassOf<UPCGDeterminismTestBlueprintBase>);
		}
		else
		{
			NativeTests = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, NativeTests_Offset), 0, NativeTests_PropertyAddress.Address);
			UseBlueprintDeterminismTest = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UseBlueprintDeterminismTest_Offset), 0, UseBlueprintDeterminismTest_PropertyAddress.Address);
			DeterminismTestBlueprint = TSubclassOfMarshaler<UPCGDeterminismTestBlueprintBase>.FromNative(IntPtr.Add(nativeStruct, DeterminismTestBlueprint_Offset));
		}
	}

	static FPCGDeterminismSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FPCGDeterminismSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FPCGDeterminismSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/PCG.PCGDeterminismSettings");
		FPCGDeterminismSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref NativeTests_PropertyAddress, intPtr, "bNativeTests");
		NativeTests_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bNativeTests");
		NativeTests_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bNativeTests", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UseBlueprintDeterminismTest_PropertyAddress, intPtr, "bUseBlueprintDeterminismTest");
		UseBlueprintDeterminismTest_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUseBlueprintDeterminismTest");
		UseBlueprintDeterminismTest_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUseBlueprintDeterminismTest", Classes.FBoolProperty);
		DeterminismTestBlueprint_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DeterminismTestBlueprint");
		DeterminismTestBlueprint_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DeterminismTestBlueprint", Classes.FClassProperty);
		FPCGDeterminismSettings_IsValid = intPtr != IntPtr.Zero && NativeTests_IsValid && UseBlueprintDeterminismTest_IsValid && DeterminismTestBlueprint_IsValid;
		NativeReflection.LogStructIsValid("/Script/PCG.PCGDeterminismSettings", FPCGDeterminismSettings_IsValid);
	}
}

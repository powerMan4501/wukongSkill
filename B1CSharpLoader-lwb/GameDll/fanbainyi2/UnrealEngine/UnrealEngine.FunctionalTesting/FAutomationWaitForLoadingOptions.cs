using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.FunctionalTesting;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/FunctionalTesting.AutomationWaitForLoadingOptions", "FunctionalTesting", UnrealModuleType.Engine)]
public struct FAutomationWaitForLoadingOptions
{
	private static bool WaitForReplicationToSettle_IsValid;

	private static FFieldAddress WaitForReplicationToSettle_PropertyAddress;

	private static int WaitForReplicationToSettle_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/FunctionalTesting.AutomationWaitForLoadingOptions:WaitForReplicationToSettle")]
	public bool WaitForReplicationToSettle;

	private static bool FAutomationWaitForLoadingOptions_IsValid;

	private static int FAutomationWaitForLoadingOptions_StructSize;

	public FAutomationWaitForLoadingOptions Copy()
	{
		return this;
	}

	public static FAutomationWaitForLoadingOptions FromNative(IntPtr nativeBuffer)
	{
		return new FAutomationWaitForLoadingOptions(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAutomationWaitForLoadingOptions value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAutomationWaitForLoadingOptions FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAutomationWaitForLoadingOptions(nativeBuffer + arrayIndex * FAutomationWaitForLoadingOptions_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAutomationWaitForLoadingOptions value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAutomationWaitForLoadingOptions_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAutomationWaitForLoadingOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/FunctionalTesting.AutomationWaitForLoadingOptions");
		}
		else
		{
			BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, WaitForReplicationToSettle_Offset), 0, WaitForReplicationToSettle_PropertyAddress.Address, WaitForReplicationToSettle);
		}
	}

	public FAutomationWaitForLoadingOptions(IntPtr nativeStruct)
	{
		if (!FAutomationWaitForLoadingOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/FunctionalTesting.AutomationWaitForLoadingOptions");
			WaitForReplicationToSettle = false;
		}
		else
		{
			WaitForReplicationToSettle = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, WaitForReplicationToSettle_Offset), 0, WaitForReplicationToSettle_PropertyAddress.Address);
		}
	}

	static FAutomationWaitForLoadingOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAutomationWaitForLoadingOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAutomationWaitForLoadingOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/FunctionalTesting.AutomationWaitForLoadingOptions");
		FAutomationWaitForLoadingOptions_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref WaitForReplicationToSettle_PropertyAddress, intPtr, "WaitForReplicationToSettle");
		WaitForReplicationToSettle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WaitForReplicationToSettle");
		WaitForReplicationToSettle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WaitForReplicationToSettle", Classes.FBoolProperty);
		FAutomationWaitForLoadingOptions_IsValid = intPtr != IntPtr.Zero && WaitForReplicationToSettle_IsValid;
		NativeReflection.LogStructIsValid("/Script/FunctionalTesting.AutomationWaitForLoadingOptions", FAutomationWaitForLoadingOptions_IsValid);
	}
}

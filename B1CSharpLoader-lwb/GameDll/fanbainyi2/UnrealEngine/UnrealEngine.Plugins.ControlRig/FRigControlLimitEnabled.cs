using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigControlLimitEnabled", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigControlLimitEnabled
{
	private static bool Minimum_IsValid;

	private static FFieldAddress Minimum_PropertyAddress;

	private static int Minimum_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ControlRig.RigControlLimitEnabled:bMinimum")]
	public bool Minimum;

	private static bool Maximum_IsValid;

	private static FFieldAddress Maximum_PropertyAddress;

	private static int Maximum_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ControlRig.RigControlLimitEnabled:bMaximum")]
	public bool Maximum;

	private static bool FRigControlLimitEnabled_IsValid;

	private static int FRigControlLimitEnabled_StructSize;

	public FRigControlLimitEnabled Copy()
	{
		return this;
	}

	public static FRigControlLimitEnabled FromNative(IntPtr nativeBuffer)
	{
		return new FRigControlLimitEnabled(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigControlLimitEnabled value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigControlLimitEnabled FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigControlLimitEnabled(nativeBuffer + arrayIndex * FRigControlLimitEnabled_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigControlLimitEnabled value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigControlLimitEnabled_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigControlLimitEnabled_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigControlLimitEnabled");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Minimum_Offset), 0, Minimum_PropertyAddress.Address, Minimum);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Maximum_Offset), 0, Maximum_PropertyAddress.Address, Maximum);
	}

	public FRigControlLimitEnabled(IntPtr nativeStruct)
	{
		if (!FRigControlLimitEnabled_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigControlLimitEnabled");
			Minimum = false;
			Maximum = false;
		}
		else
		{
			Minimum = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Minimum_Offset), 0, Minimum_PropertyAddress.Address);
			Maximum = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Maximum_Offset), 0, Maximum_PropertyAddress.Address);
		}
	}

	static FRigControlLimitEnabled()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigControlLimitEnabled)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigControlLimitEnabled));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigControlLimitEnabled");
		FRigControlLimitEnabled_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref Minimum_PropertyAddress, intPtr, "bMinimum");
		Minimum_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bMinimum");
		Minimum_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bMinimum", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Maximum_PropertyAddress, intPtr, "bMaximum");
		Maximum_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bMaximum");
		Maximum_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bMaximum", Classes.FBoolProperty);
		FRigControlLimitEnabled_IsValid = intPtr != IntPtr.Zero && Minimum_IsValid && Maximum_IsValid;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigControlLimitEnabled", FRigControlLimitEnabled_IsValid);
	}
}

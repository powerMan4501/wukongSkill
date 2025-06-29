using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.DetectCondition_UnitState")]
public struct FDetectCondition_UnitState
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.DetectCondition_UnitState:UnitState")]
	public EBGUUnitState UnitState;

	private static int DetectCondition_UnitState_StructSize;

	private static int DetectCondition_UnitState_IsValid;

	private static bool UnitState_IsValid;

	private static int UnitState_Offset;

	private static FFieldAddress UnitState_PropertyAddress;

	public FDetectCondition_UnitState Copy()
	{
		return this;
	}

	public static FDetectCondition_UnitState FromNative(IntPtr nativeBuffer)
	{
		return new FDetectCondition_UnitState(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FDetectCondition_UnitState value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FDetectCondition_UnitState FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FDetectCondition_UnitState(IntPtr.Add(nativeBuffer, arrayIndex * DetectCondition_UnitState_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FDetectCondition_UnitState value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * DetectCondition_UnitState_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (DetectCondition_UnitState_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.DetectCondition_UnitState");
		}
		else
		{
			EnumMarshaler<EBGUUnitState>.ToNative(IntPtr.Add(nativeStruct, UnitState_Offset), 0, UnitState_PropertyAddress.Address, UnitState);
		}
	}

	public FDetectCondition_UnitState(IntPtr nativeStruct)
	{
		if (DetectCondition_UnitState_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.DetectCondition_UnitState");
			UnitState = EBGUUnitState.None;
		}
		else
		{
			UnitState = EnumMarshaler<EBGUUnitState>.FromNative(IntPtr.Add(nativeStruct, UnitState_Offset), 0, UnitState_PropertyAddress.Address);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.DetectCondition_UnitState");
		DetectCondition_UnitState_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref UnitState_PropertyAddress, intPtr, "UnitState");
		UnitState_Offset = NativeReflection.GetPropertyOffset(intPtr, "UnitState");
		UnitState_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UnitState", Classes.FEnumProperty);
		DetectCondition_UnitState_IsValid = ((intPtr != IntPtr.Zero && UnitState_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.DetectCondition_UnitState", (byte)DetectCondition_UnitState_IsValid != 0);
	}

	static FDetectCondition_UnitState()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FDetectCondition_UnitState)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FDetectCondition_UnitState));
	}
}

using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.DetectCondition_SimpleState")]
public struct FDetectCondition_SimpleState
{
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.DetectCondition_SimpleState:SimpleState")]
	public EBGUSimpleState SimpleState;

	private static int DetectCondition_SimpleState_StructSize;

	private static int DetectCondition_SimpleState_IsValid;

	private static bool SimpleState_IsValid;

	private static int SimpleState_Offset;

	private static FFieldAddress SimpleState_PropertyAddress;

	public FDetectCondition_SimpleState Copy()
	{
		return this;
	}

	public static FDetectCondition_SimpleState FromNative(IntPtr nativeBuffer)
	{
		return new FDetectCondition_SimpleState(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FDetectCondition_SimpleState value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FDetectCondition_SimpleState FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FDetectCondition_SimpleState(IntPtr.Add(nativeBuffer, arrayIndex * DetectCondition_SimpleState_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FDetectCondition_SimpleState value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * DetectCondition_SimpleState_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (DetectCondition_SimpleState_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.DetectCondition_SimpleState");
		}
		else
		{
			EnumMarshaler<EBGUSimpleState>.ToNative(IntPtr.Add(nativeStruct, SimpleState_Offset), 0, SimpleState_PropertyAddress.Address, SimpleState);
		}
	}

	public FDetectCondition_SimpleState(IntPtr nativeStruct)
	{
		if (DetectCondition_SimpleState_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.DetectCondition_SimpleState");
			SimpleState = EBGUSimpleState.Normal;
		}
		else
		{
			SimpleState = EnumMarshaler<EBGUSimpleState>.FromNative(IntPtr.Add(nativeStruct, SimpleState_Offset), 0, SimpleState_PropertyAddress.Address);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.DetectCondition_SimpleState");
		DetectCondition_SimpleState_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref SimpleState_PropertyAddress, intPtr, "SimpleState");
		SimpleState_Offset = NativeReflection.GetPropertyOffset(intPtr, "SimpleState");
		SimpleState_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SimpleState", Classes.FEnumProperty);
		DetectCondition_SimpleState_IsValid = ((intPtr != IntPtr.Zero && SimpleState_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.DetectCondition_SimpleState", (byte)DetectCondition_SimpleState_IsValid != 0);
	}

	static FDetectCondition_SimpleState()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FDetectCondition_SimpleState)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FDetectCondition_SimpleState));
	}
}

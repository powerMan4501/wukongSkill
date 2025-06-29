using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.DetectCondition_FsmState")]
public struct FDetectCondition_FsmState
{
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.DetectCondition_FsmState:FsmState")]
	public EBGUFSMStateName FsmState;

	private static int DetectCondition_FsmState_StructSize;

	private static int DetectCondition_FsmState_IsValid;

	private static bool FsmState_IsValid;

	private static int FsmState_Offset;

	private static FFieldAddress FsmState_PropertyAddress;

	public FDetectCondition_FsmState Copy()
	{
		return this;
	}

	public static FDetectCondition_FsmState FromNative(IntPtr nativeBuffer)
	{
		return new FDetectCondition_FsmState(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FDetectCondition_FsmState value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FDetectCondition_FsmState FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FDetectCondition_FsmState(IntPtr.Add(nativeBuffer, arrayIndex * DetectCondition_FsmState_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FDetectCondition_FsmState value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * DetectCondition_FsmState_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (DetectCondition_FsmState_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.DetectCondition_FsmState");
		}
		else
		{
			EnumMarshaler<EBGUFSMStateName>.ToNative(IntPtr.Add(nativeStruct, FsmState_Offset), 0, FsmState_PropertyAddress.Address, FsmState);
		}
	}

	public FDetectCondition_FsmState(IntPtr nativeStruct)
	{
		if (DetectCondition_FsmState_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.DetectCondition_FsmState");
			FsmState = EBGUFSMStateName.FSM_STATE_LIFE;
		}
		else
		{
			FsmState = EnumMarshaler<EBGUFSMStateName>.FromNative(IntPtr.Add(nativeStruct, FsmState_Offset), 0, FsmState_PropertyAddress.Address);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.DetectCondition_FsmState");
		DetectCondition_FsmState_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref FsmState_PropertyAddress, intPtr, "FsmState");
		FsmState_Offset = NativeReflection.GetPropertyOffset(intPtr, "FsmState");
		FsmState_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FsmState", Classes.FEnumProperty);
		DetectCondition_FsmState_IsValid = ((intPtr != IntPtr.Zero && FsmState_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.DetectCondition_FsmState", (byte)DetectCondition_FsmState_IsValid != 0);
	}

	static FDetectCondition_FsmState()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FDetectCondition_FsmState)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FDetectCondition_FsmState));
	}
}

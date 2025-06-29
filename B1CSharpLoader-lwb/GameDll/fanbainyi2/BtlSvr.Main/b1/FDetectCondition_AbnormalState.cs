using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.DetectCondition_AbnormalState")]
public struct FDetectCondition_AbnormalState
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("异常状态类型")]
	[USharpPath("/Script/b1-Managed.DetectCondition_AbnormalState:AbnormalStateType")]
	public EAbnormalStateType AbnormalStateType;

	private static int DetectCondition_AbnormalState_StructSize;

	private static int DetectCondition_AbnormalState_IsValid;

	private static bool AbnormalStateType_IsValid;

	private static int AbnormalStateType_Offset;

	private static FFieldAddress AbnormalStateType_PropertyAddress;

	public FDetectCondition_AbnormalState Copy()
	{
		return this;
	}

	public static FDetectCondition_AbnormalState FromNative(IntPtr nativeBuffer)
	{
		return new FDetectCondition_AbnormalState(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FDetectCondition_AbnormalState value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FDetectCondition_AbnormalState FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FDetectCondition_AbnormalState(IntPtr.Add(nativeBuffer, arrayIndex * DetectCondition_AbnormalState_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FDetectCondition_AbnormalState value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * DetectCondition_AbnormalState_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (DetectCondition_AbnormalState_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.DetectCondition_AbnormalState");
		}
		else
		{
			EnumMarshaler<EAbnormalStateType>.ToNative(IntPtr.Add(nativeStruct, AbnormalStateType_Offset), 0, AbnormalStateType_PropertyAddress.Address, AbnormalStateType);
		}
	}

	public FDetectCondition_AbnormalState(IntPtr nativeStruct)
	{
		if (DetectCondition_AbnormalState_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.DetectCondition_AbnormalState");
			AbnormalStateType = EAbnormalStateType.None;
		}
		else
		{
			AbnormalStateType = EnumMarshaler<EAbnormalStateType>.FromNative(IntPtr.Add(nativeStruct, AbnormalStateType_Offset), 0, AbnormalStateType_PropertyAddress.Address);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.DetectCondition_AbnormalState");
		DetectCondition_AbnormalState_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref AbnormalStateType_PropertyAddress, intPtr, "AbnormalStateType");
		AbnormalStateType_Offset = NativeReflection.GetPropertyOffset(intPtr, "AbnormalStateType");
		AbnormalStateType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AbnormalStateType", Classes.FEnumProperty);
		DetectCondition_AbnormalState_IsValid = ((intPtr != IntPtr.Zero && AbnormalStateType_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.DetectCondition_AbnormalState", (byte)DetectCondition_AbnormalState_IsValid != 0);
	}

	static FDetectCondition_AbnormalState()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FDetectCondition_AbnormalState)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FDetectCondition_AbnormalState));
	}
}

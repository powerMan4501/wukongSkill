using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.Birth_AbnomalState")]
public struct Birth_AbnomalState
{
	[DisplayName("异常状态类型")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.Birth_AbnomalState:AbnormalStateType")]
	public EAbnormalStateType AbnormalStateType;

	[UProperty]
	[EditAnywhere]
	[DisplayName("异常状态等级")]
	[USharpPath("/Script/b1-Managed.Birth_AbnomalState:AbnormalStateLevel")]
	public int AbnormalStateLevel;

	private static int Birth_AbnomalState_StructSize;

	private static int Birth_AbnomalState_IsValid;

	private static bool AbnormalStateType_IsValid;

	private static int AbnormalStateType_Offset;

	private static FFieldAddress AbnormalStateType_PropertyAddress;

	private static bool AbnormalStateLevel_IsValid;

	private static int AbnormalStateLevel_Offset;

	public Birth_AbnomalState Copy()
	{
		return this;
	}

	public static Birth_AbnomalState FromNative(IntPtr nativeBuffer)
	{
		return new Birth_AbnomalState(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, Birth_AbnomalState value)
	{
		value.ToNative(nativeBuffer);
	}

	public static Birth_AbnomalState FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new Birth_AbnomalState(IntPtr.Add(nativeBuffer, arrayIndex * Birth_AbnomalState_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, Birth_AbnomalState value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * Birth_AbnomalState_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (Birth_AbnomalState_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.Birth_AbnomalState");
			return;
		}
		EnumMarshaler<EAbnormalStateType>.ToNative(IntPtr.Add(nativeStruct, AbnormalStateType_Offset), 0, AbnormalStateType_PropertyAddress.Address, AbnormalStateType);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, AbnormalStateLevel_Offset), AbnormalStateLevel);
	}

	public Birth_AbnomalState(IntPtr nativeStruct)
	{
		if (Birth_AbnomalState_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.Birth_AbnomalState");
			AbnormalStateType = EAbnormalStateType.None;
			AbnormalStateLevel = 0;
		}
		else
		{
			AbnormalStateType = EnumMarshaler<EAbnormalStateType>.FromNative(IntPtr.Add(nativeStruct, AbnormalStateType_Offset), 0, AbnormalStateType_PropertyAddress.Address);
			AbnormalStateLevel = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, AbnormalStateLevel_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.Birth_AbnomalState");
		Birth_AbnomalState_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref AbnormalStateType_PropertyAddress, intPtr, "AbnormalStateType");
		AbnormalStateType_Offset = NativeReflection.GetPropertyOffset(intPtr, "AbnormalStateType");
		AbnormalStateType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AbnormalStateType", Classes.FEnumProperty);
		AbnormalStateLevel_Offset = NativeReflection.GetPropertyOffset(intPtr, "AbnormalStateLevel");
		AbnormalStateLevel_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AbnormalStateLevel", Classes.FIntProperty);
		Birth_AbnomalState_IsValid = ((intPtr != IntPtr.Zero && AbnormalStateType_IsValid && AbnormalStateLevel_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.Birth_AbnomalState", (byte)Birth_AbnomalState_IsValid != 0);
	}

	static Birth_AbnomalState()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(Birth_AbnomalState)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(Birth_AbnomalState));
	}
}

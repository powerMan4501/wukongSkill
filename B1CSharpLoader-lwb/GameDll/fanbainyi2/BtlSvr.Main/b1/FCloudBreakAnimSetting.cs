using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.CloudBreakAnimSetting")]
public struct FCloudBreakAnimSetting
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[DisplayName("低空击坠动画配置")]
	[USharpPath("/Script/b1-Managed.CloudBreakAnimSetting:CloudBreakAnimSetting_Low")]
	public FAnimHumanoidSetting_Fall CloudBreakAnimSetting_Low;

	[UProperty]
	[BlueprintReadOnly]
	[EditAnywhere]
	[DisplayName("高空击坠动画配置")]
	[USharpPath("/Script/b1-Managed.CloudBreakAnimSetting:CloudBreakAnimSetting_High")]
	public FAnimHumanoidSetting_Fall CloudBreakAnimSetting_High;

	private static int CloudBreakAnimSetting_StructSize;

	private static int CloudBreakAnimSetting_IsValid;

	private static bool CloudBreakAnimSetting_Low_IsValid;

	private static int CloudBreakAnimSetting_Low_Offset;

	private static bool CloudBreakAnimSetting_High_IsValid;

	private static int CloudBreakAnimSetting_High_Offset;

	public FCloudBreakAnimSetting Copy()
	{
		return this;
	}

	public static FCloudBreakAnimSetting FromNative(IntPtr nativeBuffer)
	{
		return new FCloudBreakAnimSetting(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCloudBreakAnimSetting value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCloudBreakAnimSetting FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCloudBreakAnimSetting(IntPtr.Add(nativeBuffer, arrayIndex * CloudBreakAnimSetting_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCloudBreakAnimSetting value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * CloudBreakAnimSetting_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (CloudBreakAnimSetting_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.CloudBreakAnimSetting");
			return;
		}
		FAnimHumanoidSetting_Fall.ToNative(IntPtr.Add(nativeStruct, CloudBreakAnimSetting_Low_Offset), CloudBreakAnimSetting_Low);
		FAnimHumanoidSetting_Fall.ToNative(IntPtr.Add(nativeStruct, CloudBreakAnimSetting_High_Offset), CloudBreakAnimSetting_High);
	}

	public FCloudBreakAnimSetting(IntPtr nativeStruct)
	{
		if (CloudBreakAnimSetting_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.CloudBreakAnimSetting");
			CloudBreakAnimSetting_Low = default(FAnimHumanoidSetting_Fall);
			CloudBreakAnimSetting_High = default(FAnimHumanoidSetting_Fall);
		}
		else
		{
			CloudBreakAnimSetting_Low = FAnimHumanoidSetting_Fall.FromNative(IntPtr.Add(nativeStruct, CloudBreakAnimSetting_Low_Offset));
			CloudBreakAnimSetting_High = FAnimHumanoidSetting_Fall.FromNative(IntPtr.Add(nativeStruct, CloudBreakAnimSetting_High_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.CloudBreakAnimSetting");
		CloudBreakAnimSetting_StructSize = NativeReflection.GetStructSize(intPtr);
		CloudBreakAnimSetting_Low_Offset = NativeReflection.GetPropertyOffset(intPtr, "CloudBreakAnimSetting_Low");
		CloudBreakAnimSetting_Low_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CloudBreakAnimSetting_Low", Classes.FStructProperty);
		CloudBreakAnimSetting_High_Offset = NativeReflection.GetPropertyOffset(intPtr, "CloudBreakAnimSetting_High");
		CloudBreakAnimSetting_High_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CloudBreakAnimSetting_High", Classes.FStructProperty);
		CloudBreakAnimSetting_IsValid = ((intPtr != IntPtr.Zero && CloudBreakAnimSetting_Low_IsValid && CloudBreakAnimSetting_High_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.CloudBreakAnimSetting", (byte)CloudBreakAnimSetting_IsValid != 0);
	}

	static FCloudBreakAnimSetting()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FCloudBreakAnimSetting)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCloudBreakAnimSetting));
	}
}

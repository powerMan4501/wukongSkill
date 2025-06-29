using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[DisplayName("异常累积")]
[USharpPath("/Script/b1-Managed.AbnormalStateAccConfig")]
public struct AbnormalStateAccConfig
{
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("条件列表")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AbnormalStateAccConfig:Condition")]
	public FTriggerAbnormalCondition Condition;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("异常类型")]
	[USharpPath("/Script/b1-Managed.AbnormalStateAccConfig:AbnormalStateType")]
	public EAbnormalStateType AbnormalStateType;

	[UProperty]
	[EditAnywhere]
	[DisplayName("等级")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.AbnormalStateAccConfig:Level")]
	public int Level;

	[DisplayName("积累类型")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AbnormalStateAccConfig:AccType")]
	public EAccAbnormalValueType AccType;

	private static int AbnormalStateAccConfig_StructSize;

	private static int AbnormalStateAccConfig_IsValid;

	private static bool Condition_IsValid;

	private static int Condition_Offset;

	private static bool AbnormalStateType_IsValid;

	private static int AbnormalStateType_Offset;

	private static FFieldAddress AbnormalStateType_PropertyAddress;

	private static bool Level_IsValid;

	private static int Level_Offset;

	private static bool AccType_IsValid;

	private static int AccType_Offset;

	private static FFieldAddress AccType_PropertyAddress;

	[UFunction]
	[BlueprintCallable]
	public bool IsValid()
	{
		if (AbnormalStateType == EAbnormalStateType.None || Level <= 0)
		{
			return false;
		}
		return true;
	}

	public AbnormalStateAccConfig Copy()
	{
		return this;
	}

	public static AbnormalStateAccConfig FromNative(IntPtr nativeBuffer)
	{
		return new AbnormalStateAccConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, AbnormalStateAccConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static AbnormalStateAccConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new AbnormalStateAccConfig(IntPtr.Add(nativeBuffer, arrayIndex * AbnormalStateAccConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, AbnormalStateAccConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * AbnormalStateAccConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (AbnormalStateAccConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AbnormalStateAccConfig");
			return;
		}
		FTriggerAbnormalCondition.ToNative(IntPtr.Add(nativeStruct, Condition_Offset), Condition);
		EnumMarshaler<EAbnormalStateType>.ToNative(IntPtr.Add(nativeStruct, AbnormalStateType_Offset), 0, AbnormalStateType_PropertyAddress.Address, AbnormalStateType);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, Level_Offset), Level);
		EnumMarshaler<EAccAbnormalValueType>.ToNative(IntPtr.Add(nativeStruct, AccType_Offset), 0, AccType_PropertyAddress.Address, AccType);
	}

	public AbnormalStateAccConfig(IntPtr nativeStruct)
	{
		if (AbnormalStateAccConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AbnormalStateAccConfig");
			Condition = default(FTriggerAbnormalCondition);
			AbnormalStateType = EAbnormalStateType.None;
			Level = 0;
			AccType = EAccAbnormalValueType.IncreaseByValue;
		}
		else
		{
			Condition = FTriggerAbnormalCondition.FromNative(IntPtr.Add(nativeStruct, Condition_Offset));
			AbnormalStateType = EnumMarshaler<EAbnormalStateType>.FromNative(IntPtr.Add(nativeStruct, AbnormalStateType_Offset), 0, AbnormalStateType_PropertyAddress.Address);
			Level = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, Level_Offset));
			AccType = EnumMarshaler<EAccAbnormalValueType>.FromNative(IntPtr.Add(nativeStruct, AccType_Offset), 0, AccType_PropertyAddress.Address);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.AbnormalStateAccConfig");
		AbnormalStateAccConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		Condition_Offset = NativeReflection.GetPropertyOffset(intPtr, "Condition");
		Condition_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Condition", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref AbnormalStateType_PropertyAddress, intPtr, "AbnormalStateType");
		AbnormalStateType_Offset = NativeReflection.GetPropertyOffset(intPtr, "AbnormalStateType");
		AbnormalStateType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AbnormalStateType", Classes.FEnumProperty);
		Level_Offset = NativeReflection.GetPropertyOffset(intPtr, "Level");
		Level_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Level", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref AccType_PropertyAddress, intPtr, "AccType");
		AccType_Offset = NativeReflection.GetPropertyOffset(intPtr, "AccType");
		AccType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AccType", Classes.FEnumProperty);
		AbnormalStateAccConfig_IsValid = ((intPtr != IntPtr.Zero && Condition_IsValid && AbnormalStateType_IsValid && Level_IsValid && AccType_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.AbnormalStateAccConfig", (byte)AbnormalStateAccConfig_IsValid != 0);
	}

	static AbnormalStateAccConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(AbnormalStateAccConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AbnormalStateAccConfig));
	}
}

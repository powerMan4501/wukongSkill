using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.SpawnWaveStartCondition")]
public struct FSpawnWaveStartCondition
{
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[DisplayName("条件类型")]
	[USharpPath("/Script/b1-Managed.SpawnWaveStartCondition:ConditionType")]
	public ESpawnWaveStartConditionType ConditionType;

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("等待时间")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.SpawnWaveStartCondition:Time")]
	public float Time;

	private static int SpawnWaveStartCondition_StructSize;

	private static int SpawnWaveStartCondition_IsValid;

	private static bool ConditionType_IsValid;

	private static int ConditionType_Offset;

	private static FFieldAddress ConditionType_PropertyAddress;

	private static bool Time_IsValid;

	private static int Time_Offset;

	public FSpawnWaveStartCondition Copy()
	{
		return this;
	}

	public static FSpawnWaveStartCondition FromNative(IntPtr nativeBuffer)
	{
		return new FSpawnWaveStartCondition(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSpawnWaveStartCondition value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSpawnWaveStartCondition FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSpawnWaveStartCondition(IntPtr.Add(nativeBuffer, arrayIndex * SpawnWaveStartCondition_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSpawnWaveStartCondition value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * SpawnWaveStartCondition_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (SpawnWaveStartCondition_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.SpawnWaveStartCondition");
			return;
		}
		EnumMarshaler<ESpawnWaveStartConditionType>.ToNative(IntPtr.Add(nativeStruct, ConditionType_Offset), 0, ConditionType_PropertyAddress.Address, ConditionType);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Time_Offset), Time);
	}

	public FSpawnWaveStartCondition(IntPtr nativeStruct)
	{
		if (SpawnWaveStartCondition_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.SpawnWaveStartCondition");
			ConditionType = ESpawnWaveStartConditionType.Auto;
			Time = 0f;
		}
		else
		{
			ConditionType = EnumMarshaler<ESpawnWaveStartConditionType>.FromNative(IntPtr.Add(nativeStruct, ConditionType_Offset), 0, ConditionType_PropertyAddress.Address);
			Time = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Time_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.SpawnWaveStartCondition");
		SpawnWaveStartCondition_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref ConditionType_PropertyAddress, intPtr, "ConditionType");
		ConditionType_Offset = NativeReflection.GetPropertyOffset(intPtr, "ConditionType");
		ConditionType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ConditionType", Classes.FEnumProperty);
		Time_Offset = NativeReflection.GetPropertyOffset(intPtr, "Time");
		Time_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Time", Classes.FFloatProperty);
		SpawnWaveStartCondition_IsValid = ((intPtr != IntPtr.Zero && ConditionType_IsValid && Time_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.SpawnWaveStartCondition", (byte)SpawnWaveStartCondition_IsValid != 0);
	}

	static FSpawnWaveStartCondition()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FSpawnWaveStartCondition)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSpawnWaveStartCondition));
	}
}

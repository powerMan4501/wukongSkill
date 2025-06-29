using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.FFXActorConfig")]
public struct FFXActorConfig
{
	[DisplayName("生命时间")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FFXActorConfig:LifeTime")]
	public float LifeTime;

	[DisplayName("延迟销毁时间")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.FFXActorConfig:DelayDestroyTime")]
	public float DelayDestroyTime;

	[EditAnywhere]
	[DisplayName("FXActor类型")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FFXActorConfig:FXActorType")]
	public EFXActorType FXActorType;

	public DestructibleMassLevel MassLevel;

	public DestructibleStrengthLevel StrengthLevel;

	public float Mass;

	public float DestroyedDebrisLifeTime;

	public float DebrisDissipationTime;

	private static int FFXActorConfig_StructSize;

	private static int FFXActorConfig_IsValid;

	private static bool LifeTime_IsValid;

	private static int LifeTime_Offset;

	private static bool DelayDestroyTime_IsValid;

	private static int DelayDestroyTime_Offset;

	private static bool FXActorType_IsValid;

	private static int FXActorType_Offset;

	private static FFieldAddress FXActorType_PropertyAddress;

	public FFXActorConfig Copy()
	{
		return this;
	}

	public static FFXActorConfig FromNative(IntPtr nativeBuffer)
	{
		return new FFXActorConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FFXActorConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FFXActorConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FFXActorConfig(IntPtr.Add(nativeBuffer, arrayIndex * FFXActorConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FFXActorConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * FFXActorConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (FFXActorConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FFXActorConfig");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, LifeTime_Offset), LifeTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, DelayDestroyTime_Offset), DelayDestroyTime);
		EnumMarshaler<EFXActorType>.ToNative(IntPtr.Add(nativeStruct, FXActorType_Offset), 0, FXActorType_PropertyAddress.Address, FXActorType);
	}

	public FFXActorConfig(IntPtr nativeStruct)
	{
		if (FFXActorConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FFXActorConfig");
			LifeTime = 0f;
			DelayDestroyTime = 0f;
			FXActorType = EFXActorType.None;
		}
		else
		{
			LifeTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, LifeTime_Offset));
			DelayDestroyTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, DelayDestroyTime_Offset));
			FXActorType = EnumMarshaler<EFXActorType>.FromNative(IntPtr.Add(nativeStruct, FXActorType_Offset), 0, FXActorType_PropertyAddress.Address);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.FFXActorConfig");
		FFXActorConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		LifeTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "LifeTime");
		LifeTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LifeTime", Classes.FFloatProperty);
		DelayDestroyTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "DelayDestroyTime");
		DelayDestroyTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DelayDestroyTime", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref FXActorType_PropertyAddress, intPtr, "FXActorType");
		FXActorType_Offset = NativeReflection.GetPropertyOffset(intPtr, "FXActorType");
		FXActorType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FXActorType", Classes.FEnumProperty);
		FFXActorConfig_IsValid = ((intPtr != IntPtr.Zero && LifeTime_IsValid && DelayDestroyTime_IsValid && FXActorType_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.FFXActorConfig", (byte)FFXActorConfig_IsValid != 0);
	}

	static FFXActorConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FFXActorConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FFXActorConfig));
	}
}

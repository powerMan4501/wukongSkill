using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.FPEConfig")]
public struct FPEConfig
{
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[DisplayName("保护时间")]
	[Tooltip("刚升棍势等级时在保护时间内不持续扣减棍势值，-1则为永远不扣")]
	[USharpPath("/Script/b1-Managed.FPEConfig:ProtectTime")]
	public float ProtectTime;

	[Tooltip("单位为秒")]
	[DisplayName("棍势衰减速度")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FPEConfig:DecreaseValuePerSecond")]
	public float DecreaseValuePerSecond;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[DisplayName("棍势等级刻度值")]
	[USharpPath("/Script/b1-Managed.FPEConfig:LevelValue")]
	public float LevelValue;

	[UProperty]
	[EditAnywhere]
	[DisplayName("进阶DBC")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FPEConfig:DBC_EnterLevel")]
	public BGWDataAsset_B1DBC DBC_EnterLevel;

	[UProperty]
	[DisplayName("该阶段携带的Buff列表")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.FPEConfig:BuffIDList")]
	public List<int> BuffIDList;

	[Tooltip("只管触发，不管结束，且每次升级都会触发，eg:如越阶升级，0级一次升到2级，会同时触发1级和2级的BuffList")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("升级到该阶段所携带的Buff列表")]
	[USharpPath("/Script/b1-Managed.FPEConfig:BuffIDList_LevelUp")]
	public List<int> BuffIDList_LevelUp;

	private static int FPEConfig_StructSize;

	private static int FPEConfig_IsValid;

	private static bool ProtectTime_IsValid;

	private static int ProtectTime_Offset;

	private static bool DecreaseValuePerSecond_IsValid;

	private static int DecreaseValuePerSecond_Offset;

	private static bool LevelValue_IsValid;

	private static int LevelValue_Offset;

	private static bool DBC_EnterLevel_IsValid;

	private static int DBC_EnterLevel_Offset;

	private static bool BuffIDList_IsValid;

	private static int BuffIDList_Offset;

	private static FFieldAddress BuffIDList_PropertyAddress;

	private static bool BuffIDList_LevelUp_IsValid;

	private static int BuffIDList_LevelUp_Offset;

	private static FFieldAddress BuffIDList_LevelUp_PropertyAddress;

	public FPEConfig Copy()
	{
		FPEConfig result = this;
		if (BuffIDList != null)
		{
			result.BuffIDList = new List<int>(BuffIDList);
		}
		if (BuffIDList_LevelUp != null)
		{
			result.BuffIDList_LevelUp = new List<int>(BuffIDList_LevelUp);
		}
		return result;
	}

	public static FPEConfig FromNative(IntPtr nativeBuffer)
	{
		return new FPEConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FPEConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FPEConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FPEConfig(IntPtr.Add(nativeBuffer, arrayIndex * FPEConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FPEConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * FPEConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (FPEConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FPEConfig");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ProtectTime_Offset), ProtectTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, DecreaseValuePerSecond_Offset), DecreaseValuePerSecond);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, LevelValue_Offset), LevelValue);
		UObjectMarshaler<BGWDataAsset_B1DBC>.ToNative(IntPtr.Add(nativeStruct, DBC_EnterLevel_Offset), DBC_EnterLevel);
		new TArrayCopyMarshaler<int>(1, BuffIDList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(nativeStruct, BuffIDList_Offset), BuffIDList);
		new TArrayCopyMarshaler<int>(1, BuffIDList_LevelUp_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(nativeStruct, BuffIDList_LevelUp_Offset), BuffIDList_LevelUp);
	}

	public FPEConfig(IntPtr nativeStruct)
	{
		if (FPEConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FPEConfig");
			ProtectTime = 0f;
			DecreaseValuePerSecond = 0f;
			LevelValue = 0f;
			DBC_EnterLevel = null;
			BuffIDList = null;
			BuffIDList_LevelUp = null;
		}
		else
		{
			ProtectTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ProtectTime_Offset));
			DecreaseValuePerSecond = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, DecreaseValuePerSecond_Offset));
			LevelValue = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, LevelValue_Offset));
			DBC_EnterLevel = UObjectMarshaler<BGWDataAsset_B1DBC>.FromNative(IntPtr.Add(nativeStruct, DBC_EnterLevel_Offset));
			BuffIDList = new TArrayCopyMarshaler<int>(1, BuffIDList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(nativeStruct, BuffIDList_Offset));
			BuffIDList_LevelUp = new TArrayCopyMarshaler<int>(1, BuffIDList_LevelUp_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(nativeStruct, BuffIDList_LevelUp_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.FPEConfig");
		FPEConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		ProtectTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "ProtectTime");
		ProtectTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ProtectTime", Classes.FFloatProperty);
		DecreaseValuePerSecond_Offset = NativeReflection.GetPropertyOffset(intPtr, "DecreaseValuePerSecond");
		DecreaseValuePerSecond_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DecreaseValuePerSecond", Classes.FFloatProperty);
		LevelValue_Offset = NativeReflection.GetPropertyOffset(intPtr, "LevelValue");
		LevelValue_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LevelValue", Classes.FFloatProperty);
		DBC_EnterLevel_Offset = NativeReflection.GetPropertyOffset(intPtr, "DBC_EnterLevel");
		DBC_EnterLevel_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DBC_EnterLevel", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref BuffIDList_PropertyAddress, intPtr, "BuffIDList");
		BuffIDList_Offset = NativeReflection.GetPropertyOffset(intPtr, "BuffIDList");
		BuffIDList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BuffIDList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref BuffIDList_LevelUp_PropertyAddress, intPtr, "BuffIDList_LevelUp");
		BuffIDList_LevelUp_Offset = NativeReflection.GetPropertyOffset(intPtr, "BuffIDList_LevelUp");
		BuffIDList_LevelUp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BuffIDList_LevelUp", Classes.FArrayProperty);
		FPEConfig_IsValid = ((intPtr != IntPtr.Zero && ProtectTime_IsValid && DecreaseValuePerSecond_IsValid && LevelValue_IsValid && DBC_EnterLevel_IsValid && BuffIDList_IsValid && BuffIDList_LevelUp_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.FPEConfig", (byte)FPEConfig_IsValid != 0);
	}

	static FPEConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FPEConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FPEConfig));
	}
}

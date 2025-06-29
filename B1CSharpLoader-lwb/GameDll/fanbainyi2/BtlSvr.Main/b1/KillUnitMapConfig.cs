using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[DisplayName("击杀特殊死亡表演映射配置")]
[USharpPath("/Script/b1-Managed.KillUnitMapConfig")]
public struct KillUnitMapConfig
{
	[BlueprintReadWrite]
	[UProperty]
	[DisplayName("映射条件")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.KillUnitMapConfig:Cond")]
	public EKillUnitMapCond Cond;

	[DisplayName("映射结果")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.KillUnitMapConfig:Result")]
	public EKillUnitMapResult Result;

	private static int KillUnitMapConfig_StructSize;

	private static int KillUnitMapConfig_IsValid;

	private static bool Cond_IsValid;

	private static int Cond_Offset;

	private static FFieldAddress Cond_PropertyAddress;

	private static bool Result_IsValid;

	private static int Result_Offset;

	private static FFieldAddress Result_PropertyAddress;

	public KillUnitMapConfig Copy()
	{
		return this;
	}

	public static KillUnitMapConfig FromNative(IntPtr nativeBuffer)
	{
		return new KillUnitMapConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, KillUnitMapConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static KillUnitMapConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new KillUnitMapConfig(IntPtr.Add(nativeBuffer, arrayIndex * KillUnitMapConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, KillUnitMapConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * KillUnitMapConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (KillUnitMapConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.KillUnitMapConfig");
			return;
		}
		EnumMarshaler<EKillUnitMapCond>.ToNative(IntPtr.Add(nativeStruct, Cond_Offset), 0, Cond_PropertyAddress.Address, Cond);
		EnumMarshaler<EKillUnitMapResult>.ToNative(IntPtr.Add(nativeStruct, Result_Offset), 0, Result_PropertyAddress.Address, Result);
	}

	public KillUnitMapConfig(IntPtr nativeStruct)
	{
		if (KillUnitMapConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.KillUnitMapConfig");
			Cond = EKillUnitMapCond.Crit;
			Result = EKillUnitMapResult.HeadShot;
		}
		else
		{
			Cond = EnumMarshaler<EKillUnitMapCond>.FromNative(IntPtr.Add(nativeStruct, Cond_Offset), 0, Cond_PropertyAddress.Address);
			Result = EnumMarshaler<EKillUnitMapResult>.FromNative(IntPtr.Add(nativeStruct, Result_Offset), 0, Result_PropertyAddress.Address);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.KillUnitMapConfig");
		KillUnitMapConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref Cond_PropertyAddress, intPtr, "Cond");
		Cond_Offset = NativeReflection.GetPropertyOffset(intPtr, "Cond");
		Cond_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Cond", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref Result_PropertyAddress, intPtr, "Result");
		Result_Offset = NativeReflection.GetPropertyOffset(intPtr, "Result");
		Result_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Result", Classes.FEnumProperty);
		KillUnitMapConfig_IsValid = ((intPtr != IntPtr.Zero && Cond_IsValid && Result_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.KillUnitMapConfig", (byte)KillUnitMapConfig_IsValid != 0);
	}

	static KillUnitMapConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(KillUnitMapConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(KillUnitMapConfig));
	}
}

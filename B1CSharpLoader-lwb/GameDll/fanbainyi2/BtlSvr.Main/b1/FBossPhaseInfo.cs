using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.BossPhaseInfo")]
public struct FBossPhaseInfo
{
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("是否有转阶段表演")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BossPhaseInfo:HasPhasePerformance")]
	public bool HasPhasePerformance;

	private static int BossPhaseInfo_StructSize;

	private static int BossPhaseInfo_IsValid;

	private static bool HasPhasePerformance_IsValid;

	private static int HasPhasePerformance_Offset;

	private static FFieldAddress HasPhasePerformance_PropertyAddress;

	public FBossPhaseInfo Copy()
	{
		return this;
	}

	public static FBossPhaseInfo FromNative(IntPtr nativeBuffer)
	{
		return new FBossPhaseInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FBossPhaseInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FBossPhaseInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FBossPhaseInfo(IntPtr.Add(nativeBuffer, arrayIndex * BossPhaseInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FBossPhaseInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * BossPhaseInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (BossPhaseInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BossPhaseInfo");
		}
		else
		{
			BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, HasPhasePerformance_Offset), 0, HasPhasePerformance_PropertyAddress.Address, HasPhasePerformance);
		}
	}

	public FBossPhaseInfo(IntPtr nativeStruct)
	{
		if (BossPhaseInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BossPhaseInfo");
			HasPhasePerformance = false;
		}
		else
		{
			HasPhasePerformance = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, HasPhasePerformance_Offset), 0, HasPhasePerformance_PropertyAddress.Address);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.BossPhaseInfo");
		BossPhaseInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref HasPhasePerformance_PropertyAddress, intPtr, "HasPhasePerformance");
		HasPhasePerformance_Offset = NativeReflection.GetPropertyOffset(intPtr, "HasPhasePerformance");
		HasPhasePerformance_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "HasPhasePerformance", Classes.FBoolProperty);
		BossPhaseInfo_IsValid = ((intPtr != IntPtr.Zero && HasPhasePerformance_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.BossPhaseInfo", (byte)BossPhaseInfo_IsValid != 0);
	}

	static FBossPhaseInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FBossPhaseInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FBossPhaseInfo));
	}
}

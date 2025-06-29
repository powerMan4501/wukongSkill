using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.DetectCondition_SocketUnitsDead")]
public struct FDetectCondition_SocketUnitsDead
{
	[DisplayName("匹配规则")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.DetectCondition_SocketUnitsDead:MatchInfo")]
	public FTamerFamilyMatchChildInfo MatchInfo;

	private static int DetectCondition_SocketUnitsDead_StructSize;

	private static int DetectCondition_SocketUnitsDead_IsValid;

	private static bool MatchInfo_IsValid;

	private static int MatchInfo_Offset;

	public FDetectCondition_SocketUnitsDead Copy()
	{
		return this;
	}

	public static FDetectCondition_SocketUnitsDead FromNative(IntPtr nativeBuffer)
	{
		return new FDetectCondition_SocketUnitsDead(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FDetectCondition_SocketUnitsDead value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FDetectCondition_SocketUnitsDead FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FDetectCondition_SocketUnitsDead(IntPtr.Add(nativeBuffer, arrayIndex * DetectCondition_SocketUnitsDead_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FDetectCondition_SocketUnitsDead value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * DetectCondition_SocketUnitsDead_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (DetectCondition_SocketUnitsDead_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.DetectCondition_SocketUnitsDead");
		}
		else
		{
			FTamerFamilyMatchChildInfo.ToNative(IntPtr.Add(nativeStruct, MatchInfo_Offset), MatchInfo);
		}
	}

	public FDetectCondition_SocketUnitsDead(IntPtr nativeStruct)
	{
		if (DetectCondition_SocketUnitsDead_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.DetectCondition_SocketUnitsDead");
			MatchInfo = default(FTamerFamilyMatchChildInfo);
		}
		else
		{
			MatchInfo = FTamerFamilyMatchChildInfo.FromNative(IntPtr.Add(nativeStruct, MatchInfo_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.DetectCondition_SocketUnitsDead");
		DetectCondition_SocketUnitsDead_StructSize = NativeReflection.GetStructSize(intPtr);
		MatchInfo_Offset = NativeReflection.GetPropertyOffset(intPtr, "MatchInfo");
		MatchInfo_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MatchInfo", Classes.FStructProperty);
		DetectCondition_SocketUnitsDead_IsValid = ((intPtr != IntPtr.Zero && MatchInfo_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.DetectCondition_SocketUnitsDead", (byte)DetectCondition_SocketUnitsDead_IsValid != 0);
	}

	static FDetectCondition_SocketUnitsDead()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FDetectCondition_SocketUnitsDead)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FDetectCondition_SocketUnitsDead));
	}
}

using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.DetectCondition_FamilyUnitAliveNum")]
public struct FDetectCondition_FamilyUnitAliveNum
{
	[UProperty]
	[DisplayName("匹配子Tamer信息")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.DetectCondition_FamilyUnitAliveNum:MatchInfo")]
	public FTamerFamilyMatchChildInfo MatchInfo;

	[DisplayName("比较方式")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.DetectCondition_FamilyUnitAliveNum:CompareOperation")]
	public EValueCompareOperations CompareOperation;

	[EditAnywhere]
	[DisplayName("存活单位数量")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.DetectCondition_FamilyUnitAliveNum:AliveUnitNum")]
	public int AliveUnitNum;

	private static int DetectCondition_FamilyUnitAliveNum_StructSize;

	private static int DetectCondition_FamilyUnitAliveNum_IsValid;

	private static bool MatchInfo_IsValid;

	private static int MatchInfo_Offset;

	private static bool CompareOperation_IsValid;

	private static int CompareOperation_Offset;

	private static FFieldAddress CompareOperation_PropertyAddress;

	private static bool AliveUnitNum_IsValid;

	private static int AliveUnitNum_Offset;

	public FDetectCondition_FamilyUnitAliveNum Copy()
	{
		return this;
	}

	public static FDetectCondition_FamilyUnitAliveNum FromNative(IntPtr nativeBuffer)
	{
		return new FDetectCondition_FamilyUnitAliveNum(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FDetectCondition_FamilyUnitAliveNum value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FDetectCondition_FamilyUnitAliveNum FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FDetectCondition_FamilyUnitAliveNum(IntPtr.Add(nativeBuffer, arrayIndex * DetectCondition_FamilyUnitAliveNum_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FDetectCondition_FamilyUnitAliveNum value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * DetectCondition_FamilyUnitAliveNum_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (DetectCondition_FamilyUnitAliveNum_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.DetectCondition_FamilyUnitAliveNum");
			return;
		}
		FTamerFamilyMatchChildInfo.ToNative(IntPtr.Add(nativeStruct, MatchInfo_Offset), MatchInfo);
		EnumMarshaler<EValueCompareOperations>.ToNative(IntPtr.Add(nativeStruct, CompareOperation_Offset), 0, CompareOperation_PropertyAddress.Address, CompareOperation);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, AliveUnitNum_Offset), AliveUnitNum);
	}

	public FDetectCondition_FamilyUnitAliveNum(IntPtr nativeStruct)
	{
		if (DetectCondition_FamilyUnitAliveNum_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.DetectCondition_FamilyUnitAliveNum");
			MatchInfo = default(FTamerFamilyMatchChildInfo);
			CompareOperation = EValueCompareOperations.EqualTo;
			AliveUnitNum = 0;
		}
		else
		{
			MatchInfo = FTamerFamilyMatchChildInfo.FromNative(IntPtr.Add(nativeStruct, MatchInfo_Offset));
			CompareOperation = EnumMarshaler<EValueCompareOperations>.FromNative(IntPtr.Add(nativeStruct, CompareOperation_Offset), 0, CompareOperation_PropertyAddress.Address);
			AliveUnitNum = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, AliveUnitNum_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.DetectCondition_FamilyUnitAliveNum");
		DetectCondition_FamilyUnitAliveNum_StructSize = NativeReflection.GetStructSize(intPtr);
		MatchInfo_Offset = NativeReflection.GetPropertyOffset(intPtr, "MatchInfo");
		MatchInfo_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MatchInfo", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref CompareOperation_PropertyAddress, intPtr, "CompareOperation");
		CompareOperation_Offset = NativeReflection.GetPropertyOffset(intPtr, "CompareOperation");
		CompareOperation_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CompareOperation", Classes.FEnumProperty);
		AliveUnitNum_Offset = NativeReflection.GetPropertyOffset(intPtr, "AliveUnitNum");
		AliveUnitNum_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AliveUnitNum", Classes.FIntProperty);
		DetectCondition_FamilyUnitAliveNum_IsValid = ((intPtr != IntPtr.Zero && MatchInfo_IsValid && CompareOperation_IsValid && AliveUnitNum_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.DetectCondition_FamilyUnitAliveNum", (byte)DetectCondition_FamilyUnitAliveNum_IsValid != 0);
	}

	static FDetectCondition_FamilyUnitAliveNum()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FDetectCondition_FamilyUnitAliveNum)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FDetectCondition_FamilyUnitAliveNum));
	}
}

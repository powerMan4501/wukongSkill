using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.DetectCondition_GlobalCastSkillCount")]
public struct FDetectCondition_GlobalCastSkillCount
{
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.DetectCondition_GlobalCastSkillCount:SkillId")]
	public int SkillId;

	[UProperty]
	[EditAnywhere]
	[DisplayName("属性比较方式")]
	[USharpPath("/Script/b1-Managed.DetectCondition_GlobalCastSkillCount:CompareOperation")]
	public EValueCompareOperations CompareOperation;

	[DisplayName("属性比较值")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.DetectCondition_GlobalCastSkillCount:CompareValueInt")]
	public int CompareValueInt;

	private static int DetectCondition_GlobalCastSkillCount_StructSize;

	private static int DetectCondition_GlobalCastSkillCount_IsValid;

	private static bool SkillId_IsValid;

	private static int SkillId_Offset;

	private static bool CompareOperation_IsValid;

	private static int CompareOperation_Offset;

	private static FFieldAddress CompareOperation_PropertyAddress;

	private static bool CompareValueInt_IsValid;

	private static int CompareValueInt_Offset;

	public FDetectCondition_GlobalCastSkillCount Copy()
	{
		return this;
	}

	public static FDetectCondition_GlobalCastSkillCount FromNative(IntPtr nativeBuffer)
	{
		return new FDetectCondition_GlobalCastSkillCount(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FDetectCondition_GlobalCastSkillCount value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FDetectCondition_GlobalCastSkillCount FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FDetectCondition_GlobalCastSkillCount(IntPtr.Add(nativeBuffer, arrayIndex * DetectCondition_GlobalCastSkillCount_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FDetectCondition_GlobalCastSkillCount value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * DetectCondition_GlobalCastSkillCount_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (DetectCondition_GlobalCastSkillCount_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.DetectCondition_GlobalCastSkillCount");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, SkillId_Offset), SkillId);
		EnumMarshaler<EValueCompareOperations>.ToNative(IntPtr.Add(nativeStruct, CompareOperation_Offset), 0, CompareOperation_PropertyAddress.Address, CompareOperation);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, CompareValueInt_Offset), CompareValueInt);
	}

	public FDetectCondition_GlobalCastSkillCount(IntPtr nativeStruct)
	{
		if (DetectCondition_GlobalCastSkillCount_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.DetectCondition_GlobalCastSkillCount");
			SkillId = 0;
			CompareOperation = EValueCompareOperations.EqualTo;
			CompareValueInt = 0;
		}
		else
		{
			SkillId = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, SkillId_Offset));
			CompareOperation = EnumMarshaler<EValueCompareOperations>.FromNative(IntPtr.Add(nativeStruct, CompareOperation_Offset), 0, CompareOperation_PropertyAddress.Address);
			CompareValueInt = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, CompareValueInt_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.DetectCondition_GlobalCastSkillCount");
		DetectCondition_GlobalCastSkillCount_StructSize = NativeReflection.GetStructSize(intPtr);
		SkillId_Offset = NativeReflection.GetPropertyOffset(intPtr, "SkillId");
		SkillId_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SkillId", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref CompareOperation_PropertyAddress, intPtr, "CompareOperation");
		CompareOperation_Offset = NativeReflection.GetPropertyOffset(intPtr, "CompareOperation");
		CompareOperation_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CompareOperation", Classes.FEnumProperty);
		CompareValueInt_Offset = NativeReflection.GetPropertyOffset(intPtr, "CompareValueInt");
		CompareValueInt_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CompareValueInt", Classes.FIntProperty);
		DetectCondition_GlobalCastSkillCount_IsValid = ((intPtr != IntPtr.Zero && SkillId_IsValid && CompareOperation_IsValid && CompareValueInt_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.DetectCondition_GlobalCastSkillCount", (byte)DetectCondition_GlobalCastSkillCount_IsValid != 0);
	}

	static FDetectCondition_GlobalCastSkillCount()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FDetectCondition_GlobalCastSkillCount)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FDetectCondition_GlobalCastSkillCount));
	}
}

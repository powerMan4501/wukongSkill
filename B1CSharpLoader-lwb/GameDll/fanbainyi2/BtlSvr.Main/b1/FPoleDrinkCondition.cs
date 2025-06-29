using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.PoleDrinkCondition")]
public struct FPoleDrinkCondition
{
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[DisplayName("条件类型")]
	[USharpPath("/Script/b1-Managed.PoleDrinkCondition:ConditionType")]
	public EPoleDrinkConditionType ConditionType;

	[Tooltip("填0代表不检测")]
	[DisplayName("天赋ID")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.PoleDrinkCondition:TalentID")]
	public int TalentID;

	private static int PoleDrinkCondition_StructSize;

	private static int PoleDrinkCondition_IsValid;

	private static bool ConditionType_IsValid;

	private static int ConditionType_Offset;

	private static FFieldAddress ConditionType_PropertyAddress;

	private static bool TalentID_IsValid;

	private static int TalentID_Offset;

	public FPoleDrinkCondition Copy()
	{
		return this;
	}

	public static FPoleDrinkCondition FromNative(IntPtr nativeBuffer)
	{
		return new FPoleDrinkCondition(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FPoleDrinkCondition value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FPoleDrinkCondition FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FPoleDrinkCondition(IntPtr.Add(nativeBuffer, arrayIndex * PoleDrinkCondition_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FPoleDrinkCondition value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * PoleDrinkCondition_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (PoleDrinkCondition_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.PoleDrinkCondition");
			return;
		}
		EnumMarshaler<EPoleDrinkConditionType>.ToNative(IntPtr.Add(nativeStruct, ConditionType_Offset), 0, ConditionType_PropertyAddress.Address, ConditionType);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, TalentID_Offset), TalentID);
	}

	public FPoleDrinkCondition(IntPtr nativeStruct)
	{
		if (PoleDrinkCondition_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.PoleDrinkCondition");
			ConditionType = EPoleDrinkConditionType.HasTalent;
			TalentID = 0;
		}
		else
		{
			ConditionType = EnumMarshaler<EPoleDrinkConditionType>.FromNative(IntPtr.Add(nativeStruct, ConditionType_Offset), 0, ConditionType_PropertyAddress.Address);
			TalentID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, TalentID_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.PoleDrinkCondition");
		PoleDrinkCondition_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref ConditionType_PropertyAddress, intPtr, "ConditionType");
		ConditionType_Offset = NativeReflection.GetPropertyOffset(intPtr, "ConditionType");
		ConditionType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ConditionType", Classes.FEnumProperty);
		TalentID_Offset = NativeReflection.GetPropertyOffset(intPtr, "TalentID");
		TalentID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TalentID", Classes.FIntProperty);
		PoleDrinkCondition_IsValid = ((intPtr != IntPtr.Zero && ConditionType_IsValid && TalentID_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.PoleDrinkCondition", (byte)PoleDrinkCondition_IsValid != 0);
	}

	static FPoleDrinkCondition()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FPoleDrinkCondition)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FPoleDrinkCondition));
	}
}

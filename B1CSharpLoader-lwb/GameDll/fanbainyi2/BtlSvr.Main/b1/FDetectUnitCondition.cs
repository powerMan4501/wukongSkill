using System;
using System.Collections.Generic;
using b1.Plugins.Calliope;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.DetectUnitCondition")]
public struct FDetectUnitCondition
{
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("检测的单位")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.DetectUnitCondition:UnitType")]
	public EDetectedUnitType UnitType;

	[DisplayName("SmartUnit")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.DetectUnitCondition:SmartUnit")]
	public FGsSmartParam SmartUnit;

	[BlueprintReadWrite]
	[DisplayName("检测条件")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.DetectUnitCondition:Conditions")]
	public List<FDetectCondition> Conditions;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("条件逻辑关系")]
	[USharpPath("/Script/b1-Managed.DetectUnitCondition:ConditionalRelation")]
	public EConditionalRelation ConditionalRelation;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("注释")]
	[USharpPath("/Script/b1-Managed.DetectUnitCondition:Comment")]
	public string Comment;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("转阶段参数")]
	[USharpPath("/Script/b1-Managed.DetectUnitCondition:BossPhaseInfo")]
	public FBossPhaseInfo BossPhaseInfo;

	private static int DetectUnitCondition_StructSize;

	private static int DetectUnitCondition_IsValid;

	private static bool UnitType_IsValid;

	private static int UnitType_Offset;

	private static FFieldAddress UnitType_PropertyAddress;

	private static bool SmartUnit_IsValid;

	private static int SmartUnit_Offset;

	private static bool Conditions_IsValid;

	private static int Conditions_Offset;

	private static FFieldAddress Conditions_PropertyAddress;

	private static bool ConditionalRelation_IsValid;

	private static int ConditionalRelation_Offset;

	private static FFieldAddress ConditionalRelation_PropertyAddress;

	private static bool Comment_IsValid;

	private static int Comment_Offset;

	private static bool BossPhaseInfo_IsValid;

	private static int BossPhaseInfo_Offset;

	public FDetectUnitCondition Copy()
	{
		FDetectUnitCondition result = this;
		if (Conditions != null)
		{
			result.Conditions = new List<FDetectCondition>(Conditions);
		}
		return result;
	}

	public static FDetectUnitCondition FromNative(IntPtr nativeBuffer)
	{
		return new FDetectUnitCondition(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FDetectUnitCondition value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FDetectUnitCondition FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FDetectUnitCondition(IntPtr.Add(nativeBuffer, arrayIndex * DetectUnitCondition_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FDetectUnitCondition value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * DetectUnitCondition_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (DetectUnitCondition_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.DetectUnitCondition");
			return;
		}
		EnumMarshaler<EDetectedUnitType>.ToNative(IntPtr.Add(nativeStruct, UnitType_Offset), 0, UnitType_PropertyAddress.Address, UnitType);
		FGsSmartParam.ToNative(IntPtr.Add(nativeStruct, SmartUnit_Offset), SmartUnit);
		new TArrayCopyMarshaler<FDetectCondition>(1, Conditions_PropertyAddress, CachedMarshalingDelegates<FDetectCondition, FDetectCondition>.FromNative, CachedMarshalingDelegates<FDetectCondition, FDetectCondition>.ToNative).ToNative(IntPtr.Add(nativeStruct, Conditions_Offset), Conditions);
		EnumMarshaler<EConditionalRelation>.ToNative(IntPtr.Add(nativeStruct, ConditionalRelation_Offset), 0, ConditionalRelation_PropertyAddress.Address, ConditionalRelation);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, Comment_Offset), Comment);
		FBossPhaseInfo.ToNative(IntPtr.Add(nativeStruct, BossPhaseInfo_Offset), BossPhaseInfo);
	}

	public FDetectUnitCondition(IntPtr nativeStruct)
	{
		if (DetectUnitCondition_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.DetectUnitCondition");
			UnitType = EDetectedUnitType.Self;
			SmartUnit = default(FGsSmartParam);
			Conditions = null;
			ConditionalRelation = EConditionalRelation.And;
			Comment = null;
			BossPhaseInfo = default(FBossPhaseInfo);
		}
		else
		{
			UnitType = EnumMarshaler<EDetectedUnitType>.FromNative(IntPtr.Add(nativeStruct, UnitType_Offset), 0, UnitType_PropertyAddress.Address);
			SmartUnit = FGsSmartParam.FromNative(IntPtr.Add(nativeStruct, SmartUnit_Offset));
			Conditions = new TArrayCopyMarshaler<FDetectCondition>(1, Conditions_PropertyAddress, CachedMarshalingDelegates<FDetectCondition, FDetectCondition>.FromNative, CachedMarshalingDelegates<FDetectCondition, FDetectCondition>.ToNative).FromNative(IntPtr.Add(nativeStruct, Conditions_Offset));
			ConditionalRelation = EnumMarshaler<EConditionalRelation>.FromNative(IntPtr.Add(nativeStruct, ConditionalRelation_Offset), 0, ConditionalRelation_PropertyAddress.Address);
			Comment = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, Comment_Offset));
			BossPhaseInfo = FBossPhaseInfo.FromNative(IntPtr.Add(nativeStruct, BossPhaseInfo_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.DetectUnitCondition");
		DetectUnitCondition_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref UnitType_PropertyAddress, intPtr, "UnitType");
		UnitType_Offset = NativeReflection.GetPropertyOffset(intPtr, "UnitType");
		UnitType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UnitType", Classes.FEnumProperty);
		SmartUnit_Offset = NativeReflection.GetPropertyOffset(intPtr, "SmartUnit");
		SmartUnit_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SmartUnit", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref Conditions_PropertyAddress, intPtr, "Conditions");
		Conditions_Offset = NativeReflection.GetPropertyOffset(intPtr, "Conditions");
		Conditions_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Conditions", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref ConditionalRelation_PropertyAddress, intPtr, "ConditionalRelation");
		ConditionalRelation_Offset = NativeReflection.GetPropertyOffset(intPtr, "ConditionalRelation");
		ConditionalRelation_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ConditionalRelation", Classes.FEnumProperty);
		Comment_Offset = NativeReflection.GetPropertyOffset(intPtr, "Comment");
		Comment_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Comment", Classes.FStrProperty);
		BossPhaseInfo_Offset = NativeReflection.GetPropertyOffset(intPtr, "BossPhaseInfo");
		BossPhaseInfo_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BossPhaseInfo", Classes.FStructProperty);
		DetectUnitCondition_IsValid = ((intPtr != IntPtr.Zero && UnitType_IsValid && SmartUnit_IsValid && Conditions_IsValid && ConditionalRelation_IsValid && Comment_IsValid && BossPhaseInfo_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.DetectUnitCondition", (byte)DetectUnitCondition_IsValid != 0);
	}

	static FDetectUnitCondition()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FDetectUnitCondition)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FDetectUnitCondition));
	}
}

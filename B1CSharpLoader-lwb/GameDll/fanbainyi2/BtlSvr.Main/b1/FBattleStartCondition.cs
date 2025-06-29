using System;
using b1.Plugins.Calliope;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.BattleStartCondition")]
public struct FBattleStartCondition
{
	[DisplayName("开始条件类型")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BattleStartCondition:StartConditionType")]
	public EBattleStartConditionType StartConditionType;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("检测激活怪物")]
	[USharpPath("/Script/b1-Managed.BattleStartCondition:Unit")]
	public FGsSmartParam Unit;

	[DisplayName("检测激活刷怪器")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BattleStartCondition:Spawner")]
	public FGsSmartParam Spawner;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("检测的触发盒")]
	[USharpPath("/Script/b1-Managed.BattleStartCondition:Overlap")]
	public FGsSmartParam Overlap;

	private static int BattleStartCondition_StructSize;

	private static int BattleStartCondition_IsValid;

	private static bool StartConditionType_IsValid;

	private static int StartConditionType_Offset;

	private static FFieldAddress StartConditionType_PropertyAddress;

	private static bool Unit_IsValid;

	private static int Unit_Offset;

	private static bool Spawner_IsValid;

	private static int Spawner_Offset;

	private static bool Overlap_IsValid;

	private static int Overlap_Offset;

	public FBattleStartCondition Copy()
	{
		return this;
	}

	public static FBattleStartCondition FromNative(IntPtr nativeBuffer)
	{
		return new FBattleStartCondition(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FBattleStartCondition value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FBattleStartCondition FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FBattleStartCondition(IntPtr.Add(nativeBuffer, arrayIndex * BattleStartCondition_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FBattleStartCondition value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * BattleStartCondition_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (BattleStartCondition_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BattleStartCondition");
			return;
		}
		EnumMarshaler<EBattleStartConditionType>.ToNative(IntPtr.Add(nativeStruct, StartConditionType_Offset), 0, StartConditionType_PropertyAddress.Address, StartConditionType);
		FGsSmartParam.ToNative(IntPtr.Add(nativeStruct, Unit_Offset), Unit);
		FGsSmartParam.ToNative(IntPtr.Add(nativeStruct, Spawner_Offset), Spawner);
		FGsSmartParam.ToNative(IntPtr.Add(nativeStruct, Overlap_Offset), Overlap);
	}

	public FBattleStartCondition(IntPtr nativeStruct)
	{
		if (BattleStartCondition_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BattleStartCondition");
			StartConditionType = EBattleStartConditionType.Auto;
			Unit = default(FGsSmartParam);
			Spawner = default(FGsSmartParam);
			Overlap = default(FGsSmartParam);
		}
		else
		{
			StartConditionType = EnumMarshaler<EBattleStartConditionType>.FromNative(IntPtr.Add(nativeStruct, StartConditionType_Offset), 0, StartConditionType_PropertyAddress.Address);
			Unit = FGsSmartParam.FromNative(IntPtr.Add(nativeStruct, Unit_Offset));
			Spawner = FGsSmartParam.FromNative(IntPtr.Add(nativeStruct, Spawner_Offset));
			Overlap = FGsSmartParam.FromNative(IntPtr.Add(nativeStruct, Overlap_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.BattleStartCondition");
		BattleStartCondition_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref StartConditionType_PropertyAddress, intPtr, "StartConditionType");
		StartConditionType_Offset = NativeReflection.GetPropertyOffset(intPtr, "StartConditionType");
		StartConditionType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StartConditionType", Classes.FEnumProperty);
		Unit_Offset = NativeReflection.GetPropertyOffset(intPtr, "Unit");
		Unit_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Unit", Classes.FStructProperty);
		Spawner_Offset = NativeReflection.GetPropertyOffset(intPtr, "Spawner");
		Spawner_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Spawner", Classes.FStructProperty);
		Overlap_Offset = NativeReflection.GetPropertyOffset(intPtr, "Overlap");
		Overlap_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Overlap", Classes.FStructProperty);
		BattleStartCondition_IsValid = ((intPtr != IntPtr.Zero && StartConditionType_IsValid && Unit_IsValid && Spawner_IsValid && Overlap_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.BattleStartCondition", (byte)BattleStartCondition_IsValid != 0);
	}

	static FBattleStartCondition()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FBattleStartCondition)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FBattleStartCondition));
	}
}

using System;
using b1.Plugins.Calliope;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.ProcessUnitTriggerBattleConfig")]
public struct FProcessUnitTriggerBattleConfig
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("单位")]
	[USharpPath("/Script/b1-Managed.ProcessUnitTriggerBattleConfig:Unit")]
	public FGsSmartParam Unit;

	[BlueprintReadWrite]
	[DisplayName("开战切换队伍ID")]
	[Tooltip("开战队伍ID大于0，触发混战后会切换队伍到对应ID；若小于等于0，则不切换队伍。")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.ProcessUnitTriggerBattleConfig:SwitchTeamID")]
	public int SwitchTeamID;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("开战目标")]
	[Tooltip("若配置了开战目标，触发混战后，会指定其为当前目标，若已有目标，则加入仇恨列表。若未配置则没有操作。")]
	[USharpPath("/Script/b1-Managed.ProcessUnitTriggerBattleConfig:TargetUnit")]
	public FGsSmartParam TargetUnit;

	private static int ProcessUnitTriggerBattleConfig_StructSize;

	private static int ProcessUnitTriggerBattleConfig_IsValid;

	private static bool Unit_IsValid;

	private static int Unit_Offset;

	private static bool SwitchTeamID_IsValid;

	private static int SwitchTeamID_Offset;

	private static bool TargetUnit_IsValid;

	private static int TargetUnit_Offset;

	public FProcessUnitTriggerBattleConfig Copy()
	{
		return this;
	}

	public static FProcessUnitTriggerBattleConfig FromNative(IntPtr nativeBuffer)
	{
		return new FProcessUnitTriggerBattleConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FProcessUnitTriggerBattleConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FProcessUnitTriggerBattleConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FProcessUnitTriggerBattleConfig(IntPtr.Add(nativeBuffer, arrayIndex * ProcessUnitTriggerBattleConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FProcessUnitTriggerBattleConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * ProcessUnitTriggerBattleConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (ProcessUnitTriggerBattleConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.ProcessUnitTriggerBattleConfig");
			return;
		}
		FGsSmartParam.ToNative(IntPtr.Add(nativeStruct, Unit_Offset), Unit);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, SwitchTeamID_Offset), SwitchTeamID);
		FGsSmartParam.ToNative(IntPtr.Add(nativeStruct, TargetUnit_Offset), TargetUnit);
	}

	public FProcessUnitTriggerBattleConfig(IntPtr nativeStruct)
	{
		if (ProcessUnitTriggerBattleConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.ProcessUnitTriggerBattleConfig");
			Unit = default(FGsSmartParam);
			SwitchTeamID = 0;
			TargetUnit = default(FGsSmartParam);
		}
		else
		{
			Unit = FGsSmartParam.FromNative(IntPtr.Add(nativeStruct, Unit_Offset));
			SwitchTeamID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, SwitchTeamID_Offset));
			TargetUnit = FGsSmartParam.FromNative(IntPtr.Add(nativeStruct, TargetUnit_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.ProcessUnitTriggerBattleConfig");
		ProcessUnitTriggerBattleConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		Unit_Offset = NativeReflection.GetPropertyOffset(intPtr, "Unit");
		Unit_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Unit", Classes.FStructProperty);
		SwitchTeamID_Offset = NativeReflection.GetPropertyOffset(intPtr, "SwitchTeamID");
		SwitchTeamID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SwitchTeamID", Classes.FIntProperty);
		TargetUnit_Offset = NativeReflection.GetPropertyOffset(intPtr, "TargetUnit");
		TargetUnit_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TargetUnit", Classes.FStructProperty);
		ProcessUnitTriggerBattleConfig_IsValid = ((intPtr != IntPtr.Zero && Unit_IsValid && SwitchTeamID_IsValid && TargetUnit_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.ProcessUnitTriggerBattleConfig", (byte)ProcessUnitTriggerBattleConfig_IsValid != 0);
	}

	static FProcessUnitTriggerBattleConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FProcessUnitTriggerBattleConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FProcessUnitTriggerBattleConfig));
	}
}

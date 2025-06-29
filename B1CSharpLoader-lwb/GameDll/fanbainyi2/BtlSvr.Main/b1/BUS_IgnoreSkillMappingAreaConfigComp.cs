using System;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_IgnoreSkillMappingAreaConfigComp")]
public class BUS_IgnoreSkillMappingAreaConfigComp : UActorEditCompBase
{
	private static bool SkillMappingTypeMask_IsValid;

	private static int SkillMappingTypeMask_Offset;

	private static bool SkillMappingResultRullMask_IsValid;

	private static int SkillMappingResultRullMask_Offset;

	[DisplayName("忽视的SkillMappingType")]
	[UProperty]
	[UMeta(MDEnum.Bitmask)]
	[UMeta(MDEnum.BitmaskEnum, "SkillMappingType")]
	[Category("IgnoreSkillMapping config")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_IgnoreSkillMappingAreaConfigComp:SkillMappingTypeMask")]
	public int SkillMappingTypeMask
	{
		get
		{
			CheckDestroyed();
			if (!SkillMappingTypeMask_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_IgnoreSkillMappingAreaConfigComp:SkillMappingTypeMask");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, SkillMappingTypeMask_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SkillMappingTypeMask_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_IgnoreSkillMappingAreaConfigComp:SkillMappingTypeMask");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, SkillMappingTypeMask_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("忽视的SkillMappingResultRull")]
	[Category("IgnoreSkillMapping config")]
	[UMeta(MDEnum.Bitmask)]
	[UMeta(MDEnum.BitmaskEnum, "SkillMappingResultRull")]
	[USharpPath("/Script/b1-Managed.BUS_IgnoreSkillMappingAreaConfigComp:SkillMappingResultRullMask")]
	public int SkillMappingResultRullMask
	{
		get
		{
			CheckDestroyed();
			if (!SkillMappingResultRullMask_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_IgnoreSkillMappingAreaConfigComp:SkillMappingResultRullMask");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, SkillMappingResultRullMask_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SkillMappingResultRullMask_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_IgnoreSkillMappingAreaConfigComp:SkillMappingResultRullMask");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, SkillMappingResultRullMask_Offset), value);
			}
		}
	}

	public override void OnDataConvert(AActor Owner)
	{
		b1.BUC_IgnoreSkillMappingLogicData bUC_IgnoreSkillMappingLogicData = RequireWritableData<b1.BUC_IgnoreSkillMappingLogicData>();
		foreach (ESkillMappingConditionType value5 in Enum.GetValues(typeof(ESkillMappingConditionType)))
		{
			int num = (int)value5;
			num = 1 << num;
			if (value5 != ESkillMappingConditionType.EnumMax && (num & SkillMappingTypeMask) != 0)
			{
				if (!bUC_IgnoreSkillMappingLogicData.IgnoredMappingTypeMap.TryGetValue(value5, out var value))
				{
					bUC_IgnoreSkillMappingLogicData.IgnoredMappingTypeMap.Add(value5, value: true);
				}
				else if (!value)
				{
					bUC_IgnoreSkillMappingLogicData.IgnoredMappingTypeMap[value5] = true;
				}
				if (!bUC_IgnoreSkillMappingLogicData.IgnoredMappingTypeRemoveMap.TryGetValue(value5, out var value2))
				{
					bUC_IgnoreSkillMappingLogicData.IgnoredMappingTypeRemoveMap.Add(value5, value: false);
				}
				else if (value2)
				{
					bUC_IgnoreSkillMappingLogicData.IgnoredMappingTypeRemoveMap[value5] = false;
				}
			}
		}
		foreach (ESkillMappingResultRull value6 in Enum.GetValues(typeof(ESkillMappingResultRull)))
		{
			int num2 = (int)value6;
			num2 = 1 << num2;
			if (value6 != ESkillMappingResultRull.EnumMax && (num2 & SkillMappingResultRullMask) != 0)
			{
				if (!bUC_IgnoreSkillMappingLogicData.IgnoredMappingResultRullMap.TryGetValue(value6, out var value3))
				{
					bUC_IgnoreSkillMappingLogicData.IgnoredMappingResultRullMap.Add(value6, value: true);
				}
				else if (!value3)
				{
					bUC_IgnoreSkillMappingLogicData.IgnoredMappingResultRullMap[value6] = true;
				}
				if (!bUC_IgnoreSkillMappingLogicData.IgnoredMappingResultRullRemoveMap.TryGetValue(value6, out var value4))
				{
					bUC_IgnoreSkillMappingLogicData.IgnoredMappingResultRullRemoveMap.Add(value6, value: false);
				}
				else if (value4)
				{
					bUC_IgnoreSkillMappingLogicData.IgnoredMappingResultRullRemoveMap[value6] = false;
				}
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_IgnoreSkillMappingAreaConfigComp");
		SkillMappingTypeMask_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SkillMappingTypeMask");
		SkillMappingTypeMask_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SkillMappingTypeMask", Classes.FIntProperty);
		SkillMappingResultRullMask_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SkillMappingResultRullMask");
		SkillMappingResultRullMask_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SkillMappingResultRullMask", Classes.FIntProperty);
	}

	static BUS_IgnoreSkillMappingAreaConfigComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_IgnoreSkillMappingAreaConfigComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_IgnoreSkillMappingAreaConfigComp));
	}
}

using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_IgnoreSkillMappingAreaDataComp")]
public class BUS_IgnoreSkillMappingAreaDataComp : BUS_AreaBaseDataContainer
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<b1.BUC_IgnoreSkillMappingLogicData>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_IgnoreSkillMappingAreaDataComp");
	}

	static BUS_IgnoreSkillMappingAreaDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_IgnoreSkillMappingAreaDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_IgnoreSkillMappingAreaDataComp));
	}
}

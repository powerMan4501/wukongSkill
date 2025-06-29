using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_POMDecalDataComp")]
public class BUS_POMDecalDataComp : BUS_DecalDataComp
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<BUC_POMDecalCommData>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_POMDecalDataComp");
	}

	static BUS_POMDecalDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_POMDecalDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_POMDecalDataComp));
	}
}

using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BPS_ReplayPlayerControllerDataComp")]
public class BPS_ReplayPlayerControllerDataComp : BUS_ActorBaseDataComp
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BPS_ReplayPlayerControllerDataComp");
	}

	static BPS_ReplayPlayerControllerDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BPS_ReplayPlayerControllerDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BPS_ReplayPlayerControllerDataComp));
	}
}

using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Render;

[UClass]
[USharpPath("/Script/b1-Managed.FluidSimulationInteractor")]
public class FluidSimulationInteractor : UActorComponent
{
	private void Tick()
	{
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.FluidSimulationInteractor");
	}

	static FluidSimulationInteractor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FluidSimulationInteractor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FluidSimulationInteractor));
	}
}

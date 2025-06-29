using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.MovieNodeInstance_AfterPlay")]
public class MovieNodeInstance_AfterPlay : MovieNodeInstance
{
	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		TriggerFirstOutput();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.MovieNodeInstance_AfterPlay");
	}

	static MovieNodeInstance_AfterPlay()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(MovieNodeInstance_AfterPlay)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(MovieNodeInstance_AfterPlay));
	}
}

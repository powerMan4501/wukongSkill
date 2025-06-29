using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.MovieNodeInstance_OnSkipping")]
public class MovieNodeInstance_OnSkipping : MovieNodeInstance
{
	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		TriggerFirstOutput();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.MovieNodeInstance_OnSkipping");
	}

	static MovieNodeInstance_OnSkipping()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(MovieNodeInstance_OnSkipping)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(MovieNodeInstance_OnSkipping));
	}
}

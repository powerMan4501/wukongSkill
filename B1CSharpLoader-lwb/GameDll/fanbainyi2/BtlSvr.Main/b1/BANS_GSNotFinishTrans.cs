using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("BANS NotFinishTrans")]
[UClass]
[USharpPath("/Script/b1-Managed.BANS_GSNotFinishTrans")]
internal class BANS_GSNotFinishTrans : UAnimNotifyState
{
	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSNotFinishTrans");
	}

	static BANS_GSNotFinishTrans()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_GSNotFinishTrans)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_GSNotFinishTrans));
	}
}

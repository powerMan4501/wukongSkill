using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("【无用节点！会直接以成功执行返回】ReturnHome")]
[USharpPath("/Script/b1-Managed.BAIT_ReturnHome")]
internal class BAIT_ReturnHome : BAIT_Base
{
	public override void Initialize(FObjectInitializer initializer)
	{
		string nodeNameInCS = (base.CustomDescription = "【无用节点！会直接以成功执行返回！看到麻烦删除！】ReturnHome");
		SetNodeNameInCS(nodeNameInCS);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAIT_ReturnHome");
	}

	static BAIT_ReturnHome()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAIT_ReturnHome)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAIT_ReturnHome));
	}
}

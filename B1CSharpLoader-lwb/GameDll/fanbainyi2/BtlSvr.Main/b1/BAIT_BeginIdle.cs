using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("【无用节点！会直接以成功执行返回】BeginIdle")]
[USharpPath("/Script/b1-Managed.BAIT_BeginIdle")]
internal class BAIT_BeginIdle : BAIT_Base
{
	public override void Initialize(FObjectInitializer initializer)
	{
		string nodeNameInCS = (base.CustomDescription = "【无用节点！会直接以成功执行返回！看到麻烦删除！】BeginIdle");
		SetNodeNameInCS(nodeNameInCS);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAIT_BeginIdle");
	}

	static BAIT_BeginIdle()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAIT_BeginIdle)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAIT_BeginIdle));
	}
}

using System;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("【无用节点！作用无效】StdUnitAITick")]
[UClass]
[USharpPath("/Script/b1-Managed.BAIS_StdUnitAITick")]
internal class BAIS_StdUnitAITick : BAIS_Base
{
	public override void Initialize(FObjectInitializer initializer)
	{
		string nodeNameInCS = (base.CustomDescription = "【无用节点！作用无效！看到麻烦删除！】StdUnitAITick");
		SetNodeNameInCS(nodeNameInCS);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAIS_StdUnitAITick");
	}

	static BAIS_StdUnitAITick()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAIS_StdUnitAITick)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAIS_StdUnitAITick));
	}
}

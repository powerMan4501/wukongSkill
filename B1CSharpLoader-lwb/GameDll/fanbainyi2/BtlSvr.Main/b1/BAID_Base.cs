using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BAID_Base")]
public class BAID_Base : UBTDecorator_USharpBase
{
	public virtual bool PerformConditionCheck(AActor OwnerActor)
	{
		return false;
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAID_Base");
	}

	static BAID_Base()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BAID_Base)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BAID_Base));
	}
}

using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BAIS_Base")]
public class BAIS_Base : UBTService_USharpBase
{
	public virtual void ReceiveTick(AActor OwnerActor, float DeltaSeconds)
	{
	}

	public virtual void ReceiveActivation(AActor OwnerActor)
	{
	}

	public virtual void ReceiveDeactivation(AActor OwnerActor)
	{
	}

	public virtual void ReceiveSearchStart(AActor OwnerActor)
	{
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAIS_Base");
	}

	static BAIS_Base()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BAIS_Base)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BAIS_Base));
	}
}

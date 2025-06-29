using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_ActorCallComp")]
internal class BUS_ActorCallComp : UActorEditCompBase
{
	private static bool CallActorCls_IsValid;

	private static int CallActorCls_Offset;

	[UProperty]
	[EditAnywhere]
	[Category("Actor Call Config")]
	[USharpPath("/Script/b1-Managed.BUS_ActorCallComp:CallActorCls")]
	public TSubclassOf<AActor> CallActorCls
	{
		get
		{
			CheckDestroyed();
			if (!CallActorCls_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ActorCallComp:CallActorCls");
				return default(TSubclassOf<AActor>);
			}
			return TSubclassOfMarshaler<AActor>.FromNative(IntPtr.Add(base.Address, CallActorCls_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CallActorCls_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ActorCallComp:CallActorCls");
			}
			else
			{
				TSubclassOfMarshaler<AActor>.ToNative(IntPtr.Add(base.Address, CallActorCls_Offset), value);
			}
		}
	}

	public override void OnDataConvert(AActor Owner)
	{
		RequireWritableData<b1.BUC_ActorCallData>().CallActorCls = CallActorCls.GetDefaultObject();
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_ActorCallComp");
		CallActorCls_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CallActorCls");
		CallActorCls_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CallActorCls", Classes.FClassProperty);
	}

	static BUS_ActorCallComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BUS_ActorCallComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BUS_ActorCallComp));
	}
}

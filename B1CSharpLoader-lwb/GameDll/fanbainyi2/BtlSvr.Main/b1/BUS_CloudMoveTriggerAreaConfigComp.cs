using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_CloudMoveTriggerAreaConfigComp")]
public class BUS_CloudMoveTriggerAreaConfigComp : UActorEditCompBase
{
	private static bool PreCoolDown_IsValid;

	private static int PreCoolDown_Offset;

	[DisplayName("触发逻辑的预置CD")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_CloudMoveTriggerAreaConfigComp:PreCoolDown")]
	public float PreCoolDown
	{
		get
		{
			CheckDestroyed();
			if (!PreCoolDown_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_CloudMoveTriggerAreaConfigComp:PreCoolDown");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, PreCoolDown_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PreCoolDown_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_CloudMoveTriggerAreaConfigComp:PreCoolDown");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, PreCoolDown_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
	}

	public override void OnDataConvert(AActor Owner)
	{
		RequireWritableData<BUC_CloudMoveTriggerAreaData>().PreCoolDown = PreCoolDown;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_CloudMoveTriggerAreaConfigComp");
		PreCoolDown_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PreCoolDown");
		PreCoolDown_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PreCoolDown", Classes.FFloatProperty);
	}

	static BUS_CloudMoveTriggerAreaConfigComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_CloudMoveTriggerAreaConfigComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_CloudMoveTriggerAreaConfigComp));
	}
}

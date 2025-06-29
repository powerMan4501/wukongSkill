using System;
using UnrealEngine.Runtime;

namespace b1;

[Placeable(false)]
[UClass]
[DisplayName("计数器（Counter）")]
[USharpPath("/Script/b1-Managed.BED_ProcessMachineNode_Counter")]
public class BED_ProcessMachineNode_Counter : BED_ProcessMachineNode_TemplateBase
{
	private static bool Goal_IsValid;

	private static int Goal_Offset;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("目标数")]
	[USharpPath("/Script/b1-Managed.BED_ProcessMachineNode_Counter:Goal")]
	public int Goal
	{
		get
		{
			CheckDestroyed();
			if (!Goal_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessMachineNode_Counter:Goal");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, Goal_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Goal_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessMachineNode_Counter:Goal");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, Goal_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		base.Initialize(Initializer);
		base.SupportsContextPins = false;
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.ProcessMachineNode.Counter;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BED_ProcessMachineNode_Counter");
		Goal_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Goal");
		Goal_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Goal", Classes.FIntProperty);
	}

	static BED_ProcessMachineNode_Counter()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_ProcessMachineNode_Counter)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_ProcessMachineNode_Counter));
	}
}

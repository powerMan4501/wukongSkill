using System;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("表演阶段")]
[CollapseCategories(true)]
[EditInlineNew]
[UClass]
[USharpPath("/Script/b1-Managed.PerformerPhase")]
public class UPerformerPhase : UObject
{
	private static bool NextCondition_IsValid;

	private static int NextCondition_Offset;

	private static bool Actions_IsValid;

	private static int Actions_Offset;

	private static FFieldAddress Actions_PropertyAddress;

	private TArrayReadWriteMarshaler<UPerformerActionBase> Actions_Marshaler;

	[EditAnywhere]
	[DisplayName("阶段结束条件")]
	[UProperty(PropFlags.Instanced)]
	[USharpPath("/Script/b1-Managed.PerformerPhase:NextCondition")]
	private PerformerConditionBase NextCondition
	{
		get
		{
			CheckDestroyed();
			if (!NextCondition_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PerformerPhase:NextCondition");
				return null;
			}
			return UObjectMarshaler<PerformerConditionBase>.FromNative(IntPtr.Add(base.Address, NextCondition_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NextCondition_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PerformerPhase:NextCondition");
			}
			else
			{
				UObjectMarshaler<PerformerConditionBase>.ToNative(IntPtr.Add(base.Address, NextCondition_Offset), value);
			}
		}
	}

	[UProperty(PropFlags.Instanced)]
	[EditAnywhere]
	[DisplayName("阶段开始时执行的逻辑")]
	[USharpPath("/Script/b1-Managed.PerformerPhase:Actions")]
	private TArrayReadWrite<UPerformerActionBase> Actions
	{
		get
		{
			CheckDestroyed();
			if (!Actions_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PerformerPhase:Actions");
				return null;
			}
			if (Actions_Marshaler == null)
			{
				Actions_Marshaler = new TArrayReadWriteMarshaler<UPerformerActionBase>(1, Actions_PropertyAddress, CachedMarshalingDelegates<UPerformerActionBase, UObjectMarshaler<UPerformerActionBase>>.FromNative, CachedMarshalingDelegates<UPerformerActionBase, UObjectMarshaler<UPerformerActionBase>>.ToNative);
			}
			return Actions_Marshaler.FromNative(IntPtr.Add(base.Address, Actions_Offset));
		}
	}

	public void SetOwnerComp(BUS_PerformerControlComp InControlComp)
	{
		NextCondition?.SetOwnerComp(InControlComp);
		foreach (UPerformerActionBase action in Actions)
		{
			if (action != null)
			{
				action.SetOwnerComp(InControlComp);
			}
		}
	}

	public void EnterPhase()
	{
		NextCondition?.NotifyBegin();
		DoActions();
	}

	public void ExitPhase()
	{
		NextCondition?.NotifyEnd();
		EndActions();
	}

	public void Tick(float InDeltaTime)
	{
		foreach (UPerformerActionBase action in Actions)
		{
			action.NotifyTick(InDeltaTime);
		}
		NextCondition?.NotifyTick(InDeltaTime);
	}

	public bool CanTriggerNext()
	{
		foreach (UPerformerActionBase action in Actions)
		{
			if (!action.bFinished)
			{
				return false;
			}
		}
		if (NextCondition != null)
		{
			return NextCondition.IsConditionSuccess();
		}
		return true;
	}

	private void DoActions()
	{
		foreach (UPerformerActionBase action in Actions)
		{
			action.NotifyDoAction();
		}
	}

	private void EndActions()
	{
		foreach (UPerformerActionBase action in Actions)
		{
			action.NotifyEndAction();
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.PerformerPhase");
		NextCondition_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "NextCondition");
		NextCondition_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "NextCondition", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref Actions_PropertyAddress, unrealStruct, "Actions");
		Actions_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Actions");
		Actions_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Actions", Classes.FArrayProperty);
	}

	static UPerformerPhase()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(UPerformerPhase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPerformerPhase));
	}
}

using System;
using b1.Plugins.Calliope;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[Abstract]
[EditInlineNew]
[CollapseCategories(true)]
[USharpPath("/Script/b1-Managed.PerformerActionBase")]
public class UPerformerActionBase : UObject
{
	protected BUS_PerformerControlComp ControlComp { get; set; }

	protected virtual bool bCanAlwaysTick => false;

	public bool bFinished { get; private set; }

	public void SetOwnerComp(BUS_PerformerControlComp InControlComp)
	{
		ControlComp = InControlComp;
	}

	public void NotifyDoAction()
	{
		bFinished = DoAction();
	}

	protected virtual bool DoAction()
	{
		return true;
	}

	public void NotifyTick(float InDeltaTime)
	{
		if (!bFinished || bCanAlwaysTick)
		{
			bFinished = OnTick(InDeltaTime);
		}
	}

	protected virtual bool OnTick(float InDeltaTime)
	{
		return true;
	}

	public void NotifyEndAction()
	{
		OnEndAction();
	}

	protected virtual void OnEndAction()
	{
	}

	protected BGUPerformerActorCS GetPerformer(FGsSmartParam Performer)
	{
		if (ControlComp.GetParamActorGuid(Performer.ConfigGuid, out var OutActorGuid))
		{
			return BGU_DataUtil.GetActorByGuid(this, OutActorGuid) as BGUPerformerActorCS;
		}
		return null;
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.PerformerActionBase");
	}

	static UPerformerActionBase()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(UPerformerActionBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPerformerActionBase));
	}
}

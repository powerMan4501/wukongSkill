using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[Abstract]
[EditInlineNew]
[CollapseCategories(true)]
[USharpPath("/Script/b1-Managed.PerformerConditionBase")]
public class PerformerConditionBase : UObject
{
	protected BUS_PerformerControlComp ControlComp { get; set; }

	public virtual void SetOwnerComp(BUS_PerformerControlComp InControlComp)
	{
		ControlComp = InControlComp;
	}

	public bool IsConditionSuccess()
	{
		return IsSuccess();
	}

	protected virtual bool IsSuccess()
	{
		return true;
	}

	public void NotifyBegin()
	{
		OnBegin();
	}

	protected virtual void OnBegin()
	{
	}

	public void NotifyEnd()
	{
		OnEnd();
	}

	protected virtual void OnEnd()
	{
	}

	public void NotifyTick(float InDeltaTime)
	{
		OnTick(InDeltaTime);
	}

	protected virtual void OnTick(float InDeltaTime)
	{
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.PerformerConditionBase");
	}

	static PerformerConditionBase()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(PerformerConditionBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(PerformerConditionBase));
	}
}

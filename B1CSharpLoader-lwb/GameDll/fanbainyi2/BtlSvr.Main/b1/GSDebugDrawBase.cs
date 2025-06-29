using System;
using b1.UI;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.GSDebugDrawBase")]
public class GSDebugDrawBase : BUI_Widget
{
	private int ReqId;

	protected DebugDataBase Data;

	protected readonly GSBindProp<bool> IsShowing = new GSBindProp<bool>();

	protected float ShowingTime;

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		Init();
	}

	protected override void OnUIGSInnerTickImpl(float InDeltaTime)
	{
		base.OnUIGSInnerTickImpl(InDeltaTime);
		if (IsShowing.Value)
		{
			ShowingTime += InDeltaTime;
		}
		if (Data != null && Data.DestroyTime > 0f && ShowingTime >= Data.DestroyTime)
		{
			Stop();
		}
	}

	private void OnChangeIsShowing(EChangeReason Reason, bool OldValue, bool NewValue)
	{
		if (Reason != EChangeReason.Init)
		{
			if (NewValue)
			{
				ShowingTime = 0f;
				SetVisibility(ESlateVisibility.HitTestInvisible);
			}
			else
			{
				RemoveFromParent();
			}
		}
	}

	protected virtual void Init()
	{
	}

	public void InitData(int InReqId, DebugDataBase InData)
	{
		ReleaseBindAction();
		BindEntryEvent();
		if (Data != InData)
		{
			ReqId = InReqId;
			Data = InData;
			BindEvent();
		}
	}

	protected virtual void BindEntryEvent()
	{
		BindValueToCustom(IsShowing, OnChangeIsShowing);
	}

	protected virtual void BindEvent()
	{
	}

	public void Play()
	{
		IsShowing.SetValue(EChangeReason.ManualSet, value: true);
	}

	public void Stop()
	{
		IsShowing.SetValue(EChangeReason.ManualSet, value: false);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.GSDebugDrawBase");
	}

	static GSDebugDrawBase()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(GSDebugDrawBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(GSDebugDrawBase));
	}
}

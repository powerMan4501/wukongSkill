using System;
using b1.GSMUI;
using UnrealEngine.Runtime;

namespace b1;

public class BindDataDelayEvent : UIBindData, IGSMUITickable
{
	private GSMUITickMgr GSTickMgr;

	private float DelayTime;

	private Action DelayAction;

	private float CurTime;

	private bool NeedTick;

	public BindDataDelayEvent(UIBindData InParent)
		: base(InParent)
	{
		RootWidget.BindMUITickMgr(this);
	}

	public void Start(Action InDelayAction, float InDelayTime)
	{
		CurTime = 0f;
		DelayAction = InDelayAction;
		StartTick();
	}

	private void StartTick()
	{
		NeedTick = true;
		GSTickMgr.SetTickingQueue(this);
	}

	public void Invoke()
	{
		CurTime = 0f;
		DelayAction?.Invoke();
		DelayAction = null;
		End();
	}

	public void End()
	{
		CurTime = 0f;
		NeedTick = false;
	}

	public void BindTickMgr(GSMUITickMgr InTickMgr)
	{
		GSTickMgr = InTickMgr;
	}

	public void DoGSTick(float InDeltaTime)
	{
		CurTime += InDeltaTime;
		if (CurTime > DelayTime)
		{
			Invoke();
		}
	}

	public bool IsGSNeedTick()
	{
		return NeedTick;
	}

	public bool IsUObjectDestroyed()
	{
		return RootWidget.IsNullOrDestroyed();
	}
}

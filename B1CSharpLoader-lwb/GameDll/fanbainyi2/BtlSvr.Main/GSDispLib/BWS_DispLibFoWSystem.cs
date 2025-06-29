using System;
using System.Collections.Generic;
using b1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

public class BWS_DispLibFoWSystem : BWS_DispLibCompBase
{
	private bool EnableFoW = true;

	private float TickInterval = 0.2f;

	private float TickTimer;

	private List<int> DelayOneFrameEvent = new List<int>();

	public override void OnBeginPlay()
	{
		base.OnBeginPlay();
		BWS_DispLibEventCollection bWS_DispLibEventCollection = BWS_DispLibEventCollection.Get(GetOwner());
		bWS_DispLibEventCollection.Env_RequestFoWEvent = (BWS_DispLibEventCollection.Del_VoidTwoInt)Delegate.Combine(bWS_DispLibEventCollection.Env_RequestFoWEvent, new BWS_DispLibEventCollection.Del_VoidTwoInt(OnFowEvent));
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		base.OnEndPlay(EndPlayReason);
		BWS_DispLibEventCollection bWS_DispLibEventCollection = BWS_DispLibEventCollection.Get(GetOwner());
		bWS_DispLibEventCollection.Env_RequestFoWEvent = (BWS_DispLibEventCollection.Del_VoidTwoInt)Delegate.Remove(bWS_DispLibEventCollection.Env_RequestFoWEvent, new BWS_DispLibEventCollection.Del_VoidTwoInt(OnFowEvent));
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (EnableFoW)
		{
			TickTimer -= DeltaTime;
			if (TickTimer <= 0f || TickTimer > TickInterval)
			{
				TickTimer = TickInterval;
			}
		}
	}

	public bool IsLocationInFOW(FVector Location)
	{
		return false;
	}

	private void OnStartFoW()
	{
		UDispLib_PPEffectParameters uDispLib_PPEffectParameters = UObject.NewObject<UDispLib_PPEffectParameters>(GetOwner());
		uDispLib_PPEffectParameters.Duration = -1f;
		uDispLib_PPEffectParameters.BeginningDuration = 0.1f;
		uDispLib_PPEffectParameters.FinishingDuration = 0.1f;
		BGW_LogUtil.LogError("[FowDebug] BWS_DispLibFoWSystem OnFowEvent Start FoW PP ");
	}

	private void OnStopFoW()
	{
		GetOwner();
	}

	private void OnResetFoW()
	{
	}

	private void OnAllowFoW()
	{
		if (!EnableFoW)
		{
			EnableFoW = true;
			OnStartFoW();
		}
	}

	private void OnForbidFoW()
	{
		if (EnableFoW)
		{
			EnableFoW = false;
			OnStopFoW();
		}
	}

	private void OnSwitchFoW()
	{
		if (EnableFoW)
		{
			OnStopFoW();
		}
		else
		{
			OnStartFoW();
		}
		EnableFoW = !EnableFoW;
	}

	private void OnDebugFoW()
	{
	}

	public void OnFowEvent(int State, int Delay)
	{
		ProcessEvent(State);
	}

	private void ProcessDelayEvent()
	{
		foreach (int item in DelayOneFrameEvent)
		{
			ProcessEvent(item);
		}
		DelayOneFrameEvent.Clear();
	}

	private void ProcessEvent(int State)
	{
		switch (State)
		{
		case 3:
			OnAllowFoW();
			return;
		case 4:
			OnForbidFoW();
			return;
		case 5:
			OnSwitchFoW();
			return;
		case 6:
			OnDebugFoW();
			return;
		}
		if (EnableFoW)
		{
			switch (State)
			{
			case 1:
				OnStartFoW();
				break;
			case 0:
				OnStopFoW();
				break;
			case 2:
				OnResetFoW();
				break;
			}
		}
	}
}

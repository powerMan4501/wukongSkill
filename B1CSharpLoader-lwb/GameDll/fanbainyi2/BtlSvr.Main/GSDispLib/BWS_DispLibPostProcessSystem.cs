using System;
using System.Collections.Generic;
using b1;
using b1.BGW;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

public class BWS_DispLibPostProcessSystem : BWS_DispLibCompBase
{
	private enum PPEffectGlobalState
	{
		Default,
		Forbid
	}

	private struct PostProcessEffectEvent
	{
		public int PostProcessType;

		public int Command;

		public int EffectIndex;

		public PPEffectParametersValue Parameters;
	}

	private Dictionary<int, BWS_PostProcessEffectBase> PostProcessEffects = new Dictionary<int, BWS_PostProcessEffectBase>();

	private Dictionary<int, int> PPEffectsGlobalState = new Dictionary<int, int>();

	private Dictionary<int, int> PPEffectsRefCount = new Dictionary<int, int>();

	private List<PostProcessEffectEvent> DelayPostProcessEffectEvents = new List<PostProcessEffectEvent>();

	private const string PostProcessConfPath = "/Game/DevTest/TestConf/U3_PostProcessConf.U3_PostProcessConf";

	private bool gEnable = true;

	private bool bInited;

	[UProperty]
	private GSDispLib_PostProcessContext Context { get; set; }

	public override void OnBeginPlay()
	{
		base.OnBeginPlay();
		BWS_DispLibEventCollection bWS_DispLibEventCollection = BWS_DispLibEventCollection.Get(GetOwner());
		bWS_DispLibEventCollection.Env_RequestPostProcessEvent = (BWS_DispLibEventCollection.Del_PostProcessEffect)Delegate.Combine(bWS_DispLibEventCollection.Env_RequestPostProcessEvent, new BWS_DispLibEventCollection.Del_PostProcessEffect(OnPostProcessEvent));
		bInited = false;
	}

	private void Clear()
	{
		DelayPostProcessEffectEvents.Clear();
		PPEffectsRefCount.Clear();
		PPEffectsGlobalState.Clear();
		foreach (KeyValuePair<int, BWS_PostProcessEffectBase> postProcessEffect in PostProcessEffects)
		{
			postProcessEffect.Value.OnDestroy(Context);
		}
		PostProcessEffects.Clear();
		if (Context != null && !Context.IsPendingKill && Context.ImageProcessor != null && !Context.ImageProcessor.IsPendingKill)
		{
			Context.ImageProcessor.Clear();
		}
	}

	private void UpdateContext()
	{
		APostProcessVolume[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass<APostProcessVolume>(GetOwner());
		if (allActorsOfClass.Length != 0 && !(allActorsOfClass[0] == null))
		{
			AActor owner = GetOwner();
			GSDispLib_PostProcessContext gSDispLib_PostProcessContext = UObject.NewObject<GSDispLib_PostProcessContext>(owner, B1GlobalFNames.Context, EObjectFlags.NoFlags, null, copyTransientsFromClassDefaults: true, (IntPtr)0);
			gSDispLib_PostProcessContext.Config = BGW_PreloadAssetMgr.Get(owner).TryGetCachedResourceObj<UDispLib_PostProcessConf>("/Game/DevTest/TestConf/U3_PostProcessConf.U3_PostProcessConf", ELoadResourceType.SyncLoadAndCache);
			gSDispLib_PostProcessContext.World = owner.World;
			gSDispLib_PostProcessContext.ImageProcessor = UObject.NewObject<BWS_DispLibImageProcessor>(owner, B1GlobalFNames.PPDebuggerParameters, EObjectFlags.ClassDefaultObject, null, copyTransientsFromClassDefaults: false, (IntPtr)0);
			gSDispLib_PostProcessContext.ImageProcessor.Init(owner, null);
			gSDispLib_PostProcessContext.PostProcessVolume = allActorsOfClass[0];
			Context = gSDispLib_PostProcessContext;
		}
	}

	private void AutoEnableAllEffect()
	{
		if (!(Context != null) || !(Context.Config != null))
		{
			return;
		}
		foreach (UDispLib_PostPorcessCommonConf commonConf in Context.Config.CommonConfs)
		{
			if (commonConf.AutoEnable)
			{
				OnPostProcessEvent(0, 1, commonConf.ID, null);
			}
		}
	}

	private void AutoEnableEffect(int EffectID)
	{
		if (!(Context != null) || !(Context.Config != null))
		{
			return;
		}
		foreach (UDispLib_PostPorcessCommonConf commonConf in Context.Config.CommonConfs)
		{
			if (commonConf.ID == EffectID && commonConf.AutoEnable)
			{
				OnPostProcessEvent(0, 1, EffectID, null);
				break;
			}
		}
	}

	private void AddDelayPPEffectEvent(int InPostProcessType, int InCommand, int InEffectIndex, UDispLib_PPEffectParameters InParameters)
	{
		PostProcessEffectEvent item = new PostProcessEffectEvent
		{
			PostProcessType = InPostProcessType,
			Command = InCommand,
			EffectIndex = InEffectIndex
		};
		if (InParameters != null)
		{
			item.Parameters = new PPEffectParametersValue();
			item.Parameters.CopyValue(InParameters);
		}
		DelayPostProcessEffectEvents.Add(item);
	}

	private void ProcessDelayEffectEvent()
	{
		foreach (PostProcessEffectEvent delayPostProcessEffectEvent in DelayPostProcessEffectEvents)
		{
			int num = delayPostProcessEffectEvent.EffectIndex;
			if (delayPostProcessEffectEvent.PostProcessType != 0)
			{
				num = 1000 + delayPostProcessEffectEvent.PostProcessType;
			}
			if (!PostProcessEffects.TryGetValue(num, out var value))
			{
				value = CreateEffect(delayPostProcessEffectEvent.PostProcessType, delayPostProcessEffectEvent.EffectIndex);
				PostProcessEffects.Add(num, value);
			}
			if (value == null)
			{
				continue;
			}
			if (delayPostProcessEffectEvent.Command == 1)
			{
				AddEffectRef(num);
				UDispLib_PPEffectParameters uDispLib_PPEffectParameters = null;
				if (delayPostProcessEffectEvent.Parameters != null)
				{
					uDispLib_PPEffectParameters = UObject.NewObject<UDispLib_PPEffectParameters>(GetOwner());
					uDispLib_PPEffectParameters.CopyValue(delayPostProcessEffectEvent.Parameters);
				}
				value.Begin(Context, uDispLib_PPEffectParameters);
			}
			else if (delayPostProcessEffectEvent.Command == 0 && RemoveEffectRef(num))
			{
				value.End(Context);
			}
		}
		DelayPostProcessEffectEvents.Clear();
	}

	public void OnPostProcessEvent(int PostProcessType, int Command, int EffectIndex, UDispLib_PPEffectParameters Parameters)
	{
		int num = EffectIndex;
		if (PostProcessType != 0)
		{
			num = 1000 + PostProcessType;
		}
		PPEffectGlobalState effectGlobalState = GetEffectGlobalState(num);
		switch (Command)
		{
		case 7:
			AllowAllExtentPostProcess(bEnable: false);
			return;
		case 6:
			AllowAllExtentPostProcess(bEnable: true);
			return;
		case 5:
			AllowAllExtentPostProcess(!gEnable);
			return;
		case 3:
			SetEffectGlobalState(num, PPEffectGlobalState.Forbid);
			return;
		case 2:
			SetEffectGlobalState(num, PPEffectGlobalState.Default);
			return;
		case 4:
		{
			PPEffectGlobalState state = ((effectGlobalState == PPEffectGlobalState.Default) ? PPEffectGlobalState.Forbid : PPEffectGlobalState.Default);
			SetEffectGlobalState(num, state);
			return;
		}
		case 9:
			RestartAllEffect();
			return;
		}
		if (!gEnable)
		{
			return;
		}
		if (Command == 8)
		{
			StopAllEffect();
			DelayPostProcessEffectEvents.Clear();
			PPEffectsRefCount.Clear();
			return;
		}
		if (effectGlobalState == PPEffectGlobalState.Forbid)
		{
			return;
		}
		if (Context == null || Context.PostProcessVolume == null)
		{
			AddDelayPPEffectEvent(PostProcessType, Command, EffectIndex, Parameters);
			return;
		}
		if (!PostProcessEffects.TryGetValue(num, out var value))
		{
			value = CreateEffect(PostProcessType, EffectIndex);
			PostProcessEffects.Add(num, value);
		}
		if (value == null)
		{
			return;
		}
		switch (Command)
		{
		case 1:
			AddEffectRef(num);
			value.Begin(Context, Parameters);
			break;
		case 0:
			if (RemoveEffectRef(num))
			{
				value.End(Context);
			}
			break;
		}
	}

	private BWS_PostProcessEffectBase CreateEffect(int PostProcessType, int ID)
	{
		BWS_PostProcessEffectBase result = null;
		switch ((BWS_PostProcessType)PostProcessType)
		{
		case BWS_PostProcessType.RadialBlur:
			result = BWS_PostProcessRadialBlur.Create(Context);
			break;
		case BWS_PostProcessType.Common:
			result = BWS_PostProcessCommon.Create(Context, ID);
			break;
		}
		return result;
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (Context == null || Context.PostProcessVolume == null || Context.PostProcessVolume.IsPendingKill)
		{
			UpdateContext();
			AutoEnableAllEffect();
		}
		if (Context == null || Context.PostProcessVolume == null)
		{
			return;
		}
		ProcessDelayEffectEvent();
		foreach (KeyValuePair<int, BWS_PostProcessEffectBase> postProcessEffect in PostProcessEffects)
		{
			BWS_PostProcessEffectBase value = postProcessEffect.Value;
			if (value.IsActive())
			{
				value.OnTick(DeltaTime, Context);
			}
		}
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		BWS_DispLibEventCollection bWS_DispLibEventCollection = BWS_DispLibEventCollection.Get(GetOwner());
		bWS_DispLibEventCollection.Env_RequestPostProcessEvent = (BWS_DispLibEventCollection.Del_PostProcessEffect)Delegate.Remove(bWS_DispLibEventCollection.Env_RequestPostProcessEvent, new BWS_DispLibEventCollection.Del_PostProcessEffect(OnPostProcessEvent));
		Clear();
	}

	private void UpdatePostProcessVolume(GSDispLib_PostProcessContext InContext)
	{
		APostProcessVolume[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass<APostProcessVolume>(GetOwner());
		if (allActorsOfClass.Length != 0)
		{
			InContext.PostProcessVolume = allActorsOfClass[0];
		}
	}

	public void AllowAllExtentPostProcess(bool bEnable)
	{
		gEnable = bEnable;
		if (!gEnable)
		{
			StopAllEffect();
		}
	}

	public void StopAllEffect()
	{
		foreach (KeyValuePair<int, BWS_PostProcessEffectBase> postProcessEffect in PostProcessEffects)
		{
			if (postProcessEffect.Value.IsActive())
			{
				postProcessEffect.Value.End(Context);
			}
			postProcessEffect.Value.OnDestroy(Context);
		}
		PostProcessEffects.Clear();
	}

	public void RestartAllEffect()
	{
		foreach (KeyValuePair<int, BWS_PostProcessEffectBase> postProcessEffect in PostProcessEffects)
		{
			BWS_PostProcessEffectBase value = postProcessEffect.Value;
			if (value.IsActive())
			{
				if (value.IsConstantEffect() && postProcessEffect.Key != 2)
				{
					PostProcessEffectEvent item = new PostProcessEffectEvent
					{
						EffectIndex = postProcessEffect.Key,
						PostProcessType = 0,
						Command = 1
					};
					DelayPostProcessEffectEvents.Add(item);
				}
				value.End(Context);
			}
		}
	}

	private void SetEffectGlobalState(int GeneralEffectIndex, PPEffectGlobalState State)
	{
		int value = 0;
		if (!PPEffectsGlobalState.TryGetValue(GeneralEffectIndex, out value))
		{
			PPEffectsGlobalState.Add(GeneralEffectIndex, (int)State);
		}
		else
		{
			PPEffectsGlobalState[GeneralEffectIndex] = (int)State;
		}
		switch (State)
		{
		case PPEffectGlobalState.Forbid:
		{
			if (PostProcessEffects.TryGetValue(GeneralEffectIndex, out var value2) && value2 != null && value2.IsActive())
			{
				value2.End(Context);
			}
			break;
		}
		case PPEffectGlobalState.Default:
			AutoEnableEffect(GeneralEffectIndex);
			break;
		}
	}

	private PPEffectGlobalState GetEffectGlobalState(int GeneralEffectIndex)
	{
		int value = 0;
		PPEffectsGlobalState.TryGetValue(GeneralEffectIndex, out value);
		return (PPEffectGlobalState)value;
	}

	private void AddEffectRef(int GeneralEffectIndex)
	{
		int value = 1;
		if (PPEffectsRefCount.TryGetValue(GeneralEffectIndex, out value))
		{
			value++;
			PPEffectsRefCount[GeneralEffectIndex] = value;
		}
		else
		{
			PPEffectsRefCount.Add(GeneralEffectIndex, value);
		}
	}

	private bool RemoveEffectRef(int GeneralEffectIndex)
	{
		int value = 0;
		if (PPEffectsRefCount.TryGetValue(GeneralEffectIndex, out value))
		{
			value--;
			PPEffectsRefCount[GeneralEffectIndex] = value;
		}
		else
		{
			PPEffectsRefCount.Add(GeneralEffectIndex, value);
		}
		return value <= 0;
	}
}

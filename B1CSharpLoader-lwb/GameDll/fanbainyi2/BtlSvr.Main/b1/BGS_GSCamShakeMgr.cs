using System;
using System.Collections.Generic;
using b1.EventDelDefine;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.GameplayCameras;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
public class BGS_GSCamShakeMgr : GameStateSystemBase
{
	private BGC_CamShakeData CameraShakeData;

	public override void OnAttach()
	{
		base.OnAttach();
		CameraShakeData = RequireWritableData<BGC_CamShakeData>();
		base.BGSEventCollection.Evt_BGS_AddCameraShakeWithControl += new Del_BGS_AddCameraShakeWithControl(OnAddCameraShakeWithControl);
		base.BGSEventCollection.Evt_BGS_StopCamShakeByReqID += new Del_BGS_StopCamShakeByReqID(OnStopCamShakeByReqID);
		base.BGSEventCollection.Evt_BGS_OnPauseCameraShakeByActor += new Del_Actor_Bool(OnPauseCamShakeByAActor);
		BGW_EventCollection bGWEventCollection = base.BGWEventCollection;
		bGWEventCollection.Evt_SettingValueChanged = (Del_SettingValueChanged)Delegate.Combine(bGWEventCollection.Evt_SettingValueChanged, new Del_SettingValueChanged(OnSettingValueChange));
		BGW_EventCollection bGWEventCollection2 = base.BGWEventCollection;
		bGWEventCollection2.Evt_SetGamePause = (Del_Void_SetGamePause)Delegate.Combine(bGWEventCollection2.Evt_SetGamePause, new Del_Void_SetGamePause(OnSetGamePause));
		BGW_EventCollection bGWEventCollection3 = base.BGWEventCollection;
		bGWEventCollection3.Evt_SetGameAllPause = (Del_Void_Bool)Delegate.Combine(bGWEventCollection3.Evt_SetGameAllPause, new Del_Void_Bool(OnSetGameAllPause));
		if (BGW_GameDB.GetGlobalConfigByAlias(B1GlobalConfigFNames.PausedCameraShakeContinueRequireRestTime, out var ConfigInfo))
		{
			CameraShakeData.PausedCameraShakeContinueRequireRestTime = ConfigInfo.FloatValue;
		}
		int settingIntValueByType = BGW_SettingFuncUtil.GetSettingIntValueByType(GetOwner(), UISettingConfigType.CameraShake);
		CameraShakeData.CameraShakeScale_Global = FMath.Clamp((float)settingIntValueByType / 10f, 0f, 1f);
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		base.BGSEventCollection.Evt_BGS_AddCameraShakeWithControl -= new Del_BGS_AddCameraShakeWithControl(OnAddCameraShakeWithControl);
		base.BGSEventCollection.Evt_BGS_StopCamShakeByReqID -= new Del_BGS_StopCamShakeByReqID(OnStopCamShakeByReqID);
		base.BGSEventCollection.Evt_BGS_OnPauseCameraShakeByActor -= new Del_Actor_Bool(OnPauseCamShakeByAActor);
		BGW_EventCollection bGWEventCollection = base.BGWEventCollection;
		bGWEventCollection.Evt_SettingValueChanged = (Del_SettingValueChanged)Delegate.Remove(bGWEventCollection.Evt_SettingValueChanged, new Del_SettingValueChanged(OnSettingValueChange));
		BGW_EventCollection bGWEventCollection2 = base.BGWEventCollection;
		bGWEventCollection2.Evt_SetGamePause = (Del_Void_SetGamePause)Delegate.Remove(bGWEventCollection2.Evt_SetGamePause, new Del_Void_SetGamePause(OnSetGamePause));
		BGW_EventCollection bGWEventCollection3 = base.BGWEventCollection;
		bGWEventCollection3.Evt_SetGameAllPause = (Del_Void_Bool)Delegate.Remove(bGWEventCollection3.Evt_SetGameAllPause, new Del_Void_Bool(OnSetGameAllPause));
		base.OnEndPlay(EndPlayReason);
	}

	public void OnSetGamePause(EPauseEvent PauseEvent, bool bPause)
	{
		CameraShakeData.bGamePause = bPause;
		UpdateAllCameraShakeInstPauseData();
	}

	public void OnSetGameAllPause(bool bPause)
	{
		CameraShakeData.bGameAllPause = bPause;
		UpdateAllCameraShakeInstPauseData();
	}

	public bool IsGamePause()
	{
		if (!CameraShakeData.bGameAllPause)
		{
			return CameraShakeData.bGamePause;
		}
		return true;
	}

	public void UpdateAllCameraShakeInstPauseData()
	{
		if (CameraShakeData.CamShakeCtrlList.Count < 1)
		{
			return;
		}
		UWorld uWorld = UBGUFunctionLibraryForCS.BGUGetUWorld(Owner);
		if (uWorld == null || uWorld.IsNullOrDestroyed())
		{
			return;
		}
		bool flag = IsGamePause();
		for (int i = 0; i < CameraShakeData.CamShakeCtrlList.Count; i++)
		{
			GSCameraShakeCtrlInfo gSCameraShakeCtrlInfo = CameraShakeData.CamShakeCtrlList[i];
			if (!gSCameraShakeCtrlInfo.CamShakeInst.IsNullOrDestroyed())
			{
				if (!gSCameraShakeCtrlInfo.bPaused && flag)
				{
					gSCameraShakeCtrlInfo.OscillatorTimeRemainingOnPause = gSCameraShakeCtrlInfo.CamShakeInst.OscillatorTimeRemaining;
					gSCameraShakeCtrlInfo.CamShakeInst.ShakeScale = 0f;
				}
				else if (!gSCameraShakeCtrlInfo.bPaused && !flag)
				{
					gSCameraShakeCtrlInfo.OscillatorTimeRemainingOnPause = 0f;
				}
				CameraShakeData.CamShakeCtrlList[i] = gSCameraShakeCtrlInfo;
			}
		}
	}

	private void OnSettingValueChange(int OldSettingValue, int NewSettingValue, UISettingConfigType SettingType)
	{
		if (SettingType == UISettingConfigType.CameraShake)
		{
			CameraShakeData.CameraShakeScale_Global = FMath.Clamp((float)NewSettingValue / 10f, 0f, 1f);
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (CameraShakeData.CamShakeCtrlList.Count < 1)
		{
			return;
		}
		UWorld uWorld = UBGUFunctionLibraryForCS.BGUGetUWorld(Owner);
		if (uWorld.IsNullOrDestroyed())
		{
			return;
		}
		AActor aActor = UGSE_EngineFuncLib.GetFirstLocalPlayerController(uWorld)?.GetControlledPawn();
		if (aActor == null || aActor.IsNullOrDestroyed())
		{
			return;
		}
		bool flag = IsGamePause();
		for (int i = 0; i < CameraShakeData.CamShakeCtrlList.Count; i++)
		{
			GSCameraShakeCtrlInfo gSCameraShakeCtrlInfo = CameraShakeData.CamShakeCtrlList[i];
			if (gSCameraShakeCtrlInfo.CamShakeInst.IsNullOrDestroyed())
			{
				CameraShakeData.CamShakeCtrlList.RemoveAt(i);
				i--;
				continue;
			}
			if (gSCameraShakeCtrlInfo.bPaused || flag)
			{
				gSCameraShakeCtrlInfo.CamShakeInst.OscillatorTimeRemaining = gSCameraShakeCtrlInfo.OscillatorTimeRemainingOnPause;
				gSCameraShakeCtrlInfo.CamShakeInst.ShakeScale = 0f;
			}
			else
			{
				if (gSCameraShakeCtrlInfo.CamShakeInst.OscillatorTimeRemaining <= 0f)
				{
					CameraShakeData.CamShakeCtrlList.RemoveAt(i);
					i--;
					continue;
				}
				if (gSCameraShakeCtrlInfo.CamShakeScaleByDistCurve != null)
				{
					FVector v = gSCameraShakeCtrlInfo.EpicenterLoc;
					if (gSCameraShakeCtrlInfo.EpicenterIsAttach && !gSCameraShakeCtrlInfo.AttachActor.IsNullOrDestroyed())
					{
						ACharacter aCharacter = gSCameraShakeCtrlInfo.AttachActor as ACharacter;
						v = ((!(aCharacter != null)) ? BGUFuncLibActorTransformCS.BGUGetActorLocation(gSCameraShakeCtrlInfo.AttachActor) : aCharacter.Mesh.GetSocketLocation(gSCameraShakeCtrlInfo.SocketName));
					}
					float inTime = FVector.Dist(BGUFuncLibActorTransformCS.BGUGetActorLocation(aActor), v);
					float floatValue = gSCameraShakeCtrlInfo.CamShakeScaleByDistCurve.GetFloatValue(inTime);
					gSCameraShakeCtrlInfo.CamShakeInst.ShakeScale = floatValue;
				}
				else
				{
					gSCameraShakeCtrlInfo.CamShakeInst.ShakeScale = 1f;
				}
			}
			gSCameraShakeCtrlInfo.CamShakeInst.ShakeScale *= CameraShakeData.CameraShakeScale_Global;
		}
		foreach (KeyValuePair<TWeakObject<AActor>, bool> item in CameraShakeData.ActorShowCamShakeMap)
		{
			if (!item.Key.IsValid())
			{
				CameraShakeData.CamShakeActorMapNeedRemove.Add(item.Key);
			}
		}
		foreach (TWeakObject<AActor> item2 in CameraShakeData.CamShakeActorMapNeedRemove)
		{
			if (CameraShakeData.ActorShowCamShakeMap.ContainsKey(item2))
			{
				CameraShakeData.ActorShowCamShakeMap.Remove(item2);
			}
		}
		CameraShakeData.CamShakeActorMapNeedRemove.Clear();
	}

	private void OnAddCameraShakeWithControl(UMatineeCameraShake CamShakeInst, UCurveFloat CamShakeScaleByDistCurve, FVector EpicenterLoc, float OverrideDuration, bool EpicenterIsAttach = false, FName SocketName = default(FName), AActor EpicenterOwner = null, int ReqID = -1)
	{
		if (CamShakeInst.IsNullOrDestroyed() || UBGUFunctionLibraryForCS.BGUGetUWorld(Owner).IsNullOrDestroyed())
		{
			return;
		}
		bool flag = IsGamePause();
		GSCameraShakeCtrlInfo gSCameraShakeCtrlInfo = new GSCameraShakeCtrlInfo();
		gSCameraShakeCtrlInfo.CamShakeInst = CamShakeInst;
		gSCameraShakeCtrlInfo.CamShakeScaleByDistCurve = CamShakeScaleByDistCurve;
		gSCameraShakeCtrlInfo.EpicenterLoc = EpicenterLoc;
		gSCameraShakeCtrlInfo.EpicenterIsAttach = EpicenterIsAttach;
		gSCameraShakeCtrlInfo.SocketName = SocketName;
		gSCameraShakeCtrlInfo.AttachActor = EpicenterOwner;
		gSCameraShakeCtrlInfo.ReqID = ReqID;
		CamShakeInst.OscillatorTimeRemaining = (((double)OverrideDuration > 0.1) ? OverrideDuration : CamShakeInst.OscillatorTimeRemaining);
		bool flag2 = true;
		if (EpicenterOwner != null)
		{
			TWeakObject<AActor> key = new TWeakObject<AActor>(EpicenterOwner);
			if (!CameraShakeData.ActorShowCamShakeMap.TryGetValue(key, out var value))
			{
				value = false;
				CameraShakeData.ActorShowCamShakeMap.Add(key, value);
			}
			if (value || flag)
			{
				if (CameraShakeData.PausedCameraShakeContinueRequireRestTime > gSCameraShakeCtrlInfo.CamShakeInst.OscillatorTimeRemaining)
				{
					flag2 = false;
				}
				gSCameraShakeCtrlInfo.OscillatorTimeRemainingOnPause = gSCameraShakeCtrlInfo.CamShakeInst.OscillatorTimeRemaining;
				gSCameraShakeCtrlInfo.bPaused = value;
				CamShakeInst.ShakeScale = 0f;
			}
		}
		if (flag2)
		{
			CameraShakeData.CamShakeCtrlList.Add(gSCameraShakeCtrlInfo);
		}
	}

	private void OnPauseCamShakeByAActor(AActor Acotr, bool bPaused)
	{
		bool flag = IsGamePause();
		TWeakObject<AActor> key = new TWeakObject<AActor>(Acotr);
		if (CameraShakeData.ActorShowCamShakeMap.ContainsKey(key))
		{
			CameraShakeData.ActorShowCamShakeMap[key] = bPaused;
		}
		else
		{
			CameraShakeData.ActorShowCamShakeMap.Add(key, bPaused);
		}
		for (int i = 0; i < CameraShakeData.CamShakeCtrlList.Count; i++)
		{
			GSCameraShakeCtrlInfo gSCameraShakeCtrlInfo = CameraShakeData.CamShakeCtrlList[i];
			if (gSCameraShakeCtrlInfo.CamShakeInst.IsNullOrDestroyed())
			{
				CameraShakeData.CamShakeCtrlList.RemoveAt(i);
				i--;
			}
			else
			{
				if (gSCameraShakeCtrlInfo.AttachActor.IsNullOrDestroyed() || !(gSCameraShakeCtrlInfo.AttachActor == Acotr))
				{
					continue;
				}
				if (bPaused || flag)
				{
					if (!gSCameraShakeCtrlInfo.bPaused)
					{
						if (CameraShakeData.PausedCameraShakeContinueRequireRestTime <= gSCameraShakeCtrlInfo.CamShakeInst.OscillatorTimeRemaining)
						{
							gSCameraShakeCtrlInfo.OscillatorTimeRemainingOnPause = gSCameraShakeCtrlInfo.CamShakeInst.OscillatorTimeRemaining;
							gSCameraShakeCtrlInfo.bPaused = bPaused;
						}
						else
						{
							gSCameraShakeCtrlInfo.OscillatorTimeRemainingOnPause = 0f;
							gSCameraShakeCtrlInfo.CamShakeInst.OscillatorTimeRemaining = 0f;
						}
						gSCameraShakeCtrlInfo.CamShakeInst.ShakeScale = 0f;
					}
				}
				else if (gSCameraShakeCtrlInfo.bPaused)
				{
					gSCameraShakeCtrlInfo.CamShakeInst.OscillatorTimeRemaining = gSCameraShakeCtrlInfo.OscillatorTimeRemainingOnPause;
					gSCameraShakeCtrlInfo.CamShakeInst.ShakeScale = CameraShakeData.CameraShakeScale_Global;
					gSCameraShakeCtrlInfo.bPaused = bPaused;
				}
				CameraShakeData.CamShakeCtrlList[i] = gSCameraShakeCtrlInfo;
			}
		}
	}

	private void OnStopCamShakeByReqID(int ReqID, bool bImmediately = true)
	{
		for (int i = 0; i < CameraShakeData.CamShakeCtrlList.Count; i++)
		{
			GSCameraShakeCtrlInfo gSCameraShakeCtrlInfo = CameraShakeData.CamShakeCtrlList[i];
			if (gSCameraShakeCtrlInfo.CamShakeInst.IsNullOrDestroyed())
			{
				CameraShakeData.CamShakeCtrlList.RemoveAt(i);
				i--;
			}
			else if (gSCameraShakeCtrlInfo.ReqID == (float)ReqID)
			{
				StopCamShake(gSCameraShakeCtrlInfo.CamShakeInst, bImmediately);
				CameraShakeData.CamShakeCtrlList.RemoveAt(i);
				i--;
			}
		}
	}

	public void StopCamShake(UMatineeCameraShake CamShakeInst, bool bImmediately = true)
	{
		UWorld uWorld = UBGUFunctionLibraryForCS.BGUGetUWorld(Owner);
		if (!uWorld.IsNullOrDestroyed())
		{
			APlayerCameraManager playerCameraManager = UGSE_EngineFuncLib.GetFirstLocalPlayerController(uWorld).PlayerCameraManager;
			if (playerCameraManager != null && CamShakeInst != null)
			{
				playerCameraManager.StopCameraShake(CamShakeInst, bImmediately);
			}
		}
	}
}

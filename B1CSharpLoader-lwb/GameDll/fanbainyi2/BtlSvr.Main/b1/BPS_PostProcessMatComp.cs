using System;
using System.Collections.Generic;
using System.Linq;
using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BPS_PostProcessMatComp : PlayerControllerSystemBase
{
	private bool bGamePause;

	private float OldBlendWeight = 1f;

	private b1.BPC_PostProcessMatData PostProcessMatData { get; set; }

	public override void OnAttach()
	{
		PostProcessMatData = RequireWritableData<b1.BPC_PostProcessMatData>();
		BPS_GSEventCollection local = BPS_EventCollectionCS.GetLocal(Owner);
		local.Evt_AddPostProcessMat += new Del_AddPostProcessMat(AddPostProcessMat);
		local.Evt_RemovePostProcessMat += new Del_RemovePostProcessMat(RemovePostProcessMat);
		BGW_EventCollection bGWEventCollection = base.BGWEventCollection;
		bGWEventCollection.Evt_SetGamePause = (Del_Void_SetGamePause)Delegate.Combine(bGWEventCollection.Evt_SetGamePause, new Del_Void_SetGamePause(OnSetGamePause));
		BGW_EventCollection bGWEventCollection2 = base.BGWEventCollection;
		bGWEventCollection2.Evt_TriggerResetAllActors = (BGW_EventCollection.Del_TriggerResetAllActors)Delegate.Combine(bGWEventCollection2.Evt_TriggerResetAllActors, new BGW_EventCollection.Del_TriggerResetAllActors(OnResetAllActors));
	}

	public void OnSetGamePause(EPauseEvent PauseEvent, bool bPause)
	{
		bGamePause = bPause;
		APostProcessVolume aPostProcessVolume = PostProcessMatData.PostProcessCompPtr.Get();
		if (bPause)
		{
			OldBlendWeight = aPostProcessVolume.BlendWeight;
			aPostProcessVolume.BlendWeight = 0f;
		}
		else
		{
			aPostProcessVolume.BlendWeight = OldBlendWeight;
			OldBlendWeight = 1f;
		}
	}

	public override void PreBeginPlay()
	{
		APostProcessVolume aPostProcessVolume = BGU_UnrealWorldUtil.SpawnActor<APostProcessVolume>(Owner.World);
		aPostProcessVolume.Unbound = true;
		PostProcessMatData.PostProcessCompPtr = new TWeakObject<APostProcessVolume>(aPostProcessVolume);
		PostProcessMatData.CurrentFramePlayer = GetControlledPlayerCharacter();
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		PostProcessMatData.PostProcessCompPtr.Get()?.DestroyActor();
		PostProcessMatData.PostProcessCompPtr.Set(null);
		BGW_EventCollection bGWEventCollection = base.BGWEventCollection;
		bGWEventCollection.Evt_SetGamePause = (Del_Void_SetGamePause)Delegate.Remove(bGWEventCollection.Evt_SetGamePause, new Del_Void_SetGamePause(OnSetGamePause));
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		PostProcessMatData.CurrentFramePlayer = GetControlledPlayerCharacter();
		foreach (KeyValuePair<EPostProcessSource, Dictionary<int, TStrongObjectPtr<UPostProcessMatInfo>>> item in PostProcessMatData.MaterialDictionary)
		{
			foreach (KeyValuePair<int, TStrongObjectPtr<UPostProcessMatInfo>> item2 in item.Value)
			{
				DoUpdatePostProcessMaterial(item2.Value.Get(), DeltaTime);
			}
		}
	}

	private void DoUpdatePostProcessMaterial(in UPostProcessMatInfo MatInfo, float DeltaTime)
	{
		BGWDataAsset_PostProcessMatSetting postProcessMatSetting = MatInfo.PostProcessMatSetting;
		if (postProcessMatSetting.IsNullOrDestroyed())
		{
			return;
		}
		postProcessMatSetting.ExistedTime += DeltaTime;
		IList<UMaterialInstanceDynamic> materials = MatInfo.Materials;
		if (materials == null)
		{
			return;
		}
		for (int i = 0; i < postProcessMatSetting.PostProcessMatParams.Count; i++)
		{
			FMatParam matParam = postProcessMatSetting.PostProcessMatParams[i];
			if ((int)matParam.ParamType < 64)
			{
				switch (matParam.ParamType)
				{
				case EGSMatParamType.FloatCurve:
				{
					if (!(matParam.FloatCurve != null))
					{
						break;
					}
					float floatValue = matParam.FloatCurve.GetFloatValue(postProcessMatSetting.ExistedTime);
					foreach (UMaterialInstanceDynamic item in materials)
					{
						if (!(item == null))
						{
							item.SetScalarParameterValue(matParam.ParameterName, floatValue);
						}
					}
					break;
				}
				case EGSMatParamType.VectorCurve:
				{
					if (!(matParam.VectorCurve != null))
					{
						break;
					}
					FVector vectorValue = matParam.VectorCurve.GetVectorValue(postProcessMatSetting.ExistedTime);
					foreach (UMaterialInstanceDynamic item2 in materials)
					{
						if (!(item2 == null))
						{
							item2.SetVectorParameterValue(matParam.ParameterName, vectorValue.Conv_VectorToLinearColor());
						}
					}
					break;
				}
				case EGSMatParamType.LinearColorValue:
				{
					if (!(matParam.LinearColorCurve != null))
					{
						break;
					}
					FLinearColor linearColorValue = matParam.LinearColorCurve.GetLinearColorValue(postProcessMatSetting.ExistedTime);
					foreach (UMaterialInstanceDynamic item3 in materials)
					{
						if (!(item3 == null))
						{
							item3.SetVectorParameterValue(matParam.ParameterName, linearColorValue);
						}
					}
					break;
				}
				}
			}
			else
			{
				if (!matParam.CharacterInfoRefresh)
				{
					continue;
				}
				BGUCharacterCS ownerActor = MatInfo.OwnerActor;
				FVector fVector = GetCharacterVectorInfo(matParam, ownerActor, matParam.bUseScreenSpace);
				if (matParam.bUseLastFrameValue)
				{
					TMapReadWrite<int, FVector> lastFrameDataCache = MatInfo.LastFrameDataCache;
					int key = i;
					FVector value = fVector;
					FVector fVector2 = MatInfo.LastFrameDataCache[i];
					lastFrameDataCache[key] = value;
					fVector = fVector2;
				}
				foreach (UMaterialInstanceDynamic item4 in materials)
				{
					item4.SetVectorParameterValue(matParam.ParameterName, fVector.Conv_VectorToLinearColor());
				}
			}
		}
	}

	private void AddPostProcessMat(EPostProcessSource Source, int NotifyId, AActor OwnerActor, BGWDataAsset_PostProcessMatSetting Template)
	{
		if (Source == EPostProcessSource.None || Source == EPostProcessSource.ReservedAfterReset || !PostProcessMatData.PostProcessCompPtr.IsValid() || Template == null)
		{
			return;
		}
		BGWDataAsset_PostProcessMatSetting bGWDataAsset_PostProcessMatSetting = UObject.NewObject<BGWDataAsset_PostProcessMatSetting>(Owner, UClass.GetClass(typeof(BGWDataAsset_PostProcessMatSetting)), FName.None, EObjectFlags.Transient, Template, copyTransientsFromClassDefaults: false, (IntPtr)0);
		if (bGWDataAsset_PostProcessMatSetting == null)
		{
			return;
		}
		bGWDataAsset_PostProcessMatSetting.ExistedTime = 0f;
		if (!PostProcessMatData.MaterialDictionary.ContainsKey(Source))
		{
			PostProcessMatData.MaterialDictionary[Source] = new Dictionary<int, TStrongObjectPtr<UPostProcessMatInfo>>();
		}
		Dictionary<int, TStrongObjectPtr<UPostProcessMatInfo>> dictionary = PostProcessMatData.MaterialDictionary[Source];
		if (dictionary.TryGetValue(NotifyId, out var value))
		{
			RemovePostProcessMat(Source, NotifyId);
		}
		UPostProcessMatInfo uPostProcessMatInfo = UObject.NewObject<UPostProcessMatInfo>();
		uPostProcessMatInfo.PostProcessMatSetting = bGWDataAsset_PostProcessMatSetting;
		uPostProcessMatInfo.Materials.Clear();
		uPostProcessMatInfo.OwnerActor = OwnerActor as BGUCharacterCS;
		uPostProcessMatInfo.LastFrameDataCache.Clear();
		value = new TStrongObjectPtr<UPostProcessMatInfo>(uPostProcessMatInfo);
		APostProcessVolume aPostProcessVolume = PostProcessMatData.PostProcessCompPtr.Get();
		for (int i = 0; i < bGWDataAsset_PostProcessMatSetting.PostProcessMatInstances.Count; i++)
		{
			UMaterialInterface parent = bGWDataAsset_PostProcessMatSetting.PostProcessMatInstances[i];
			UMaterialInstanceDynamic uMaterialInstanceDynamic = UMaterialLibrary.CreateDynamicMaterialInstance(Owner, parent, FName.None, EMIDCreationFlags.None);
			if (uMaterialInstanceDynamic != null)
			{
				float inWeight = 1f;
				if (bGWDataAsset_PostProcessMatSetting.Weights.Count > i)
				{
					inWeight = bGWDataAsset_PostProcessMatSetting.Weights[i];
				}
				aPostProcessVolume.AddOrUpdateBlendable(uMaterialInstanceDynamic, inWeight);
				uPostProcessMatInfo.Materials.Add(uMaterialInstanceDynamic);
			}
		}
		for (int j = 0; j < bGWDataAsset_PostProcessMatSetting.PostProcessMatParams.Count; j++)
		{
			FMatParam matParam = bGWDataAsset_PostProcessMatSetting.PostProcessMatParams[j];
			if ((int)matParam.ParamType < 64)
			{
				switch (matParam.ParamType)
				{
				case EGSMatParamType.Float:
					foreach (UMaterialInstanceDynamic material in uPostProcessMatInfo.Materials)
					{
						material.SetScalarParameterValue(matParam.ParameterName, matParam.FloatValue);
					}
					break;
				case EGSMatParamType.Vector:
					foreach (UMaterialInstanceDynamic material2 in uPostProcessMatInfo.Materials)
					{
						material2.SetDoubleVectorParameterValue(matParam.ParameterName, matParam.VectorValue);
					}
					break;
				case EGSMatParamType.LinearColor:
					foreach (UMaterialInstanceDynamic material3 in uPostProcessMatInfo.Materials)
					{
						material3.SetVectorParameterValue(matParam.ParameterName, matParam.LinearColorValue);
					}
					break;
				case EGSMatParamType.FloatCurve:
				{
					if (!(matParam.FloatCurve != null))
					{
						break;
					}
					float floatValue = matParam.FloatCurve.GetFloatValue(0f);
					foreach (UMaterialInstanceDynamic material4 in uPostProcessMatInfo.Materials)
					{
						material4.SetScalarParameterValue(matParam.ParameterName, floatValue);
					}
					break;
				}
				case EGSMatParamType.VectorCurve:
				{
					if (!(matParam.VectorCurve != null))
					{
						break;
					}
					FVector vectorValue = matParam.VectorCurve.GetVectorValue(0f);
					foreach (UMaterialInstanceDynamic material5 in uPostProcessMatInfo.Materials)
					{
						material5.SetDoubleVectorParameterValue(matParam.ParameterName, vectorValue);
					}
					break;
				}
				case EGSMatParamType.LinearColorValue:
					if (!(matParam.LinearColorCurve != null))
					{
						break;
					}
					foreach (UMaterialInstanceDynamic material6 in uPostProcessMatInfo.Materials)
					{
						material6.SetVectorParameterValue(matParam.ParameterName, matParam.LinearColorCurve.GetLinearColorValue(0f));
					}
					break;
				}
				continue;
			}
			BGUCharacterCS ownerActor = uPostProcessMatInfo.OwnerActor;
			FVector characterVectorInfo = GetCharacterVectorInfo(matParam, ownerActor, matParam.bUseScreenSpace);
			foreach (UMaterialInstanceDynamic material7 in uPostProcessMatInfo.Materials)
			{
				material7.SetVectorParameterValue(matParam.ParameterName, characterVectorInfo.Conv_VectorToLinearColor());
			}
			uPostProcessMatInfo.LastFrameDataCache[j] = characterVectorInfo;
		}
		dictionary[NotifyId] = value;
	}

	private FVector GetCharacterVectorInfo(FMatParam MatParam, BGUCharacterCS MatOwnerActor, bool bScreenSpace)
	{
		FVector fVector = FVector.ZeroVector;
		FVector fVector2 = FVector.ZeroVector;
		bool flag = false;
		if ((int)MatParam.ParamType < 128)
		{
			if (MatOwnerActor != null)
			{
				fVector2 = MatOwnerActor.GetActorLocation();
				switch (MatParam.ParamType)
				{
				case EGSMatParamType.OwnerWorldLocation:
					fVector = MatOwnerActor.GetActorLocation();
					break;
				case EGSMatParamType.OwnerVelocity:
					flag = true;
					fVector = MatOwnerActor.GetVelocity();
					break;
				case EGSMatParamType.OwnerForwardVector:
					flag = true;
					fVector = MatOwnerActor.GetActorForwardVector();
					break;
				case EGSMatParamType.OwnerSocketLocation:
					fVector = MatOwnerActor.Mesh.GetSocketLocation(MatParam.SocketName);
					break;
				case EGSMatParamType.OwnerSocketForwardVector:
					flag = true;
					fVector = MatOwnerActor.Mesh.GetSocketTransform(MatParam.SocketName).TransformVector(FVector.ForwardVector);
					break;
				}
			}
		}
		else
		{
			BGUPlayerCharacterCS currentFramePlayer = PostProcessMatData.CurrentFramePlayer;
			if (currentFramePlayer != null)
			{
				fVector2 = currentFramePlayer.GetActorLocation();
				switch (MatParam.ParamType)
				{
				case EGSMatParamType.PlayerWorldLocation:
					fVector = currentFramePlayer.GetActorLocation();
					break;
				case EGSMatParamType.PlayerVelocity:
					flag = true;
					fVector = currentFramePlayer.GetVelocity();
					break;
				case EGSMatParamType.PlayerForwardVector:
					flag = true;
					fVector = currentFramePlayer.GetActorForwardVector();
					break;
				case EGSMatParamType.PlayerSocketLocation:
					fVector = currentFramePlayer.Mesh.GetSocketLocation(MatParam.SocketName);
					break;
				case EGSMatParamType.PlayerSocketForwardVector:
					flag = true;
					fVector = currentFramePlayer.Mesh.GetSocketTransform(MatParam.SocketName).TransformVector(FVector.ForwardVector);
					break;
				}
			}
		}
		if (bScreenSpace)
		{
			FVector2D ScreenPosition3;
			if (flag)
			{
				FVector worldPosition = fVector2;
				FVector worldPosition2 = fVector2 + fVector;
				UGameplayStatics.ProjectWorldToScreen(base.PlayerController, worldPosition, out var ScreenPosition);
				UGameplayStatics.ProjectWorldToScreen(base.PlayerController, worldPosition2, out var ScreenPosition2);
				ScreenPosition3 = ScreenPosition2 - ScreenPosition;
			}
			else
			{
				UGameplayStatics.ProjectWorldToScreen(base.PlayerController, fVector, out ScreenPosition3);
			}
			base.PlayerController.GetViewportSize(out var SizeX, out var SizeY);
			fVector = new FVector(ScreenPosition3 / new FVector2D(SizeX, SizeY), 0.0);
		}
		return fVector;
	}

	private void RemovePostProcessMat(EPostProcessSource Source, int NotifyId)
	{
		if (Source == EPostProcessSource.None || Source == EPostProcessSource.ReservedAfterReset || !PostProcessMatData.MaterialDictionary.TryGetValue(Source, out var value) || !value.TryGetValue(NotifyId, out var value2))
		{
			return;
		}
		UPostProcessMatInfo uPostProcessMatInfo = value2.Get();
		if (!(uPostProcessMatInfo != null))
		{
			return;
		}
		APostProcessVolume pPV = PostProcessMatData.PostProcessCompPtr.Get();
		foreach (UMaterialInstanceDynamic material in uPostProcessMatInfo.Materials)
		{
			UGSE_PostProcessFuncLib.RemovePPVWeightBlendable(pPV, material);
		}
		value.Remove(NotifyId);
	}

	private void OnResetAllActors(EResetActorReason ResetActorReason)
	{
		if (ResetActorReason != EResetActorReason.Rebirth && ResetActorReason != EResetActorReason.InteractRebirthPoint && ResetActorReason != EResetActorReason.GameLevelPass)
		{
			return;
		}
		foreach (EPostProcessSource item in PostProcessMatData.MaterialDictionary.Keys.ToList())
		{
			if ((int)item >= 3)
			{
				continue;
			}
			foreach (int item2 in PostProcessMatData.MaterialDictionary[item].Keys.ToList())
			{
				RemovePostProcessMat(item, item2);
			}
		}
	}
}

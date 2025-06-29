using System.Collections.Generic;
using b1.BGW;
using b1.EventDelDefine;
using b1.Plugins.AkAudio;
using BtlB1;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUS_MappedSoundFXMgrComp : UActorCompBaseCS
{
	private IBUC_EquipData EquipData;

	private IBUC_EnvironmentInteractionMgrData EnvironmentInteractionMgrData;

	private IBUC_UnitStateData UnitStateData;

	private IBUC_SimpleStateData SimpleStateData;

	private IBUC_SpeedCtrlData SpeedCtrlData;

	private b1.IBUC_AkMgrData AkMgrData;

	public override void OnAttach()
	{
		base.OnAttach();
		EquipData = RequireReadOnlyData<IBUC_EquipData, BUC_EquipData>();
		EnvironmentInteractionMgrData = RequireReadOnlyData<IBUC_EnvironmentInteractionMgrData, BUC_EnvironmentInteractionMgrData>();
		UnitStateData = RequireReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>();
		SimpleStateData = RequireReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>();
		SpeedCtrlData = RequireReadOnlyData<IBUC_SpeedCtrlData, BUC_SpeedCtrlData>();
		AkMgrData = RequireReadOnlyData<b1.IBUC_AkMgrData, BUC_AKMgrData>();
		base.BUSEventCollection.Evt_PlayMappedSoundFX += new Del_PlayMappedSoundFX(OnPlayMappedSoundFX);
	}

	private void OnPlayMappedSoundFX(EquipPosition EquipPosition, int ActionTypeID, bool bIsFollow, FName SocketName)
	{
		int num = 0;
		string path = "";
		if (EquipData.SelfEquipMap.TryGetValue(EquipPosition, out var value))
		{
			EquipDesc equipDesc = GameDBRuntime.GetEquipDesc(value);
			if (equipDesc != null)
			{
				num = equipDesc.AudioMappingId;
			}
		}
		Dictionary<int, FUStAudioExtendDesc> allAudioExtendDescs = BGW_GameDB.GetAllAudioExtendDescs();
		if (allAudioExtendDescs != null)
		{
			foreach (KeyValuePair<int, FUStAudioExtendDesc> item in allAudioExtendDescs)
			{
				FUStAudioExtendDesc value2 = item.Value;
				if (value2.EquipPosition == EquipPosition && value2.ActionTypeID == ActionTypeID && value2.AudioMappingID == num)
				{
					if (value2.SceneItemSurfaceType == ESceneItemSurfaceType.DefaultSurface)
					{
						path = value2.AudioPath;
					}
					if (EnvironmentInteractionMgrData.ResultSurfaceType == value2.SceneItemSurfaceType)
					{
						path = value2.AudioPath;
						break;
					}
				}
			}
		}
		UAkAudioEvent uAkAudioEvent = BGW_PreloadAssetMgr.Get(Owner).TryGetCachedResourceObj<UObject>(path, ELoadResourceType.AsyncLoadAndCache, EAssetPriority.Low) as UAkAudioEvent;
		if (!(uAkAudioEvent != null) || !(base.BUSEventCollection != null))
		{
			return;
		}
		USceneComponent mesh = OwnerAsCharacterCS.Mesh;
		if (!(mesh != null))
		{
			return;
		}
		if (bIsFollow)
		{
			base.BUSEventCollection.Evt_PostAkEvent_Follow.Invoke(mesh, SocketName, uAkAudioEvent);
			UAkComponent lastFollowAkComp = AkMgrData.LastFollowAkComp;
			if (lastFollowAkComp != null)
			{
				float num2 = 0f;
				num2 = (UnitStateData.HasState(EBGUUnitState.Sprinting) ? SpeedCtrlData.GetMoveSpeedFast() : ((!UnitStateData.HasState(EBGUUnitState.Walking)) ? SpeedCtrlData.GetMoveSpeedNormal() : SpeedCtrlData.GetMoveSpeedSlow()));
				if (SimpleStateData.HasSimpleState(EBGUSimpleState.MoveSlowly))
				{
					num2 = SpeedCtrlData.GetMoveSpeedSlow();
				}
				lastFollowAkComp.SetRTPCValue(null, num2, 0, "Player_Mvmt_Speed");
			}
		}
		else
		{
			base.BUSEventCollection.Evt_PostAkEvent_AtLocation.Invoke(mesh.GetWorldLocation(), mesh.GetWorldRotation(), uAkAudioEvent);
		}
	}
}

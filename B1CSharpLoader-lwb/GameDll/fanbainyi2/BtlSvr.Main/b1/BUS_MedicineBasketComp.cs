using System;
using System.Collections.Generic;
using b1.EventDelDefine;
using CommB1;
using CsB1;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
public class BUS_MedicineBasketComp : UActorCompBaseCS
{
	private float MedicinePercent;

	private const float UpdateIntervalTime = 10f;

	private const int UpdateIntervalCount = 100;

	private float CurAccumulateTickTime;

	private float CurAccumulateTickCount;

	private List<UActorComponent> DisplayMeshCompList0;

	private List<UActorComponent> DisplayMeshCompList1;

	private List<UActorComponent> DisplayMeshCompList2;

	private List<UActorComponent> DisplayMeshCompList3;

	private List<UActorComponent> FullFXCompList0;

	private List<UActorComponent> FullFXCompList1;

	private List<UActorComponent> FullFXCompList2;

	private List<UActorComponent> FullFXCompList3;

	private List<UActorComponent> ClearFXCompList1;

	private List<UActorComponent> ClearFXCompList2;

	private List<UActorComponent> ClearFXCompList3;

	private int DisplayLevel;

	private bool IsCanInteract;

	public override void OnBeginPlay()
	{
		base.OnBeginPlay();
		DisplayMeshCompList0 = Owner.GetComponentsByTag(UClass.GetClass<UStaticMeshComponent>(), B1GlobalFNames.DisplayQuantity_0);
		DisplayMeshCompList1 = Owner.GetComponentsByTag(UClass.GetClass<UStaticMeshComponent>(), B1GlobalFNames.DisplayQuantity_1);
		DisplayMeshCompList2 = Owner.GetComponentsByTag(UClass.GetClass<UStaticMeshComponent>(), B1GlobalFNames.DisplayQuantity_2);
		DisplayMeshCompList3 = Owner.GetComponentsByTag(UClass.GetClass<UStaticMeshComponent>(), B1GlobalFNames.DisplayQuantity_3);
		FullFXCompList0 = Owner.GetComponentsByTag(UClass.GetClass<UNiagaraComponent>(), B1GlobalFNames.FullFX_0);
		FullFXCompList1 = Owner.GetComponentsByTag(UClass.GetClass<UNiagaraComponent>(), B1GlobalFNames.FullFX_1);
		FullFXCompList2 = Owner.GetComponentsByTag(UClass.GetClass<UNiagaraComponent>(), B1GlobalFNames.FullFX_2);
		FullFXCompList3 = Owner.GetComponentsByTag(UClass.GetClass<UNiagaraComponent>(), B1GlobalFNames.FullFX_3);
		ClearFXCompList1 = Owner.GetComponentsByTag(UClass.GetClass<UNiagaraComponent>(), B1GlobalFNames.ClearFX_1);
		ClearFXCompList2 = Owner.GetComponentsByTag(UClass.GetClass<UNiagaraComponent>(), B1GlobalFNames.ClearFX_2);
		ClearFXCompList3 = Owner.GetComponentsByTag(UClass.GetClass<UNiagaraComponent>(), B1GlobalFNames.ClearFX_3);
		DisplayLevel = -1;
		IsCanInteract = true;
		MedicinePercent = 0f;
		CurAccumulateTickTime = 0f;
		CurAccumulateTickCount = 0f;
		BGW_EventCollection bGWEventCollection = base.BGWEventCollection;
		bGWEventCollection.Evt_UpdateMedicineBasketDisplay = (Del_Void_Bool)Delegate.Combine(bGWEventCollection.Evt_UpdateMedicineBasketDisplay, new Del_Void_Bool(UpdateMedicinePercent));
	}

	public override void LateBeginPlay()
	{
		base.LateBeginPlay();
		UpdateMedicinePercent(IsForce: true);
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		base.OnTickWithGroup(DeltaTime, TickGroup);
		CurAccumulateTickTime += DeltaTime;
		CurAccumulateTickCount += 1f;
		if (!(CurAccumulateTickTime < 10f) && !(CurAccumulateTickCount < 100f))
		{
			UpdateMedicinePercent(IsForce: false);
		}
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		base.OnEndPlay(EndPlayReason);
		BGW_EventCollection bGWEventCollection = base.BGWEventCollection;
		bGWEventCollection.Evt_UpdateMedicineBasketDisplay = (Del_Void_Bool)Delegate.Remove(bGWEventCollection.Evt_UpdateMedicineBasketDisplay, new Del_Void_Bool(UpdateMedicinePercent));
	}

	private void SetIsCanInteract(bool IsCan, bool IsForce = false)
	{
		if (IsForce)
		{
			BUS_EventCollectionCS.Get(this)?.Evt_SwitchNoInteraction?.Invoke(IsCan);
		}
		else if (IsCan && !IsCanInteract)
		{
			BUS_EventCollectionCS.Get(this)?.Evt_SwitchNoInteraction?.Invoke(P1: true);
		}
		else if (!IsCan && IsCanInteract)
		{
			BUS_EventCollectionCS.Get(this)?.Evt_SwitchNoInteraction?.Invoke(P1: false);
		}
		IsCanInteract = IsCan;
	}

	private void UpdateMedicinePercent(bool IsForce)
	{
		CurAccumulateTickTime = 0f;
		CurAccumulateTickCount = 0f;
		APlayerController CurPlayer = UGSE_EngineFuncLib.GetFirstLocalPlayerController(Owner);
		if (CurPlayer.IsNullOrDestroyed())
		{
			return;
		}
		BTF_EventCollectionCS.Get(CurPlayer.PlayerState)?.Evt_GardenUpdateCropOutputReq?.Invoke(new CSMsgGardenUpdateCropOutputReq(), delegate(MsgErrCode errCode, CSMsgGardenUpdateCropOutputReq req, CSMsgGardenUpdateCropOutputRes res)
		{
			if (errCode != MsgErrCode.ErrSuccess)
			{
				BGW_LogUtil.LogError($"Error:{errCode}, RequestGardenPlantAllSeeds Failed!");
			}
			else
			{
				MedicinePercent = 0f;
				BPC_PlayerRoleData readOnlyData = BGU_DataUtil.GetReadOnlyData<BPC_PlayerRoleData>(CurPlayer);
				if (readOnlyData != null && readOnlyData.RoleData != null && readOnlyData.RoleData.RoleCs != null)
				{
					int count = readOnlyData.RoleData.RoleCs.Garden.CropList.Count;
					SetIsCanInteract(count > 0, IsForce);
					int num = 0;
					int num2 = 0;
					foreach (ReadOnlyCrop crop in readOnlyData.RoleData.RoleCs.Garden.CropList)
					{
						foreach (ReadOnlyCropOutput output in crop.OutputList)
						{
							num += output.OutputConfig.OutputMaxCount;
							num2 += output.OutputCount;
						}
					}
					if (num <= 0)
					{
						MedicinePercent = 0f;
					}
					else
					{
						MedicinePercent = (float)num2 / (float)num;
					}
				}
				UpdateDisplay();
			}
		});
	}

	private void UpdateDisplay()
	{
		int displayLevel = DisplayLevel;
		if ((double)MedicinePercent >= 1.0)
		{
			DisplayLevel = 4;
		}
		else if ((double)MedicinePercent >= 0.66)
		{
			DisplayLevel = 3;
		}
		else if ((double)MedicinePercent >= 0.33)
		{
			DisplayLevel = 2;
		}
		else if (MedicinePercent > 0f)
		{
			DisplayLevel = 1;
		}
		else
		{
			DisplayLevel = 0;
		}
		if (displayLevel != DisplayLevel)
		{
			UpdateMesh();
		}
		if (displayLevel > DisplayLevel)
		{
			PlayClearFX(displayLevel, DisplayLevel);
		}
	}

	private void UpdateMesh()
	{
		foreach (UActorComponent item in DisplayMeshCompList0)
		{
			UStaticMeshComponent uStaticMeshComponent = item as UStaticMeshComponent;
			if (uStaticMeshComponent != null)
			{
				if (DisplayLevel >= 1)
				{
					uStaticMeshComponent.SetVisibility(bNewVisibility: true);
				}
				else
				{
					uStaticMeshComponent.SetVisibility(bNewVisibility: false);
				}
			}
		}
		foreach (UActorComponent item2 in DisplayMeshCompList1)
		{
			UStaticMeshComponent uStaticMeshComponent2 = item2 as UStaticMeshComponent;
			if (uStaticMeshComponent2 != null)
			{
				if (DisplayLevel >= 2)
				{
					uStaticMeshComponent2.SetVisibility(bNewVisibility: true);
				}
				else
				{
					uStaticMeshComponent2.SetVisibility(bNewVisibility: false);
				}
			}
		}
		foreach (UActorComponent item3 in DisplayMeshCompList2)
		{
			UStaticMeshComponent uStaticMeshComponent3 = item3 as UStaticMeshComponent;
			if (uStaticMeshComponent3 != null)
			{
				if (DisplayLevel >= 3)
				{
					uStaticMeshComponent3.SetVisibility(bNewVisibility: true);
				}
				else
				{
					uStaticMeshComponent3.SetVisibility(bNewVisibility: false);
				}
			}
		}
		foreach (UActorComponent item4 in DisplayMeshCompList3)
		{
			UStaticMeshComponent uStaticMeshComponent4 = item4 as UStaticMeshComponent;
			if (uStaticMeshComponent4 != null)
			{
				if (DisplayLevel >= 4)
				{
					uStaticMeshComponent4.SetVisibility(bNewVisibility: true);
				}
				else
				{
					uStaticMeshComponent4.SetVisibility(bNewVisibility: false);
				}
			}
		}
		foreach (UActorComponent item5 in FullFXCompList0)
		{
			UNiagaraComponent uNiagaraComponent = item5 as UNiagaraComponent;
			if (!uNiagaraComponent.IsNullOrDestroyed())
			{
				bool flag = DisplayLevel < 1;
				uNiagaraComponent.SetVariableBool(B1GlobalFNames.User_GS_EfxStop, flag);
				if (flag)
				{
					uNiagaraComponent.Deactivate();
				}
				else
				{
					uNiagaraComponent.Activate();
				}
			}
		}
		foreach (UActorComponent item6 in FullFXCompList1)
		{
			UNiagaraComponent uNiagaraComponent2 = item6 as UNiagaraComponent;
			if (!uNiagaraComponent2.IsNullOrDestroyed())
			{
				bool flag2 = DisplayLevel < 2;
				uNiagaraComponent2.SetVariableBool(B1GlobalFNames.User_GS_EfxStop, flag2);
				if (flag2)
				{
					uNiagaraComponent2.Deactivate();
				}
				else
				{
					uNiagaraComponent2.Activate();
				}
			}
		}
		foreach (UActorComponent item7 in FullFXCompList2)
		{
			UNiagaraComponent uNiagaraComponent3 = item7 as UNiagaraComponent;
			if (!uNiagaraComponent3.IsNullOrDestroyed())
			{
				bool flag3 = DisplayLevel < 3;
				uNiagaraComponent3.SetVariableBool(B1GlobalFNames.User_GS_EfxStop, flag3);
				if (flag3)
				{
					uNiagaraComponent3.Deactivate();
				}
				else
				{
					uNiagaraComponent3.Activate();
				}
			}
		}
		foreach (UActorComponent item8 in FullFXCompList3)
		{
			UNiagaraComponent uNiagaraComponent4 = item8 as UNiagaraComponent;
			if (!uNiagaraComponent4.IsNullOrDestroyed())
			{
				bool flag4 = DisplayLevel < 4;
				uNiagaraComponent4.SetVariableBool(B1GlobalFNames.User_GS_EfxStop, flag4);
				if (flag4)
				{
					uNiagaraComponent4.Deactivate();
				}
				else
				{
					uNiagaraComponent4.Activate();
				}
			}
		}
	}

	private void PlayClearFX(int OldLevel, int NewLevel)
	{
		if (OldLevel > 0 && NewLevel <= 0)
		{
			foreach (UActorComponent item in ClearFXCompList1)
			{
				UNiagaraComponent uNiagaraComponent = item as UNiagaraComponent;
				if (!uNiagaraComponent.IsNullOrDestroyed())
				{
					uNiagaraComponent.Activate();
				}
			}
		}
		if (OldLevel > 1 && NewLevel <= 1)
		{
			foreach (UActorComponent item2 in ClearFXCompList2)
			{
				UNiagaraComponent uNiagaraComponent2 = item2 as UNiagaraComponent;
				if (!uNiagaraComponent2.IsNullOrDestroyed())
				{
					uNiagaraComponent2.Activate();
				}
			}
		}
		if (OldLevel <= 2 || NewLevel > 2)
		{
			return;
		}
		foreach (UActorComponent item3 in ClearFXCompList3)
		{
			UNiagaraComponent uNiagaraComponent3 = item3 as UNiagaraComponent;
			if (!uNiagaraComponent3.IsNullOrDestroyed())
			{
				uNiagaraComponent3.Activate();
			}
		}
	}
}

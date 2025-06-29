using System.Collections.Generic;
using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_DashWallComp : UActorCompBaseCS
{
	private BUC_DashWallData DashWallData;

	public override void OnBeginPlay()
	{
		DashWallData = RequireWritableData<BUC_DashWallData>();
		base.BUSEventCollection.Evt_DashWallCheckBegin += new Del_DashWallCheckBegin(DashWallCheckBegin);
		base.BUSEventCollection.Evt_DashWallCheckEnd += new Del_Void_Int(DashWallCheckEnd);
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		TickFoWallCheck();
	}

	private void TickFoWallCheck()
	{
		ACharacter aCharacter = GetOwner() as ACharacter;
		if (aCharacter.IsNullOrDestroyed() || DashWallData.CheckInfoMap.Count < 1)
		{
			return;
		}
		bool flag = false;
		int key = -1;
		foreach (KeyValuePair<int, FDashHitWallInfo> item in DashWallData.CheckInfoMap)
		{
			foreach (FUStCheckShape checkShape in item.Value.CheckShapeList)
			{
				FVector socketLocation = aCharacter.Mesh.GetSocketLocation(checkShape.SocketName);
				if (USystemLibrary.SphereOverlapActors(aCharacter, socketLocation, checkShape.Radius * Owner.GetActorScale3D().X, item.Value.ObjectTypeList, null, null, out var OutActors))
				{
					if (item.Value.ValidTag == FName.None)
					{
						flag = true;
					}
					else
					{
						foreach (AActor item2 in OutActors)
						{
							if (item2.ActorHasTag(item.Value.ValidTag))
							{
								flag = true;
								break;
							}
						}
					}
				}
				if (flag)
				{
					key = item.Key;
					break;
				}
			}
			if (flag)
			{
				break;
			}
		}
		if (flag)
		{
			UAnimMontage hitWallStiffAM = DashWallData.CheckInfoMap[key].HitWallStiffAM;
			if (hitWallStiffAM != null)
			{
				aCharacter.StopAnimMontage(null);
				base.BUSEventCollection.Evt_OnMagicallyChangeBreak.Invoke();
				base.BUSEventCollection.Evt_UnitTryBreakSkill.Invoke("撞到墙了");
				BGUFuncLibAnim.BGUActorTryPlayMontage(Owner, hitWallStiffAM, FName.None);
			}
			DashWallData.CheckInfoMap.Clear();
		}
	}

	private void DashWallCheckBegin(int NotifyID, TArrayReadWrite<FUStCheckShape> _CheckShapeList, TArrayReadWrite<EObjectTypeQuery> _ObjectTypeList, UAnimMontage HitWallStiffAM, string ValidTag)
	{
		FDashHitWallInfo value = new FDashHitWallInfo
		{
			ObjectTypeList = _ObjectTypeList.ToList(),
			CheckShapeList = _CheckShapeList.ToList(),
			HitWallStiffAM = HitWallStiffAM,
			ValidTag = new FName(ValidTag)
		};
		DashWallData.CheckInfoMap.Add(NotifyID, value);
	}

	private void DashWallCheckEnd(int NotifyID)
	{
		if (DashWallData.CheckInfoMap.ContainsKey(NotifyID))
		{
			DashWallData.CheckInfoMap.Remove(NotifyID);
		}
	}
}

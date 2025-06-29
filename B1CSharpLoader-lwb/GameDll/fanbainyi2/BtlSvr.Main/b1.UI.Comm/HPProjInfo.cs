using System.Collections.Generic;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.UI.Comm;

public class HPProjInfo : IProjInfo
{
	public BGUCharacterCS BindedUnit;

	public bool UseMesh;

	public USceneComponent TopBarSock;

	public FVector PosOffset;

	public DS_IBUC_UnitBarInfoData UnitBarInfoData;

	private readonly FName HpBarSocketName = new FName("HpBar");

	private readonly FName TopBarSocketName = new FName("GSTopBarSock");

	public HPProjInfo(BGUCharacterCS InBindedUnit)
	{
		BindedUnit = InBindedUnit;
		UseMesh = BindedUnit.Mesh.DoesSocketExist(HpBarSocketName);
		if (!UseMesh)
		{
			List<UActorComponent> componentsByTag = BindedUnit.GetComponentsByTag(UClass.GetClass<USceneComponent>(), TopBarSocketName);
			if (componentsByTag.Count >= 1)
			{
				TopBarSock = componentsByTag[0] as USceneComponent;
			}
		}
		UnitBarInfoData = B1GSUIActorMgr.Get(BindedUnit).GetBattleDataByActor<DS_IBUC_UnitBarInfoData>(BindedUnit);
	}

	public FVector GetLocation()
	{
		if (BindedUnit.IsNullOrDestroyed())
		{
			return FVector.ZeroVector;
		}
		FVector zeroVector = FVector.ZeroVector;
		if (!UGSE_EngineFuncLib.IsStandAlone(BindedUnit.World))
		{
			BUC_AttrContainer readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_AttrContainer>(BindedUnit);
			if (readOnlyData != null)
			{
				BGUPlayerCharacterCS obj = BindedUnit as BGUPlayerCharacterCS;
				float floatValue = readOnlyData.GetFloatValue(EBGUAttrFloat.Hp);
				if (!obj.IsNullOrDestroyed() && floatValue <= 0f)
				{
					zeroVector -= FVector.UpVector * 50.0;
				}
			}
		}
		zeroVector += PosOffset;
		if (UseMesh && BindedUnit != null)
		{
			return BindedUnit.Mesh.GetSocketLocation(HpBarSocketName) + zeroVector;
		}
		if (TopBarSock != null)
		{
			return TopBarSock.GetWorldLocation() + zeroVector;
		}
		return FVector.ZeroVector;
	}

	public bool GetIsLock()
	{
		if (UnitBarInfoData != null)
		{
			return UnitBarInfoData.IsLocked;
		}
		return false;
	}
}

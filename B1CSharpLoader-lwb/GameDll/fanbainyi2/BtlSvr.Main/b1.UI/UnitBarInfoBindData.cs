using System;
using BtlShare;
using UnrealEngine.Runtime;

namespace b1.UI;

public class UnitBarInfoBindData : UIBindData
{
	public readonly string Guid;

	private readonly B1GSUIActorMgr ActorMgr;

	private readonly DS_IBPC_BattleMainInfoData BattleMainInfoData;

	private readonly DS_IBUC_AttrContainer AttrContainer;

	private readonly int BarBindIdx;

	private readonly Action OnAttrChanged;

	private float CurValue;

	private float MaxValue;

	public UnitBarInfoBindData(UIBindData InParent, string InGuid, BGUCharacterCS InCharacterActor, Action InOnAttrChanged)
		: base(InParent)
	{
		Guid = InGuid;
		UObject worldContext = GetWorldContext();
		ActorMgr = B1GSUIActorMgr.Get(worldContext);
		BattleMainInfoData = B1GSUIActorMgr.Get(worldContext).GetBattleData<DS_IBPC_BattleMainInfoData>(B1ActorTag.PlayerController);
		AttrContainer = ActorMgr.GetBattleDataByActor<DS_IBUC_AttrContainer>(InCharacterActor);
		BarBindIdx = AttrContainer.BindFloatAttrsOnSetIdxValue(OnBloodBarValueChange);
		CurValue = AttrContainer.GetFloatValue(EBGUAttrFloat.Hp);
		MaxValue = AttrContainer.GetFloatValue(EBGUAttrFloat.HpMax);
		OnAttrChanged = InOnAttrChanged;
	}

	private void OnBloodBarValueChange(int AttrId, float OldValue, float NewValue)
	{
		switch ((EBGUAttrFloat)(byte)AttrId)
		{
		case EBGUAttrFloat.Hp:
			CurValue = AttrContainer.GetFloatValue(EBGUAttrFloat.Hp);
			break;
		case EBGUAttrFloat.HpMax:
			MaxValue = AttrContainer.GetFloatValue(EBGUAttrFloat.HpMax);
			break;
		}
		OnAttrChanged?.Invoke();
	}

	public bool GetCanShow()
	{
		foreach (UnitBarInfo item in BattleMainInfoData.BossBarInfo)
		{
			if (item.UnitGuid == Guid)
			{
				return true;
			}
		}
		foreach (UnitBarInfo item2 in BattleMainInfoData.EliteBarInfo)
		{
			if (item2.UnitGuid == Guid)
			{
				return true;
			}
		}
		return false;
	}

	public float GetValue()
	{
		if (GetCanShow())
		{
			return CurValue;
		}
		return 0f;
	}

	public float GetMaxValue()
	{
		return MaxValue;
	}

	protected override void OnDestructImpl()
	{
		AttrContainer.UnBindFloatAttrsOnSetIdxValue(BarBindIdx, OnBloodBarValueChange);
		base.OnDestructImpl();
	}
}

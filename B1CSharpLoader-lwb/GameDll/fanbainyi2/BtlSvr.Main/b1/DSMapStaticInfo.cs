using b1.UI;
using BtlB1;
using UnrealEngine.Runtime;

namespace b1;

public class DSMapStaticInfo : UIBindData
{
	public readonly int StaticInfoId;

	public readonly GSBindProp<bool> IsVisable = new GSBindProp<bool>();

	public readonly GSBindProp<float> Scale = new GSBindProp<float>();

	private DS_IBPC_RebirthPointData RebirthPointData;

	private DSMapWidget MapWidget => ParentData as DSMapWidget;

	public DSMapStaticInfo(DSMapWidget InParent, int InStaticInfoId)
		: base(InParent)
	{
		RebirthPointData = B1GSUIActorMgr.Get(GetWorldContext()).GetBattleData<DS_IBPC_RebirthPointData>(B1ActorTag.PlayerController);
		StaticInfoId = InStaticInfoId;
		BindValueToCustom(InParent.MapSpriteId, OnChangeMapSpriteId);
		BindValueToCustom(InParent.MapScale, OnChangeMapScale);
	}

	private void OnChangeMapSpriteId(EChangeReason Reason, int OldValue, int NewValue)
	{
		SetIsVisable(CalIsVisable());
	}

	private void OnChangeMapScale(EChangeReason Reason, float OldValue, float NewValue)
	{
		Scale.SetValue(Reason, CalSymbolScale());
		SetIsVisable(CalIsVisable());
	}

	private FMapLevelConfig GetSpriteConfig()
	{
		return MapWidget.GetSpriteConfig().MapLevelDescConfig;
	}

	private float CalSymbolScale()
	{
		FMapLevelConfig spriteConfig = GetSpriteConfig();
		return FMath.Lerp(spriteConfig.MinScale, spriteConfig.MaxScale, MapWidget.MapScale.Value);
	}

	private bool CalIsVisable()
	{
		foreach (FUStRebirthPointDesc value in GameDBRuntime.GetTBFUStRebirthPointDesc().Values)
		{
			if (value.GroupAreaID == StaticInfoId && RebirthPointData != null && RebirthPointData.IsRebirthPointActived(value.ID))
			{
				return true;
			}
		}
		return false;
	}

	private void SetIsVisable(bool InIsVisable)
	{
		IsVisable.SetValue(EChangeReason.ManualSet, InIsVisable);
	}
}

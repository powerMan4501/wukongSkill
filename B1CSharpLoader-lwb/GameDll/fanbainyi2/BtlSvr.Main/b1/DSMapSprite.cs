using UnrealEngine.Runtime;

namespace b1;

public class DSMapSprite : UIBindData
{
	public readonly int MapSpriteId;

	public readonly GSBindProp<bool> IsStaticMapInfoVisable = new GSBindProp<bool>();

	private FVector2D MapSize;

	public DSMapSprite(DSMapWidget InParent, int InMapSpriteId)
		: base(InParent)
	{
		MapSpriteId = InMapSpriteId;
		BindValueToCustom(InParent.MapSpriteId, OnChangeMapSpriteId);
		BindValueToCustom(InParent.MapScale, OnChangeMapScale);
	}

	private void OnChangeMapSpriteId(EChangeReason Reason, int OldValue, int NewValue)
	{
		UpdateIsStaticMapInfoVisable();
	}

	private void OnChangeMapScale(EChangeReason Reason, float OldValue, float NewValue)
	{
		UpdateIsStaticMapInfoVisable();
	}

	private void UpdateIsStaticMapInfoVisable()
	{
		DSMapWidget parentData = GetParentData();
		float value = parentData.MapScale.Value;
		FMapLevelConfig mapLevelDescConfig = parentData.GetSpriteConfig().MapLevelDescConfig;
		float minCanShowScale = mapLevelDescConfig.MinCanShowScale;
		float maxCanShowScale = mapLevelDescConfig.MaxCanShowScale;
		IsStaticMapInfoVisable.SetValue(EChangeReason.Init, value < minCanShowScale || value > maxCanShowScale);
	}

	public void SetMapSize(FVector2D InMapSize)
	{
		MapSize = InMapSize;
	}

	public FVector2D GetMapSize()
	{
		return MapSize;
	}

	public DSMapWidget GetParentData()
	{
		return ParentData as DSMapWidget;
	}
}

using UnrealEngine.Runtime;

namespace b1;

public class DSMapSymbolLevel : UIBindData
{
	public readonly EMapSymbolType MapSymbolType;

	public readonly GSBindList<DSMapSymbol> MapSymbolList = new GSBindList<DSMapSymbol>();

	public readonly GSBindProp<bool> IsVisable = new GSBindProp<bool>();

	private DSMapWidget MapWidget => ParentData as DSMapWidget;

	public DSMapSymbolLevel(DSMapWidget ParentData, EMapSymbolType InMapSymbolType)
		: base(ParentData)
	{
		MapSymbolType = InMapSymbolType;
		IsVisable.InitForEnumBugFix(InitValue: true);
		BindValueToCustom(ParentData.MapScale, OnChangeMapScale);
	}

	private void OnChangeMapScale(EChangeReason Reason, float OldValue, float NewValue)
	{
		float scale = CalSymbolScale();
		foreach (DSMapSymbol mapSymbol in MapSymbolList)
		{
			mapSymbol.SetScale(scale);
		}
		SetIsVisable(Reason, CalIsVisable());
	}

	public void AddMapSymbol(DSMapSymbol MapSymbol)
	{
		MapSymbol.SetScale(CalSymbolScale());
		MapSymbolList.Add(MapSymbol);
	}

	public void RemoveMapSymbol(DSMapSymbol MapSymbol)
	{
		MapSymbolList.Remove(MapSymbol);
	}

	public void Clear()
	{
		MapSymbolList.Clear();
	}

	public void SetIsVisable(EChangeReason Reason, bool InIsVisable)
	{
		IsVisable.SetValue(Reason, InIsVisable);
	}

	public float CalSymbolScale()
	{
		return FMath.Lerp(GetLevelConfig().MinScale, GetLevelConfig().MaxScale, MapWidget.MapScale.Value);
	}

	private bool CalIsVisable()
	{
		float value = MapWidget.MapScale.Value;
		FMapLevelConfig levelConfig = GetLevelConfig();
		float minCanShowScale = levelConfig.MinCanShowScale;
		float maxCanShowScale = levelConfig.MaxCanShowScale;
		if (value < minCanShowScale || value > maxCanShowScale)
		{
			return false;
		}
		return true;
	}

	public FMapLevelConfig GetLevelConfig()
	{
		return MapWidget.GetSpriteConfig().MapLevelCommConfig;
	}
}

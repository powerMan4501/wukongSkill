using System;
using System.Collections.Generic;
using b1.UI;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1;

public class MapSymbolLevelData : UIBindData
{
	private DSMapSymbolLevel DataStore;

	private BUI_Widget MapRootWidget;

	private UPanelWidget MapSymbolTypeWidget;

	private UWidget BaseWidget;

	private Queue<MapSymbolData> MapSymbolDataPool = new Queue<MapSymbolData>();

	private Dictionary<DSMapSymbol, MapSymbolData> MapSymbolDataDic = new Dictionary<DSMapSymbol, MapSymbolData>();

	private const string LevelConNamePre = "MapLevel";

	private const string BaseNameFix = "Widget";

	public MapSymbolLevelData(UIBindData Parent, BUI_Widget InMapRootWidget, DSMapSymbolLevel InDataStore)
		: base(Parent)
	{
		DataStore = InDataStore;
		MapRootWidget = InMapRootWidget;
		MapSymbolTypeWidget = UGSE_UMGFuncLib.GetWidgetFromName(MapRootWidget, new FName(string.Format("{0}_{1}", "MapLevel", DataStore.MapSymbolType))) as UPanelWidget;
		if (MapSymbolTypeWidget == null)
		{
			BGW_LogUtil.LogError($"MapSymbolTypeWidget is null, MapSymbolType = {DataStore.MapSymbolType}");
		}
		BaseWidget = UGSE_UMGFuncLib.GetWidgetFromName(MapRootWidget, new FName(string.Format("{0}_{1}", DataStore.MapSymbolType, "Widget")));
		if (BaseWidget == null)
		{
			BGW_LogUtil.LogError($"BaseWidget is null, MapSymbolType = {DataStore.MapSymbolType}");
		}
		else
		{
			BaseWidget.SetVisibility(ESlateVisibility.Collapsed);
		}
		BindValueToCustom(DataStore.IsVisable, OnChangeIsVisable);
		BindListToOnAdd(DataStore.MapSymbolList, OnMapSymbolListAdd);
		BindListToOnRemove(DataStore.MapSymbolList, OnMapSymbolListRemove);
		BindListToOnClear(DataStore.MapSymbolList, OnMapSymbolListClear);
		foreach (DSMapSymbol mapSymbol in DataStore.MapSymbolList)
		{
			OnMapSymbolListAdd(mapSymbol);
		}
	}

	private void OnMapSymbolListAdd(DSMapSymbol OneItem)
	{
		TryGetMapSymbol(OneItem);
	}

	private void OnMapSymbolListRemove(int Idx, DSMapSymbol OneItem)
	{
		RemoveToPool(OneItem);
	}

	private void OnMapSymbolListClear()
	{
		for (int num = DataStore.MapSymbolList.Count - 1; num >= 0; num--)
		{
			RemoveToPool(DataStore.MapSymbolList[num]);
		}
	}

	private MapSymbolData TryGetMapSymbol(DSMapSymbol InMapSymbol)
	{
		if (InMapSymbol == null)
		{
			return null;
		}
		if (!MapSymbolDataDic.TryGetValue(InMapSymbol, out var value))
		{
			if (MapSymbolDataPool.Count > 0)
			{
				value = MapSymbolDataPool.Dequeue();
			}
			else
			{
				if (BaseWidget is UPanelWidget)
				{
					throw new Exception($"BaseWidget is UPanelWidget, MapSymbolType = {DataStore.MapSymbolType}");
				}
				UWidget uWidget = UGSE_UMGFuncLib.ConstructUWidgetWithClass(MapRootWidget, BaseWidget.GetClass());
				MapSymbolTypeWidget.AddChild(uWidget);
				SyncWidgetParam(BaseWidget, uWidget);
				value = new MapSymbolData(this, uWidget);
			}
			MapSymbolDataDic.Add(InMapSymbol, value);
		}
		value.InitDataStore(InMapSymbol);
		return value;
	}

	private void RemoveToPool(DSMapSymbol InMapSymbol)
	{
		if (MapSymbolDataDic.TryGetValue(InMapSymbol, out var value))
		{
			value.Release();
			MapSymbolDataDic.Remove(InMapSymbol);
			MapSymbolDataPool.Enqueue(value);
		}
	}

	private void OnChangeIsVisable(EChangeReason Reason, bool OldValue, bool NewValue)
	{
		MapRootWidget.GSAnimKeyToState($"GSAKB{DataStore.MapSymbolType}State", NewValue ? "Show" : "Hide", Reason == EChangeReason.Init);
	}

	private void SyncWidgetParam(UWidget BaseWidget, UWidget TargetWidget)
	{
		if (BaseWidget is UImage uImage && TargetWidget is UImage uImage2)
		{
			uImage2.SetBrush(uImage.Brush);
			GSUIPanelSlotHelper.WidgetSlotCopy(uImage, uImage2);
			uImage2.SetVisibility(ESlateVisibility.SelfHitTestInvisible);
		}
	}

	public UWidget GetMapSymbolWidget(DSMapSymbol InMapSymbol)
	{
		if (MapSymbolDataDic.TryGetValue(InMapSymbol, out var value))
		{
			return value.GetWidget();
		}
		return null;
	}

	protected override void OnDestructImpl()
	{
		foreach (MapSymbolData value in MapSymbolDataDic.Values)
		{
			MapSymbolTypeWidget.RemoveChild(value.GetWidget());
		}
		MapSymbolDataDic.Clear();
		base.OnDestructImpl();
	}
}

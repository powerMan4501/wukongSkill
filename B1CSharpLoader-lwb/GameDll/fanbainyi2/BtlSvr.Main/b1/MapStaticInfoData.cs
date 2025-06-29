using b1.UI;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1;

public class MapStaticInfoData : UIBindData
{
	private DSMapStaticInfo DataStore;

	private UWidget Wiget;

	public MapStaticInfoData(BUI_Widget InBindWidget, UWidget InWidget)
		: base(InBindWidget)
	{
		Wiget = InWidget;
		Wiget.SetVisibility(ESlateVisibility.Collapsed);
	}

	public void InitDataStore(DSMapStaticInfo InDataStore)
	{
		ReleaseBindAction();
		DataStore = InDataStore;
		BindValueToCustom(DataStore.IsVisable, OnChangeIsVisable);
		BindValueToCustom(DataStore.Scale, OnChangeScale);
	}

	private void OnChangeIsVisable(EChangeReason Reason, bool OldValue, bool NewValue)
	{
		Wiget.SetVisibility((!NewValue) ? ESlateVisibility.Collapsed : ESlateVisibility.SelfHitTestInvisible);
	}

	private void OnChangeScale(EChangeReason Reason, float OldValue, float NewValue)
	{
		Wiget.SetRenderScale(FVector2D.UnitVector * NewValue);
	}
}

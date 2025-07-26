using b1;
using UnrealEngine.Runtime;

namespace Game_Helper;

public class BU_Print : BaseGameHelper
{
	private BUC_BuffData buffData = null;

	private static bool isShow;

	public bool IsRuning { get; set; }

	public void OnInitialize()
	{
		if (Tools.BU_UIGameHelper != null && Tools.BU_UIGameHelper.fieldOrProperty != null)
		{
			buffData = Tools.BUC_AnyDataGet<BUC_BuffData>();
			if (buffData != null)
			{
				IsShow(show: true);
				Tools.BU_UIGameHelper.AddTextBlock("buffdata", new FVector2D(3000.0, -2000.0));
				Tools.BU_UIGameHelper.SetColor("buffdata", "#BECC42");
			}
		}
	}

	public void OnTick(float DeltTime, int TickGroup)
	{
		if (buffData == null)
		{
			OnInitialize();
			return;
		}
		if (!IsRuning)
		{
			Tools.BU_UIGameHelper.GetLine("buffdata")?.SetText(FText.FromString(""));
			return;
		}
		string text = "";
		foreach (BuffInstData allBuffInstDatum in buffData.GetAllBuffInstData())
		{
			text += $"ID: {allBuffInstDatum.BuffID} : 剩余时间: {allBuffInstDatum.LeftTime} : 层数: {allBuffInstDatum.Layer}\n";
		}
		Tools.BU_UIGameHelper.GetLine("buffdata")?.SetText(FText.FromString(text));
	}

	public void StartRun()
	{
		IsRuning = true;
	}

	public void StopRun()
	{
		IsRuning = false;
		Tools.BU_UIGameHelper.GetLine("buffdata")?.SetText(FText.FromString(""));
	}

	public static void IsShow(bool show)
	{
		isShow = show;
	}
}

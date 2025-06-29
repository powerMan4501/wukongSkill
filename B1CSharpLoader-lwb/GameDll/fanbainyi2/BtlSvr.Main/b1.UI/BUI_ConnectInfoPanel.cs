using System;
using System.Text;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_ConnectInfoPanel")]
public class BUI_ConnectInfoPanel : BUI_Widget
{
	private UTextBlock PingTextBlock;

	private URichTextBlock ConnectionInfoTextBlock;

	private int FPSTmp;

	private int FPSThreshold = 1;

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		PingTextBlock = FindChildWidget("PingText") as UTextBlock;
		ConnectionInfoTextBlock = FindChildWidget("TextConnectionInfo") as URichTextBlock;
	}

	public void Tick(float InDeltaTime)
	{
		SetPingAndFpsInTextBlock(InDeltaTime);
		SetConnectionInfoInTextBlock(InDeltaTime);
	}

	private void SetConnectionInfoInTextBlock(float DeltaTime)
	{
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(this);
		if (firstLocalPlayerController == null)
		{
			return;
		}
		APawn controlledPawn = firstLocalPlayerController.GetControlledPawn();
		if (controlledPawn == null || controlledPawn.World == null)
		{
			ConnectionInfoTextBlock?.SetVisibility(ESlateVisibility.Hidden);
			return;
		}
		if (UGSE_EngineFuncLib.IsStandAlone(controlledPawn.World) || !DebugConfig.ConnectionInfo)
		{
			ConnectionInfoTextBlock?.SetVisibility(ESlateVisibility.Hidden);
			return;
		}
		ConnectionInfoTextBlock?.SetVisibility(ESlateVisibility.Visible);
		UGSE_NetFuncLib.GetAllActiveConnectionInfo(this, out var ConnectionInfos);
		StringBuilder stringBuilder = new StringBuilder();
		StringBuilder stringBuilder2 = new StringBuilder();
		stringBuilder.Append($"Local({firstLocalPlayerController.GetLocalRole()})");
		int num = 0;
		int num2 = 0;
		foreach (FGSConnectionInfo item in ConnectionInfos)
		{
			num += item.InSpeedByte;
			num2 += item.OutSpeedByte;
			stringBuilder2.AppendLine($"{item.URLInfo}:<TeamWarnTips_Green>↑{FormatSpeedByte(item.InSpeedByte)} ↓{FormatSpeedByte(item.OutSpeedByte)}  {item.NetLagMS:F1}ms</>");
		}
		stringBuilder.AppendLine("<TeamWarnTips_Green>↑" + FormatSpeedByte(num) + " ↓" + FormatSpeedByte(num2) + "</>");
		stringBuilder.Append(stringBuilder2);
		ConnectionInfoTextBlock?.SetText(FText.FromString(stringBuilder.ToString()));
	}

	public string FormatSpeedByte(int SpeedByte)
	{
		if ((double)SpeedByte > 1023897.6)
		{
			return $"{(float)SpeedByte / 1048576f:F2)}MB/s";
		}
		if (SpeedByte > 1024)
		{
			return $"{SpeedByte / 1024:F1}KB/s";
		}
		return $"{SpeedByte}B/s";
	}

	private void SetPingAndFpsInTextBlock(float DeltaTime)
	{
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(this);
		if (firstLocalPlayerController == null)
		{
			return;
		}
		APawn controlledPawn = firstLocalPlayerController.GetControlledPawn();
		if (controlledPawn == null || controlledPawn.World == null)
		{
			return;
		}
		if (UGSE_EngineFuncLib.IsStandAlone(controlledPawn.World) || !DebugConfig.ConnectionInfo)
		{
			PingTextBlock.SetVisibility(ESlateVisibility.Hidden);
			return;
		}
		PingTextBlock.SetVisibility(ESlateVisibility.Visible);
		int num = 0;
		if (firstLocalPlayerController != null)
		{
			APlayerState playerState = firstLocalPlayerController.PlayerState;
			if (playerState != null)
			{
				num = (int)playerState.GetPingInMilliseconds();
			}
		}
		FText fText = FText.FromString(num.ToString().PadLeft(3, ' '));
		int num2 = FMath.FloorToInt(1f / DeltaTime);
		if (FMath.Abs(num2 - FPSTmp) > FPSThreshold)
		{
			FPSTmp = num2;
		}
		else
		{
			num2 = FPSTmp;
		}
		FText fText2 = FText.FromString(num2.ToString().PadLeft(3, ' '));
		FText fmt = FText.FromString("FPS:{0}      {1}ms");
		PingTextBlock.SetText(FText.Format(fmt, fText2, fText));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUI_ConnectInfoPanel");
	}

	static BUI_ConnectInfoPanel()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUI_ConnectInfoPanel)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUI_ConnectInfoPanel));
	}
}

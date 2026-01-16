using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using b1;
using BtlShare;
using CSharpModBase;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.Slate;
using UnrealEngine.SlateCore;
using UnrealEngine.UMG;

namespace bian;

public class ShowPlayerInfo
{
	public static List<UTextBlock> BasicInfoKs = new List<UTextBlock>();
	public static List<UTextBlock> BasicInfoVs = new List<UTextBlock>();

	public static Dictionary<EBGUAttrFloat, string> BasicAttributes = new Dictionary<EBGUAttrFloat, string>
	{
		{ EBGUAttrFloat.Shield,  "" },
		{ EBGUAttrFloat.CritRate, "" },
		{ EBGUAttrFloat.Hp,  "" },
		{ EBGUAttrFloat.FreezeDef,  "" },
		{ EBGUAttrFloat.FreezeAtk,  "" },
		{ EBGUAttrFloat.CurEnergy,  "" },
		{ EBGUAttrFloat.EnumMax,  "" },
		{ EBGUAttrFloat.None,  "" },
	};

	private static UWorld? world;

	public static UWorld? GetWorld()
	{
		if (world == null || !world.IsValidLowLevel() || world.IsPendingKill)
		{
			world = GCHelper.FindRef(FGlobals.GWorld)?.Managed as UWorld;
		}
		return world;
	}

	public static bool IsValidActor(AActor? actor)
	{
		return actor != null && actor.IsValidLowLevel() && !actor.IsPendingKill && !actor.IsActorBeingDestroyed();
	}

	public static bool IsValidUObject(UObject? uobj)
	{
		return uobj != null && uobj.IsValidLowLevel() && !uobj.IsPendingKill;
	}

	public static FSlateFontInfo FontInfo = new FSlateFontInfo
	{
		FontObject = UObject.LoadObject<UFont>(null, "/Game/00MainHZ/UI/Fonts/B1Font_Main.B1Font_Main"),
		Size = 33
	};
	// 添加特殊属性字体样式
	public static FSlateFontInfo BoldFontInfo = new FSlateFontInfo
	{
		FontObject = UObject.LoadObject<UFont>(null, "/Game/00MainHZ/UI/Fonts/B1Font_Main.B1Font_Main"),
		Size = 42
	};

	public static void SetUTextBlockContent(UTextBlock textBlock, string content)
	{
		if (IsValidUObject(textBlock))
		{
			textBlock.SetText(FText.FromString(content));
		}
	}

	public static void UpdateUTextBlockContentIfChanged(UTextBlock textBlock, string newText)
	{
		if (IsValidUObject(textBlock))
		{
			string text = textBlock.GetText().ToString();
			if (text != newText)
			{
				textBlock.SetText(FText.FromString(newText));
			}
		}
	}

	public static void SetUTextBlockFont(UTextBlock textBlock, FSlateFontInfo fontInfo)
	{
		if (IsValidUObject(textBlock))
		{
			textBlock.SetFont(fontInfo);
		}
	}

	public static void SetUTextBlockStyle(UTextBlock? textBlock, float opacity, ETextJustify justify)
	{
		if (IsValidUObject(textBlock))
		{
			textBlock.SetJustification(justify);
			textBlock.SetOpacity(opacity);
		}
	}

	// 添加需要特殊样式的属性集合
	public static readonly HashSet<EBGUAttrFloat> SpecialAttributes = new HashSet<EBGUAttrFloat>
{
	EBGUAttrFloat.Shield,
	EBGUAttrFloat.Atk,
	EBGUAttrFloat.DmgDef
};


	private static Timer? updateTimer;

	public static void InitItems(bool force = false)
	{
		BGUPlayerCharacterCS bGUPlayerCharacterCS = GetBGUPlayerCharacterCS();
		if (bGUPlayerCharacterCS == null)
		{
			return;
		}
		if (BasicInfoKs.Count > 0)
		{
			ClearAllUI();

			if (!force) return;
		}

		foreach (var attribute in BasicAttributes)
		{
			UTextBlock keyBlock = UObject.NewObject<UTextBlock>();
			UTextBlock valueBlock = UObject.NewObject<UTextBlock>();
			BasicInfoKs.Add(keyBlock);
			BasicInfoVs.Add(valueBlock);
			SetUTextBlockContent(keyBlock, attribute.Value);
			SetUTextBlockFont(keyBlock, FontInfo);
			SetUTextBlockFont(valueBlock, FontInfo);
			SetUTextBlockStyle(keyBlock, 0.6f, ETextJustify.Left);
			SetUTextBlockStyle(valueBlock, 0.6f, ETextJustify.Right);
			// 优化后的特殊样式设置
			if (SpecialAttributes.Contains(attribute.Key))
			{
				SetUTextBlockFont(keyBlock, BoldFontInfo);
				SetUTextBlockFont(valueBlock, BoldFontInfo);
			}
		}

		var timerComp = new TimerComp();

		if (!timerComp.InitDone())
		{
			timerComp.InitWidgets();
		}
		else
		{
			timerComp.RenderBasicInfo();
		}
		// 启动定时器
		StartUpdateTimer(timerComp);

	}
	private static void StartUpdateTimer(TimerComp timerComp)
	{

		// 如果已有定时器在运行，先停止它
		if (updateTimer != null)
		{
			updateTimer.Dispose();
			updateTimer = null;
		}

		// 创建新的定时器，每0.5秒执行一次
		updateTimer = new Timer(_ =>
		{

			if (timerComp != null)
			{
				if (!timerComp.InitDone())
				{
					timerComp.InitWidgets();
				}
				else
				{
					timerComp.RenderBasicInfo();
				}
			}
		}, null, TimeSpan.Zero, TimeSpan.FromSeconds(1));
	}

	public static APawn? GetControlledPawn()
	{
		UWorld uWorld = GetWorld();
		if (!IsValidUObject(uWorld))
		{
			return null;
		}
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController((UObject)uWorld);
		if (!IsValidActor(firstLocalPlayerController))
		{
			return null;
		}
		return firstLocalPlayerController.GetControlledPawn();
	}
	public static BGUPlayerCharacterCS? GetBGUPlayerCharacterCS()
	{
		APawn controlledPawn = GetControlledPawn();
		if (!IsValidActor(controlledPawn))
		{
			return null;
		}
		return controlledPawn as BGUPlayerCharacterCS;
	}


	public static void ClearAllUI()
	{
		// 清理定时器
		if (updateTimer != null)
		{
			updateTimer.Dispose();
			updateTimer = null;
		}
		var timerComp = new TimerComp();
		timerComp.DestroyMainCon();
		// 先处理Key文本块
		if (BasicInfoKs.Count > 0)
		{
			// 创建临时列表存储要移除的元素
			var keysToRemove = new List<UTextBlock>(BasicInfoKs);
			foreach (var textBlock in keysToRemove)
			{
				if (IsValidUObject(textBlock))
				{
					textBlock.SetText(FText.GetEmpty());
					textBlock.RemoveFromParent();
				}
			}
			// 在循环结束后清空列表
			BasicInfoKs.Clear();
		}
		// 处理Value文本块
		if (BasicInfoVs.Count > 0)
		{
			// 创建临时列表存储要移除的元素
			var valuesToRemove = new List<UTextBlock>(BasicInfoVs);
			foreach (var textBlock in valuesToRemove)
			{
				if (IsValidUObject(textBlock))
				{
					textBlock.SetText(FText.GetEmpty());
					textBlock.RemoveFromParent();
				}
			}
			// 在循环结束后清空列表
			BasicInfoVs.Clear();
		}
	}
}

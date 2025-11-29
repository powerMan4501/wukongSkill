using System;
using System.Collections.Generic;
using System.Threading;
using b1;
using BtlShare;
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
		{ EBGUAttrFloat.Hp,  "生命" },
		{ EBGUAttrFloat.Mp, "法力" },
		{ EBGUAttrFloat.Shield,  "护盾" },
		{ EBGUAttrFloat.Atk, "攻击" },
		{ EBGUAttrFloat.Def, "防御" },
		{ EBGUAttrFloat.DmgDef, "伤害减免" },
		{ EBGUAttrFloat.DmgAddition, "伤害加成" },
		{ EBGUAttrFloat.CritRate, "暴击率" },
		{ EBGUAttrFloat.CritMultiplierBase, "暴击伤害" },
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
		Size = 32
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

	public static void InitItems()
	{
		// if (BasicInfoKs.Count > 0) return;  // 添加初始化检查
		foreach (var attribute in BasicAttributes)
		{
			UTextBlock keyBlock = UObject.NewObject<UTextBlock>();
			UTextBlock valueBlock = UObject.NewObject<UTextBlock>();
			BasicInfoKs.Add(keyBlock);
			BasicInfoVs.Add(valueBlock);

			SetUTextBlockContent(keyBlock, attribute.Value);
			// SetUTextBlockContent(valueBlock, "0");

			SetUTextBlockFont(keyBlock, FontInfo);
			SetUTextBlockFont(valueBlock, FontInfo);
			SetUTextBlockStyle(keyBlock, 0.6f, ETextJustify.Left);
			SetUTextBlockStyle(valueBlock, 0.6f, ETextJustify.Right);
		}

		ShowInfo();
	}

	public static void ShowInfo()
	{
		try
		{
			UWorld world = GetWorld();

			Console.WriteLine("ShowInfo world: " + world?.GetName());
			BGUPlayerCharacterCS bGUPlayerCharacterCS = Helper.GetBGUPlayerCharacterCS();
			if (IsValidActor((AActor?)(object)bGUPlayerCharacterCS))
			{
				UActorCompContainerCS actorCompContainerCS = bGUPlayerCharacterCS.ActorCompContainerCS;
				if (!IsValidUObject((UObject?)(object)actorCompContainerCS))
				{
					return;
				}
				List<UActorCompBaseCS> list = actorCompContainerCS?.GetFieldOrProperty<List<UActorCompBaseCS>>("CompCSs");
				if (list == null)
				{
					return;
				}
				TimerComp timerComp = null;
				foreach (UActorCompBaseCS item2 in list)
				{
					if (item2 != null && item2.GetType() == typeof(TimerComp))
					{
						timerComp = item2 as TimerComp;
					}
				}
				if (timerComp == null)
				{
					TimerComp newComp = new TimerComp();
					if (IsValidActor((AActor?)(object)bGUPlayerCharacterCS) && IsValidUObject((UObject?)(object)actorCompContainerCS))
					{

						actorCompContainerCS?.AddComp(newComp);
						actorCompContainerCS?.RecalculateCanTick();
					}
				}
			}

		}
		catch (Exception ex)
		{
			Console.WriteLine("ShowInfo error: " + ex.Message);
			Console.WriteLine(ex.StackTrace);
		}
	}
}

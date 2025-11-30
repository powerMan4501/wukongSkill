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
		{ EBGUAttrFloat.Shield,  "护盾" },
		{ EBGUAttrFloat.Hp,  "生命" },
		{ EBGUAttrFloat.Mp, "法力" },
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
	public static void InitItems(bool force = false)
	{
		if (BasicInfoKs.Count > 0 && !force) return;  // 添加初始化检查
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
			// 优化后的特殊样式设置
			if (SpecialAttributes.Contains(attribute.Key))
			{
				SetUTextBlockFont(keyBlock, BoldFontInfo);
				SetUTextBlockFont(valueBlock, BoldFontInfo);
			}
		}

		ShowInfo();
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
	public static void ShowInfo()
	{
		try
		{

			BGUPlayerCharacterCS bGUPlayerCharacterCS = GetBGUPlayerCharacterCS();
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
				// 优化：使用LINQ的FirstOrDefault来查找TimerComp
				TimerComp timerComp = list.OfType<TimerComp>().FirstOrDefault();
				if (timerComp == null)
				{

					BasicInfoKs.Clear();
					BasicInfoVs.Clear();
					TimerComp newComp = new TimerComp();
					newComp.isInitialized = false;
					newComp.World = null;
					newComp.MainCon = null;
					if (IsValidActor((AActor?)(object)bGUPlayerCharacterCS) && IsValidUObject((UObject?)(object)actorCompContainerCS))
					{

						actorCompContainerCS?.AddComp(newComp);
						actorCompContainerCS?.RecalculateCanTick();

						if (timerComp != null)
						{
							var result = timerComp.InitDone();


							if (!result)
							{
								timerComp.InitWidgets();
							}
							else
							{
								timerComp.RenderBasicInfo(1);
							}
						}

					}
				}
				else
				{

					var result = timerComp.InitDone();
					Log.Info($"TimerComp has value ,InitDone:{result}");
					if (!result)
					{
						timerComp.InitWidgets();
					}
					else
					{
						timerComp.RenderBasicInfo(1);
					}

					actorCompContainerCS?.RecalculateCanTick();
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

using System;
using System.Collections.Generic;
using B1UI.GSUI;
using GSE.GSUI;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;
using UnrealEngine.UMG;

namespace Game_Helper;

public class BU_UIGameHelper : BaseGameHelper
{
	private UWorld world;

	private UIBattleMainCon uibattleMainCon;

	public UCanvasPanel fieldOrProperty;

	private UVerticalBox UVerticalBox;

	private FVector2D UVPosition = new FVector2D(0.0, -2000.0);

	private UCanvasPanelSlot uPanelSlot;

	private Dictionary<string, UTextBlock> UILabelDic = new Dictionary<string, UTextBlock>();

	private Dictionary<string, UCanvasPanelSlot> PanelSlotDic = new Dictionary<string, UCanvasPanelSlot>();

	private List<string> LabelDicKey;

	public bool IsRuning { get; set; }

	public void OnInitialize()
	{
		world = GCHelper.FindRef(FGlobals.GWorld)?.Managed as UWorld;
		if (!(world != null))
		{
			return;
		}
		ref UIBattleMainCon reference = ref uibattleMainCon;
		GSUIPage obj = GSUI.UIMgr.FindUIPage((UObject)world, 2);
		reference = (UIBattleMainCon)(object)((obj is UIBattleMainCon) ? obj : null);
		if (uibattleMainCon == null)
		{
			Console.WriteLine("UIBattleMainCon not found");
			return;
		}
		if (uibattleMainCon != null && uibattleMainCon.GetFieldOrProperty<UCanvasPanel>("PlayerStCon") != null)
		{
			fieldOrProperty = uibattleMainCon.GetFieldOrProperty<UCanvasPanel>("PlayerStCon");
		}
		if (!(fieldOrProperty == null))
		{
			UVerticalBox = UObject.NewObject<UVerticalBox>();
			AddVerticalBox();
			AddLine("att");
			SetColor("att", "#1FBAB0");
		}
	}

	private void AddVerticalBox()
	{
		uPanelSlot = fieldOrProperty.AddChild(UVerticalBox) as UCanvasPanelSlot;
		uPanelSlot.SetPosition(UVPosition);
	}

	public UTextBlock AddLine(string lable)
	{
		if (UILabelDic.TryGetValue(lable, out var value))
		{
			return value;
		}
		UTextBlock uTextBlock = UObject.NewObject<UTextBlock>();
		UILabelDic.Add(lable, uTextBlock);
		UVerticalBox.AddChild(uTextBlock);
		return uTextBlock;
	}

	public UTextBlock AddTextBlock(string lable, FVector2D fVector2D)
	{
		if (UILabelDic.TryGetValue(lable, out var value))
		{
			return value;
		}
		UTextBlock uTextBlock = UObject.NewObject<UTextBlock>();
		UILabelDic.Add(lable, uTextBlock);
		UCanvasPanelSlot uCanvasPanelSlot = fieldOrProperty.AddChild(uTextBlock) as UCanvasPanelSlot;
		uCanvasPanelSlot.SetPosition(fVector2D);
		PanelSlotDic[lable] = uCanvasPanelSlot;
		return uTextBlock;
	}

	public UTextBlock GetLine(string lable)
	{
		if (UILabelDic.TryGetValue(lable, out var value))
		{
			return value;
		}
		return null;
	}

	public void SetColor(string lable, string hexString)
	{
		UTextBlock line = GetLine(lable);
		if (line != null)
		{
			line.SetColorAndOpacity(new FSlateColor
			{
				SpecifiedColor = new FLinearColor(FColor.FromHex(hexString))
			});
		}
	}

	public void RemoveByL(string lable)
	{
	}

	private void RemoveAll()
	{
		foreach (KeyValuePair<string, UTextBlock> item in UILabelDic)
		{
			item.Value.SetText(FText.FromString(" "));
		}
	}

	public void SetPosition(FVector2D position)
	{
		uPanelSlot.SetPosition(position);
	}

	public void SetTextBlockPos(string lable, FVector2D fVector2D)
	{
		if (PanelSlotDic.TryGetValue(lable, out var value))
		{
			value.SetPosition(fVector2D);
		}
	}

	public void OnTick(float DeltTime, int TickGroup)
	{
		if ((uibattleMainCon == null) | (fieldOrProperty == null))
		{
			OnInitialize();
		}
		else if (IsRuning)
		{
			GetLine("att").SetText(FText.FromString("战斗基本信息表"));
		}
	}

	public void StartRun()
	{
		IsRuning = true;
	}

	public void StopRun()
	{
		RemoveAll();
		IsRuning = false;
	}
}

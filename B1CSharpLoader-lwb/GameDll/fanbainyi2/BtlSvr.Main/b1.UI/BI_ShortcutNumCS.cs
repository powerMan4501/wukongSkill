using System;
using b1.Plugins.GSInput;
using b1.UI.Comm;
using ResB1;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BI_ShortcutNumCS")]
public class BI_ShortcutNumCS : BUI_StateWidget
{
	private UCanvasPanel NormalCon;

	private UTextBlock TxtNormalNum;

	private UTextBlock TxtMaxNum;

	private int CurItemID;

	private static bool ShowInputType_IsValid;

	private static int ShowInputType_Offset;

	private static FFieldAddress ShowInputType_PropertyAddress;

	private static bool CurPosIdx_IsValid;

	private static int CurPosIdx_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Tooltip("在哪种输入类型")]
	[Category("GSProperty")]
	[USharpPath("/Script/b1-Managed.BI_ShortcutNumCS:ShowInputType")]
	public EGSInputType ShowInputType
	{
		get
		{
			CheckDestroyed();
			if (!ShowInputType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BI_ShortcutNumCS:ShowInputType");
				return EGSInputType.None;
			}
			return EnumMarshaler<EGSInputType>.FromNative(IntPtr.Add(base.Address, ShowInputType_Offset), 0, ShowInputType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ShowInputType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BI_ShortcutNumCS:ShowInputType");
			}
			else
			{
				EnumMarshaler<EGSInputType>.ToNative(IntPtr.Add(base.Address, ShowInputType_Offset), 0, ShowInputType_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[Tooltip("PosIdx")]
	[EditAnywhere]
	[Category("GSProperty")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BI_ShortcutNumCS:CurPosIdx")]
	public int CurPosIdx
	{
		get
		{
			CheckDestroyed();
			if (!CurPosIdx_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BI_ShortcutNumCS:CurPosIdx");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, CurPosIdx_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CurPosIdx_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BI_ShortcutNumCS:CurPosIdx");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, CurPosIdx_Offset), value);
			}
		}
	}

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		NormalCon = FindChildWidget("DfCon") as UCanvasPanel;
		TxtNormalNum = FindChildWidget("NumQuantityDf") as UTextBlock;
		TxtMaxNum = FindChildWidget("NumQuantityMax") as UTextBlock;
	}

	public void UpdateContent(int ItemID)
	{
		CurItemID = ItemID;
		if (CurItemID != 0)
		{
			ItemDesc itemDesc = GameDBRuntime.GetItemDesc(CurItemID);
			if (itemDesc == null)
			{
				BGW_LogUtil.LogError($"[BI_ShortcutNumCS:UpdateContent]ItemDesc is null ItemID = {ItemID}");
			}
			else
			{
				TxtMaxNum.SetText(FText.FromString($"{itemDesc.CarryMax}"));
			}
		}
	}

	public void SetForceShow(bool IsShow)
	{
		if (CurItemID != 0)
		{
			if (IsShow)
			{
				SetVisibility(ESlateVisibility.SelfHitTestInvisible);
			}
			else
			{
				SetVisibility(ESlateVisibility.Collapsed);
			}
		}
	}

	public void OnNumChange(int OldValue, int NewValue)
	{
		TxtNormalNum.SetText(FText.FromString($"{NewValue}"));
		if (NewValue < OldValue)
		{
			BGW_UIMgr.Get(this)?.GetMDSBattleMain().TriggerShowState(EnMainShowState.SHOW);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BI_ShortcutNumCS");
		NativeReflection.GetPropertyRef(ref ShowInputType_PropertyAddress, unrealStruct, "ShowInputType");
		ShowInputType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ShowInputType");
		ShowInputType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ShowInputType", Classes.FEnumProperty);
		CurPosIdx_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CurPosIdx");
		CurPosIdx_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CurPosIdx", Classes.FIntProperty);
	}

	static BI_ShortcutNumCS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BI_ShortcutNumCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BI_ShortcutNumCS));
	}
}

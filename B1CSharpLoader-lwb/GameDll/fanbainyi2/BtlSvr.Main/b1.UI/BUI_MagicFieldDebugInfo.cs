using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;
using UnrealEngine.UMG;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_MagicFieldDebugInfo")]
internal class BUI_MagicFieldDebugInfo : b1.UI.BUI_ProjectileDebugInfo
{
	private BUC_MFOverlapData MFOverlapData;

	private const string INFOCONTENT_MF_InnerActor = "内部单位";

	private UTextBlock BuffText;

	private const string BUFFTEXT_NAME = "BuffText";

	private string buffstr;

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		BuffText = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("BuffText")) as UTextBlock;
		AddInitInfo("内部单位");
	}

	public override void OnRegistOwner(BGUProjectileBaseActor projectileBaseActor)
	{
		base.OnRegistOwner(projectileBaseActor);
		MFOverlapData = BGU_DataUtil.GetReadOnlyData<BUC_MFOverlapData>(base.ProjectileSelf);
	}

	protected override void OnUIGSSlowTickImpl(FGeometry MyGeometry, float InDeltaTime)
	{
		base.OnUIGSSlowTickImpl(MyGeometry, InDeltaTime);
		UpdateMFDebugInfo();
		UpdateBuffInfo();
	}

	private void UpdateMFDebugInfo()
	{
		if (!(base.ProjectileSelf is BGUMagicFieldBaseCS) || MFOverlapData == null)
		{
			return;
		}
		string text = "";
		foreach (AActor item in MFOverlapData.InnerActorList_AlreadyTriggerOverlapBegin)
		{
			if (item.IsNullOrDestroyed())
			{
				continue;
			}
			string text2 = item.GetName();
			if (item is BGUCharacterCS)
			{
				int num = text2.IndexOf("TAMER");
				if (num != -1)
				{
					text2 = text2.Substring(num);
				}
			}
			text += text2;
			text += "\n";
		}
		InfoDic["内部单位"].SetText(FText.FromString(text));
	}

	private void UpdateBuffInfo()
	{
		BUC_BuffData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_BuffData>(base.ProjectileSelf);
		if (readOnlyData == null)
		{
			return;
		}
		buffstr = "BuffID [Layer] Time\n";
		foreach (BuffInstData allBuffInstDatum in readOnlyData.GetAllBuffInstData())
		{
			int num = (int)allBuffInstDatum.LeftTime;
			buffstr += $"{allBuffInstDatum.BuffID} [{allBuffInstDatum.Layer}] {num}s \n";
		}
		BuffText.SetText(FText.FromString(buffstr));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUI_MagicFieldDebugInfo");
	}

	static BUI_MagicFieldDebugInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.UI.BUI_MagicFieldDebugInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.UI.BUI_MagicFieldDebugInfo));
	}
}

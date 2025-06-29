using System;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_BulletDebugInfo")]
internal class BUI_BulletDebugInfo : b1.UI.BUI_ProjectileDebugInfo
{
	private BUC_BulletSweepCheckData SweepCheckData;

	private const string INFOCONTENT_6 = "延迟检测";

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		AddInitInfo("延迟检测");
	}

	public override void OnRegistOwner(BGUProjectileBaseActor projectileBaseActor)
	{
		base.OnRegistOwner(projectileBaseActor);
		SweepCheckData = BGU_DataUtil.GetReadOnlyData<BUC_BulletSweepCheckData>(base.ProjectileSelf);
	}

	protected override void OnUIGSSlowTickImpl(FGeometry MyGeometry, float InDeltaTime)
	{
		base.OnUIGSSlowTickImpl(MyGeometry, InDeltaTime);
		UpdateBulletDebugInfo();
	}

	private void UpdateBulletDebugInfo()
	{
		if (base.ProjectileSelf is BGUBulletBaseCS && SweepCheckData != null)
		{
			InfoDic["延迟检测"].SetText(FText.FromString(SweepCheckData.SweepDelayTimer.ToString()));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUI_BulletDebugInfo");
	}

	static BUI_BulletDebugInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.UI.BUI_BulletDebugInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.UI.BUI_BulletDebugInfo));
	}
}

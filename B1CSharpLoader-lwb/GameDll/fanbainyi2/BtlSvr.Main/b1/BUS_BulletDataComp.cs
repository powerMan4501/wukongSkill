using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_BulletDataComp")]
public class BUS_BulletDataComp : BUS_ProjectileBaseDataComp
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<BUC_BulletSweepCheckData>();
		CreateDataClass<BUC_BulletEffectData>();
		CreateDataClass<BUC_BulletDonutAudioData>();
		if (BasicData != null)
		{
			BasicData.ActorType = BGU_ActorType.Bullet;
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_BulletDataComp");
	}

	static BUS_BulletDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_BulletDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_BulletDataComp));
	}
}

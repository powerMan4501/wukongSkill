using b1.ECS;
using UnrealEngine.Engine;

namespace b1;

public class BUC_ABPEventCollection : IPersistentECSData
{
	public delegate void Del_Void();

	public delegate void Del_Void_Float(float P1);

	public delegate void Del_ChangeABPSetting(BGWDataAsset_AbpHumanoidSetting ABPSetting);

	public delegate void Del_SetSplineMoveAnimConfig(BGWDataAsset_ManualSplineMoveAnimConfig MoveAnimConfig);

	public Del_ChangeABPSetting Evt_ChangeABPSetting = delegate
	{
	};

	public Del_Void Evt_InitABPSetting = delegate
	{
	};

	public Del_Void_Float Evt_SetValue_Alpha_FBIK_StandBar = delegate
	{
	};

	public Del_Void Evt_ResetABPSetting = delegate
	{
	};

	public Del_SetSplineMoveAnimConfig Evt_SetSplineMoveAnimConfig = delegate
	{
	};

	public Del_Void Evt_RefreshABP = delegate
	{
	};

	private static BUC_ABPEventCollection Get(AActor Actor)
	{
		return BGU_DataUtil.GetReadOnlyData<BUC_ABPEventCollection>(Actor);
	}

	public static BUC_ABPEventCollection Get(BUS_ABPHelperComp Comp)
	{
		return Get(Comp.GetOwner());
	}

	public static BUC_ABPEventCollection Get(UAnimInstance AnimInstace)
	{
		return Get(AnimInstace.GetOwningActor());
	}
}

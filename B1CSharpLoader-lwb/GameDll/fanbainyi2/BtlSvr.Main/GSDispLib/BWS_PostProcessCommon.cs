using b1;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UClass]
public class BWS_PostProcessCommon : BWS_PostProcessEffectBase
{
	private UDispLib_PostPorcessCommonConf PPConf;

	[UProperty]
	private GSDispLib_PostProcessActor PPInst { get; set; }

	public BWS_PostProcessCommon()
	{
		PPConf.ID = -1;
	}

	public static BWS_PostProcessCommon Create(GSDispLib_PostProcessContext Context, TSubclassOf<GSDispLib_PostProcessActor> PPClass)
	{
		BWS_PostProcessCommon bWS_PostProcessCommon = new BWS_PostProcessCommon();
		foreach (UDispLib_PostPorcessCommonConf commonConf in Context.Config.CommonConfs)
		{
			if (commonConf.ActorType == PPClass)
			{
				bWS_PostProcessCommon.PPConf.Copy(commonConf);
				bWS_PostProcessCommon.EffectID = commonConf.ID;
				break;
			}
		}
		bWS_PostProcessCommon.Init(Context, bWS_PostProcessCommon.PPConf);
		return bWS_PostProcessCommon;
	}

	public static BWS_PostProcessCommon Create(GSDispLib_PostProcessContext Context, int EffectID)
	{
		BWS_PostProcessCommon bWS_PostProcessCommon = new BWS_PostProcessCommon();
		foreach (UDispLib_PostPorcessCommonConf commonConf in Context.Config.CommonConfs)
		{
			if (commonConf.ID == EffectID)
			{
				bWS_PostProcessCommon.PPConf.Copy(commonConf);
				bWS_PostProcessCommon.EffectID = commonConf.ID;
				break;
			}
		}
		if (bWS_PostProcessCommon.PPConf.ID == -1)
		{
			BGW_LogUtil.LogError($"Try create Postprocess fail! EffectID:{EffectID}");
		}
		bWS_PostProcessCommon.Init(Context, bWS_PostProcessCommon.PPConf);
		return bWS_PostProcessCommon;
	}

	public void Init(GSDispLib_PostProcessContext Context, UDispLib_PostPorcessCommonConf Conf)
	{
		BeginningDuration = Conf.BeginningDuration;
		FinishingDuration = Conf.FinishingDuration;
		if (Conf.ID > -1 && Conf.ActorType != null)
		{
			PPInst = BGU_UnrealWorldUtil.SpawnActorAndECSBeginPlay(Context.World, Conf.ActorType.Value) as GSDispLib_PostProcessActor;
			if (PPInst != null)
			{
				PPInst.EffectID = EffectID;
				PPInst.OnInit(Context, PPConf);
			}
		}
	}

	public override void OnDestroy(GSDispLib_PostProcessContext Context)
	{
		if (PPInst != null && Context != null && Context.World != null)
		{
			BGU_UnrealWorldUtil.DestroyActor(PPInst);
			PPInst = null;
		}
	}

	protected override void OnEffectTick(float DeltaTime, float Progress, GSDispLib_PostProcessContext Context)
	{
		if (PPInst != null)
		{
			PPInst.OnEffectTick(DeltaTime, Progress, Context);
		}
	}

	public override void OnEnterBegin(GSDispLib_PostProcessContext Context)
	{
		if (PPInst != null)
		{
			PPInst.OnSetParameters(base.Parameters);
			PPInst.OnEnterBegin(Context);
		}
	}

	public override void OnEndBegin(GSDispLib_PostProcessContext Context)
	{
		if (PPInst != null)
		{
			PPInst.OnEndBegin(Context);
		}
	}

	public override void OnEnterFinish(GSDispLib_PostProcessContext Context)
	{
		if (PPInst != null)
		{
			PPInst.OnEnterFinish(Context);
		}
	}

	public override void OnEndFinish(GSDispLib_PostProcessContext Context)
	{
		if (PPInst != null)
		{
			PPInst.OnEndFinish(Context);
		}
	}

	public override void OnAlreadyBegin(GSDispLib_PostProcessContext Context)
	{
		if (PPInst != null)
		{
			PPInst.OnAlreadyBegin(Context);
		}
	}

	public override void OnAlreadyFinish(GSDispLib_PostProcessContext Context)
	{
		if (PPInst != null)
		{
			PPInst.OnAlreadyFinish(Context);
		}
	}
}

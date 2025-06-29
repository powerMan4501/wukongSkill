using b1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

public class BWS_PostProcessRadialBlur : BWS_PostProcessEffectBase
{
	private FName RadialCenterName = B1GlobalFNames.RadialCenter;

	private FName BlurIntensityName = B1GlobalFNames.BlurIntensity;

	private FName IterationCountName = B1GlobalFNames.IterationCount;

	private FName DepthRangeName = B1GlobalFNames.DepthRange;

	private FName DepthMaskBiasName = B1GlobalFNames.DepthMaskBias;

	private FName TintName = B1GlobalFNames.Tint;

	private FName DesaturationFactionName = B1GlobalFNames.DesaturationFaction;

	[UProperty]
	private UMaterialInstanceDynamic MaterialInst { get; set; }

	public static BWS_PostProcessRadialBlur Create(GSDispLib_PostProcessContext Context)
	{
		return new BWS_PostProcessRadialBlur();
	}

	protected override void OnEffectTick(float DeltaTime, float Progress, GSDispLib_PostProcessContext Context)
	{
		_ = MaterialInst == null;
	}

	public override void OnEnterBegin(GSDispLib_PostProcessContext Context)
	{
		base.OnEnterBegin(Context);
		Init(Context);
		if (!(MaterialInst == null))
		{
			MaterialInst.SetVectorParameterValue(RadialCenterName, Context.Config.RadialBlurConf.RadialCenter);
			MaterialInst.SetScalarParameterValue(BlurIntensityName, 0f);
			MaterialInst.SetScalarParameterValue(IterationCountName, Context.Config.RadialBlurConf.IterationCount);
			MaterialInst.SetScalarParameterValue(DepthRangeName, Context.Config.RadialBlurConf.DepthRange);
			MaterialInst.SetScalarParameterValue(DepthMaskBiasName, Context.Config.RadialBlurConf.DepthMaskBias);
			MaterialInst.SetVectorParameterValue(TintName, FLinearColor.White);
			MaterialInst.SetScalarParameterValue(DesaturationFactionName, 0f);
			BeginningDuration = Context.Config.RadialBlurConf.BeginningDuration;
			FinishingDuration = Context.Config.RadialBlurConf.FinishingDuration;
		}
	}

	public override void OnEndFinish(GSDispLib_PostProcessContext Context)
	{
		base.OnEndFinish(Context);
		UGSE_PostProcessFuncLib.RemovePPVWeightBlendable(Context.PostProcessVolume, MaterialInst);
	}

	public void Init(GSDispLib_PostProcessContext Context)
	{
		if (MaterialInst == null)
		{
			MaterialInst = UMaterialLibrary.CreateDynamicMaterialInstance(Context.PostProcessVolume, Context.Config.RadialBlurConf.Material, FName.None, EMIDCreationFlags.None);
		}
		UGSE_PostProcessFuncLib.SetPPVWeightedBlendableWeight(Context.PostProcessVolume, MaterialInst, 1f);
	}
}

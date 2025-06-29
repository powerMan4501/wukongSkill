using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_ABPSpeicalAdditiveData : IBUC_ABPSlopeAdditiveData
{
	private FVector2D MapInput;

	private FVector2D MapOutput = new FVector2D(0.0, 1.0);

	private IBUC_EnvironmentInteractionMgrData SurfaceCheckData;

	public bool bEnableLocalSpaceSlopeAdditive { get; set; }

	public bool bEnableMeshSpaceSlopeAdditive { get; set; }

	public float SlopeAlpha { get; set; }

	public void Init(BUABPSettingData Setting, IBUC_EnvironmentInteractionMgrData InSurfaceCheckData)
	{
		SurfaceCheckData = InSurfaceCheckData;
		bEnableLocalSpaceSlopeAdditive = Setting.SpecialAdditiveSetting.ASSlopeAdditiveLocalSpace != null;
		bEnableMeshSpaceSlopeAdditive = Setting.SpecialAdditiveSetting.ASSlopeAdditiveMeshSpace != null;
		MapInput.X = Setting.SpecialAdditiveSetting.MinSlopeAngle;
		MapInput.Y = Setting.SpecialAdditiveSetting.MaxSlopeAngle;
	}

	public void Update(AActor Owner)
	{
		if (bEnableLocalSpaceSlopeAdditive || bEnableMeshSpaceSlopeAdditive)
		{
			float num = FMath.Abs(MathLib.NormalizedDeltaRotator(FVector.UpVector.Rotation(), SurfaceCheckData.SurfaceNormal_Normalized.Rotation()).Pitch);
			SlopeAlpha = FMath.GetMappedRangeValueClamped(MapInput, MapOutput, num);
		}
	}
}

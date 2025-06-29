using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

public interface IBUC_ABPSpineIKData
{
	bool bEnableSpineIK { get; }

	float IKPelivisAlpha { get; set; }

	float SpineIKTraceUpDistance { get; set; }

	float SpineIKTraceDownDistance { get; set; }

	float IKSpinePitch { get; }

	float IKSpineRoll { get; }

	float LerpSpeed { get; }

	float OffsetPitch { get; set; }

	bool DisableLimbIKAlpha { get; set; }

	float IgnoreDistance { get; }

	float IKSpineAlpha { get; set; }

	FVector SpineIKFootRPos { get; }

	FVector SpineIKFootLPos { get; }

	FVector SpineIKHandRPos { get; }

	FVector SpineIKHandLPos { get; }

	float IKFootRAlpha { get; }

	float IKFootLAlpha { get; }

	float IKHandRAlpha { get; }

	float IKHandLAlpha { get; }

	float LimbIKAlpha { get; }

	List<LimbIKData> LimbIKDataList { get; }

	List<FName> LimbRootBoneNames { get; }

	List<FName> LimbEndBoneNames { get; }

	List<FVector> LimbsEndBonePositions { get; }

	List<float> LimbsPisitionAlphas { get; }

	List<float> LimbsPisitionOffset { get; }

	List<FName> LimbsCurveNames { get; }

	List<float> LimbsCurveAlphas { get; }

	Dictionary<FName, float> LimbsAlphas { get; }

	bool EnableCustomLimbIK { get; }
}

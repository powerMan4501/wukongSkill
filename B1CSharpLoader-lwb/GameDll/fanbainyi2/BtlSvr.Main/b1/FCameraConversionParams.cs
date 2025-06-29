using BtlB1;
using UnrealEngine.Runtime;

namespace b1;

public class FCameraConversionParams
{
	public int ParamID { get; set; }

	public float UnitScaleRate { get; set; }

	public float UnitMeshHeightRate { get; set; }

	public float UnitMeshHeight { get; set; }

	public float WukongMeshHeight { get; set; }

	public float UnitPelvisHeightRate { get; set; }

	public float WukongRearFootOffset { get; set; }

	public float UnitRearFootOffset { get; set; }

	public float WukongCapsuleHalfHeight { get; set; }

	public float UnitCapsuleHalfHeight { get; set; }

	public float BlendTime { get; set; }

	public void InitByID(int InParamID)
	{
		ParamID = InParamID;
		if (BGW_GameDB.GetGlobalConfigByAlias(B1GlobalConfigFNames.WukongResID, out var ConfigInfo))
		{
			FUStCameraConversionParamConfigDesc cameraConversionParamConfigDesc = BGW_GameDB.GetCameraConversionParamConfigDesc(ConfigInfo.IntValue);
			FUStCameraConversionParamConfigDesc fUStCameraConversionParamConfigDesc = BGW_GameDB.GetCameraConversionParamConfigDesc(InParamID) ?? cameraConversionParamConfigDesc;
			if (cameraConversionParamConfigDesc != null)
			{
				UnitScaleRate = fUStCameraConversionParamConfigDesc.Scale / cameraConversionParamConfigDesc.Scale;
				UnitMeshHeightRate = fUStCameraConversionParamConfigDesc.MeshHeight / cameraConversionParamConfigDesc.MeshHeight;
				UnitPelvisHeightRate = fUStCameraConversionParamConfigDesc.PelvisHeight / cameraConversionParamConfigDesc.PelvisHeight;
				WukongRearFootOffset = cameraConversionParamConfigDesc.RearFootOffset;
				UnitRearFootOffset = fUStCameraConversionParamConfigDesc.RearFootOffset;
				WukongCapsuleHalfHeight = cameraConversionParamConfigDesc.CapsuleHalfHeight;
				UnitCapsuleHalfHeight = fUStCameraConversionParamConfigDesc.CapsuleHalfHeight;
				UnitMeshHeight = fUStCameraConversionParamConfigDesc.MeshHeight;
				WukongMeshHeight = cameraConversionParamConfigDesc.MeshHeight;
				BlendTime = fUStCameraConversionParamConfigDesc.BlendTime;
			}
		}
	}

	public void CopyFromOther(FCameraConversionParams Other)
	{
		ParamID = Other.ParamID;
		UnitScaleRate = Other.UnitScaleRate;
		UnitMeshHeightRate = Other.UnitMeshHeightRate;
		UnitPelvisHeightRate = Other.UnitPelvisHeightRate;
		WukongRearFootOffset = Other.WukongRearFootOffset;
		UnitRearFootOffset = Other.UnitRearFootOffset;
		WukongCapsuleHalfHeight = Other.WukongCapsuleHalfHeight;
		UnitCapsuleHalfHeight = Other.UnitCapsuleHalfHeight;
		BlendTime = Other.BlendTime;
	}

	public void LerpValue(FCameraConversionParams Origin, FCameraConversionParams Target, float Alpha)
	{
		UnitScaleRate = FMath.Lerp(Origin.UnitScaleRate, Target.UnitScaleRate, Alpha);
		UnitMeshHeightRate = FMath.Lerp(Origin.UnitMeshHeightRate, Target.UnitMeshHeightRate, Alpha);
		UnitPelvisHeightRate = FMath.Lerp(Origin.UnitPelvisHeightRate, Target.UnitPelvisHeightRate, Alpha);
		UnitRearFootOffset = FMath.Lerp(Origin.UnitRearFootOffset, Target.UnitRearFootOffset, Alpha);
		UnitCapsuleHalfHeight = FMath.Lerp(Origin.UnitCapsuleHalfHeight, Target.UnitCapsuleHalfHeight, Alpha);
	}
}

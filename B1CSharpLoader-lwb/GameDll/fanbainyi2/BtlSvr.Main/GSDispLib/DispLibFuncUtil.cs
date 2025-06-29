using b1;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace GSDispLib;

public class DispLibFuncUtil
{
	public static FVector XAxisV3 = new FVector(1.0, 0.0, 0.0);

	public static FVector YAxisV3 = new FVector(0.0, 1.0, 0.0);

	public static FVector ZAxisV3 = new FVector(0.0, 0.0, 1.0);

	public static FVector GetAxisVector(DispLibDBCAxisMode AxisMode, USceneComponent MeshOrRootComp, FTransform SocketTransformWS, FVector SocketVelocity, FVector CustomRotationLS)
	{
		_ = FVector.ZeroVector;
		bool flag = false;
		FTransform fTransform = FTransform.Default;
		if (CustomRotationLS != FVector.ZeroVector)
		{
			flag = true;
			fTransform = new FRotator(CustomRotationLS.Y, CustomRotationLS.Z, CustomRotationLS.X).Conv_RotatorToTransform();
		}
		switch (AxisMode)
		{
		case DispLibDBCAxisMode.Zero:
			return FVector.ZeroVector;
		case DispLibDBCAxisMode.WS_X:
			if (!flag)
			{
				return XAxisV3;
			}
			return fTransform.TransformVectorNoScale(XAxisV3).GetSafeNormal();
		case DispLibDBCAxisMode.WS_Y:
			if (!flag)
			{
				return YAxisV3;
			}
			return fTransform.TransformVectorNoScale(YAxisV3).GetSafeNormal();
		case DispLibDBCAxisMode.WS_Z:
			if (!flag)
			{
				return ZAxisV3;
			}
			return fTransform.TransformVectorNoScale(ZAxisV3).GetSafeNormal();
		case DispLibDBCAxisMode.WS_N_X:
			return (flag ? fTransform.TransformVectorNoScale(XAxisV3).GetSafeNormal() : XAxisV3).NegateVector();
		case DispLibDBCAxisMode.WS_N_Y:
			return (flag ? fTransform.TransformVectorNoScale(YAxisV3).GetSafeNormal() : YAxisV3).NegateVector();
		case DispLibDBCAxisMode.WS_N_Z:
			return (flag ? fTransform.TransformVectorNoScale(YAxisV3).GetSafeNormal() : ZAxisV3).NegateVector();
		case DispLibDBCAxisMode.Bone_X:
		{
			FVector v9 = (flag ? fTransform.TransformVectorNoScale(XAxisV3).GetSafeNormal() : XAxisV3);
			return SocketTransformWS.TransformVectorNoScale(v9);
		}
		case DispLibDBCAxisMode.Bone_Y:
		{
			FVector v10 = (flag ? fTransform.TransformVectorNoScale(YAxisV3).GetSafeNormal() : YAxisV3);
			return SocketTransformWS.TransformVectorNoScale(v10);
		}
		case DispLibDBCAxisMode.Bone_Z:
		{
			FVector v11 = (flag ? fTransform.TransformVectorNoScale(ZAxisV3).GetSafeNormal() : ZAxisV3);
			return SocketTransformWS.TransformVectorNoScale(v11);
		}
		case DispLibDBCAxisMode.Bone_N_X:
		{
			FVector v8 = -1.0 * (flag ? fTransform.TransformVectorNoScale(XAxisV3).GetSafeNormal() : XAxisV3);
			return SocketTransformWS.TransformVectorNoScale(v8);
		}
		case DispLibDBCAxisMode.Bone_N_Y:
		{
			FVector v7 = -1.0 * (flag ? fTransform.TransformVectorNoScale(YAxisV3).GetSafeNormal() : YAxisV3);
			return SocketTransformWS.TransformVectorNoScale(v7);
		}
		case DispLibDBCAxisMode.Bone_N_Z:
		{
			FVector v12 = -1.0 * (flag ? fTransform.TransformVectorNoScale(ZAxisV3).GetSafeNormal() : ZAxisV3);
			return SocketTransformWS.TransformVectorNoScale(v12);
		}
		case DispLibDBCAxisMode.Bone_Velocity:
			return (flag ? fTransform.TransformVectorNoScale(SocketVelocity) : SocketVelocity).GetSafeNormal();
		case DispLibDBCAxisMode.Bone_N_Velocity:
			return (flag ? fTransform.TransformVectorNoScale(SocketVelocity) : SocketVelocity).GetSafeNormal().NegateVector();
		case DispLibDBCAxisMode.Owner_Velocity:
			return (flag ? fTransform.TransformVectorNoScale(MeshOrRootComp.GetComponentVelocity()) : MeshOrRootComp.GetComponentVelocity()).GetSafeNormal();
		case DispLibDBCAxisMode.Owner_N_Velocity:
			return (flag ? fTransform.TransformVectorNoScale(MeshOrRootComp.GetComponentVelocity()) : MeshOrRootComp.GetComponentVelocity()).GetSafeNormal().NegateVector();
		default:
		{
			FTransform socketTransform = MeshOrRootComp.GetSocketTransform(B1GlobalFNames.root);
			switch (AxisMode)
			{
			case DispLibDBCAxisMode.Owner_X:
			{
				FVector v6 = (flag ? fTransform.TransformVectorNoScale(XAxisV3).GetSafeNormal() : XAxisV3);
				return socketTransform.TransformVectorNoScale(v6);
			}
			case DispLibDBCAxisMode.Owner_Y:
			{
				FVector v2 = (flag ? fTransform.TransformVectorNoScale(YAxisV3).GetSafeNormal() : YAxisV3);
				return socketTransform.TransformVectorNoScale(v2);
			}
			case DispLibDBCAxisMode.Owner_Z:
			{
				FVector v4 = (flag ? fTransform.TransformVectorNoScale(ZAxisV3).GetSafeNormal() : ZAxisV3);
				return socketTransform.TransformVectorNoScale(v4);
			}
			case DispLibDBCAxisMode.Owner_N_X:
			{
				FVector v3 = (flag ? fTransform.TransformVectorNoScale(XAxisV3).GetSafeNormal() : XAxisV3).NegateVector();
				return socketTransform.TransformVectorNoScale(v3);
			}
			case DispLibDBCAxisMode.Owner_N_Y:
			{
				FVector v5 = (flag ? fTransform.TransformVectorNoScale(YAxisV3).GetSafeNormal() : YAxisV3).NegateVector();
				return socketTransform.TransformVectorNoScale(v5);
			}
			case DispLibDBCAxisMode.Owner_N_Z:
			{
				FVector v = (flag ? fTransform.TransformVectorNoScale(ZAxisV3).GetSafeNormal() : ZAxisV3).NegateVector();
				return socketTransform.TransformVectorNoScale(v);
			}
			default:
				return FVector.ZeroVector;
			}
		}
		}
	}

	public static bool ValidateDBCNiagaraScalabilitySettings(BUC_DispLibDBC_NiagaraEventScalabilitySettings Setting)
	{
		if (!Setting.Enable)
		{
			return false;
		}
		if (!Setting.Low.Enable && !Setting.Medium.Enable && !Setting.High.Enable && !Setting.Epic.Enable && !Setting.Cinematic.Enable)
		{
			return false;
		}
		return true;
	}

	public static bool IsEqualDBCNiagaraScalabilitySettings(BUC_DispLibDBC_NiagaraEventScalabilitySettings A, BUC_DispLibDBC_NiagaraEventScalabilitySettings B)
	{
		if (A.Enable != B.Enable)
		{
			return false;
		}
		if (A.PoolMode != B.PoolMode)
		{
			return false;
		}
		if (!IsEqualDBCOneEffectQualityNiagaraScalabilitySettings(A.Low, B.Low))
		{
			return false;
		}
		if (!IsEqualDBCOneEffectQualityNiagaraScalabilitySettings(A.Medium, B.Medium))
		{
			return false;
		}
		if (!IsEqualDBCOneEffectQualityNiagaraScalabilitySettings(A.High, B.High))
		{
			return false;
		}
		if (!IsEqualDBCOneEffectQualityNiagaraScalabilitySettings(A.Epic, B.Epic))
		{
			return false;
		}
		if (!IsEqualDBCOneEffectQualityNiagaraScalabilitySettings(A.Cinematic, B.Cinematic))
		{
			return false;
		}
		return true;
	}

	public static bool IsEqualDBCOneEffectQualityNiagaraScalabilitySettings(BUC_DispLibDBC_OneEffectQualityNiagaraScalabilitySettings A, BUC_DispLibDBC_OneEffectQualityNiagaraScalabilitySettings B)
	{
		if (A.Enable != B.Enable)
		{
			return false;
		}
		if (A.MaxSystemInstanceCount != B.MaxSystemInstanceCount)
		{
			return false;
		}
		if (A.Mode != B.Mode)
		{
			return false;
		}
		if (A.AgeWeight != B.AgeWeight)
		{
			return false;
		}
		if (A.CameraDistanceWeight != B.CameraDistanceWeight)
		{
			return false;
		}
		if (A.CameraForwardDirDotWeight != B.CameraForwardDirDotWeight)
		{
			return false;
		}
		if (A.CustomWeightAdd != B.CustomWeightAdd)
		{
			return false;
		}
		return true;
	}

	public static ENCPoolMethod GetNCPoolMethodByDBCEndMode(DispLibDBCEndMode EndMode)
	{
		ENCPoolMethod result = ENCPoolMethod.AutoRelease;
		switch (EndMode)
		{
		case DispLibDBCEndMode.AutoRelease:
			result = ENCPoolMethod.AutoRelease;
			break;
		case DispLibDBCEndMode.FixDuration:
			result = ENCPoolMethod.ManualRelease;
			break;
		case DispLibDBCEndMode.ProcedureNotity:
			result = ENCPoolMethod.ManualRelease;
			break;
		}
		if (BGW_DispLibGameDB.GameDBDataAsset != null && !BGW_DispLibGameDB.GameDBDataAsset.DispConstDA.DBCUseUEFXPool)
		{
			result = ENCPoolMethod.None;
		}
		return result;
	}

	public static EPSCPoolMethod GetPSCPoolMethodByDBCEndMode(DispLibDBCEndMode EndMode)
	{
		return EndMode switch
		{
			_ => EPSCPoolMethod.AutoRelease, 
		};
	}
}

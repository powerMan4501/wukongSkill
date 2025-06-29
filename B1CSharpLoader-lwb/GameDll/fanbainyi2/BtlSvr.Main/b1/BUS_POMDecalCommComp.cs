using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_POMDecalCommComp : UActorCompBaseCS
{
	private BUC_POMDecalCommData POMDecalCommData;

	public override void OnAttach()
	{
		POMDecalCommData = RequireWritableData<BUC_POMDecalCommData>();
		UpdatePOMDecalRot();
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		DecalRotTick();
	}

	private void DecalRotTick()
	{
		if (!(GetOwner() as BGUPOMDecalActor).IsNullOrDestroyed())
		{
			UpdatePOMDecalRot();
		}
	}

	private void UpdatePOMDecalRot()
	{
		BGUPOMDecalActor bGUPOMDecalActor = GetOwner() as BGUPOMDecalActor;
		if (bGUPOMDecalActor.IsNullOrDestroyed())
		{
			return;
		}
		FQuat rotation = BGUFuncLibActorTransformCS.BGUGetActorTransform(bGUPOMDecalActor).InvertTransform().Rotation;
		FTransform t = new FTransform(rotation, FVector.ZeroVector, FVector.OneVector);
		FMatrix fMatrix = MathLib.TransformToMatrix(t);
		UDecalComponent decal = bGUPOMDecalActor.GetDecal();
		if (!(decal == null))
		{
			UMaterialInstanceDynamic uMaterialInstanceDynamic = decal.GetDecalMaterial() as UMaterialInstanceDynamic;
			if (uMaterialInstanceDynamic == null)
			{
				uMaterialInstanceDynamic = decal.CreateDynamicMaterialInstance();
			}
			if (!(uMaterialInstanceDynamic == null))
			{
				FLinearColor value = new FLinearColor(fMatrix.M11, fMatrix.M12, fMatrix.M13, 0.0);
				FLinearColor value2 = new FLinearColor(fMatrix.M21, fMatrix.M22, fMatrix.M23, 0.0);
				FLinearColor value3 = new FLinearColor(fMatrix.M31, fMatrix.M32, fMatrix.M33, 0.0);
				uMaterialInstanceDynamic.SetVectorParameterValue(B1GlobalFNames.Transform3x1, value);
				uMaterialInstanceDynamic.SetVectorParameterValue(B1GlobalFNames.Transform3x2, value2);
				uMaterialInstanceDynamic.SetVectorParameterValue(B1GlobalFNames.Transform3x3, value3);
			}
		}
	}
}

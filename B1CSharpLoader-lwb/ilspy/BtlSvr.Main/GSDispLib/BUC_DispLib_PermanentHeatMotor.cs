using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

public class BUC_DispLib_PermanentHeatMotor
{
	public FName EventName;

	public FName SocketName;

	public FVector SocketLocalOffset;

	public FVector SocketLocalRotation;

	public float Radius;

	public float TriggerProbability;

	public float MinIntensity;

	public float MaxIntensity;

	public float ScaleVelocityIntensity;

	public float DistanceDamplingRate;

	public DispLibDBCAxisMode RangeAxis;

	public float RangeMask;

	public DispLibDBCAxisMode VelocityDir;

	public bool isPause;

	public bool isUseing;

	public bool NeedCalBoneVelocity;

	public FVector LastFrameSocketPosWS;

	public FVector SizeV3;

	public BUC_DispLib_PermanentHeatMotor(BUC_DispLibDBC_Heat SourceStruct, UPrimitiveComponent MeshComp)
	{
		isPause = false;
		isUseing = true;
		EventName = SourceStruct.EventName;
		SocketName = SourceStruct.SocketName;
		SocketLocalOffset = SourceStruct.SocketLocalOffset;
		SocketLocalRotation = SourceStruct.SocketLocalRotation;
		Radius = SourceStruct.Radius;
		TriggerProbability = SourceStruct.TriggerProbability;
		MinIntensity = SourceStruct.MinIntensity;
		MaxIntensity = SourceStruct.MaxIntensity;
		DistanceDamplingRate = SourceStruct.DistanceDamplingRate;
		RangeAxis = SourceStruct.RangeAxis;
		RangeMask = SourceStruct.RangeMask;
		LastFrameSocketPosWS = MeshComp.GetSocketLocation(SocketName);
		NeedCalBoneVelocity = true;
		SizeV3 = new FVector(Radius, 0.0, 0.0);
	}
}

using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

public class BUC_DispLib_PermanentWindMotor
{
	private struct MyS
	{
		private int hhh;

		public MyS(int v)
		{
			hhh = v;
		}
	}

	public uint RequesterUniqueID;

	public FName EventName;

	public FName SocketName;

	public FVector SocketLocalOffset;

	public float Radius;

	public float BaseIntensity;

	public float ScaleVelocityIntensity;

	public float VelocityThreshold;

	public float DistanceDamplingRate;

	public DispLibDBCWindMotorMode WindMotorMode;

	public DispLibDBCAxisMode RangeAxis;

	public FVector RangeAxisLocalRotation;

	public float RangeMask;

	public DispLibDBCAxisMode VelocityDir;

	public FVector VelocityDirLocalRotation;

	public float ScaleSecondVelocity;

	public bool isPause;

	public FVector LastFrameSocketPosWS;

	public FVector SizeV3;

	public int MotorType;

	public BUC_DispLib_PermanentWindMotor(BUC_DispLibDBC_WEFMPermanentWind SourceStruct, UPrimitiveComponent MeshComp)
	{
		RequesterUniqueID = 0u;
		isPause = false;
		EventName = SourceStruct.EventName;
		SocketName = SourceStruct.SocketName;
		SocketLocalOffset = SourceStruct.SocketLocalOffset;
		RangeAxisLocalRotation = SourceStruct.RangeAxisLocalRotation;
		Radius = SourceStruct.Radius;
		VelocityThreshold = SourceStruct.VelocityThreshold;
		BaseIntensity = SourceStruct.BaseIntensity;
		ScaleVelocityIntensity = SourceStruct.ScaleVelocityIntensity;
		DistanceDamplingRate = SourceStruct.DistanceDamplingRate;
		WindMotorMode = SourceStruct.WindMotorMode;
		RangeAxis = SourceStruct.RangeAxis;
		RangeMask = SourceStruct.RangeMask;
		VelocityDir = SourceStruct.VelocityDir;
		VelocityDirLocalRotation = SourceStruct.VelocityDirLocalRotation;
		ScaleSecondVelocity = SourceStruct.ScaleSecondVelocity;
		LastFrameSocketPosWS = MeshComp.GetSocketLocation(SocketName);
		MotorType = (int)WindMotorMode;
		SizeV3 = new FVector(Radius, 0.0, 0.0);
	}
}

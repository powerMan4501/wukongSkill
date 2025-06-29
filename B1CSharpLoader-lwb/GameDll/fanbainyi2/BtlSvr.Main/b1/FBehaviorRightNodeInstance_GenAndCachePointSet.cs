using CommB1;
using Google.Protobuf;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class FBehaviorRightNodeInstance_GenAndCachePointSet : FBehaviorRightNodeInstance
{
	public override string NodeName => B1CalliopeDef.BehaviorNode.GenAndCachePointSet;

	public BehaviorCustom_GenAndCachePointSet CustomData { get; set; }

	protected override void PostCreate()
	{
		CustomData = new BehaviorCustom_GenAndCachePointSet();
		CustomData.MergeFrom(base.Node.NodeData);
	}

	protected override void TriggerInput(string InputPin)
	{
		PointsGenType genType = (PointsGenType)CustomData.GenType;
		PointsGenExtParam extParam = new PointsGenExtParam
		{
			EQSPath = CustomData.EqsPath,
			SceneItemTag = CustomData.SceneItemTag,
			Explode_DesiredNum = CustomData.ExplodeDesiredNum,
			Explode_LineTraceMaxLength = CustomData.ExplodeLineTraceMaxLength,
			Explode_TraceTypeQuery = (ETraceTypeQuery)CustomData.ExplodeTraceTypeQuery,
			Explode_PointMinBetween = CustomData.ExplodePointMinBetween,
			SocketName = new FName(CustomData.SocketName)
		};
		FFloatRangeBound lowerBound = default(FFloatRangeBound);
		FFloatRangeBound upperBound = default(FFloatRangeBound);
		lowerBound.Value = CustomData.ExplodeRangeDirXMin;
		lowerBound.Type = (ERangeBoundTypes)CustomData.ExplodeRangeDirXMinRangeType;
		upperBound.Value = CustomData.ExplodeRangeDirXMax;
		upperBound.Type = (ERangeBoundTypes)CustomData.ExplodeRangeDirXMaxRangeType;
		extParam.Explode_RangeDir_X = new FFloatRange(lowerBound, upperBound);
		lowerBound.Value = CustomData.ExplodeRangeDirYMin;
		lowerBound.Type = (ERangeBoundTypes)CustomData.ExplodeRangeDirYMinRangeType;
		upperBound.Value = CustomData.ExplodeRangeDirYMax;
		upperBound.Type = (ERangeBoundTypes)CustomData.ExplodeRangeDirYMax;
		extParam.Explode_RangeDir_Y = new FFloatRange(lowerBound, upperBound);
		lowerBound.Value = CustomData.ExplodeRangeDirZMin;
		lowerBound.Type = (ERangeBoundTypes)CustomData.ExplodeRangeDirZMinRangeType;
		upperBound.Value = CustomData.ExplodeRangeDirZMax;
		upperBound.Type = (ERangeBoundTypes)CustomData.ExplodeRangeDirZMaxRangeType;
		extParam.Explode_RangeDir_Z = new FFloatRange(lowerBound, upperBound);
		int registerId = CustomData.RegisterId;
		base.BUSEventCollection.Evt_CallPointsRegister.Invoke(registerId, genType, extParam);
	}
}

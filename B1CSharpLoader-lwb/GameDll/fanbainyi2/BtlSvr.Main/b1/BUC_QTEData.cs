using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_QTEData : IBUC_QTEData, IPersistentECSData
{
	private EntitySharedRef QTETargetRef;

	private int QTERunIndex;

	private float QTESecondSyncRunTime;

	private int QTEDescID;

	private FTransform QTEPlayerStartTransformInEnemySkel;

	private FTransform QTEPlayerStartTransformSelfRecord;

	private UAnimMontage QTEEnemyDoingMontage;

	public BUC_QTEData()
	{
		QTEReset();
	}

	public void QTEReset()
	{
		QTETargetRef = null;
		QTERunIndex = 0;
		QTEPlayerStartTransformSelfRecord = FTransform.Identity;
		QTEPlayerStartTransformInEnemySkel = FTransform.Identity;
		QTEEnemyDoingMontage = null;
		QTESecondSyncRunTime = 0f;
		QTEDescID = 0;
	}

	public override string ToString()
	{
		return "QTEData:" + $"QTETargetID:{QTETargetRef} QTERunIndex:{QTERunIndex} QTEPlayerStartTransformInEnemySkel:{QTEPlayerStartTransformInEnemySkel} QTEEnemyDoingMontage:{QTEEnemyDoingMontage} DescID:{QTEDescID}";
	}

	public void ResetRunIndex()
	{
		QTERunIndex = 0;
	}

	public void IncRunIndex()
	{
		QTERunIndex++;
	}

	public int GetRunIndex()
	{
		return QTERunIndex;
	}

	public void SetQTETarget(AActor Actor)
	{
		QTETargetRef = (Actor.IsNullOrDestroyed() ? null : new EntitySharedRef(Actor));
	}

	public AActor GetQTETarget()
	{
		return EntitySharedRefFuncLib.Actor(QTETargetRef);
	}

	public void IncQTESecondSyncRunTime(float DeltaTime)
	{
		QTESecondSyncRunTime += DeltaTime;
	}

	public float GetQTESecondSyncRunTime()
	{
		return QTESecondSyncRunTime;
	}

	public int GetQTEDescID()
	{
		return QTEDescID;
	}

	public void SetQTEDescID(int DescID)
	{
		QTEDescID = DescID;
	}

	public UAnimMontage GetQTEEnemyDoingMontage()
	{
		return QTEEnemyDoingMontage;
	}

	public void SetQTEEnemyDoingMontage(UAnimMontage AnimMontage)
	{
		QTEEnemyDoingMontage = AnimMontage;
	}

	public FTransform GetQTEPlayerStartTransformInEnemySkel()
	{
		return QTEPlayerStartTransformInEnemySkel;
	}

	public void SetQTEPlayerStartTransformInEnemySkel(FTransform TargetTransform)
	{
		QTEPlayerStartTransformInEnemySkel = TargetTransform;
	}

	public FTransform GetQTEPlayerStartTransformSelfRecord()
	{
		return QTEPlayerStartTransformSelfRecord;
	}

	public void SetQTEPlayerStartTransformSelfRecord(FTransform TargetTransform)
	{
		QTEPlayerStartTransformSelfRecord = TargetTransform;
	}
}

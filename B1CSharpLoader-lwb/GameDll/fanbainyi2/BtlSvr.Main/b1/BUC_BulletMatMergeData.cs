using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_BulletMatMergeData
{
	private TStrongObjectPtr<UMaterialParameterCollection> mMPC = new TStrongObjectPtr<UMaterialParameterCollection>();

	public bool OpenMatDataTrans;

	public FName MPCScaleVName;

	public FName MPCLocationVName;

	public bool IsMergeChild;

	public UMaterialParameterCollection MPC
	{
		get
		{
			return mMPC.Get();
		}
		set
		{
			mMPC.Set(value);
		}
	}

	public BUC_BulletMatMergeData()
	{
		OpenMatDataTrans = false;
		MPCScaleVName = default(FName);
		MPCLocationVName = default(FName);
		IsMergeChild = false;
	}
}

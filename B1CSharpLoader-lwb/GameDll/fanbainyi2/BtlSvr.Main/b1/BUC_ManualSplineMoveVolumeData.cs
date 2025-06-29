using UnrealEngine.Runtime;

namespace b1;

public class BUC_ManualSplineMoveVolumeData : b1.IBUC_ManualSplineMoveVolumeData
{
	private TStrongObjectPtr<BGWDataAsset_ManualSplineMoveAnimConfig> mForwardSplineAnimConfig = new TStrongObjectPtr<BGWDataAsset_ManualSplineMoveAnimConfig>();

	private TStrongObjectPtr<BGWDataAsset_ManualSplineMoveAnimConfig> mReverseSplineAnimConfig = new TStrongObjectPtr<BGWDataAsset_ManualSplineMoveAnimConfig>();

	public BGWDataAsset_ManualSplineMoveAnimConfig ForwardSplineAnimConfig
	{
		get
		{
			return mForwardSplineAnimConfig.Get();
		}
		set
		{
			mForwardSplineAnimConfig.Set(value);
		}
	}

	public BGWDataAsset_ManualSplineMoveAnimConfig ReverseSplineAnimConfig
	{
		get
		{
			return mReverseSplineAnimConfig.Get();
		}
		set
		{
			mReverseSplineAnimConfig.Set(value);
		}
	}
}

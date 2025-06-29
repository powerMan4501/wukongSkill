using System.Collections.Generic;
using BtlB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_ScarData
{
	private TStrongObjectPtr<UTextureRenderTarget2D> mTempRT = new TStrongObjectPtr<UTextureRenderTarget2D>();

	public Dictionary<EScarDecalTriggerType, FScarDecalBrushInfo> ScarDecalBrushInfoDict = new Dictionary<EScarDecalTriggerType, FScarDecalBrushInfo>();

	public UTextureRenderTarget2D TempRT
	{
		get
		{
			return mTempRT.Get();
		}
		set
		{
			mTempRT.Set(value);
		}
	}

	public void Init()
	{
		ScarDecalBrushInfoDict = new Dictionary<EScarDecalTriggerType, FScarDecalBrushInfo>
		{
			{
				EScarDecalTriggerType.Dcss,
				new FScarDecalBrushInfo(0, 6, 6)
			},
			{
				EScarDecalTriggerType.Other,
				new FScarDecalBrushInfo(6, 16, 6)
			}
		};
	}
}

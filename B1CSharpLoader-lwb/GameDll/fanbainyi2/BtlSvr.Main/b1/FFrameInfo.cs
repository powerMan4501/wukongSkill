using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

public class FFrameInfo : IDisposable
{
	private const int TimeOutFrameCount = 10;

	public int TotalCount { get; set; }

	public int ReturnCount { get; set; }

	public uint FrameIndex { get; set; }

	public int VisibleCount { get; set; }

	public List<FVector> VisiblePosList { get; } = new List<FVector>();

	public List<FVector> InvisiblePosList { get; } = new List<FVector>();

	public Dictionary<FTamerRef, int> TamerVisibilityDictionary { get; } = new Dictionary<FTamerRef, int>();

	public List<int> ReqIDList { get; } = new List<int>();

	public int FrameReturnInterval { get; set; }

	private bool bCreateByPool { get; set; }

	public FFrameInfo()
	{
		bCreateByPool = false;
	}

	public bool IsAllReturn()
	{
		return ReturnCount == TotalCount;
	}

	public bool IsTimeout(uint InCurrentFrameIndex)
	{
		if (InCurrentFrameIndex < FrameIndex)
		{
			if (InCurrentFrameIndex > 10)
			{
				return true;
			}
			return false;
		}
		return InCurrentFrameIndex - FrameIndex > 10;
	}

	public static FFrameInfo CreateByPool()
	{
		return new FFrameInfo
		{
			bCreateByPool = true
		};
	}

	public void Clean()
	{
		TotalCount = 0;
		FrameIndex = 0u;
		VisibleCount = 0;
		ReturnCount = 0;
		FrameReturnInterval = 0;
		VisiblePosList.Clear();
		InvisiblePosList.Clear();
		TamerVisibilityDictionary.Clear();
	}

	public void Dispose()
	{
		if (bCreateByPool)
		{
			FFrameInfoPool.Return(this);
		}
	}
}

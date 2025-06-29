using System;
using b1.EventDelDefine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGW_PlayGoMgr")]
public class BGW_PlayGoMgr : GameInstanceSystemBaseUObj
{
	private enum EPlayGoState
	{
		NotBegin,
		InPrologue,
		PrologueCompletedNotShowProgress,
		PrologueCompletedAndShowProgress,
		BroadcastDownloadFinish
	}

	private class FDummyDownloadInfo
	{
		private readonly long _totalSize;

		private long _downloadedSize;

		private long _speed;

		private readonly UObject _worldContext;

		private bool _isPause;

		private const long ConvertToBytes = 1073741824L;

		public FDummyDownloadInfo(UObject worldContext)
		{
			_totalSize = 200789721088L;
			_downloadedSize = 0L;
			_speed = 0L;
			_worldContext = worldContext;
			_isPause = false;
		}

		public void SetPause(bool InIsPause)
		{
			_isPause = InIsPause;
		}

		public void BeginDownload(float Speed)
		{
			_speed = (long)(Speed * 1.0737418E+09f);
			_downloadedSize = 21474836480L;
		}

		public void FinishDownload()
		{
			_downloadedSize = _totalSize;
			BGW_EventCollection.Get(_worldContext).Evt_PlayGoDownloadComplete();
		}

		public void SetSpeed(float InSpeed)
		{
			_speed = (long)(InSpeed * 1.0737418E+09f);
		}

		public void OnTick(float DeltaTime)
		{
			if (!IsDownloadFinish() && !_isPause)
			{
				_downloadedSize = FMath.Min(_totalSize, _downloadedSize + (long)((float)_speed * DeltaTime));
				if (IsDownloadFinish())
				{
					BGW_EventCollection.Get(_worldContext).Evt_PlayGoDownloadComplete();
				}
			}
		}

		public void FetchDownloadDetails(out long ProgressSize, out long TotalSize)
		{
			ProgressSize = _downloadedSize;
			TotalSize = _totalSize;
		}

		public bool IsDownloadFinish()
		{
			return FMath.IsNearlyEqual(_downloadedSize, _totalSize);
		}
	}

	private FDummyDownloadInfo _dummyDownloadInfo;

	private EPlayGoState _state;

	private FPlayGoDownloadDetails _downloadDetails;

	public override bool bTickEnabled => IsDownloadIncomplete();

	public static BGW_PlayGoMgr Get(UObject WorldContext)
	{
		return BGWGameInstanceCS.GetObject<BGW_PlayGoMgr>(WorldContext);
	}

	public override void OnInit()
	{
		_state = EPlayGoState.NotBegin;
		_downloadDetails = new FPlayGoDownloadDetails();
		if (DebugConfig.DebugPlayGo)
		{
			_dummyDownloadInfo = new FDummyDownloadInfo(this);
			_dummyDownloadInfo.BeginDownload(1f);
		}
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(this);
		bGW_EventCollection.Evt_GSLoginFinish = (Del_Void)Delegate.Combine(bGW_EventCollection.Evt_GSLoginFinish, new Del_Void(OnGSLoginFinish));
	}

	private void OnGSLoginFinish()
	{
		if (DebugConfig.DebugPlayGo || BGUFuncLibMap.GetPrologueLevelId(this) == BGUFuncLibMap.GetCurLevelId(this))
		{
			_state = EPlayGoState.InPrologue;
		}
	}

	public void TriggerPrologueCompleted()
	{
		if (_state == EPlayGoState.InPrologue)
		{
			_state = EPlayGoState.PrologueCompletedNotShowProgress;
		}
	}

	public void TriggerShowProgress()
	{
		if (_state == EPlayGoState.PrologueCompletedNotShowProgress)
		{
			_state = EPlayGoState.PrologueCompletedAndShowProgress;
		}
	}

	public bool IsPrologueCompletedNotShowProgress()
	{
		return _state == EPlayGoState.PrologueCompletedNotShowProgress;
	}

	public bool IsShowProgress()
	{
		return _state == EPlayGoState.PrologueCompletedAndShowProgress;
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (DebugConfig.DebugPlayGo)
		{
			_dummyDownloadInfo.OnTick(DeltaTime);
			_dummyDownloadInfo.FetchDownloadDetails(out var ProgressSize, out var TotalSize);
			_downloadDetails.Update(ProgressSize, TotalSize, DateTime.Now.TimeOfDay.TotalSeconds);
		}
		else if (_state != EPlayGoState.BroadcastDownloadFinish)
		{
			long ProgressSize2;
			long TotalSize2;
			double CurrentTime;
			if (!IsDownloadIncomplete())
			{
				BGW_EventCollection.Get(this).Evt_PlayGoDownloadComplete();
				_state = EPlayGoState.BroadcastDownloadFinish;
			}
			else if (UGSE_ChunkFuncLib.TryGetPlayGoInfo(out ProgressSize2, out TotalSize2, out CurrentTime))
			{
				_downloadDetails.Update(ProgressSize2, TotalSize2, CurrentTime);
			}
		}
	}

	public bool IsDownloadIncomplete()
	{
		if (DebugConfig.DebugPlayGo)
		{
			if (_dummyDownloadInfo != null)
			{
				return !_dummyDownloadInfo.IsDownloadFinish();
			}
			return true;
		}
		return UGSE_ChunkFuncLib.IsPlayGoInstalling();
	}

	public void FetchDownloadDetails(out FPlayGoDownloadDetails DownloadDetails)
	{
		DownloadDetails = _downloadDetails;
	}

	public void Pause()
	{
		_dummyDownloadInfo.SetPause(InIsPause: true);
	}

	public void Resume()
	{
		_dummyDownloadInfo.SetPause(InIsPause: false);
	}

	public void Begin()
	{
		_dummyDownloadInfo.BeginDownload(1f);
	}

	public void Finish()
	{
		_dummyDownloadInfo.FinishDownload();
	}

	public void SetSpeed(float Speed)
	{
		_dummyDownloadInfo.SetSpeed(Speed);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGW_PlayGoMgr");
	}

	static BGW_PlayGoMgr()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGW_PlayGoMgr)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGW_PlayGoMgr));
	}
}

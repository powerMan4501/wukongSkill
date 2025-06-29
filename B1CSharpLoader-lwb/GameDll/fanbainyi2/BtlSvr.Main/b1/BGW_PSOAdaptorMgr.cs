using System;
using System.Diagnostics;
using System.Linq;
using System.Text;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGW_PSOAdaptorMgr")]
public class BGW_PSOAdaptorMgr : GameInstanceSystemBaseUObj
{
	private struct FPSOFullCompilationTracker
	{
		private int _remaining;

		private int _total;

		public float CompiledPercent;

		public bool UpdateAndCheckIsFinished()
		{
			Update();
			return IsFinished();
		}

		private void Update()
		{
			_remaining = UGSE_EngineFuncLib.GetRemainingPsoPrecompileNum();
			_total = UGSE_EngineFuncLib.GetTotalPsoPrecompileNum();
			if (_remaining == 0 || _total == 0)
			{
				CompiledPercent = 1f;
				return;
			}
			float num = (float)_remaining / (float)_total;
			CompiledPercent = 1f - num;
		}

		private bool IsFinished()
		{
			if (_remaining > 0)
			{
				return _total <= 0;
			}
			return true;
		}
	}

	private FPSOFullCompilationTracker _tracker;

	private const string LockFilePath = "/Temp/pso.lock";

	private const string ProgrammerJoke = "Why do programmers perfer dark mode?\nBecause light attracts bugs!";

	private int _ticker;

	private const int UpdateFrequencyTick = 2;

	private float _timer;

	private const float UpdateFrequencyDuration = 0.5f;

	public EFullCompilationState State { get; private set; }

	public override bool bTickEnabled => EnableTick();

	public static BGW_PSOAdaptorMgr Get(UObject WorldCtx)
	{
		return BGWGameInstanceCS.GetObject<BGW_PSOAdaptorMgr>(WorldCtx);
	}

	private bool IsLock()
	{
		return UGSFileHelper.FileExists("/Temp/pso.lock");
	}

	private void Lock()
	{
		if (IsLock())
		{
			LogInfo("already locked, but not matter.");
			return;
		}
		bool flag = UGSFileHelper.WriteFile("/Temp/pso.lock", Encoding.UTF8.GetBytes("Why do programmers perfer dark mode?\nBecause light attracts bugs!").ToList());
		LogInfo(flag ? "lock succeed!" : "lock failed!");
	}

	private void Unlock()
	{
		bool flag = UGSFileHelper.DeleteFile("/Temp/pso.lock");
		LogInfo(flag ? "Unlock succeed!" : "unlock failed");
	}

	public override void OnInit()
	{
		State = EFullCompilationState.NotBegin;
		if (BGW_LocalDevEnvUtils.GetBuildBranch() == "b1_release")
		{
			IConsoleManager.Get().FindConsoleVariable("r.ShaderPipelineCache.HttpAddressHeader")?.Set("http://uecrash.gs.com:8000/pso_cache/report?branch=b1_release&cache_content=");
		}
	}

	public bool IsEnableCompile()
	{
		if (!DebugConfig.IsNeedPsoPrecompileWhenStartGame)
		{
			return false;
		}
		return UGSE_EngineFuncLib.IsDriverVersionMismatch();
	}

	public void BeginFullCompilation()
	{
		GSEUtil.Check(State == EFullCompilationState.NotBegin);
		if (!IsEnableCompile())
		{
			if (IsLock())
			{
				Unlock();
			}
			ChangeCurrentStateTo(EFullCompilationState.Finish);
		}
		else
		{
			BGW_UIEventCollection.Get(this).Evt_UI_ShowShaderCompiling();
			if (IsLock())
			{
				ChangeCurrentStateTo(EFullCompilationState.WaitUserConfirm);
			}
			else
			{
				BeginCompilationImpl();
			}
		}
	}

	private void BeginCompilationImpl()
	{
		UGSE_EngineFuncLib.PSOFullCompilation();
		if (_tracker.UpdateAndCheckIsFinished())
		{
			ChangeCurrentStateTo(EFullCompilationState.Finish);
			return;
		}
		Lock();
		ChangeCurrentStateTo(EFullCompilationState.Compiling);
	}

	public void ConfirmCompilation()
	{
		GSEUtil.Ensure(State == EFullCompilationState.WaitUserConfirm);
		BeginCompilationImpl();
	}

	public void CancelCompilation()
	{
		GSEUtil.Ensure(State == EFullCompilationState.WaitUserConfirm);
		ChangeCurrentStateTo(EFullCompilationState.Finish);
	}

	public float GetCurrentCompliedPercent()
	{
		return FMath.Clamp(_tracker.CompiledPercent, 0f, 1f);
	}

	public void BeginSaveCacheFile()
	{
		GSEUtil.Ensure(State == EFullCompilationState.WaitingAnimationStop);
		UGSE_EngineFuncLib.SavePSOCacheFile();
		ChangeCurrentStateTo(EFullCompilationState.SaveCacheFile);
	}

	public void QuitGame()
	{
		GSEUtil.Ensure(State == EFullCompilationState.WaitUserCheckDiskSize);
		UGSE_EngineFuncLib.QuitGame(this);
	}

	public void ContinueToPlay()
	{
		GSEUtil.Ensure(State == EFullCompilationState.WaitUserCheckDiskSize);
		ChangeCurrentStateTo(EFullCompilationState.Finish);
	}

	public void OpenFAQ()
	{
		GSEUtil.Ensure(State == EFullCompilationState.WaitUserConfirm || State == EFullCompilationState.WaitUserCheckDiskSize);
		Process.Start(DebugConfig.FAQWebsiteLink);
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public bool EnableTick()
	{
		if (State == EFullCompilationState.Finish)
		{
			return State != EFullCompilationState.NotBegin;
		}
		return true;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (!EnableTick() || !CheckCanUpdate())
		{
			return;
		}
		if (State == EFullCompilationState.Compiling)
		{
			if (_tracker.UpdateAndCheckIsFinished())
			{
				Unlock();
				ChangeCurrentStateTo(EFullCompilationState.WaitingAnimationStop);
			}
		}
		else if (State == EFullCompilationState.SaveCacheFile)
		{
			ChangeCurrentStateTo(EFullCompilationState.ClearMemory);
		}
		else if (State == EFullCompilationState.ClearMemory)
		{
			UGSE_EngineFuncLib.SetPSOCacheUsageMask(0, -1, -1, -1);
			ChangeCurrentStateTo(EFullCompilationState.WaitClearMemoryFinish);
		}
		else if (State == EFullCompilationState.WaitClearMemoryFinish && UGSE_EngineFuncLib.IsUnloadPSOFinished())
		{
			if (!UGSE_EngineFuncLib.IsSavePSOCacheInErrorState())
			{
				ChangeCurrentStateTo(EFullCompilationState.Finish);
			}
			else
			{
				ChangeCurrentStateTo(EFullCompilationState.WaitUserCheckDiskSize);
			}
		}
		bool CheckCanUpdate()
		{
			if (_timer >= 0.5f && _ticker >= 2)
			{
				_ticker = 0;
				_timer = 0f;
				return true;
			}
			_timer += DeltaTime;
			_ticker++;
			return false;
		}
	}

	private void ChangeCurrentStateTo(EFullCompilationState NewState)
	{
		LogInfo($"Try to change state from {State} to {NewState}");
		if (NewState > State)
		{
			EFullCompilationState state = State;
			State = NewState;
			BGW_EventCollection.Get(this).Evt_PostPSOStateChanged(state, NewState);
		}
	}

	private void LogInfo(string Msg)
	{
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGW_PSOAdaptorMgr");
	}

	static BGW_PSOAdaptorMgr()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGW_PSOAdaptorMgr)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGW_PSOAdaptorMgr));
	}
}

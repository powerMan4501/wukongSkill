using System;
using b1;
using b1.BGW;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

public class BWS_DispLibEnvInteractiveSystem : BWS_DispLibCompBase
{
	private static BWS_DispLibEnvInteractiveSystem Instance;

	private BWS_EnvInteractiveCapture InteractiveCapture;

	private const string BP_ENV_VECTOR_CAPTURE_PATH = "/Game/01_U3Main/BPLibrary/BP_EnvInteractiveCapture.BP_EnvInteractiveCapture_C";

	public static bool IsEnable;

	private float UpdateInterval = 0.01f;

	private float UpdateTimer;

	public static BWS_DispLibEnvInteractiveSystem GetInstance()
	{
		return Instance;
	}

	public override void OnBeginPlay()
	{
		base.OnBeginPlay();
		Instance = this;
		if (IsEnable)
		{
			AActor owner = GetOwner();
			UClass uClass = BGW_PreloadAssetMgr.Get(owner).TryGetCachedResourceObj<UClass>("/Game/01_U3Main/BPLibrary/BP_EnvInteractiveCapture.BP_EnvInteractiveCapture_C", ELoadResourceType.SyncLoadAndCache);
			if (uClass != null)
			{
				InteractiveCapture = BGU_UnrealWorldUtil.SpawnActorAndECSBeginPlay(UBGUFunctionLibraryForCS.BGUGetUWorld(owner), uClass, in FVector.ZeroVector, in FRotator.ZeroRotator) as BWS_EnvInteractiveCapture;
				InteractiveCapture.Init();
			}
			else
			{
				BGW_LogUtil.LogError("BWS_DispEnvInteractiveSystem Spawn faild/Game/01_U3Main/BPLibrary/BP_EnvInteractiveCapture.BP_EnvInteractiveCapture_C");
			}
			BWS_DispLibEventCollection bWSDispLibEventCollection = base.BWSDispLibEventCollection;
			bWSDispLibEventCollection.Env_RequestScenePhysicalInteractorEvent = (BWS_DispLibEventCollection.Del_Void_ActorTwoIntThreeFloat)Delegate.Combine(bWSDispLibEventCollection.Env_RequestScenePhysicalInteractorEvent, new BWS_DispLibEventCollection.Del_Void_ActorTwoIntThreeFloat(OnEvnInteractorEvent));
		}
	}

	public int AddInteractor(UPrimitiveComponent PrimComp, int EventType, FVector Size, float Intensity, float Interval)
	{
		if (!IsEnable)
		{
			return -1;
		}
		if (PrimComp != null && InteractiveCapture != null)
		{
			return InteractiveCapture.AddInteractor(PrimComp, EventType, Size, Intensity, Interval);
		}
		return -1;
	}

	public void RemoveInteractor(int InteractorID)
	{
		if (IsEnable && InteractiveCapture != null)
		{
			InteractiveCapture.RemoveInteractor(InteractorID);
		}
	}

	public void SetInteractorCapturerEnabled(bool Enabled)
	{
		if (InteractiveCapture != null)
		{
			InteractiveCapture.SetCapturingEnabled(Enabled);
		}
	}

	public void OnEvnInteractorEvent(AActor Actor, FVector Size, int EventType, int IntensityLevel, float Intensity, float Duration, float Delay)
	{
		if (IsEnable && InteractiveCapture != null)
		{
			InteractiveCapture.TriggerOnce(Actor.GetActorLocation(), Size, EventType, Intensity, Duration);
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (IsEnable && InteractiveCapture != null)
		{
			UpdateTimer -= DeltaTime;
			if (UpdateTimer < 0f)
			{
				UpdateTimer = UpdateInterval;
				InteractiveCapture.OnTickCapture();
			}
		}
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		BWS_DispLibEventCollection bWSDispLibEventCollection = base.BWSDispLibEventCollection;
		bWSDispLibEventCollection.Env_RequestScenePhysicalInteractorEvent = (BWS_DispLibEventCollection.Del_Void_ActorTwoIntThreeFloat)Delegate.Remove(bWSDispLibEventCollection.Env_RequestScenePhysicalInteractorEvent, new BWS_DispLibEventCollection.Del_Void_ActorTwoIntThreeFloat(OnEvnInteractorEvent));
		Instance = null;
	}

	public void EnableDebug()
	{
		if (InteractiveCapture != null)
		{
			InteractiveCapture.OnEnableDebug();
		}
	}
}

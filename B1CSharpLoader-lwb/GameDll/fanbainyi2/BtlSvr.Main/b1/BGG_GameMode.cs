using System;
using System.Collections.Generic;
using b1.ECS;
using GSDispLib;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGG_GameMode")]
public abstract class BGG_GameMode : ABGWGameMode, IECSWorldObj
{
	protected Entity mECSEntity;

	protected Chunk mECSChunk;

	protected int mECSIndexInChunk;

	private ChoosePlayerStartInput ChoosePlayerStartInput;

	private static bool DataComp_IsValid;

	private static int DataComp_Offset;

	private static bool ActorCompContainerCS_IsValid;

	private static int ActorCompContainerCS_Offset;

	private static bool PlayerAllocNum_IsValid;

	private static int PlayerAllocNum_Offset;

	private static bool EventCollection_IsValid;

	private static int EventCollection_Offset;

	private static bool StartPlayCS_IsValid;

	private static IntPtr StartPlayCS_FunctionAddress;

	private static int StartPlayCS_ParamsSize;

	private static bool ChoosePlayerStart_IsValid;

	private static IntPtr ChoosePlayerStart_FunctionAddress;

	private static int ChoosePlayerStart_ParamsSize;

	private static bool ChoosePlayerStart_Player_IsValid;

	private static int ChoosePlayerStart_Player_Offset;

	private static bool ChoosePlayerStart_ReturnValue_IsValid;

	private static int ChoosePlayerStart_ReturnValue_Offset;

	private static bool PostSeamlessTravelCS_IsValid;

	private static IntPtr PostSeamlessTravelCS_FunctionAddress;

	private static int PostSeamlessTravelCS_ParamsSize;

	private static bool GetSeamlessTravelActorListCS_IsValid;

	private static IntPtr GetSeamlessTravelActorListCS_FunctionAddress;

	private static int GetSeamlessTravelActorListCS_ParamsSize;

	private static bool GetSeamlessTravelActorListCS_bToTransition_IsValid;

	private static int GetSeamlessTravelActorListCS_bToTransition_Offset;

	private static FFieldAddress GetSeamlessTravelActorListCS_bToTransition_PropertyAddress;

	private static bool GetSeamlessTravelActorListCS_ActorList_IsValid;

	private static int GetSeamlessTravelActorListCS_ActorList_Offset;

	private static FFieldAddress GetSeamlessTravelActorListCS_ActorList_PropertyAddress;

	public Entity ECSEntity
	{
		get
		{
			return mECSEntity;
		}
		set
		{
			mECSEntity = value;
		}
	}

	public Chunk ECSChunk
	{
		get
		{
			return mECSChunk;
		}
		set
		{
			mECSChunk = value;
		}
	}

	public int ECSIndexInChunk
	{
		get
		{
			return mECSIndexInChunk;
		}
		set
		{
			mECSIndexInChunk = value;
		}
	}

	[UProperty(Flags = PropFlags.Transient)]
	[USharpPath("/Script/b1-Managed.BGG_GameMode:DataComp")]
	public UActorDataContainer DataComp
	{
		get
		{
			CheckDestroyed();
			if (!DataComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGG_GameMode:DataComp");
				return null;
			}
			return UObjectMarshaler<UActorDataContainer>.FromNative(IntPtr.Add(base.Address, DataComp_Offset));
		}
		protected set
		{
			CheckDestroyed();
			if (!DataComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGG_GameMode:DataComp");
			}
			else
			{
				UObjectMarshaler<UActorDataContainer>.ToNative(IntPtr.Add(base.Address, DataComp_Offset), value);
			}
		}
	}

	[UProperty(Flags = PropFlags.Transient)]
	[USharpPath("/Script/b1-Managed.BGG_GameMode:ActorCompContainerCS")]
	public UActorCompContainerCS ActorCompContainerCS
	{
		get
		{
			CheckDestroyed();
			if (!ActorCompContainerCS_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGG_GameMode:ActorCompContainerCS");
				return null;
			}
			return UObjectMarshaler<UActorCompContainerCS>.FromNative(IntPtr.Add(base.Address, ActorCompContainerCS_Offset));
		}
		protected set
		{
			CheckDestroyed();
			if (!ActorCompContainerCS_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGG_GameMode:ActorCompContainerCS");
			}
			else
			{
				UObjectMarshaler<UActorCompContainerCS>.ToNative(IntPtr.Add(base.Address, ActorCompContainerCS_Offset), value);
			}
		}
	}

	[UProperty(Flags = PropFlags.Transient)]
	[USharpPath("/Script/b1-Managed.BGG_GameMode:PlayerAllocNum")]
	protected int PlayerAllocNum
	{
		get
		{
			CheckDestroyed();
			if (!PlayerAllocNum_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGG_GameMode:PlayerAllocNum");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, PlayerAllocNum_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PlayerAllocNum_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGG_GameMode:PlayerAllocNum");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, PlayerAllocNum_Offset), value);
			}
		}
	}

	[UProperty(Flags = PropFlags.Transient)]
	[USharpPath("/Script/b1-Managed.BGG_GameMode:EventCollection")]
	private BGS_GSEventCollection EventCollection
	{
		get
		{
			CheckDestroyed();
			if (!EventCollection_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGG_GameMode:EventCollection");
				return null;
			}
			return UObjectMarshaler<BGS_GSEventCollection>.FromNative(IntPtr.Add(base.Address, EventCollection_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EventCollection_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGG_GameMode:EventCollection");
			}
			else
			{
				UObjectMarshaler<BGS_GSEventCollection>.ToNative(IntPtr.Add(base.Address, EventCollection_Offset), value);
			}
		}
	}

	public int ECSArcheType => 1;

	public object GetDataByChunk(int TypeIndex)
	{
		return BGU_DataUtil.GetDataByEntityChunk(TypeIndex, mECSEntity, mECSChunk, mECSIndexInChunk);
	}

	[USharpPath("/Script/b1-Managed.BGG_GameMode:PostSeamlessTravelCS")]
	protected override void PostSeamlessTravelCS_Implementation()
	{
		base.PostSeamlessTravelCS_Implementation();
		UGSE_WorldFuncLib.NotifyWorldSettingsBeginPlay(base.World);
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		ActorCompContainerCS = initializer.CreateDefaultSubobject<UActorCompContainerCS>(this, B1GlobalFNames.ActorCompContainerCS);
		PlayerAllocNum = 0;
		CreateDataContainer(initializer);
	}

	[USharpPath("/Script/b1-Managed.BGG_GameMode:GetSeamlessTravelActorListCS")]
	protected override void GetSeamlessTravelActorListCS_Implementation(bool bToTransition, out List<AActor> ActorList)
	{
		base.GetSeamlessTravelActorListCS_Implementation(bToTransition, out ActorList);
		ActorList.Add(DispLibDispWorld.GetInstance(this));
	}

	protected abstract void CreateDataContainer(FObjectInitializer initializer);

	public object GetEventCollection()
	{
		if (EventCollection == null)
		{
			EventCollection = (UGameplayStatics.GetGameState(this) as BGGGameStateCS)?.GameEventCollection;
		}
		return EventCollection;
	}

	public virtual void InitAllComp()
	{
	}

	protected AActor ChoosePlayerStartV2(AController Player)
	{
		APlayerStart[] allActorsOfClass = base.World.GetAllActorsOfClass<APlayerStart>();
		FChoosePlayerStartInfo fChoosePlayerStartInfo = BGW_EventCollection.Get(this).Evt_ChoosePlayerStart();
		if (fChoosePlayerStartInfo.UseDefaultPos)
		{
			if (DebugConfig.Debug820Demo)
			{
				FDemo820LevelInfo curLevelInfo = BGW_820DemoPlayTimeMgr.Get(this).GetCurLevelInfo();
				FVector Loc = curLevelInfo.DefaultPos;
				FRotator Rot = curLevelInfo.DefaultRot;
				return GSSpawnPlayerStart(ref Loc, ref Rot);
			}
			if (allActorsOfClass.Length != 0)
			{
				APlayerStart result = allActorsOfClass[PlayerAllocNum % allActorsOfClass.Length];
				PlayerAllocNum++;
				return result;
			}
			return null;
		}
		FVector Loc2 = fChoosePlayerStartInfo.PlayerTransform.GetLocation();
		FRotator Rot2 = fChoosePlayerStartInfo.PlayerTransform.Rotation.Rotator();
		return GSSpawnPlayerStart(ref Loc2, ref Rot2);
	}

	[USharpPath("/Script/b1-Managed.BGG_GameMode:ChoosePlayerStart")]
	protected override AActor ChoosePlayerStart_Implementation(AController Player)
	{
		return ChoosePlayerStartV2(Player);
	}

	private ABGUPlayerStart GSSpawnPlayerStart(ref FVector Loc, ref FRotator Rot)
	{
		return base.World.SpawnActor<ABGUPlayerStart>(ref Loc, ref Rot);
	}

	private ABGUPlayerStart GSSpawnPlayerStart(AActor TargetActor)
	{
		FVector location = TargetActor.GetActorLocation();
		FRotator rotation = TargetActor.GetActorRotation();
		return base.World.SpawnActor<ABGUPlayerStart>(ref location, ref rotation);
	}

	private ABGUPlayerStart GSSpawnPlayerStart(FTransform TargetTransform)
	{
		FVector location = TargetTransform.GetLocation();
		FRotator rotation = TargetTransform.GetRotation().Rotator();
		return base.World.SpawnActor<ABGUPlayerStart>(ref location, ref rotation);
	}

	public virtual void AfterInitAllComp()
	{
	}

	public void SetChoosePlayerStartInput(ChoosePlayerStartInput ChoosePlayerStartInput)
	{
		this.ChoosePlayerStartInput = ChoosePlayerStartInput;
	}

	[USharpPath("/Script/b1-Managed.BGG_GameMode:StartPlayCS")]
	protected override void StartPlayCS_Implementation()
	{
		if (IsMovieRendering())
		{
			B1Global.GIsMovieRendering = true;
			DebugConfig.OnlyOpenPVUI = true;
		}
	}

	public bool IsBeginPlayFinished()
	{
		return ActorCompContainerCS.HasLateBeginPlay;
	}

	[UFunctionInvoker("/Script/b1-Managed.BGG_GameMode:StartPlayCS")]
	private static void StartPlayCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGG_GameMode bGG_GameMode = GCHelper.Find<BGG_GameMode>(obj);
		bGG_GameMode.StartPlayCS_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGG_GameMode:ChoosePlayerStart")]
	private static void ChoosePlayerStart__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGG_GameMode bGG_GameMode = GCHelper.Find<BGG_GameMode>(obj);
		AController player = UObjectMarshaler<AController>.FromNative(IntPtr.Add(buffer, ChoosePlayerStart_Player_Offset));
		AActor value = bGG_GameMode.ChoosePlayerStart_Implementation(player);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(buffer, ChoosePlayerStart_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGG_GameMode:PostSeamlessTravelCS")]
	private static void PostSeamlessTravelCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGG_GameMode bGG_GameMode = GCHelper.Find<BGG_GameMode>(obj);
		bGG_GameMode.PostSeamlessTravelCS_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGG_GameMode:GetSeamlessTravelActorListCS")]
	private static void GetSeamlessTravelActorListCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGG_GameMode bGG_GameMode = GCHelper.Find<BGG_GameMode>(obj);
		bool bToTransition = BoolMarshaler.FromNative(IntPtr.Add(buffer, GetSeamlessTravelActorListCS_bToTransition_Offset), 0, GetSeamlessTravelActorListCS_bToTransition_PropertyAddress.Address);
		TArrayCopyMarshaler<AActor> tArrayCopyMarshaler = new TArrayCopyMarshaler<AActor>(1, GetSeamlessTravelActorListCS_ActorList_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative);
		List<AActor> ActorList = tArrayCopyMarshaler.FromNative(IntPtr.Add(buffer, GetSeamlessTravelActorListCS_ActorList_Offset));
		bGG_GameMode.GetSeamlessTravelActorListCS_Implementation(bToTransition, out ActorList);
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, GetSeamlessTravelActorListCS_ActorList_Offset), ActorList);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGG_GameMode");
		DataComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "DataComp");
		DataComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DataComp", Classes.FObjectProperty);
		ActorCompContainerCS_Offset = NativeReflection.GetPropertyOffset(intPtr, "ActorCompContainerCS");
		ActorCompContainerCS_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ActorCompContainerCS", Classes.FObjectProperty);
		PlayerAllocNum_Offset = NativeReflection.GetPropertyOffset(intPtr, "PlayerAllocNum");
		PlayerAllocNum_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PlayerAllocNum", Classes.FIntProperty);
		EventCollection_Offset = NativeReflection.GetPropertyOffset(intPtr, "EventCollection");
		EventCollection_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EventCollection", Classes.FObjectProperty);
		StartPlayCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "StartPlayCS");
		StartPlayCS_ParamsSize = NativeReflection.GetFunctionParamsSize(StartPlayCS_FunctionAddress);
		StartPlayCS_IsValid = StartPlayCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGG_GameMode:StartPlayCS", StartPlayCS_IsValid);
		ChoosePlayerStart_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ChoosePlayerStart");
		ChoosePlayerStart_ParamsSize = NativeReflection.GetFunctionParamsSize(ChoosePlayerStart_FunctionAddress);
		ChoosePlayerStart_Player_Offset = NativeReflection.GetPropertyOffset(ChoosePlayerStart_FunctionAddress, "Player");
		ChoosePlayerStart_Player_IsValid = NativeReflection.ValidatePropertyClass(ChoosePlayerStart_FunctionAddress, "Player", Classes.FObjectProperty);
		ChoosePlayerStart_ReturnValue_Offset = NativeReflection.GetPropertyOffset(ChoosePlayerStart_FunctionAddress, "ReturnValue");
		ChoosePlayerStart_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(ChoosePlayerStart_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		ChoosePlayerStart_IsValid = ChoosePlayerStart_FunctionAddress != IntPtr.Zero && ChoosePlayerStart_Player_IsValid && ChoosePlayerStart_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGG_GameMode:ChoosePlayerStart", ChoosePlayerStart_IsValid);
		PostSeamlessTravelCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PostSeamlessTravelCS");
		PostSeamlessTravelCS_ParamsSize = NativeReflection.GetFunctionParamsSize(PostSeamlessTravelCS_FunctionAddress);
		PostSeamlessTravelCS_IsValid = PostSeamlessTravelCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGG_GameMode:PostSeamlessTravelCS", PostSeamlessTravelCS_IsValid);
		GetSeamlessTravelActorListCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSeamlessTravelActorListCS");
		GetSeamlessTravelActorListCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSeamlessTravelActorListCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetSeamlessTravelActorListCS_bToTransition_PropertyAddress, GetSeamlessTravelActorListCS_FunctionAddress, "bToTransition");
		GetSeamlessTravelActorListCS_bToTransition_Offset = NativeReflection.GetPropertyOffset(GetSeamlessTravelActorListCS_FunctionAddress, "bToTransition");
		GetSeamlessTravelActorListCS_bToTransition_IsValid = NativeReflection.ValidatePropertyClass(GetSeamlessTravelActorListCS_FunctionAddress, "bToTransition", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref GetSeamlessTravelActorListCS_ActorList_PropertyAddress, GetSeamlessTravelActorListCS_FunctionAddress, "ActorList");
		GetSeamlessTravelActorListCS_ActorList_Offset = NativeReflection.GetPropertyOffset(GetSeamlessTravelActorListCS_FunctionAddress, "ActorList");
		GetSeamlessTravelActorListCS_ActorList_IsValid = NativeReflection.ValidatePropertyClass(GetSeamlessTravelActorListCS_FunctionAddress, "ActorList", Classes.FArrayProperty);
		GetSeamlessTravelActorListCS_IsValid = GetSeamlessTravelActorListCS_FunctionAddress != IntPtr.Zero && GetSeamlessTravelActorListCS_bToTransition_IsValid && GetSeamlessTravelActorListCS_ActorList_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGG_GameMode:GetSeamlessTravelActorListCS", GetSeamlessTravelActorListCS_IsValid);
	}

	static BGG_GameMode()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGG_GameMode)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGG_GameMode));
	}
}

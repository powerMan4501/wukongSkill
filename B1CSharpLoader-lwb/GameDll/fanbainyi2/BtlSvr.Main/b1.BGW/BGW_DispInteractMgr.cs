using System;
using UnrealEngine.Engine;
using UnrealEngine.Landscape;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace b1.BGW;

[UClass]
[USharpPath("/Script/b1-Managed.BGW_DispInteractMgr")]
public class BGW_DispInteractMgr : GameInstanceSystemBaseUObj
{
	public bool EnableDispInteract;

	private static string path;

	private bool bDelayCallDispInteractOwnerUpdate;

	private static bool DispInteractOwner_IsValid;

	private static int DispInteractOwner_Offset;

	private static bool LandScape_IsValid;

	private static int LandScape_Offset;

	private static bool LS_HeightMap_IsValid;

	private static int LS_HeightMap_Offset;

	private static bool LS_WeightMap_IsValid;

	private static int LS_WeightMap_Offset;

	private static bool LandscapeOriginOffset_IsValid;

	private static int LandscapeOriginOffset_Offset;

	private static bool LS_MinX_IsValid;

	private static int LS_MinX_Offset;

	private static bool LS_MinY_IsValid;

	private static int LS_MinY_Offset;

	private static bool LS_MaxX_IsValid;

	private static int LS_MaxX_Offset;

	private static bool LS_MaxY_IsValid;

	private static int LS_MaxY_Offset;

	private static bool MaxHeight_IsValid;

	private static int MaxHeight_Offset;

	private static bool SimulationSize_cm_IsValid;

	private static int SimulationSize_cm_Offset;

	private static bool InteractiveData_StorageSize_cm_IsValid;

	private static int InteractiveData_StorageSize_cm_Offset;

	private static bool InteractDistLimitToDispActor_IsValid;

	private static int InteractDistLimitToDispActor_Offset;

	private static bool NS_Landscape_Interactive_IsValid;

	private static int NS_Landscape_Interactive_Offset;

	private static bool NS_Landscape_Simulator_IsValid;

	private static int NS_Landscape_Simulator_Offset;

	public override bool bTickEnabled => true;

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_DispInteractMgr:DispInteractOwner")]
	public BGUDispInteractActor DispInteractOwner
	{
		get
		{
			CheckDestroyed();
			if (!DispInteractOwner_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispInteractMgr:DispInteractOwner");
				return null;
			}
			return UObjectMarshaler<BGUDispInteractActor>.FromNative(IntPtr.Add(base.Address, DispInteractOwner_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DispInteractOwner_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispInteractMgr:DispInteractOwner");
			}
			else
			{
				UObjectMarshaler<BGUDispInteractActor>.ToNative(IntPtr.Add(base.Address, DispInteractOwner_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_DispInteractMgr:LandScape")]
	public ALandscape LandScape
	{
		get
		{
			CheckDestroyed();
			if (!LandScape_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispInteractMgr:LandScape");
				return null;
			}
			return UObjectMarshaler<ALandscape>.FromNative(IntPtr.Add(base.Address, LandScape_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LandScape_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispInteractMgr:LandScape");
			}
			else
			{
				UObjectMarshaler<ALandscape>.ToNative(IntPtr.Add(base.Address, LandScape_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_DispInteractMgr:LS_HeightMap")]
	public UTexture2D LS_HeightMap
	{
		get
		{
			CheckDestroyed();
			if (!LS_HeightMap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispInteractMgr:LS_HeightMap");
				return null;
			}
			return UObjectMarshaler<UTexture2D>.FromNative(IntPtr.Add(base.Address, LS_HeightMap_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LS_HeightMap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispInteractMgr:LS_HeightMap");
			}
			else
			{
				UObjectMarshaler<UTexture2D>.ToNative(IntPtr.Add(base.Address, LS_HeightMap_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_DispInteractMgr:LS_WeightMap")]
	public UTexture2D LS_WeightMap
	{
		get
		{
			CheckDestroyed();
			if (!LS_WeightMap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispInteractMgr:LS_WeightMap");
				return null;
			}
			return UObjectMarshaler<UTexture2D>.FromNative(IntPtr.Add(base.Address, LS_WeightMap_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LS_WeightMap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispInteractMgr:LS_WeightMap");
			}
			else
			{
				UObjectMarshaler<UTexture2D>.ToNative(IntPtr.Add(base.Address, LS_WeightMap_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_DispInteractMgr:LandscapeOriginOffset")]
	public FVector LandscapeOriginOffset
	{
		get
		{
			CheckDestroyed();
			if (!LandscapeOriginOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispInteractMgr:LandscapeOriginOffset");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, LandscapeOriginOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LandscapeOriginOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispInteractMgr:LandscapeOriginOffset");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, LandscapeOriginOffset_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_DispInteractMgr:LS_MinX")]
	public int LS_MinX
	{
		get
		{
			CheckDestroyed();
			if (!LS_MinX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispInteractMgr:LS_MinX");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, LS_MinX_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LS_MinX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispInteractMgr:LS_MinX");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, LS_MinX_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_DispInteractMgr:LS_MinY")]
	public int LS_MinY
	{
		get
		{
			CheckDestroyed();
			if (!LS_MinY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispInteractMgr:LS_MinY");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, LS_MinY_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LS_MinY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispInteractMgr:LS_MinY");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, LS_MinY_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_DispInteractMgr:LS_MaxX")]
	public int LS_MaxX
	{
		get
		{
			CheckDestroyed();
			if (!LS_MaxX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispInteractMgr:LS_MaxX");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, LS_MaxX_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LS_MaxX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispInteractMgr:LS_MaxX");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, LS_MaxX_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_DispInteractMgr:LS_MaxY")]
	public int LS_MaxY
	{
		get
		{
			CheckDestroyed();
			if (!LS_MaxY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispInteractMgr:LS_MaxY");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, LS_MaxY_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LS_MaxY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispInteractMgr:LS_MaxY");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, LS_MaxY_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_DispInteractMgr:MaxHeight")]
	public float MaxHeight
	{
		get
		{
			CheckDestroyed();
			if (!MaxHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispInteractMgr:MaxHeight");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxHeight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispInteractMgr:MaxHeight");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaxHeight_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_DispInteractMgr:SimulationSize_cm")]
	public float SimulationSize_cm
	{
		get
		{
			CheckDestroyed();
			if (!SimulationSize_cm_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispInteractMgr:SimulationSize_cm");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SimulationSize_cm_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SimulationSize_cm_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispInteractMgr:SimulationSize_cm");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SimulationSize_cm_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_DispInteractMgr:InteractiveData_StorageSize_cm")]
	public float InteractiveData_StorageSize_cm
	{
		get
		{
			CheckDestroyed();
			if (!InteractiveData_StorageSize_cm_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispInteractMgr:InteractiveData_StorageSize_cm");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, InteractiveData_StorageSize_cm_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InteractiveData_StorageSize_cm_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispInteractMgr:InteractiveData_StorageSize_cm");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, InteractiveData_StorageSize_cm_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_DispInteractMgr:InteractDistLimitToDispActor")]
	public float InteractDistLimitToDispActor
	{
		get
		{
			CheckDestroyed();
			if (!InteractDistLimitToDispActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispInteractMgr:InteractDistLimitToDispActor");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, InteractDistLimitToDispActor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InteractDistLimitToDispActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispInteractMgr:InteractDistLimitToDispActor");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, InteractDistLimitToDispActor_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_DispInteractMgr:NS_Landscape_Interactive")]
	public UNiagaraSystem NS_Landscape_Interactive
	{
		get
		{
			CheckDestroyed();
			if (!NS_Landscape_Interactive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispInteractMgr:NS_Landscape_Interactive");
				return null;
			}
			return UObjectMarshaler<UNiagaraSystem>.FromNative(IntPtr.Add(base.Address, NS_Landscape_Interactive_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NS_Landscape_Interactive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispInteractMgr:NS_Landscape_Interactive");
			}
			else
			{
				UObjectMarshaler<UNiagaraSystem>.ToNative(IntPtr.Add(base.Address, NS_Landscape_Interactive_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_DispInteractMgr:NS_Landscape_Simulator")]
	public UNiagaraSystem NS_Landscape_Simulator
	{
		get
		{
			CheckDestroyed();
			if (!NS_Landscape_Simulator_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispInteractMgr:NS_Landscape_Simulator");
				return null;
			}
			return UObjectMarshaler<UNiagaraSystem>.FromNative(IntPtr.Add(base.Address, NS_Landscape_Simulator_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NS_Landscape_Simulator_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispInteractMgr:NS_Landscape_Simulator");
			}
			else
			{
				UObjectMarshaler<UNiagaraSystem>.ToNative(IntPtr.Add(base.Address, NS_Landscape_Simulator_Offset), value);
			}
		}
	}

	public static BGW_DispInteractMgr Get(UObject Context)
	{
		return BGWGameInstanceCS.GetObject<BGW_DispInteractMgr>(Context);
	}

	public override void OnInit()
	{
		EnableDispInteract = false;
	}

	public void RegisterDispInteractActor()
	{
		if (!(DispInteractOwner != null))
		{
			BGW_PreloadAssetMgr.Get(this).TryGetCachedResourceObj<UClass>(path, ELoadResourceType.AsyncLoadAndCache, EAssetPriority.Low, OnDispInteractActorLoaded);
		}
	}

	private void OnDispInteractActorLoaded(int ReqID, UObject Obj)
	{
		if (Obj == null)
		{
			return;
		}
		UWorld uWorld = UBGUFunctionLibraryForCS.BGUGetUWorld(this);
		if (uWorld.IsNullOrDestroyed())
		{
			return;
		}
		TSubclassOf<BGUDispInteractActor> tSubclassOf = Obj as UClass;
		if (!(tSubclassOf != null))
		{
			return;
		}
		FActorSpawnParameters parameters = new FActorSpawnParameters
		{
			SpawnCollisionHandlingOverride = ESpawnActorCollisionHandlingMethod.AdjustIfPossibleButAlwaysSpawn
		};
		FVector Location = FVector.ZeroVector;
		FRotator Rotation = FRotator.ZeroRotator;
		BGUDispInteractActor dispInteractOwner = BGU_UnrealWorldUtil.SpawnActorAndECSBeginPlay(uWorld, tSubclassOf.Value, ref Location, ref Rotation, ref parameters) as BGUDispInteractActor;
		DispInteractOwner = dispInteractOwner;
		AActor controlledPawn = UGSE_EngineFuncLib.GetFirstLocalPlayerController(uWorld).GetControlledPawn();
		if (!controlledPawn.IsNullOrDestroyed())
		{
			DispInteractOwner.AttachTo = controlledPawn;
		}
		CallDispInteractOwnerUpdate();
		if (!DispInteractOwner.IsNullOrDestroyed())
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(DispInteractOwner);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_EventOnUpdateDispInteractNSSystem.Invoke(NS_Landscape_Interactive, NS_Landscape_Simulator);
			}
		}
	}

	public BGUDispInteractActor GetDispInteractOwner()
	{
		return DispInteractOwner;
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (bDelayCallDispInteractOwnerUpdate)
		{
			CallDispInteractOwnerUpdate();
		}
	}

	public void OnEnableDispInteract(bool enable)
	{
		if (enable)
		{
			EnableDispInteract = true;
		}
		else
		{
			EnableDispInteract = false;
		}
	}

	public void OnUpdateAreaLandScapeInfo(UWorld World, float _MaxHeight, ALandscape _LandScape, UTexture2D _LS_HeightMap, UTexture2D _LS_WeightMap, int MinX, int MinY, int MaxX, int MaxY, FVector _LandscapeOriginOffset, float _SimulationSize_cm, float _InteractiveData_StorageSize_cm, float _InteractDistLimitToDispActor, UNiagaraSystem NS_Landscape_Interactive, UNiagaraSystem NS_Landscape_Simulator)
	{
		LandScape = _LandScape;
		LS_HeightMap = _LS_HeightMap;
		LS_WeightMap = _LS_WeightMap;
		LS_MinX = MinX;
		LS_MinY = MinY;
		LS_MaxX = MaxX;
		LS_MaxY = MaxY;
		MaxHeight = _MaxHeight;
		LandscapeOriginOffset = _LandscapeOriginOffset;
		SimulationSize_cm = _SimulationSize_cm;
		InteractiveData_StorageSize_cm = _InteractiveData_StorageSize_cm;
		InteractDistLimitToDispActor = _InteractDistLimitToDispActor;
		this.NS_Landscape_Interactive = NS_Landscape_Interactive;
		this.NS_Landscape_Simulator = NS_Landscape_Simulator;
		CallDispInteractOwnerUpdate();
		if (!DispInteractOwner.IsNullOrDestroyed())
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(DispInteractOwner);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_EventOnUpdateDispInteractNSSystem.Invoke(NS_Landscape_Interactive, NS_Landscape_Simulator);
			}
		}
	}

	public void OnLeaveVolume()
	{
		if (!DispInteractOwner.IsNullOrDestroyed())
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(DispInteractOwner);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_OnDisableDispInteractNSSystem.Invoke();
			}
		}
	}

	private void CallDispInteractOwnerUpdate()
	{
		if (DispInteractOwner.IsNullOrDestroyed())
		{
			bDelayCallDispInteractOwnerUpdate = true;
			return;
		}
		FDispInteractLandscapeInfo interactLandscapeInfo = new FDispInteractLandscapeInfo
		{
			Landscape = LandScape,
			LS_HeightMap = LS_HeightMap,
			LS_WeightMap = LS_WeightMap,
			_LandscapeOriginOffset = LandscapeOriginOffset,
			VertexCount_Width = LS_MaxX - LS_MinX + 1,
			VertexCount_Height = LS_MaxY - LS_MinY + 1,
			MaxHeight = MaxHeight,
			SimulationSize_cm = SimulationSize_cm,
			InteractiveData_StorageSize_cm = InteractiveData_StorageSize_cm,
			InteractDistLimitToDispActor = InteractDistLimitToDispActor
		};
		BUS_EventCollectionCS.Get(DispInteractOwner).Evt_EventOnPlayerChangeVolume.Invoke(interactLandscapeInfo);
		bDelayCallDispInteractOwnerUpdate = false;
	}

	static BGW_DispInteractMgr()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGW_DispInteractMgr)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGW_DispInteractMgr));
		path = "/Game/00Main/Design/Tech/Landscape_Interactive_Virtual/BPs/BP_DIActor.BP_DIActor_C";
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGW_DispInteractMgr");
		DispInteractOwner_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DispInteractOwner");
		DispInteractOwner_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DispInteractOwner", Classes.FObjectProperty);
		LandScape_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LandScape");
		LandScape_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LandScape", Classes.FObjectProperty);
		LS_HeightMap_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LS_HeightMap");
		LS_HeightMap_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LS_HeightMap", Classes.FObjectProperty);
		LS_WeightMap_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LS_WeightMap");
		LS_WeightMap_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LS_WeightMap", Classes.FObjectProperty);
		LandscapeOriginOffset_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LandscapeOriginOffset");
		LandscapeOriginOffset_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LandscapeOriginOffset", Classes.FStructProperty);
		LS_MinX_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LS_MinX");
		LS_MinX_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LS_MinX", Classes.FIntProperty);
		LS_MinY_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LS_MinY");
		LS_MinY_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LS_MinY", Classes.FIntProperty);
		LS_MaxX_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LS_MaxX");
		LS_MaxX_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LS_MaxX", Classes.FIntProperty);
		LS_MaxY_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LS_MaxY");
		LS_MaxY_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LS_MaxY", Classes.FIntProperty);
		MaxHeight_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MaxHeight");
		MaxHeight_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MaxHeight", Classes.FFloatProperty);
		SimulationSize_cm_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SimulationSize_cm");
		SimulationSize_cm_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SimulationSize_cm", Classes.FFloatProperty);
		InteractiveData_StorageSize_cm_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "InteractiveData_StorageSize_cm");
		InteractiveData_StorageSize_cm_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "InteractiveData_StorageSize_cm", Classes.FFloatProperty);
		InteractDistLimitToDispActor_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "InteractDistLimitToDispActor");
		InteractDistLimitToDispActor_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "InteractDistLimitToDispActor", Classes.FFloatProperty);
		NS_Landscape_Interactive_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "NS_Landscape_Interactive");
		NS_Landscape_Interactive_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "NS_Landscape_Interactive", Classes.FObjectProperty);
		NS_Landscape_Simulator_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "NS_Landscape_Simulator");
		NS_Landscape_Simulator_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "NS_Landscape_Simulator", Classes.FObjectProperty);
	}
}

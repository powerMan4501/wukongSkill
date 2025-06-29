using System;
using System.Collections.Generic;
using System.Linq;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.Runtime.Native;

namespace b1.BGW;

[UClass]
[USharpPath("/Script/b1-Managed.NEW_SDFMgr")]
public class NEW_SDFMgr : GameInstanceSystemBaseUObj
{
	public struct SolverSpawnInfo
	{
		public AActor SolverOwner;

		public int Pority;
	}

	private bool bEnableDrawDebug;

	private Dictionary<EntitySharedRef, DSDF_Solver> SDFSolverMap = new Dictionary<EntitySharedRef, DSDF_Solver>();

	private Dictionary<EntitySharedRef, FVector> InteractActors = new Dictionary<EntitySharedRef, FVector>();

	private List<SolverSpawnInfo> SpawnDelayQueue = new List<SolverSpawnInfo>();

	private static bool DSDFActorClass_IsValid;

	private static int DSDFActorClass_Offset;

	public override bool bTickEnabled => true;

	[UProperty]
	[USharpPath("/Script/b1-Managed.NEW_SDFMgr:DSDFActorClass")]
	private TSubclassOf<BGUDynamicSDFGenerator> DSDFActorClass
	{
		get
		{
			CheckDestroyed();
			if (!DSDFActorClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.NEW_SDFMgr:DSDFActorClass");
				return default(TSubclassOf<BGUDynamicSDFGenerator>);
			}
			return TSubclassOfMarshaler<BGUDynamicSDFGenerator>.FromNative(IntPtr.Add(base.Address, DSDFActorClass_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DSDFActorClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.NEW_SDFMgr:DSDFActorClass");
			}
			else
			{
				TSubclassOfMarshaler<BGUDynamicSDFGenerator>.ToNative(IntPtr.Add(base.Address, DSDFActorClass_Offset), value);
			}
		}
	}

	public static NEW_SDFMgr Get(UObject Context)
	{
		return BGWGameInstanceCS.GetObject<NEW_SDFMgr>(Context);
	}

	public override void OnInit()
	{
		DSDFActorClass = BGW_PreloadAssetMgr.Get(this).TryGetCachedResourceObj<UClass>("/Game/00Main/Design/Tech/DynamicSDF/BPs/DynamicSDFGenerator.DynamicSDFGenerator_C", ELoadResourceType.SyncLoadAndCache);
		bEnableDrawDebug = GSGameplayCVar.CVar_DrawDebugSDFInfo.GetValueInGameThread() == 1;
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		SolverSpawnCheck();
		EntityValidCheck();
		DistributionCollectUnit();
		foreach (KeyValuePair<EntitySharedRef, DSDF_Solver> item in SDFSolverMap)
		{
			item.Value.Update(DeltaTime);
		}
	}

	private void DistributionCollectUnit()
	{
		Dictionary<EntitySharedRef, FVector> InteractActors = new Dictionary<EntitySharedRef, FVector>(this.InteractActors);
		foreach (KeyValuePair<EntitySharedRef, DSDF_Solver> item in SDFSolverMap)
		{
			item.Value.SelectInteractActors(ref InteractActors);
		}
	}

	private void SortSolverByPority()
	{
		IOrderedEnumerable<KeyValuePair<EntitySharedRef, DSDF_Solver>> orderedEnumerable = SDFSolverMap.OrderByDescending(delegate(KeyValuePair<EntitySharedRef, DSDF_Solver> pair)
		{
			KeyValuePair<EntitySharedRef, DSDF_Solver> keyValuePair = pair;
			return keyValuePair.Value.GetPority();
		});
		Dictionary<EntitySharedRef, DSDF_Solver> dictionary = new Dictionary<EntitySharedRef, DSDF_Solver>();
		foreach (KeyValuePair<EntitySharedRef, DSDF_Solver> item in orderedEnumerable)
		{
			dictionary.Add(item.Key, item.Value);
		}
		SDFSolverMap = dictionary;
	}

	private void SolverSpawnCheck()
	{
		if (SpawnDelayQueue == null || SpawnDelayQueue.Count < 1 || DSDFActorClass == null)
		{
			return;
		}
		foreach (SolverSpawnInfo item in SpawnDelayQueue)
		{
			SpawnSolverDelayQueue(item);
		}
		SpawnDelayQueue.Clear();
	}

	public void RegistSolver(AActor SolverOwner, int Pority)
	{
		SolverSpawnInfo item = new SolverSpawnInfo
		{
			SolverOwner = SolverOwner,
			Pority = Pority
		};
		SpawnDelayQueue.Add(item);
	}

	private void SpawnSolverDelayQueue(SolverSpawnInfo SpawnInfo)
	{
		UWorld uWorld = UBGUFunctionLibraryForCS.BGUGetUWorld(this);
		if (!uWorld.IsNullOrDestroyed() && !(DSDFActorClass == null))
		{
			FActorSpawnParametersInterop parameters = new FActorSpawnParametersInterop
			{
				SpawnCollisionHandlingOverride = ESpawnActorCollisionHandlingMethod.AlwaysSpawn
			};
			FVector location = FVector.ZeroVector;
			FRotator rotation = FRotator.ZeroRotator;
			BGUDynamicSDFGenerator bGUDynamicSDFGenerator = uWorld.SpawnActor(DSDFActorClass.Value, ref location, ref rotation, ref parameters) as BGUDynamicSDFGenerator;
			if (!(bGUDynamicSDFGenerator == null))
			{
				EntitySharedRef entitySharedRef = new EntitySharedRef(SpawnInfo.SolverOwner);
				DSDF_Solver value = new DSDF_Solver(entitySharedRef, bGUDynamicSDFGenerator, SpawnInfo.Pority);
				SDFSolverMap.Add(entitySharedRef, value);
				SortSolverByPority();
			}
		}
	}

	private void RemoveSolver()
	{
	}

	public void UpdateUnitWorldPosition(AActor Unit)
	{
		EntitySharedRef key = new EntitySharedRef(Unit);
		if (!SDFSolverMap.ContainsKey(key))
		{
			FVector actorLocation = Unit.GetActorLocation();
			if (InteractActors.ContainsKey(key))
			{
				InteractActors[key] = actorLocation;
			}
			else
			{
				InteractActors.Add(key, actorLocation);
			}
		}
	}

	public void LogoutInteractObj(AActor InteractObj)
	{
		if (!(InteractObj == null))
		{
			EntitySharedRef key = new EntitySharedRef(InteractObj);
			if (InteractActors.ContainsKey(key))
			{
				InteractActors.Remove(key);
			}
		}
	}

	private void EntityValidCheck()
	{
		List<EntitySharedRef> list = new List<EntitySharedRef>();
		foreach (KeyValuePair<EntitySharedRef, FVector> interactActor in InteractActors)
		{
			if (EntitySharedRefFuncLib.Actor(interactActor.Key) == null)
			{
				list.Add(interactActor.Key);
			}
		}
		foreach (EntitySharedRef item in list)
		{
			InteractActors.Remove(item);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.NEW_SDFMgr");
		DSDFActorClass_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DSDFActorClass");
		DSDFActorClass_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DSDFActorClass", Classes.FClassProperty);
	}

	static NEW_SDFMgr()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(NEW_SDFMgr)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(NEW_SDFMgr));
	}
}

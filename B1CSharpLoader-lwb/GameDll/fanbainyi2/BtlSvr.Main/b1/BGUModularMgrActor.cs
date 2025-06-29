using System;
using System.Collections.Generic;
using UnrealEngine.AssetRegistry;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUModularMgrActor")]
public class BGUModularMgrActor : BGUActorBaseCS
{
	private static bool ModularMgrConfigComp_IsValid;

	private static int ModularMgrConfigComp_Offset;

	private static bool SpawnedModularActors_IsValid;

	private static int SpawnedModularActors_Offset;

	private static FFieldAddress SpawnedModularActors_PropertyAddress;

	private TArrayReadWriteMarshaler<AActor> SpawnedModularActors_Marshaler;

	private static bool ModularMeshes_IsValid;

	private static int ModularMeshes_Offset;

	private static FFieldAddress ModularMeshes_PropertyAddress;

	private TMapReadWriteMarshaler<UObject, string> ModularMeshes_Marshaler;

	private static bool SpawnModularActors_IsValid;

	private static IntPtr SpawnModularActors_FunctionAddress;

	private static int SpawnModularActors_ParamsSize;

	private static bool ReceiveDestroyed_IsValid;

	private static IntPtr ReceiveDestroyed_FunctionAddress;

	private static int ReceiveDestroyed_ParamsSize;

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUModularMgrActor:ModularMgrConfigComp")]
	public BUS_ModularMgrConfigComp ModularMgrConfigComp
	{
		get
		{
			CheckDestroyed();
			if (!ModularMgrConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUModularMgrActor:ModularMgrConfigComp");
				return null;
			}
			return UObjectMarshaler<BUS_ModularMgrConfigComp>.FromNative(IntPtr.Add(base.Address, ModularMgrConfigComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ModularMgrConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUModularMgrActor:ModularMgrConfigComp");
			}
			else
			{
				UObjectMarshaler<BUS_ModularMgrConfigComp>.ToNative(IntPtr.Add(base.Address, ModularMgrConfigComp_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUModularMgrActor:SpawnedModularActors")]
	public TArrayReadWrite<AActor> SpawnedModularActors
	{
		get
		{
			CheckDestroyed();
			if (!SpawnedModularActors_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUModularMgrActor:SpawnedModularActors");
				return null;
			}
			if (SpawnedModularActors_Marshaler == null)
			{
				SpawnedModularActors_Marshaler = new TArrayReadWriteMarshaler<AActor>(1, SpawnedModularActors_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative);
			}
			return SpawnedModularActors_Marshaler.FromNative(IntPtr.Add(base.Address, SpawnedModularActors_Offset));
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUModularMgrActor:ModularMeshes")]
	public TMapReadWrite<UObject, string> ModularMeshes
	{
		get
		{
			CheckDestroyed();
			if (!ModularMeshes_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUModularMgrActor:ModularMeshes");
				return null;
			}
			if (ModularMeshes_Marshaler == null)
			{
				ModularMeshes_Marshaler = new TMapReadWriteMarshaler<UObject, string>(1, ModularMeshes_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative);
			}
			return ModularMeshes_Marshaler.FromNative(IntPtr.Add(base.Address, ModularMeshes_Offset));
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		ModularMgrConfigComp = initializer.CreateDefaultSubobject<BUS_ModularMgrConfigComp>(this, B1GlobalFNames.ModularMgrConfigComp);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddComp(new b1.BUS_ModularMgrComp());
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<BUS_ModularMgrDataComp>(this, B1GlobalFNames.ModularMgrDataComp);
	}

	[USharpPath("/Script/b1-Managed.BGUModularMgrActor:ReceiveDestroyed")]
	protected override void ReceiveDestroyed_Implementation()
	{
		ClearSpawnedModularActors();
	}

	[UMeta(MDFunc.CallInEditor)]
	[BlueprintCallable]
	[UFunction]
	[Category("Modular Actors Manager")]
	[USharpPath("/Script/b1-Managed.BGUModularMgrActor:SpawnModularActors")]
	public void SpawnModularActors()
	{
		SpawnModularActorsEditor();
	}

	public void SpawnModularActorsEditor()
	{
		if (ModularMgrConfigComp.ModularActorTemplate == null || ModularMgrConfigComp.ContextTamerActor == null)
		{
			return;
		}
		ClearSpawnedModularActors();
		ModularMeshes.Clear();
		foreach (FAssetData item in UGSFuncLibForEditor.GetAssetsInFolder(new FName(ModularMgrConfigComp.ModularFolderPath)).AssetDataArr)
		{
			bool num = item.GetClass() == UClass.GetClass<UStaticMesh>();
			bool flag = item.GetClass() == UClass.GetClass<USkeletalMesh>();
			if (num || flag)
			{
				string text = item.GetFullName().Split('.')[^1];
				ModularMeshes.Add(item.GetAsset(), text);
				SpawnModularActor(item.GetAsset(), text, bIsRuntime: false);
			}
		}
	}

	public void SpawnModularActorsRuntime()
	{
		if (ModularMgrConfigComp.ModularActorTemplate == null || ModularMgrConfigComp.ContextTamerActor == null)
		{
			return;
		}
		ClearSpawnedModularActors();
		foreach (KeyValuePair<UObject, string> modularMesh in ModularMeshes)
		{
			SpawnModularActor(modularMesh.Key, modularMesh.Value, bIsRuntime: true);
		}
	}

	private void SpawnModularActor(UObject Mesh, string TargetSocketName, bool bIsRuntime)
	{
		AActor aActor = RandomSpawnModularActor(Mesh, TargetSocketName, bIsRuntime);
		if (!(aActor != null))
		{
			return;
		}
		if (bIsRuntime)
		{
			BGUCharacterCS monster = ModularMgrConfigComp.ContextTamerActor.GetMonster();
			if (monster != null)
			{
				if (ModularMgrConfigComp.bAutoAttachModularActors)
				{
					aActor.AttachToComponent(monster.Mesh, new FName(TargetSocketName), EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, bWeldSimulatedBodies: false);
				}
				else
				{
					aActor.AttachToActor(monster, FName.None, EAttachmentRule.KeepWorld, EAttachmentRule.KeepWorld, EAttachmentRule.KeepWorld, bWeldSimulatedBodies: false);
				}
				SpawnedModularActors.Add(aActor);
			}
		}
		else
		{
			if (ModularMgrConfigComp.bAutoAttachModularActors)
			{
				aActor.AttachToComponent(ModularMgrConfigComp.ContextTamerActor.Mesh, new FName(TargetSocketName), EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, bWeldSimulatedBodies: false);
			}
			else
			{
				aActor.AttachToActor(ModularMgrConfigComp.ContextTamerActor, FName.None, EAttachmentRule.KeepWorld, EAttachmentRule.KeepWorld, EAttachmentRule.KeepWorld, bWeldSimulatedBodies: false);
			}
			SpawnedModularActors.Add(aActor);
		}
	}

	private AActor RandomSpawnModularActor(UObject ModularMesh, string TargetSocketName, bool bIsRuntime)
	{
		UStaticMesh uStaticMesh = ModularMesh as UStaticMesh;
		USkeletalMesh uSkeletalMesh = ModularMesh as USkeletalMesh;
		float modularActorSpawnInnerRange = ModularMgrConfigComp.ModularActorSpawnInnerRange;
		float modularActorSpawnOuterRange = ModularMgrConfigComp.ModularActorSpawnOuterRange;
		float num = (float)UMathLibrary.RandomFloatInRange(modularActorSpawnInnerRange, modularActorSpawnOuterRange);
		float value = FMath.DegreesToRadians((float)UMathLibrary.RandomFloatInRange(0.0, 360.0));
		float num2 = num * FMath.Cos(value);
		float num3 = num * FMath.Sin(value);
		float num4 = num * FMath.Sin(value);
		float z = BGUFuncLibActorTransformCS.BGUGetActorLocation(ModularMgrConfigComp.ContextTamerActor).Z;
		num4 = ((!ModularMgrConfigComp.bUseRandomLocationZ || num4 < z) ? 0f : (num4 - z));
		FVector location = UMathLibrary_CsExtensions.TransformLocation(Location: new FVector(num2, num3, num4), T: BGUFuncLibActorTransformCS.BGUGetActorTransform(ModularMgrConfigComp.ContextTamerActor));
		if (ModularMgrConfigComp.bAutoSnapToGround)
		{
			FVector lineTraceEnd = location + FVector.UpVector * -1000.0;
			if (BGUFuncLibSelectTargetsCS.LineTraceForHitWorldItem(this, location, lineTraceEnd, out var hitResultSimple))
			{
				float num5 = 0f;
				if (uSkeletalMesh != null)
				{
					num5 = uSkeletalMesh.GetBounds().BoxExtent.Z;
				}
				else if (uStaticMesh != null)
				{
					num5 = uStaticMesh.GetBounds().BoxExtent.Z;
				}
				location.Z = hitResultSimple.HitLocation.Z + num5;
			}
		}
		FRotator rotation = (ModularMgrConfigComp.bUseRandomRotation ? UMathLibrary.RandomRotator() : FRotator.ZeroRotator);
		FTransform Trans = new FTransform(rotation, location);
		AActor aActor = null;
		if (bIsRuntime)
		{
			FActorSpawnParameters parameters = new FActorSpawnParameters
			{
				SpawnCollisionHandlingOverride = ESpawnActorCollisionHandlingMethod.AlwaysSpawn
			};
			aActor = base.World.SpawnActor(ModularMgrConfigComp.ModularActorTemplate.Value, ref location, ref rotation, ref parameters);
		}
		else
		{
			aActor = BGUFuncLibNonRuntime.BGUSpawnActorFromAssetPath(ModularMgrConfigComp.ModularActorTemplate.Value.PathName, ref Trans);
		}
		FName item = new FName(TargetSocketName);
		if (uSkeletalMesh != null)
		{
			USkeletalMeshComponent componentByClass = aActor.GetComponentByClass<USkeletalMeshComponent>();
			if (componentByClass != null)
			{
				componentByClass.SetSkeletalMesh(uSkeletalMesh);
				componentByClass.ReceivesDecals = false;
				componentByClass.ComponentTags.Add(item);
			}
		}
		else if (uStaticMesh != null)
		{
			UStaticMeshComponent componentByClass2 = aActor.GetComponentByClass<UStaticMeshComponent>();
			if (componentByClass2 != null)
			{
				componentByClass2.SetStaticMesh(uStaticMesh);
				componentByClass2.ReceivesDecals = false;
				componentByClass2.ComponentTags.Add(item);
			}
		}
		aActor.Tags.Add(item);
		return aActor;
	}

	public void ClearSpawnedModularActors()
	{
		foreach (AActor spawnedModularActor in SpawnedModularActors)
		{
			if (!spawnedModularActor.IsNullOrDestroyed())
			{
				BGU_UnrealWorldUtil.DestroyActor(spawnedModularActor);
			}
		}
		SpawnedModularActors.Clear();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUModularMgrActor:SpawnModularActors")]
	private static void SpawnModularActors__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUModularMgrActor bGUModularMgrActor = GCHelper.Find<BGUModularMgrActor>(obj);
		bGUModularMgrActor.SpawnModularActors();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUModularMgrActor:ReceiveDestroyed")]
	private static void ReceiveDestroyed__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUModularMgrActor bGUModularMgrActor = GCHelper.Find<BGUModularMgrActor>(obj);
		bGUModularMgrActor.ReceiveDestroyed_Implementation();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGUModularMgrActor");
		ModularMgrConfigComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "ModularMgrConfigComp");
		ModularMgrConfigComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ModularMgrConfigComp", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref SpawnedModularActors_PropertyAddress, intPtr, "SpawnedModularActors");
		SpawnedModularActors_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpawnedModularActors");
		SpawnedModularActors_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpawnedModularActors", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref ModularMeshes_PropertyAddress, intPtr, "ModularMeshes");
		ModularMeshes_Offset = NativeReflection.GetPropertyOffset(intPtr, "ModularMeshes");
		ModularMeshes_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ModularMeshes", Classes.FMapProperty);
		SpawnModularActors_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SpawnModularActors");
		SpawnModularActors_ParamsSize = NativeReflection.GetFunctionParamsSize(SpawnModularActors_FunctionAddress);
		SpawnModularActors_IsValid = SpawnModularActors_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUModularMgrActor:SpawnModularActors", SpawnModularActors_IsValid);
		ReceiveDestroyed_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveDestroyed");
		ReceiveDestroyed_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveDestroyed_FunctionAddress);
		ReceiveDestroyed_IsValid = ReceiveDestroyed_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUModularMgrActor:ReceiveDestroyed", ReceiveDestroyed_IsValid);
	}

	static BGUModularMgrActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUModularMgrActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUModularMgrActor));
	}
}

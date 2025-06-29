using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[BlueprintType]
[USharpPath("/Script/b1-Managed.BGUPerformerActorCS")]
public class BGUPerformerActorCS : ABGUPerformerActor, IECSWorldObj
{
	protected Entity mECSEntity;

	protected Chunk mECSChunk;

	protected int mECSIndexInChunk;

	private static bool DataComp_IsValid;

	private static int DataComp_Offset;

	private static bool ActorCompContainerCS_IsValid;

	private static int ActorCompContainerCS_Offset;

	private static bool GuidComp_IsValid;

	private static int GuidComp_Offset;

	private static bool ActorConfigInfoComp_IsValid;

	private static int ActorConfigInfoComp_Offset;

	private static bool AudioEditComp_IsValid;

	private static int AudioEditComp_Offset;

	private static bool CharacterModularComp_IsValid;

	private static int CharacterModularComp_Offset;

	private static bool ConfigInfoComp_IsValid;

	private static int ConfigInfoComp_Offset;

	private static bool bPlayerPerformer_IsValid;

	private static int bPlayerPerformer_Offset;

	private static FFieldAddress bPlayerPerformer_PropertyAddress;

	private static bool bSupportAIConversation_IsValid;

	private static int bSupportAIConversation_Offset;

	private static FFieldAddress bSupportAIConversation_PropertyAddress;

	private static bool EquipFinish_IsValid;

	private static IntPtr EquipFinish_FunctionAddress;

	private static int EquipFinish_ParamsSize;

	private static bool EquipFinish_EquipId_IsValid;

	private static int EquipFinish_EquipId_Offset;

	private IntPtr EquipFinish_InstanceFunctionAddressInstance;

	private static bool BeginPlayCS_IsValid;

	private static IntPtr BeginPlayCS_FunctionAddress;

	private static int BeginPlayCS_ParamsSize;

	private static bool GetActorGuidCS_IsValid;

	private static IntPtr GetActorGuidCS_FunctionAddress;

	private static int GetActorGuidCS_ParamsSize;

	private static bool GetActorGuidCS_OutActorGuid_IsValid;

	private static int GetActorGuidCS_OutActorGuid_Offset;

	private static FFieldAddress GetActorGuidCS_OutActorGuid_PropertyAddress;

	private static bool GetActorGuidCS_ReturnValue_IsValid;

	private static int GetActorGuidCS_ReturnValue_Offset;

	private static FFieldAddress GetActorGuidCS_ReturnValue_PropertyAddress;

	private static bool OnConstructionCS_IsValid;

	private static IntPtr OnConstructionCS_FunctionAddress;

	private static int OnConstructionCS_ParamsSize;

	private static bool OnConstructionCS_Transform_IsValid;

	private static int OnConstructionCS_Transform_Offset;

	private static FFieldAddress OnConstructionCS_Transform_PropertyAddress;

	private static bool PostInitializeComponentsCS_IsValid;

	private static IntPtr PostInitializeComponentsCS_FunctionAddress;

	private static int PostInitializeComponentsCS_ParamsSize;

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

	public int ECSArcheType => 7;

	private BUS_GSEventCollection RPCEventCollection { get; set; }

	[UProperty(Flags = PropFlags.Transient)]
	[USharpPath("/Script/b1-Managed.BGUPerformerActorCS:DataComp")]
	public UActorDataContainer DataComp
	{
		get
		{
			CheckDestroyed();
			if (!DataComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUPerformerActorCS:DataComp");
				return null;
			}
			return UObjectMarshaler<UActorDataContainer>.FromNative(IntPtr.Add(base.Address, DataComp_Offset));
		}
		protected set
		{
			CheckDestroyed();
			if (!DataComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUPerformerActorCS:DataComp");
			}
			else
			{
				UObjectMarshaler<UActorDataContainer>.ToNative(IntPtr.Add(base.Address, DataComp_Offset), value);
			}
		}
	}

	[UProperty(Flags = PropFlags.Transient)]
	[USharpPath("/Script/b1-Managed.BGUPerformerActorCS:ActorCompContainerCS")]
	public UActorCompContainerCS ActorCompContainerCS
	{
		get
		{
			CheckDestroyed();
			if (!ActorCompContainerCS_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUPerformerActorCS:ActorCompContainerCS");
				return null;
			}
			return UObjectMarshaler<UActorCompContainerCS>.FromNative(IntPtr.Add(base.Address, ActorCompContainerCS_Offset));
		}
		protected set
		{
			CheckDestroyed();
			if (!ActorCompContainerCS_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUPerformerActorCS:ActorCompContainerCS");
			}
			else
			{
				UObjectMarshaler<UActorCompContainerCS>.ToNative(IntPtr.Add(base.Address, ActorCompContainerCS_Offset), value);
			}
		}
	}

	[UProperty]
	[VisibleAnywhere]
	[USharpPath("/Script/b1-Managed.BGUPerformerActorCS:GuidComp")]
	private BUS_GuidComp GuidComp
	{
		get
		{
			CheckDestroyed();
			if (!GuidComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUPerformerActorCS:GuidComp");
				return null;
			}
			return UObjectMarshaler<BUS_GuidComp>.FromNative(IntPtr.Add(base.Address, GuidComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GuidComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUPerformerActorCS:GuidComp");
			}
			else
			{
				UObjectMarshaler<BUS_GuidComp>.ToNative(IntPtr.Add(base.Address, GuidComp_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUPerformerActorCS:ActorConfigInfoComp")]
	private BUS_ActorConfigInfoComp ActorConfigInfoComp
	{
		get
		{
			CheckDestroyed();
			if (!ActorConfigInfoComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUPerformerActorCS:ActorConfigInfoComp");
				return null;
			}
			return UObjectMarshaler<BUS_ActorConfigInfoComp>.FromNative(IntPtr.Add(base.Address, ActorConfigInfoComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ActorConfigInfoComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUPerformerActorCS:ActorConfigInfoComp");
			}
			else
			{
				UObjectMarshaler<BUS_ActorConfigInfoComp>.ToNative(IntPtr.Add(base.Address, ActorConfigInfoComp_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUPerformerActorCS:AudioEditComp")]
	private BUS_AudioEditComp AudioEditComp
	{
		get
		{
			CheckDestroyed();
			if (!AudioEditComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUPerformerActorCS:AudioEditComp");
				return null;
			}
			return UObjectMarshaler<BUS_AudioEditComp>.FromNative(IntPtr.Add(base.Address, AudioEditComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AudioEditComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUPerformerActorCS:AudioEditComp");
			}
			else
			{
				UObjectMarshaler<BUS_AudioEditComp>.ToNative(IntPtr.Add(base.Address, AudioEditComp_Offset), value);
			}
		}
	}

	[UProperty(Flags = PropFlags.Transient)]
	[USharpPath("/Script/b1-Managed.BGUPerformerActorCS:CharacterModularComp")]
	private BUS_CharacterModularComp CharacterModularComp
	{
		get
		{
			CheckDestroyed();
			if (!CharacterModularComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUPerformerActorCS:CharacterModularComp");
				return null;
			}
			return UObjectMarshaler<BUS_CharacterModularComp>.FromNative(IntPtr.Add(base.Address, CharacterModularComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CharacterModularComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUPerformerActorCS:CharacterModularComp");
			}
			else
			{
				UObjectMarshaler<BUS_CharacterModularComp>.ToNative(IntPtr.Add(base.Address, CharacterModularComp_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGUPerformerActorCS:ConfigInfoComp")]
	public BUS_SeqPerformerConfigInfoComp ConfigInfoComp
	{
		get
		{
			CheckDestroyed();
			if (!ConfigInfoComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUPerformerActorCS:ConfigInfoComp");
				return null;
			}
			return UObjectMarshaler<BUS_SeqPerformerConfigInfoComp>.FromNative(IntPtr.Add(base.Address, ConfigInfoComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ConfigInfoComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUPerformerActorCS:ConfigInfoComp");
			}
			else
			{
				UObjectMarshaler<BUS_SeqPerformerConfigInfoComp>.ToNative(IntPtr.Add(base.Address, ConfigInfoComp_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[DisplayName("是否为主角演员")]
	[Category("Performer")]
	[USharpPath("/Script/b1-Managed.BGUPerformerActorCS:bPlayerPerformer")]
	public bool bPlayerPerformer
	{
		get
		{
			CheckDestroyed();
			if (!bPlayerPerformer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUPerformerActorCS:bPlayerPerformer");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bPlayerPerformer_Offset), 0, bPlayerPerformer_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bPlayerPerformer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUPerformerActorCS:bPlayerPerformer");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bPlayerPerformer_Offset), 0, bPlayerPerformer_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Performer")]
	[USharpPath("/Script/b1-Managed.BGUPerformerActorCS:bSupportAIConversation")]
	public bool bSupportAIConversation
	{
		get
		{
			CheckDestroyed();
			if (!bSupportAIConversation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUPerformerActorCS:bSupportAIConversation");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bSupportAIConversation_Offset), 0, bSupportAIConversation_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bSupportAIConversation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUPerformerActorCS:bSupportAIConversation");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bSupportAIConversation_Offset), 0, bSupportAIConversation_PropertyAddress.Address, value);
			}
		}
	}

	public Entity GetECSEntity()
	{
		return ECSEntity;
	}

	public override void GetLifetimeReplicatedProps(FLifetimePropertyCollection lifetimeProps)
	{
		base.GetLifetimeReplicatedProps(lifetimeProps);
		lifetimeProps.Add("RPCEventCollection");
	}

	public object GetDataByChunk(int TypeIndex)
	{
		return BGU_DataUtil.GetDataByEntityChunk(TypeIndex, mECSEntity, mECSChunk, mECSIndexInChunk);
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		base.Initialize(Initializer);
		RPCEventCollection = Initializer.CreateDefaultSubobject<BUS_GSEventCollection>(this, B1GlobalFNames.RPCEventCollection);
		CreateDataContainer(Initializer);
		base.ActorCompContainer = Initializer.CreateDefaultSubobject<UActorCompContainer>(this, B1GlobalFNames.ActorCompContainer);
		GuidComp = Initializer.CreateDefaultSubobject<BUS_GuidComp>(this, B1GlobalFNames.GuidSystem);
		ActorCompContainerCS = Initializer.CreateDefaultSubobject<UActorCompContainerCS>(this, B1GlobalFNames.ActorCompContainerCS);
		ActorConfigInfoComp = Initializer.CreateDefaultSubobject<BUS_ActorConfigInfoComp>(this, B1GlobalFNames.ActorConfigInfoSystem);
		AudioEditComp = Initializer.CreateDefaultSubobject<BUS_AudioEditComp>(this, B1GlobalFNames.AudioEditComp);
		CharacterModularComp = Initializer.CreateDefaultSubobject<BUS_CharacterModularComp>(this, B1GlobalFNames.CharacterModularComp);
		ConfigInfoComp = Initializer.CreateDefaultSubobject<BUS_SeqPerformerConfigInfoComp>(this, B1GlobalFNames.ConfigInfoComp);
		base.Mesh.ComponentTags.Add(B1GlobalFNames.master);
		base.Hidden = true;
	}

	[USharpPath("/Script/b1-Managed.BGUPerformerActorCS:PostInitializeComponentsCS")]
	protected sealed override void PostInitializeComponentsCS_Implementation()
	{
		base.PostInitializeComponentsCS_Implementation();
	}

	public object GetEventCollection()
	{
		return RPCEventCollection;
	}

	public virtual void InitAllComp()
	{
		if (UBGUFunctionLibraryForCS.BGUGetIsInGameWorld(this))
		{
			base.ActorCompContainer.FillDataContainer(DataComp);
			base.ActorCompContainer.FillEventCollection(base.EventCollection);
		}
		ActorCompContainerCS.AddComp(new BUS_GuidCompImpl());
		ActorCompContainerCS.AddCompUObj<b1.BUS_AKMgrComp>();
		ActorCompContainerCS.AddComp(new b1.BUS_InteractInfoCollectionComp());
		ActorCompContainerCS.AddComp(new BUS_BattleInfoComp());
		if (UGSE_EngineFuncLib.IsStandAlone(base.World) && bPlayerPerformer && !B1Global.GIsMovieRendering)
		{
			ActorCompContainerCS.AddComp(new BUS_PerformerEquipComp());
			ActorCompContainerCS.AddComp(new BUS_CharacterModularCompImpl(), 1);
			ActorCompContainerCS.AddComp(new BUS_EquipComp(), 1);
		}
		if (bSupportAIConversation)
		{
			ActorCompContainerCS.AddComp(new BUS_AIConversationCompl());
			ActorCompContainerCS.AddComp(new BUS_FacialAnimComp());
		}
	}

	public void AfterInitAllComp()
	{
		ActorCompContainerCS.AddComp(new b1.BUS_ActorTransformInfoComp());
	}

	[USharpPath("/Script/b1-Managed.BGUPerformerActorCS:OnConstructionCS")]
	protected override void OnConstructionCS_Implementation(FTransform Transform)
	{
		GuidComp?.OnActorConstruction();
		CharacterModularComp?.OnActorConstruction();
	}

	[USharpPath("/Script/b1-Managed.BGUPerformerActorCS:BeginPlayCS")]
	protected override void BeginPlayCS_Implementation()
	{
		FullyInit();
		base.BeginPlayCS_Implementation();
		CacheTeamIDFromMaster();
		if (bPlayerPerformer && B1Global.GIsMovieRendering)
		{
			ApplyEquipConfig();
		}
	}

	protected virtual void CreateDataContainer(FObjectInitializer initializer)
	{
		DataComp = initializer.CreateDefaultSubobject<b1.BUS_PerformerDataComp>(this, B1GlobalFNames.PerformerDataComp);
	}

	private void CacheTeamIDFromMaster()
	{
		int teamID = 0;
		BUC_MasterData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_MasterData>(this);
		if (readOnlyData != null)
		{
			AActor masterActor = readOnlyData.GetMasterActor();
			if (masterActor != null)
			{
				BGUCharacterCS bGUCharacterCS = masterActor as BGUCharacterCS;
				if (bGUCharacterCS != null)
				{
					teamID = bGUCharacterCS.GetTeamIDInCS();
				}
			}
		}
		SetTeamID(teamID);
	}

	[USharpPath("/Script/b1-Managed.BGUPerformerActorCS:GetActorGuidCS")]
	protected override bool GetActorGuidCS_Implementation(out string OutActorGuid)
	{
		OutActorGuid = BGU_DataUtil.GetActorGuid(this, bFindFromComponent: true);
		return !string.IsNullOrEmpty(OutActorGuid);
	}

	[UFunction]
	[BlueprintImplementedEvent]
	[USharpPath("/Script/b1-Managed.BGUPerformerActorCS:EquipFinish")]
	public unsafe void EquipFinish(int EquipId)
	{
		CheckDestroyed();
		if (!EquipFinish_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BGUPerformerActorCS:EquipFinish");
			return;
		}
		if (EquipFinish_InstanceFunctionAddressInstance == IntPtr.Zero)
		{
			EquipFinish_InstanceFunctionAddressInstance = NativeReflection.GetFunctionFromInstance(base.Address, "EquipFinish");
		}
		byte* value = stackalloc byte[(int)(uint)EquipFinish_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, EquipFinish_ParamsSize);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, EquipFinish_EquipId_Offset), EquipId);
		NativeReflection.InvokeFunction(base.Address, EquipFinish_InstanceFunctionAddressInstance, intPtr, EquipFinish_ParamsSize);
	}

	public void ApplyEquipConfig()
	{
		if (bPlayerPerformer)
		{
			IBIC_MovieData gameInstanceReadonlyData = BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_MovieData, BIC_MovieData>(this);
			if (gameInstanceReadonlyData != null)
			{
				gameInstanceReadonlyData.GetPlayerPerformerEquipConfig(out var MeshConfig, out var AbpConfig);
				SetEquipPositionMesh(B1GlobalFNames.head, MeshConfig.Head, AbpConfig.Head.Value);
				SetEquipPositionMesh(B1GlobalFNames.upwear, MeshConfig.UpWear, AbpConfig.UpWear.Value);
				SetEquipPositionMesh(B1GlobalFNames.Arm, MeshConfig.Arm, AbpConfig.Arm.Value);
				SetEquipPositionMesh(B1GlobalFNames.foot, MeshConfig.Foot, AbpConfig.Foot.Value);
				SetEquipPositionMesh(B1GlobalFNames.Hulu, MeshConfig.Hulu, AbpConfig.Hulu.Value);
				SetEquipPositionMesh(B1GlobalFNames.weapon, MeshConfig.Weapon, AbpConfig.Weapon.Value);
			}
		}
	}

	private void SetEquipPositionMesh(FName InTag, USkeletalMesh InMesh, UClass InAbp)
	{
		if (InMesh == null)
		{
			return;
		}
		List<UActorComponent> componentsByTag = GetComponentsByTag(UClass.GetClass(typeof(USkeletalMeshComponent)), InTag);
		if (componentsByTag == null || componentsByTag.Count <= 0)
		{
			return;
		}
		USkeletalMeshComponent uSkeletalMeshComponent = componentsByTag[0] as USkeletalMeshComponent;
		if (uSkeletalMeshComponent != null)
		{
			if (InAbp == null)
			{
				uSkeletalMeshComponent.SetMasterPoseComponent(base.Mesh);
				uSkeletalMeshComponent.SetCollisionProfileName(B1GlobalFNames.NoCollision);
				uSkeletalMeshComponent.SetSkeletalMesh(InMesh);
			}
			else
			{
				uSkeletalMeshComponent.SetMasterPoseComponent(null);
				uSkeletalMeshComponent.SetCollisionProfileName(B1GlobalFNames.BodyPart);
				uSkeletalMeshComponent.SetSkeletalMesh(InMesh);
				uSkeletalMeshComponent.SetAnimClass(InAbp);
			}
			List<FSkeletalMaterial> materials = InMesh.GetMaterials();
			for (int i = 0; i < materials.Count; i++)
			{
				uSkeletalMeshComponent.SetMaterial(i, materials[i].MaterialInterface);
			}
		}
	}

	public bool IsBeginPlayFinished()
	{
		return ActorCompContainerCS.HasLateBeginPlay;
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUPerformerActorCS:BeginPlayCS")]
	private static void BeginPlayCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUPerformerActorCS bGUPerformerActorCS = GCHelper.Find<BGUPerformerActorCS>(obj);
		bGUPerformerActorCS.BeginPlayCS_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUPerformerActorCS:GetActorGuidCS")]
	private static void GetActorGuidCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUPerformerActorCS bGUPerformerActorCS = GCHelper.Find<BGUPerformerActorCS>(obj);
		string OutActorGuid;
		bool actorGuidCS_Implementation = bGUPerformerActorCS.GetActorGuidCS_Implementation(out OutActorGuid);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, GetActorGuidCS_ReturnValue_Offset), 0, GetActorGuidCS_ReturnValue_PropertyAddress.Address, actorGuidCS_Implementation);
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetActorGuidCS_OutActorGuid_Offset), OutActorGuid);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUPerformerActorCS:OnConstructionCS")]
	private static void OnConstructionCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUPerformerActorCS bGUPerformerActorCS = GCHelper.Find<BGUPerformerActorCS>(obj);
		FTransform transform = BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(buffer, OnConstructionCS_Transform_Offset));
		bGUPerformerActorCS.OnConstructionCS_Implementation(transform);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUPerformerActorCS:PostInitializeComponentsCS")]
	private static void PostInitializeComponentsCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUPerformerActorCS bGUPerformerActorCS = GCHelper.Find<BGUPerformerActorCS>(obj);
		bGUPerformerActorCS.PostInitializeComponentsCS_Implementation();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGUPerformerActorCS");
		DataComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "DataComp");
		DataComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DataComp", Classes.FObjectProperty);
		ActorCompContainerCS_Offset = NativeReflection.GetPropertyOffset(intPtr, "ActorCompContainerCS");
		ActorCompContainerCS_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ActorCompContainerCS", Classes.FObjectProperty);
		GuidComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "GuidComp");
		GuidComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GuidComp", Classes.FObjectProperty);
		ActorConfigInfoComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "ActorConfigInfoComp");
		ActorConfigInfoComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ActorConfigInfoComp", Classes.FObjectProperty);
		AudioEditComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "AudioEditComp");
		AudioEditComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AudioEditComp", Classes.FObjectProperty);
		CharacterModularComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "CharacterModularComp");
		CharacterModularComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CharacterModularComp", Classes.FObjectProperty);
		ConfigInfoComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "ConfigInfoComp");
		ConfigInfoComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ConfigInfoComp", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref bPlayerPerformer_PropertyAddress, intPtr, "bPlayerPerformer");
		bPlayerPerformer_Offset = NativeReflection.GetPropertyOffset(intPtr, "bPlayerPerformer");
		bPlayerPerformer_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bPlayerPerformer", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bSupportAIConversation_PropertyAddress, intPtr, "bSupportAIConversation");
		bSupportAIConversation_Offset = NativeReflection.GetPropertyOffset(intPtr, "bSupportAIConversation");
		bSupportAIConversation_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bSupportAIConversation", Classes.FBoolProperty);
		EquipFinish_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "EquipFinish");
		EquipFinish_ParamsSize = NativeReflection.GetFunctionParamsSize(EquipFinish_FunctionAddress);
		EquipFinish_EquipId_Offset = NativeReflection.GetPropertyOffset(EquipFinish_FunctionAddress, "EquipId");
		EquipFinish_EquipId_IsValid = NativeReflection.ValidatePropertyClass(EquipFinish_FunctionAddress, "EquipId", Classes.FIntProperty);
		EquipFinish_IsValid = EquipFinish_FunctionAddress != IntPtr.Zero && EquipFinish_EquipId_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUPerformerActorCS:EquipFinish", EquipFinish_IsValid);
		BeginPlayCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BeginPlayCS");
		BeginPlayCS_ParamsSize = NativeReflection.GetFunctionParamsSize(BeginPlayCS_FunctionAddress);
		BeginPlayCS_IsValid = BeginPlayCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUPerformerActorCS:BeginPlayCS", BeginPlayCS_IsValid);
		GetActorGuidCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetActorGuidCS");
		GetActorGuidCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetActorGuidCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetActorGuidCS_OutActorGuid_PropertyAddress, GetActorGuidCS_FunctionAddress, "OutActorGuid");
		GetActorGuidCS_OutActorGuid_Offset = NativeReflection.GetPropertyOffset(GetActorGuidCS_FunctionAddress, "OutActorGuid");
		GetActorGuidCS_OutActorGuid_IsValid = NativeReflection.ValidatePropertyClass(GetActorGuidCS_FunctionAddress, "OutActorGuid", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref GetActorGuidCS_ReturnValue_PropertyAddress, GetActorGuidCS_FunctionAddress, "ReturnValue");
		GetActorGuidCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetActorGuidCS_FunctionAddress, "ReturnValue");
		GetActorGuidCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetActorGuidCS_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetActorGuidCS_IsValid = GetActorGuidCS_FunctionAddress != IntPtr.Zero && GetActorGuidCS_OutActorGuid_IsValid && GetActorGuidCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUPerformerActorCS:GetActorGuidCS", GetActorGuidCS_IsValid);
		OnConstructionCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnConstructionCS");
		OnConstructionCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnConstructionCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnConstructionCS_Transform_PropertyAddress, OnConstructionCS_FunctionAddress, "Transform");
		OnConstructionCS_Transform_Offset = NativeReflection.GetPropertyOffset(OnConstructionCS_FunctionAddress, "Transform");
		OnConstructionCS_Transform_IsValid = NativeReflection.ValidatePropertyClass(OnConstructionCS_FunctionAddress, "Transform", Classes.FStructProperty);
		OnConstructionCS_IsValid = OnConstructionCS_FunctionAddress != IntPtr.Zero && OnConstructionCS_Transform_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUPerformerActorCS:OnConstructionCS", OnConstructionCS_IsValid);
		PostInitializeComponentsCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PostInitializeComponentsCS");
		PostInitializeComponentsCS_ParamsSize = NativeReflection.GetFunctionParamsSize(PostInitializeComponentsCS_FunctionAddress);
		PostInitializeComponentsCS_IsValid = PostInitializeComponentsCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUPerformerActorCS:PostInitializeComponentsCS", PostInitializeComponentsCS_IsValid);
	}

	static BGUPerformerActorCS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUPerformerActorCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUPerformerActorCS));
	}
}

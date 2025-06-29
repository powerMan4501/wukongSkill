using System;
using b1;
using UnrealEngine.Runtime;

namespace GSDispLib;

[BlueprintType]
[UClass]
[USharpPath("/Script/b1-Managed.BUC_DispLibDispBaseConfigDataAsset")]
public class BUC_DispLibDispBaseConfigDataAsset : UBGWDataAsset
{
	private static bool PlayCascade_IsValid;

	private static int PlayCascade_Offset;

	private static FFieldAddress PlayCascade_PropertyAddress;

	private TArrayReadWriteMarshaler<BUC_DispLibDBC_PlayCascade> PlayCascade_Marshaler;

	private static bool PlayNiagara_IsValid;

	private static int PlayNiagara_Offset;

	private static FFieldAddress PlayNiagara_PropertyAddress;

	private TArrayReadWriteMarshaler<BUC_DispLibDBC_PlayNiagara> PlayNiagara_Marshaler;

	private static bool PlayAdvanceNiagara_IsValid;

	private static int PlayAdvanceNiagara_Offset;

	private static FFieldAddress PlayAdvanceNiagara_PropertyAddress;

	private TArrayReadWriteMarshaler<BUC_DispLibDBC_PlayAdvanceNiagara> PlayAdvanceNiagara_Marshaler;

	private static bool PlayArtFresnel_IsValid;

	private static int PlayArtFresnel_Offset;

	private static FFieldAddress PlayArtFresnel_PropertyAddress;

	private TArrayReadWriteMarshaler<BUC_DispLibDBC_PlayArtFresnel> PlayArtFresnel_Marshaler;

	private static bool PlayCameraShake_IsValid;

	private static int PlayCameraShake_Offset;

	private static FFieldAddress PlayCameraShake_PropertyAddress;

	private TArrayReadWriteMarshaler<BUC_DispLibDBC_PlayCameraShake> PlayCameraShake_Marshaler;

	private static bool PlayCustomCameraShake_IsValid;

	private static int PlayCustomCameraShake_Offset;

	private static FFieldAddress PlayCustomCameraShake_PropertyAddress;

	private TArrayReadWriteMarshaler<BUC_DispLibDBC_PlayCustomCameraShake> PlayCustomCameraShake_Marshaler;

	private static bool PlayAudio_IsValid;

	private static int PlayAudio_Offset;

	private static FFieldAddress PlayAudio_PropertyAddress;

	private TArrayReadWriteMarshaler<BUC_DispLibDBC_PlayAudio> PlayAudio_Marshaler;

	private static bool SpawnSimpleActor_IsValid;

	private static int SpawnSimpleActor_Offset;

	private static FFieldAddress SpawnSimpleActor_PropertyAddress;

	private TArrayReadWriteMarshaler<BUC_DispLibDBC_SpawnSimpleActor> SpawnSimpleActor_Marshaler;

	private static bool WEFMWind_IsValid;

	private static int WEFMWind_Offset;

	private static FFieldAddress WEFMWind_PropertyAddress;

	private TArrayReadWriteMarshaler<BUC_DispLibDBC_WEFMWind> WEFMWind_Marshaler;

	private static bool ScenePhysicalInteractor_IsValid;

	private static int ScenePhysicalInteractor_Offset;

	private static FFieldAddress ScenePhysicalInteractor_PropertyAddress;

	private TArrayReadWriteMarshaler<BUC_DispLibDBC_ScenePhysicalInteractor> ScenePhysicalInteractor_Marshaler;

	private static bool ChangeMaterial_IsValid;

	private static int ChangeMaterial_Offset;

	private static FFieldAddress ChangeMaterial_PropertyAddress;

	private TArrayReadWriteMarshaler<BUC_DispLibDBC_ChangeMaterial> ChangeMaterial_Marshaler;

	private static bool ModifyMaterial_IsValid;

	private static int ModifyMaterial_Offset;

	private static FFieldAddress ModifyMaterial_PropertyAddress;

	private TArrayReadWriteMarshaler<BUC_DispLibDBC_ModifyMaterial> ModifyMaterial_Marshaler;

	private static bool ModifyNiagaraParams_IsValid;

	private static int ModifyNiagaraParams_Offset;

	private static FFieldAddress ModifyNiagaraParams_PropertyAddress;

	private TArrayReadWriteMarshaler<BUC_DispLibDBC_ModifyNiagaraParams> ModifyNiagaraParams_Marshaler;

	private static bool ModifyMPCParams_IsValid;

	private static int ModifyMPCParams_Offset;

	private static FFieldAddress ModifyMPCParams_PropertyAddress;

	private TArrayReadWriteMarshaler<BUC_DispLibDBC_ModifyMaterialParameterCollection> ModifyMPCParams_Marshaler;

	private static bool CustomEvents_IsValid;

	private static int CustomEvents_Offset;

	private static FFieldAddress CustomEvents_PropertyAddress;

	private TArrayReadWriteMarshaler<BUC_DispLibDBC_CustomEvent> CustomEvents_Marshaler;

	private static bool MetaString_IsValid;

	private static int MetaString_Offset;

	private static bool DelayDestroyTime_IsValid;

	private static int DelayDestroyTime_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("Play Cascade")]
	[Category("Cascade")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDispBaseConfigDataAsset:PlayCascade")]
	public TArrayReadWrite<BUC_DispLibDBC_PlayCascade> PlayCascade
	{
		get
		{
			CheckDestroyed();
			if (!PlayCascade_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUC_DispLibDispBaseConfigDataAsset:PlayCascade");
				return null;
			}
			if (PlayCascade_Marshaler == null)
			{
				PlayCascade_Marshaler = new TArrayReadWriteMarshaler<BUC_DispLibDBC_PlayCascade>(1, PlayCascade_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibDBC_PlayCascade, BUC_DispLibDBC_PlayCascade>.FromNative, CachedMarshalingDelegates<BUC_DispLibDBC_PlayCascade, BUC_DispLibDBC_PlayCascade>.ToNative);
			}
			return PlayCascade_Marshaler.FromNative(IntPtr.Add(base.Address, PlayCascade_Offset));
		}
	}

	[DisplayName("Play Niagara")]
	[UProperty]
	[EditAnywhere]
	[Category("Niagara")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDispBaseConfigDataAsset:PlayNiagara")]
	public TArrayReadWrite<BUC_DispLibDBC_PlayNiagara> PlayNiagara
	{
		get
		{
			CheckDestroyed();
			if (!PlayNiagara_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUC_DispLibDispBaseConfigDataAsset:PlayNiagara");
				return null;
			}
			if (PlayNiagara_Marshaler == null)
			{
				PlayNiagara_Marshaler = new TArrayReadWriteMarshaler<BUC_DispLibDBC_PlayNiagara>(1, PlayNiagara_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibDBC_PlayNiagara, BUC_DispLibDBC_PlayNiagara>.FromNative, CachedMarshalingDelegates<BUC_DispLibDBC_PlayNiagara, BUC_DispLibDBC_PlayNiagara>.ToNative);
			}
			return PlayNiagara_Marshaler.FromNative(IntPtr.Add(base.Address, PlayNiagara_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("Play Advance Niagara")]
	[Category("Advance Niagara")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDispBaseConfigDataAsset:PlayAdvanceNiagara")]
	public TArrayReadWrite<BUC_DispLibDBC_PlayAdvanceNiagara> PlayAdvanceNiagara
	{
		get
		{
			CheckDestroyed();
			if (!PlayAdvanceNiagara_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUC_DispLibDispBaseConfigDataAsset:PlayAdvanceNiagara");
				return null;
			}
			if (PlayAdvanceNiagara_Marshaler == null)
			{
				PlayAdvanceNiagara_Marshaler = new TArrayReadWriteMarshaler<BUC_DispLibDBC_PlayAdvanceNiagara>(1, PlayAdvanceNiagara_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibDBC_PlayAdvanceNiagara, BUC_DispLibDBC_PlayAdvanceNiagara>.FromNative, CachedMarshalingDelegates<BUC_DispLibDBC_PlayAdvanceNiagara, BUC_DispLibDBC_PlayAdvanceNiagara>.ToNative);
			}
			return PlayAdvanceNiagara_Marshaler.FromNative(IntPtr.Add(base.Address, PlayAdvanceNiagara_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("Play Art Fresnel")]
	[Category("Art Fresnel")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDispBaseConfigDataAsset:PlayArtFresnel")]
	public TArrayReadWrite<BUC_DispLibDBC_PlayArtFresnel> PlayArtFresnel
	{
		get
		{
			CheckDestroyed();
			if (!PlayArtFresnel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUC_DispLibDispBaseConfigDataAsset:PlayArtFresnel");
				return null;
			}
			if (PlayArtFresnel_Marshaler == null)
			{
				PlayArtFresnel_Marshaler = new TArrayReadWriteMarshaler<BUC_DispLibDBC_PlayArtFresnel>(1, PlayArtFresnel_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibDBC_PlayArtFresnel, BUC_DispLibDBC_PlayArtFresnel>.FromNative, CachedMarshalingDelegates<BUC_DispLibDBC_PlayArtFresnel, BUC_DispLibDBC_PlayArtFresnel>.ToNative);
			}
			return PlayArtFresnel_Marshaler.FromNative(IntPtr.Add(base.Address, PlayArtFresnel_Offset));
		}
	}

	[BlueprintReadWrite]
	[Category("Camera Shake")]
	[DisplayName("Play Camera Shake")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDispBaseConfigDataAsset:PlayCameraShake")]
	public TArrayReadWrite<BUC_DispLibDBC_PlayCameraShake> PlayCameraShake
	{
		get
		{
			CheckDestroyed();
			if (!PlayCameraShake_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUC_DispLibDispBaseConfigDataAsset:PlayCameraShake");
				return null;
			}
			if (PlayCameraShake_Marshaler == null)
			{
				PlayCameraShake_Marshaler = new TArrayReadWriteMarshaler<BUC_DispLibDBC_PlayCameraShake>(1, PlayCameraShake_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibDBC_PlayCameraShake, BUC_DispLibDBC_PlayCameraShake>.FromNative, CachedMarshalingDelegates<BUC_DispLibDBC_PlayCameraShake, BUC_DispLibDBC_PlayCameraShake>.ToNative);
			}
			return PlayCameraShake_Marshaler.FromNative(IntPtr.Add(base.Address, PlayCameraShake_Offset));
		}
	}

	[Category("Custom Camera Shake")]
	[DisplayName("Play Custom Camera Shake")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDispBaseConfigDataAsset:PlayCustomCameraShake")]
	public TArrayReadWrite<BUC_DispLibDBC_PlayCustomCameraShake> PlayCustomCameraShake
	{
		get
		{
			CheckDestroyed();
			if (!PlayCustomCameraShake_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUC_DispLibDispBaseConfigDataAsset:PlayCustomCameraShake");
				return null;
			}
			if (PlayCustomCameraShake_Marshaler == null)
			{
				PlayCustomCameraShake_Marshaler = new TArrayReadWriteMarshaler<BUC_DispLibDBC_PlayCustomCameraShake>(1, PlayCustomCameraShake_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibDBC_PlayCustomCameraShake, BUC_DispLibDBC_PlayCustomCameraShake>.FromNative, CachedMarshalingDelegates<BUC_DispLibDBC_PlayCustomCameraShake, BUC_DispLibDBC_PlayCustomCameraShake>.ToNative);
			}
			return PlayCustomCameraShake_Marshaler.FromNative(IntPtr.Add(base.Address, PlayCustomCameraShake_Offset));
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[Category("Audio")]
	[DisplayName("Play Audio")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDispBaseConfigDataAsset:PlayAudio")]
	public TArrayReadWrite<BUC_DispLibDBC_PlayAudio> PlayAudio
	{
		get
		{
			CheckDestroyed();
			if (!PlayAudio_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUC_DispLibDispBaseConfigDataAsset:PlayAudio");
				return null;
			}
			if (PlayAudio_Marshaler == null)
			{
				PlayAudio_Marshaler = new TArrayReadWriteMarshaler<BUC_DispLibDBC_PlayAudio>(1, PlayAudio_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibDBC_PlayAudio, BUC_DispLibDBC_PlayAudio>.FromNative, CachedMarshalingDelegates<BUC_DispLibDBC_PlayAudio, BUC_DispLibDBC_PlayAudio>.ToNative);
			}
			return PlayAudio_Marshaler.FromNative(IntPtr.Add(base.Address, PlayAudio_Offset));
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("Spawn Simple Actor")]
	[Category("Spawn Simple Actor")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDispBaseConfigDataAsset:SpawnSimpleActor")]
	public TArrayReadWrite<BUC_DispLibDBC_SpawnSimpleActor> SpawnSimpleActor
	{
		get
		{
			CheckDestroyed();
			if (!SpawnSimpleActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUC_DispLibDispBaseConfigDataAsset:SpawnSimpleActor");
				return null;
			}
			if (SpawnSimpleActor_Marshaler == null)
			{
				SpawnSimpleActor_Marshaler = new TArrayReadWriteMarshaler<BUC_DispLibDBC_SpawnSimpleActor>(1, SpawnSimpleActor_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibDBC_SpawnSimpleActor, BUC_DispLibDBC_SpawnSimpleActor>.FromNative, CachedMarshalingDelegates<BUC_DispLibDBC_SpawnSimpleActor, BUC_DispLibDBC_SpawnSimpleActor>.ToNative);
			}
			return SpawnSimpleActor_Marshaler.FromNative(IntPtr.Add(base.Address, SpawnSimpleActor_Offset));
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("WEFM Wind")]
	[Category("WEFM Wind")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDispBaseConfigDataAsset:WEFMWind")]
	public TArrayReadWrite<BUC_DispLibDBC_WEFMWind> WEFMWind
	{
		get
		{
			CheckDestroyed();
			if (!WEFMWind_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUC_DispLibDispBaseConfigDataAsset:WEFMWind");
				return null;
			}
			if (WEFMWind_Marshaler == null)
			{
				WEFMWind_Marshaler = new TArrayReadWriteMarshaler<BUC_DispLibDBC_WEFMWind>(1, WEFMWind_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibDBC_WEFMWind, BUC_DispLibDBC_WEFMWind>.FromNative, CachedMarshalingDelegates<BUC_DispLibDBC_WEFMWind, BUC_DispLibDBC_WEFMWind>.ToNative);
			}
			return WEFMWind_Marshaler.FromNative(IntPtr.Add(base.Address, WEFMWind_Offset));
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("Scene Physical Interactor")]
	[Category("Scene Physical Interactor")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDispBaseConfigDataAsset:ScenePhysicalInteractor")]
	public TArrayReadWrite<BUC_DispLibDBC_ScenePhysicalInteractor> ScenePhysicalInteractor
	{
		get
		{
			CheckDestroyed();
			if (!ScenePhysicalInteractor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUC_DispLibDispBaseConfigDataAsset:ScenePhysicalInteractor");
				return null;
			}
			if (ScenePhysicalInteractor_Marshaler == null)
			{
				ScenePhysicalInteractor_Marshaler = new TArrayReadWriteMarshaler<BUC_DispLibDBC_ScenePhysicalInteractor>(1, ScenePhysicalInteractor_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibDBC_ScenePhysicalInteractor, BUC_DispLibDBC_ScenePhysicalInteractor>.FromNative, CachedMarshalingDelegates<BUC_DispLibDBC_ScenePhysicalInteractor, BUC_DispLibDBC_ScenePhysicalInteractor>.ToNative);
			}
			return ScenePhysicalInteractor_Marshaler.FromNative(IntPtr.Add(base.Address, ScenePhysicalInteractor_Offset));
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("(废弃)Change Material")]
	[UProperty]
	[Category("(废弃)Change Material")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDispBaseConfigDataAsset:ChangeMaterial")]
	public TArrayReadWrite<BUC_DispLibDBC_ChangeMaterial> ChangeMaterial
	{
		get
		{
			CheckDestroyed();
			if (!ChangeMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUC_DispLibDispBaseConfigDataAsset:ChangeMaterial");
				return null;
			}
			if (ChangeMaterial_Marshaler == null)
			{
				ChangeMaterial_Marshaler = new TArrayReadWriteMarshaler<BUC_DispLibDBC_ChangeMaterial>(1, ChangeMaterial_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibDBC_ChangeMaterial, BUC_DispLibDBC_ChangeMaterial>.FromNative, CachedMarshalingDelegates<BUC_DispLibDBC_ChangeMaterial, BUC_DispLibDBC_ChangeMaterial>.ToNative);
			}
			return ChangeMaterial_Marshaler.FromNative(IntPtr.Add(base.Address, ChangeMaterial_Offset));
		}
	}

	[UProperty]
	[Category("Modify Material")]
	[DisplayName("Modify Material")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDispBaseConfigDataAsset:ModifyMaterial")]
	public TArrayReadWrite<BUC_DispLibDBC_ModifyMaterial> ModifyMaterial
	{
		get
		{
			CheckDestroyed();
			if (!ModifyMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUC_DispLibDispBaseConfigDataAsset:ModifyMaterial");
				return null;
			}
			if (ModifyMaterial_Marshaler == null)
			{
				ModifyMaterial_Marshaler = new TArrayReadWriteMarshaler<BUC_DispLibDBC_ModifyMaterial>(1, ModifyMaterial_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibDBC_ModifyMaterial, BUC_DispLibDBC_ModifyMaterial>.FromNative, CachedMarshalingDelegates<BUC_DispLibDBC_ModifyMaterial, BUC_DispLibDBC_ModifyMaterial>.ToNative);
			}
			return ModifyMaterial_Marshaler.FromNative(IntPtr.Add(base.Address, ModifyMaterial_Offset));
		}
	}

	[BlueprintReadWrite]
	[DisplayName("Modify Niagara")]
	[UProperty]
	[EditAnywhere]
	[Category("Modify Niagara")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDispBaseConfigDataAsset:ModifyNiagaraParams")]
	public TArrayReadWrite<BUC_DispLibDBC_ModifyNiagaraParams> ModifyNiagaraParams
	{
		get
		{
			CheckDestroyed();
			if (!ModifyNiagaraParams_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUC_DispLibDispBaseConfigDataAsset:ModifyNiagaraParams");
				return null;
			}
			if (ModifyNiagaraParams_Marshaler == null)
			{
				ModifyNiagaraParams_Marshaler = new TArrayReadWriteMarshaler<BUC_DispLibDBC_ModifyNiagaraParams>(1, ModifyNiagaraParams_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibDBC_ModifyNiagaraParams, BUC_DispLibDBC_ModifyNiagaraParams>.FromNative, CachedMarshalingDelegates<BUC_DispLibDBC_ModifyNiagaraParams, BUC_DispLibDBC_ModifyNiagaraParams>.ToNative);
			}
			return ModifyNiagaraParams_Marshaler.FromNative(IntPtr.Add(base.Address, ModifyNiagaraParams_Offset));
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("Modify Material Parameter Collection")]
	[Category("Modify Material Parameter Collection")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDispBaseConfigDataAsset:ModifyMPCParams")]
	public TArrayReadWrite<BUC_DispLibDBC_ModifyMaterialParameterCollection> ModifyMPCParams
	{
		get
		{
			CheckDestroyed();
			if (!ModifyMPCParams_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUC_DispLibDispBaseConfigDataAsset:ModifyMPCParams");
				return null;
			}
			if (ModifyMPCParams_Marshaler == null)
			{
				ModifyMPCParams_Marshaler = new TArrayReadWriteMarshaler<BUC_DispLibDBC_ModifyMaterialParameterCollection>(1, ModifyMPCParams_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibDBC_ModifyMaterialParameterCollection, BUC_DispLibDBC_ModifyMaterialParameterCollection>.FromNative, CachedMarshalingDelegates<BUC_DispLibDBC_ModifyMaterialParameterCollection, BUC_DispLibDBC_ModifyMaterialParameterCollection>.ToNative);
			}
			return ModifyMPCParams_Marshaler.FromNative(IntPtr.Add(base.Address, ModifyMPCParams_Offset));
		}
	}

	[Category("Custom Event")]
	[BlueprintReadWrite]
	[DisplayName("自定义事件")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDispBaseConfigDataAsset:CustomEvents")]
	public TArrayReadWrite<BUC_DispLibDBC_CustomEvent> CustomEvents
	{
		get
		{
			CheckDestroyed();
			if (!CustomEvents_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUC_DispLibDispBaseConfigDataAsset:CustomEvents");
				return null;
			}
			if (CustomEvents_Marshaler == null)
			{
				CustomEvents_Marshaler = new TArrayReadWriteMarshaler<BUC_DispLibDBC_CustomEvent>(1, CustomEvents_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibDBC_CustomEvent, BUC_DispLibDBC_CustomEvent>.FromNative, CachedMarshalingDelegates<BUC_DispLibDBC_CustomEvent, BUC_DispLibDBC_CustomEvent>.ToNative);
			}
			return CustomEvents_Marshaler.FromNative(IntPtr.Add(base.Address, CustomEvents_Offset));
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[DisplayName("MetaString")]
	[Category("Meta Data")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDispBaseConfigDataAsset:MetaString")]
	public FName MetaString
	{
		get
		{
			CheckDestroyed();
			if (!MetaString_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUC_DispLibDispBaseConfigDataAsset:MetaString");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, MetaString_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MetaString_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUC_DispLibDispBaseConfigDataAsset:MetaString");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, MetaString_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("结束表现时间")]
	[Category("Meta Data")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDispBaseConfigDataAsset:DelayDestroyTime")]
	public float DelayDestroyTime
	{
		get
		{
			CheckDestroyed();
			if (!DelayDestroyTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUC_DispLibDispBaseConfigDataAsset:DelayDestroyTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DelayDestroyTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DelayDestroyTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUC_DispLibDispBaseConfigDataAsset:DelayDestroyTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DelayDestroyTime_Offset), value);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUC_DispLibDispBaseConfigDataAsset");
		NativeReflection.GetPropertyRef(ref PlayCascade_PropertyAddress, unrealStruct, "PlayCascade");
		PlayCascade_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PlayCascade");
		PlayCascade_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PlayCascade", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref PlayNiagara_PropertyAddress, unrealStruct, "PlayNiagara");
		PlayNiagara_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PlayNiagara");
		PlayNiagara_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PlayNiagara", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref PlayAdvanceNiagara_PropertyAddress, unrealStruct, "PlayAdvanceNiagara");
		PlayAdvanceNiagara_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PlayAdvanceNiagara");
		PlayAdvanceNiagara_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PlayAdvanceNiagara", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref PlayArtFresnel_PropertyAddress, unrealStruct, "PlayArtFresnel");
		PlayArtFresnel_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PlayArtFresnel");
		PlayArtFresnel_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PlayArtFresnel", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref PlayCameraShake_PropertyAddress, unrealStruct, "PlayCameraShake");
		PlayCameraShake_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PlayCameraShake");
		PlayCameraShake_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PlayCameraShake", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref PlayCustomCameraShake_PropertyAddress, unrealStruct, "PlayCustomCameraShake");
		PlayCustomCameraShake_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PlayCustomCameraShake");
		PlayCustomCameraShake_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PlayCustomCameraShake", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref PlayAudio_PropertyAddress, unrealStruct, "PlayAudio");
		PlayAudio_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PlayAudio");
		PlayAudio_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PlayAudio", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref SpawnSimpleActor_PropertyAddress, unrealStruct, "SpawnSimpleActor");
		SpawnSimpleActor_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SpawnSimpleActor");
		SpawnSimpleActor_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SpawnSimpleActor", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref WEFMWind_PropertyAddress, unrealStruct, "WEFMWind");
		WEFMWind_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "WEFMWind");
		WEFMWind_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "WEFMWind", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref ScenePhysicalInteractor_PropertyAddress, unrealStruct, "ScenePhysicalInteractor");
		ScenePhysicalInteractor_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ScenePhysicalInteractor");
		ScenePhysicalInteractor_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ScenePhysicalInteractor", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref ChangeMaterial_PropertyAddress, unrealStruct, "ChangeMaterial");
		ChangeMaterial_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ChangeMaterial");
		ChangeMaterial_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ChangeMaterial", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref ModifyMaterial_PropertyAddress, unrealStruct, "ModifyMaterial");
		ModifyMaterial_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ModifyMaterial");
		ModifyMaterial_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ModifyMaterial", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref ModifyNiagaraParams_PropertyAddress, unrealStruct, "ModifyNiagaraParams");
		ModifyNiagaraParams_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ModifyNiagaraParams");
		ModifyNiagaraParams_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ModifyNiagaraParams", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref ModifyMPCParams_PropertyAddress, unrealStruct, "ModifyMPCParams");
		ModifyMPCParams_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ModifyMPCParams");
		ModifyMPCParams_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ModifyMPCParams", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref CustomEvents_PropertyAddress, unrealStruct, "CustomEvents");
		CustomEvents_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CustomEvents");
		CustomEvents_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CustomEvents", Classes.FArrayProperty);
		MetaString_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MetaString");
		MetaString_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MetaString", Classes.FNameProperty);
		DelayDestroyTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DelayDestroyTime");
		DelayDestroyTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DelayDestroyTime", Classes.FFloatProperty);
	}

	static BUC_DispLibDispBaseConfigDataAsset()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUC_DispLibDispBaseConfigDataAsset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUC_DispLibDispBaseConfigDataAsset));
	}
}

using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)821039268uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.ParticleSystemComponent", "Engine", UnrealModuleType.Engine)]
public class UParticleSystemComponent : UFXSystemComponent
{
	private static bool Template_IsValid;

	private static int Template_Offset;

	private static bool ResetOnDetach_IsValid;

	private static FFieldAddress ResetOnDetach_PropertyAddress;

	private static int ResetOnDetach_Offset;

	private static bool AllowRecycling_IsValid;

	private static FFieldAddress AllowRecycling_PropertyAddress;

	private static int AllowRecycling_Offset;

	private static bool AutoManageAttachment_IsValid;

	private static FFieldAddress AutoManageAttachment_PropertyAddress;

	private static int AutoManageAttachment_Offset;

	private static bool AutoAttachWeldSimulatedBodies_IsValid;

	private static FFieldAddress AutoAttachWeldSimulatedBodies_PropertyAddress;

	private static int AutoAttachWeldSimulatedBodies_Offset;

	private static bool OverrideLODMethod_IsValid;

	private static FFieldAddress OverrideLODMethod_PropertyAddress;

	private static int OverrideLODMethod_Offset;

	private static bool RenderInTranslucencyUpscaledRTPass_IsValid;

	private static FFieldAddress RenderInTranslucencyUpscaledRTPass_PropertyAddress;

	private static int RenderInTranslucencyUpscaledRTPass_Offset;

	private static bool LODMethod_IsValid;

	private static FFieldAddress LODMethod_PropertyAddress;

	private static int LODMethod_Offset;

	private static bool InstanceParameters_IsValid;

	private static FFieldAddress InstanceParameters_PropertyAddress;

	private static int InstanceParameters_Offset;

	private TArrayReadWriteMarshaler<FParticleSysParam> InstanceParameters_MarshalerCached;

	private static bool OnParticleSpawn_IsValid;

	private static int OnParticleSpawn_Offset;

	private FParticleSpawnSignature OnParticleSpawn_DelegateCached;

	private static bool OnParticleBurst_IsValid;

	private static int OnParticleBurst_Offset;

	private FParticleBurstSignature OnParticleBurst_DelegateCached;

	private static bool OnParticleDeath_IsValid;

	private static int OnParticleDeath_Offset;

	private FParticleDeathSignature OnParticleDeath_DelegateCached;

	private static bool OnParticleCollide_IsValid;

	private static int OnParticleCollide_Offset;

	private FParticleCollisionSignature OnParticleCollide_DelegateCached;

	private static bool SecondsBeforeInactive_IsValid;

	private static int SecondsBeforeInactive_Offset;

	private static bool CustomTimeDilation_IsValid;

	private static int CustomTimeDilation_Offset;

	private static bool AutoAttachParent_IsValid;

	private static int AutoAttachParent_Offset;

	private static bool AutoAttachSocketName_IsValid;

	private static int AutoAttachSocketName_Offset;

	private static bool AutoAttachLocationRule_IsValid;

	private static FFieldAddress AutoAttachLocationRule_PropertyAddress;

	private static int AutoAttachLocationRule_Offset;

	private static bool AutoAttachRotationRule_IsValid;

	private static FFieldAddress AutoAttachRotationRule_PropertyAddress;

	private static int AutoAttachRotationRule_Offset;

	private static bool AutoAttachScaleRule_IsValid;

	private static FFieldAddress AutoAttachScaleRule_PropertyAddress;

	private static int AutoAttachScaleRule_Offset;

	private static bool OnSystemFinished_IsValid;

	private static int OnSystemFinished_Offset;

	private FOnSystemFinished OnSystemFinished_DelegateCached;

	private static bool SetTrailSourceData_IsValid;

	private static IntPtr SetTrailSourceData_FunctionAddress;

	private static int SetTrailSourceData_ParamsSize;

	private static bool SetTrailSourceData_InFirstSocketName_IsValid;

	private static FFieldAddress SetTrailSourceData_InFirstSocketName_PropertyAddress;

	private static int SetTrailSourceData_InFirstSocketName_Offset;

	private static bool SetTrailSourceData_InSecondSocketName_IsValid;

	private static FFieldAddress SetTrailSourceData_InSecondSocketName_PropertyAddress;

	private static int SetTrailSourceData_InSecondSocketName_Offset;

	private static bool SetTrailSourceData_InWidthMode_IsValid;

	private static FFieldAddress SetTrailSourceData_InWidthMode_PropertyAddress;

	private static int SetTrailSourceData_InWidthMode_Offset;

	private static bool SetTrailSourceData_InWidth_IsValid;

	private static FFieldAddress SetTrailSourceData_InWidth_PropertyAddress;

	private static int SetTrailSourceData_InWidth_Offset;

	private static bool SetTemplate_IsValid;

	private static IntPtr SetTemplate_FunctionAddress;

	private static int SetTemplate_ParamsSize;

	private static bool SetTemplate_NewTemplate_IsValid;

	private static FFieldAddress SetTemplate_NewTemplate_PropertyAddress;

	private static int SetTemplate_NewTemplate_Offset;

	private static bool SetMaterialParameter_IsValid;

	private static IntPtr SetMaterialParameter_FunctionAddress;

	private static int SetMaterialParameter_ParamsSize;

	private static bool SetMaterialParameter_ParameterName_IsValid;

	private static FFieldAddress SetMaterialParameter_ParameterName_PropertyAddress;

	private static int SetMaterialParameter_ParameterName_Offset;

	private static bool SetMaterialParameter_Param_IsValid;

	private static FFieldAddress SetMaterialParameter_Param_PropertyAddress;

	private static int SetMaterialParameter_Param_Offset;

	private static bool SetBeamTargetTangent_IsValid;

	private static IntPtr SetBeamTargetTangent_FunctionAddress;

	private static int SetBeamTargetTangent_ParamsSize;

	private static bool SetBeamTargetTangent_EmitterIndex_IsValid;

	private static FFieldAddress SetBeamTargetTangent_EmitterIndex_PropertyAddress;

	private static int SetBeamTargetTangent_EmitterIndex_Offset;

	private static bool SetBeamTargetTangent_NewTangentPoint_IsValid;

	private static FFieldAddress SetBeamTargetTangent_NewTangentPoint_PropertyAddress;

	private static int SetBeamTargetTangent_NewTangentPoint_Offset;

	private static bool SetBeamTargetTangent_TargetIndex_IsValid;

	private static FFieldAddress SetBeamTargetTangent_TargetIndex_PropertyAddress;

	private static int SetBeamTargetTangent_TargetIndex_Offset;

	private static bool SetBeamTargetStrength_IsValid;

	private static IntPtr SetBeamTargetStrength_FunctionAddress;

	private static int SetBeamTargetStrength_ParamsSize;

	private static bool SetBeamTargetStrength_EmitterIndex_IsValid;

	private static FFieldAddress SetBeamTargetStrength_EmitterIndex_PropertyAddress;

	private static int SetBeamTargetStrength_EmitterIndex_Offset;

	private static bool SetBeamTargetStrength_NewTargetStrength_IsValid;

	private static FFieldAddress SetBeamTargetStrength_NewTargetStrength_PropertyAddress;

	private static int SetBeamTargetStrength_NewTargetStrength_Offset;

	private static bool SetBeamTargetStrength_TargetIndex_IsValid;

	private static FFieldAddress SetBeamTargetStrength_TargetIndex_PropertyAddress;

	private static int SetBeamTargetStrength_TargetIndex_Offset;

	private static bool SetBeamTargetPoint_IsValid;

	private static IntPtr SetBeamTargetPoint_FunctionAddress;

	private static int SetBeamTargetPoint_ParamsSize;

	private static bool SetBeamTargetPoint_EmitterIndex_IsValid;

	private static FFieldAddress SetBeamTargetPoint_EmitterIndex_PropertyAddress;

	private static int SetBeamTargetPoint_EmitterIndex_Offset;

	private static bool SetBeamTargetPoint_NewTargetPoint_IsValid;

	private static FFieldAddress SetBeamTargetPoint_NewTargetPoint_PropertyAddress;

	private static int SetBeamTargetPoint_NewTargetPoint_Offset;

	private static bool SetBeamTargetPoint_TargetIndex_IsValid;

	private static FFieldAddress SetBeamTargetPoint_TargetIndex_PropertyAddress;

	private static int SetBeamTargetPoint_TargetIndex_Offset;

	private static bool SetBeamSourceTangent_IsValid;

	private static IntPtr SetBeamSourceTangent_FunctionAddress;

	private static int SetBeamSourceTangent_ParamsSize;

	private static bool SetBeamSourceTangent_EmitterIndex_IsValid;

	private static FFieldAddress SetBeamSourceTangent_EmitterIndex_PropertyAddress;

	private static int SetBeamSourceTangent_EmitterIndex_Offset;

	private static bool SetBeamSourceTangent_NewTangentPoint_IsValid;

	private static FFieldAddress SetBeamSourceTangent_NewTangentPoint_PropertyAddress;

	private static int SetBeamSourceTangent_NewTangentPoint_Offset;

	private static bool SetBeamSourceTangent_SourceIndex_IsValid;

	private static FFieldAddress SetBeamSourceTangent_SourceIndex_PropertyAddress;

	private static int SetBeamSourceTangent_SourceIndex_Offset;

	private static bool SetBeamSourceStrength_IsValid;

	private static IntPtr SetBeamSourceStrength_FunctionAddress;

	private static int SetBeamSourceStrength_ParamsSize;

	private static bool SetBeamSourceStrength_EmitterIndex_IsValid;

	private static FFieldAddress SetBeamSourceStrength_EmitterIndex_PropertyAddress;

	private static int SetBeamSourceStrength_EmitterIndex_Offset;

	private static bool SetBeamSourceStrength_NewSourceStrength_IsValid;

	private static FFieldAddress SetBeamSourceStrength_NewSourceStrength_PropertyAddress;

	private static int SetBeamSourceStrength_NewSourceStrength_Offset;

	private static bool SetBeamSourceStrength_SourceIndex_IsValid;

	private static FFieldAddress SetBeamSourceStrength_SourceIndex_PropertyAddress;

	private static int SetBeamSourceStrength_SourceIndex_Offset;

	private static bool SetBeamSourcePoint_IsValid;

	private static IntPtr SetBeamSourcePoint_FunctionAddress;

	private static int SetBeamSourcePoint_ParamsSize;

	private static bool SetBeamSourcePoint_EmitterIndex_IsValid;

	private static FFieldAddress SetBeamSourcePoint_EmitterIndex_PropertyAddress;

	private static int SetBeamSourcePoint_EmitterIndex_Offset;

	private static bool SetBeamSourcePoint_NewSourcePoint_IsValid;

	private static FFieldAddress SetBeamSourcePoint_NewSourcePoint_PropertyAddress;

	private static int SetBeamSourcePoint_NewSourcePoint_Offset;

	private static bool SetBeamSourcePoint_SourceIndex_IsValid;

	private static FFieldAddress SetBeamSourcePoint_SourceIndex_PropertyAddress;

	private static int SetBeamSourcePoint_SourceIndex_Offset;

	private static bool SetBeamEndPoint_IsValid;

	private static IntPtr SetBeamEndPoint_FunctionAddress;

	private static int SetBeamEndPoint_ParamsSize;

	private static bool SetBeamEndPoint_EmitterIndex_IsValid;

	private static FFieldAddress SetBeamEndPoint_EmitterIndex_PropertyAddress;

	private static int SetBeamEndPoint_EmitterIndex_Offset;

	private static bool SetBeamEndPoint_NewEndPoint_IsValid;

	private static FFieldAddress SetBeamEndPoint_NewEndPoint_PropertyAddress;

	private static int SetBeamEndPoint_NewEndPoint_Offset;

	private static bool GetNumActiveParticles_IsValid;

	private static IntPtr GetNumActiveParticles_FunctionAddress;

	private static int GetNumActiveParticles_ParamsSize;

	private static bool GetNumActiveParticles_ReturnValue_IsValid;

	private static FFieldAddress GetNumActiveParticles_ReturnValue_PropertyAddress;

	private static int GetNumActiveParticles_ReturnValue_Offset;

	private static bool GetNamedMaterial_IsValid;

	private static IntPtr GetNamedMaterial_FunctionAddress;

	private static int GetNamedMaterial_ParamsSize;

	private static bool GetNamedMaterial_InName_IsValid;

	private static FFieldAddress GetNamedMaterial_InName_PropertyAddress;

	private static int GetNamedMaterial_InName_Offset;

	private static bool GetNamedMaterial_ReturnValue_IsValid;

	private static FFieldAddress GetNamedMaterial_ReturnValue_PropertyAddress;

	private static int GetNamedMaterial_ReturnValue_Offset;

	private static bool GetBeamTargetTangent_IsValid;

	private static IntPtr GetBeamTargetTangent_FunctionAddress;

	private static int GetBeamTargetTangent_ParamsSize;

	private static bool GetBeamTargetTangent_EmitterIndex_IsValid;

	private static FFieldAddress GetBeamTargetTangent_EmitterIndex_PropertyAddress;

	private static int GetBeamTargetTangent_EmitterIndex_Offset;

	private static bool GetBeamTargetTangent_TargetIndex_IsValid;

	private static FFieldAddress GetBeamTargetTangent_TargetIndex_PropertyAddress;

	private static int GetBeamTargetTangent_TargetIndex_Offset;

	private static bool GetBeamTargetTangent_OutTangentPoint_IsValid;

	private static FFieldAddress GetBeamTargetTangent_OutTangentPoint_PropertyAddress;

	private static int GetBeamTargetTangent_OutTangentPoint_Offset;

	private static bool GetBeamTargetTangent_ReturnValue_IsValid;

	private static FFieldAddress GetBeamTargetTangent_ReturnValue_PropertyAddress;

	private static int GetBeamTargetTangent_ReturnValue_Offset;

	private static bool GetBeamTargetStrength_IsValid;

	private static IntPtr GetBeamTargetStrength_FunctionAddress;

	private static int GetBeamTargetStrength_ParamsSize;

	private static bool GetBeamTargetStrength_EmitterIndex_IsValid;

	private static FFieldAddress GetBeamTargetStrength_EmitterIndex_PropertyAddress;

	private static int GetBeamTargetStrength_EmitterIndex_Offset;

	private static bool GetBeamTargetStrength_TargetIndex_IsValid;

	private static FFieldAddress GetBeamTargetStrength_TargetIndex_PropertyAddress;

	private static int GetBeamTargetStrength_TargetIndex_Offset;

	private static bool GetBeamTargetStrength_OutTargetStrength_IsValid;

	private static FFieldAddress GetBeamTargetStrength_OutTargetStrength_PropertyAddress;

	private static int GetBeamTargetStrength_OutTargetStrength_Offset;

	private static bool GetBeamTargetStrength_ReturnValue_IsValid;

	private static FFieldAddress GetBeamTargetStrength_ReturnValue_PropertyAddress;

	private static int GetBeamTargetStrength_ReturnValue_Offset;

	private static bool GetBeamTargetPoint_IsValid;

	private static IntPtr GetBeamTargetPoint_FunctionAddress;

	private static int GetBeamTargetPoint_ParamsSize;

	private static bool GetBeamTargetPoint_EmitterIndex_IsValid;

	private static FFieldAddress GetBeamTargetPoint_EmitterIndex_PropertyAddress;

	private static int GetBeamTargetPoint_EmitterIndex_Offset;

	private static bool GetBeamTargetPoint_TargetIndex_IsValid;

	private static FFieldAddress GetBeamTargetPoint_TargetIndex_PropertyAddress;

	private static int GetBeamTargetPoint_TargetIndex_Offset;

	private static bool GetBeamTargetPoint_OutTargetPoint_IsValid;

	private static FFieldAddress GetBeamTargetPoint_OutTargetPoint_PropertyAddress;

	private static int GetBeamTargetPoint_OutTargetPoint_Offset;

	private static bool GetBeamTargetPoint_ReturnValue_IsValid;

	private static FFieldAddress GetBeamTargetPoint_ReturnValue_PropertyAddress;

	private static int GetBeamTargetPoint_ReturnValue_Offset;

	private static bool GetBeamSourceTangent_IsValid;

	private static IntPtr GetBeamSourceTangent_FunctionAddress;

	private static int GetBeamSourceTangent_ParamsSize;

	private static bool GetBeamSourceTangent_EmitterIndex_IsValid;

	private static FFieldAddress GetBeamSourceTangent_EmitterIndex_PropertyAddress;

	private static int GetBeamSourceTangent_EmitterIndex_Offset;

	private static bool GetBeamSourceTangent_SourceIndex_IsValid;

	private static FFieldAddress GetBeamSourceTangent_SourceIndex_PropertyAddress;

	private static int GetBeamSourceTangent_SourceIndex_Offset;

	private static bool GetBeamSourceTangent_OutTangentPoint_IsValid;

	private static FFieldAddress GetBeamSourceTangent_OutTangentPoint_PropertyAddress;

	private static int GetBeamSourceTangent_OutTangentPoint_Offset;

	private static bool GetBeamSourceTangent_ReturnValue_IsValid;

	private static FFieldAddress GetBeamSourceTangent_ReturnValue_PropertyAddress;

	private static int GetBeamSourceTangent_ReturnValue_Offset;

	private static bool GetBeamSourceStrength_IsValid;

	private static IntPtr GetBeamSourceStrength_FunctionAddress;

	private static int GetBeamSourceStrength_ParamsSize;

	private static bool GetBeamSourceStrength_EmitterIndex_IsValid;

	private static FFieldAddress GetBeamSourceStrength_EmitterIndex_PropertyAddress;

	private static int GetBeamSourceStrength_EmitterIndex_Offset;

	private static bool GetBeamSourceStrength_SourceIndex_IsValid;

	private static FFieldAddress GetBeamSourceStrength_SourceIndex_PropertyAddress;

	private static int GetBeamSourceStrength_SourceIndex_Offset;

	private static bool GetBeamSourceStrength_OutSourceStrength_IsValid;

	private static FFieldAddress GetBeamSourceStrength_OutSourceStrength_PropertyAddress;

	private static int GetBeamSourceStrength_OutSourceStrength_Offset;

	private static bool GetBeamSourceStrength_ReturnValue_IsValid;

	private static FFieldAddress GetBeamSourceStrength_ReturnValue_PropertyAddress;

	private static int GetBeamSourceStrength_ReturnValue_Offset;

	private static bool GetBeamSourcePoint_IsValid;

	private static IntPtr GetBeamSourcePoint_FunctionAddress;

	private static int GetBeamSourcePoint_ParamsSize;

	private static bool GetBeamSourcePoint_EmitterIndex_IsValid;

	private static FFieldAddress GetBeamSourcePoint_EmitterIndex_PropertyAddress;

	private static int GetBeamSourcePoint_EmitterIndex_Offset;

	private static bool GetBeamSourcePoint_SourceIndex_IsValid;

	private static FFieldAddress GetBeamSourcePoint_SourceIndex_PropertyAddress;

	private static int GetBeamSourcePoint_SourceIndex_Offset;

	private static bool GetBeamSourcePoint_OutSourcePoint_IsValid;

	private static FFieldAddress GetBeamSourcePoint_OutSourcePoint_PropertyAddress;

	private static int GetBeamSourcePoint_OutSourcePoint_Offset;

	private static bool GetBeamSourcePoint_ReturnValue_IsValid;

	private static FFieldAddress GetBeamSourcePoint_ReturnValue_PropertyAddress;

	private static int GetBeamSourcePoint_ReturnValue_Offset;

	private static bool GetBeamEndPoint_IsValid;

	private static IntPtr GetBeamEndPoint_FunctionAddress;

	private static int GetBeamEndPoint_ParamsSize;

	private static bool GetBeamEndPoint_EmitterIndex_IsValid;

	private static FFieldAddress GetBeamEndPoint_EmitterIndex_PropertyAddress;

	private static int GetBeamEndPoint_EmitterIndex_Offset;

	private static bool GetBeamEndPoint_OutEndPoint_IsValid;

	private static FFieldAddress GetBeamEndPoint_OutEndPoint_PropertyAddress;

	private static int GetBeamEndPoint_OutEndPoint_Offset;

	private static bool GetBeamEndPoint_ReturnValue_IsValid;

	private static FFieldAddress GetBeamEndPoint_ReturnValue_PropertyAddress;

	private static int GetBeamEndPoint_ReturnValue_Offset;

	private static bool GenerateParticleEvent_IsValid;

	private static IntPtr GenerateParticleEvent_FunctionAddress;

	private static int GenerateParticleEvent_ParamsSize;

	private static bool GenerateParticleEvent_InEventName_IsValid;

	private static FFieldAddress GenerateParticleEvent_InEventName_PropertyAddress;

	private static int GenerateParticleEvent_InEventName_Offset;

	private static bool GenerateParticleEvent_InEmitterTime_IsValid;

	private static FFieldAddress GenerateParticleEvent_InEmitterTime_PropertyAddress;

	private static int GenerateParticleEvent_InEmitterTime_Offset;

	private static bool GenerateParticleEvent_InLocation_IsValid;

	private static FFieldAddress GenerateParticleEvent_InLocation_PropertyAddress;

	private static int GenerateParticleEvent_InLocation_Offset;

	private static bool GenerateParticleEvent_InDirection_IsValid;

	private static FFieldAddress GenerateParticleEvent_InDirection_PropertyAddress;

	private static int GenerateParticleEvent_InDirection_Offset;

	private static bool GenerateParticleEvent_InVelocity_IsValid;

	private static FFieldAddress GenerateParticleEvent_InVelocity_PropertyAddress;

	private static int GenerateParticleEvent_InVelocity_Offset;

	private static bool EndTrails_IsValid;

	private static IntPtr EndTrails_FunctionAddress;

	private static int EndTrails_ParamsSize;

	private static bool CreateNamedDynamicMaterialInstance_IsValid;

	private static IntPtr CreateNamedDynamicMaterialInstance_FunctionAddress;

	private static int CreateNamedDynamicMaterialInstance_ParamsSize;

	private static bool CreateNamedDynamicMaterialInstance_InName_IsValid;

	private static FFieldAddress CreateNamedDynamicMaterialInstance_InName_PropertyAddress;

	private static int CreateNamedDynamicMaterialInstance_InName_Offset;

	private static bool CreateNamedDynamicMaterialInstance_SourceMaterial_IsValid;

	private static FFieldAddress CreateNamedDynamicMaterialInstance_SourceMaterial_PropertyAddress;

	private static int CreateNamedDynamicMaterialInstance_SourceMaterial_Offset;

	private static bool CreateNamedDynamicMaterialInstance_ReturnValue_IsValid;

	private static FFieldAddress CreateNamedDynamicMaterialInstance_ReturnValue_PropertyAddress;

	private static int CreateNamedDynamicMaterialInstance_ReturnValue_Offset;

	private static bool BeginTrails_IsValid;

	private static IntPtr BeginTrails_FunctionAddress;

	private static int BeginTrails_ParamsSize;

	private static bool BeginTrails_InFirstSocketName_IsValid;

	private static FFieldAddress BeginTrails_InFirstSocketName_PropertyAddress;

	private static int BeginTrails_InFirstSocketName_Offset;

	private static bool BeginTrails_InSecondSocketName_IsValid;

	private static FFieldAddress BeginTrails_InSecondSocketName_PropertyAddress;

	private static int BeginTrails_InSecondSocketName_Offset;

	private static bool BeginTrails_InWidthMode_IsValid;

	private static FFieldAddress BeginTrails_InWidthMode_PropertyAddress;

	private static int BeginTrails_InWidthMode_Offset;

	private static bool BeginTrails_InWidth_IsValid;

	private static FFieldAddress BeginTrails_InWidth_PropertyAddress;

	private static int BeginTrails_InWidth_Offset;

	[UProperty(Flags = (PropFlags)7881369141117461uL)]
	[UMetaPath("/Script/Engine.ParticleSystemComponent:Template")]
	public UParticleSystem Template
	{
		get
		{
			CheckDestroyed();
			if (!Template_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ParticleSystemComponent:Template");
				return null;
			}
			return UObjectMarshaler<UParticleSystem>.FromNative(IntPtr.Add(base.Address, Template_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Template_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ParticleSystemComponent:Template");
			}
			else
			{
				UObjectMarshaler<UParticleSystem>.ToNative(IntPtr.Add(base.Address, Template_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.ParticleSystemComponent:bResetOnDetach")]
	public bool ResetOnDetach
	{
		get
		{
			CheckDestroyed();
			if (!ResetOnDetach_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ParticleSystemComponent:bResetOnDetach");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ResetOnDetach_Offset), 0, ResetOnDetach_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ResetOnDetach_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ParticleSystemComponent:bResetOnDetach");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ResetOnDetach_Offset), 0, ResetOnDetach_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043589uL)]
	[UMetaPath("/Script/Engine.ParticleSystemComponent:bAllowRecycling")]
	public bool AllowRecycling
	{
		get
		{
			CheckDestroyed();
			if (!AllowRecycling_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ParticleSystemComponent:bAllowRecycling");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AllowRecycling_Offset), 0, AllowRecycling_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AllowRecycling_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ParticleSystemComponent:bAllowRecycling");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AllowRecycling_Offset), 0, AllowRecycling_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.ParticleSystemComponent:bAutoManageAttachment")]
	public bool AutoManageAttachment
	{
		get
		{
			CheckDestroyed();
			if (!AutoManageAttachment_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ParticleSystemComponent:bAutoManageAttachment");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AutoManageAttachment_Offset), 0, AutoManageAttachment_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AutoManageAttachment_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ParticleSystemComponent:bAutoManageAttachment");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AutoManageAttachment_Offset), 0, AutoManageAttachment_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.ParticleSystemComponent:bAutoAttachWeldSimulatedBodies")]
	public bool AutoAttachWeldSimulatedBodies
	{
		get
		{
			CheckDestroyed();
			if (!AutoAttachWeldSimulatedBodies_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ParticleSystemComponent:bAutoAttachWeldSimulatedBodies");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AutoAttachWeldSimulatedBodies_Offset), 0, AutoAttachWeldSimulatedBodies_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AutoAttachWeldSimulatedBodies_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ParticleSystemComponent:bAutoAttachWeldSimulatedBodies");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AutoAttachWeldSimulatedBodies_Offset), 0, AutoAttachWeldSimulatedBodies_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.ParticleSystemComponent:bOverrideLODMethod")]
	public bool OverrideLODMethod
	{
		get
		{
			CheckDestroyed();
			if (!OverrideLODMethod_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ParticleSystemComponent:bOverrideLODMethod");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, OverrideLODMethod_Offset), 0, OverrideLODMethod_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!OverrideLODMethod_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ParticleSystemComponent:bOverrideLODMethod");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, OverrideLODMethod_Offset), 0, OverrideLODMethod_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.ParticleSystemComponent:bRenderInTranslucencyUpscaledRTPass")]
	public bool RenderInTranslucencyUpscaledRTPass
	{
		get
		{
			CheckDestroyed();
			if (!RenderInTranslucencyUpscaledRTPass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ParticleSystemComponent:bRenderInTranslucencyUpscaledRTPass");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, RenderInTranslucencyUpscaledRTPass_Offset), 0, RenderInTranslucencyUpscaledRTPass_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!RenderInTranslucencyUpscaledRTPass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ParticleSystemComponent:bRenderInTranslucencyUpscaledRTPass");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, RenderInTranslucencyUpscaledRTPass_Offset), 0, RenderInTranslucencyUpscaledRTPass_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.ParticleSystemComponent:LODMethod")]
	public EParticleSystemLODMethod LODMethod
	{
		get
		{
			CheckDestroyed();
			if (!LODMethod_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ParticleSystemComponent:LODMethod");
				return EParticleSystemLODMethod.PARTICLESYSTEMLODMETHOD_Automatic;
			}
			return EnumMarshaler<EParticleSystemLODMethod>.FromNative(IntPtr.Add(base.Address, LODMethod_Offset), 0, LODMethod_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!LODMethod_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ParticleSystemComponent:LODMethod");
			}
			else
			{
				EnumMarshaler<EParticleSystemLODMethod>.ToNative(IntPtr.Add(base.Address, LODMethod_Offset), 0, LODMethod_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/Engine.ParticleSystemComponent:InstanceParameters")]
	public TArrayReadWrite<FParticleSysParam> InstanceParameters
	{
		get
		{
			CheckDestroyed();
			if (!InstanceParameters_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ParticleSystemComponent:InstanceParameters");
				return null;
			}
			if (InstanceParameters_MarshalerCached == null)
			{
				InstanceParameters_MarshalerCached = new TArrayReadWriteMarshaler<FParticleSysParam>(1, InstanceParameters_PropertyAddress, CachedMarshalingDelegates<FParticleSysParam, FParticleSysParam>.FromNative, CachedMarshalingDelegates<FParticleSysParam, FParticleSysParam>.ToNative);
			}
			return InstanceParameters_MarshalerCached.FromNative(IntPtr.Add(base.Address, InstanceParameters_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Engine.ParticleSystemComponent:OnParticleSpawn")]
	public FParticleSpawnSignature OnParticleSpawn
	{
		get
		{
			CheckDestroyed();
			if (!OnParticleSpawn_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ParticleSystemComponent:OnParticleSpawn");
				return new FParticleSpawnSignature();
			}
			if (OnParticleSpawn_DelegateCached == null)
			{
				OnParticleSpawn_DelegateCached = new FParticleSpawnSignature();
				OnParticleSpawn_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnParticleSpawn_Offset));
			}
			return OnParticleSpawn_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Engine.ParticleSystemComponent:OnParticleBurst")]
	public FParticleBurstSignature OnParticleBurst
	{
		get
		{
			CheckDestroyed();
			if (!OnParticleBurst_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ParticleSystemComponent:OnParticleBurst");
				return new FParticleBurstSignature();
			}
			if (OnParticleBurst_DelegateCached == null)
			{
				OnParticleBurst_DelegateCached = new FParticleBurstSignature();
				OnParticleBurst_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnParticleBurst_Offset));
			}
			return OnParticleBurst_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Engine.ParticleSystemComponent:OnParticleDeath")]
	public FParticleDeathSignature OnParticleDeath
	{
		get
		{
			CheckDestroyed();
			if (!OnParticleDeath_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ParticleSystemComponent:OnParticleDeath");
				return new FParticleDeathSignature();
			}
			if (OnParticleDeath_DelegateCached == null)
			{
				OnParticleDeath_DelegateCached = new FParticleDeathSignature();
				OnParticleDeath_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnParticleDeath_Offset));
			}
			return OnParticleDeath_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Engine.ParticleSystemComponent:OnParticleCollide")]
	public FParticleCollisionSignature OnParticleCollide
	{
		get
		{
			CheckDestroyed();
			if (!OnParticleCollide_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ParticleSystemComponent:OnParticleCollide");
				return new FParticleCollisionSignature();
			}
			if (OnParticleCollide_DelegateCached == null)
			{
				OnParticleCollide_DelegateCached = new FParticleCollisionSignature();
				OnParticleCollide_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnParticleCollide_Offset));
			}
			return OnParticleCollide_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.ParticleSystemComponent:SecondsBeforeInactive")]
	public float SecondsBeforeInactive
	{
		get
		{
			CheckDestroyed();
			if (!SecondsBeforeInactive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ParticleSystemComponent:SecondsBeforeInactive");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SecondsBeforeInactive_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SecondsBeforeInactive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ParticleSystemComponent:SecondsBeforeInactive");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SecondsBeforeInactive_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.ParticleSystemComponent:CustomTimeDilation")]
	public float CustomTimeDilation
	{
		get
		{
			CheckDestroyed();
			if (!CustomTimeDilation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ParticleSystemComponent:CustomTimeDilation");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CustomTimeDilation_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CustomTimeDilation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ParticleSystemComponent:CustomTimeDilation");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CustomTimeDilation_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141774861uL)]
	[UMetaPath("/Script/Engine.ParticleSystemComponent:AutoAttachParent")]
	public TWeakObject<USceneComponent> AutoAttachParent
	{
		get
		{
			CheckDestroyed();
			if (!AutoAttachParent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ParticleSystemComponent:AutoAttachParent");
				return default(TWeakObject<USceneComponent>);
			}
			return TWeakObjectMarshaler<USceneComponent>.FromNative(IntPtr.Add(base.Address, AutoAttachParent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AutoAttachParent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ParticleSystemComponent:AutoAttachParent");
			}
			else
			{
				TWeakObjectMarshaler<USceneComponent>.ToNative(IntPtr.Add(base.Address, AutoAttachParent_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.ParticleSystemComponent:AutoAttachSocketName")]
	public FName AutoAttachSocketName
	{
		get
		{
			CheckDestroyed();
			if (!AutoAttachSocketName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ParticleSystemComponent:AutoAttachSocketName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, AutoAttachSocketName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AutoAttachSocketName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ParticleSystemComponent:AutoAttachSocketName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, AutoAttachSocketName_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.ParticleSystemComponent:AutoAttachLocationRule")]
	public EAttachmentRule AutoAttachLocationRule
	{
		get
		{
			CheckDestroyed();
			if (!AutoAttachLocationRule_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ParticleSystemComponent:AutoAttachLocationRule");
				return EAttachmentRule.KeepRelative;
			}
			return EnumMarshaler<EAttachmentRule>.FromNative(IntPtr.Add(base.Address, AutoAttachLocationRule_Offset), 0, AutoAttachLocationRule_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AutoAttachLocationRule_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ParticleSystemComponent:AutoAttachLocationRule");
			}
			else
			{
				EnumMarshaler<EAttachmentRule>.ToNative(IntPtr.Add(base.Address, AutoAttachLocationRule_Offset), 0, AutoAttachLocationRule_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.ParticleSystemComponent:AutoAttachRotationRule")]
	public EAttachmentRule AutoAttachRotationRule
	{
		get
		{
			CheckDestroyed();
			if (!AutoAttachRotationRule_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ParticleSystemComponent:AutoAttachRotationRule");
				return EAttachmentRule.KeepRelative;
			}
			return EnumMarshaler<EAttachmentRule>.FromNative(IntPtr.Add(base.Address, AutoAttachRotationRule_Offset), 0, AutoAttachRotationRule_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AutoAttachRotationRule_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ParticleSystemComponent:AutoAttachRotationRule");
			}
			else
			{
				EnumMarshaler<EAttachmentRule>.ToNative(IntPtr.Add(base.Address, AutoAttachRotationRule_Offset), 0, AutoAttachRotationRule_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.ParticleSystemComponent:AutoAttachScaleRule")]
	public EAttachmentRule AutoAttachScaleRule
	{
		get
		{
			CheckDestroyed();
			if (!AutoAttachScaleRule_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ParticleSystemComponent:AutoAttachScaleRule");
				return EAttachmentRule.KeepRelative;
			}
			return EnumMarshaler<EAttachmentRule>.FromNative(IntPtr.Add(base.Address, AutoAttachScaleRule_Offset), 0, AutoAttachScaleRule_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AutoAttachScaleRule_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ParticleSystemComponent:AutoAttachScaleRule");
			}
			else
			{
				EnumMarshaler<EAttachmentRule>.ToNative(IntPtr.Add(base.Address, AutoAttachScaleRule_Offset), 0, AutoAttachScaleRule_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Engine.ParticleSystemComponent:OnSystemFinished")]
	public FOnSystemFinished OnSystemFinished
	{
		get
		{
			CheckDestroyed();
			if (!OnSystemFinished_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ParticleSystemComponent:OnSystemFinished");
				return new FOnSystemFinished();
			}
			if (OnSystemFinished_DelegateCached == null)
			{
				OnSystemFinished_DelegateCached = new FOnSystemFinished();
				OnSystemFinished_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnSystemFinished_Offset));
			}
			return OnSystemFinished_DelegateCached;
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.ParticleSystemComponent:SetTrailSourceData")]
	public unsafe void SetTrailSourceData(FName InFirstSocketName, FName InSecondSocketName, ETrailWidthMode InWidthMode, float InWidth)
	{
		CheckDestroyed();
		if (!SetTrailSourceData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ParticleSystemComponent:SetTrailSourceData");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTrailSourceData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTrailSourceData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetTrailSourceData_InFirstSocketName_Offset), 0, SetTrailSourceData_InFirstSocketName_PropertyAddress.Address, InFirstSocketName);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetTrailSourceData_InSecondSocketName_Offset), 0, SetTrailSourceData_InSecondSocketName_PropertyAddress.Address, InSecondSocketName);
		EnumMarshaler<ETrailWidthMode>.ToNative(IntPtr.Add(intPtr, SetTrailSourceData_InWidthMode_Offset), 0, SetTrailSourceData_InWidthMode_PropertyAddress.Address, InWidthMode);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetTrailSourceData_InWidth_Offset), 0, SetTrailSourceData_InWidth_PropertyAddress.Address, InWidth);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetTrailSourceData_FunctionAddress, intPtr, SetTrailSourceData_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.ParticleSystemComponent:SetTemplate")]
	public unsafe void SetTemplate(UParticleSystem NewTemplate)
	{
		CheckDestroyed();
		if (!SetTemplate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ParticleSystemComponent:SetTemplate");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTemplate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTemplate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UParticleSystem>.ToNative(IntPtr.Add(intPtr, SetTemplate_NewTemplate_Offset), 0, SetTemplate_NewTemplate_PropertyAddress.Address, NewTemplate);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetTemplate_FunctionAddress, intPtr, SetTemplate_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.ParticleSystemComponent:SetMaterialParameter")]
	public unsafe void SetMaterialParameter(FName ParameterName, UMaterialInterface Param)
	{
		CheckDestroyed();
		if (!SetMaterialParameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ParticleSystemComponent:SetMaterialParameter");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMaterialParameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMaterialParameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetMaterialParameter_ParameterName_Offset), 0, SetMaterialParameter_ParameterName_PropertyAddress.Address, ParameterName);
		UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(intPtr, SetMaterialParameter_Param_Offset), 0, SetMaterialParameter_Param_PropertyAddress.Address, Param);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetMaterialParameter_FunctionAddress, intPtr, SetMaterialParameter_ParamsSize);
	}

	[UFunction(Flags = 75629568u)]
	[UMetaPath("/Script/Engine.ParticleSystemComponent:SetBeamTargetTangent")]
	public unsafe void SetBeamTargetTangent(int EmitterIndex, FVector NewTangentPoint, int TargetIndex)
	{
		CheckDestroyed();
		if (!SetBeamTargetTangent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ParticleSystemComponent:SetBeamTargetTangent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBeamTargetTangent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBeamTargetTangent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetBeamTargetTangent_EmitterIndex_Offset), 0, SetBeamTargetTangent_EmitterIndex_PropertyAddress.Address, EmitterIndex);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetBeamTargetTangent_NewTangentPoint_Offset), 0, SetBeamTargetTangent_NewTangentPoint_PropertyAddress.Address, NewTangentPoint);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetBeamTargetTangent_TargetIndex_Offset), 0, SetBeamTargetTangent_TargetIndex_PropertyAddress.Address, TargetIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetBeamTargetTangent_FunctionAddress, intPtr, SetBeamTargetTangent_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.ParticleSystemComponent:SetBeamTargetStrength")]
	public unsafe void SetBeamTargetStrength(int EmitterIndex, float NewTargetStrength, int TargetIndex)
	{
		CheckDestroyed();
		if (!SetBeamTargetStrength_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ParticleSystemComponent:SetBeamTargetStrength");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBeamTargetStrength_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBeamTargetStrength_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetBeamTargetStrength_EmitterIndex_Offset), 0, SetBeamTargetStrength_EmitterIndex_PropertyAddress.Address, EmitterIndex);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetBeamTargetStrength_NewTargetStrength_Offset), 0, SetBeamTargetStrength_NewTargetStrength_PropertyAddress.Address, NewTargetStrength);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetBeamTargetStrength_TargetIndex_Offset), 0, SetBeamTargetStrength_TargetIndex_PropertyAddress.Address, TargetIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetBeamTargetStrength_FunctionAddress, intPtr, SetBeamTargetStrength_ParamsSize);
	}

	[UFunction(Flags = 75629568u)]
	[UMetaPath("/Script/Engine.ParticleSystemComponent:SetBeamTargetPoint")]
	public unsafe void SetBeamTargetPoint(int EmitterIndex, FVector NewTargetPoint, int TargetIndex)
	{
		CheckDestroyed();
		if (!SetBeamTargetPoint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ParticleSystemComponent:SetBeamTargetPoint");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBeamTargetPoint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBeamTargetPoint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetBeamTargetPoint_EmitterIndex_Offset), 0, SetBeamTargetPoint_EmitterIndex_PropertyAddress.Address, EmitterIndex);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetBeamTargetPoint_NewTargetPoint_Offset), 0, SetBeamTargetPoint_NewTargetPoint_PropertyAddress.Address, NewTargetPoint);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetBeamTargetPoint_TargetIndex_Offset), 0, SetBeamTargetPoint_TargetIndex_PropertyAddress.Address, TargetIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetBeamTargetPoint_FunctionAddress, intPtr, SetBeamTargetPoint_ParamsSize);
	}

	[UFunction(Flags = 75629568u)]
	[UMetaPath("/Script/Engine.ParticleSystemComponent:SetBeamSourceTangent")]
	public unsafe void SetBeamSourceTangent(int EmitterIndex, FVector NewTangentPoint, int SourceIndex)
	{
		CheckDestroyed();
		if (!SetBeamSourceTangent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ParticleSystemComponent:SetBeamSourceTangent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBeamSourceTangent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBeamSourceTangent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetBeamSourceTangent_EmitterIndex_Offset), 0, SetBeamSourceTangent_EmitterIndex_PropertyAddress.Address, EmitterIndex);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetBeamSourceTangent_NewTangentPoint_Offset), 0, SetBeamSourceTangent_NewTangentPoint_PropertyAddress.Address, NewTangentPoint);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetBeamSourceTangent_SourceIndex_Offset), 0, SetBeamSourceTangent_SourceIndex_PropertyAddress.Address, SourceIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetBeamSourceTangent_FunctionAddress, intPtr, SetBeamSourceTangent_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.ParticleSystemComponent:SetBeamSourceStrength")]
	public unsafe void SetBeamSourceStrength(int EmitterIndex, float NewSourceStrength, int SourceIndex)
	{
		CheckDestroyed();
		if (!SetBeamSourceStrength_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ParticleSystemComponent:SetBeamSourceStrength");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBeamSourceStrength_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBeamSourceStrength_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetBeamSourceStrength_EmitterIndex_Offset), 0, SetBeamSourceStrength_EmitterIndex_PropertyAddress.Address, EmitterIndex);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetBeamSourceStrength_NewSourceStrength_Offset), 0, SetBeamSourceStrength_NewSourceStrength_PropertyAddress.Address, NewSourceStrength);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetBeamSourceStrength_SourceIndex_Offset), 0, SetBeamSourceStrength_SourceIndex_PropertyAddress.Address, SourceIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetBeamSourceStrength_FunctionAddress, intPtr, SetBeamSourceStrength_ParamsSize);
	}

	[UFunction(Flags = 75629568u)]
	[UMetaPath("/Script/Engine.ParticleSystemComponent:SetBeamSourcePoint")]
	public unsafe void SetBeamSourcePoint(int EmitterIndex, FVector NewSourcePoint, int SourceIndex)
	{
		CheckDestroyed();
		if (!SetBeamSourcePoint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ParticleSystemComponent:SetBeamSourcePoint");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBeamSourcePoint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBeamSourcePoint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetBeamSourcePoint_EmitterIndex_Offset), 0, SetBeamSourcePoint_EmitterIndex_PropertyAddress.Address, EmitterIndex);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetBeamSourcePoint_NewSourcePoint_Offset), 0, SetBeamSourcePoint_NewSourcePoint_PropertyAddress.Address, NewSourcePoint);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetBeamSourcePoint_SourceIndex_Offset), 0, SetBeamSourcePoint_SourceIndex_PropertyAddress.Address, SourceIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetBeamSourcePoint_FunctionAddress, intPtr, SetBeamSourcePoint_ParamsSize);
	}

	[UFunction(Flags = 75629568u)]
	[UMetaPath("/Script/Engine.ParticleSystemComponent:SetBeamEndPoint")]
	public unsafe void SetBeamEndPoint(int EmitterIndex, FVector NewEndPoint)
	{
		CheckDestroyed();
		if (!SetBeamEndPoint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ParticleSystemComponent:SetBeamEndPoint");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBeamEndPoint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBeamEndPoint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetBeamEndPoint_EmitterIndex_Offset), 0, SetBeamEndPoint_EmitterIndex_PropertyAddress.Address, EmitterIndex);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetBeamEndPoint_NewEndPoint_Offset), 0, SetBeamEndPoint_NewEndPoint_PropertyAddress.Address, NewEndPoint);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetBeamEndPoint_FunctionAddress, intPtr, SetBeamEndPoint_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.ParticleSystemComponent:GetNumActiveParticles")]
	public unsafe int GetNumActiveParticles()
	{
		CheckDestroyed();
		if (!GetNumActiveParticles_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ParticleSystemComponent:GetNumActiveParticles");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNumActiveParticles_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNumActiveParticles_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNumActiveParticles_FunctionAddress, intPtr, GetNumActiveParticles_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetNumActiveParticles_ReturnValue_Offset), 0, GetNumActiveParticles_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.ParticleSystemComponent:GetNamedMaterial")]
	public unsafe UMaterialInterface GetNamedMaterial(FName InName)
	{
		CheckDestroyed();
		if (!GetNamedMaterial_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ParticleSystemComponent:GetNamedMaterial");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNamedMaterial_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNamedMaterial_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetNamedMaterial_InName_Offset), 0, GetNamedMaterial_InName_PropertyAddress.Address, InName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNamedMaterial_FunctionAddress, intPtr, GetNamedMaterial_ParamsSize);
		return UObjectMarshaler<UMaterialInterface>.FromNative(IntPtr.Add(intPtr, GetNamedMaterial_ReturnValue_Offset), 0, GetNamedMaterial_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1422001152u)]
	[UMetaPath("/Script/Engine.ParticleSystemComponent:GetBeamTargetTangent")]
	public unsafe bool GetBeamTargetTangent(int EmitterIndex, int TargetIndex, out FVector OutTangentPoint)
	{
		CheckDestroyed();
		if (!GetBeamTargetTangent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ParticleSystemComponent:GetBeamTargetTangent");
			OutTangentPoint = default(FVector);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBeamTargetTangent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBeamTargetTangent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetBeamTargetTangent_EmitterIndex_Offset), 0, GetBeamTargetTangent_EmitterIndex_PropertyAddress.Address, EmitterIndex);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetBeamTargetTangent_TargetIndex_Offset), 0, GetBeamTargetTangent_TargetIndex_PropertyAddress.Address, TargetIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetBeamTargetTangent_FunctionAddress, intPtr, GetBeamTargetTangent_ParamsSize);
		OutTangentPoint = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetBeamTargetTangent_OutTangentPoint_Offset), 0, GetBeamTargetTangent_OutTangentPoint_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetBeamTargetTangent_ReturnValue_Offset), 0, GetBeamTargetTangent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612544u)]
	[UMetaPath("/Script/Engine.ParticleSystemComponent:GetBeamTargetStrength")]
	public unsafe bool GetBeamTargetStrength(int EmitterIndex, int TargetIndex, out float OutTargetStrength)
	{
		CheckDestroyed();
		if (!GetBeamTargetStrength_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ParticleSystemComponent:GetBeamTargetStrength");
			OutTargetStrength = 0f;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBeamTargetStrength_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBeamTargetStrength_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetBeamTargetStrength_EmitterIndex_Offset), 0, GetBeamTargetStrength_EmitterIndex_PropertyAddress.Address, EmitterIndex);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetBeamTargetStrength_TargetIndex_Offset), 0, GetBeamTargetStrength_TargetIndex_PropertyAddress.Address, TargetIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetBeamTargetStrength_FunctionAddress, intPtr, GetBeamTargetStrength_ParamsSize);
		OutTargetStrength = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetBeamTargetStrength_OutTargetStrength_Offset), 0, GetBeamTargetStrength_OutTargetStrength_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetBeamTargetStrength_ReturnValue_Offset), 0, GetBeamTargetStrength_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1422001152u)]
	[UMetaPath("/Script/Engine.ParticleSystemComponent:GetBeamTargetPoint")]
	public unsafe bool GetBeamTargetPoint(int EmitterIndex, int TargetIndex, out FVector OutTargetPoint)
	{
		CheckDestroyed();
		if (!GetBeamTargetPoint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ParticleSystemComponent:GetBeamTargetPoint");
			OutTargetPoint = default(FVector);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBeamTargetPoint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBeamTargetPoint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetBeamTargetPoint_EmitterIndex_Offset), 0, GetBeamTargetPoint_EmitterIndex_PropertyAddress.Address, EmitterIndex);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetBeamTargetPoint_TargetIndex_Offset), 0, GetBeamTargetPoint_TargetIndex_PropertyAddress.Address, TargetIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetBeamTargetPoint_FunctionAddress, intPtr, GetBeamTargetPoint_ParamsSize);
		OutTargetPoint = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetBeamTargetPoint_OutTargetPoint_Offset), 0, GetBeamTargetPoint_OutTargetPoint_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetBeamTargetPoint_ReturnValue_Offset), 0, GetBeamTargetPoint_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1422001152u)]
	[UMetaPath("/Script/Engine.ParticleSystemComponent:GetBeamSourceTangent")]
	public unsafe bool GetBeamSourceTangent(int EmitterIndex, int SourceIndex, out FVector OutTangentPoint)
	{
		CheckDestroyed();
		if (!GetBeamSourceTangent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ParticleSystemComponent:GetBeamSourceTangent");
			OutTangentPoint = default(FVector);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBeamSourceTangent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBeamSourceTangent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetBeamSourceTangent_EmitterIndex_Offset), 0, GetBeamSourceTangent_EmitterIndex_PropertyAddress.Address, EmitterIndex);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetBeamSourceTangent_SourceIndex_Offset), 0, GetBeamSourceTangent_SourceIndex_PropertyAddress.Address, SourceIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetBeamSourceTangent_FunctionAddress, intPtr, GetBeamSourceTangent_ParamsSize);
		OutTangentPoint = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetBeamSourceTangent_OutTangentPoint_Offset), 0, GetBeamSourceTangent_OutTangentPoint_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetBeamSourceTangent_ReturnValue_Offset), 0, GetBeamSourceTangent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612544u)]
	[UMetaPath("/Script/Engine.ParticleSystemComponent:GetBeamSourceStrength")]
	public unsafe bool GetBeamSourceStrength(int EmitterIndex, int SourceIndex, out float OutSourceStrength)
	{
		CheckDestroyed();
		if (!GetBeamSourceStrength_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ParticleSystemComponent:GetBeamSourceStrength");
			OutSourceStrength = 0f;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBeamSourceStrength_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBeamSourceStrength_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetBeamSourceStrength_EmitterIndex_Offset), 0, GetBeamSourceStrength_EmitterIndex_PropertyAddress.Address, EmitterIndex);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetBeamSourceStrength_SourceIndex_Offset), 0, GetBeamSourceStrength_SourceIndex_PropertyAddress.Address, SourceIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetBeamSourceStrength_FunctionAddress, intPtr, GetBeamSourceStrength_ParamsSize);
		OutSourceStrength = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetBeamSourceStrength_OutSourceStrength_Offset), 0, GetBeamSourceStrength_OutSourceStrength_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetBeamSourceStrength_ReturnValue_Offset), 0, GetBeamSourceStrength_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1422001152u)]
	[UMetaPath("/Script/Engine.ParticleSystemComponent:GetBeamSourcePoint")]
	public unsafe bool GetBeamSourcePoint(int EmitterIndex, int SourceIndex, out FVector OutSourcePoint)
	{
		CheckDestroyed();
		if (!GetBeamSourcePoint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ParticleSystemComponent:GetBeamSourcePoint");
			OutSourcePoint = default(FVector);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBeamSourcePoint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBeamSourcePoint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetBeamSourcePoint_EmitterIndex_Offset), 0, GetBeamSourcePoint_EmitterIndex_PropertyAddress.Address, EmitterIndex);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetBeamSourcePoint_SourceIndex_Offset), 0, GetBeamSourcePoint_SourceIndex_PropertyAddress.Address, SourceIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetBeamSourcePoint_FunctionAddress, intPtr, GetBeamSourcePoint_ParamsSize);
		OutSourcePoint = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetBeamSourcePoint_OutSourcePoint_Offset), 0, GetBeamSourcePoint_OutSourcePoint_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetBeamSourcePoint_ReturnValue_Offset), 0, GetBeamSourcePoint_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1422001152u)]
	[UMetaPath("/Script/Engine.ParticleSystemComponent:GetBeamEndPoint")]
	public unsafe bool GetBeamEndPoint(int EmitterIndex, out FVector OutEndPoint)
	{
		CheckDestroyed();
		if (!GetBeamEndPoint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ParticleSystemComponent:GetBeamEndPoint");
			OutEndPoint = default(FVector);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBeamEndPoint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBeamEndPoint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetBeamEndPoint_EmitterIndex_Offset), 0, GetBeamEndPoint_EmitterIndex_PropertyAddress.Address, EmitterIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetBeamEndPoint_FunctionAddress, intPtr, GetBeamEndPoint_ParamsSize);
		OutEndPoint = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetBeamEndPoint_OutEndPoint_Offset), 0, GetBeamEndPoint_OutEndPoint_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetBeamEndPoint_ReturnValue_Offset), 0, GetBeamEndPoint_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Engine.ParticleSystemComponent:GenerateParticleEvent")]
	public unsafe void GenerateParticleEvent(FName InEventName, float InEmitterTime, FVector InLocation, FVector InDirection, FVector InVelocity)
	{
		CheckDestroyed();
		if (!GenerateParticleEvent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ParticleSystemComponent:GenerateParticleEvent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GenerateParticleEvent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GenerateParticleEvent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GenerateParticleEvent_InEventName_Offset), 0, GenerateParticleEvent_InEventName_PropertyAddress.Address, InEventName);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GenerateParticleEvent_InEmitterTime_Offset), 0, GenerateParticleEvent_InEmitterTime_PropertyAddress.Address, InEmitterTime);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, GenerateParticleEvent_InLocation_Offset), 0, GenerateParticleEvent_InLocation_PropertyAddress.Address, InLocation);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, GenerateParticleEvent_InDirection_Offset), 0, GenerateParticleEvent_InDirection_PropertyAddress.Address, InDirection);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, GenerateParticleEvent_InVelocity_Offset), 0, GenerateParticleEvent_InVelocity_PropertyAddress.Address, InVelocity);
		NativeReflection.InvokeFunctionOptimized(base.Address, GenerateParticleEvent_FunctionAddress, intPtr, GenerateParticleEvent_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.ParticleSystemComponent:EndTrails")]
	public unsafe void EndTrails()
	{
		CheckDestroyed();
		if (!EndTrails_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ParticleSystemComponent:EndTrails");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EndTrails_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EndTrails_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: EndTrails_FunctionAddress, argsSize: EndTrails_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.ParticleSystemComponent:CreateNamedDynamicMaterialInstance")]
	public unsafe UMaterialInstanceDynamic CreateNamedDynamicMaterialInstance(FName InName, UMaterialInterface SourceMaterial)
	{
		CheckDestroyed();
		if (!CreateNamedDynamicMaterialInstance_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ParticleSystemComponent:CreateNamedDynamicMaterialInstance");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateNamedDynamicMaterialInstance_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateNamedDynamicMaterialInstance_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, CreateNamedDynamicMaterialInstance_InName_Offset), 0, CreateNamedDynamicMaterialInstance_InName_PropertyAddress.Address, InName);
		UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(intPtr, CreateNamedDynamicMaterialInstance_SourceMaterial_Offset), 0, CreateNamedDynamicMaterialInstance_SourceMaterial_PropertyAddress.Address, SourceMaterial);
		NativeReflection.InvokeFunctionOptimized(base.Address, CreateNamedDynamicMaterialInstance_FunctionAddress, intPtr, CreateNamedDynamicMaterialInstance_ParamsSize);
		return UObjectMarshaler<UMaterialInstanceDynamic>.FromNative(IntPtr.Add(intPtr, CreateNamedDynamicMaterialInstance_ReturnValue_Offset), 0, CreateNamedDynamicMaterialInstance_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.ParticleSystemComponent:BeginTrails")]
	public unsafe void BeginTrails(FName InFirstSocketName, FName InSecondSocketName, ETrailWidthMode InWidthMode, float InWidth)
	{
		CheckDestroyed();
		if (!BeginTrails_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ParticleSystemComponent:BeginTrails");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BeginTrails_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BeginTrails_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, BeginTrails_InFirstSocketName_Offset), 0, BeginTrails_InFirstSocketName_PropertyAddress.Address, InFirstSocketName);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, BeginTrails_InSecondSocketName_Offset), 0, BeginTrails_InSecondSocketName_PropertyAddress.Address, InSecondSocketName);
		EnumMarshaler<ETrailWidthMode>.ToNative(IntPtr.Add(intPtr, BeginTrails_InWidthMode_Offset), 0, BeginTrails_InWidthMode_PropertyAddress.Address, InWidthMode);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, BeginTrails_InWidth_Offset), 0, BeginTrails_InWidth_PropertyAddress.Address, InWidth);
		NativeReflection.InvokeFunctionOptimized(base.Address, BeginTrails_FunctionAddress, intPtr, BeginTrails_ParamsSize);
	}

	static UParticleSystemComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UParticleSystemComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UParticleSystemComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.ParticleSystemComponent");
		Template_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Template");
		Template_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Template", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ResetOnDetach_PropertyAddress, intPtr, "bResetOnDetach");
		ResetOnDetach_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bResetOnDetach");
		ResetOnDetach_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bResetOnDetach", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AllowRecycling_PropertyAddress, intPtr, "bAllowRecycling");
		AllowRecycling_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAllowRecycling");
		AllowRecycling_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAllowRecycling", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AutoManageAttachment_PropertyAddress, intPtr, "bAutoManageAttachment");
		AutoManageAttachment_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAutoManageAttachment");
		AutoManageAttachment_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAutoManageAttachment", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AutoAttachWeldSimulatedBodies_PropertyAddress, intPtr, "bAutoAttachWeldSimulatedBodies");
		AutoAttachWeldSimulatedBodies_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAutoAttachWeldSimulatedBodies");
		AutoAttachWeldSimulatedBodies_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAutoAttachWeldSimulatedBodies", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref OverrideLODMethod_PropertyAddress, intPtr, "bOverrideLODMethod");
		OverrideLODMethod_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bOverrideLODMethod");
		OverrideLODMethod_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bOverrideLODMethod", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RenderInTranslucencyUpscaledRTPass_PropertyAddress, intPtr, "bRenderInTranslucencyUpscaledRTPass");
		RenderInTranslucencyUpscaledRTPass_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bRenderInTranslucencyUpscaledRTPass");
		RenderInTranslucencyUpscaledRTPass_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bRenderInTranslucencyUpscaledRTPass", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref LODMethod_PropertyAddress, intPtr, "LODMethod");
		LODMethod_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LODMethod");
		LODMethod_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LODMethod", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref InstanceParameters_PropertyAddress, intPtr, "InstanceParameters");
		InstanceParameters_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InstanceParameters");
		InstanceParameters_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InstanceParameters", Classes.FArrayProperty);
		OnParticleSpawn_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnParticleSpawn");
		OnParticleSpawn_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnParticleSpawn", Classes.FMulticastDelegateProperty);
		OnParticleBurst_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnParticleBurst");
		OnParticleBurst_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnParticleBurst", Classes.FMulticastDelegateProperty);
		OnParticleDeath_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnParticleDeath");
		OnParticleDeath_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnParticleDeath", Classes.FMulticastDelegateProperty);
		OnParticleCollide_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnParticleCollide");
		OnParticleCollide_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnParticleCollide", Classes.FMulticastDelegateProperty);
		SecondsBeforeInactive_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SecondsBeforeInactive");
		SecondsBeforeInactive_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SecondsBeforeInactive", Classes.FFloatProperty);
		CustomTimeDilation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CustomTimeDilation");
		CustomTimeDilation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CustomTimeDilation", Classes.FFloatProperty);
		AutoAttachParent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AutoAttachParent");
		AutoAttachParent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AutoAttachParent", Classes.FWeakObjectProperty);
		AutoAttachSocketName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AutoAttachSocketName");
		AutoAttachSocketName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AutoAttachSocketName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AutoAttachLocationRule_PropertyAddress, intPtr, "AutoAttachLocationRule");
		AutoAttachLocationRule_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AutoAttachLocationRule");
		AutoAttachLocationRule_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AutoAttachLocationRule", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref AutoAttachRotationRule_PropertyAddress, intPtr, "AutoAttachRotationRule");
		AutoAttachRotationRule_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AutoAttachRotationRule");
		AutoAttachRotationRule_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AutoAttachRotationRule", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref AutoAttachScaleRule_PropertyAddress, intPtr, "AutoAttachScaleRule");
		AutoAttachScaleRule_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AutoAttachScaleRule");
		AutoAttachScaleRule_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AutoAttachScaleRule", Classes.FEnumProperty);
		OnSystemFinished_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnSystemFinished");
		OnSystemFinished_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnSystemFinished", Classes.FMulticastDelegateProperty);
		SetTrailSourceData_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetTrailSourceData");
		SetTrailSourceData_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTrailSourceData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTrailSourceData_InFirstSocketName_PropertyAddress, SetTrailSourceData_FunctionAddress, "InFirstSocketName");
		SetTrailSourceData_InFirstSocketName_Offset = NativeReflectionCached.GetPropertyOffset(SetTrailSourceData_FunctionAddress, "InFirstSocketName");
		SetTrailSourceData_InFirstSocketName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTrailSourceData_FunctionAddress, "InFirstSocketName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetTrailSourceData_InSecondSocketName_PropertyAddress, SetTrailSourceData_FunctionAddress, "InSecondSocketName");
		SetTrailSourceData_InSecondSocketName_Offset = NativeReflectionCached.GetPropertyOffset(SetTrailSourceData_FunctionAddress, "InSecondSocketName");
		SetTrailSourceData_InSecondSocketName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTrailSourceData_FunctionAddress, "InSecondSocketName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetTrailSourceData_InWidthMode_PropertyAddress, SetTrailSourceData_FunctionAddress, "InWidthMode");
		SetTrailSourceData_InWidthMode_Offset = NativeReflectionCached.GetPropertyOffset(SetTrailSourceData_FunctionAddress, "InWidthMode");
		SetTrailSourceData_InWidthMode_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTrailSourceData_FunctionAddress, "InWidthMode", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref SetTrailSourceData_InWidth_PropertyAddress, SetTrailSourceData_FunctionAddress, "InWidth");
		SetTrailSourceData_InWidth_Offset = NativeReflectionCached.GetPropertyOffset(SetTrailSourceData_FunctionAddress, "InWidth");
		SetTrailSourceData_InWidth_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTrailSourceData_FunctionAddress, "InWidth", Classes.FFloatProperty);
		SetTrailSourceData_IsValid = SetTrailSourceData_FunctionAddress != IntPtr.Zero && SetTrailSourceData_InFirstSocketName_IsValid && SetTrailSourceData_InSecondSocketName_IsValid && SetTrailSourceData_InWidthMode_IsValid && SetTrailSourceData_InWidth_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ParticleSystemComponent:SetTrailSourceData", SetTrailSourceData_IsValid);
		SetTemplate_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetTemplate");
		SetTemplate_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTemplate_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTemplate_NewTemplate_PropertyAddress, SetTemplate_FunctionAddress, "NewTemplate");
		SetTemplate_NewTemplate_Offset = NativeReflectionCached.GetPropertyOffset(SetTemplate_FunctionAddress, "NewTemplate");
		SetTemplate_NewTemplate_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTemplate_FunctionAddress, "NewTemplate", Classes.FObjectProperty);
		SetTemplate_IsValid = SetTemplate_FunctionAddress != IntPtr.Zero && SetTemplate_NewTemplate_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ParticleSystemComponent:SetTemplate", SetTemplate_IsValid);
		SetMaterialParameter_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetMaterialParameter");
		SetMaterialParameter_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMaterialParameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMaterialParameter_ParameterName_PropertyAddress, SetMaterialParameter_FunctionAddress, "ParameterName");
		SetMaterialParameter_ParameterName_Offset = NativeReflectionCached.GetPropertyOffset(SetMaterialParameter_FunctionAddress, "ParameterName");
		SetMaterialParameter_ParameterName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMaterialParameter_FunctionAddress, "ParameterName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMaterialParameter_Param_PropertyAddress, SetMaterialParameter_FunctionAddress, "Param");
		SetMaterialParameter_Param_Offset = NativeReflectionCached.GetPropertyOffset(SetMaterialParameter_FunctionAddress, "Param");
		SetMaterialParameter_Param_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMaterialParameter_FunctionAddress, "Param", Classes.FObjectProperty);
		SetMaterialParameter_IsValid = SetMaterialParameter_FunctionAddress != IntPtr.Zero && SetMaterialParameter_ParameterName_IsValid && SetMaterialParameter_Param_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ParticleSystemComponent:SetMaterialParameter", SetMaterialParameter_IsValid);
		SetBeamTargetTangent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetBeamTargetTangent");
		SetBeamTargetTangent_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBeamTargetTangent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBeamTargetTangent_EmitterIndex_PropertyAddress, SetBeamTargetTangent_FunctionAddress, "EmitterIndex");
		SetBeamTargetTangent_EmitterIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetBeamTargetTangent_FunctionAddress, "EmitterIndex");
		SetBeamTargetTangent_EmitterIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBeamTargetTangent_FunctionAddress, "EmitterIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBeamTargetTangent_NewTangentPoint_PropertyAddress, SetBeamTargetTangent_FunctionAddress, "NewTangentPoint");
		SetBeamTargetTangent_NewTangentPoint_Offset = NativeReflectionCached.GetPropertyOffset(SetBeamTargetTangent_FunctionAddress, "NewTangentPoint");
		SetBeamTargetTangent_NewTangentPoint_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBeamTargetTangent_FunctionAddress, "NewTangentPoint", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBeamTargetTangent_TargetIndex_PropertyAddress, SetBeamTargetTangent_FunctionAddress, "TargetIndex");
		SetBeamTargetTangent_TargetIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetBeamTargetTangent_FunctionAddress, "TargetIndex");
		SetBeamTargetTangent_TargetIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBeamTargetTangent_FunctionAddress, "TargetIndex", Classes.FIntProperty);
		SetBeamTargetTangent_IsValid = SetBeamTargetTangent_FunctionAddress != IntPtr.Zero && SetBeamTargetTangent_EmitterIndex_IsValid && SetBeamTargetTangent_NewTangentPoint_IsValid && SetBeamTargetTangent_TargetIndex_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ParticleSystemComponent:SetBeamTargetTangent", SetBeamTargetTangent_IsValid);
		SetBeamTargetStrength_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetBeamTargetStrength");
		SetBeamTargetStrength_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBeamTargetStrength_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBeamTargetStrength_EmitterIndex_PropertyAddress, SetBeamTargetStrength_FunctionAddress, "EmitterIndex");
		SetBeamTargetStrength_EmitterIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetBeamTargetStrength_FunctionAddress, "EmitterIndex");
		SetBeamTargetStrength_EmitterIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBeamTargetStrength_FunctionAddress, "EmitterIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBeamTargetStrength_NewTargetStrength_PropertyAddress, SetBeamTargetStrength_FunctionAddress, "NewTargetStrength");
		SetBeamTargetStrength_NewTargetStrength_Offset = NativeReflectionCached.GetPropertyOffset(SetBeamTargetStrength_FunctionAddress, "NewTargetStrength");
		SetBeamTargetStrength_NewTargetStrength_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBeamTargetStrength_FunctionAddress, "NewTargetStrength", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBeamTargetStrength_TargetIndex_PropertyAddress, SetBeamTargetStrength_FunctionAddress, "TargetIndex");
		SetBeamTargetStrength_TargetIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetBeamTargetStrength_FunctionAddress, "TargetIndex");
		SetBeamTargetStrength_TargetIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBeamTargetStrength_FunctionAddress, "TargetIndex", Classes.FIntProperty);
		SetBeamTargetStrength_IsValid = SetBeamTargetStrength_FunctionAddress != IntPtr.Zero && SetBeamTargetStrength_EmitterIndex_IsValid && SetBeamTargetStrength_NewTargetStrength_IsValid && SetBeamTargetStrength_TargetIndex_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ParticleSystemComponent:SetBeamTargetStrength", SetBeamTargetStrength_IsValid);
		SetBeamTargetPoint_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetBeamTargetPoint");
		SetBeamTargetPoint_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBeamTargetPoint_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBeamTargetPoint_EmitterIndex_PropertyAddress, SetBeamTargetPoint_FunctionAddress, "EmitterIndex");
		SetBeamTargetPoint_EmitterIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetBeamTargetPoint_FunctionAddress, "EmitterIndex");
		SetBeamTargetPoint_EmitterIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBeamTargetPoint_FunctionAddress, "EmitterIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBeamTargetPoint_NewTargetPoint_PropertyAddress, SetBeamTargetPoint_FunctionAddress, "NewTargetPoint");
		SetBeamTargetPoint_NewTargetPoint_Offset = NativeReflectionCached.GetPropertyOffset(SetBeamTargetPoint_FunctionAddress, "NewTargetPoint");
		SetBeamTargetPoint_NewTargetPoint_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBeamTargetPoint_FunctionAddress, "NewTargetPoint", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBeamTargetPoint_TargetIndex_PropertyAddress, SetBeamTargetPoint_FunctionAddress, "TargetIndex");
		SetBeamTargetPoint_TargetIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetBeamTargetPoint_FunctionAddress, "TargetIndex");
		SetBeamTargetPoint_TargetIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBeamTargetPoint_FunctionAddress, "TargetIndex", Classes.FIntProperty);
		SetBeamTargetPoint_IsValid = SetBeamTargetPoint_FunctionAddress != IntPtr.Zero && SetBeamTargetPoint_EmitterIndex_IsValid && SetBeamTargetPoint_NewTargetPoint_IsValid && SetBeamTargetPoint_TargetIndex_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ParticleSystemComponent:SetBeamTargetPoint", SetBeamTargetPoint_IsValid);
		SetBeamSourceTangent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetBeamSourceTangent");
		SetBeamSourceTangent_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBeamSourceTangent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBeamSourceTangent_EmitterIndex_PropertyAddress, SetBeamSourceTangent_FunctionAddress, "EmitterIndex");
		SetBeamSourceTangent_EmitterIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetBeamSourceTangent_FunctionAddress, "EmitterIndex");
		SetBeamSourceTangent_EmitterIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBeamSourceTangent_FunctionAddress, "EmitterIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBeamSourceTangent_NewTangentPoint_PropertyAddress, SetBeamSourceTangent_FunctionAddress, "NewTangentPoint");
		SetBeamSourceTangent_NewTangentPoint_Offset = NativeReflectionCached.GetPropertyOffset(SetBeamSourceTangent_FunctionAddress, "NewTangentPoint");
		SetBeamSourceTangent_NewTangentPoint_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBeamSourceTangent_FunctionAddress, "NewTangentPoint", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBeamSourceTangent_SourceIndex_PropertyAddress, SetBeamSourceTangent_FunctionAddress, "SourceIndex");
		SetBeamSourceTangent_SourceIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetBeamSourceTangent_FunctionAddress, "SourceIndex");
		SetBeamSourceTangent_SourceIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBeamSourceTangent_FunctionAddress, "SourceIndex", Classes.FIntProperty);
		SetBeamSourceTangent_IsValid = SetBeamSourceTangent_FunctionAddress != IntPtr.Zero && SetBeamSourceTangent_EmitterIndex_IsValid && SetBeamSourceTangent_NewTangentPoint_IsValid && SetBeamSourceTangent_SourceIndex_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ParticleSystemComponent:SetBeamSourceTangent", SetBeamSourceTangent_IsValid);
		SetBeamSourceStrength_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetBeamSourceStrength");
		SetBeamSourceStrength_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBeamSourceStrength_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBeamSourceStrength_EmitterIndex_PropertyAddress, SetBeamSourceStrength_FunctionAddress, "EmitterIndex");
		SetBeamSourceStrength_EmitterIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetBeamSourceStrength_FunctionAddress, "EmitterIndex");
		SetBeamSourceStrength_EmitterIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBeamSourceStrength_FunctionAddress, "EmitterIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBeamSourceStrength_NewSourceStrength_PropertyAddress, SetBeamSourceStrength_FunctionAddress, "NewSourceStrength");
		SetBeamSourceStrength_NewSourceStrength_Offset = NativeReflectionCached.GetPropertyOffset(SetBeamSourceStrength_FunctionAddress, "NewSourceStrength");
		SetBeamSourceStrength_NewSourceStrength_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBeamSourceStrength_FunctionAddress, "NewSourceStrength", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBeamSourceStrength_SourceIndex_PropertyAddress, SetBeamSourceStrength_FunctionAddress, "SourceIndex");
		SetBeamSourceStrength_SourceIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetBeamSourceStrength_FunctionAddress, "SourceIndex");
		SetBeamSourceStrength_SourceIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBeamSourceStrength_FunctionAddress, "SourceIndex", Classes.FIntProperty);
		SetBeamSourceStrength_IsValid = SetBeamSourceStrength_FunctionAddress != IntPtr.Zero && SetBeamSourceStrength_EmitterIndex_IsValid && SetBeamSourceStrength_NewSourceStrength_IsValid && SetBeamSourceStrength_SourceIndex_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ParticleSystemComponent:SetBeamSourceStrength", SetBeamSourceStrength_IsValid);
		SetBeamSourcePoint_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetBeamSourcePoint");
		SetBeamSourcePoint_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBeamSourcePoint_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBeamSourcePoint_EmitterIndex_PropertyAddress, SetBeamSourcePoint_FunctionAddress, "EmitterIndex");
		SetBeamSourcePoint_EmitterIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetBeamSourcePoint_FunctionAddress, "EmitterIndex");
		SetBeamSourcePoint_EmitterIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBeamSourcePoint_FunctionAddress, "EmitterIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBeamSourcePoint_NewSourcePoint_PropertyAddress, SetBeamSourcePoint_FunctionAddress, "NewSourcePoint");
		SetBeamSourcePoint_NewSourcePoint_Offset = NativeReflectionCached.GetPropertyOffset(SetBeamSourcePoint_FunctionAddress, "NewSourcePoint");
		SetBeamSourcePoint_NewSourcePoint_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBeamSourcePoint_FunctionAddress, "NewSourcePoint", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBeamSourcePoint_SourceIndex_PropertyAddress, SetBeamSourcePoint_FunctionAddress, "SourceIndex");
		SetBeamSourcePoint_SourceIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetBeamSourcePoint_FunctionAddress, "SourceIndex");
		SetBeamSourcePoint_SourceIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBeamSourcePoint_FunctionAddress, "SourceIndex", Classes.FIntProperty);
		SetBeamSourcePoint_IsValid = SetBeamSourcePoint_FunctionAddress != IntPtr.Zero && SetBeamSourcePoint_EmitterIndex_IsValid && SetBeamSourcePoint_NewSourcePoint_IsValid && SetBeamSourcePoint_SourceIndex_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ParticleSystemComponent:SetBeamSourcePoint", SetBeamSourcePoint_IsValid);
		SetBeamEndPoint_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetBeamEndPoint");
		SetBeamEndPoint_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBeamEndPoint_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBeamEndPoint_EmitterIndex_PropertyAddress, SetBeamEndPoint_FunctionAddress, "EmitterIndex");
		SetBeamEndPoint_EmitterIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetBeamEndPoint_FunctionAddress, "EmitterIndex");
		SetBeamEndPoint_EmitterIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBeamEndPoint_FunctionAddress, "EmitterIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBeamEndPoint_NewEndPoint_PropertyAddress, SetBeamEndPoint_FunctionAddress, "NewEndPoint");
		SetBeamEndPoint_NewEndPoint_Offset = NativeReflectionCached.GetPropertyOffset(SetBeamEndPoint_FunctionAddress, "NewEndPoint");
		SetBeamEndPoint_NewEndPoint_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBeamEndPoint_FunctionAddress, "NewEndPoint", Classes.FStructProperty);
		SetBeamEndPoint_IsValid = SetBeamEndPoint_FunctionAddress != IntPtr.Zero && SetBeamEndPoint_EmitterIndex_IsValid && SetBeamEndPoint_NewEndPoint_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ParticleSystemComponent:SetBeamEndPoint", SetBeamEndPoint_IsValid);
		GetNumActiveParticles_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNumActiveParticles");
		GetNumActiveParticles_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNumActiveParticles_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNumActiveParticles_ReturnValue_PropertyAddress, GetNumActiveParticles_FunctionAddress, "ReturnValue");
		GetNumActiveParticles_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNumActiveParticles_FunctionAddress, "ReturnValue");
		GetNumActiveParticles_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumActiveParticles_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetNumActiveParticles_IsValid = GetNumActiveParticles_FunctionAddress != IntPtr.Zero && GetNumActiveParticles_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ParticleSystemComponent:GetNumActiveParticles", GetNumActiveParticles_IsValid);
		GetNamedMaterial_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNamedMaterial");
		GetNamedMaterial_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNamedMaterial_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNamedMaterial_InName_PropertyAddress, GetNamedMaterial_FunctionAddress, "InName");
		GetNamedMaterial_InName_Offset = NativeReflectionCached.GetPropertyOffset(GetNamedMaterial_FunctionAddress, "InName");
		GetNamedMaterial_InName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNamedMaterial_FunctionAddress, "InName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNamedMaterial_ReturnValue_PropertyAddress, GetNamedMaterial_FunctionAddress, "ReturnValue");
		GetNamedMaterial_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNamedMaterial_FunctionAddress, "ReturnValue");
		GetNamedMaterial_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNamedMaterial_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetNamedMaterial_IsValid = GetNamedMaterial_FunctionAddress != IntPtr.Zero && GetNamedMaterial_InName_IsValid && GetNamedMaterial_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ParticleSystemComponent:GetNamedMaterial", GetNamedMaterial_IsValid);
		GetBeamTargetTangent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetBeamTargetTangent");
		GetBeamTargetTangent_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBeamTargetTangent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBeamTargetTangent_EmitterIndex_PropertyAddress, GetBeamTargetTangent_FunctionAddress, "EmitterIndex");
		GetBeamTargetTangent_EmitterIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetBeamTargetTangent_FunctionAddress, "EmitterIndex");
		GetBeamTargetTangent_EmitterIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBeamTargetTangent_FunctionAddress, "EmitterIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBeamTargetTangent_TargetIndex_PropertyAddress, GetBeamTargetTangent_FunctionAddress, "TargetIndex");
		GetBeamTargetTangent_TargetIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetBeamTargetTangent_FunctionAddress, "TargetIndex");
		GetBeamTargetTangent_TargetIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBeamTargetTangent_FunctionAddress, "TargetIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBeamTargetTangent_OutTangentPoint_PropertyAddress, GetBeamTargetTangent_FunctionAddress, "OutTangentPoint");
		GetBeamTargetTangent_OutTangentPoint_Offset = NativeReflectionCached.GetPropertyOffset(GetBeamTargetTangent_FunctionAddress, "OutTangentPoint");
		GetBeamTargetTangent_OutTangentPoint_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBeamTargetTangent_FunctionAddress, "OutTangentPoint", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBeamTargetTangent_ReturnValue_PropertyAddress, GetBeamTargetTangent_FunctionAddress, "ReturnValue");
		GetBeamTargetTangent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBeamTargetTangent_FunctionAddress, "ReturnValue");
		GetBeamTargetTangent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBeamTargetTangent_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetBeamTargetTangent_IsValid = GetBeamTargetTangent_FunctionAddress != IntPtr.Zero && GetBeamTargetTangent_EmitterIndex_IsValid && GetBeamTargetTangent_TargetIndex_IsValid && GetBeamTargetTangent_OutTangentPoint_IsValid && GetBeamTargetTangent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ParticleSystemComponent:GetBeamTargetTangent", GetBeamTargetTangent_IsValid);
		GetBeamTargetStrength_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetBeamTargetStrength");
		GetBeamTargetStrength_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBeamTargetStrength_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBeamTargetStrength_EmitterIndex_PropertyAddress, GetBeamTargetStrength_FunctionAddress, "EmitterIndex");
		GetBeamTargetStrength_EmitterIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetBeamTargetStrength_FunctionAddress, "EmitterIndex");
		GetBeamTargetStrength_EmitterIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBeamTargetStrength_FunctionAddress, "EmitterIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBeamTargetStrength_TargetIndex_PropertyAddress, GetBeamTargetStrength_FunctionAddress, "TargetIndex");
		GetBeamTargetStrength_TargetIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetBeamTargetStrength_FunctionAddress, "TargetIndex");
		GetBeamTargetStrength_TargetIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBeamTargetStrength_FunctionAddress, "TargetIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBeamTargetStrength_OutTargetStrength_PropertyAddress, GetBeamTargetStrength_FunctionAddress, "OutTargetStrength");
		GetBeamTargetStrength_OutTargetStrength_Offset = NativeReflectionCached.GetPropertyOffset(GetBeamTargetStrength_FunctionAddress, "OutTargetStrength");
		GetBeamTargetStrength_OutTargetStrength_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBeamTargetStrength_FunctionAddress, "OutTargetStrength", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBeamTargetStrength_ReturnValue_PropertyAddress, GetBeamTargetStrength_FunctionAddress, "ReturnValue");
		GetBeamTargetStrength_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBeamTargetStrength_FunctionAddress, "ReturnValue");
		GetBeamTargetStrength_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBeamTargetStrength_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetBeamTargetStrength_IsValid = GetBeamTargetStrength_FunctionAddress != IntPtr.Zero && GetBeamTargetStrength_EmitterIndex_IsValid && GetBeamTargetStrength_TargetIndex_IsValid && GetBeamTargetStrength_OutTargetStrength_IsValid && GetBeamTargetStrength_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ParticleSystemComponent:GetBeamTargetStrength", GetBeamTargetStrength_IsValid);
		GetBeamTargetPoint_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetBeamTargetPoint");
		GetBeamTargetPoint_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBeamTargetPoint_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBeamTargetPoint_EmitterIndex_PropertyAddress, GetBeamTargetPoint_FunctionAddress, "EmitterIndex");
		GetBeamTargetPoint_EmitterIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetBeamTargetPoint_FunctionAddress, "EmitterIndex");
		GetBeamTargetPoint_EmitterIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBeamTargetPoint_FunctionAddress, "EmitterIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBeamTargetPoint_TargetIndex_PropertyAddress, GetBeamTargetPoint_FunctionAddress, "TargetIndex");
		GetBeamTargetPoint_TargetIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetBeamTargetPoint_FunctionAddress, "TargetIndex");
		GetBeamTargetPoint_TargetIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBeamTargetPoint_FunctionAddress, "TargetIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBeamTargetPoint_OutTargetPoint_PropertyAddress, GetBeamTargetPoint_FunctionAddress, "OutTargetPoint");
		GetBeamTargetPoint_OutTargetPoint_Offset = NativeReflectionCached.GetPropertyOffset(GetBeamTargetPoint_FunctionAddress, "OutTargetPoint");
		GetBeamTargetPoint_OutTargetPoint_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBeamTargetPoint_FunctionAddress, "OutTargetPoint", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBeamTargetPoint_ReturnValue_PropertyAddress, GetBeamTargetPoint_FunctionAddress, "ReturnValue");
		GetBeamTargetPoint_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBeamTargetPoint_FunctionAddress, "ReturnValue");
		GetBeamTargetPoint_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBeamTargetPoint_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetBeamTargetPoint_IsValid = GetBeamTargetPoint_FunctionAddress != IntPtr.Zero && GetBeamTargetPoint_EmitterIndex_IsValid && GetBeamTargetPoint_TargetIndex_IsValid && GetBeamTargetPoint_OutTargetPoint_IsValid && GetBeamTargetPoint_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ParticleSystemComponent:GetBeamTargetPoint", GetBeamTargetPoint_IsValid);
		GetBeamSourceTangent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetBeamSourceTangent");
		GetBeamSourceTangent_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBeamSourceTangent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBeamSourceTangent_EmitterIndex_PropertyAddress, GetBeamSourceTangent_FunctionAddress, "EmitterIndex");
		GetBeamSourceTangent_EmitterIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetBeamSourceTangent_FunctionAddress, "EmitterIndex");
		GetBeamSourceTangent_EmitterIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBeamSourceTangent_FunctionAddress, "EmitterIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBeamSourceTangent_SourceIndex_PropertyAddress, GetBeamSourceTangent_FunctionAddress, "SourceIndex");
		GetBeamSourceTangent_SourceIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetBeamSourceTangent_FunctionAddress, "SourceIndex");
		GetBeamSourceTangent_SourceIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBeamSourceTangent_FunctionAddress, "SourceIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBeamSourceTangent_OutTangentPoint_PropertyAddress, GetBeamSourceTangent_FunctionAddress, "OutTangentPoint");
		GetBeamSourceTangent_OutTangentPoint_Offset = NativeReflectionCached.GetPropertyOffset(GetBeamSourceTangent_FunctionAddress, "OutTangentPoint");
		GetBeamSourceTangent_OutTangentPoint_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBeamSourceTangent_FunctionAddress, "OutTangentPoint", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBeamSourceTangent_ReturnValue_PropertyAddress, GetBeamSourceTangent_FunctionAddress, "ReturnValue");
		GetBeamSourceTangent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBeamSourceTangent_FunctionAddress, "ReturnValue");
		GetBeamSourceTangent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBeamSourceTangent_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetBeamSourceTangent_IsValid = GetBeamSourceTangent_FunctionAddress != IntPtr.Zero && GetBeamSourceTangent_EmitterIndex_IsValid && GetBeamSourceTangent_SourceIndex_IsValid && GetBeamSourceTangent_OutTangentPoint_IsValid && GetBeamSourceTangent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ParticleSystemComponent:GetBeamSourceTangent", GetBeamSourceTangent_IsValid);
		GetBeamSourceStrength_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetBeamSourceStrength");
		GetBeamSourceStrength_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBeamSourceStrength_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBeamSourceStrength_EmitterIndex_PropertyAddress, GetBeamSourceStrength_FunctionAddress, "EmitterIndex");
		GetBeamSourceStrength_EmitterIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetBeamSourceStrength_FunctionAddress, "EmitterIndex");
		GetBeamSourceStrength_EmitterIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBeamSourceStrength_FunctionAddress, "EmitterIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBeamSourceStrength_SourceIndex_PropertyAddress, GetBeamSourceStrength_FunctionAddress, "SourceIndex");
		GetBeamSourceStrength_SourceIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetBeamSourceStrength_FunctionAddress, "SourceIndex");
		GetBeamSourceStrength_SourceIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBeamSourceStrength_FunctionAddress, "SourceIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBeamSourceStrength_OutSourceStrength_PropertyAddress, GetBeamSourceStrength_FunctionAddress, "OutSourceStrength");
		GetBeamSourceStrength_OutSourceStrength_Offset = NativeReflectionCached.GetPropertyOffset(GetBeamSourceStrength_FunctionAddress, "OutSourceStrength");
		GetBeamSourceStrength_OutSourceStrength_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBeamSourceStrength_FunctionAddress, "OutSourceStrength", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBeamSourceStrength_ReturnValue_PropertyAddress, GetBeamSourceStrength_FunctionAddress, "ReturnValue");
		GetBeamSourceStrength_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBeamSourceStrength_FunctionAddress, "ReturnValue");
		GetBeamSourceStrength_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBeamSourceStrength_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetBeamSourceStrength_IsValid = GetBeamSourceStrength_FunctionAddress != IntPtr.Zero && GetBeamSourceStrength_EmitterIndex_IsValid && GetBeamSourceStrength_SourceIndex_IsValid && GetBeamSourceStrength_OutSourceStrength_IsValid && GetBeamSourceStrength_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ParticleSystemComponent:GetBeamSourceStrength", GetBeamSourceStrength_IsValid);
		GetBeamSourcePoint_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetBeamSourcePoint");
		GetBeamSourcePoint_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBeamSourcePoint_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBeamSourcePoint_EmitterIndex_PropertyAddress, GetBeamSourcePoint_FunctionAddress, "EmitterIndex");
		GetBeamSourcePoint_EmitterIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetBeamSourcePoint_FunctionAddress, "EmitterIndex");
		GetBeamSourcePoint_EmitterIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBeamSourcePoint_FunctionAddress, "EmitterIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBeamSourcePoint_SourceIndex_PropertyAddress, GetBeamSourcePoint_FunctionAddress, "SourceIndex");
		GetBeamSourcePoint_SourceIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetBeamSourcePoint_FunctionAddress, "SourceIndex");
		GetBeamSourcePoint_SourceIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBeamSourcePoint_FunctionAddress, "SourceIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBeamSourcePoint_OutSourcePoint_PropertyAddress, GetBeamSourcePoint_FunctionAddress, "OutSourcePoint");
		GetBeamSourcePoint_OutSourcePoint_Offset = NativeReflectionCached.GetPropertyOffset(GetBeamSourcePoint_FunctionAddress, "OutSourcePoint");
		GetBeamSourcePoint_OutSourcePoint_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBeamSourcePoint_FunctionAddress, "OutSourcePoint", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBeamSourcePoint_ReturnValue_PropertyAddress, GetBeamSourcePoint_FunctionAddress, "ReturnValue");
		GetBeamSourcePoint_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBeamSourcePoint_FunctionAddress, "ReturnValue");
		GetBeamSourcePoint_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBeamSourcePoint_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetBeamSourcePoint_IsValid = GetBeamSourcePoint_FunctionAddress != IntPtr.Zero && GetBeamSourcePoint_EmitterIndex_IsValid && GetBeamSourcePoint_SourceIndex_IsValid && GetBeamSourcePoint_OutSourcePoint_IsValid && GetBeamSourcePoint_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ParticleSystemComponent:GetBeamSourcePoint", GetBeamSourcePoint_IsValid);
		GetBeamEndPoint_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetBeamEndPoint");
		GetBeamEndPoint_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBeamEndPoint_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBeamEndPoint_EmitterIndex_PropertyAddress, GetBeamEndPoint_FunctionAddress, "EmitterIndex");
		GetBeamEndPoint_EmitterIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetBeamEndPoint_FunctionAddress, "EmitterIndex");
		GetBeamEndPoint_EmitterIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBeamEndPoint_FunctionAddress, "EmitterIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBeamEndPoint_OutEndPoint_PropertyAddress, GetBeamEndPoint_FunctionAddress, "OutEndPoint");
		GetBeamEndPoint_OutEndPoint_Offset = NativeReflectionCached.GetPropertyOffset(GetBeamEndPoint_FunctionAddress, "OutEndPoint");
		GetBeamEndPoint_OutEndPoint_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBeamEndPoint_FunctionAddress, "OutEndPoint", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBeamEndPoint_ReturnValue_PropertyAddress, GetBeamEndPoint_FunctionAddress, "ReturnValue");
		GetBeamEndPoint_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBeamEndPoint_FunctionAddress, "ReturnValue");
		GetBeamEndPoint_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBeamEndPoint_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetBeamEndPoint_IsValid = GetBeamEndPoint_FunctionAddress != IntPtr.Zero && GetBeamEndPoint_EmitterIndex_IsValid && GetBeamEndPoint_OutEndPoint_IsValid && GetBeamEndPoint_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ParticleSystemComponent:GetBeamEndPoint", GetBeamEndPoint_IsValid);
		GenerateParticleEvent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GenerateParticleEvent");
		GenerateParticleEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(GenerateParticleEvent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GenerateParticleEvent_InEventName_PropertyAddress, GenerateParticleEvent_FunctionAddress, "InEventName");
		GenerateParticleEvent_InEventName_Offset = NativeReflectionCached.GetPropertyOffset(GenerateParticleEvent_FunctionAddress, "InEventName");
		GenerateParticleEvent_InEventName_IsValid = NativeReflectionCached.ValidatePropertyClass(GenerateParticleEvent_FunctionAddress, "InEventName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GenerateParticleEvent_InEmitterTime_PropertyAddress, GenerateParticleEvent_FunctionAddress, "InEmitterTime");
		GenerateParticleEvent_InEmitterTime_Offset = NativeReflectionCached.GetPropertyOffset(GenerateParticleEvent_FunctionAddress, "InEmitterTime");
		GenerateParticleEvent_InEmitterTime_IsValid = NativeReflectionCached.ValidatePropertyClass(GenerateParticleEvent_FunctionAddress, "InEmitterTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GenerateParticleEvent_InLocation_PropertyAddress, GenerateParticleEvent_FunctionAddress, "InLocation");
		GenerateParticleEvent_InLocation_Offset = NativeReflectionCached.GetPropertyOffset(GenerateParticleEvent_FunctionAddress, "InLocation");
		GenerateParticleEvent_InLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(GenerateParticleEvent_FunctionAddress, "InLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GenerateParticleEvent_InDirection_PropertyAddress, GenerateParticleEvent_FunctionAddress, "InDirection");
		GenerateParticleEvent_InDirection_Offset = NativeReflectionCached.GetPropertyOffset(GenerateParticleEvent_FunctionAddress, "InDirection");
		GenerateParticleEvent_InDirection_IsValid = NativeReflectionCached.ValidatePropertyClass(GenerateParticleEvent_FunctionAddress, "InDirection", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GenerateParticleEvent_InVelocity_PropertyAddress, GenerateParticleEvent_FunctionAddress, "InVelocity");
		GenerateParticleEvent_InVelocity_Offset = NativeReflectionCached.GetPropertyOffset(GenerateParticleEvent_FunctionAddress, "InVelocity");
		GenerateParticleEvent_InVelocity_IsValid = NativeReflectionCached.ValidatePropertyClass(GenerateParticleEvent_FunctionAddress, "InVelocity", Classes.FStructProperty);
		GenerateParticleEvent_IsValid = GenerateParticleEvent_FunctionAddress != IntPtr.Zero && GenerateParticleEvent_InEventName_IsValid && GenerateParticleEvent_InEmitterTime_IsValid && GenerateParticleEvent_InLocation_IsValid && GenerateParticleEvent_InDirection_IsValid && GenerateParticleEvent_InVelocity_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ParticleSystemComponent:GenerateParticleEvent", GenerateParticleEvent_IsValid);
		EndTrails_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "EndTrails");
		EndTrails_ParamsSize = NativeReflection.GetFunctionParamsSize(EndTrails_FunctionAddress);
		EndTrails_IsValid = EndTrails_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ParticleSystemComponent:EndTrails", EndTrails_IsValid);
		CreateNamedDynamicMaterialInstance_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CreateNamedDynamicMaterialInstance");
		CreateNamedDynamicMaterialInstance_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateNamedDynamicMaterialInstance_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateNamedDynamicMaterialInstance_InName_PropertyAddress, CreateNamedDynamicMaterialInstance_FunctionAddress, "InName");
		CreateNamedDynamicMaterialInstance_InName_Offset = NativeReflectionCached.GetPropertyOffset(CreateNamedDynamicMaterialInstance_FunctionAddress, "InName");
		CreateNamedDynamicMaterialInstance_InName_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateNamedDynamicMaterialInstance_FunctionAddress, "InName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateNamedDynamicMaterialInstance_SourceMaterial_PropertyAddress, CreateNamedDynamicMaterialInstance_FunctionAddress, "SourceMaterial");
		CreateNamedDynamicMaterialInstance_SourceMaterial_Offset = NativeReflectionCached.GetPropertyOffset(CreateNamedDynamicMaterialInstance_FunctionAddress, "SourceMaterial");
		CreateNamedDynamicMaterialInstance_SourceMaterial_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateNamedDynamicMaterialInstance_FunctionAddress, "SourceMaterial", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateNamedDynamicMaterialInstance_ReturnValue_PropertyAddress, CreateNamedDynamicMaterialInstance_FunctionAddress, "ReturnValue");
		CreateNamedDynamicMaterialInstance_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateNamedDynamicMaterialInstance_FunctionAddress, "ReturnValue");
		CreateNamedDynamicMaterialInstance_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateNamedDynamicMaterialInstance_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		CreateNamedDynamicMaterialInstance_IsValid = CreateNamedDynamicMaterialInstance_FunctionAddress != IntPtr.Zero && CreateNamedDynamicMaterialInstance_InName_IsValid && CreateNamedDynamicMaterialInstance_SourceMaterial_IsValid && CreateNamedDynamicMaterialInstance_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ParticleSystemComponent:CreateNamedDynamicMaterialInstance", CreateNamedDynamicMaterialInstance_IsValid);
		BeginTrails_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BeginTrails");
		BeginTrails_ParamsSize = NativeReflection.GetFunctionParamsSize(BeginTrails_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BeginTrails_InFirstSocketName_PropertyAddress, BeginTrails_FunctionAddress, "InFirstSocketName");
		BeginTrails_InFirstSocketName_Offset = NativeReflectionCached.GetPropertyOffset(BeginTrails_FunctionAddress, "InFirstSocketName");
		BeginTrails_InFirstSocketName_IsValid = NativeReflectionCached.ValidatePropertyClass(BeginTrails_FunctionAddress, "InFirstSocketName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref BeginTrails_InSecondSocketName_PropertyAddress, BeginTrails_FunctionAddress, "InSecondSocketName");
		BeginTrails_InSecondSocketName_Offset = NativeReflectionCached.GetPropertyOffset(BeginTrails_FunctionAddress, "InSecondSocketName");
		BeginTrails_InSecondSocketName_IsValid = NativeReflectionCached.ValidatePropertyClass(BeginTrails_FunctionAddress, "InSecondSocketName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref BeginTrails_InWidthMode_PropertyAddress, BeginTrails_FunctionAddress, "InWidthMode");
		BeginTrails_InWidthMode_Offset = NativeReflectionCached.GetPropertyOffset(BeginTrails_FunctionAddress, "InWidthMode");
		BeginTrails_InWidthMode_IsValid = NativeReflectionCached.ValidatePropertyClass(BeginTrails_FunctionAddress, "InWidthMode", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref BeginTrails_InWidth_PropertyAddress, BeginTrails_FunctionAddress, "InWidth");
		BeginTrails_InWidth_Offset = NativeReflectionCached.GetPropertyOffset(BeginTrails_FunctionAddress, "InWidth");
		BeginTrails_InWidth_IsValid = NativeReflectionCached.ValidatePropertyClass(BeginTrails_FunctionAddress, "InWidth", Classes.FFloatProperty);
		BeginTrails_IsValid = BeginTrails_FunctionAddress != IntPtr.Zero && BeginTrails_InFirstSocketName_IsValid && BeginTrails_InSecondSocketName_IsValid && BeginTrails_InWidthMode_IsValid && BeginTrails_InWidth_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ParticleSystemComponent:BeginTrails", BeginTrails_IsValid);
	}
}

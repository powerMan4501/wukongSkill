using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.GSNiagara;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/GSNiagara.GSNiagaraBatchingSpriteConfigDA", "GSNiagara", UnrealModuleType.GamePlugin)]
public class UGSNiagaraBatchingSpriteConfigDA : UPrimaryDataAsset
{
	private static bool AtlasConfigFilePath_IsValid;

	private static int AtlasConfigFilePath_Offset;

	private static bool AltasTextureSize_IsValid;

	private static int AltasTextureSize_Offset;

	private static bool ParticleInfoConfigArray_IsValid;

	private static FFieldAddress ParticleInfoConfigArray_PropertyAddress;

	private static int ParticleInfoConfigArray_Offset;

	private TArrayReadWriteMarshaler<FGSNiagaraParticleInfoConfig> ParticleInfoConfigArray_MarshalerCached;

	private static bool ParticleSpriteMappingConfig_IsValid;

	private static FFieldAddress ParticleSpriteMappingConfig_PropertyAddress;

	private static int ParticleSpriteMappingConfig_Offset;

	private TArrayReadWriteMarshaler<FGSNiagaraParticleSpriteMapping> ParticleSpriteMappingConfig_MarshalerCached;

	private static bool InitGSParticlesConfigInfo_IsValid;

	private static IntPtr InitGSParticlesConfigInfo_FunctionAddress;

	private static int InitGSParticlesConfigInfo_ParamsSize;

	private static bool InitGSParticlesConfigInfo_bForceSet_IsValid;

	private static FFieldAddress InitGSParticlesConfigInfo_bForceSet_PropertyAddress;

	private static int InitGSParticlesConfigInfo_bForceSet_Offset;

	private static bool InitGSParticlesConfigInfo_ReturnValue_IsValid;

	private static FFieldAddress InitGSParticlesConfigInfo_ReturnValue_PropertyAddress;

	private static int InitGSParticlesConfigInfo_ReturnValue_Offset;

	private static bool ClearPaticleConfigData_IsValid;

	private static IntPtr ClearPaticleConfigData_FunctionAddress;

	private static int ClearPaticleConfigData_ParamsSize;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/GSNiagara.GSNiagaraBatchingSpriteConfigDA:AtlasConfigFilePath")]
	public string AtlasConfigFilePath
	{
		get
		{
			CheckDestroyed();
			if (!AtlasConfigFilePath_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSNiagara.GSNiagaraBatchingSpriteConfigDA:AtlasConfigFilePath");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, AtlasConfigFilePath_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AtlasConfigFilePath_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSNiagara.GSNiagaraBatchingSpriteConfigDA:AtlasConfigFilePath");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, AtlasConfigFilePath_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234405893uL)]
	[UMetaPath("/Script/GSNiagara.GSNiagaraBatchingSpriteConfigDA:AltasTextureSize")]
	public FVector2D AltasTextureSize
	{
		get
		{
			CheckDestroyed();
			if (!AltasTextureSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSNiagara.GSNiagaraBatchingSpriteConfigDA:AltasTextureSize");
				return default(FVector2D);
			}
			return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(base.Address, AltasTextureSize_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AltasTextureSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSNiagara.GSNiagaraBatchingSpriteConfigDA:AltasTextureSize");
			}
			else
			{
				BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(base.Address, AltasTextureSize_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/GSNiagara.GSNiagaraBatchingSpriteConfigDA:ParticleInfoConfigArray")]
	public TArrayReadWrite<FGSNiagaraParticleInfoConfig> ParticleInfoConfigArray
	{
		get
		{
			CheckDestroyed();
			if (!ParticleInfoConfigArray_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSNiagara.GSNiagaraBatchingSpriteConfigDA:ParticleInfoConfigArray");
				return null;
			}
			if (ParticleInfoConfigArray_MarshalerCached == null)
			{
				ParticleInfoConfigArray_MarshalerCached = new TArrayReadWriteMarshaler<FGSNiagaraParticleInfoConfig>(1, ParticleInfoConfigArray_PropertyAddress, CachedMarshalingDelegates<FGSNiagaraParticleInfoConfig, FGSNiagaraParticleInfoConfig>.FromNative, CachedMarshalingDelegates<FGSNiagaraParticleInfoConfig, FGSNiagaraParticleInfoConfig>.ToNative);
			}
			return ParticleInfoConfigArray_MarshalerCached.FromNative(IntPtr.Add(base.Address, ParticleInfoConfigArray_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/GSNiagara.GSNiagaraBatchingSpriteConfigDA:ParticleSpriteMappingConfig")]
	public TArrayReadWrite<FGSNiagaraParticleSpriteMapping> ParticleSpriteMappingConfig
	{
		get
		{
			CheckDestroyed();
			if (!ParticleSpriteMappingConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSNiagara.GSNiagaraBatchingSpriteConfigDA:ParticleSpriteMappingConfig");
				return null;
			}
			if (ParticleSpriteMappingConfig_MarshalerCached == null)
			{
				ParticleSpriteMappingConfig_MarshalerCached = new TArrayReadWriteMarshaler<FGSNiagaraParticleSpriteMapping>(1, ParticleSpriteMappingConfig_PropertyAddress, CachedMarshalingDelegates<FGSNiagaraParticleSpriteMapping, BlittableTypeMarshaler<FGSNiagaraParticleSpriteMapping>>.FromNative, CachedMarshalingDelegates<FGSNiagaraParticleSpriteMapping, BlittableTypeMarshaler<FGSNiagaraParticleSpriteMapping>>.ToNative);
			}
			return ParticleSpriteMappingConfig_MarshalerCached.FromNative(IntPtr.Add(base.Address, ParticleSpriteMappingConfig_Offset));
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GSNiagara.GSNiagaraBatchingSpriteConfigDA:InitGSParticlesConfigInfo")]
	public unsafe bool InitGSParticlesConfigInfo(bool bForceSet)
	{
		CheckDestroyed();
		if (!InitGSParticlesConfigInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSNiagara.GSNiagaraBatchingSpriteConfigDA:InitGSParticlesConfigInfo");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(InitGSParticlesConfigInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InitGSParticlesConfigInfo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, InitGSParticlesConfigInfo_bForceSet_Offset), 0, InitGSParticlesConfigInfo_bForceSet_PropertyAddress.Address, bForceSet);
		NativeReflection.InvokeFunctionOptimized(base.Address, InitGSParticlesConfigInfo_FunctionAddress, intPtr, InitGSParticlesConfigInfo_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, InitGSParticlesConfigInfo_ReturnValue_Offset), 0, InitGSParticlesConfigInfo_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GSNiagara.GSNiagaraBatchingSpriteConfigDA:ClearPaticleConfigData")]
	public unsafe void ClearPaticleConfigData()
	{
		CheckDestroyed();
		if (!ClearPaticleConfigData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSNiagara.GSNiagaraBatchingSpriteConfigDA:ClearPaticleConfigData");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearPaticleConfigData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearPaticleConfigData_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ClearPaticleConfigData_FunctionAddress, argsSize: ClearPaticleConfigData_ParamsSize);
	}

	static UGSNiagaraBatchingSpriteConfigDA()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSNiagaraBatchingSpriteConfigDA)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSNiagaraBatchingSpriteConfigDA));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/GSNiagara.GSNiagaraBatchingSpriteConfigDA");
		AtlasConfigFilePath_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AtlasConfigFilePath");
		AtlasConfigFilePath_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AtlasConfigFilePath", Classes.FStrProperty);
		AltasTextureSize_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AltasTextureSize");
		AltasTextureSize_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AltasTextureSize", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ParticleInfoConfigArray_PropertyAddress, intPtr, "ParticleInfoConfigArray");
		ParticleInfoConfigArray_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ParticleInfoConfigArray");
		ParticleInfoConfigArray_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ParticleInfoConfigArray", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ParticleSpriteMappingConfig_PropertyAddress, intPtr, "ParticleSpriteMappingConfig");
		ParticleSpriteMappingConfig_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ParticleSpriteMappingConfig");
		ParticleSpriteMappingConfig_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ParticleSpriteMappingConfig", Classes.FArrayProperty);
		InitGSParticlesConfigInfo_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "InitGSParticlesConfigInfo");
		InitGSParticlesConfigInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(InitGSParticlesConfigInfo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref InitGSParticlesConfigInfo_bForceSet_PropertyAddress, InitGSParticlesConfigInfo_FunctionAddress, "bForceSet");
		InitGSParticlesConfigInfo_bForceSet_Offset = NativeReflectionCached.GetPropertyOffset(InitGSParticlesConfigInfo_FunctionAddress, "bForceSet");
		InitGSParticlesConfigInfo_bForceSet_IsValid = NativeReflectionCached.ValidatePropertyClass(InitGSParticlesConfigInfo_FunctionAddress, "bForceSet", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref InitGSParticlesConfigInfo_ReturnValue_PropertyAddress, InitGSParticlesConfigInfo_FunctionAddress, "ReturnValue");
		InitGSParticlesConfigInfo_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(InitGSParticlesConfigInfo_FunctionAddress, "ReturnValue");
		InitGSParticlesConfigInfo_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(InitGSParticlesConfigInfo_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		InitGSParticlesConfigInfo_IsValid = InitGSParticlesConfigInfo_FunctionAddress != IntPtr.Zero && InitGSParticlesConfigInfo_bForceSet_IsValid && InitGSParticlesConfigInfo_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSNiagara.GSNiagaraBatchingSpriteConfigDA:InitGSParticlesConfigInfo", InitGSParticlesConfigInfo_IsValid);
		ClearPaticleConfigData_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ClearPaticleConfigData");
		ClearPaticleConfigData_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearPaticleConfigData_FunctionAddress);
		ClearPaticleConfigData_IsValid = ClearPaticleConfigData_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/GSNiagara.GSNiagaraBatchingSpriteConfigDA:ClearPaticleConfigData", ClearPaticleConfigData_IsValid);
	}
}

using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.GSNiagara;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/GSNiagara.GSNiagaraParticleInfoConfig", "GSNiagara", UnrealModuleType.GamePlugin)]
public struct FGSNiagaraParticleInfoConfig
{
	private static bool ParticleType_IsValid;

	private static int ParticleType_Offset;

	[UProperty(Flags = (PropFlags)6755469234405893uL)]
	[UMetaPath("/Script/GSNiagara.GSNiagaraParticleInfoConfig:ParticleType")]
	public int ParticleType;

	private static bool ParticleLifetimeLoop_IsValid;

	private static FFieldAddress ParticleLifetimeLoop_PropertyAddress;

	private static int ParticleLifetimeLoop_Offset;

	[UProperty(Flags = (PropFlags)6755469234405893uL)]
	[UMetaPath("/Script/GSNiagara.GSNiagaraParticleInfoConfig:bParticleLifetimeLoop")]
	public bool ParticleLifetimeLoop;

	private static bool ParticleSpriteSize_IsValid;

	private static int ParticleSpriteSize_Offset;

	[UProperty(Flags = (PropFlags)6755469234405893uL)]
	[UMetaPath("/Script/GSNiagara.GSNiagaraParticleInfoConfig:ParticleSpriteSize")]
	public FVector2D ParticleSpriteSize;

	private static bool ParticleSpriteOffset_IsValid;

	private static int ParticleSpriteOffset_Offset;

	[UProperty(Flags = (PropFlags)6755469234405893uL)]
	[UMetaPath("/Script/GSNiagara.GSNiagaraParticleInfoConfig:ParticleSpriteOffset")]
	public FVector2D ParticleSpriteOffset;

	private static bool ParticleConfigRemark_IsValid;

	private static int ParticleConfigRemark_Offset;

	[UProperty(Flags = (PropFlags)6755399441187333uL)]
	[UMetaPath("/Script/GSNiagara.GSNiagaraParticleInfoConfig:ParticleConfigRemark")]
	public string ParticleConfigRemark;

	private static bool FGSNiagaraParticleInfoConfig_IsValid;

	private static int FGSNiagaraParticleInfoConfig_StructSize;

	public FGSNiagaraParticleInfoConfig Copy()
	{
		return this;
	}

	public static FGSNiagaraParticleInfoConfig FromNative(IntPtr nativeBuffer)
	{
		return new FGSNiagaraParticleInfoConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSNiagaraParticleInfoConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSNiagaraParticleInfoConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSNiagaraParticleInfoConfig(nativeBuffer + arrayIndex * FGSNiagaraParticleInfoConfig_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSNiagaraParticleInfoConfig value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGSNiagaraParticleInfoConfig_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGSNiagaraParticleInfoConfig_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GSNiagara.GSNiagaraParticleInfoConfig");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, ParticleType_Offset), ParticleType);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ParticleLifetimeLoop_Offset), 0, ParticleLifetimeLoop_PropertyAddress.Address, ParticleLifetimeLoop);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(nativeStruct, ParticleSpriteSize_Offset), ParticleSpriteSize);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(nativeStruct, ParticleSpriteOffset_Offset), ParticleSpriteOffset);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, ParticleConfigRemark_Offset), ParticleConfigRemark);
	}

	public FGSNiagaraParticleInfoConfig(IntPtr nativeStruct)
	{
		if (!FGSNiagaraParticleInfoConfig_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GSNiagara.GSNiagaraParticleInfoConfig");
			ParticleType = 0;
			ParticleLifetimeLoop = false;
			ParticleSpriteSize = default(FVector2D);
			ParticleSpriteOffset = default(FVector2D);
			ParticleConfigRemark = FStringMarshaler.DefaultString;
		}
		else
		{
			ParticleType = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, ParticleType_Offset));
			ParticleLifetimeLoop = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ParticleLifetimeLoop_Offset), 0, ParticleLifetimeLoop_PropertyAddress.Address);
			ParticleSpriteSize = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(nativeStruct, ParticleSpriteSize_Offset));
			ParticleSpriteOffset = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(nativeStruct, ParticleSpriteOffset_Offset));
			ParticleConfigRemark = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, ParticleConfigRemark_Offset));
		}
	}

	static FGSNiagaraParticleInfoConfig()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGSNiagaraParticleInfoConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSNiagaraParticleInfoConfig));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GSNiagara.GSNiagaraParticleInfoConfig");
		FGSNiagaraParticleInfoConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		ParticleType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ParticleType");
		ParticleType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ParticleType", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref ParticleLifetimeLoop_PropertyAddress, intPtr, "bParticleLifetimeLoop");
		ParticleLifetimeLoop_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bParticleLifetimeLoop");
		ParticleLifetimeLoop_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bParticleLifetimeLoop", Classes.FBoolProperty);
		ParticleSpriteSize_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ParticleSpriteSize");
		ParticleSpriteSize_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ParticleSpriteSize", Classes.FStructProperty);
		ParticleSpriteOffset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ParticleSpriteOffset");
		ParticleSpriteOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ParticleSpriteOffset", Classes.FStructProperty);
		ParticleConfigRemark_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ParticleConfigRemark");
		ParticleConfigRemark_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ParticleConfigRemark", Classes.FStrProperty);
		FGSNiagaraParticleInfoConfig_IsValid = intPtr != IntPtr.Zero && ParticleType_IsValid && ParticleLifetimeLoop_IsValid && ParticleSpriteSize_IsValid && ParticleSpriteOffset_IsValid && ParticleConfigRemark_IsValid;
		NativeReflection.LogStructIsValid("/Script/GSNiagara.GSNiagaraParticleInfoConfig", FGSNiagaraParticleInfoConfig_IsValid);
	}
}

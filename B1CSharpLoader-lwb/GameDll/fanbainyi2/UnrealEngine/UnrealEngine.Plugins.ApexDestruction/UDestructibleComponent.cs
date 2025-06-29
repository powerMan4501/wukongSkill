using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ApexDestruction;

[UClass(Flags = (ClassFlags)821039268uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/ApexDestruction.DestructibleComponent", "ApexDestruction", UnrealModuleType.EnginePlugin)]
public class UDestructibleComponent : USkinnedMeshComponent, IDestructibleInterface, IInterface
{
	private static bool FractureEffectOverride_IsValid;

	private static FFieldAddress FractureEffectOverride_PropertyAddress;

	private static int FractureEffectOverride_Offset;

	private static bool FractureEffects_IsValid;

	private static FFieldAddress FractureEffects_PropertyAddress;

	private static int FractureEffects_Offset;

	private TArrayReadOnlyMarshaler<FFractureEffect> FractureEffects_MarshalerCached;

	private static bool EnableHardSleeping_IsValid;

	private static FFieldAddress EnableHardSleeping_PropertyAddress;

	private static int EnableHardSleeping_Offset;

	private static bool LargeChunkThreshold_IsValid;

	private static int LargeChunkThreshold_Offset;

	private static bool DestructibleMesh_IsValid;

	private static int DestructibleMesh_Offset;

	private static bool OnComponentFracture_IsValid;

	private static int OnComponentFracture_Offset;

	private FComponentFractureSignature OnComponentFracture_DelegateCached;

	private static bool SetDestructibleMesh_IsValid;

	private static IntPtr SetDestructibleMesh_FunctionAddress;

	private static int SetDestructibleMesh_ParamsSize;

	private static bool SetDestructibleMesh_NewMesh_IsValid;

	private static FFieldAddress SetDestructibleMesh_NewMesh_PropertyAddress;

	private static int SetDestructibleMesh_NewMesh_Offset;

	private static bool GetDestructibleMesh_IsValid;

	private static IntPtr GetDestructibleMesh_FunctionAddress;

	private static int GetDestructibleMesh_ParamsSize;

	private static bool GetDestructibleMesh_ReturnValue_IsValid;

	private static FFieldAddress GetDestructibleMesh_ReturnValue_PropertyAddress;

	private static int GetDestructibleMesh_ReturnValue_Offset;

	private static bool ApplyRadiusDamage_IsValid;

	private static IntPtr ApplyRadiusDamage_FunctionAddress;

	private static int ApplyRadiusDamage_ParamsSize;

	private static bool ApplyRadiusDamage_BaseDamage_IsValid;

	private static FFieldAddress ApplyRadiusDamage_BaseDamage_PropertyAddress;

	private static int ApplyRadiusDamage_BaseDamage_Offset;

	private static bool ApplyRadiusDamage_HurtOrigin_IsValid;

	private static FFieldAddress ApplyRadiusDamage_HurtOrigin_PropertyAddress;

	private static int ApplyRadiusDamage_HurtOrigin_Offset;

	private static bool ApplyRadiusDamage_DamageRadius_IsValid;

	private static FFieldAddress ApplyRadiusDamage_DamageRadius_PropertyAddress;

	private static int ApplyRadiusDamage_DamageRadius_Offset;

	private static bool ApplyRadiusDamage_ImpulseStrength_IsValid;

	private static FFieldAddress ApplyRadiusDamage_ImpulseStrength_PropertyAddress;

	private static int ApplyRadiusDamage_ImpulseStrength_Offset;

	private static bool ApplyRadiusDamage_bFullDamage_IsValid;

	private static FFieldAddress ApplyRadiusDamage_bFullDamage_PropertyAddress;

	private static int ApplyRadiusDamage_bFullDamage_Offset;

	private static bool ApplyDamage_IsValid;

	private static IntPtr ApplyDamage_FunctionAddress;

	private static int ApplyDamage_ParamsSize;

	private static bool ApplyDamage_DamageAmount_IsValid;

	private static FFieldAddress ApplyDamage_DamageAmount_PropertyAddress;

	private static int ApplyDamage_DamageAmount_Offset;

	private static bool ApplyDamage_HitLocation_IsValid;

	private static FFieldAddress ApplyDamage_HitLocation_PropertyAddress;

	private static int ApplyDamage_HitLocation_Offset;

	private static bool ApplyDamage_ImpulseDir_IsValid;

	private static FFieldAddress ApplyDamage_ImpulseDir_PropertyAddress;

	private static int ApplyDamage_ImpulseDir_Offset;

	private static bool ApplyDamage_ImpulseStrength_IsValid;

	private static FFieldAddress ApplyDamage_ImpulseStrength_PropertyAddress;

	private static int ApplyDamage_ImpulseStrength_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/ApexDestruction.DestructibleComponent:bFractureEffectOverride")]
	public bool FractureEffectOverride
	{
		get
		{
			CheckDestroyed();
			if (!FractureEffectOverride_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ApexDestruction.DestructibleComponent:bFractureEffectOverride");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, FractureEffectOverride_Offset), 0, FractureEffectOverride_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!FractureEffectOverride_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ApexDestruction.DestructibleComponent:bFractureEffectOverride");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, FractureEffectOverride_Offset), 0, FractureEffectOverride_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371093uL)]
	[UMetaPath("/Script/ApexDestruction.DestructibleComponent:FractureEffects")]
	public TArrayReadOnly<FFractureEffect> FractureEffects
	{
		get
		{
			CheckDestroyed();
			if (!FractureEffects_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ApexDestruction.DestructibleComponent:FractureEffects");
				return null;
			}
			if (FractureEffects_MarshalerCached == null)
			{
				FractureEffects_MarshalerCached = new TArrayReadOnlyMarshaler<FFractureEffect>(1, FractureEffects_PropertyAddress, CachedMarshalingDelegates<FFractureEffect, FFractureEffect>.FromNative, CachedMarshalingDelegates<FFractureEffect, FFractureEffect>.ToNative);
			}
			return FractureEffects_MarshalerCached.FromNative(IntPtr.Add(base.Address, FractureEffects_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ApexDestruction.DestructibleComponent:bEnableHardSleeping")]
	public bool EnableHardSleeping
	{
		get
		{
			CheckDestroyed();
			if (!EnableHardSleeping_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ApexDestruction.DestructibleComponent:bEnableHardSleeping");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableHardSleeping_Offset), 0, EnableHardSleeping_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableHardSleeping_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ApexDestruction.DestructibleComponent:bEnableHardSleeping");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableHardSleeping_Offset), 0, EnableHardSleeping_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ApexDestruction.DestructibleComponent:LargeChunkThreshold")]
	public float LargeChunkThreshold
	{
		get
		{
			CheckDestroyed();
			if (!LargeChunkThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ApexDestruction.DestructibleComponent:LargeChunkThreshold");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LargeChunkThreshold_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LargeChunkThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ApexDestruction.DestructibleComponent:LargeChunkThreshold");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LargeChunkThreshold_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755503594021381uL)]
	[UMetaPath("/Script/ApexDestruction.DestructibleComponent:DestructibleMesh")]
	public UDestructibleMesh DestructibleMesh
	{
		get
		{
			CheckDestroyed();
			if (!DestructibleMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ApexDestruction.DestructibleComponent:DestructibleMesh");
				return null;
			}
			return UObjectMarshaler<UDestructibleMesh>.FromNative(IntPtr.Add(base.Address, DestructibleMesh_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DestructibleMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ApexDestruction.DestructibleComponent:DestructibleMesh");
			}
			else
			{
				UObjectMarshaler<UDestructibleMesh>.ToNative(IntPtr.Add(base.Address, DestructibleMesh_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/ApexDestruction.DestructibleComponent:OnComponentFracture")]
	public FComponentFractureSignature OnComponentFracture
	{
		get
		{
			CheckDestroyed();
			if (!OnComponentFracture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ApexDestruction.DestructibleComponent:OnComponentFracture");
				return new FComponentFractureSignature();
			}
			if (OnComponentFracture_DelegateCached == null)
			{
				OnComponentFracture_DelegateCached = new FComponentFractureSignature();
				OnComponentFracture_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnComponentFracture_Offset));
			}
			return OnComponentFracture_DelegateCached;
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ApexDestruction.DestructibleComponent:SetDestructibleMesh")]
	public unsafe void SetDestructibleMesh(UDestructibleMesh NewMesh)
	{
		CheckDestroyed();
		if (!SetDestructibleMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ApexDestruction.DestructibleComponent:SetDestructibleMesh");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDestructibleMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDestructibleMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDestructibleMesh>.ToNative(IntPtr.Add(intPtr, SetDestructibleMesh_NewMesh_Offset), 0, SetDestructibleMesh_NewMesh_PropertyAddress.Address, NewMesh);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetDestructibleMesh_FunctionAddress, intPtr, SetDestructibleMesh_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ApexDestruction.DestructibleComponent:GetDestructibleMesh")]
	public unsafe UDestructibleMesh GetDestructibleMesh()
	{
		CheckDestroyed();
		if (!GetDestructibleMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ApexDestruction.DestructibleComponent:GetDestructibleMesh");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDestructibleMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDestructibleMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDestructibleMesh_FunctionAddress, intPtr, GetDestructibleMesh_ParamsSize);
		return UObjectMarshaler<UDestructibleMesh>.FromNative(IntPtr.Add(intPtr, GetDestructibleMesh_ReturnValue_Offset), 0, GetDestructibleMesh_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79823872u)]
	[UMetaPath("/Script/ApexDestruction.DestructibleComponent:ApplyRadiusDamage")]
	public unsafe void ApplyRadiusDamage(float BaseDamage, FVector3f HurtOrigin, float DamageRadius, float ImpulseStrength, bool bFullDamage)
	{
		CheckDestroyed();
		if (!ApplyRadiusDamage_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ApexDestruction.DestructibleComponent:ApplyRadiusDamage");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ApplyRadiusDamage_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ApplyRadiusDamage_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ApplyRadiusDamage_BaseDamage_Offset), 0, ApplyRadiusDamage_BaseDamage_PropertyAddress.Address, BaseDamage);
		FVector3f.ToNative(IntPtr.Add(intPtr, ApplyRadiusDamage_HurtOrigin_Offset), 0, ApplyRadiusDamage_HurtOrigin_PropertyAddress.Address, HurtOrigin);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ApplyRadiusDamage_DamageRadius_Offset), 0, ApplyRadiusDamage_DamageRadius_PropertyAddress.Address, DamageRadius);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ApplyRadiusDamage_ImpulseStrength_Offset), 0, ApplyRadiusDamage_ImpulseStrength_PropertyAddress.Address, ImpulseStrength);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ApplyRadiusDamage_bFullDamage_Offset), 0, ApplyRadiusDamage_bFullDamage_PropertyAddress.Address, bFullDamage);
		NativeReflection.InvokeFunctionOptimized(base.Address, ApplyRadiusDamage_FunctionAddress, intPtr, ApplyRadiusDamage_ParamsSize);
	}

	[UFunction(Flags = 79823872u)]
	[UMetaPath("/Script/ApexDestruction.DestructibleComponent:ApplyDamage")]
	public unsafe void ApplyDamage(float DamageAmount, FVector3f HitLocation, FVector3f ImpulseDir, float ImpulseStrength)
	{
		CheckDestroyed();
		if (!ApplyDamage_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ApexDestruction.DestructibleComponent:ApplyDamage");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ApplyDamage_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ApplyDamage_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ApplyDamage_DamageAmount_Offset), 0, ApplyDamage_DamageAmount_PropertyAddress.Address, DamageAmount);
		FVector3f.ToNative(IntPtr.Add(intPtr, ApplyDamage_HitLocation_Offset), 0, ApplyDamage_HitLocation_PropertyAddress.Address, HitLocation);
		FVector3f.ToNative(IntPtr.Add(intPtr, ApplyDamage_ImpulseDir_Offset), 0, ApplyDamage_ImpulseDir_PropertyAddress.Address, ImpulseDir);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ApplyDamage_ImpulseStrength_Offset), 0, ApplyDamage_ImpulseStrength_PropertyAddress.Address, ImpulseStrength);
		NativeReflection.InvokeFunctionOptimized(base.Address, ApplyDamage_FunctionAddress, intPtr, ApplyDamage_ParamsSize);
	}

	static UDestructibleComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UDestructibleComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UDestructibleComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/ApexDestruction.DestructibleComponent");
		NativeReflectionCached.GetPropertyRef(ref FractureEffectOverride_PropertyAddress, intPtr, "bFractureEffectOverride");
		FractureEffectOverride_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bFractureEffectOverride");
		FractureEffectOverride_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bFractureEffectOverride", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref FractureEffects_PropertyAddress, intPtr, "FractureEffects");
		FractureEffects_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FractureEffects");
		FractureEffects_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FractureEffects", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableHardSleeping_PropertyAddress, intPtr, "bEnableHardSleeping");
		EnableHardSleeping_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnableHardSleeping");
		EnableHardSleeping_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnableHardSleeping", Classes.FBoolProperty);
		LargeChunkThreshold_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LargeChunkThreshold");
		LargeChunkThreshold_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LargeChunkThreshold", Classes.FFloatProperty);
		DestructibleMesh_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DestructibleMesh");
		DestructibleMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DestructibleMesh", Classes.FObjectProperty);
		OnComponentFracture_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnComponentFracture");
		OnComponentFracture_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnComponentFracture", Classes.FMulticastDelegateProperty);
		SetDestructibleMesh_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetDestructibleMesh");
		SetDestructibleMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDestructibleMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDestructibleMesh_NewMesh_PropertyAddress, SetDestructibleMesh_FunctionAddress, "NewMesh");
		SetDestructibleMesh_NewMesh_Offset = NativeReflectionCached.GetPropertyOffset(SetDestructibleMesh_FunctionAddress, "NewMesh");
		SetDestructibleMesh_NewMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDestructibleMesh_FunctionAddress, "NewMesh", Classes.FObjectProperty);
		SetDestructibleMesh_IsValid = SetDestructibleMesh_FunctionAddress != IntPtr.Zero && SetDestructibleMesh_NewMesh_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ApexDestruction.DestructibleComponent:SetDestructibleMesh", SetDestructibleMesh_IsValid);
		GetDestructibleMesh_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDestructibleMesh");
		GetDestructibleMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDestructibleMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDestructibleMesh_ReturnValue_PropertyAddress, GetDestructibleMesh_FunctionAddress, "ReturnValue");
		GetDestructibleMesh_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDestructibleMesh_FunctionAddress, "ReturnValue");
		GetDestructibleMesh_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDestructibleMesh_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetDestructibleMesh_IsValid = GetDestructibleMesh_FunctionAddress != IntPtr.Zero && GetDestructibleMesh_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ApexDestruction.DestructibleComponent:GetDestructibleMesh", GetDestructibleMesh_IsValid);
		ApplyRadiusDamage_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ApplyRadiusDamage");
		ApplyRadiusDamage_ParamsSize = NativeReflection.GetFunctionParamsSize(ApplyRadiusDamage_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ApplyRadiusDamage_BaseDamage_PropertyAddress, ApplyRadiusDamage_FunctionAddress, "BaseDamage");
		ApplyRadiusDamage_BaseDamage_Offset = NativeReflectionCached.GetPropertyOffset(ApplyRadiusDamage_FunctionAddress, "BaseDamage");
		ApplyRadiusDamage_BaseDamage_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyRadiusDamage_FunctionAddress, "BaseDamage", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyRadiusDamage_HurtOrigin_PropertyAddress, ApplyRadiusDamage_FunctionAddress, "HurtOrigin");
		ApplyRadiusDamage_HurtOrigin_Offset = NativeReflectionCached.GetPropertyOffset(ApplyRadiusDamage_FunctionAddress, "HurtOrigin");
		ApplyRadiusDamage_HurtOrigin_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyRadiusDamage_FunctionAddress, "HurtOrigin", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyRadiusDamage_DamageRadius_PropertyAddress, ApplyRadiusDamage_FunctionAddress, "DamageRadius");
		ApplyRadiusDamage_DamageRadius_Offset = NativeReflectionCached.GetPropertyOffset(ApplyRadiusDamage_FunctionAddress, "DamageRadius");
		ApplyRadiusDamage_DamageRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyRadiusDamage_FunctionAddress, "DamageRadius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyRadiusDamage_ImpulseStrength_PropertyAddress, ApplyRadiusDamage_FunctionAddress, "ImpulseStrength");
		ApplyRadiusDamage_ImpulseStrength_Offset = NativeReflectionCached.GetPropertyOffset(ApplyRadiusDamage_FunctionAddress, "ImpulseStrength");
		ApplyRadiusDamage_ImpulseStrength_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyRadiusDamage_FunctionAddress, "ImpulseStrength", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyRadiusDamage_bFullDamage_PropertyAddress, ApplyRadiusDamage_FunctionAddress, "bFullDamage");
		ApplyRadiusDamage_bFullDamage_Offset = NativeReflectionCached.GetPropertyOffset(ApplyRadiusDamage_FunctionAddress, "bFullDamage");
		ApplyRadiusDamage_bFullDamage_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyRadiusDamage_FunctionAddress, "bFullDamage", Classes.FBoolProperty);
		ApplyRadiusDamage_IsValid = ApplyRadiusDamage_FunctionAddress != IntPtr.Zero && ApplyRadiusDamage_BaseDamage_IsValid && ApplyRadiusDamage_HurtOrigin_IsValid && ApplyRadiusDamage_DamageRadius_IsValid && ApplyRadiusDamage_ImpulseStrength_IsValid && ApplyRadiusDamage_bFullDamage_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ApexDestruction.DestructibleComponent:ApplyRadiusDamage", ApplyRadiusDamage_IsValid);
		ApplyDamage_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ApplyDamage");
		ApplyDamage_ParamsSize = NativeReflection.GetFunctionParamsSize(ApplyDamage_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ApplyDamage_DamageAmount_PropertyAddress, ApplyDamage_FunctionAddress, "DamageAmount");
		ApplyDamage_DamageAmount_Offset = NativeReflectionCached.GetPropertyOffset(ApplyDamage_FunctionAddress, "DamageAmount");
		ApplyDamage_DamageAmount_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyDamage_FunctionAddress, "DamageAmount", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyDamage_HitLocation_PropertyAddress, ApplyDamage_FunctionAddress, "HitLocation");
		ApplyDamage_HitLocation_Offset = NativeReflectionCached.GetPropertyOffset(ApplyDamage_FunctionAddress, "HitLocation");
		ApplyDamage_HitLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyDamage_FunctionAddress, "HitLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyDamage_ImpulseDir_PropertyAddress, ApplyDamage_FunctionAddress, "ImpulseDir");
		ApplyDamage_ImpulseDir_Offset = NativeReflectionCached.GetPropertyOffset(ApplyDamage_FunctionAddress, "ImpulseDir");
		ApplyDamage_ImpulseDir_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyDamage_FunctionAddress, "ImpulseDir", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyDamage_ImpulseStrength_PropertyAddress, ApplyDamage_FunctionAddress, "ImpulseStrength");
		ApplyDamage_ImpulseStrength_Offset = NativeReflectionCached.GetPropertyOffset(ApplyDamage_FunctionAddress, "ImpulseStrength");
		ApplyDamage_ImpulseStrength_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyDamage_FunctionAddress, "ImpulseStrength", Classes.FFloatProperty);
		ApplyDamage_IsValid = ApplyDamage_FunctionAddress != IntPtr.Zero && ApplyDamage_DamageAmount_IsValid && ApplyDamage_HitLocation_IsValid && ApplyDamage_ImpulseDir_IsValid && ApplyDamage_ImpulseStrength_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ApexDestruction.DestructibleComponent:ApplyDamage", ApplyDamage_IsValid);
	}
}

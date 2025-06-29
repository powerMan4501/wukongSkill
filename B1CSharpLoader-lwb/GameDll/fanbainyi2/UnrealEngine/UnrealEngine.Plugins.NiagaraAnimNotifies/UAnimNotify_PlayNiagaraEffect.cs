using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.NiagaraAnimNotifies;

[UClass(Flags = (ClassFlags)810623136uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/NiagaraAnimNotifies.AnimNotify_PlayNiagaraEffect", "NiagaraAnimNotifies", UnrealModuleType.EnginePlugin)]
public class UAnimNotify_PlayNiagaraEffect : UAnimNotify
{
	private static bool Template_IsValid;

	private static int Template_Offset;

	private static bool LocationOffset_IsValid;

	private static int LocationOffset_Offset;

	private static bool RotationOffset_IsValid;

	private static int RotationOffset_Offset;

	private static bool Attached_IsValid;

	private static FFieldAddress Attached_PropertyAddress;

	private static int Attached_Offset;

	private static bool SocketName_IsValid;

	private static int SocketName_Offset;

	private static bool GetSpawnedEffect_IsValid;

	private static IntPtr GetSpawnedEffect_FunctionAddress;

	private static int GetSpawnedEffect_ParamsSize;

	private static bool GetSpawnedEffect_ReturnValue_IsValid;

	private static FFieldAddress GetSpawnedEffect_ReturnValue_PropertyAddress;

	private static int GetSpawnedEffect_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)7881369141117461uL)]
	[UMetaPath("/Script/NiagaraAnimNotifies.AnimNotify_PlayNiagaraEffect:Template")]
	public UNiagaraSystem Template
	{
		get
		{
			CheckDestroyed();
			if (!Template_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/NiagaraAnimNotifies.AnimNotify_PlayNiagaraEffect:Template");
				return null;
			}
			return UObjectMarshaler<UNiagaraSystem>.FromNative(IntPtr.Add(base.Address, Template_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Template_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/NiagaraAnimNotifies.AnimNotify_PlayNiagaraEffect:Template");
			}
			else
			{
				UObjectMarshaler<UNiagaraSystem>.ToNative(IntPtr.Add(base.Address, Template_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/NiagaraAnimNotifies.AnimNotify_PlayNiagaraEffect:LocationOffset")]
	public FVector LocationOffset
	{
		get
		{
			CheckDestroyed();
			if (!LocationOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/NiagaraAnimNotifies.AnimNotify_PlayNiagaraEffect:LocationOffset");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, LocationOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LocationOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/NiagaraAnimNotifies.AnimNotify_PlayNiagaraEffect:LocationOffset");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, LocationOffset_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503669420589589uL)]
	[UMetaPath("/Script/NiagaraAnimNotifies.AnimNotify_PlayNiagaraEffect:RotationOffset")]
	public FRotator RotationOffset
	{
		get
		{
			CheckDestroyed();
			if (!RotationOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/NiagaraAnimNotifies.AnimNotify_PlayNiagaraEffect:RotationOffset");
				return default(FRotator);
			}
			return BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(base.Address, RotationOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RotationOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/NiagaraAnimNotifies.AnimNotify_PlayNiagaraEffect:RotationOffset");
			}
			else
			{
				BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(base.Address, RotationOffset_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/NiagaraAnimNotifies.AnimNotify_PlayNiagaraEffect:Attached")]
	public bool Attached
	{
		get
		{
			CheckDestroyed();
			if (!Attached_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/NiagaraAnimNotifies.AnimNotify_PlayNiagaraEffect:Attached");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Attached_Offset), 0, Attached_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Attached_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/NiagaraAnimNotifies.AnimNotify_PlayNiagaraEffect:Attached");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Attached_Offset), 0, Attached_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/NiagaraAnimNotifies.AnimNotify_PlayNiagaraEffect:SocketName")]
	public FName SocketName
	{
		get
		{
			CheckDestroyed();
			if (!SocketName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/NiagaraAnimNotifies.AnimNotify_PlayNiagaraEffect:SocketName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, SocketName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SocketName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/NiagaraAnimNotifies.AnimNotify_PlayNiagaraEffect:SocketName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, SocketName_Offset), value);
			}
		}
	}

	[UFunction(Flags = 1140982785u)]
	[UMetaPath("/Script/NiagaraAnimNotifies.AnimNotify_PlayNiagaraEffect:GetSpawnedEffect")]
	public unsafe UFXSystemComponent GetSpawnedEffect()
	{
		CheckDestroyed();
		if (!GetSpawnedEffect_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/NiagaraAnimNotifies.AnimNotify_PlayNiagaraEffect:GetSpawnedEffect");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSpawnedEffect_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSpawnedEffect_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSpawnedEffect_FunctionAddress, intPtr, GetSpawnedEffect_ParamsSize);
		return UObjectMarshaler<UFXSystemComponent>.FromNative(IntPtr.Add(intPtr, GetSpawnedEffect_ReturnValue_Offset), 0, GetSpawnedEffect_ReturnValue_PropertyAddress.Address);
	}

	static UAnimNotify_PlayNiagaraEffect()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAnimNotify_PlayNiagaraEffect)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAnimNotify_PlayNiagaraEffect));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/NiagaraAnimNotifies.AnimNotify_PlayNiagaraEffect");
		Template_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Template");
		Template_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Template", Classes.FObjectProperty);
		LocationOffset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LocationOffset");
		LocationOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LocationOffset", Classes.FStructProperty);
		RotationOffset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RotationOffset");
		RotationOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RotationOffset", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Attached_PropertyAddress, intPtr, "Attached");
		Attached_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Attached");
		Attached_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Attached", Classes.FBoolProperty);
		SocketName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SocketName");
		SocketName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SocketName", Classes.FNameProperty);
		GetSpawnedEffect_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSpawnedEffect");
		GetSpawnedEffect_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSpawnedEffect_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSpawnedEffect_ReturnValue_PropertyAddress, GetSpawnedEffect_FunctionAddress, "ReturnValue");
		GetSpawnedEffect_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSpawnedEffect_FunctionAddress, "ReturnValue");
		GetSpawnedEffect_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSpawnedEffect_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetSpawnedEffect_IsValid = GetSpawnedEffect_FunctionAddress != IntPtr.Zero && GetSpawnedEffect_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/NiagaraAnimNotifies.AnimNotify_PlayNiagaraEffect:GetSpawnedEffect", GetSpawnedEffect_IsValid);
	}
}

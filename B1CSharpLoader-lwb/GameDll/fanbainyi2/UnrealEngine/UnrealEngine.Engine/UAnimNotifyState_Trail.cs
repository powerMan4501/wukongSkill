using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)810627232uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Engine.AnimNotifyState_Trail", "Engine", UnrealModuleType.Engine)]
public class UAnimNotifyState_Trail : UAnimNotifyState
{
	private static bool PSTemplate_IsValid;

	private static int PSTemplate_Offset;

	private static bool FirstSocketName_IsValid;

	private static int FirstSocketName_Offset;

	private static bool SecondSocketName_IsValid;

	private static int SecondSocketName_Offset;

	private static bool WidthScaleMode_IsValid;

	private static FFieldAddress WidthScaleMode_PropertyAddress;

	private static int WidthScaleMode_Offset;

	private static bool WidthScaleCurve_IsValid;

	private static int WidthScaleCurve_Offset;

	private static bool RecycleSpawnedSystems_IsValid;

	private static FFieldAddress RecycleSpawnedSystems_PropertyAddress;

	private static int RecycleSpawnedSystems_Offset;

	private static bool OverridePSTemplate_IsValid;

	private IntPtr OverridePSTemplate_InstanceFunctionAddress;

	private static IntPtr OverridePSTemplate_FunctionAddress;

	private static int OverridePSTemplate_ParamsSize;

	private static bool OverridePSTemplate_MeshComp_IsValid;

	private static FFieldAddress OverridePSTemplate_MeshComp_PropertyAddress;

	private static int OverridePSTemplate_MeshComp_Offset;

	private static bool OverridePSTemplate_Animation_IsValid;

	private static FFieldAddress OverridePSTemplate_Animation_PropertyAddress;

	private static int OverridePSTemplate_Animation_Offset;

	private static bool OverridePSTemplate_ReturnValue_IsValid;

	private static FFieldAddress OverridePSTemplate_ReturnValue_PropertyAddress;

	private static int OverridePSTemplate_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)7881369141117461uL)]
	[UMetaPath("/Script/Engine.AnimNotifyState_Trail:PSTemplate")]
	public UParticleSystem PSTemplate
	{
		get
		{
			CheckDestroyed();
			if (!PSTemplate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimNotifyState_Trail:PSTemplate");
				return null;
			}
			return UObjectMarshaler<UParticleSystem>.FromNative(IntPtr.Add(base.Address, PSTemplate_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PSTemplate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimNotifyState_Trail:PSTemplate");
			}
			else
			{
				UObjectMarshaler<UParticleSystem>.ToNative(IntPtr.Add(base.Address, PSTemplate_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.AnimNotifyState_Trail:FirstSocketName")]
	public FName FirstSocketName
	{
		get
		{
			CheckDestroyed();
			if (!FirstSocketName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimNotifyState_Trail:FirstSocketName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, FirstSocketName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FirstSocketName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimNotifyState_Trail:FirstSocketName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, FirstSocketName_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.AnimNotifyState_Trail:SecondSocketName")]
	public FName SecondSocketName
	{
		get
		{
			CheckDestroyed();
			if (!SecondSocketName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimNotifyState_Trail:SecondSocketName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, SecondSocketName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SecondSocketName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimNotifyState_Trail:SecondSocketName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, SecondSocketName_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.AnimNotifyState_Trail:WidthScaleMode")]
	public ETrailWidthMode WidthScaleMode
	{
		get
		{
			CheckDestroyed();
			if (!WidthScaleMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimNotifyState_Trail:WidthScaleMode");
				return ETrailWidthMode.ETrailWidthMode_FromCentre;
			}
			return EnumMarshaler<ETrailWidthMode>.FromNative(IntPtr.Add(base.Address, WidthScaleMode_Offset), 0, WidthScaleMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!WidthScaleMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimNotifyState_Trail:WidthScaleMode");
			}
			else
			{
				EnumMarshaler<ETrailWidthMode>.ToNative(IntPtr.Add(base.Address, WidthScaleMode_Offset), 0, WidthScaleMode_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.AnimNotifyState_Trail:WidthScaleCurve")]
	public FName WidthScaleCurve
	{
		get
		{
			CheckDestroyed();
			if (!WidthScaleCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimNotifyState_Trail:WidthScaleCurve");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, WidthScaleCurve_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WidthScaleCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimNotifyState_Trail:WidthScaleCurve");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, WidthScaleCurve_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.AnimNotifyState_Trail:bRecycleSpawnedSystems")]
	public bool RecycleSpawnedSystems
	{
		get
		{
			CheckDestroyed();
			if (!RecycleSpawnedSystems_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimNotifyState_Trail:bRecycleSpawnedSystems");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, RecycleSpawnedSystems_Offset), 0, RecycleSpawnedSystems_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!RecycleSpawnedSystems_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimNotifyState_Trail:bRecycleSpawnedSystems");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, RecycleSpawnedSystems_Offset), 0, RecycleSpawnedSystems_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 1208092672u)]
	[UMetaPath("/Script/Engine.AnimNotifyState_Trail:OverridePSTemplate")]
	public unsafe UParticleSystem OverridePSTemplate(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation)
	{
		CheckDestroyed();
		if (!OverridePSTemplate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimNotifyState_Trail:OverridePSTemplate");
			return null;
		}
		if (OverridePSTemplate_InstanceFunctionAddress == IntPtr.Zero)
		{
			OverridePSTemplate_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OverridePSTemplate");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OverridePSTemplate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OverridePSTemplate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMeshComponent>.ToNative(IntPtr.Add(intPtr, OverridePSTemplate_MeshComp_Offset), 0, OverridePSTemplate_MeshComp_PropertyAddress.Address, MeshComp);
		UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(intPtr, OverridePSTemplate_Animation_Offset), 0, OverridePSTemplate_Animation_PropertyAddress.Address, Animation);
		NativeReflection.InvokeFunctionOptimized(base.Address, OverridePSTemplate_InstanceFunctionAddress, intPtr, OverridePSTemplate_ParamsSize);
		return UObjectMarshaler<UParticleSystem>.FromNative(IntPtr.Add(intPtr, OverridePSTemplate_ReturnValue_Offset), 0, OverridePSTemplate_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual UParticleSystem OverridePSTemplate_Implementation(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation)
	{
		CheckDestroyed();
		if (!OverridePSTemplate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimNotifyState_Trail:OverridePSTemplate");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OverridePSTemplate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OverridePSTemplate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMeshComponent>.ToNative(IntPtr.Add(intPtr, OverridePSTemplate_MeshComp_Offset), 0, OverridePSTemplate_MeshComp_PropertyAddress.Address, MeshComp);
		UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(intPtr, OverridePSTemplate_Animation_Offset), 0, OverridePSTemplate_Animation_PropertyAddress.Address, Animation);
		NativeReflection.InvokeFunctionOptimized(base.Address, OverridePSTemplate_FunctionAddress, intPtr, OverridePSTemplate_ParamsSize);
		return UObjectMarshaler<UParticleSystem>.FromNative(IntPtr.Add(intPtr, OverridePSTemplate_ReturnValue_Offset), 0, OverridePSTemplate_ReturnValue_PropertyAddress.Address);
	}

	static UAnimNotifyState_Trail()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAnimNotifyState_Trail)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAnimNotifyState_Trail));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.AnimNotifyState_Trail");
		PSTemplate_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PSTemplate");
		PSTemplate_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PSTemplate", Classes.FObjectProperty);
		FirstSocketName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FirstSocketName");
		FirstSocketName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FirstSocketName", Classes.FNameProperty);
		SecondSocketName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SecondSocketName");
		SecondSocketName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SecondSocketName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref WidthScaleMode_PropertyAddress, intPtr, "WidthScaleMode");
		WidthScaleMode_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WidthScaleMode");
		WidthScaleMode_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WidthScaleMode", Classes.FByteProperty);
		WidthScaleCurve_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WidthScaleCurve");
		WidthScaleCurve_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WidthScaleCurve", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref RecycleSpawnedSystems_PropertyAddress, intPtr, "bRecycleSpawnedSystems");
		RecycleSpawnedSystems_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bRecycleSpawnedSystems");
		RecycleSpawnedSystems_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bRecycleSpawnedSystems", Classes.FBoolProperty);
		OverridePSTemplate_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OverridePSTemplate");
		OverridePSTemplate_ParamsSize = NativeReflection.GetFunctionParamsSize(OverridePSTemplate_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OverridePSTemplate_MeshComp_PropertyAddress, OverridePSTemplate_FunctionAddress, "MeshComp");
		OverridePSTemplate_MeshComp_Offset = NativeReflectionCached.GetPropertyOffset(OverridePSTemplate_FunctionAddress, "MeshComp");
		OverridePSTemplate_MeshComp_IsValid = NativeReflectionCached.ValidatePropertyClass(OverridePSTemplate_FunctionAddress, "MeshComp", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref OverridePSTemplate_Animation_PropertyAddress, OverridePSTemplate_FunctionAddress, "Animation");
		OverridePSTemplate_Animation_Offset = NativeReflectionCached.GetPropertyOffset(OverridePSTemplate_FunctionAddress, "Animation");
		OverridePSTemplate_Animation_IsValid = NativeReflectionCached.ValidatePropertyClass(OverridePSTemplate_FunctionAddress, "Animation", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref OverridePSTemplate_ReturnValue_PropertyAddress, OverridePSTemplate_FunctionAddress, "ReturnValue");
		OverridePSTemplate_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(OverridePSTemplate_FunctionAddress, "ReturnValue");
		OverridePSTemplate_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(OverridePSTemplate_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		OverridePSTemplate_IsValid = OverridePSTemplate_FunctionAddress != IntPtr.Zero && OverridePSTemplate_MeshComp_IsValid && OverridePSTemplate_Animation_IsValid && OverridePSTemplate_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimNotifyState_Trail:OverridePSTemplate", OverridePSTemplate_IsValid);
	}
}

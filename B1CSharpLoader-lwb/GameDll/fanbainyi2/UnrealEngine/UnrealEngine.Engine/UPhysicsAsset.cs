using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818414756uL, Config = "Game")]
[BlueprintType]
[UMetaPath("/Script/Engine.PhysicsAsset", "Engine", UnrealModuleType.Engine)]
public class UPhysicsAsset : UObject, IInterface_PreviewMeshProvider, IInterface
{
	private static bool PreviewSkeletalMesh_IsValid;

	private static int PreviewSkeletalMesh_Offset;

	private static bool PhysicalAnimationProfiles_IsValid;

	private static FFieldAddress PhysicalAnimationProfiles_PropertyAddress;

	private static int PhysicalAnimationProfiles_Offset;

	private TArrayReadWriteMarshaler<FName> PhysicalAnimationProfiles_MarshalerCached;

	private static bool ConstraintProfiles_IsValid;

	private static FFieldAddress ConstraintProfiles_PropertyAddress;

	private static int ConstraintProfiles_Offset;

	private TArrayReadWriteMarshaler<FName> ConstraintProfiles_MarshalerCached;

	private static bool CurrentPhysicalAnimationProfileName_IsValid;

	private static int CurrentPhysicalAnimationProfileName_Offset;

	private static bool CurrentConstraintProfileName_IsValid;

	private static int CurrentConstraintProfileName_Offset;

	private static bool BoundsBodies_IsValid;

	private static FFieldAddress BoundsBodies_PropertyAddress;

	private static int BoundsBodies_Offset;

	private TArrayReadWriteMarshaler<int> BoundsBodies_MarshalerCached;

	private static bool SkeletalBodySetups_IsValid;

	private static FFieldAddress SkeletalBodySetups_PropertyAddress;

	private static int SkeletalBodySetups_Offset;

	private TArrayReadWriteMarshaler<USkeletalBodySetup> SkeletalBodySetups_MarshalerCached;

	private static bool ConstraintSetup_IsValid;

	private static FFieldAddress ConstraintSetup_PropertyAddress;

	private static int ConstraintSetup_Offset;

	private TArrayReadWriteMarshaler<UPhysicsConstraintTemplate> ConstraintSetup_MarshalerCached;

	private static bool SolverSettings_IsValid;

	private static int SolverSettings_Offset;

	private static bool SolverIterations_IsValid;

	private static int SolverIterations_Offset;

	private static bool SolverType_IsValid;

	private static FFieldAddress SolverType_PropertyAddress;

	private static int SolverType_Offset;

	private static bool NotForDedicatedServer_IsValid;

	private static FFieldAddress NotForDedicatedServer_PropertyAddress;

	private static int NotForDedicatedServer_Offset;

	private static bool ThumbnailInfo_IsValid;

	private static int ThumbnailInfo_Offset;

	private static bool GetConstraints_IsValid;

	private static IntPtr GetConstraints_FunctionAddress;

	private static int GetConstraints_ParamsSize;

	private static bool GetConstraints_bIncludesTerminated_IsValid;

	private static FFieldAddress GetConstraints_bIncludesTerminated_PropertyAddress;

	private static int GetConstraints_bIncludesTerminated_Offset;

	private static bool GetConstraints_OutConstraints_IsValid;

	private static FFieldAddress GetConstraints_OutConstraints_PropertyAddress;

	private static int GetConstraints_OutConstraints_Offset;

	private static bool GetConstraintByName_IsValid;

	private static IntPtr GetConstraintByName_FunctionAddress;

	private static int GetConstraintByName_ParamsSize;

	private static bool GetConstraintByName_ConstraintName_IsValid;

	private static FFieldAddress GetConstraintByName_ConstraintName_PropertyAddress;

	private static int GetConstraintByName_ConstraintName_Offset;

	private static bool GetConstraintByName_ReturnValue_IsValid;

	private static FFieldAddress GetConstraintByName_ReturnValue_PropertyAddress;

	private static int GetConstraintByName_ReturnValue_Offset;

	private static bool GetConstraintByBoneNames_IsValid;

	private static IntPtr GetConstraintByBoneNames_FunctionAddress;

	private static int GetConstraintByBoneNames_ParamsSize;

	private static bool GetConstraintByBoneNames_Bone1Name_IsValid;

	private static FFieldAddress GetConstraintByBoneNames_Bone1Name_PropertyAddress;

	private static int GetConstraintByBoneNames_Bone1Name_Offset;

	private static bool GetConstraintByBoneNames_Bone2Name_IsValid;

	private static FFieldAddress GetConstraintByBoneNames_Bone2Name_PropertyAddress;

	private static int GetConstraintByBoneNames_Bone2Name_Offset;

	private static bool GetConstraintByBoneNames_ReturnValue_IsValid;

	private static FFieldAddress GetConstraintByBoneNames_ReturnValue_PropertyAddress;

	private static int GetConstraintByBoneNames_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)7882433219264512uL)]
	[UMetaPath("/Script/Engine.PhysicsAsset:PreviewSkeletalMesh")]
	public TSoftObject<USkeletalMesh> PreviewSkeletalMesh
	{
		get
		{
			CheckDestroyed();
			if (!PreviewSkeletalMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PhysicsAsset:PreviewSkeletalMesh");
				return default(TSoftObject<USkeletalMesh>);
			}
			return TSoftObjectMarshaler<USkeletalMesh>.FromNative(IntPtr.Add(base.Address, PreviewSkeletalMesh_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PreviewSkeletalMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PhysicsAsset:PreviewSkeletalMesh");
			}
			else
			{
				TSoftObjectMarshaler<USkeletalMesh>.ToNative(IntPtr.Add(base.Address, PreviewSkeletalMesh_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503633987109377uL)]
	[UMetaPath("/Script/Engine.PhysicsAsset:PhysicalAnimationProfiles")]
	public TArrayReadWrite<FName> PhysicalAnimationProfiles
	{
		get
		{
			CheckDestroyed();
			if (!PhysicalAnimationProfiles_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PhysicsAsset:PhysicalAnimationProfiles");
				return null;
			}
			if (PhysicalAnimationProfiles_MarshalerCached == null)
			{
				PhysicalAnimationProfiles_MarshalerCached = new TArrayReadWriteMarshaler<FName>(1, PhysicalAnimationProfiles_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
			}
			return PhysicalAnimationProfiles_MarshalerCached.FromNative(IntPtr.Add(base.Address, PhysicalAnimationProfiles_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4503633987109377uL)]
	[UMetaPath("/Script/Engine.PhysicsAsset:ConstraintProfiles")]
	public TArrayReadWrite<FName> ConstraintProfiles
	{
		get
		{
			CheckDestroyed();
			if (!ConstraintProfiles_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PhysicsAsset:ConstraintProfiles");
				return null;
			}
			if (ConstraintProfiles_MarshalerCached == null)
			{
				ConstraintProfiles_MarshalerCached = new TArrayReadWriteMarshaler<FName>(1, ConstraintProfiles_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
			}
			return ConstraintProfiles_MarshalerCached.FromNative(IntPtr.Add(base.Address, ConstraintProfiles_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)6755503594021376uL)]
	[UMetaPath("/Script/Engine.PhysicsAsset:CurrentPhysicalAnimationProfileName")]
	public FName CurrentPhysicalAnimationProfileName
	{
		get
		{
			CheckDestroyed();
			if (!CurrentPhysicalAnimationProfileName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PhysicsAsset:CurrentPhysicalAnimationProfileName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, CurrentPhysicalAnimationProfileName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CurrentPhysicalAnimationProfileName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PhysicsAsset:CurrentPhysicalAnimationProfileName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, CurrentPhysicalAnimationProfileName_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755503594021376uL)]
	[UMetaPath("/Script/Engine.PhysicsAsset:CurrentConstraintProfileName")]
	public FName CurrentConstraintProfileName
	{
		get
		{
			CheckDestroyed();
			if (!CurrentConstraintProfileName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PhysicsAsset:CurrentConstraintProfileName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, CurrentConstraintProfileName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CurrentConstraintProfileName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PhysicsAsset:CurrentConstraintProfileName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, CurrentConstraintProfileName_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371008uL)]
	[UMetaPath("/Script/Engine.PhysicsAsset:BoundsBodies")]
	public TArrayReadWrite<int> BoundsBodies
	{
		get
		{
			CheckDestroyed();
			if (!BoundsBodies_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PhysicsAsset:BoundsBodies");
				return null;
			}
			if (BoundsBodies_MarshalerCached == null)
			{
				BoundsBodies_MarshalerCached = new TArrayReadWriteMarshaler<int>(1, BoundsBodies_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return BoundsBodies_MarshalerCached.FromNative(IntPtr.Add(base.Address, BoundsBodies_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)5630049290027528uL)]
	[UMetaPath("/Script/Engine.PhysicsAsset:SkeletalBodySetups")]
	public TArrayReadWrite<USkeletalBodySetup> SkeletalBodySetups
	{
		get
		{
			CheckDestroyed();
			if (!SkeletalBodySetups_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PhysicsAsset:SkeletalBodySetups");
				return null;
			}
			if (SkeletalBodySetups_MarshalerCached == null)
			{
				SkeletalBodySetups_MarshalerCached = new TArrayReadWriteMarshaler<USkeletalBodySetup>(1, SkeletalBodySetups_PropertyAddress, CachedMarshalingDelegates<USkeletalBodySetup, UObjectMarshaler<USkeletalBodySetup>>.FromNative, CachedMarshalingDelegates<USkeletalBodySetup, UObjectMarshaler<USkeletalBodySetup>>.ToNative);
			}
			return SkeletalBodySetups_MarshalerCached.FromNative(IntPtr.Add(base.Address, SkeletalBodySetups_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)5630049290027528uL)]
	[UMetaPath("/Script/Engine.PhysicsAsset:ConstraintSetup")]
	public TArrayReadWrite<UPhysicsConstraintTemplate> ConstraintSetup
	{
		get
		{
			CheckDestroyed();
			if (!ConstraintSetup_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PhysicsAsset:ConstraintSetup");
				return null;
			}
			if (ConstraintSetup_MarshalerCached == null)
			{
				ConstraintSetup_MarshalerCached = new TArrayReadWriteMarshaler<UPhysicsConstraintTemplate>(1, ConstraintSetup_PropertyAddress, CachedMarshalingDelegates<UPhysicsConstraintTemplate, UObjectMarshaler<UPhysicsConstraintTemplate>>.FromNative, CachedMarshalingDelegates<UPhysicsConstraintTemplate, UObjectMarshaler<UPhysicsConstraintTemplate>>.ToNative);
			}
			return ConstraintSetup_MarshalerCached.FromNative(IntPtr.Add(base.Address, ConstraintSetup_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4503668346863617uL)]
	[UMetaPath("/Script/Engine.PhysicsAsset:SolverSettings")]
	public FPhysicsAssetSolverSettings SolverSettings
	{
		get
		{
			CheckDestroyed();
			if (!SolverSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PhysicsAsset:SolverSettings");
				return default(FPhysicsAssetSolverSettings);
			}
			return FPhysicsAssetSolverSettings.FromNative(IntPtr.Add(base.Address, SolverSettings_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SolverSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PhysicsAsset:SolverSettings");
			}
			else
			{
				FPhysicsAssetSolverSettings.ToNative(IntPtr.Add(base.Address, SolverSettings_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503668346863616uL)]
	[UMetaPath("/Script/Engine.PhysicsAsset:SolverIterations")]
	public FSolverIterations SolverIterations
	{
		get
		{
			CheckDestroyed();
			if (!SolverIterations_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PhysicsAsset:SolverIterations");
				return default(FSolverIterations);
			}
			return FSolverIterations.FromNative(IntPtr.Add(base.Address, SolverIterations_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SolverIterations_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PhysicsAsset:SolverIterations");
			}
			else
			{
				FSolverIterations.ToNative(IntPtr.Add(base.Address, SolverIterations_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274817uL)]
	[UMetaPath("/Script/Engine.PhysicsAsset:SolverType")]
	public EPhysicsAssetSolverType SolverType
	{
		get
		{
			CheckDestroyed();
			if (!SolverType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PhysicsAsset:SolverType");
				return EPhysicsAssetSolverType.RBAN;
			}
			return EnumMarshaler<EPhysicsAssetSolverType>.FromNative(IntPtr.Add(base.Address, SolverType_Offset), 0, SolverType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SolverType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PhysicsAsset:SolverType");
			}
			else
			{
				EnumMarshaler<EPhysicsAssetSolverType>.ToNative(IntPtr.Add(base.Address, SolverType_Offset), 0, SolverType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043585uL)]
	[UMetaPath("/Script/Engine.PhysicsAsset:bNotForDedicatedServer")]
	public bool NotForDedicatedServer
	{
		get
		{
			CheckDestroyed();
			if (!NotForDedicatedServer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PhysicsAsset:bNotForDedicatedServer");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, NotForDedicatedServer_Offset), 0, NotForDedicatedServer_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!NotForDedicatedServer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PhysicsAsset:bNotForDedicatedServer");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, NotForDedicatedServer_Offset), 0, NotForDedicatedServer_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)8444319095194121uL)]
	[UMetaPath("/Script/Engine.PhysicsAsset:ThumbnailInfo")]
	public UThumbnailInfo ThumbnailInfo
	{
		get
		{
			CheckDestroyed();
			if (!ThumbnailInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PhysicsAsset:ThumbnailInfo");
				return null;
			}
			return UObjectMarshaler<UThumbnailInfo>.FromNative(IntPtr.Add(base.Address, ThumbnailInfo_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ThumbnailInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PhysicsAsset:ThumbnailInfo");
			}
			else
			{
				UObjectMarshaler<UThumbnailInfo>.ToNative(IntPtr.Add(base.Address, ThumbnailInfo_Offset), value);
			}
		}
	}

	[UFunction(Flags = 608306177u)]
	[UMetaPath("/Script/Engine.PhysicsAsset:GetConstraints")]
	public unsafe void GetConstraints(bool bIncludesTerminated, out List<FConstraintInstanceAccessor> OutConstraints)
	{
		CheckDestroyed();
		if (!GetConstraints_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PhysicsAsset:GetConstraints");
			OutConstraints = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetConstraints_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetConstraints_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetConstraints_bIncludesTerminated_Offset), 0, GetConstraints_bIncludesTerminated_PropertyAddress.Address, bIncludesTerminated);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetConstraints_FunctionAddress, intPtr, GetConstraints_ParamsSize);
		OutConstraints = new TArrayCopyMarshaler<FConstraintInstanceAccessor>(1, GetConstraints_OutConstraints_PropertyAddress, CachedMarshalingDelegates<FConstraintInstanceAccessor, FConstraintInstanceAccessor>.FromNative, CachedMarshalingDelegates<FConstraintInstanceAccessor, FConstraintInstanceAccessor>.ToNative).FromNative(IntPtr.Add(intPtr, GetConstraints_OutConstraints_Offset));
		NativeReflection.DestroyValue_InContainer(GetConstraints_OutConstraints_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/Engine.PhysicsAsset:GetConstraintByName")]
	public unsafe FConstraintInstanceAccessor GetConstraintByName(FName ConstraintName)
	{
		CheckDestroyed();
		if (!GetConstraintByName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PhysicsAsset:GetConstraintByName");
			return default(FConstraintInstanceAccessor);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetConstraintByName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetConstraintByName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetConstraintByName_ConstraintName_Offset), 0, GetConstraintByName_ConstraintName_PropertyAddress.Address, ConstraintName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetConstraintByName_FunctionAddress, intPtr, GetConstraintByName_ParamsSize);
		FConstraintInstanceAccessor result = FConstraintInstanceAccessor.FromNative(IntPtr.Add(intPtr, GetConstraintByName_ReturnValue_Offset), 0, GetConstraintByName_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetConstraintByName_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/Engine.PhysicsAsset:GetConstraintByBoneNames")]
	public unsafe FConstraintInstanceAccessor GetConstraintByBoneNames(FName Bone1Name, FName Bone2Name)
	{
		CheckDestroyed();
		if (!GetConstraintByBoneNames_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PhysicsAsset:GetConstraintByBoneNames");
			return default(FConstraintInstanceAccessor);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetConstraintByBoneNames_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetConstraintByBoneNames_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetConstraintByBoneNames_Bone1Name_Offset), 0, GetConstraintByBoneNames_Bone1Name_PropertyAddress.Address, Bone1Name);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetConstraintByBoneNames_Bone2Name_Offset), 0, GetConstraintByBoneNames_Bone2Name_PropertyAddress.Address, Bone2Name);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetConstraintByBoneNames_FunctionAddress, intPtr, GetConstraintByBoneNames_ParamsSize);
		FConstraintInstanceAccessor result = FConstraintInstanceAccessor.FromNative(IntPtr.Add(intPtr, GetConstraintByBoneNames_ReturnValue_Offset), 0, GetConstraintByBoneNames_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetConstraintByBoneNames_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static UPhysicsAsset()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPhysicsAsset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPhysicsAsset));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.PhysicsAsset");
		PreviewSkeletalMesh_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PreviewSkeletalMesh");
		PreviewSkeletalMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PreviewSkeletalMesh", Classes.FSoftObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref PhysicalAnimationProfiles_PropertyAddress, intPtr, "PhysicalAnimationProfiles");
		PhysicalAnimationProfiles_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PhysicalAnimationProfiles");
		PhysicalAnimationProfiles_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PhysicalAnimationProfiles", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ConstraintProfiles_PropertyAddress, intPtr, "ConstraintProfiles");
		ConstraintProfiles_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ConstraintProfiles");
		ConstraintProfiles_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ConstraintProfiles", Classes.FArrayProperty);
		CurrentPhysicalAnimationProfileName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CurrentPhysicalAnimationProfileName");
		CurrentPhysicalAnimationProfileName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CurrentPhysicalAnimationProfileName", Classes.FNameProperty);
		CurrentConstraintProfileName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CurrentConstraintProfileName");
		CurrentConstraintProfileName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CurrentConstraintProfileName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref BoundsBodies_PropertyAddress, intPtr, "BoundsBodies");
		BoundsBodies_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BoundsBodies");
		BoundsBodies_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BoundsBodies", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SkeletalBodySetups_PropertyAddress, intPtr, "SkeletalBodySetups");
		SkeletalBodySetups_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SkeletalBodySetups");
		SkeletalBodySetups_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SkeletalBodySetups", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ConstraintSetup_PropertyAddress, intPtr, "ConstraintSetup");
		ConstraintSetup_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ConstraintSetup");
		ConstraintSetup_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ConstraintSetup", Classes.FArrayProperty);
		SolverSettings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SolverSettings");
		SolverSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SolverSettings", Classes.FStructProperty);
		SolverIterations_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SolverIterations");
		SolverIterations_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SolverIterations", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SolverType_PropertyAddress, intPtr, "SolverType");
		SolverType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SolverType");
		SolverType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SolverType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref NotForDedicatedServer_PropertyAddress, intPtr, "bNotForDedicatedServer");
		NotForDedicatedServer_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bNotForDedicatedServer");
		NotForDedicatedServer_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bNotForDedicatedServer", Classes.FBoolProperty);
		ThumbnailInfo_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ThumbnailInfo");
		ThumbnailInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ThumbnailInfo", Classes.FObjectProperty);
		GetConstraints_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetConstraints");
		GetConstraints_ParamsSize = NativeReflection.GetFunctionParamsSize(GetConstraints_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetConstraints_bIncludesTerminated_PropertyAddress, GetConstraints_FunctionAddress, "bIncludesTerminated");
		GetConstraints_bIncludesTerminated_Offset = NativeReflectionCached.GetPropertyOffset(GetConstraints_FunctionAddress, "bIncludesTerminated");
		GetConstraints_bIncludesTerminated_IsValid = NativeReflectionCached.ValidatePropertyClass(GetConstraints_FunctionAddress, "bIncludesTerminated", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetConstraints_OutConstraints_PropertyAddress, GetConstraints_FunctionAddress, "OutConstraints");
		GetConstraints_OutConstraints_Offset = NativeReflectionCached.GetPropertyOffset(GetConstraints_FunctionAddress, "OutConstraints");
		GetConstraints_OutConstraints_IsValid = NativeReflectionCached.ValidatePropertyClass(GetConstraints_FunctionAddress, "OutConstraints", Classes.FArrayProperty);
		GetConstraints_IsValid = GetConstraints_FunctionAddress != IntPtr.Zero && GetConstraints_bIncludesTerminated_IsValid && GetConstraints_OutConstraints_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PhysicsAsset:GetConstraints", GetConstraints_IsValid);
		GetConstraintByName_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetConstraintByName");
		GetConstraintByName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetConstraintByName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetConstraintByName_ConstraintName_PropertyAddress, GetConstraintByName_FunctionAddress, "ConstraintName");
		GetConstraintByName_ConstraintName_Offset = NativeReflectionCached.GetPropertyOffset(GetConstraintByName_FunctionAddress, "ConstraintName");
		GetConstraintByName_ConstraintName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetConstraintByName_FunctionAddress, "ConstraintName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetConstraintByName_ReturnValue_PropertyAddress, GetConstraintByName_FunctionAddress, "ReturnValue");
		GetConstraintByName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetConstraintByName_FunctionAddress, "ReturnValue");
		GetConstraintByName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetConstraintByName_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetConstraintByName_IsValid = GetConstraintByName_FunctionAddress != IntPtr.Zero && GetConstraintByName_ConstraintName_IsValid && GetConstraintByName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PhysicsAsset:GetConstraintByName", GetConstraintByName_IsValid);
		GetConstraintByBoneNames_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetConstraintByBoneNames");
		GetConstraintByBoneNames_ParamsSize = NativeReflection.GetFunctionParamsSize(GetConstraintByBoneNames_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetConstraintByBoneNames_Bone1Name_PropertyAddress, GetConstraintByBoneNames_FunctionAddress, "Bone1Name");
		GetConstraintByBoneNames_Bone1Name_Offset = NativeReflectionCached.GetPropertyOffset(GetConstraintByBoneNames_FunctionAddress, "Bone1Name");
		GetConstraintByBoneNames_Bone1Name_IsValid = NativeReflectionCached.ValidatePropertyClass(GetConstraintByBoneNames_FunctionAddress, "Bone1Name", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetConstraintByBoneNames_Bone2Name_PropertyAddress, GetConstraintByBoneNames_FunctionAddress, "Bone2Name");
		GetConstraintByBoneNames_Bone2Name_Offset = NativeReflectionCached.GetPropertyOffset(GetConstraintByBoneNames_FunctionAddress, "Bone2Name");
		GetConstraintByBoneNames_Bone2Name_IsValid = NativeReflectionCached.ValidatePropertyClass(GetConstraintByBoneNames_FunctionAddress, "Bone2Name", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetConstraintByBoneNames_ReturnValue_PropertyAddress, GetConstraintByBoneNames_FunctionAddress, "ReturnValue");
		GetConstraintByBoneNames_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetConstraintByBoneNames_FunctionAddress, "ReturnValue");
		GetConstraintByBoneNames_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetConstraintByBoneNames_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetConstraintByBoneNames_IsValid = GetConstraintByBoneNames_FunctionAddress != IntPtr.Zero && GetConstraintByBoneNames_Bone1Name_IsValid && GetConstraintByBoneNames_Bone2Name_IsValid && GetConstraintByBoneNames_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PhysicsAsset:GetConstraintByBoneNames", GetConstraintByBoneNames_IsValid);
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.CableComponent;

[UClass(Flags = (ClassFlags)821039268uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/CableComponent.CableComponent", "CableComponent", UnrealModuleType.EnginePlugin)]
public class UCableComponent : UMeshComponent
{
	private static bool AttachStart_IsValid;

	private static FFieldAddress AttachStart_PropertyAddress;

	private static int AttachStart_Offset;

	private static bool AttachEnd_IsValid;

	private static FFieldAddress AttachEnd_PropertyAddress;

	private static int AttachEnd_Offset;

	private static bool EndLocation_IsValid;

	private static int EndLocation_Offset;

	private static bool CableLength_IsValid;

	private static int CableLength_Offset;

	private static bool NumSegments_IsValid;

	private static int NumSegments_Offset;

	private static bool SubstepTime_IsValid;

	private static int SubstepTime_Offset;

	private static bool SolverIterations_IsValid;

	private static int SolverIterations_Offset;

	private static bool EnableStiffness_IsValid;

	private static FFieldAddress EnableStiffness_PropertyAddress;

	private static int EnableStiffness_Offset;

	private static bool UseSubstepping_IsValid;

	private static FFieldAddress UseSubstepping_PropertyAddress;

	private static int UseSubstepping_Offset;

	private static bool SkipCableUpdateWhenNotVisible_IsValid;

	private static FFieldAddress SkipCableUpdateWhenNotVisible_PropertyAddress;

	private static int SkipCableUpdateWhenNotVisible_Offset;

	private static bool SkipCableUpdateWhenNotOwnerRecentlyRendered_IsValid;

	private static FFieldAddress SkipCableUpdateWhenNotOwnerRecentlyRendered_PropertyAddress;

	private static int SkipCableUpdateWhenNotOwnerRecentlyRendered_Offset;

	private static bool EnableCollision_IsValid;

	private static FFieldAddress EnableCollision_PropertyAddress;

	private static int EnableCollision_Offset;

	private static bool CollisionFriction_IsValid;

	private static int CollisionFriction_Offset;

	private static bool CableForce_IsValid;

	private static int CableForce_Offset;

	private static bool CableGravityScale_IsValid;

	private static int CableGravityScale_Offset;

	private static bool CableWidth_IsValid;

	private static int CableWidth_Offset;

	private static bool NumSides_IsValid;

	private static int NumSides_Offset;

	private static bool TileMaterial_IsValid;

	private static int TileMaterial_Offset;

	private static bool SetAttachEndToComponent_IsValid;

	private static IntPtr SetAttachEndToComponent_FunctionAddress;

	private static int SetAttachEndToComponent_ParamsSize;

	private static bool SetAttachEndToComponent_Component_IsValid;

	private static FFieldAddress SetAttachEndToComponent_Component_PropertyAddress;

	private static int SetAttachEndToComponent_Component_Offset;

	private static bool SetAttachEndToComponent_SocketName_IsValid;

	private static FFieldAddress SetAttachEndToComponent_SocketName_PropertyAddress;

	private static int SetAttachEndToComponent_SocketName_Offset;

	private static bool SetAttachEndTo_IsValid;

	private static IntPtr SetAttachEndTo_FunctionAddress;

	private static int SetAttachEndTo_ParamsSize;

	private static bool SetAttachEndTo_Actor_IsValid;

	private static FFieldAddress SetAttachEndTo_Actor_PropertyAddress;

	private static int SetAttachEndTo_Actor_Offset;

	private static bool SetAttachEndTo_ComponentProperty_IsValid;

	private static FFieldAddress SetAttachEndTo_ComponentProperty_PropertyAddress;

	private static int SetAttachEndTo_ComponentProperty_Offset;

	private static bool SetAttachEndTo_SocketName_IsValid;

	private static FFieldAddress SetAttachEndTo_SocketName_PropertyAddress;

	private static int SetAttachEndTo_SocketName_Offset;

	private static bool GetCableParticleLocations_IsValid;

	private static IntPtr GetCableParticleLocations_FunctionAddress;

	private static int GetCableParticleLocations_ParamsSize;

	private static bool GetCableParticleLocations_Locations_IsValid;

	private static FFieldAddress GetCableParticleLocations_Locations_PropertyAddress;

	private static int GetCableParticleLocations_Locations_Offset;

	private static bool GetAttachedComponent_IsValid;

	private static IntPtr GetAttachedComponent_FunctionAddress;

	private static int GetAttachedComponent_ParamsSize;

	private static bool GetAttachedComponent_ReturnValue_IsValid;

	private static FFieldAddress GetAttachedComponent_ReturnValue_PropertyAddress;

	private static int GetAttachedComponent_ReturnValue_Offset;

	private static bool GetAttachedActor_IsValid;

	private static IntPtr GetAttachedActor_FunctionAddress;

	private static int GetAttachedActor_ParamsSize;

	private static bool GetAttachedActor_ReturnValue_IsValid;

	private static FFieldAddress GetAttachedActor_ReturnValue_PropertyAddress;

	private static int GetAttachedActor_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CableComponent.CableComponent:bAttachStart")]
	public bool AttachStart
	{
		get
		{
			CheckDestroyed();
			if (!AttachStart_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CableComponent.CableComponent:bAttachStart");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AttachStart_Offset), 0, AttachStart_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AttachStart_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CableComponent.CableComponent:bAttachStart");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AttachStart_Offset), 0, AttachStart_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CableComponent.CableComponent:bAttachEnd")]
	public bool AttachEnd
	{
		get
		{
			CheckDestroyed();
			if (!AttachEnd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CableComponent.CableComponent:bAttachEnd");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AttachEnd_Offset), 0, AttachEnd_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AttachEnd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CableComponent.CableComponent:bAttachEnd");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AttachEnd_Offset), 0, AttachEnd_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CableComponent.CableComponent:EndLocation")]
	public FVector EndLocation
	{
		get
		{
			CheckDestroyed();
			if (!EndLocation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CableComponent.CableComponent:EndLocation");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, EndLocation_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EndLocation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CableComponent.CableComponent:EndLocation");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, EndLocation_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CableComponent.CableComponent:CableLength")]
	public float CableLength
	{
		get
		{
			CheckDestroyed();
			if (!CableLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CableComponent.CableComponent:CableLength");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CableLength_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CableLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CableComponent.CableComponent:CableLength");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CableLength_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/CableComponent.CableComponent:NumSegments")]
	public int NumSegments
	{
		get
		{
			CheckDestroyed();
			if (!NumSegments_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CableComponent.CableComponent:NumSegments");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, NumSegments_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NumSegments_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CableComponent.CableComponent:NumSegments");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, NumSegments_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/CableComponent.CableComponent:SubstepTime")]
	public float SubstepTime
	{
		get
		{
			CheckDestroyed();
			if (!SubstepTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CableComponent.CableComponent:SubstepTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SubstepTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SubstepTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CableComponent.CableComponent:SubstepTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SubstepTime_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CableComponent.CableComponent:SolverIterations")]
	public int SolverIterations
	{
		get
		{
			CheckDestroyed();
			if (!SolverIterations_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CableComponent.CableComponent:SolverIterations");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, SolverIterations_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SolverIterations_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CableComponent.CableComponent:SolverIterations");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, SolverIterations_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/CableComponent.CableComponent:bEnableStiffness")]
	public bool EnableStiffness
	{
		get
		{
			CheckDestroyed();
			if (!EnableStiffness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CableComponent.CableComponent:bEnableStiffness");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableStiffness_Offset), 0, EnableStiffness_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableStiffness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CableComponent.CableComponent:bEnableStiffness");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableStiffness_Offset), 0, EnableStiffness_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/CableComponent.CableComponent:bUseSubstepping")]
	public bool UseSubstepping
	{
		get
		{
			CheckDestroyed();
			if (!UseSubstepping_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CableComponent.CableComponent:bUseSubstepping");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseSubstepping_Offset), 0, UseSubstepping_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseSubstepping_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CableComponent.CableComponent:bUseSubstepping");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseSubstepping_Offset), 0, UseSubstepping_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/CableComponent.CableComponent:bSkipCableUpdateWhenNotVisible")]
	public bool SkipCableUpdateWhenNotVisible
	{
		get
		{
			CheckDestroyed();
			if (!SkipCableUpdateWhenNotVisible_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CableComponent.CableComponent:bSkipCableUpdateWhenNotVisible");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, SkipCableUpdateWhenNotVisible_Offset), 0, SkipCableUpdateWhenNotVisible_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SkipCableUpdateWhenNotVisible_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CableComponent.CableComponent:bSkipCableUpdateWhenNotVisible");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, SkipCableUpdateWhenNotVisible_Offset), 0, SkipCableUpdateWhenNotVisible_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/CableComponent.CableComponent:bSkipCableUpdateWhenNotOwnerRecentlyRendered")]
	public bool SkipCableUpdateWhenNotOwnerRecentlyRendered
	{
		get
		{
			CheckDestroyed();
			if (!SkipCableUpdateWhenNotOwnerRecentlyRendered_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CableComponent.CableComponent:bSkipCableUpdateWhenNotOwnerRecentlyRendered");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, SkipCableUpdateWhenNotOwnerRecentlyRendered_Offset), 0, SkipCableUpdateWhenNotOwnerRecentlyRendered_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SkipCableUpdateWhenNotOwnerRecentlyRendered_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CableComponent.CableComponent:bSkipCableUpdateWhenNotOwnerRecentlyRendered");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, SkipCableUpdateWhenNotOwnerRecentlyRendered_Offset), 0, SkipCableUpdateWhenNotOwnerRecentlyRendered_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/CableComponent.CableComponent:bEnableCollision")]
	public bool EnableCollision
	{
		get
		{
			CheckDestroyed();
			if (!EnableCollision_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CableComponent.CableComponent:bEnableCollision");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableCollision_Offset), 0, EnableCollision_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableCollision_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CableComponent.CableComponent:bEnableCollision");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableCollision_Offset), 0, EnableCollision_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/CableComponent.CableComponent:CollisionFriction")]
	public float CollisionFriction
	{
		get
		{
			CheckDestroyed();
			if (!CollisionFriction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CableComponent.CableComponent:CollisionFriction");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CollisionFriction_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CollisionFriction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CableComponent.CableComponent:CollisionFriction");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CollisionFriction_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CableComponent.CableComponent:CableForce")]
	public FVector CableForce
	{
		get
		{
			CheckDestroyed();
			if (!CableForce_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CableComponent.CableComponent:CableForce");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, CableForce_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CableForce_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CableComponent.CableComponent:CableForce");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, CableForce_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CableComponent.CableComponent:CableGravityScale")]
	public float CableGravityScale
	{
		get
		{
			CheckDestroyed();
			if (!CableGravityScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CableComponent.CableComponent:CableGravityScale");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CableGravityScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CableGravityScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CableComponent.CableComponent:CableGravityScale");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CableGravityScale_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CableComponent.CableComponent:CableWidth")]
	public float CableWidth
	{
		get
		{
			CheckDestroyed();
			if (!CableWidth_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CableComponent.CableComponent:CableWidth");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CableWidth_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CableWidth_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CableComponent.CableComponent:CableWidth");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CableWidth_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/CableComponent.CableComponent:NumSides")]
	public int NumSides
	{
		get
		{
			CheckDestroyed();
			if (!NumSides_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CableComponent.CableComponent:NumSides");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, NumSides_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NumSides_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CableComponent.CableComponent:NumSides");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, NumSides_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CableComponent.CableComponent:TileMaterial")]
	public float TileMaterial
	{
		get
		{
			CheckDestroyed();
			if (!TileMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CableComponent.CableComponent:TileMaterial");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, TileMaterial_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TileMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CableComponent.CableComponent:TileMaterial");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, TileMaterial_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/CableComponent.CableComponent:SetAttachEndToComponent")]
	public unsafe void SetAttachEndToComponent(USceneComponent Component, FName SocketName)
	{
		CheckDestroyed();
		if (!SetAttachEndToComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CableComponent.CableComponent:SetAttachEndToComponent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAttachEndToComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAttachEndToComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USceneComponent>.ToNative(IntPtr.Add(intPtr, SetAttachEndToComponent_Component_Offset), 0, SetAttachEndToComponent_Component_PropertyAddress.Address, Component);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetAttachEndToComponent_SocketName_Offset), 0, SetAttachEndToComponent_SocketName_PropertyAddress.Address, SocketName);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAttachEndToComponent_FunctionAddress, intPtr, SetAttachEndToComponent_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/CableComponent.CableComponent:SetAttachEndTo")]
	public unsafe void SetAttachEndTo(AActor Actor, FName ComponentProperty, FName SocketName)
	{
		CheckDestroyed();
		if (!SetAttachEndTo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CableComponent.CableComponent:SetAttachEndTo");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAttachEndTo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAttachEndTo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, SetAttachEndTo_Actor_Offset), 0, SetAttachEndTo_Actor_PropertyAddress.Address, Actor);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetAttachEndTo_ComponentProperty_Offset), 0, SetAttachEndTo_ComponentProperty_PropertyAddress.Address, ComponentProperty);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetAttachEndTo_SocketName_Offset), 0, SetAttachEndTo_SocketName_PropertyAddress.Address, SocketName);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAttachEndTo_FunctionAddress, intPtr, SetAttachEndTo_ParamsSize);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/CableComponent.CableComponent:GetCableParticleLocations")]
	public unsafe void GetCableParticleLocations(out List<FVector> Locations)
	{
		CheckDestroyed();
		if (!GetCableParticleLocations_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CableComponent.CableComponent:GetCableParticleLocations");
			Locations = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCableParticleLocations_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCableParticleLocations_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCableParticleLocations_FunctionAddress, intPtr, GetCableParticleLocations_ParamsSize);
		Locations = new TArrayCopyMarshaler<FVector>(1, GetCableParticleLocations_Locations_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).FromNative(IntPtr.Add(intPtr, GetCableParticleLocations_Locations_Offset));
		NativeReflection.DestroyValue_InContainer(GetCableParticleLocations_Locations_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/CableComponent.CableComponent:GetAttachedComponent")]
	public unsafe USceneComponent GetAttachedComponent()
	{
		CheckDestroyed();
		if (!GetAttachedComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CableComponent.CableComponent:GetAttachedComponent");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAttachedComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAttachedComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAttachedComponent_FunctionAddress, intPtr, GetAttachedComponent_ParamsSize);
		return UObjectMarshaler<USceneComponent>.FromNative(IntPtr.Add(intPtr, GetAttachedComponent_ReturnValue_Offset), 0, GetAttachedComponent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/CableComponent.CableComponent:GetAttachedActor")]
	public unsafe AActor GetAttachedActor()
	{
		CheckDestroyed();
		if (!GetAttachedActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CableComponent.CableComponent:GetAttachedActor");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAttachedActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAttachedActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAttachedActor_FunctionAddress, intPtr, GetAttachedActor_ParamsSize);
		return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(intPtr, GetAttachedActor_ReturnValue_Offset), 0, GetAttachedActor_ReturnValue_PropertyAddress.Address);
	}

	static UCableComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UCableComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UCableComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/CableComponent.CableComponent");
		NativeReflectionCached.GetPropertyRef(ref AttachStart_PropertyAddress, intPtr, "bAttachStart");
		AttachStart_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAttachStart");
		AttachStart_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAttachStart", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AttachEnd_PropertyAddress, intPtr, "bAttachEnd");
		AttachEnd_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAttachEnd");
		AttachEnd_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAttachEnd", Classes.FBoolProperty);
		EndLocation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "EndLocation");
		EndLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "EndLocation", Classes.FStructProperty);
		CableLength_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CableLength");
		CableLength_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CableLength", Classes.FFloatProperty);
		NumSegments_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NumSegments");
		NumSegments_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NumSegments", Classes.FIntProperty);
		SubstepTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SubstepTime");
		SubstepTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SubstepTime", Classes.FFloatProperty);
		SolverIterations_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SolverIterations");
		SolverIterations_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SolverIterations", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableStiffness_PropertyAddress, intPtr, "bEnableStiffness");
		EnableStiffness_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnableStiffness");
		EnableStiffness_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnableStiffness", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UseSubstepping_PropertyAddress, intPtr, "bUseSubstepping");
		UseSubstepping_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUseSubstepping");
		UseSubstepping_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUseSubstepping", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SkipCableUpdateWhenNotVisible_PropertyAddress, intPtr, "bSkipCableUpdateWhenNotVisible");
		SkipCableUpdateWhenNotVisible_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bSkipCableUpdateWhenNotVisible");
		SkipCableUpdateWhenNotVisible_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bSkipCableUpdateWhenNotVisible", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SkipCableUpdateWhenNotOwnerRecentlyRendered_PropertyAddress, intPtr, "bSkipCableUpdateWhenNotOwnerRecentlyRendered");
		SkipCableUpdateWhenNotOwnerRecentlyRendered_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bSkipCableUpdateWhenNotOwnerRecentlyRendered");
		SkipCableUpdateWhenNotOwnerRecentlyRendered_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bSkipCableUpdateWhenNotOwnerRecentlyRendered", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableCollision_PropertyAddress, intPtr, "bEnableCollision");
		EnableCollision_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnableCollision");
		EnableCollision_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnableCollision", Classes.FBoolProperty);
		CollisionFriction_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CollisionFriction");
		CollisionFriction_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CollisionFriction", Classes.FFloatProperty);
		CableForce_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CableForce");
		CableForce_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CableForce", Classes.FStructProperty);
		CableGravityScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CableGravityScale");
		CableGravityScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CableGravityScale", Classes.FFloatProperty);
		CableWidth_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CableWidth");
		CableWidth_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CableWidth", Classes.FFloatProperty);
		NumSides_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NumSides");
		NumSides_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NumSides", Classes.FIntProperty);
		TileMaterial_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TileMaterial");
		TileMaterial_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TileMaterial", Classes.FFloatProperty);
		SetAttachEndToComponent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAttachEndToComponent");
		SetAttachEndToComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAttachEndToComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAttachEndToComponent_Component_PropertyAddress, SetAttachEndToComponent_FunctionAddress, "Component");
		SetAttachEndToComponent_Component_Offset = NativeReflectionCached.GetPropertyOffset(SetAttachEndToComponent_FunctionAddress, "Component");
		SetAttachEndToComponent_Component_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAttachEndToComponent_FunctionAddress, "Component", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAttachEndToComponent_SocketName_PropertyAddress, SetAttachEndToComponent_FunctionAddress, "SocketName");
		SetAttachEndToComponent_SocketName_Offset = NativeReflectionCached.GetPropertyOffset(SetAttachEndToComponent_FunctionAddress, "SocketName");
		SetAttachEndToComponent_SocketName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAttachEndToComponent_FunctionAddress, "SocketName", Classes.FNameProperty);
		SetAttachEndToComponent_IsValid = SetAttachEndToComponent_FunctionAddress != IntPtr.Zero && SetAttachEndToComponent_Component_IsValid && SetAttachEndToComponent_SocketName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/CableComponent.CableComponent:SetAttachEndToComponent", SetAttachEndToComponent_IsValid);
		SetAttachEndTo_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAttachEndTo");
		SetAttachEndTo_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAttachEndTo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAttachEndTo_Actor_PropertyAddress, SetAttachEndTo_FunctionAddress, "Actor");
		SetAttachEndTo_Actor_Offset = NativeReflectionCached.GetPropertyOffset(SetAttachEndTo_FunctionAddress, "Actor");
		SetAttachEndTo_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAttachEndTo_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAttachEndTo_ComponentProperty_PropertyAddress, SetAttachEndTo_FunctionAddress, "ComponentProperty");
		SetAttachEndTo_ComponentProperty_Offset = NativeReflectionCached.GetPropertyOffset(SetAttachEndTo_FunctionAddress, "ComponentProperty");
		SetAttachEndTo_ComponentProperty_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAttachEndTo_FunctionAddress, "ComponentProperty", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAttachEndTo_SocketName_PropertyAddress, SetAttachEndTo_FunctionAddress, "SocketName");
		SetAttachEndTo_SocketName_Offset = NativeReflectionCached.GetPropertyOffset(SetAttachEndTo_FunctionAddress, "SocketName");
		SetAttachEndTo_SocketName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAttachEndTo_FunctionAddress, "SocketName", Classes.FNameProperty);
		SetAttachEndTo_IsValid = SetAttachEndTo_FunctionAddress != IntPtr.Zero && SetAttachEndTo_Actor_IsValid && SetAttachEndTo_ComponentProperty_IsValid && SetAttachEndTo_SocketName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/CableComponent.CableComponent:SetAttachEndTo", SetAttachEndTo_IsValid);
		GetCableParticleLocations_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetCableParticleLocations");
		GetCableParticleLocations_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCableParticleLocations_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCableParticleLocations_Locations_PropertyAddress, GetCableParticleLocations_FunctionAddress, "Locations");
		GetCableParticleLocations_Locations_Offset = NativeReflectionCached.GetPropertyOffset(GetCableParticleLocations_FunctionAddress, "Locations");
		GetCableParticleLocations_Locations_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCableParticleLocations_FunctionAddress, "Locations", Classes.FArrayProperty);
		GetCableParticleLocations_IsValid = GetCableParticleLocations_FunctionAddress != IntPtr.Zero && GetCableParticleLocations_Locations_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/CableComponent.CableComponent:GetCableParticleLocations", GetCableParticleLocations_IsValid);
		GetAttachedComponent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetAttachedComponent");
		GetAttachedComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAttachedComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAttachedComponent_ReturnValue_PropertyAddress, GetAttachedComponent_FunctionAddress, "ReturnValue");
		GetAttachedComponent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAttachedComponent_FunctionAddress, "ReturnValue");
		GetAttachedComponent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAttachedComponent_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetAttachedComponent_IsValid = GetAttachedComponent_FunctionAddress != IntPtr.Zero && GetAttachedComponent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/CableComponent.CableComponent:GetAttachedComponent", GetAttachedComponent_IsValid);
		GetAttachedActor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetAttachedActor");
		GetAttachedActor_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAttachedActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAttachedActor_ReturnValue_PropertyAddress, GetAttachedActor_FunctionAddress, "ReturnValue");
		GetAttachedActor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAttachedActor_FunctionAddress, "ReturnValue");
		GetAttachedActor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAttachedActor_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetAttachedActor_IsValid = GetAttachedActor_FunctionAddress != IntPtr.Zero && GetAttachedActor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/CableComponent.CableComponent:GetAttachedActor", GetAttachedActor_IsValid);
	}
}

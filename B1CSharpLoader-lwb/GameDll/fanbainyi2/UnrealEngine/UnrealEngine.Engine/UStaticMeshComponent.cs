using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)821039268uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Engine.StaticMeshComponent", "Engine", UnrealModuleType.Engine)]
public class UStaticMeshComponent : UMeshComponent
{
	private static bool ForcedLodModel_IsValid;

	private static int ForcedLodModel_Offset;

	private static bool MinLOD_IsValid;

	private static int MinLOD_Offset;

	private static bool StaticMesh_IsValid;

	private static int StaticMesh_Offset;

	private static bool WireframeColorOverride_IsValid;

	private static int WireframeColorOverride_Offset;

	private static bool EvaluateWorldPositionOffset_IsValid;

	private static FFieldAddress EvaluateWorldPositionOffset_PropertyAddress;

	private static int EvaluateWorldPositionOffset_Offset;

	private static bool OverrideWireframeColor_IsValid;

	private static FFieldAddress OverrideWireframeColor_PropertyAddress;

	private static int OverrideWireframeColor_Offset;

	private static bool OverrideMinLOD_IsValid;

	private static FFieldAddress OverrideMinLOD_PropertyAddress;

	private static int OverrideMinLOD_Offset;

	private static bool DisallowMeshPaintPerInstance_IsValid;

	private static FFieldAddress DisallowMeshPaintPerInstance_PropertyAddress;

	private static int DisallowMeshPaintPerInstance_Offset;

	private static bool IgnoreInstanceForTextureStreaming_IsValid;

	private static FFieldAddress IgnoreInstanceForTextureStreaming_PropertyAddress;

	private static int IgnoreInstanceForTextureStreaming_Offset;

	private static bool OverrideLightMapRes_IsValid;

	private static FFieldAddress OverrideLightMapRes_PropertyAddress;

	private static int OverrideLightMapRes_Offset;

	private static bool CastDistanceFieldIndirectShadow_IsValid;

	private static FFieldAddress CastDistanceFieldIndirectShadow_PropertyAddress;

	private static int CastDistanceFieldIndirectShadow_Offset;

	private static bool OverrideDistanceFieldSelfShadowBias_IsValid;

	private static FFieldAddress OverrideDistanceFieldSelfShadowBias_PropertyAddress;

	private static int OverrideDistanceFieldSelfShadowBias_Offset;

	private static bool SortTriangles_IsValid;

	private static FFieldAddress SortTriangles_PropertyAddress;

	private static int SortTriangles_Offset;

	private static bool ReverseCulling_IsValid;

	private static FFieldAddress ReverseCulling_PropertyAddress;

	private static int ReverseCulling_Offset;

	private static bool OverriddenLightMapRes_IsValid;

	private static int OverriddenLightMapRes_Offset;

	private static bool DistanceFieldIndirectShadowMinVisibility_IsValid;

	private static int DistanceFieldIndirectShadowMinVisibility_Offset;

	private static bool DistanceFieldSelfShadowBias_IsValid;

	private static int DistanceFieldSelfShadowBias_Offset;

	private static bool StreamingDistanceMultiplier_IsValid;

	private static int StreamingDistanceMultiplier_Offset;

	private static bool SetStaticMesh_IsValid;

	private static IntPtr SetStaticMesh_FunctionAddress;

	private static int SetStaticMesh_ParamsSize;

	private static bool SetStaticMesh_NewMesh_IsValid;

	private static FFieldAddress SetStaticMesh_NewMesh_PropertyAddress;

	private static int SetStaticMesh_NewMesh_Offset;

	private static bool SetStaticMesh_ReturnValue_IsValid;

	private static FFieldAddress SetStaticMesh_ReturnValue_PropertyAddress;

	private static int SetStaticMesh_ReturnValue_Offset;

	private static bool SetReverseCulling_IsValid;

	private static IntPtr SetReverseCulling_FunctionAddress;

	private static int SetReverseCulling_ParamsSize;

	private static bool SetReverseCulling_ReverseCulling_IsValid;

	private static FFieldAddress SetReverseCulling_ReverseCulling_PropertyAddress;

	private static int SetReverseCulling_ReverseCulling_Offset;

	private static bool SetForcedLodModel_IsValid;

	private static IntPtr SetForcedLodModel_FunctionAddress;

	private static int SetForcedLodModel_ParamsSize;

	private static bool SetForcedLodModel_NewForcedLodModel_IsValid;

	private static FFieldAddress SetForcedLodModel_NewForcedLodModel_PropertyAddress;

	private static int SetForcedLodModel_NewForcedLodModel_Offset;

	private static bool SetEvaluateWorldPositionOffsetInRayTracing_IsValid;

	private static IntPtr SetEvaluateWorldPositionOffsetInRayTracing_FunctionAddress;

	private static int SetEvaluateWorldPositionOffsetInRayTracing_ParamsSize;

	private static bool SetEvaluateWorldPositionOffsetInRayTracing_NewValue_IsValid;

	private static FFieldAddress SetEvaluateWorldPositionOffsetInRayTracing_NewValue_PropertyAddress;

	private static int SetEvaluateWorldPositionOffsetInRayTracing_NewValue_Offset;

	private static bool SetDistanceFieldSelfShadowBias_IsValid;

	private static IntPtr SetDistanceFieldSelfShadowBias_FunctionAddress;

	private static int SetDistanceFieldSelfShadowBias_ParamsSize;

	private static bool SetDistanceFieldSelfShadowBias_NewValue_IsValid;

	private static FFieldAddress SetDistanceFieldSelfShadowBias_NewValue_PropertyAddress;

	private static int SetDistanceFieldSelfShadowBias_NewValue_Offset;

	private static bool GetLocalBounds_IsValid;

	private static IntPtr GetLocalBounds_FunctionAddress;

	private static int GetLocalBounds_ParamsSize;

	private static bool GetLocalBounds_Min_IsValid;

	private static FFieldAddress GetLocalBounds_Min_PropertyAddress;

	private static int GetLocalBounds_Min_Offset;

	private static bool GetLocalBounds_Max_IsValid;

	private static FFieldAddress GetLocalBounds_Max_PropertyAddress;

	private static int GetLocalBounds_Max_Offset;

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/Engine.StaticMeshComponent:ForcedLodModel")]
	public int ForcedLodModel
	{
		get
		{
			CheckDestroyed();
			if (!ForcedLodModel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StaticMeshComponent:ForcedLodModel");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ForcedLodModel_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ForcedLodModel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StaticMeshComponent:ForcedLodModel");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ForcedLodModel_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/Engine.StaticMeshComponent:MinLOD")]
	public int MinLOD
	{
		get
		{
			CheckDestroyed();
			if (!MinLOD_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StaticMeshComponent:MinLOD");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, MinLOD_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MinLOD_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StaticMeshComponent:MinLOD");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, MinLOD_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)21392172318196277uL)]
	[UMetaPath("/Script/Engine.StaticMeshComponent:StaticMesh")]
	public UStaticMesh StaticMesh
	{
		get
		{
			CheckDestroyed();
			if (!StaticMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StaticMeshComponent:StaticMesh");
				return null;
			}
			return UObjectMarshaler<UStaticMesh>.FromNative(IntPtr.Add(base.Address, StaticMesh_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StaticMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StaticMeshComponent:StaticMesh");
			}
			else
			{
				UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(base.Address, StaticMesh_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/Engine.StaticMeshComponent:WireframeColorOverride")]
	public FColor WireframeColorOverride
	{
		get
		{
			CheckDestroyed();
			if (!WireframeColorOverride_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StaticMeshComponent:WireframeColorOverride");
				return default(FColor);
			}
			return BlittableTypeMarshaler<FColor>.FromNative(IntPtr.Add(base.Address, WireframeColorOverride_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WireframeColorOverride_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StaticMeshComponent:WireframeColorOverride");
			}
			else
			{
				BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(base.Address, WireframeColorOverride_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043589uL)]
	[UMetaPath("/Script/Engine.StaticMeshComponent:bEvaluateWorldPositionOffset")]
	public bool EvaluateWorldPositionOffset
	{
		get
		{
			CheckDestroyed();
			if (!EvaluateWorldPositionOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StaticMeshComponent:bEvaluateWorldPositionOffset");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EvaluateWorldPositionOffset_Offset), 0, EvaluateWorldPositionOffset_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EvaluateWorldPositionOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StaticMeshComponent:bEvaluateWorldPositionOffset");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EvaluateWorldPositionOffset_Offset), 0, EvaluateWorldPositionOffset_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.StaticMeshComponent:bOverrideWireframeColor")]
	public bool OverrideWireframeColor
	{
		get
		{
			CheckDestroyed();
			if (!OverrideWireframeColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StaticMeshComponent:bOverrideWireframeColor");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, OverrideWireframeColor_Offset), 0, OverrideWireframeColor_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!OverrideWireframeColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StaticMeshComponent:bOverrideWireframeColor");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, OverrideWireframeColor_Offset), 0, OverrideWireframeColor_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Engine.StaticMeshComponent:bOverrideMinLOD")]
	public bool OverrideMinLOD
	{
		get
		{
			CheckDestroyed();
			if (!OverrideMinLOD_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StaticMeshComponent:bOverrideMinLOD");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, OverrideMinLOD_Offset), 0, OverrideMinLOD_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!OverrideMinLOD_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StaticMeshComponent:bOverrideMinLOD");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, OverrideMinLOD_Offset), 0, OverrideMinLOD_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043589uL)]
	[UMetaPath("/Script/Engine.StaticMeshComponent:bDisallowMeshPaintPerInstance")]
	public bool DisallowMeshPaintPerInstance
	{
		get
		{
			CheckDestroyed();
			if (!DisallowMeshPaintPerInstance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StaticMeshComponent:bDisallowMeshPaintPerInstance");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DisallowMeshPaintPerInstance_Offset), 0, DisallowMeshPaintPerInstance_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DisallowMeshPaintPerInstance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StaticMeshComponent:bDisallowMeshPaintPerInstance");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DisallowMeshPaintPerInstance_Offset), 0, DisallowMeshPaintPerInstance_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043589uL)]
	[UMetaPath("/Script/Engine.StaticMeshComponent:bIgnoreInstanceForTextureStreaming")]
	public bool IgnoreInstanceForTextureStreaming
	{
		get
		{
			CheckDestroyed();
			if (!IgnoreInstanceForTextureStreaming_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StaticMeshComponent:bIgnoreInstanceForTextureStreaming");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IgnoreInstanceForTextureStreaming_Offset), 0, IgnoreInstanceForTextureStreaming_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IgnoreInstanceForTextureStreaming_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StaticMeshComponent:bIgnoreInstanceForTextureStreaming");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IgnoreInstanceForTextureStreaming_Offset), 0, IgnoreInstanceForTextureStreaming_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.StaticMeshComponent:bOverrideLightMapRes")]
	public bool OverrideLightMapRes
	{
		get
		{
			CheckDestroyed();
			if (!OverrideLightMapRes_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StaticMeshComponent:bOverrideLightMapRes");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, OverrideLightMapRes_Offset), 0, OverrideLightMapRes_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!OverrideLightMapRes_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StaticMeshComponent:bOverrideLightMapRes");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, OverrideLightMapRes_Offset), 0, OverrideLightMapRes_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Engine.StaticMeshComponent:bCastDistanceFieldIndirectShadow")]
	public bool CastDistanceFieldIndirectShadow
	{
		get
		{
			CheckDestroyed();
			if (!CastDistanceFieldIndirectShadow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StaticMeshComponent:bCastDistanceFieldIndirectShadow");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CastDistanceFieldIndirectShadow_Offset), 0, CastDistanceFieldIndirectShadow_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CastDistanceFieldIndirectShadow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StaticMeshComponent:bCastDistanceFieldIndirectShadow");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CastDistanceFieldIndirectShadow_Offset), 0, CastDistanceFieldIndirectShadow_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Engine.StaticMeshComponent:bOverrideDistanceFieldSelfShadowBias")]
	public bool OverrideDistanceFieldSelfShadowBias
	{
		get
		{
			CheckDestroyed();
			if (!OverrideDistanceFieldSelfShadowBias_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StaticMeshComponent:bOverrideDistanceFieldSelfShadowBias");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, OverrideDistanceFieldSelfShadowBias_Offset), 0, OverrideDistanceFieldSelfShadowBias_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!OverrideDistanceFieldSelfShadowBias_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StaticMeshComponent:bOverrideDistanceFieldSelfShadowBias");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, OverrideDistanceFieldSelfShadowBias_Offset), 0, OverrideDistanceFieldSelfShadowBias_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Engine.StaticMeshComponent:bSortTriangles")]
	public bool SortTriangles
	{
		get
		{
			CheckDestroyed();
			if (!SortTriangles_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StaticMeshComponent:bSortTriangles");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, SortTriangles_Offset), 0, SortTriangles_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SortTriangles_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StaticMeshComponent:bSortTriangles");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, SortTriangles_Offset), 0, SortTriangles_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Engine.StaticMeshComponent:bReverseCulling")]
	public bool ReverseCulling
	{
		get
		{
			CheckDestroyed();
			if (!ReverseCulling_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StaticMeshComponent:bReverseCulling");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ReverseCulling_Offset), 0, ReverseCulling_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ReverseCulling_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StaticMeshComponent:bReverseCulling");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ReverseCulling_Offset), 0, ReverseCulling_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.StaticMeshComponent:OverriddenLightMapRes")]
	public int OverriddenLightMapRes
	{
		get
		{
			CheckDestroyed();
			if (!OverriddenLightMapRes_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StaticMeshComponent:OverriddenLightMapRes");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, OverriddenLightMapRes_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OverriddenLightMapRes_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StaticMeshComponent:OverriddenLightMapRes");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, OverriddenLightMapRes_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/Engine.StaticMeshComponent:DistanceFieldIndirectShadowMinVisibility")]
	public float DistanceFieldIndirectShadowMinVisibility
	{
		get
		{
			CheckDestroyed();
			if (!DistanceFieldIndirectShadowMinVisibility_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StaticMeshComponent:DistanceFieldIndirectShadowMinVisibility");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DistanceFieldIndirectShadowMinVisibility_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DistanceFieldIndirectShadowMinVisibility_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StaticMeshComponent:DistanceFieldIndirectShadowMinVisibility");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DistanceFieldIndirectShadowMinVisibility_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/Engine.StaticMeshComponent:DistanceFieldSelfShadowBias")]
	public float DistanceFieldSelfShadowBias
	{
		get
		{
			CheckDestroyed();
			if (!DistanceFieldSelfShadowBias_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StaticMeshComponent:DistanceFieldSelfShadowBias");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DistanceFieldSelfShadowBias_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DistanceFieldSelfShadowBias_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StaticMeshComponent:DistanceFieldSelfShadowBias");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DistanceFieldSelfShadowBias_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Engine.StaticMeshComponent:StreamingDistanceMultiplier")]
	public float StreamingDistanceMultiplier
	{
		get
		{
			CheckDestroyed();
			if (!StreamingDistanceMultiplier_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StaticMeshComponent:StreamingDistanceMultiplier");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, StreamingDistanceMultiplier_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StreamingDistanceMultiplier_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StaticMeshComponent:StreamingDistanceMultiplier");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, StreamingDistanceMultiplier_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.StaticMeshComponent:SetStaticMesh")]
	public unsafe bool SetStaticMesh(UStaticMesh NewMesh)
	{
		CheckDestroyed();
		if (!SetStaticMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.StaticMeshComponent:SetStaticMesh");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetStaticMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetStaticMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, SetStaticMesh_NewMesh_Offset), 0, SetStaticMesh_NewMesh_PropertyAddress.Address, NewMesh);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetStaticMesh_FunctionAddress, intPtr, SetStaticMesh_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetStaticMesh_ReturnValue_Offset), 0, SetStaticMesh_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.StaticMeshComponent:SetReverseCulling")]
	public unsafe void SetReverseCulling(bool ReverseCulling)
	{
		CheckDestroyed();
		if (!SetReverseCulling_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.StaticMeshComponent:SetReverseCulling");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetReverseCulling_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetReverseCulling_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetReverseCulling_ReverseCulling_Offset), 0, SetReverseCulling_ReverseCulling_PropertyAddress.Address, ReverseCulling);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetReverseCulling_FunctionAddress, intPtr, SetReverseCulling_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.StaticMeshComponent:SetForcedLodModel")]
	public unsafe void SetForcedLodModel(int NewForcedLodModel)
	{
		CheckDestroyed();
		if (!SetForcedLodModel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.StaticMeshComponent:SetForcedLodModel");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetForcedLodModel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetForcedLodModel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetForcedLodModel_NewForcedLodModel_Offset), 0, SetForcedLodModel_NewForcedLodModel_PropertyAddress.Address, NewForcedLodModel);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetForcedLodModel_FunctionAddress, intPtr, SetForcedLodModel_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.StaticMeshComponent:SetEvaluateWorldPositionOffsetInRayTracing")]
	public unsafe void SetEvaluateWorldPositionOffsetInRayTracing(bool NewValue)
	{
		CheckDestroyed();
		if (!SetEvaluateWorldPositionOffsetInRayTracing_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.StaticMeshComponent:SetEvaluateWorldPositionOffsetInRayTracing");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetEvaluateWorldPositionOffsetInRayTracing_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetEvaluateWorldPositionOffsetInRayTracing_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetEvaluateWorldPositionOffsetInRayTracing_NewValue_Offset), 0, SetEvaluateWorldPositionOffsetInRayTracing_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetEvaluateWorldPositionOffsetInRayTracing_FunctionAddress, intPtr, SetEvaluateWorldPositionOffsetInRayTracing_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.StaticMeshComponent:SetDistanceFieldSelfShadowBias")]
	public unsafe void SetDistanceFieldSelfShadowBias(float NewValue)
	{
		CheckDestroyed();
		if (!SetDistanceFieldSelfShadowBias_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.StaticMeshComponent:SetDistanceFieldSelfShadowBias");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDistanceFieldSelfShadowBias_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDistanceFieldSelfShadowBias_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetDistanceFieldSelfShadowBias_NewValue_Offset), 0, SetDistanceFieldSelfShadowBias_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetDistanceFieldSelfShadowBias_FunctionAddress, intPtr, SetDistanceFieldSelfShadowBias_ParamsSize);
	}

	[UFunction(Flags = 1422001153u)]
	[UMetaPath("/Script/Engine.StaticMeshComponent:GetLocalBounds")]
	public unsafe void GetLocalBounds(out FVector Min, out FVector Max)
	{
		CheckDestroyed();
		if (!GetLocalBounds_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.StaticMeshComponent:GetLocalBounds");
			Min = default(FVector);
			Max = default(FVector);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLocalBounds_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLocalBounds_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetLocalBounds_FunctionAddress, intPtr, GetLocalBounds_ParamsSize);
		Min = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetLocalBounds_Min_Offset), 0, GetLocalBounds_Min_PropertyAddress.Address);
		Max = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetLocalBounds_Max_Offset), 0, GetLocalBounds_Max_PropertyAddress.Address);
	}

	static UStaticMeshComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UStaticMeshComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UStaticMeshComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.StaticMeshComponent");
		ForcedLodModel_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ForcedLodModel");
		ForcedLodModel_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ForcedLodModel", Classes.FIntProperty);
		MinLOD_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MinLOD");
		MinLOD_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MinLOD", Classes.FIntProperty);
		StaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StaticMesh");
		StaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StaticMesh", Classes.FObjectProperty);
		WireframeColorOverride_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WireframeColorOverride");
		WireframeColorOverride_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WireframeColorOverride", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref EvaluateWorldPositionOffset_PropertyAddress, intPtr, "bEvaluateWorldPositionOffset");
		EvaluateWorldPositionOffset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEvaluateWorldPositionOffset");
		EvaluateWorldPositionOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEvaluateWorldPositionOffset", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref OverrideWireframeColor_PropertyAddress, intPtr, "bOverrideWireframeColor");
		OverrideWireframeColor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bOverrideWireframeColor");
		OverrideWireframeColor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bOverrideWireframeColor", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref OverrideMinLOD_PropertyAddress, intPtr, "bOverrideMinLOD");
		OverrideMinLOD_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bOverrideMinLOD");
		OverrideMinLOD_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bOverrideMinLOD", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref DisallowMeshPaintPerInstance_PropertyAddress, intPtr, "bDisallowMeshPaintPerInstance");
		DisallowMeshPaintPerInstance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bDisallowMeshPaintPerInstance");
		DisallowMeshPaintPerInstance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bDisallowMeshPaintPerInstance", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IgnoreInstanceForTextureStreaming_PropertyAddress, intPtr, "bIgnoreInstanceForTextureStreaming");
		IgnoreInstanceForTextureStreaming_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIgnoreInstanceForTextureStreaming");
		IgnoreInstanceForTextureStreaming_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIgnoreInstanceForTextureStreaming", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref OverrideLightMapRes_PropertyAddress, intPtr, "bOverrideLightMapRes");
		OverrideLightMapRes_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bOverrideLightMapRes");
		OverrideLightMapRes_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bOverrideLightMapRes", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CastDistanceFieldIndirectShadow_PropertyAddress, intPtr, "bCastDistanceFieldIndirectShadow");
		CastDistanceFieldIndirectShadow_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCastDistanceFieldIndirectShadow");
		CastDistanceFieldIndirectShadow_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCastDistanceFieldIndirectShadow", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref OverrideDistanceFieldSelfShadowBias_PropertyAddress, intPtr, "bOverrideDistanceFieldSelfShadowBias");
		OverrideDistanceFieldSelfShadowBias_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bOverrideDistanceFieldSelfShadowBias");
		OverrideDistanceFieldSelfShadowBias_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bOverrideDistanceFieldSelfShadowBias", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SortTriangles_PropertyAddress, intPtr, "bSortTriangles");
		SortTriangles_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bSortTriangles");
		SortTriangles_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bSortTriangles", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ReverseCulling_PropertyAddress, intPtr, "bReverseCulling");
		ReverseCulling_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bReverseCulling");
		ReverseCulling_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bReverseCulling", Classes.FBoolProperty);
		OverriddenLightMapRes_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OverriddenLightMapRes");
		OverriddenLightMapRes_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OverriddenLightMapRes", Classes.FIntProperty);
		DistanceFieldIndirectShadowMinVisibility_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DistanceFieldIndirectShadowMinVisibility");
		DistanceFieldIndirectShadowMinVisibility_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DistanceFieldIndirectShadowMinVisibility", Classes.FFloatProperty);
		DistanceFieldSelfShadowBias_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DistanceFieldSelfShadowBias");
		DistanceFieldSelfShadowBias_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DistanceFieldSelfShadowBias", Classes.FFloatProperty);
		StreamingDistanceMultiplier_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StreamingDistanceMultiplier");
		StreamingDistanceMultiplier_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StreamingDistanceMultiplier", Classes.FFloatProperty);
		SetStaticMesh_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetStaticMesh");
		SetStaticMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(SetStaticMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetStaticMesh_NewMesh_PropertyAddress, SetStaticMesh_FunctionAddress, "NewMesh");
		SetStaticMesh_NewMesh_Offset = NativeReflectionCached.GetPropertyOffset(SetStaticMesh_FunctionAddress, "NewMesh");
		SetStaticMesh_NewMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStaticMesh_FunctionAddress, "NewMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetStaticMesh_ReturnValue_PropertyAddress, SetStaticMesh_FunctionAddress, "ReturnValue");
		SetStaticMesh_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetStaticMesh_FunctionAddress, "ReturnValue");
		SetStaticMesh_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStaticMesh_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetStaticMesh_IsValid = SetStaticMesh_FunctionAddress != IntPtr.Zero && SetStaticMesh_NewMesh_IsValid && SetStaticMesh_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.StaticMeshComponent:SetStaticMesh", SetStaticMesh_IsValid);
		SetReverseCulling_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetReverseCulling");
		SetReverseCulling_ParamsSize = NativeReflection.GetFunctionParamsSize(SetReverseCulling_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetReverseCulling_ReverseCulling_PropertyAddress, SetReverseCulling_FunctionAddress, "ReverseCulling");
		SetReverseCulling_ReverseCulling_Offset = NativeReflectionCached.GetPropertyOffset(SetReverseCulling_FunctionAddress, "ReverseCulling");
		SetReverseCulling_ReverseCulling_IsValid = NativeReflectionCached.ValidatePropertyClass(SetReverseCulling_FunctionAddress, "ReverseCulling", Classes.FBoolProperty);
		SetReverseCulling_IsValid = SetReverseCulling_FunctionAddress != IntPtr.Zero && SetReverseCulling_ReverseCulling_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.StaticMeshComponent:SetReverseCulling", SetReverseCulling_IsValid);
		SetForcedLodModel_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetForcedLodModel");
		SetForcedLodModel_ParamsSize = NativeReflection.GetFunctionParamsSize(SetForcedLodModel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetForcedLodModel_NewForcedLodModel_PropertyAddress, SetForcedLodModel_FunctionAddress, "NewForcedLodModel");
		SetForcedLodModel_NewForcedLodModel_Offset = NativeReflectionCached.GetPropertyOffset(SetForcedLodModel_FunctionAddress, "NewForcedLodModel");
		SetForcedLodModel_NewForcedLodModel_IsValid = NativeReflectionCached.ValidatePropertyClass(SetForcedLodModel_FunctionAddress, "NewForcedLodModel", Classes.FIntProperty);
		SetForcedLodModel_IsValid = SetForcedLodModel_FunctionAddress != IntPtr.Zero && SetForcedLodModel_NewForcedLodModel_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.StaticMeshComponent:SetForcedLodModel", SetForcedLodModel_IsValid);
		SetEvaluateWorldPositionOffsetInRayTracing_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetEvaluateWorldPositionOffsetInRayTracing");
		SetEvaluateWorldPositionOffsetInRayTracing_ParamsSize = NativeReflection.GetFunctionParamsSize(SetEvaluateWorldPositionOffsetInRayTracing_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetEvaluateWorldPositionOffsetInRayTracing_NewValue_PropertyAddress, SetEvaluateWorldPositionOffsetInRayTracing_FunctionAddress, "NewValue");
		SetEvaluateWorldPositionOffsetInRayTracing_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetEvaluateWorldPositionOffsetInRayTracing_FunctionAddress, "NewValue");
		SetEvaluateWorldPositionOffsetInRayTracing_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetEvaluateWorldPositionOffsetInRayTracing_FunctionAddress, "NewValue", Classes.FBoolProperty);
		SetEvaluateWorldPositionOffsetInRayTracing_IsValid = SetEvaluateWorldPositionOffsetInRayTracing_FunctionAddress != IntPtr.Zero && SetEvaluateWorldPositionOffsetInRayTracing_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.StaticMeshComponent:SetEvaluateWorldPositionOffsetInRayTracing", SetEvaluateWorldPositionOffsetInRayTracing_IsValid);
		SetDistanceFieldSelfShadowBias_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetDistanceFieldSelfShadowBias");
		SetDistanceFieldSelfShadowBias_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDistanceFieldSelfShadowBias_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDistanceFieldSelfShadowBias_NewValue_PropertyAddress, SetDistanceFieldSelfShadowBias_FunctionAddress, "NewValue");
		SetDistanceFieldSelfShadowBias_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetDistanceFieldSelfShadowBias_FunctionAddress, "NewValue");
		SetDistanceFieldSelfShadowBias_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDistanceFieldSelfShadowBias_FunctionAddress, "NewValue", Classes.FFloatProperty);
		SetDistanceFieldSelfShadowBias_IsValid = SetDistanceFieldSelfShadowBias_FunctionAddress != IntPtr.Zero && SetDistanceFieldSelfShadowBias_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.StaticMeshComponent:SetDistanceFieldSelfShadowBias", SetDistanceFieldSelfShadowBias_IsValid);
		GetLocalBounds_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetLocalBounds");
		GetLocalBounds_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLocalBounds_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLocalBounds_Min_PropertyAddress, GetLocalBounds_FunctionAddress, "Min");
		GetLocalBounds_Min_Offset = NativeReflectionCached.GetPropertyOffset(GetLocalBounds_FunctionAddress, "Min");
		GetLocalBounds_Min_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLocalBounds_FunctionAddress, "Min", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLocalBounds_Max_PropertyAddress, GetLocalBounds_FunctionAddress, "Max");
		GetLocalBounds_Max_Offset = NativeReflectionCached.GetPropertyOffset(GetLocalBounds_FunctionAddress, "Max");
		GetLocalBounds_Max_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLocalBounds_FunctionAddress, "Max", Classes.FStructProperty);
		GetLocalBounds_IsValid = GetLocalBounds_FunctionAddress != IntPtr.Zero && GetLocalBounds_Min_IsValid && GetLocalBounds_Max_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.StaticMeshComponent:GetLocalBounds", GetLocalBounds_IsValid);
	}
}

using System;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace b1.Plugins.GSDynamicSDF;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/GSDynamicSDF.GSDynamicSDFInitializer", "GSDynamicSDF", UnrealModuleType.GamePlugin)]
public class AGSDynamicSDFInitializer : AActor
{
	private static bool CenterSnappedPosWS_IsValid;

	private static int CenterSnappedPosWS_Offset;

	private static bool CenterSnappedOffset_IsValid;

	private static int CenterSnappedOffset_Offset;

	private static bool PreviousCenterSnappedPosWS_IsValid;

	private static int PreviousCenterSnappedPosWS_Offset;

	private static bool PreviousCenterSnappedOffset_IsValid;

	private static int PreviousCenterSnappedOffset_Offset;

	private static bool CenterPos_IsValid;

	private static int CenterPos_Offset;

	private static bool CenterOffset_IsValid;

	private static int CenterOffset_Offset;

	private static bool PreviousCenterPos_IsValid;

	private static int PreviousCenterPos_Offset;

	private static bool UsedElementCount_IsValid;

	private static int UsedElementCount_Offset;

	private static bool Data_IsValid;

	private static FFieldAddress Data_PropertyAddress;

	private static int Data_Offset;

	private TArrayReadWriteMarshaler<FVector4> Data_MarshalerCached;

	private static bool Velocity_IsValid;

	private static FFieldAddress Velocity_PropertyAddress;

	private static int Velocity_Offset;

	private TArrayReadWriteMarshaler<FVector4> Velocity_MarshalerCached;

	private static bool VertexNormal_IsValid;

	private static FFieldAddress VertexNormal_PropertyAddress;

	private static int VertexNormal_Offset;

	private TArrayReadWriteMarshaler<FVector4> VertexNormal_MarshalerCached;

	private static bool MPC_IsValid;

	private static int MPC_Offset;

	private static bool NPC_IsValid;

	private static int NPC_Offset;

	private static bool NPCInst_IsValid;

	private static int NPCInst_Offset;

	[UProperty(Flags = (PropFlags)6755469234283013uL)]
	[UMetaPath("/Script/GSDynamicSDF.GSDynamicSDFInitializer:CenterSnappedPosWS")]
	public FVector CenterSnappedPosWS
	{
		get
		{
			CheckDestroyed();
			if (!CenterSnappedPosWS_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSDynamicSDF.GSDynamicSDFInitializer:CenterSnappedPosWS");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, CenterSnappedPosWS_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CenterSnappedPosWS_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSDynamicSDF.GSDynamicSDFInitializer:CenterSnappedPosWS");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, CenterSnappedPosWS_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234283013uL)]
	[UMetaPath("/Script/GSDynamicSDF.GSDynamicSDFInitializer:CenterSnappedOffset")]
	public FVector CenterSnappedOffset
	{
		get
		{
			CheckDestroyed();
			if (!CenterSnappedOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSDynamicSDF.GSDynamicSDFInitializer:CenterSnappedOffset");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, CenterSnappedOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CenterSnappedOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSDynamicSDF.GSDynamicSDFInitializer:CenterSnappedOffset");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, CenterSnappedOffset_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234283013uL)]
	[UMetaPath("/Script/GSDynamicSDF.GSDynamicSDFInitializer:PreviousCenterSnappedPosWS")]
	public FVector PreviousCenterSnappedPosWS
	{
		get
		{
			CheckDestroyed();
			if (!PreviousCenterSnappedPosWS_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSDynamicSDF.GSDynamicSDFInitializer:PreviousCenterSnappedPosWS");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, PreviousCenterSnappedPosWS_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PreviousCenterSnappedPosWS_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSDynamicSDF.GSDynamicSDFInitializer:PreviousCenterSnappedPosWS");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, PreviousCenterSnappedPosWS_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234283013uL)]
	[UMetaPath("/Script/GSDynamicSDF.GSDynamicSDFInitializer:PreviousCenterSnappedOffset")]
	public FVector PreviousCenterSnappedOffset
	{
		get
		{
			CheckDestroyed();
			if (!PreviousCenterSnappedOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSDynamicSDF.GSDynamicSDFInitializer:PreviousCenterSnappedOffset");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, PreviousCenterSnappedOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PreviousCenterSnappedOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSDynamicSDF.GSDynamicSDFInitializer:PreviousCenterSnappedOffset");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, PreviousCenterSnappedOffset_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234283013uL)]
	[UMetaPath("/Script/GSDynamicSDF.GSDynamicSDFInitializer:CenterPos")]
	public FVector CenterPos
	{
		get
		{
			CheckDestroyed();
			if (!CenterPos_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSDynamicSDF.GSDynamicSDFInitializer:CenterPos");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, CenterPos_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CenterPos_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSDynamicSDF.GSDynamicSDFInitializer:CenterPos");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, CenterPos_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234283013uL)]
	[UMetaPath("/Script/GSDynamicSDF.GSDynamicSDFInitializer:CenterOffset")]
	public FVector CenterOffset
	{
		get
		{
			CheckDestroyed();
			if (!CenterOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSDynamicSDF.GSDynamicSDFInitializer:CenterOffset");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, CenterOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CenterOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSDynamicSDF.GSDynamicSDFInitializer:CenterOffset");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, CenterOffset_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234283013uL)]
	[UMetaPath("/Script/GSDynamicSDF.GSDynamicSDFInitializer:PreviousCenterPos")]
	public FVector PreviousCenterPos
	{
		get
		{
			CheckDestroyed();
			if (!PreviousCenterPos_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSDynamicSDF.GSDynamicSDFInitializer:PreviousCenterPos");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, PreviousCenterPos_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PreviousCenterPos_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSDynamicSDF.GSDynamicSDFInitializer:PreviousCenterPos");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, PreviousCenterPos_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234283013uL)]
	[UMetaPath("/Script/GSDynamicSDF.GSDynamicSDFInitializer:UsedElementCount")]
	public int UsedElementCount
	{
		get
		{
			CheckDestroyed();
			if (!UsedElementCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSDynamicSDF.GSDynamicSDFInitializer:UsedElementCount");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, UsedElementCount_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UsedElementCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSDynamicSDF.GSDynamicSDFInitializer:UsedElementCount");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, UsedElementCount_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627379205uL)]
	[UMetaPath("/Script/GSDynamicSDF.GSDynamicSDFInitializer:Data")]
	public TArrayReadWrite<FVector4> Data
	{
		get
		{
			CheckDestroyed();
			if (!Data_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSDynamicSDF.GSDynamicSDFInitializer:Data");
				return null;
			}
			if (Data_MarshalerCached == null)
			{
				Data_MarshalerCached = new TArrayReadWriteMarshaler<FVector4>(1, Data_PropertyAddress, CachedMarshalingDelegates<FVector4, BlittableTypeMarshaler<FVector4>>.FromNative, CachedMarshalingDelegates<FVector4, BlittableTypeMarshaler<FVector4>>.ToNative);
			}
			return Data_MarshalerCached.FromNative(IntPtr.Add(base.Address, Data_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4503599627379205uL)]
	[UMetaPath("/Script/GSDynamicSDF.GSDynamicSDFInitializer:Velocity")]
	public TArrayReadWrite<FVector4> Velocity
	{
		get
		{
			CheckDestroyed();
			if (!Velocity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSDynamicSDF.GSDynamicSDFInitializer:Velocity");
				return null;
			}
			if (Velocity_MarshalerCached == null)
			{
				Velocity_MarshalerCached = new TArrayReadWriteMarshaler<FVector4>(1, Velocity_PropertyAddress, CachedMarshalingDelegates<FVector4, BlittableTypeMarshaler<FVector4>>.FromNative, CachedMarshalingDelegates<FVector4, BlittableTypeMarshaler<FVector4>>.ToNative);
			}
			return Velocity_MarshalerCached.FromNative(IntPtr.Add(base.Address, Velocity_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4503599627379205uL)]
	[UMetaPath("/Script/GSDynamicSDF.GSDynamicSDFInitializer:VertexNormal")]
	public TArrayReadWrite<FVector4> VertexNormal
	{
		get
		{
			CheckDestroyed();
			if (!VertexNormal_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSDynamicSDF.GSDynamicSDFInitializer:VertexNormal");
				return null;
			}
			if (VertexNormal_MarshalerCached == null)
			{
				VertexNormal_MarshalerCached = new TArrayReadWriteMarshaler<FVector4>(1, VertexNormal_PropertyAddress, CachedMarshalingDelegates<FVector4, BlittableTypeMarshaler<FVector4>>.FromNative, CachedMarshalingDelegates<FVector4, BlittableTypeMarshaler<FVector4>>.ToNative);
			}
			return VertexNormal_MarshalerCached.FromNative(IntPtr.Add(base.Address, VertexNormal_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GSDynamicSDF.GSDynamicSDFInitializer:MPC")]
	public UMaterialParameterCollection MPC
	{
		get
		{
			CheckDestroyed();
			if (!MPC_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSDynamicSDF.GSDynamicSDFInitializer:MPC");
				return null;
			}
			return UObjectMarshaler<UMaterialParameterCollection>.FromNative(IntPtr.Add(base.Address, MPC_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MPC_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSDynamicSDF.GSDynamicSDFInitializer:MPC");
			}
			else
			{
				UObjectMarshaler<UMaterialParameterCollection>.ToNative(IntPtr.Add(base.Address, MPC_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GSDynamicSDF.GSDynamicSDFInitializer:NPC")]
	public UNiagaraParameterCollection NPC
	{
		get
		{
			CheckDestroyed();
			if (!NPC_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSDynamicSDF.GSDynamicSDFInitializer:NPC");
				return null;
			}
			return UObjectMarshaler<UNiagaraParameterCollection>.FromNative(IntPtr.Add(base.Address, NPC_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NPC_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSDynamicSDF.GSDynamicSDFInitializer:NPC");
			}
			else
			{
				UObjectMarshaler<UNiagaraParameterCollection>.ToNative(IntPtr.Add(base.Address, NPC_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234283013uL)]
	[UMetaPath("/Script/GSDynamicSDF.GSDynamicSDFInitializer:NPCInst")]
	public UNiagaraParameterCollectionInstance NPCInst
	{
		get
		{
			CheckDestroyed();
			if (!NPCInst_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSDynamicSDF.GSDynamicSDFInitializer:NPCInst");
				return null;
			}
			return UObjectMarshaler<UNiagaraParameterCollectionInstance>.FromNative(IntPtr.Add(base.Address, NPCInst_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NPCInst_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSDynamicSDF.GSDynamicSDFInitializer:NPCInst");
			}
			else
			{
				UObjectMarshaler<UNiagaraParameterCollectionInstance>.ToNative(IntPtr.Add(base.Address, NPCInst_Offset), value);
			}
		}
	}

	static AGSDynamicSDFInitializer()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(AGSDynamicSDFInitializer)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AGSDynamicSDFInitializer));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/GSDynamicSDF.GSDynamicSDFInitializer");
		CenterSnappedPosWS_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "CenterSnappedPosWS");
		CenterSnappedPosWS_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "CenterSnappedPosWS", Classes.FStructProperty);
		CenterSnappedOffset_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "CenterSnappedOffset");
		CenterSnappedOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "CenterSnappedOffset", Classes.FStructProperty);
		PreviousCenterSnappedPosWS_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "PreviousCenterSnappedPosWS");
		PreviousCenterSnappedPosWS_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "PreviousCenterSnappedPosWS", Classes.FStructProperty);
		PreviousCenterSnappedOffset_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "PreviousCenterSnappedOffset");
		PreviousCenterSnappedOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "PreviousCenterSnappedOffset", Classes.FStructProperty);
		CenterPos_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "CenterPos");
		CenterPos_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "CenterPos", Classes.FStructProperty);
		CenterOffset_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "CenterOffset");
		CenterOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "CenterOffset", Classes.FStructProperty);
		PreviousCenterPos_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "PreviousCenterPos");
		PreviousCenterPos_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "PreviousCenterPos", Classes.FStructProperty);
		UsedElementCount_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "UsedElementCount");
		UsedElementCount_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "UsedElementCount", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref Data_PropertyAddress, unrealStruct, "Data");
		Data_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Data");
		Data_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Data", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref Velocity_PropertyAddress, unrealStruct, "Velocity");
		Velocity_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Velocity");
		Velocity_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Velocity", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref VertexNormal_PropertyAddress, unrealStruct, "VertexNormal");
		VertexNormal_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "VertexNormal");
		VertexNormal_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "VertexNormal", Classes.FArrayProperty);
		MPC_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "MPC");
		MPC_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "MPC", Classes.FObjectProperty);
		NPC_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "NPC");
		NPC_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "NPC", Classes.FObjectProperty);
		NPCInst_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "NPCInst");
		NPCInst_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "NPCInst", Classes.FObjectProperty);
	}
}

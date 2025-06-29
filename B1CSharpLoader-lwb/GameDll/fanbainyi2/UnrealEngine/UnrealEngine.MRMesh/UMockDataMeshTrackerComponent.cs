using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.MRMesh;

[UClass(Flags = (ClassFlags)821039268uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/MRMesh.MockDataMeshTrackerComponent", "MRMesh", UnrealModuleType.Engine)]
public class UMockDataMeshTrackerComponent : USceneComponent
{
	[UDelegate]
	[UMetaPath("/Script/MRMesh.MockDataMeshTrackerComponent:OnMockDataMeshTrackerUpdated__DelegateSignature")]
	public class FOnMockDataMeshTrackerUpdated : FMulticastDelegate<FOnMockDataMeshTrackerUpdated.Signature>
	{
		public delegate void Signature(int Index, List<FVector> Vertices, List<int> Triangles, List<FVector> Normals, List<float> Confidence);

		private static bool OnMockDataMeshTrackerUpdated__DelegateSignature_IsValid;

		private static IntPtr OnMockDataMeshTrackerUpdated__DelegateSignature_FunctionAddress;

		private static int OnMockDataMeshTrackerUpdated__DelegateSignature_ParamsSize;

		private static bool OnMockDataMeshTrackerUpdated__DelegateSignature_Index_IsValid;

		private static FFieldAddress OnMockDataMeshTrackerUpdated__DelegateSignature_Index_PropertyAddress;

		private static int OnMockDataMeshTrackerUpdated__DelegateSignature_Index_Offset;

		private static bool OnMockDataMeshTrackerUpdated__DelegateSignature_Vertices_IsValid;

		private static FFieldAddress OnMockDataMeshTrackerUpdated__DelegateSignature_Vertices_PropertyAddress;

		private static int OnMockDataMeshTrackerUpdated__DelegateSignature_Vertices_Offset;

		private static bool OnMockDataMeshTrackerUpdated__DelegateSignature_Triangles_IsValid;

		private static FFieldAddress OnMockDataMeshTrackerUpdated__DelegateSignature_Triangles_PropertyAddress;

		private static int OnMockDataMeshTrackerUpdated__DelegateSignature_Triangles_Offset;

		private static bool OnMockDataMeshTrackerUpdated__DelegateSignature_Normals_IsValid;

		private static FFieldAddress OnMockDataMeshTrackerUpdated__DelegateSignature_Normals_PropertyAddress;

		private static int OnMockDataMeshTrackerUpdated__DelegateSignature_Normals_Offset;

		private static bool OnMockDataMeshTrackerUpdated__DelegateSignature_Confidence_IsValid;

		private static FFieldAddress OnMockDataMeshTrackerUpdated__DelegateSignature_Confidence_PropertyAddress;

		private static int OnMockDataMeshTrackerUpdated__DelegateSignature_Confidence_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FOnMockDataMeshTrackerUpdated()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			OnMockDataMeshTrackerUpdated__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/MRMesh.MockDataMeshTrackerComponent:OnMockDataMeshTrackerUpdated__DelegateSignature");
			OnMockDataMeshTrackerUpdated__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnMockDataMeshTrackerUpdated__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref OnMockDataMeshTrackerUpdated__DelegateSignature_Index_PropertyAddress, OnMockDataMeshTrackerUpdated__DelegateSignature_FunctionAddress, "Index");
			OnMockDataMeshTrackerUpdated__DelegateSignature_Index_Offset = NativeReflectionCached.GetPropertyOffset(OnMockDataMeshTrackerUpdated__DelegateSignature_FunctionAddress, "Index");
			OnMockDataMeshTrackerUpdated__DelegateSignature_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(OnMockDataMeshTrackerUpdated__DelegateSignature_FunctionAddress, "Index", Classes.FIntProperty);
			NativeReflectionCached.GetPropertyRef(ref OnMockDataMeshTrackerUpdated__DelegateSignature_Vertices_PropertyAddress, OnMockDataMeshTrackerUpdated__DelegateSignature_FunctionAddress, "Vertices");
			OnMockDataMeshTrackerUpdated__DelegateSignature_Vertices_Offset = NativeReflectionCached.GetPropertyOffset(OnMockDataMeshTrackerUpdated__DelegateSignature_FunctionAddress, "Vertices");
			OnMockDataMeshTrackerUpdated__DelegateSignature_Vertices_IsValid = NativeReflectionCached.ValidatePropertyClass(OnMockDataMeshTrackerUpdated__DelegateSignature_FunctionAddress, "Vertices", Classes.FArrayProperty);
			NativeReflectionCached.GetPropertyRef(ref OnMockDataMeshTrackerUpdated__DelegateSignature_Triangles_PropertyAddress, OnMockDataMeshTrackerUpdated__DelegateSignature_FunctionAddress, "Triangles");
			OnMockDataMeshTrackerUpdated__DelegateSignature_Triangles_Offset = NativeReflectionCached.GetPropertyOffset(OnMockDataMeshTrackerUpdated__DelegateSignature_FunctionAddress, "Triangles");
			OnMockDataMeshTrackerUpdated__DelegateSignature_Triangles_IsValid = NativeReflectionCached.ValidatePropertyClass(OnMockDataMeshTrackerUpdated__DelegateSignature_FunctionAddress, "Triangles", Classes.FArrayProperty);
			NativeReflectionCached.GetPropertyRef(ref OnMockDataMeshTrackerUpdated__DelegateSignature_Normals_PropertyAddress, OnMockDataMeshTrackerUpdated__DelegateSignature_FunctionAddress, "Normals");
			OnMockDataMeshTrackerUpdated__DelegateSignature_Normals_Offset = NativeReflectionCached.GetPropertyOffset(OnMockDataMeshTrackerUpdated__DelegateSignature_FunctionAddress, "Normals");
			OnMockDataMeshTrackerUpdated__DelegateSignature_Normals_IsValid = NativeReflectionCached.ValidatePropertyClass(OnMockDataMeshTrackerUpdated__DelegateSignature_FunctionAddress, "Normals", Classes.FArrayProperty);
			NativeReflectionCached.GetPropertyRef(ref OnMockDataMeshTrackerUpdated__DelegateSignature_Confidence_PropertyAddress, OnMockDataMeshTrackerUpdated__DelegateSignature_FunctionAddress, "Confidence");
			OnMockDataMeshTrackerUpdated__DelegateSignature_Confidence_Offset = NativeReflectionCached.GetPropertyOffset(OnMockDataMeshTrackerUpdated__DelegateSignature_FunctionAddress, "Confidence");
			OnMockDataMeshTrackerUpdated__DelegateSignature_Confidence_IsValid = NativeReflectionCached.ValidatePropertyClass(OnMockDataMeshTrackerUpdated__DelegateSignature_FunctionAddress, "Confidence", Classes.FArrayProperty);
			OnMockDataMeshTrackerUpdated__DelegateSignature_IsValid = OnMockDataMeshTrackerUpdated__DelegateSignature_FunctionAddress != IntPtr.Zero && OnMockDataMeshTrackerUpdated__DelegateSignature_Index_IsValid && OnMockDataMeshTrackerUpdated__DelegateSignature_Vertices_IsValid && OnMockDataMeshTrackerUpdated__DelegateSignature_Triangles_IsValid && OnMockDataMeshTrackerUpdated__DelegateSignature_Normals_IsValid && OnMockDataMeshTrackerUpdated__DelegateSignature_Confidence_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/MRMesh.MockDataMeshTrackerComponent:OnMockDataMeshTrackerUpdated__DelegateSignature", OnMockDataMeshTrackerUpdated__DelegateSignature_IsValid);
		}

		private unsafe void Invoker(int Index, List<FVector> Vertices, List<int> Triangles, List<FVector> Normals, List<float> Confidence)
		{
			if (!OnMockDataMeshTrackerUpdated__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/MRMesh.MockDataMeshTrackerComponent:OnMockDataMeshTrackerUpdated__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(OnMockDataMeshTrackerUpdated__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnMockDataMeshTrackerUpdated__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, OnMockDataMeshTrackerUpdated__DelegateSignature_Index_Offset), 0, OnMockDataMeshTrackerUpdated__DelegateSignature_Index_PropertyAddress.Address, Index);
				new TArrayCopyMarshaler<FVector>(1, OnMockDataMeshTrackerUpdated__DelegateSignature_Vertices_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).ToNative(IntPtr.Add(intPtr, OnMockDataMeshTrackerUpdated__DelegateSignature_Vertices_Offset), Vertices);
				new TArrayCopyMarshaler<int>(1, OnMockDataMeshTrackerUpdated__DelegateSignature_Triangles_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(intPtr, OnMockDataMeshTrackerUpdated__DelegateSignature_Triangles_Offset), Triangles);
				new TArrayCopyMarshaler<FVector>(1, OnMockDataMeshTrackerUpdated__DelegateSignature_Normals_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).ToNative(IntPtr.Add(intPtr, OnMockDataMeshTrackerUpdated__DelegateSignature_Normals_Offset), Normals);
				new TArrayCopyMarshaler<float>(1, OnMockDataMeshTrackerUpdated__DelegateSignature_Confidence_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).ToNative(IntPtr.Add(intPtr, OnMockDataMeshTrackerUpdated__DelegateSignature_Confidence_Offset), Confidence);
				ProcessDelegate(intPtr);
				NativeReflection.DestroyValue_InContainer(OnMockDataMeshTrackerUpdated__DelegateSignature_Vertices_PropertyAddress.Address, intPtr);
				NativeReflection.DestroyValue_InContainer(OnMockDataMeshTrackerUpdated__DelegateSignature_Triangles_PropertyAddress.Address, intPtr);
				NativeReflection.DestroyValue_InContainer(OnMockDataMeshTrackerUpdated__DelegateSignature_Normals_PropertyAddress.Address, intPtr);
				NativeReflection.DestroyValue_InContainer(OnMockDataMeshTrackerUpdated__DelegateSignature_Confidence_PropertyAddress.Address, intPtr);
			}
		}
	}

	private static bool OnMeshTrackerUpdated_IsValid;

	private static int OnMeshTrackerUpdated_Offset;

	private FOnMockDataMeshTrackerUpdated OnMeshTrackerUpdated_DelegateCached;

	private static bool ScanWorld_IsValid;

	private static FFieldAddress ScanWorld_PropertyAddress;

	private static int ScanWorld_Offset;

	private static bool RequestNormals_IsValid;

	private static FFieldAddress RequestNormals_PropertyAddress;

	private static int RequestNormals_Offset;

	private static bool RequestVertexConfidence_IsValid;

	private static FFieldAddress RequestVertexConfidence_PropertyAddress;

	private static int RequestVertexConfidence_Offset;

	private static bool VertexColorMode_IsValid;

	private static FFieldAddress VertexColorMode_PropertyAddress;

	private static int VertexColorMode_Offset;

	private static bool BlockVertexColors_IsValid;

	private static FFieldAddress BlockVertexColors_PropertyAddress;

	private static int BlockVertexColors_Offset;

	private TArrayReadWriteMarshaler<FColor> BlockVertexColors_MarshalerCached;

	private static bool VertexColorFromConfidenceZero_IsValid;

	private static int VertexColorFromConfidenceZero_Offset;

	private static bool VertexColorFromConfidenceOne_IsValid;

	private static int VertexColorFromConfidenceOne_Offset;

	private static bool UpdateInterval_IsValid;

	private static int UpdateInterval_Offset;

	private static bool DisconnectMRMesh_IsValid;

	private static IntPtr DisconnectMRMesh_FunctionAddress;

	private static int DisconnectMRMesh_ParamsSize;

	private static bool DisconnectMRMesh_InMRMeshPtr_IsValid;

	private static FFieldAddress DisconnectMRMesh_InMRMeshPtr_PropertyAddress;

	private static int DisconnectMRMesh_InMRMeshPtr_Offset;

	private static bool ConnectMRMesh_IsValid;

	private static IntPtr ConnectMRMesh_FunctionAddress;

	private static int ConnectMRMesh_ParamsSize;

	private static bool ConnectMRMesh_InMRMeshPtr_IsValid;

	private static FFieldAddress ConnectMRMesh_InMRMeshPtr_PropertyAddress;

	private static int ConnectMRMesh_InMRMeshPtr_Offset;

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/MRMesh.MockDataMeshTrackerComponent:OnMeshTrackerUpdated")]
	public FOnMockDataMeshTrackerUpdated OnMeshTrackerUpdated
	{
		get
		{
			CheckDestroyed();
			if (!OnMeshTrackerUpdated_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MRMesh.MockDataMeshTrackerComponent:OnMeshTrackerUpdated");
				return new FOnMockDataMeshTrackerUpdated();
			}
			if (OnMeshTrackerUpdated_DelegateCached == null)
			{
				OnMeshTrackerUpdated_DelegateCached = new FOnMockDataMeshTrackerUpdated();
				OnMeshTrackerUpdated_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnMeshTrackerUpdated_Offset));
			}
			return OnMeshTrackerUpdated_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MRMesh.MockDataMeshTrackerComponent:ScanWorld")]
	public bool ScanWorld
	{
		get
		{
			CheckDestroyed();
			if (!ScanWorld_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MRMesh.MockDataMeshTrackerComponent:ScanWorld");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ScanWorld_Offset), 0, ScanWorld_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ScanWorld_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MRMesh.MockDataMeshTrackerComponent:ScanWorld");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ScanWorld_Offset), 0, ScanWorld_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MRMesh.MockDataMeshTrackerComponent:RequestNormals")]
	public bool RequestNormals
	{
		get
		{
			CheckDestroyed();
			if (!RequestNormals_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MRMesh.MockDataMeshTrackerComponent:RequestNormals");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, RequestNormals_Offset), 0, RequestNormals_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!RequestNormals_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MRMesh.MockDataMeshTrackerComponent:RequestNormals");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, RequestNormals_Offset), 0, RequestNormals_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MRMesh.MockDataMeshTrackerComponent:RequestVertexConfidence")]
	public bool RequestVertexConfidence
	{
		get
		{
			CheckDestroyed();
			if (!RequestVertexConfidence_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MRMesh.MockDataMeshTrackerComponent:RequestVertexConfidence");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, RequestVertexConfidence_Offset), 0, RequestVertexConfidence_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!RequestVertexConfidence_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MRMesh.MockDataMeshTrackerComponent:RequestVertexConfidence");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, RequestVertexConfidence_Offset), 0, RequestVertexConfidence_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MRMesh.MockDataMeshTrackerComponent:VertexColorMode")]
	public EMeshTrackerVertexColorMode VertexColorMode
	{
		get
		{
			CheckDestroyed();
			if (!VertexColorMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MRMesh.MockDataMeshTrackerComponent:VertexColorMode");
				return EMeshTrackerVertexColorMode.None;
			}
			return EnumMarshaler<EMeshTrackerVertexColorMode>.FromNative(IntPtr.Add(base.Address, VertexColorMode_Offset), 0, VertexColorMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!VertexColorMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MRMesh.MockDataMeshTrackerComponent:VertexColorMode");
			}
			else
			{
				EnumMarshaler<EMeshTrackerVertexColorMode>.ToNative(IntPtr.Add(base.Address, VertexColorMode_Offset), 0, VertexColorMode_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/MRMesh.MockDataMeshTrackerComponent:BlockVertexColors")]
	public TArrayReadWrite<FColor> BlockVertexColors
	{
		get
		{
			CheckDestroyed();
			if (!BlockVertexColors_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MRMesh.MockDataMeshTrackerComponent:BlockVertexColors");
				return null;
			}
			if (BlockVertexColors_MarshalerCached == null)
			{
				BlockVertexColors_MarshalerCached = new TArrayReadWriteMarshaler<FColor>(1, BlockVertexColors_PropertyAddress, CachedMarshalingDelegates<FColor, BlittableTypeMarshaler<FColor>>.FromNative, CachedMarshalingDelegates<FColor, BlittableTypeMarshaler<FColor>>.ToNative);
			}
			return BlockVertexColors_MarshalerCached.FromNative(IntPtr.Add(base.Address, BlockVertexColors_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MRMesh.MockDataMeshTrackerComponent:VertexColorFromConfidenceZero")]
	public FLinearColor VertexColorFromConfidenceZero
	{
		get
		{
			CheckDestroyed();
			if (!VertexColorFromConfidenceZero_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MRMesh.MockDataMeshTrackerComponent:VertexColorFromConfidenceZero");
				return default(FLinearColor);
			}
			return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(base.Address, VertexColorFromConfidenceZero_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VertexColorFromConfidenceZero_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MRMesh.MockDataMeshTrackerComponent:VertexColorFromConfidenceZero");
			}
			else
			{
				BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(base.Address, VertexColorFromConfidenceZero_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MRMesh.MockDataMeshTrackerComponent:VertexColorFromConfidenceOne")]
	public FLinearColor VertexColorFromConfidenceOne
	{
		get
		{
			CheckDestroyed();
			if (!VertexColorFromConfidenceOne_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MRMesh.MockDataMeshTrackerComponent:VertexColorFromConfidenceOne");
				return default(FLinearColor);
			}
			return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(base.Address, VertexColorFromConfidenceOne_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VertexColorFromConfidenceOne_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MRMesh.MockDataMeshTrackerComponent:VertexColorFromConfidenceOne");
			}
			else
			{
				BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(base.Address, VertexColorFromConfidenceOne_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MRMesh.MockDataMeshTrackerComponent:UpdateInterval")]
	public float UpdateInterval
	{
		get
		{
			CheckDestroyed();
			if (!UpdateInterval_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MRMesh.MockDataMeshTrackerComponent:UpdateInterval");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, UpdateInterval_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UpdateInterval_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MRMesh.MockDataMeshTrackerComponent:UpdateInterval");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, UpdateInterval_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MRMesh.MockDataMeshTrackerComponent:DisconnectMRMesh")]
	public unsafe void DisconnectMRMesh(UMRMeshComponent InMRMeshPtr)
	{
		CheckDestroyed();
		if (!DisconnectMRMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MRMesh.MockDataMeshTrackerComponent:DisconnectMRMesh");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DisconnectMRMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DisconnectMRMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMRMeshComponent>.ToNative(IntPtr.Add(intPtr, DisconnectMRMesh_InMRMeshPtr_Offset), 0, DisconnectMRMesh_InMRMeshPtr_PropertyAddress.Address, InMRMeshPtr);
		NativeReflection.InvokeFunctionOptimized(base.Address, DisconnectMRMesh_FunctionAddress, intPtr, DisconnectMRMesh_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MRMesh.MockDataMeshTrackerComponent:ConnectMRMesh")]
	public unsafe void ConnectMRMesh(UMRMeshComponent InMRMeshPtr)
	{
		CheckDestroyed();
		if (!ConnectMRMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MRMesh.MockDataMeshTrackerComponent:ConnectMRMesh");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConnectMRMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConnectMRMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMRMeshComponent>.ToNative(IntPtr.Add(intPtr, ConnectMRMesh_InMRMeshPtr_Offset), 0, ConnectMRMesh_InMRMeshPtr_PropertyAddress.Address, InMRMeshPtr);
		NativeReflection.InvokeFunctionOptimized(base.Address, ConnectMRMesh_FunctionAddress, intPtr, ConnectMRMesh_ParamsSize);
	}

	static UMockDataMeshTrackerComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMockDataMeshTrackerComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMockDataMeshTrackerComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/MRMesh.MockDataMeshTrackerComponent");
		OnMeshTrackerUpdated_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnMeshTrackerUpdated");
		OnMeshTrackerUpdated_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnMeshTrackerUpdated", Classes.FMulticastDelegateProperty);
		NativeReflectionCached.GetPropertyRef(ref ScanWorld_PropertyAddress, intPtr, "ScanWorld");
		ScanWorld_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ScanWorld");
		ScanWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ScanWorld", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RequestNormals_PropertyAddress, intPtr, "RequestNormals");
		RequestNormals_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RequestNormals");
		RequestNormals_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RequestNormals", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RequestVertexConfidence_PropertyAddress, intPtr, "RequestVertexConfidence");
		RequestVertexConfidence_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RequestVertexConfidence");
		RequestVertexConfidence_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RequestVertexConfidence", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref VertexColorMode_PropertyAddress, intPtr, "VertexColorMode");
		VertexColorMode_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VertexColorMode");
		VertexColorMode_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VertexColorMode", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref BlockVertexColors_PropertyAddress, intPtr, "BlockVertexColors");
		BlockVertexColors_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BlockVertexColors");
		BlockVertexColors_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BlockVertexColors", Classes.FArrayProperty);
		VertexColorFromConfidenceZero_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VertexColorFromConfidenceZero");
		VertexColorFromConfidenceZero_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VertexColorFromConfidenceZero", Classes.FStructProperty);
		VertexColorFromConfidenceOne_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VertexColorFromConfidenceOne");
		VertexColorFromConfidenceOne_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VertexColorFromConfidenceOne", Classes.FStructProperty);
		UpdateInterval_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UpdateInterval");
		UpdateInterval_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UpdateInterval", Classes.FFloatProperty);
		DisconnectMRMesh_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "DisconnectMRMesh");
		DisconnectMRMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(DisconnectMRMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DisconnectMRMesh_InMRMeshPtr_PropertyAddress, DisconnectMRMesh_FunctionAddress, "InMRMeshPtr");
		DisconnectMRMesh_InMRMeshPtr_Offset = NativeReflectionCached.GetPropertyOffset(DisconnectMRMesh_FunctionAddress, "InMRMeshPtr");
		DisconnectMRMesh_InMRMeshPtr_IsValid = NativeReflectionCached.ValidatePropertyClass(DisconnectMRMesh_FunctionAddress, "InMRMeshPtr", Classes.FObjectProperty);
		DisconnectMRMesh_IsValid = DisconnectMRMesh_FunctionAddress != IntPtr.Zero && DisconnectMRMesh_InMRMeshPtr_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MRMesh.MockDataMeshTrackerComponent:DisconnectMRMesh", DisconnectMRMesh_IsValid);
		ConnectMRMesh_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ConnectMRMesh");
		ConnectMRMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(ConnectMRMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ConnectMRMesh_InMRMeshPtr_PropertyAddress, ConnectMRMesh_FunctionAddress, "InMRMeshPtr");
		ConnectMRMesh_InMRMeshPtr_Offset = NativeReflectionCached.GetPropertyOffset(ConnectMRMesh_FunctionAddress, "InMRMeshPtr");
		ConnectMRMesh_InMRMeshPtr_IsValid = NativeReflectionCached.ValidatePropertyClass(ConnectMRMesh_FunctionAddress, "InMRMeshPtr", Classes.FObjectProperty);
		ConnectMRMesh_IsValid = ConnectMRMesh_FunctionAddress != IntPtr.Zero && ConnectMRMesh_InMRMeshPtr_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MRMesh.MockDataMeshTrackerComponent:ConnectMRMesh", ConnectMRMesh_IsValid);
	}
}

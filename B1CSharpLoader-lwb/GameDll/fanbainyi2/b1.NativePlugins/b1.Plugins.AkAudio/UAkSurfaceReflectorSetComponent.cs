using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/AkAudio.AkSurfaceReflectorSetComponent", "AkAudio", UnrealModuleType.GamePlugin)]
public class UAkSurfaceReflectorSetComponent : UAkAcousticTextureSetComponent
{
	private static bool EnableSurfaceReflectors_IsValid;

	private static FFieldAddress EnableSurfaceReflectors_PropertyAddress;

	private static int EnableSurfaceReflectors_Offset;

	private static bool AcousticPolys_IsValid;

	private static FFieldAddress AcousticPolys_PropertyAddress;

	private static int AcousticPolys_Offset;

	private TArrayReadWriteMarshaler<FAkSurfacePoly> AcousticPolys_MarshalerCached;

	private static bool EnableDiffraction_IsValid;

	private static FFieldAddress EnableDiffraction_PropertyAddress;

	private static int EnableDiffraction_Offset;

	private static bool EnableDiffractionOnBoundaryEdges_IsValid;

	private static FFieldAddress EnableDiffractionOnBoundaryEdges_PropertyAddress;

	private static int EnableDiffractionOnBoundaryEdges_Offset;

	private static bool AssociatedRoom_IsValid;

	private static int AssociatedRoom_Offset;

	private static bool UpdateSurfaceReflectorSet_IsValid;

	private static IntPtr UpdateSurfaceReflectorSet_FunctionAddress;

	private static int UpdateSurfaceReflectorSet_ParamsSize;

	private static bool UpdateAcousticProperties_IsValid;

	private static IntPtr UpdateAcousticProperties_FunctionAddress;

	private static int UpdateAcousticProperties_ParamsSize;

	private static bool UpdateAcousticProperties_in_AcousticPolys_IsValid;

	private static FFieldAddress UpdateAcousticProperties_in_AcousticPolys_PropertyAddress;

	private static int UpdateAcousticProperties_in_AcousticPolys_Offset;

	private static bool SendSurfaceReflectorSet_IsValid;

	private static IntPtr SendSurfaceReflectorSet_FunctionAddress;

	private static int SendSurfaceReflectorSet_ParamsSize;

	private static bool RemoveSurfaceReflectorSet_IsValid;

	private static IntPtr RemoveSurfaceReflectorSet_FunctionAddress;

	private static int RemoveSurfaceReflectorSet_ParamsSize;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AkAudio.AkSurfaceReflectorSetComponent:bEnableSurfaceReflectors")]
	public bool EnableSurfaceReflectors
	{
		get
		{
			CheckDestroyed();
			if (!EnableSurfaceReflectors_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkSurfaceReflectorSetComponent:bEnableSurfaceReflectors");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableSurfaceReflectors_Offset), 0, EnableSurfaceReflectors_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableSurfaceReflectors_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkSurfaceReflectorSetComponent:bEnableSurfaceReflectors");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableSurfaceReflectors_Offset), 0, EnableSurfaceReflectors_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/AkAudio.AkSurfaceReflectorSetComponent:AcousticPolys")]
	public TArrayReadWrite<FAkSurfacePoly> AcousticPolys
	{
		get
		{
			CheckDestroyed();
			if (!AcousticPolys_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkSurfaceReflectorSetComponent:AcousticPolys");
				return null;
			}
			if (AcousticPolys_MarshalerCached == null)
			{
				AcousticPolys_MarshalerCached = new TArrayReadWriteMarshaler<FAkSurfacePoly>(1, AcousticPolys_PropertyAddress, CachedMarshalingDelegates<FAkSurfacePoly, FAkSurfacePoly>.FromNative, CachedMarshalingDelegates<FAkSurfacePoly, FAkSurfacePoly>.ToNative);
			}
			return AcousticPolys_MarshalerCached.FromNative(IntPtr.Add(base.Address, AcousticPolys_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AkAudio.AkSurfaceReflectorSetComponent:bEnableDiffraction")]
	public bool EnableDiffraction
	{
		get
		{
			CheckDestroyed();
			if (!EnableDiffraction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkSurfaceReflectorSetComponent:bEnableDiffraction");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableDiffraction_Offset), 0, EnableDiffraction_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableDiffraction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkSurfaceReflectorSetComponent:bEnableDiffraction");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableDiffraction_Offset), 0, EnableDiffraction_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AkAudio.AkSurfaceReflectorSetComponent:bEnableDiffractionOnBoundaryEdges")]
	public bool EnableDiffractionOnBoundaryEdges
	{
		get
		{
			CheckDestroyed();
			if (!EnableDiffractionOnBoundaryEdges_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkSurfaceReflectorSetComponent:bEnableDiffractionOnBoundaryEdges");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableDiffractionOnBoundaryEdges_Offset), 0, EnableDiffractionOnBoundaryEdges_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableDiffractionOnBoundaryEdges_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkSurfaceReflectorSetComponent:bEnableDiffractionOnBoundaryEdges");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableDiffractionOnBoundaryEdges_Offset), 0, EnableDiffractionOnBoundaryEdges_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AkAudio.AkSurfaceReflectorSetComponent:AssociatedRoom")]
	public AActor AssociatedRoom
	{
		get
		{
			CheckDestroyed();
			if (!AssociatedRoom_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkSurfaceReflectorSetComponent:AssociatedRoom");
				return null;
			}
			return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(base.Address, AssociatedRoom_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AssociatedRoom_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkSurfaceReflectorSetComponent:AssociatedRoom");
			}
			else
			{
				UObjectMarshaler<AActor>.ToNative(IntPtr.Add(base.Address, AssociatedRoom_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/AkAudio.AkSurfaceReflectorSetComponent:UpdateSurfaceReflectorSet")]
	public unsafe void UpdateSurfaceReflectorSet()
	{
		CheckDestroyed();
		if (!UpdateSurfaceReflectorSet_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkSurfaceReflectorSetComponent:UpdateSurfaceReflectorSet");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UpdateSurfaceReflectorSet_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UpdateSurfaceReflectorSet_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: UpdateSurfaceReflectorSet_FunctionAddress, argsSize: UpdateSurfaceReflectorSet_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/AkAudio.AkSurfaceReflectorSetComponent:UpdateAcousticProperties")]
	public unsafe void UpdateAcousticProperties(List<FAkSurfacePoly> in_AcousticPolys)
	{
		CheckDestroyed();
		if (!UpdateAcousticProperties_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkSurfaceReflectorSetComponent:UpdateAcousticProperties");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UpdateAcousticProperties_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UpdateAcousticProperties_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FAkSurfacePoly>(1, UpdateAcousticProperties_in_AcousticPolys_PropertyAddress, CachedMarshalingDelegates<FAkSurfacePoly, FAkSurfacePoly>.FromNative, CachedMarshalingDelegates<FAkSurfacePoly, FAkSurfacePoly>.ToNative).ToNative(IntPtr.Add(intPtr, UpdateAcousticProperties_in_AcousticPolys_Offset), in_AcousticPolys);
		NativeReflection.InvokeFunctionOptimized(base.Address, UpdateAcousticProperties_FunctionAddress, intPtr, UpdateAcousticProperties_ParamsSize);
		NativeReflection.DestroyValue_InContainer(UpdateAcousticProperties_in_AcousticPolys_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/AkAudio.AkSurfaceReflectorSetComponent:SendSurfaceReflectorSet")]
	public unsafe void SendSurfaceReflectorSet()
	{
		CheckDestroyed();
		if (!SendSurfaceReflectorSet_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkSurfaceReflectorSetComponent:SendSurfaceReflectorSet");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SendSurfaceReflectorSet_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SendSurfaceReflectorSet_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: SendSurfaceReflectorSet_FunctionAddress, argsSize: SendSurfaceReflectorSet_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/AkAudio.AkSurfaceReflectorSetComponent:RemoveSurfaceReflectorSet")]
	public unsafe void RemoveSurfaceReflectorSet()
	{
		CheckDestroyed();
		if (!RemoveSurfaceReflectorSet_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkSurfaceReflectorSetComponent:RemoveSurfaceReflectorSet");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveSurfaceReflectorSet_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveSurfaceReflectorSet_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: RemoveSurfaceReflectorSet_FunctionAddress, argsSize: RemoveSurfaceReflectorSet_ParamsSize);
	}

	static UAkSurfaceReflectorSetComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAkSurfaceReflectorSetComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAkSurfaceReflectorSetComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/AkAudio.AkSurfaceReflectorSetComponent");
		NativeReflectionCached.GetPropertyRef(ref EnableSurfaceReflectors_PropertyAddress, intPtr, "bEnableSurfaceReflectors");
		EnableSurfaceReflectors_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnableSurfaceReflectors");
		EnableSurfaceReflectors_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnableSurfaceReflectors", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AcousticPolys_PropertyAddress, intPtr, "AcousticPolys");
		AcousticPolys_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AcousticPolys");
		AcousticPolys_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AcousticPolys", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableDiffraction_PropertyAddress, intPtr, "bEnableDiffraction");
		EnableDiffraction_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnableDiffraction");
		EnableDiffraction_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnableDiffraction", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableDiffractionOnBoundaryEdges_PropertyAddress, intPtr, "bEnableDiffractionOnBoundaryEdges");
		EnableDiffractionOnBoundaryEdges_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnableDiffractionOnBoundaryEdges");
		EnableDiffractionOnBoundaryEdges_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnableDiffractionOnBoundaryEdges", Classes.FBoolProperty);
		AssociatedRoom_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AssociatedRoom");
		AssociatedRoom_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AssociatedRoom", Classes.FObjectProperty);
		UpdateSurfaceReflectorSet_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UpdateSurfaceReflectorSet");
		UpdateSurfaceReflectorSet_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateSurfaceReflectorSet_FunctionAddress);
		UpdateSurfaceReflectorSet_IsValid = UpdateSurfaceReflectorSet_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkSurfaceReflectorSetComponent:UpdateSurfaceReflectorSet", UpdateSurfaceReflectorSet_IsValid);
		UpdateAcousticProperties_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UpdateAcousticProperties");
		UpdateAcousticProperties_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateAcousticProperties_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UpdateAcousticProperties_in_AcousticPolys_PropertyAddress, UpdateAcousticProperties_FunctionAddress, "in_AcousticPolys");
		UpdateAcousticProperties_in_AcousticPolys_Offset = NativeReflectionCached.GetPropertyOffset(UpdateAcousticProperties_FunctionAddress, "in_AcousticPolys");
		UpdateAcousticProperties_in_AcousticPolys_IsValid = NativeReflectionCached.ValidatePropertyClass(UpdateAcousticProperties_FunctionAddress, "in_AcousticPolys", Classes.FArrayProperty);
		UpdateAcousticProperties_IsValid = UpdateAcousticProperties_FunctionAddress != IntPtr.Zero && UpdateAcousticProperties_in_AcousticPolys_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkSurfaceReflectorSetComponent:UpdateAcousticProperties", UpdateAcousticProperties_IsValid);
		SendSurfaceReflectorSet_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SendSurfaceReflectorSet");
		SendSurfaceReflectorSet_ParamsSize = NativeReflection.GetFunctionParamsSize(SendSurfaceReflectorSet_FunctionAddress);
		SendSurfaceReflectorSet_IsValid = SendSurfaceReflectorSet_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkSurfaceReflectorSetComponent:SendSurfaceReflectorSet", SendSurfaceReflectorSet_IsValid);
		RemoveSurfaceReflectorSet_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RemoveSurfaceReflectorSet");
		RemoveSurfaceReflectorSet_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveSurfaceReflectorSet_FunctionAddress);
		RemoveSurfaceReflectorSet_IsValid = RemoveSurfaceReflectorSet_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkSurfaceReflectorSetComponent:RemoveSurfaceReflectorSet", RemoveSurfaceReflectorSet_IsValid);
	}
}

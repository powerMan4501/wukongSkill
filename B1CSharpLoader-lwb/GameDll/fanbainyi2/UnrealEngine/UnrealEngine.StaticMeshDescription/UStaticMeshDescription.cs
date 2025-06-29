using System;
using System.Runtime.CompilerServices;
using UnrealEngine.MeshDescription;
using UnrealEngine.Runtime;

namespace UnrealEngine.StaticMeshDescription;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/StaticMeshDescription.StaticMeshDescription", "StaticMeshDescription", UnrealModuleType.Engine)]
public class UStaticMeshDescription : UMeshDescriptionBase
{
	private static bool SetVertexInstanceUV_IsValid;

	private static IntPtr SetVertexInstanceUV_FunctionAddress;

	private static int SetVertexInstanceUV_ParamsSize;

	private static bool SetVertexInstanceUV_VertexInstanceID_IsValid;

	private static FFieldAddress SetVertexInstanceUV_VertexInstanceID_PropertyAddress;

	private static int SetVertexInstanceUV_VertexInstanceID_Offset;

	private static bool SetVertexInstanceUV_UV_IsValid;

	private static FFieldAddress SetVertexInstanceUV_UV_PropertyAddress;

	private static int SetVertexInstanceUV_UV_Offset;

	private static bool SetVertexInstanceUV_UVIndex_IsValid;

	private static FFieldAddress SetVertexInstanceUV_UVIndex_PropertyAddress;

	private static int SetVertexInstanceUV_UVIndex_Offset;

	private static bool SetPolygonGroupMaterialSlotName_IsValid;

	private static IntPtr SetPolygonGroupMaterialSlotName_FunctionAddress;

	private static int SetPolygonGroupMaterialSlotName_ParamsSize;

	private static bool SetPolygonGroupMaterialSlotName_PolygonGroupID_IsValid;

	private static FFieldAddress SetPolygonGroupMaterialSlotName_PolygonGroupID_PropertyAddress;

	private static int SetPolygonGroupMaterialSlotName_PolygonGroupID_Offset;

	private static bool SetPolygonGroupMaterialSlotName_SlotName_IsValid;

	private static FFieldAddress SetPolygonGroupMaterialSlotName_SlotName_PropertyAddress;

	private static int SetPolygonGroupMaterialSlotName_SlotName_Offset;

	private static bool GetVertexInstanceUV_IsValid;

	private static IntPtr GetVertexInstanceUV_FunctionAddress;

	private static int GetVertexInstanceUV_ParamsSize;

	private static bool GetVertexInstanceUV_VertexInstanceID_IsValid;

	private static FFieldAddress GetVertexInstanceUV_VertexInstanceID_PropertyAddress;

	private static int GetVertexInstanceUV_VertexInstanceID_Offset;

	private static bool GetVertexInstanceUV_UVIndex_IsValid;

	private static FFieldAddress GetVertexInstanceUV_UVIndex_PropertyAddress;

	private static int GetVertexInstanceUV_UVIndex_Offset;

	private static bool GetVertexInstanceUV_ReturnValue_IsValid;

	private static FFieldAddress GetVertexInstanceUV_ReturnValue_PropertyAddress;

	private static int GetVertexInstanceUV_ReturnValue_Offset;

	private static bool CreateCube_IsValid;

	private static IntPtr CreateCube_FunctionAddress;

	private static int CreateCube_ParamsSize;

	private static bool CreateCube_Center_IsValid;

	private static FFieldAddress CreateCube_Center_PropertyAddress;

	private static int CreateCube_Center_Offset;

	private static bool CreateCube_HalfExtents_IsValid;

	private static FFieldAddress CreateCube_HalfExtents_PropertyAddress;

	private static int CreateCube_HalfExtents_Offset;

	private static bool CreateCube_PolygonGroup_IsValid;

	private static FFieldAddress CreateCube_PolygonGroup_PropertyAddress;

	private static int CreateCube_PolygonGroup_Offset;

	private static bool CreateCube_PolygonID_PlusX_IsValid;

	private static FFieldAddress CreateCube_PolygonID_PlusX_PropertyAddress;

	private static int CreateCube_PolygonID_PlusX_Offset;

	private static bool CreateCube_PolygonID_MinusX_IsValid;

	private static FFieldAddress CreateCube_PolygonID_MinusX_PropertyAddress;

	private static int CreateCube_PolygonID_MinusX_Offset;

	private static bool CreateCube_PolygonID_PlusY_IsValid;

	private static FFieldAddress CreateCube_PolygonID_PlusY_PropertyAddress;

	private static int CreateCube_PolygonID_PlusY_Offset;

	private static bool CreateCube_PolygonID_MinusY_IsValid;

	private static FFieldAddress CreateCube_PolygonID_MinusY_PropertyAddress;

	private static int CreateCube_PolygonID_MinusY_Offset;

	private static bool CreateCube_PolygonID_PlusZ_IsValid;

	private static FFieldAddress CreateCube_PolygonID_PlusZ_PropertyAddress;

	private static int CreateCube_PolygonID_PlusZ_Offset;

	private static bool CreateCube_PolygonID_MinusZ_IsValid;

	private static FFieldAddress CreateCube_PolygonID_MinusZ_PropertyAddress;

	private static int CreateCube_PolygonID_MinusZ_Offset;

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/StaticMeshDescription.StaticMeshDescription:SetVertexInstanceUV")]
	public unsafe void SetVertexInstanceUV(FVertexInstanceID VertexInstanceID, FVector2D UV, int UVIndex = 0)
	{
		CheckDestroyed();
		if (!SetVertexInstanceUV_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/StaticMeshDescription.StaticMeshDescription:SetVertexInstanceUV");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetVertexInstanceUV_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetVertexInstanceUV_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetVertexInstanceUV_VertexInstanceID_PropertyAddress.Address, intPtr);
		FVertexInstanceID.ToNative(IntPtr.Add(intPtr, SetVertexInstanceUV_VertexInstanceID_Offset), 0, SetVertexInstanceUV_VertexInstanceID_PropertyAddress.Address, VertexInstanceID);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, SetVertexInstanceUV_UV_Offset), 0, SetVertexInstanceUV_UV_PropertyAddress.Address, UV);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetVertexInstanceUV_UVIndex_Offset), 0, SetVertexInstanceUV_UVIndex_PropertyAddress.Address, UVIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetVertexInstanceUV_FunctionAddress, intPtr, SetVertexInstanceUV_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/StaticMeshDescription.StaticMeshDescription:SetPolygonGroupMaterialSlotName")]
	public unsafe void SetPolygonGroupMaterialSlotName(FPolygonGroupID PolygonGroupID, FName SlotName)
	{
		CheckDestroyed();
		if (!SetPolygonGroupMaterialSlotName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/StaticMeshDescription.StaticMeshDescription:SetPolygonGroupMaterialSlotName");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPolygonGroupMaterialSlotName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPolygonGroupMaterialSlotName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetPolygonGroupMaterialSlotName_PolygonGroupID_PropertyAddress.Address, intPtr);
		FPolygonGroupID.ToNative(IntPtr.Add(intPtr, SetPolygonGroupMaterialSlotName_PolygonGroupID_Offset), 0, SetPolygonGroupMaterialSlotName_PolygonGroupID_PropertyAddress.Address, PolygonGroupID);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetPolygonGroupMaterialSlotName_SlotName_Offset), 0, SetPolygonGroupMaterialSlotName_SlotName_PropertyAddress.Address, SlotName);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPolygonGroupMaterialSlotName_FunctionAddress, intPtr, SetPolygonGroupMaterialSlotName_ParamsSize);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/StaticMeshDescription.StaticMeshDescription:GetVertexInstanceUV")]
	public unsafe FVector2D GetVertexInstanceUV(FVertexInstanceID VertexInstanceID, int UVIndex = 0)
	{
		CheckDestroyed();
		if (!GetVertexInstanceUV_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/StaticMeshDescription.StaticMeshDescription:GetVertexInstanceUV");
			return default(FVector2D);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetVertexInstanceUV_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetVertexInstanceUV_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetVertexInstanceUV_VertexInstanceID_PropertyAddress.Address, intPtr);
		FVertexInstanceID.ToNative(IntPtr.Add(intPtr, GetVertexInstanceUV_VertexInstanceID_Offset), 0, GetVertexInstanceUV_VertexInstanceID_PropertyAddress.Address, VertexInstanceID);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetVertexInstanceUV_UVIndex_Offset), 0, GetVertexInstanceUV_UVIndex_PropertyAddress.Address, UVIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetVertexInstanceUV_FunctionAddress, intPtr, GetVertexInstanceUV_ParamsSize);
		return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, GetVertexInstanceUV_ReturnValue_Offset), 0, GetVertexInstanceUV_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/StaticMeshDescription.StaticMeshDescription:CreateCube")]
	public unsafe void CreateCube(FVector Center, FVector HalfExtents, FPolygonGroupID PolygonGroup, out FPolygonID PolygonID_PlusX, out FPolygonID PolygonID_MinusX, out FPolygonID PolygonID_PlusY, out FPolygonID PolygonID_MinusY, out FPolygonID PolygonID_PlusZ, out FPolygonID PolygonID_MinusZ)
	{
		CheckDestroyed();
		if (!CreateCube_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/StaticMeshDescription.StaticMeshDescription:CreateCube");
			PolygonID_PlusX = default(FPolygonID);
			PolygonID_MinusX = default(FPolygonID);
			PolygonID_PlusY = default(FPolygonID);
			PolygonID_MinusY = default(FPolygonID);
			PolygonID_PlusZ = default(FPolygonID);
			PolygonID_MinusZ = default(FPolygonID);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateCube_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateCube_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, CreateCube_Center_Offset), 0, CreateCube_Center_PropertyAddress.Address, Center);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, CreateCube_HalfExtents_Offset), 0, CreateCube_HalfExtents_PropertyAddress.Address, HalfExtents);
		NativeReflection.InitializeValue_InContainer(CreateCube_PolygonGroup_PropertyAddress.Address, intPtr);
		FPolygonGroupID.ToNative(IntPtr.Add(intPtr, CreateCube_PolygonGroup_Offset), 0, CreateCube_PolygonGroup_PropertyAddress.Address, PolygonGroup);
		NativeReflection.InitializeValue_InContainer(CreateCube_PolygonID_PlusX_PropertyAddress.Address, intPtr);
		NativeReflection.InitializeValue_InContainer(CreateCube_PolygonID_MinusX_PropertyAddress.Address, intPtr);
		NativeReflection.InitializeValue_InContainer(CreateCube_PolygonID_PlusY_PropertyAddress.Address, intPtr);
		NativeReflection.InitializeValue_InContainer(CreateCube_PolygonID_MinusY_PropertyAddress.Address, intPtr);
		NativeReflection.InitializeValue_InContainer(CreateCube_PolygonID_PlusZ_PropertyAddress.Address, intPtr);
		NativeReflection.InitializeValue_InContainer(CreateCube_PolygonID_MinusZ_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeFunctionOptimized(base.Address, CreateCube_FunctionAddress, intPtr, CreateCube_ParamsSize);
		PolygonID_PlusX = FPolygonID.FromNative(IntPtr.Add(intPtr, CreateCube_PolygonID_PlusX_Offset), 0, CreateCube_PolygonID_PlusX_PropertyAddress.Address);
		PolygonID_MinusX = FPolygonID.FromNative(IntPtr.Add(intPtr, CreateCube_PolygonID_MinusX_Offset), 0, CreateCube_PolygonID_MinusX_PropertyAddress.Address);
		PolygonID_PlusY = FPolygonID.FromNative(IntPtr.Add(intPtr, CreateCube_PolygonID_PlusY_Offset), 0, CreateCube_PolygonID_PlusY_PropertyAddress.Address);
		PolygonID_MinusY = FPolygonID.FromNative(IntPtr.Add(intPtr, CreateCube_PolygonID_MinusY_Offset), 0, CreateCube_PolygonID_MinusY_PropertyAddress.Address);
		PolygonID_PlusZ = FPolygonID.FromNative(IntPtr.Add(intPtr, CreateCube_PolygonID_PlusZ_Offset), 0, CreateCube_PolygonID_PlusZ_PropertyAddress.Address);
		PolygonID_MinusZ = FPolygonID.FromNative(IntPtr.Add(intPtr, CreateCube_PolygonID_MinusZ_Offset), 0, CreateCube_PolygonID_MinusZ_PropertyAddress.Address);
	}

	static UStaticMeshDescription()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UStaticMeshDescription)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UStaticMeshDescription));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/StaticMeshDescription.StaticMeshDescription");
		SetVertexInstanceUV_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetVertexInstanceUV");
		SetVertexInstanceUV_ParamsSize = NativeReflection.GetFunctionParamsSize(SetVertexInstanceUV_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetVertexInstanceUV_VertexInstanceID_PropertyAddress, SetVertexInstanceUV_FunctionAddress, "VertexInstanceID");
		SetVertexInstanceUV_VertexInstanceID_Offset = NativeReflectionCached.GetPropertyOffset(SetVertexInstanceUV_FunctionAddress, "VertexInstanceID");
		SetVertexInstanceUV_VertexInstanceID_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVertexInstanceUV_FunctionAddress, "VertexInstanceID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetVertexInstanceUV_UV_PropertyAddress, SetVertexInstanceUV_FunctionAddress, "UV");
		SetVertexInstanceUV_UV_Offset = NativeReflectionCached.GetPropertyOffset(SetVertexInstanceUV_FunctionAddress, "UV");
		SetVertexInstanceUV_UV_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVertexInstanceUV_FunctionAddress, "UV", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetVertexInstanceUV_UVIndex_PropertyAddress, SetVertexInstanceUV_FunctionAddress, "UVIndex");
		SetVertexInstanceUV_UVIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetVertexInstanceUV_FunctionAddress, "UVIndex");
		SetVertexInstanceUV_UVIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVertexInstanceUV_FunctionAddress, "UVIndex", Classes.FIntProperty);
		SetVertexInstanceUV_IsValid = SetVertexInstanceUV_FunctionAddress != IntPtr.Zero && SetVertexInstanceUV_VertexInstanceID_IsValid && SetVertexInstanceUV_UV_IsValid && SetVertexInstanceUV_UVIndex_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/StaticMeshDescription.StaticMeshDescription:SetVertexInstanceUV", SetVertexInstanceUV_IsValid);
		SetPolygonGroupMaterialSlotName_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetPolygonGroupMaterialSlotName");
		SetPolygonGroupMaterialSlotName_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPolygonGroupMaterialSlotName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPolygonGroupMaterialSlotName_PolygonGroupID_PropertyAddress, SetPolygonGroupMaterialSlotName_FunctionAddress, "PolygonGroupID");
		SetPolygonGroupMaterialSlotName_PolygonGroupID_Offset = NativeReflectionCached.GetPropertyOffset(SetPolygonGroupMaterialSlotName_FunctionAddress, "PolygonGroupID");
		SetPolygonGroupMaterialSlotName_PolygonGroupID_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPolygonGroupMaterialSlotName_FunctionAddress, "PolygonGroupID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPolygonGroupMaterialSlotName_SlotName_PropertyAddress, SetPolygonGroupMaterialSlotName_FunctionAddress, "SlotName");
		SetPolygonGroupMaterialSlotName_SlotName_Offset = NativeReflectionCached.GetPropertyOffset(SetPolygonGroupMaterialSlotName_FunctionAddress, "SlotName");
		SetPolygonGroupMaterialSlotName_SlotName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPolygonGroupMaterialSlotName_FunctionAddress, "SlotName", Classes.FNameProperty);
		SetPolygonGroupMaterialSlotName_IsValid = SetPolygonGroupMaterialSlotName_FunctionAddress != IntPtr.Zero && SetPolygonGroupMaterialSlotName_PolygonGroupID_IsValid && SetPolygonGroupMaterialSlotName_SlotName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/StaticMeshDescription.StaticMeshDescription:SetPolygonGroupMaterialSlotName", SetPolygonGroupMaterialSlotName_IsValid);
		GetVertexInstanceUV_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetVertexInstanceUV");
		GetVertexInstanceUV_ParamsSize = NativeReflection.GetFunctionParamsSize(GetVertexInstanceUV_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetVertexInstanceUV_VertexInstanceID_PropertyAddress, GetVertexInstanceUV_FunctionAddress, "VertexInstanceID");
		GetVertexInstanceUV_VertexInstanceID_Offset = NativeReflectionCached.GetPropertyOffset(GetVertexInstanceUV_FunctionAddress, "VertexInstanceID");
		GetVertexInstanceUV_VertexInstanceID_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVertexInstanceUV_FunctionAddress, "VertexInstanceID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVertexInstanceUV_UVIndex_PropertyAddress, GetVertexInstanceUV_FunctionAddress, "UVIndex");
		GetVertexInstanceUV_UVIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetVertexInstanceUV_FunctionAddress, "UVIndex");
		GetVertexInstanceUV_UVIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVertexInstanceUV_FunctionAddress, "UVIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVertexInstanceUV_ReturnValue_PropertyAddress, GetVertexInstanceUV_FunctionAddress, "ReturnValue");
		GetVertexInstanceUV_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetVertexInstanceUV_FunctionAddress, "ReturnValue");
		GetVertexInstanceUV_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVertexInstanceUV_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetVertexInstanceUV_IsValid = GetVertexInstanceUV_FunctionAddress != IntPtr.Zero && GetVertexInstanceUV_VertexInstanceID_IsValid && GetVertexInstanceUV_UVIndex_IsValid && GetVertexInstanceUV_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/StaticMeshDescription.StaticMeshDescription:GetVertexInstanceUV", GetVertexInstanceUV_IsValid);
		CreateCube_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CreateCube");
		CreateCube_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateCube_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateCube_Center_PropertyAddress, CreateCube_FunctionAddress, "Center");
		CreateCube_Center_Offset = NativeReflectionCached.GetPropertyOffset(CreateCube_FunctionAddress, "Center");
		CreateCube_Center_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateCube_FunctionAddress, "Center", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateCube_HalfExtents_PropertyAddress, CreateCube_FunctionAddress, "HalfExtents");
		CreateCube_HalfExtents_Offset = NativeReflectionCached.GetPropertyOffset(CreateCube_FunctionAddress, "HalfExtents");
		CreateCube_HalfExtents_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateCube_FunctionAddress, "HalfExtents", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateCube_PolygonGroup_PropertyAddress, CreateCube_FunctionAddress, "PolygonGroup");
		CreateCube_PolygonGroup_Offset = NativeReflectionCached.GetPropertyOffset(CreateCube_FunctionAddress, "PolygonGroup");
		CreateCube_PolygonGroup_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateCube_FunctionAddress, "PolygonGroup", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateCube_PolygonID_PlusX_PropertyAddress, CreateCube_FunctionAddress, "PolygonID_PlusX");
		CreateCube_PolygonID_PlusX_Offset = NativeReflectionCached.GetPropertyOffset(CreateCube_FunctionAddress, "PolygonID_PlusX");
		CreateCube_PolygonID_PlusX_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateCube_FunctionAddress, "PolygonID_PlusX", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateCube_PolygonID_MinusX_PropertyAddress, CreateCube_FunctionAddress, "PolygonID_MinusX");
		CreateCube_PolygonID_MinusX_Offset = NativeReflectionCached.GetPropertyOffset(CreateCube_FunctionAddress, "PolygonID_MinusX");
		CreateCube_PolygonID_MinusX_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateCube_FunctionAddress, "PolygonID_MinusX", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateCube_PolygonID_PlusY_PropertyAddress, CreateCube_FunctionAddress, "PolygonID_PlusY");
		CreateCube_PolygonID_PlusY_Offset = NativeReflectionCached.GetPropertyOffset(CreateCube_FunctionAddress, "PolygonID_PlusY");
		CreateCube_PolygonID_PlusY_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateCube_FunctionAddress, "PolygonID_PlusY", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateCube_PolygonID_MinusY_PropertyAddress, CreateCube_FunctionAddress, "PolygonID_MinusY");
		CreateCube_PolygonID_MinusY_Offset = NativeReflectionCached.GetPropertyOffset(CreateCube_FunctionAddress, "PolygonID_MinusY");
		CreateCube_PolygonID_MinusY_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateCube_FunctionAddress, "PolygonID_MinusY", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateCube_PolygonID_PlusZ_PropertyAddress, CreateCube_FunctionAddress, "PolygonID_PlusZ");
		CreateCube_PolygonID_PlusZ_Offset = NativeReflectionCached.GetPropertyOffset(CreateCube_FunctionAddress, "PolygonID_PlusZ");
		CreateCube_PolygonID_PlusZ_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateCube_FunctionAddress, "PolygonID_PlusZ", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateCube_PolygonID_MinusZ_PropertyAddress, CreateCube_FunctionAddress, "PolygonID_MinusZ");
		CreateCube_PolygonID_MinusZ_Offset = NativeReflectionCached.GetPropertyOffset(CreateCube_FunctionAddress, "PolygonID_MinusZ");
		CreateCube_PolygonID_MinusZ_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateCube_FunctionAddress, "PolygonID_MinusZ", Classes.FStructProperty);
		CreateCube_IsValid = CreateCube_FunctionAddress != IntPtr.Zero && CreateCube_Center_IsValid && CreateCube_HalfExtents_IsValid && CreateCube_PolygonGroup_IsValid && CreateCube_PolygonID_PlusX_IsValid && CreateCube_PolygonID_MinusX_IsValid && CreateCube_PolygonID_PlusY_IsValid && CreateCube_PolygonID_MinusY_IsValid && CreateCube_PolygonID_PlusZ_IsValid && CreateCube_PolygonID_MinusZ_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/StaticMeshDescription.StaticMeshDescription:CreateCube", CreateCube_IsValid);
	}
}

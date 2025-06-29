using System;
using System.Runtime.CompilerServices;
using UnrealEngine.GeometryFramework;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ModelingComponents;

[UClass(Flags = (ClassFlags)821039268uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/ModelingComponents.OctreeDynamicMeshComponent", "ModelingComponents", UnrealModuleType.EnginePlugin)]
public class UOctreeDynamicMeshComponent : UBaseDynamicMeshComponent
{
	private static bool SetDynamicMesh_IsValid;

	private static IntPtr SetDynamicMesh_FunctionAddress;

	private static int SetDynamicMesh_ParamsSize;

	private static bool SetDynamicMesh_NewMesh_IsValid;

	private static FFieldAddress SetDynamicMesh_NewMesh_PropertyAddress;

	private static int SetDynamicMesh_NewMesh_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ModelingComponents.OctreeDynamicMeshComponent:SetDynamicMesh")]
	public unsafe void SetDynamicMesh(UDynamicMesh NewMesh)
	{
		CheckDestroyed();
		if (!SetDynamicMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ModelingComponents.OctreeDynamicMeshComponent:SetDynamicMesh");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDynamicMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDynamicMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, SetDynamicMesh_NewMesh_Offset), 0, SetDynamicMesh_NewMesh_PropertyAddress.Address, NewMesh);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetDynamicMesh_FunctionAddress, intPtr, SetDynamicMesh_ParamsSize);
	}

	static UOctreeDynamicMeshComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UOctreeDynamicMeshComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UOctreeDynamicMeshComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/ModelingComponents.OctreeDynamicMeshComponent");
		SetDynamicMesh_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetDynamicMesh");
		SetDynamicMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDynamicMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDynamicMesh_NewMesh_PropertyAddress, SetDynamicMesh_FunctionAddress, "NewMesh");
		SetDynamicMesh_NewMesh_Offset = NativeReflectionCached.GetPropertyOffset(SetDynamicMesh_FunctionAddress, "NewMesh");
		SetDynamicMesh_NewMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDynamicMesh_FunctionAddress, "NewMesh", Classes.FObjectProperty);
		SetDynamicMesh_IsValid = SetDynamicMesh_FunctionAddress != IntPtr.Zero && SetDynamicMesh_NewMesh_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ModelingComponents.OctreeDynamicMeshComponent:SetDynamicMesh", SetDynamicMesh_IsValid);
	}
}

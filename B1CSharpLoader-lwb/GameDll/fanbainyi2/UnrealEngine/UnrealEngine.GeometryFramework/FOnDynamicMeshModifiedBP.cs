using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.GeometryFramework;

[UDelegate]
[UMetaPath("/Script/GeometryFramework.OnDynamicMeshModifiedBP__DelegateSignature")]
public class FOnDynamicMeshModifiedBP : FMulticastDelegate<FOnDynamicMeshModifiedBP.Signature>
{
	public delegate void Signature(UDynamicMesh Mesh);

	private static bool OnDynamicMeshModifiedBP__DelegateSignature_IsValid;

	private static IntPtr OnDynamicMeshModifiedBP__DelegateSignature_FunctionAddress;

	private static int OnDynamicMeshModifiedBP__DelegateSignature_ParamsSize;

	private static bool OnDynamicMeshModifiedBP__DelegateSignature_Mesh_IsValid;

	private static FFieldAddress OnDynamicMeshModifiedBP__DelegateSignature_Mesh_PropertyAddress;

	private static int OnDynamicMeshModifiedBP__DelegateSignature_Mesh_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnDynamicMeshModifiedBP()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnDynamicMeshModifiedBP__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/GeometryFramework.OnDynamicMeshModifiedBP__DelegateSignature");
		OnDynamicMeshModifiedBP__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnDynamicMeshModifiedBP__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnDynamicMeshModifiedBP__DelegateSignature_Mesh_PropertyAddress, OnDynamicMeshModifiedBP__DelegateSignature_FunctionAddress, "Mesh");
		OnDynamicMeshModifiedBP__DelegateSignature_Mesh_Offset = NativeReflectionCached.GetPropertyOffset(OnDynamicMeshModifiedBP__DelegateSignature_FunctionAddress, "Mesh");
		OnDynamicMeshModifiedBP__DelegateSignature_Mesh_IsValid = NativeReflectionCached.ValidatePropertyClass(OnDynamicMeshModifiedBP__DelegateSignature_FunctionAddress, "Mesh", Classes.FObjectProperty);
		OnDynamicMeshModifiedBP__DelegateSignature_IsValid = OnDynamicMeshModifiedBP__DelegateSignature_FunctionAddress != IntPtr.Zero && OnDynamicMeshModifiedBP__DelegateSignature_Mesh_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryFramework.OnDynamicMeshModifiedBP__DelegateSignature", OnDynamicMeshModifiedBP__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(UDynamicMesh Mesh)
	{
		if (!OnDynamicMeshModifiedBP__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryFramework.OnDynamicMeshModifiedBP__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnDynamicMeshModifiedBP__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnDynamicMeshModifiedBP__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, OnDynamicMeshModifiedBP__DelegateSignature_Mesh_Offset), 0, OnDynamicMeshModifiedBP__DelegateSignature_Mesh_PropertyAddress.Address, Mesh);
			ProcessDelegate(intPtr);
		}
	}
}

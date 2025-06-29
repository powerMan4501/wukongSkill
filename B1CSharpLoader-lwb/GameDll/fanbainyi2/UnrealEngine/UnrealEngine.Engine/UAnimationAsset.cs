using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[Abstract]
[UClass(Flags = (ClassFlags)818938017uL, Config = "Engine")]
[UMetaPath("/Script/Engine.AnimationAsset", "Engine", UnrealModuleType.Engine)]
public class UAnimationAsset : UObject, IInterface_AssetUserData, IInterface, IInterface_PreviewMeshProvider
{
	private static bool SetPreviewSkeletalMesh_IsValid;

	private static IntPtr SetPreviewSkeletalMesh_FunctionAddress;

	private static int SetPreviewSkeletalMesh_ParamsSize;

	private static bool SetPreviewSkeletalMesh_PreviewMesh_IsValid;

	private static FFieldAddress SetPreviewSkeletalMesh_PreviewMesh_PropertyAddress;

	private static int SetPreviewSkeletalMesh_PreviewMesh_Offset;

	private static bool GetPlayLength_IsValid;

	private static IntPtr GetPlayLength_FunctionAddress;

	private static int GetPlayLength_ParamsSize;

	private static bool GetPlayLength_ReturnValue_IsValid;

	private static FFieldAddress GetPlayLength_ReturnValue_PropertyAddress;

	private static int GetPlayLength_ReturnValue_Offset;

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/Engine.AnimationAsset:SetPreviewSkeletalMesh")]
	public unsafe void SetPreviewSkeletalMesh(USkeletalMesh PreviewMesh)
	{
		CheckDestroyed();
		if (!SetPreviewSkeletalMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimationAsset:SetPreviewSkeletalMesh");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPreviewSkeletalMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPreviewSkeletalMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMesh>.ToNative(IntPtr.Add(intPtr, SetPreviewSkeletalMesh_PreviewMesh_Offset), 0, SetPreviewSkeletalMesh_PreviewMesh_PropertyAddress.Address, PreviewMesh);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPreviewSkeletalMesh_FunctionAddress, intPtr, SetPreviewSkeletalMesh_ParamsSize);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.AnimationAsset:GetPlayLength")]
	public unsafe float GetPlayLength()
	{
		CheckDestroyed();
		if (!GetPlayLength_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimationAsset:GetPlayLength");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPlayLength_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPlayLength_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPlayLength_FunctionAddress, intPtr, GetPlayLength_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetPlayLength_ReturnValue_Offset), 0, GetPlayLength_ReturnValue_PropertyAddress.Address);
	}

	static UAnimationAsset()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAnimationAsset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAnimationAsset));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/Engine.AnimationAsset");
		SetPreviewSkeletalMesh_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetPreviewSkeletalMesh");
		SetPreviewSkeletalMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPreviewSkeletalMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPreviewSkeletalMesh_PreviewMesh_PropertyAddress, SetPreviewSkeletalMesh_FunctionAddress, "PreviewMesh");
		SetPreviewSkeletalMesh_PreviewMesh_Offset = NativeReflectionCached.GetPropertyOffset(SetPreviewSkeletalMesh_FunctionAddress, "PreviewMesh");
		SetPreviewSkeletalMesh_PreviewMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPreviewSkeletalMesh_FunctionAddress, "PreviewMesh", Classes.FObjectProperty);
		SetPreviewSkeletalMesh_IsValid = SetPreviewSkeletalMesh_FunctionAddress != IntPtr.Zero && SetPreviewSkeletalMesh_PreviewMesh_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimationAsset:SetPreviewSkeletalMesh", SetPreviewSkeletalMesh_IsValid);
		GetPlayLength_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetPlayLength");
		GetPlayLength_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPlayLength_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPlayLength_ReturnValue_PropertyAddress, GetPlayLength_FunctionAddress, "ReturnValue");
		GetPlayLength_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPlayLength_FunctionAddress, "ReturnValue");
		GetPlayLength_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPlayLength_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetPlayLength_IsValid = GetPlayLength_FunctionAddress != IntPtr.Zero && GetPlayLength_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimationAsset:GetPlayLength", GetPlayLength_IsValid);
	}
}

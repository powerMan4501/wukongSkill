using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.IsRootComponentChanged__DelegateSignature")]
public class FIsRootComponentChanged : FMulticastDelegate<FIsRootComponentChanged.Signature>
{
	public delegate void Signature(USceneComponent UpdatedComponent, bool bIsRootComponent);

	private static bool IsRootComponentChanged__DelegateSignature_IsValid;

	private static IntPtr IsRootComponentChanged__DelegateSignature_FunctionAddress;

	private static int IsRootComponentChanged__DelegateSignature_ParamsSize;

	private static bool IsRootComponentChanged__DelegateSignature_UpdatedComponent_IsValid;

	private static FFieldAddress IsRootComponentChanged__DelegateSignature_UpdatedComponent_PropertyAddress;

	private static int IsRootComponentChanged__DelegateSignature_UpdatedComponent_Offset;

	private static bool IsRootComponentChanged__DelegateSignature_bIsRootComponent_IsValid;

	private static FFieldAddress IsRootComponentChanged__DelegateSignature_bIsRootComponent_PropertyAddress;

	private static int IsRootComponentChanged__DelegateSignature_bIsRootComponent_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FIsRootComponentChanged()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		IsRootComponentChanged__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.IsRootComponentChanged__DelegateSignature");
		IsRootComponentChanged__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(IsRootComponentChanged__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsRootComponentChanged__DelegateSignature_UpdatedComponent_PropertyAddress, IsRootComponentChanged__DelegateSignature_FunctionAddress, "UpdatedComponent");
		IsRootComponentChanged__DelegateSignature_UpdatedComponent_Offset = NativeReflectionCached.GetPropertyOffset(IsRootComponentChanged__DelegateSignature_FunctionAddress, "UpdatedComponent");
		IsRootComponentChanged__DelegateSignature_UpdatedComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(IsRootComponentChanged__DelegateSignature_FunctionAddress, "UpdatedComponent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsRootComponentChanged__DelegateSignature_bIsRootComponent_PropertyAddress, IsRootComponentChanged__DelegateSignature_FunctionAddress, "bIsRootComponent");
		IsRootComponentChanged__DelegateSignature_bIsRootComponent_Offset = NativeReflectionCached.GetPropertyOffset(IsRootComponentChanged__DelegateSignature_FunctionAddress, "bIsRootComponent");
		IsRootComponentChanged__DelegateSignature_bIsRootComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(IsRootComponentChanged__DelegateSignature_FunctionAddress, "bIsRootComponent", Classes.FBoolProperty);
		IsRootComponentChanged__DelegateSignature_IsValid = IsRootComponentChanged__DelegateSignature_FunctionAddress != IntPtr.Zero && IsRootComponentChanged__DelegateSignature_UpdatedComponent_IsValid && IsRootComponentChanged__DelegateSignature_bIsRootComponent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.IsRootComponentChanged__DelegateSignature", IsRootComponentChanged__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(USceneComponent UpdatedComponent, bool bIsRootComponent)
	{
		if (!IsRootComponentChanged__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.IsRootComponentChanged__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(IsRootComponentChanged__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsRootComponentChanged__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<USceneComponent>.ToNative(IntPtr.Add(intPtr, IsRootComponentChanged__DelegateSignature_UpdatedComponent_Offset), 0, IsRootComponentChanged__DelegateSignature_UpdatedComponent_PropertyAddress.Address, UpdatedComponent);
			BoolMarshaler.ToNative(IntPtr.Add(intPtr, IsRootComponentChanged__DelegateSignature_bIsRootComponent_Offset), 0, IsRootComponentChanged__DelegateSignature_bIsRootComponent_PropertyAddress.Address, bIsRootComponent);
			ProcessDelegate(intPtr);
		}
	}
}

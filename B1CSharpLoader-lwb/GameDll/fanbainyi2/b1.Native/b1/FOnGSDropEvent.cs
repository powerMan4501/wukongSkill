using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1;

[UDelegate]
[UMetaPath("/Script/UnrealExtent.OnGSDropEvent__DelegateSignature")]
public class FOnGSDropEvent : FMulticastDelegate<FOnGSDropEvent.Signature>
{
	public delegate void Signature(List<string> DraggedItems, List<string> DraggedFiles, List<string> DraggedFolders);

	private static bool OnGSDropEvent__DelegateSignature_IsValid;

	private static IntPtr OnGSDropEvent__DelegateSignature_FunctionAddress;

	private static int OnGSDropEvent__DelegateSignature_ParamsSize;

	private static bool OnGSDropEvent__DelegateSignature_DraggedItems_IsValid;

	private static FFieldAddress OnGSDropEvent__DelegateSignature_DraggedItems_PropertyAddress;

	private static int OnGSDropEvent__DelegateSignature_DraggedItems_Offset;

	private static bool OnGSDropEvent__DelegateSignature_DraggedFiles_IsValid;

	private static FFieldAddress OnGSDropEvent__DelegateSignature_DraggedFiles_PropertyAddress;

	private static int OnGSDropEvent__DelegateSignature_DraggedFiles_Offset;

	private static bool OnGSDropEvent__DelegateSignature_DraggedFolders_IsValid;

	private static FFieldAddress OnGSDropEvent__DelegateSignature_DraggedFolders_PropertyAddress;

	private static int OnGSDropEvent__DelegateSignature_DraggedFolders_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnGSDropEvent()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnGSDropEvent__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/UnrealExtent.OnGSDropEvent__DelegateSignature");
		OnGSDropEvent__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnGSDropEvent__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnGSDropEvent__DelegateSignature_DraggedItems_PropertyAddress, OnGSDropEvent__DelegateSignature_FunctionAddress, "DraggedItems");
		OnGSDropEvent__DelegateSignature_DraggedItems_Offset = NativeReflectionCached.GetPropertyOffset(OnGSDropEvent__DelegateSignature_FunctionAddress, "DraggedItems");
		OnGSDropEvent__DelegateSignature_DraggedItems_IsValid = NativeReflectionCached.ValidatePropertyClass(OnGSDropEvent__DelegateSignature_FunctionAddress, "DraggedItems", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref OnGSDropEvent__DelegateSignature_DraggedFiles_PropertyAddress, OnGSDropEvent__DelegateSignature_FunctionAddress, "DraggedFiles");
		OnGSDropEvent__DelegateSignature_DraggedFiles_Offset = NativeReflectionCached.GetPropertyOffset(OnGSDropEvent__DelegateSignature_FunctionAddress, "DraggedFiles");
		OnGSDropEvent__DelegateSignature_DraggedFiles_IsValid = NativeReflectionCached.ValidatePropertyClass(OnGSDropEvent__DelegateSignature_FunctionAddress, "DraggedFiles", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref OnGSDropEvent__DelegateSignature_DraggedFolders_PropertyAddress, OnGSDropEvent__DelegateSignature_FunctionAddress, "DraggedFolders");
		OnGSDropEvent__DelegateSignature_DraggedFolders_Offset = NativeReflectionCached.GetPropertyOffset(OnGSDropEvent__DelegateSignature_FunctionAddress, "DraggedFolders");
		OnGSDropEvent__DelegateSignature_DraggedFolders_IsValid = NativeReflectionCached.ValidatePropertyClass(OnGSDropEvent__DelegateSignature_FunctionAddress, "DraggedFolders", Classes.FArrayProperty);
		OnGSDropEvent__DelegateSignature_IsValid = OnGSDropEvent__DelegateSignature_FunctionAddress != IntPtr.Zero && OnGSDropEvent__DelegateSignature_DraggedItems_IsValid && OnGSDropEvent__DelegateSignature_DraggedFiles_IsValid && OnGSDropEvent__DelegateSignature_DraggedFolders_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.OnGSDropEvent__DelegateSignature", OnGSDropEvent__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(List<string> DraggedItems, List<string> DraggedFiles, List<string> DraggedFolders)
	{
		if (!OnGSDropEvent__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.OnGSDropEvent__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnGSDropEvent__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnGSDropEvent__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			new TArrayCopyMarshaler<string>(1, OnGSDropEvent__DelegateSignature_DraggedItems_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, OnGSDropEvent__DelegateSignature_DraggedItems_Offset), DraggedItems);
			new TArrayCopyMarshaler<string>(1, OnGSDropEvent__DelegateSignature_DraggedFiles_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, OnGSDropEvent__DelegateSignature_DraggedFiles_Offset), DraggedFiles);
			new TArrayCopyMarshaler<string>(1, OnGSDropEvent__DelegateSignature_DraggedFolders_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, OnGSDropEvent__DelegateSignature_DraggedFolders_Offset), DraggedFolders);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(OnGSDropEvent__DelegateSignature_DraggedItems_PropertyAddress.Address, intPtr);
			NativeReflection.DestroyValue_InContainer(OnGSDropEvent__DelegateSignature_DraggedFiles_PropertyAddress.Address, intPtr);
			NativeReflection.DestroyValue_InContainer(OnGSDropEvent__DelegateSignature_DraggedFolders_PropertyAddress.Address, intPtr);
		}
	}
}

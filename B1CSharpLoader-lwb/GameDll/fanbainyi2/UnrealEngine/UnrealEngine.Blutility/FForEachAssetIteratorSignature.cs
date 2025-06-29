using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Blutility;

[UDelegate]
[UMetaPath("/Script/Blutility.ForEachAssetIteratorSignature__DelegateSignature")]
public class FForEachAssetIteratorSignature : FMulticastDelegate<FForEachAssetIteratorSignature.Signature>
{
	public delegate void Signature(UObject Asset, int Index);

	private static bool ForEachAssetIteratorSignature__DelegateSignature_IsValid;

	private static IntPtr ForEachAssetIteratorSignature__DelegateSignature_FunctionAddress;

	private static int ForEachAssetIteratorSignature__DelegateSignature_ParamsSize;

	private static bool ForEachAssetIteratorSignature__DelegateSignature_Asset_IsValid;

	private static FFieldAddress ForEachAssetIteratorSignature__DelegateSignature_Asset_PropertyAddress;

	private static int ForEachAssetIteratorSignature__DelegateSignature_Asset_Offset;

	private static bool ForEachAssetIteratorSignature__DelegateSignature_Index_IsValid;

	private static FFieldAddress ForEachAssetIteratorSignature__DelegateSignature_Index_PropertyAddress;

	private static int ForEachAssetIteratorSignature__DelegateSignature_Index_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FForEachAssetIteratorSignature()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		ForEachAssetIteratorSignature__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Blutility.ForEachAssetIteratorSignature__DelegateSignature");
		ForEachAssetIteratorSignature__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(ForEachAssetIteratorSignature__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ForEachAssetIteratorSignature__DelegateSignature_Asset_PropertyAddress, ForEachAssetIteratorSignature__DelegateSignature_FunctionAddress, "Asset");
		ForEachAssetIteratorSignature__DelegateSignature_Asset_Offset = NativeReflectionCached.GetPropertyOffset(ForEachAssetIteratorSignature__DelegateSignature_FunctionAddress, "Asset");
		ForEachAssetIteratorSignature__DelegateSignature_Asset_IsValid = NativeReflectionCached.ValidatePropertyClass(ForEachAssetIteratorSignature__DelegateSignature_FunctionAddress, "Asset", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ForEachAssetIteratorSignature__DelegateSignature_Index_PropertyAddress, ForEachAssetIteratorSignature__DelegateSignature_FunctionAddress, "Index");
		ForEachAssetIteratorSignature__DelegateSignature_Index_Offset = NativeReflectionCached.GetPropertyOffset(ForEachAssetIteratorSignature__DelegateSignature_FunctionAddress, "Index");
		ForEachAssetIteratorSignature__DelegateSignature_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(ForEachAssetIteratorSignature__DelegateSignature_FunctionAddress, "Index", Classes.FIntProperty);
		ForEachAssetIteratorSignature__DelegateSignature_IsValid = ForEachAssetIteratorSignature__DelegateSignature_FunctionAddress != IntPtr.Zero && ForEachAssetIteratorSignature__DelegateSignature_Asset_IsValid && ForEachAssetIteratorSignature__DelegateSignature_Index_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Blutility.ForEachAssetIteratorSignature__DelegateSignature", ForEachAssetIteratorSignature__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(UObject Asset, int Index)
	{
		if (!ForEachAssetIteratorSignature__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Blutility.ForEachAssetIteratorSignature__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(ForEachAssetIteratorSignature__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ForEachAssetIteratorSignature__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, ForEachAssetIteratorSignature__DelegateSignature_Asset_Offset), 0, ForEachAssetIteratorSignature__DelegateSignature_Asset_PropertyAddress.Address, Asset);
			BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ForEachAssetIteratorSignature__DelegateSignature_Index_Offset), 0, ForEachAssetIteratorSignature__DelegateSignature_Index_PropertyAddress.Address, Index);
			ProcessDelegate(intPtr);
		}
	}
}

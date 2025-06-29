using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.UMG;

[UDelegate]
[UMetaPath("/Script/UMG.DownloadImageDelegate__DelegateSignature")]
public class FDownloadImageDelegate : FMulticastDelegate<FDownloadImageDelegate.Signature>
{
	public delegate void Signature(UTexture2DDynamic Texture);

	private static bool DownloadImageDelegate__DelegateSignature_IsValid;

	private static IntPtr DownloadImageDelegate__DelegateSignature_FunctionAddress;

	private static int DownloadImageDelegate__DelegateSignature_ParamsSize;

	private static bool DownloadImageDelegate__DelegateSignature_Texture_IsValid;

	private static FFieldAddress DownloadImageDelegate__DelegateSignature_Texture_PropertyAddress;

	private static int DownloadImageDelegate__DelegateSignature_Texture_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FDownloadImageDelegate()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		DownloadImageDelegate__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/UMG.DownloadImageDelegate__DelegateSignature");
		DownloadImageDelegate__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(DownloadImageDelegate__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DownloadImageDelegate__DelegateSignature_Texture_PropertyAddress, DownloadImageDelegate__DelegateSignature_FunctionAddress, "Texture");
		DownloadImageDelegate__DelegateSignature_Texture_Offset = NativeReflectionCached.GetPropertyOffset(DownloadImageDelegate__DelegateSignature_FunctionAddress, "Texture");
		DownloadImageDelegate__DelegateSignature_Texture_IsValid = NativeReflectionCached.ValidatePropertyClass(DownloadImageDelegate__DelegateSignature_FunctionAddress, "Texture", Classes.FObjectProperty);
		DownloadImageDelegate__DelegateSignature_IsValid = DownloadImageDelegate__DelegateSignature_FunctionAddress != IntPtr.Zero && DownloadImageDelegate__DelegateSignature_Texture_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.DownloadImageDelegate__DelegateSignature", DownloadImageDelegate__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(UTexture2DDynamic Texture)
	{
		if (!DownloadImageDelegate__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.DownloadImageDelegate__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(DownloadImageDelegate__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DownloadImageDelegate__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<UTexture2DDynamic>.ToNative(IntPtr.Add(intPtr, DownloadImageDelegate__DelegateSignature_Texture_Offset), 0, DownloadImageDelegate__DelegateSignature_Texture_PropertyAddress.Address, Texture);
			ProcessDelegate(intPtr);
		}
	}
}

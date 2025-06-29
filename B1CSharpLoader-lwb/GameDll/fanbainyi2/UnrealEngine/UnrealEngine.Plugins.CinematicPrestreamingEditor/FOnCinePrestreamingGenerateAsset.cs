using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.CinematicPrestreamingEditor;

[UDelegate]
[UMetaPath("/Script/CinematicPrestreamingEditor.OnCinePrestreamingGenerateAsset__DelegateSignature")]
public class FOnCinePrestreamingGenerateAsset : FMulticastDelegate<FOnCinePrestreamingGenerateAsset.Signature>
{
	public delegate void Signature(FCinePrestreamingGenerateAssetArgs OriginalGenerationArgs);

	private static bool OnCinePrestreamingGenerateAsset__DelegateSignature_IsValid;

	private static IntPtr OnCinePrestreamingGenerateAsset__DelegateSignature_FunctionAddress;

	private static int OnCinePrestreamingGenerateAsset__DelegateSignature_ParamsSize;

	private static bool OnCinePrestreamingGenerateAsset__DelegateSignature_OriginalGenerationArgs_IsValid;

	private static FFieldAddress OnCinePrestreamingGenerateAsset__DelegateSignature_OriginalGenerationArgs_PropertyAddress;

	private static int OnCinePrestreamingGenerateAsset__DelegateSignature_OriginalGenerationArgs_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnCinePrestreamingGenerateAsset()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnCinePrestreamingGenerateAsset__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/CinematicPrestreamingEditor.OnCinePrestreamingGenerateAsset__DelegateSignature");
		OnCinePrestreamingGenerateAsset__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnCinePrestreamingGenerateAsset__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnCinePrestreamingGenerateAsset__DelegateSignature_OriginalGenerationArgs_PropertyAddress, OnCinePrestreamingGenerateAsset__DelegateSignature_FunctionAddress, "OriginalGenerationArgs");
		OnCinePrestreamingGenerateAsset__DelegateSignature_OriginalGenerationArgs_Offset = NativeReflectionCached.GetPropertyOffset(OnCinePrestreamingGenerateAsset__DelegateSignature_FunctionAddress, "OriginalGenerationArgs");
		OnCinePrestreamingGenerateAsset__DelegateSignature_OriginalGenerationArgs_IsValid = NativeReflectionCached.ValidatePropertyClass(OnCinePrestreamingGenerateAsset__DelegateSignature_FunctionAddress, "OriginalGenerationArgs", Classes.FStructProperty);
		OnCinePrestreamingGenerateAsset__DelegateSignature_IsValid = OnCinePrestreamingGenerateAsset__DelegateSignature_FunctionAddress != IntPtr.Zero && OnCinePrestreamingGenerateAsset__DelegateSignature_OriginalGenerationArgs_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/CinematicPrestreamingEditor.OnCinePrestreamingGenerateAsset__DelegateSignature", OnCinePrestreamingGenerateAsset__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(FCinePrestreamingGenerateAssetArgs OriginalGenerationArgs)
	{
		if (!OnCinePrestreamingGenerateAsset__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CinematicPrestreamingEditor.OnCinePrestreamingGenerateAsset__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnCinePrestreamingGenerateAsset__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnCinePrestreamingGenerateAsset__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			NativeReflection.InitializeValue_InContainer(OnCinePrestreamingGenerateAsset__DelegateSignature_OriginalGenerationArgs_PropertyAddress.Address, intPtr);
			FCinePrestreamingGenerateAssetArgs.ToNative(IntPtr.Add(intPtr, OnCinePrestreamingGenerateAsset__DelegateSignature_OriginalGenerationArgs_Offset), 0, OnCinePrestreamingGenerateAsset__DelegateSignature_OriginalGenerationArgs_PropertyAddress.Address, OriginalGenerationArgs);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(OnCinePrestreamingGenerateAsset__DelegateSignature_OriginalGenerationArgs_PropertyAddress.Address, intPtr);
		}
	}
}

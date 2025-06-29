using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UDelegate]
[UMetaPath("/Script/Synthesis.OnTableAltered__DelegateSignature")]
public class FOnTableAltered : FMulticastDelegate<FOnTableAltered.Signature>
{
	public delegate void Signature(int TableIndex);

	private static bool OnTableAltered__DelegateSignature_IsValid;

	private static IntPtr OnTableAltered__DelegateSignature_FunctionAddress;

	private static int OnTableAltered__DelegateSignature_ParamsSize;

	private static bool OnTableAltered__DelegateSignature_TableIndex_IsValid;

	private static FFieldAddress OnTableAltered__DelegateSignature_TableIndex_PropertyAddress;

	private static int OnTableAltered__DelegateSignature_TableIndex_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnTableAltered()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnTableAltered__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Synthesis.OnTableAltered__DelegateSignature");
		OnTableAltered__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnTableAltered__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnTableAltered__DelegateSignature_TableIndex_PropertyAddress, OnTableAltered__DelegateSignature_FunctionAddress, "TableIndex");
		OnTableAltered__DelegateSignature_TableIndex_Offset = NativeReflectionCached.GetPropertyOffset(OnTableAltered__DelegateSignature_FunctionAddress, "TableIndex");
		OnTableAltered__DelegateSignature_TableIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(OnTableAltered__DelegateSignature_FunctionAddress, "TableIndex", Classes.FIntProperty);
		OnTableAltered__DelegateSignature_IsValid = OnTableAltered__DelegateSignature_FunctionAddress != IntPtr.Zero && OnTableAltered__DelegateSignature_TableIndex_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.OnTableAltered__DelegateSignature", OnTableAltered__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(int TableIndex)
	{
		if (!OnTableAltered__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.OnTableAltered__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnTableAltered__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnTableAltered__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, OnTableAltered__DelegateSignature_TableIndex_Offset), 0, OnTableAltered__DelegateSignature_TableIndex_PropertyAddress.Address, TableIndex);
			ProcessDelegate(intPtr);
		}
	}
}

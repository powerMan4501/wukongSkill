using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Blutility;

[UDelegate]
[UMetaPath("/Script/Blutility.ForEachActorIteratorSignature__DelegateSignature")]
public class FForEachActorIteratorSignature : FMulticastDelegate<FForEachActorIteratorSignature.Signature>
{
	public delegate void Signature(AActor Actor, int Index);

	private static bool ForEachActorIteratorSignature__DelegateSignature_IsValid;

	private static IntPtr ForEachActorIteratorSignature__DelegateSignature_FunctionAddress;

	private static int ForEachActorIteratorSignature__DelegateSignature_ParamsSize;

	private static bool ForEachActorIteratorSignature__DelegateSignature_Actor_IsValid;

	private static FFieldAddress ForEachActorIteratorSignature__DelegateSignature_Actor_PropertyAddress;

	private static int ForEachActorIteratorSignature__DelegateSignature_Actor_Offset;

	private static bool ForEachActorIteratorSignature__DelegateSignature_Index_IsValid;

	private static FFieldAddress ForEachActorIteratorSignature__DelegateSignature_Index_PropertyAddress;

	private static int ForEachActorIteratorSignature__DelegateSignature_Index_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FForEachActorIteratorSignature()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		ForEachActorIteratorSignature__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Blutility.ForEachActorIteratorSignature__DelegateSignature");
		ForEachActorIteratorSignature__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(ForEachActorIteratorSignature__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ForEachActorIteratorSignature__DelegateSignature_Actor_PropertyAddress, ForEachActorIteratorSignature__DelegateSignature_FunctionAddress, "Actor");
		ForEachActorIteratorSignature__DelegateSignature_Actor_Offset = NativeReflectionCached.GetPropertyOffset(ForEachActorIteratorSignature__DelegateSignature_FunctionAddress, "Actor");
		ForEachActorIteratorSignature__DelegateSignature_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(ForEachActorIteratorSignature__DelegateSignature_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ForEachActorIteratorSignature__DelegateSignature_Index_PropertyAddress, ForEachActorIteratorSignature__DelegateSignature_FunctionAddress, "Index");
		ForEachActorIteratorSignature__DelegateSignature_Index_Offset = NativeReflectionCached.GetPropertyOffset(ForEachActorIteratorSignature__DelegateSignature_FunctionAddress, "Index");
		ForEachActorIteratorSignature__DelegateSignature_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(ForEachActorIteratorSignature__DelegateSignature_FunctionAddress, "Index", Classes.FIntProperty);
		ForEachActorIteratorSignature__DelegateSignature_IsValid = ForEachActorIteratorSignature__DelegateSignature_FunctionAddress != IntPtr.Zero && ForEachActorIteratorSignature__DelegateSignature_Actor_IsValid && ForEachActorIteratorSignature__DelegateSignature_Index_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Blutility.ForEachActorIteratorSignature__DelegateSignature", ForEachActorIteratorSignature__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(AActor Actor, int Index)
	{
		if (!ForEachActorIteratorSignature__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Blutility.ForEachActorIteratorSignature__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(ForEachActorIteratorSignature__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ForEachActorIteratorSignature__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ForEachActorIteratorSignature__DelegateSignature_Actor_Offset), 0, ForEachActorIteratorSignature__DelegateSignature_Actor_PropertyAddress.Address, Actor);
			BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ForEachActorIteratorSignature__DelegateSignature_Index_Offset), 0, ForEachActorIteratorSignature__DelegateSignature_Index_PropertyAddress.Address, Index);
			ProcessDelegate(intPtr);
		}
	}
}

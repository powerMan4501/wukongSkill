using System;
using System.Runtime.CompilerServices;
using UnrealEngine.AIModule;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.FunctionalTesting;

[UDelegate]
[UMetaPath("/Script/FunctionalTesting.FunctionalTestAISpawned__DelegateSignature")]
public class FFunctionalTestAISpawned : FMulticastDelegate<FFunctionalTestAISpawned.Signature>
{
	public delegate void Signature(AIController Controller, APawn Pawn);

	private static bool FunctionalTestAISpawned__DelegateSignature_IsValid;

	private static IntPtr FunctionalTestAISpawned__DelegateSignature_FunctionAddress;

	private static int FunctionalTestAISpawned__DelegateSignature_ParamsSize;

	private static bool FunctionalTestAISpawned__DelegateSignature_Controller_IsValid;

	private static FFieldAddress FunctionalTestAISpawned__DelegateSignature_Controller_PropertyAddress;

	private static int FunctionalTestAISpawned__DelegateSignature_Controller_Offset;

	private static bool FunctionalTestAISpawned__DelegateSignature_Pawn_IsValid;

	private static FFieldAddress FunctionalTestAISpawned__DelegateSignature_Pawn_PropertyAddress;

	private static int FunctionalTestAISpawned__DelegateSignature_Pawn_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FFunctionalTestAISpawned()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		FunctionalTestAISpawned__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/FunctionalTesting.FunctionalTestAISpawned__DelegateSignature");
		FunctionalTestAISpawned__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(FunctionalTestAISpawned__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FunctionalTestAISpawned__DelegateSignature_Controller_PropertyAddress, FunctionalTestAISpawned__DelegateSignature_FunctionAddress, "Controller");
		FunctionalTestAISpawned__DelegateSignature_Controller_Offset = NativeReflectionCached.GetPropertyOffset(FunctionalTestAISpawned__DelegateSignature_FunctionAddress, "Controller");
		FunctionalTestAISpawned__DelegateSignature_Controller_IsValid = NativeReflectionCached.ValidatePropertyClass(FunctionalTestAISpawned__DelegateSignature_FunctionAddress, "Controller", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref FunctionalTestAISpawned__DelegateSignature_Pawn_PropertyAddress, FunctionalTestAISpawned__DelegateSignature_FunctionAddress, "Pawn");
		FunctionalTestAISpawned__DelegateSignature_Pawn_Offset = NativeReflectionCached.GetPropertyOffset(FunctionalTestAISpawned__DelegateSignature_FunctionAddress, "Pawn");
		FunctionalTestAISpawned__DelegateSignature_Pawn_IsValid = NativeReflectionCached.ValidatePropertyClass(FunctionalTestAISpawned__DelegateSignature_FunctionAddress, "Pawn", Classes.FObjectProperty);
		FunctionalTestAISpawned__DelegateSignature_IsValid = FunctionalTestAISpawned__DelegateSignature_FunctionAddress != IntPtr.Zero && FunctionalTestAISpawned__DelegateSignature_Controller_IsValid && FunctionalTestAISpawned__DelegateSignature_Pawn_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.FunctionalTestAISpawned__DelegateSignature", FunctionalTestAISpawned__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(AIController Controller, APawn Pawn)
	{
		if (!FunctionalTestAISpawned__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.FunctionalTestAISpawned__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(FunctionalTestAISpawned__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FunctionalTestAISpawned__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<AIController>.ToNative(IntPtr.Add(intPtr, FunctionalTestAISpawned__DelegateSignature_Controller_Offset), 0, FunctionalTestAISpawned__DelegateSignature_Controller_PropertyAddress.Address, Controller);
			UObjectMarshaler<APawn>.ToNative(IntPtr.Add(intPtr, FunctionalTestAISpawned__DelegateSignature_Pawn_Offset), 0, FunctionalTestAISpawned__DelegateSignature_Pawn_PropertyAddress.Address, Pawn);
			ProcessDelegate(intPtr);
		}
	}
}

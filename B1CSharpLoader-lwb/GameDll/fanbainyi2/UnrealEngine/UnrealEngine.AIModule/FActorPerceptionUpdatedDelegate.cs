using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[UDelegate]
[UMetaPath("/Script/AIModule.ActorPerceptionUpdatedDelegate__DelegateSignature")]
public class FActorPerceptionUpdatedDelegate : FMulticastDelegate<FActorPerceptionUpdatedDelegate.Signature>
{
	public delegate void Signature(AActor Actor, FAIStimulus Stimulus);

	private static bool ActorPerceptionUpdatedDelegate__DelegateSignature_IsValid;

	private static IntPtr ActorPerceptionUpdatedDelegate__DelegateSignature_FunctionAddress;

	private static int ActorPerceptionUpdatedDelegate__DelegateSignature_ParamsSize;

	private static bool ActorPerceptionUpdatedDelegate__DelegateSignature_Actor_IsValid;

	private static FFieldAddress ActorPerceptionUpdatedDelegate__DelegateSignature_Actor_PropertyAddress;

	private static int ActorPerceptionUpdatedDelegate__DelegateSignature_Actor_Offset;

	private static bool ActorPerceptionUpdatedDelegate__DelegateSignature_Stimulus_IsValid;

	private static FFieldAddress ActorPerceptionUpdatedDelegate__DelegateSignature_Stimulus_PropertyAddress;

	private static int ActorPerceptionUpdatedDelegate__DelegateSignature_Stimulus_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FActorPerceptionUpdatedDelegate()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		ActorPerceptionUpdatedDelegate__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/AIModule.ActorPerceptionUpdatedDelegate__DelegateSignature");
		ActorPerceptionUpdatedDelegate__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(ActorPerceptionUpdatedDelegate__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ActorPerceptionUpdatedDelegate__DelegateSignature_Actor_PropertyAddress, ActorPerceptionUpdatedDelegate__DelegateSignature_FunctionAddress, "Actor");
		ActorPerceptionUpdatedDelegate__DelegateSignature_Actor_Offset = NativeReflectionCached.GetPropertyOffset(ActorPerceptionUpdatedDelegate__DelegateSignature_FunctionAddress, "Actor");
		ActorPerceptionUpdatedDelegate__DelegateSignature_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(ActorPerceptionUpdatedDelegate__DelegateSignature_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ActorPerceptionUpdatedDelegate__DelegateSignature_Stimulus_PropertyAddress, ActorPerceptionUpdatedDelegate__DelegateSignature_FunctionAddress, "Stimulus");
		ActorPerceptionUpdatedDelegate__DelegateSignature_Stimulus_Offset = NativeReflectionCached.GetPropertyOffset(ActorPerceptionUpdatedDelegate__DelegateSignature_FunctionAddress, "Stimulus");
		ActorPerceptionUpdatedDelegate__DelegateSignature_Stimulus_IsValid = NativeReflectionCached.ValidatePropertyClass(ActorPerceptionUpdatedDelegate__DelegateSignature_FunctionAddress, "Stimulus", Classes.FStructProperty);
		ActorPerceptionUpdatedDelegate__DelegateSignature_IsValid = ActorPerceptionUpdatedDelegate__DelegateSignature_FunctionAddress != IntPtr.Zero && ActorPerceptionUpdatedDelegate__DelegateSignature_Actor_IsValid && ActorPerceptionUpdatedDelegate__DelegateSignature_Stimulus_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.ActorPerceptionUpdatedDelegate__DelegateSignature", ActorPerceptionUpdatedDelegate__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(AActor Actor, FAIStimulus Stimulus)
	{
		if (!ActorPerceptionUpdatedDelegate__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.ActorPerceptionUpdatedDelegate__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(ActorPerceptionUpdatedDelegate__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ActorPerceptionUpdatedDelegate__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ActorPerceptionUpdatedDelegate__DelegateSignature_Actor_Offset), 0, ActorPerceptionUpdatedDelegate__DelegateSignature_Actor_PropertyAddress.Address, Actor);
			NativeReflection.InitializeValue_InContainer(ActorPerceptionUpdatedDelegate__DelegateSignature_Stimulus_PropertyAddress.Address, intPtr);
			FAIStimulus.ToNative(IntPtr.Add(intPtr, ActorPerceptionUpdatedDelegate__DelegateSignature_Stimulus_Offset), 0, ActorPerceptionUpdatedDelegate__DelegateSignature_Stimulus_PropertyAddress.Address, Stimulus);
			ProcessDelegate(intPtr);
		}
	}
}

using System;
using UnrealEngine.AnimGraphRuntime;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UClass]
[Blueprintable]
[USharpPath("/Script/b1-Managed.BUAnimSimple")]
internal class BUAnimSimple : UAnimInstance
{
	private static bool AnimIdleList_IsValid;

	private static int AnimIdleList_Offset;

	private static FFieldAddress AnimIdleList_PropertyAddress;

	private TArrayReadWriteMarshaler<UAnimSequence> AnimIdleList_Marshaler;

	private static bool GetRandomIdleAnim_IsValid;

	private static IntPtr GetRandomIdleAnim_FunctionAddress;

	private static int GetRandomIdleAnim_ParamsSize;

	private static bool GetRandomIdleAnim_Context_IsValid;

	private static int GetRandomIdleAnim_Context_Offset;

	private static FFieldAddress GetRandomIdleAnim_Context_PropertyAddress;

	private static bool GetRandomIdleAnim_Node_IsValid;

	private static int GetRandomIdleAnim_Node_Offset;

	private static FFieldAddress GetRandomIdleAnim_Node_PropertyAddress;

	private static bool BlueprintInitializeAnimation_IsValid;

	private static IntPtr BlueprintInitializeAnimation_FunctionAddress;

	private static int BlueprintInitializeAnimation_ParamsSize;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUAnimSimple:AnimIdleList")]
	public TArrayReadWrite<UAnimSequence> AnimIdleList
	{
		get
		{
			CheckDestroyed();
			if (!AnimIdleList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimSimple:AnimIdleList");
				return null;
			}
			if (AnimIdleList_Marshaler == null)
			{
				AnimIdleList_Marshaler = new TArrayReadWriteMarshaler<UAnimSequence>(1, AnimIdleList_PropertyAddress, CachedMarshalingDelegates<UAnimSequence, UObjectMarshaler<UAnimSequence>>.FromNative, CachedMarshalingDelegates<UAnimSequence, UObjectMarshaler<UAnimSequence>>.ToNative);
			}
			return AnimIdleList_Marshaler.FromNative(IntPtr.Add(base.Address, AnimIdleList_Offset));
		}
	}

	[USharpPath("/Script/b1-Managed.BUAnimSimple:BlueprintInitializeAnimation")]
	protected override void BlueprintInitializeAnimation_Implementation()
	{
		base.SkipBlueprintUpdateAnimation = 1;
	}

	[UMeta(MDClass.BlueprintThreadSafe)]
	[UFunction]
	[BlueprintCallable]
	[Category("Thread Safe")]
	[USharpPath("/Script/b1-Managed.BUAnimSimple:GetRandomIdleAnim")]
	private void GetRandomIdleAnim(ref FAnimUpdateContext Context, ref FAnimNodeReference Node)
	{
		if (AnimIdleList.Count != 0)
		{
			USequencePlayerLibrary.ConvertToSequencePlayerPure(Node, out var SequencePlayer, out var Result);
			if (Result)
			{
				int index = FMath.RandRange(0, AnimIdleList.Count - 1);
				USequencePlayerLibrary.SetSequence(SequencePlayer, AnimIdleList[index]);
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimSimple:GetRandomIdleAnim")]
	private static void GetRandomIdleAnim__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BUAnimSimple bUAnimSimple = GCHelper.Find<b1.BUAnimSimple>(obj);
		FAnimUpdateContext Context = StructAsClassMarshaler<FAnimUpdateContext>.FromNative(IntPtr.Add(buffer, GetRandomIdleAnim_Context_Offset));
		FAnimNodeReference Node = StructAsClassMarshaler<FAnimNodeReference>.FromNative(IntPtr.Add(buffer, GetRandomIdleAnim_Node_Offset));
		bUAnimSimple.GetRandomIdleAnim(ref Context, ref Node);
		StructAsClassMarshaler<FAnimUpdateContext>.ToNative(IntPtr.Add(buffer, GetRandomIdleAnim_Context_Offset), Context);
		StructAsClassMarshaler<FAnimNodeReference>.ToNative(IntPtr.Add(buffer, GetRandomIdleAnim_Node_Offset), Node);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimSimple:BlueprintInitializeAnimation")]
	private static void BlueprintInitializeAnimation__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BUAnimSimple bUAnimSimple = GCHelper.Find<b1.BUAnimSimple>(obj);
		bUAnimSimple.BlueprintInitializeAnimation_Implementation();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUAnimSimple");
		NativeReflection.GetPropertyRef(ref AnimIdleList_PropertyAddress, intPtr, "AnimIdleList");
		AnimIdleList_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimIdleList");
		AnimIdleList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimIdleList", Classes.FArrayProperty);
		GetRandomIdleAnim_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetRandomIdleAnim");
		GetRandomIdleAnim_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRandomIdleAnim_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetRandomIdleAnim_Context_PropertyAddress, GetRandomIdleAnim_FunctionAddress, "Context");
		GetRandomIdleAnim_Context_Offset = NativeReflection.GetPropertyOffset(GetRandomIdleAnim_FunctionAddress, "Context");
		GetRandomIdleAnim_Context_IsValid = NativeReflection.ValidatePropertyClass(GetRandomIdleAnim_FunctionAddress, "Context", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref GetRandomIdleAnim_Node_PropertyAddress, GetRandomIdleAnim_FunctionAddress, "Node");
		GetRandomIdleAnim_Node_Offset = NativeReflection.GetPropertyOffset(GetRandomIdleAnim_FunctionAddress, "Node");
		GetRandomIdleAnim_Node_IsValid = NativeReflection.ValidatePropertyClass(GetRandomIdleAnim_FunctionAddress, "Node", Classes.FStructProperty);
		GetRandomIdleAnim_IsValid = GetRandomIdleAnim_FunctionAddress != IntPtr.Zero && GetRandomIdleAnim_Context_IsValid && GetRandomIdleAnim_Node_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimSimple:GetRandomIdleAnim", GetRandomIdleAnim_IsValid);
		BlueprintInitializeAnimation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BlueprintInitializeAnimation");
		BlueprintInitializeAnimation_ParamsSize = NativeReflection.GetFunctionParamsSize(BlueprintInitializeAnimation_FunctionAddress);
		BlueprintInitializeAnimation_IsValid = BlueprintInitializeAnimation_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimSimple:BlueprintInitializeAnimation", BlueprintInitializeAnimation_IsValid);
	}

	static BUAnimSimple()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BUAnimSimple)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BUAnimSimple));
	}
}

using System;
using System.Collections.Generic;
using b1.Plugins.Calliope;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("Restart")]
[USharpPath("/Script/b1-Managed.BED_ComboNode_Restart")]
internal class BED_ComboNode_Restart : BED_ComboNode_State
{
	private static bool GetContextInputsInCS_IsValid;

	private static IntPtr GetContextInputsInCS_FunctionAddress;

	private static int GetContextInputsInCS_ParamsSize;

	private static bool GetContextInputsInCS_ReturnValue_IsValid;

	private static int GetContextInputsInCS_ReturnValue_Offset;

	private static FFieldAddress GetContextInputsInCS_ReturnValue_PropertyAddress;

	private static bool GetContextOutputsInCS_IsValid;

	private static IntPtr GetContextOutputsInCS_FunctionAddress;

	private static int GetContextOutputsInCS_ParamsSize;

	private static bool GetContextOutputsInCS_ReturnValue_IsValid;

	private static int GetContextOutputsInCS_ReturnValue_Offset;

	private static FFieldAddress GetContextOutputsInCS_ReturnValue_PropertyAddress;

	public override void Initialize(FObjectInitializer Initializer)
	{
		base.Initialize(Initializer);
		base.Category = "General";
		base.NodeStyle = ECalliopeNodeStyle.InOut;
		base.OutputPins.Clear();
		base.SupportsContextPins = true;
	}

	[USharpPath("/Script/b1-Managed.BED_ComboNode_Restart:GetContextInputsInCS")]
	protected override List<FName> GetContextInputsInCS_Implementation()
	{
		List<FName> list = base.GetContextOutputsInCS_Implementation();
		if (list == null || list.Count == 0)
		{
			list = new List<FName> { GetDefaultInputPin().PinName };
		}
		return list;
	}

	[USharpPath("/Script/b1-Managed.BED_ComboNode_Restart:GetContextOutputsInCS")]
	protected override List<FName> GetContextOutputsInCS_Implementation()
	{
		return null;
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.ComboNode.Restart;
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_ComboNode_Restart:GetContextInputsInCS")]
	private static void GetContextInputsInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BED_ComboNode_Restart bED_ComboNode_Restart = GCHelper.Find<b1.BED_ComboNode_Restart>(obj);
		TArrayCopyMarshaler<FName> tArrayCopyMarshaler = new TArrayCopyMarshaler<FName>(1, GetContextInputsInCS_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
		List<FName> contextInputsInCS_Implementation = bED_ComboNode_Restart.GetContextInputsInCS_Implementation();
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, GetContextInputsInCS_ReturnValue_Offset), contextInputsInCS_Implementation);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_ComboNode_Restart:GetContextOutputsInCS")]
	private static void GetContextOutputsInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BED_ComboNode_Restart bED_ComboNode_Restart = GCHelper.Find<b1.BED_ComboNode_Restart>(obj);
		TArrayCopyMarshaler<FName> tArrayCopyMarshaler = new TArrayCopyMarshaler<FName>(1, GetContextOutputsInCS_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
		List<FName> contextOutputsInCS_Implementation = bED_ComboNode_Restart.GetContextOutputsInCS_Implementation();
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, GetContextOutputsInCS_ReturnValue_Offset), contextOutputsInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BED_ComboNode_Restart");
		GetContextInputsInCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetContextInputsInCS");
		GetContextInputsInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetContextInputsInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetContextInputsInCS_ReturnValue_PropertyAddress, GetContextInputsInCS_FunctionAddress, "ReturnValue");
		GetContextInputsInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetContextInputsInCS_FunctionAddress, "ReturnValue");
		GetContextInputsInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetContextInputsInCS_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetContextInputsInCS_IsValid = GetContextInputsInCS_FunctionAddress != IntPtr.Zero && GetContextInputsInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_ComboNode_Restart:GetContextInputsInCS", GetContextInputsInCS_IsValid);
		GetContextOutputsInCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetContextOutputsInCS");
		GetContextOutputsInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetContextOutputsInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetContextOutputsInCS_ReturnValue_PropertyAddress, GetContextOutputsInCS_FunctionAddress, "ReturnValue");
		GetContextOutputsInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetContextOutputsInCS_FunctionAddress, "ReturnValue");
		GetContextOutputsInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetContextOutputsInCS_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetContextOutputsInCS_IsValid = GetContextOutputsInCS_FunctionAddress != IntPtr.Zero && GetContextOutputsInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_ComboNode_Restart:GetContextOutputsInCS", GetContextOutputsInCS_IsValid);
	}

	static BED_ComboNode_Restart()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BED_ComboNode_Restart)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BED_ComboNode_Restart));
	}
}

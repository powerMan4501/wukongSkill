using System;
using System.Collections.Generic;
using b1.Plugins.Calliope;
using UnrealEngine.Runtime;

namespace b1;

[NotBlueprintable]
[UClass]
[DisplayName("CustomExit")]
[USharpPath("/Script/b1-Managed.BED_StateNode_CustomExit")]
public class BED_StateNode_CustomExit : BED_StateNode
{
	private static bool GetContextInputsInCS_IsValid;

	private static IntPtr GetContextInputsInCS_FunctionAddress;

	private static int GetContextInputsInCS_ParamsSize;

	private static bool GetContextInputsInCS_ReturnValue_IsValid;

	private static int GetContextInputsInCS_ReturnValue_Offset;

	private static FFieldAddress GetContextInputsInCS_ReturnValue_PropertyAddress;

	public override string GetNodeName()
	{
		return B1CalliopeDef.StateNode.CustomExit;
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		base.Category = "Notifies";
		base.NodeStyle = ECalliopeNodeStyle.InOut;
		base.InputPins.Clear();
		base.OutputPins.Clear();
	}

	[USharpPath("/Script/b1-Managed.BED_StateNode_CustomExit:GetContextInputsInCS")]
	protected override List<FName> GetContextInputsInCS_Implementation()
	{
		List<FName> list = new List<FName>();
		UCalliopeAsset assetInCS = GetAssetInCS();
		if (assetInCS != null)
		{
			foreach (FName customOutput in assetInCS.GetCustomOutputs())
			{
				list.Add(customOutput);
			}
		}
		return list;
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_StateNode_CustomExit:GetContextInputsInCS")]
	private static void GetContextInputsInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_StateNode_CustomExit bED_StateNode_CustomExit = GCHelper.Find<BED_StateNode_CustomExit>(obj);
		TArrayCopyMarshaler<FName> tArrayCopyMarshaler = new TArrayCopyMarshaler<FName>(1, GetContextInputsInCS_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
		List<FName> contextInputsInCS_Implementation = bED_StateNode_CustomExit.GetContextInputsInCS_Implementation();
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, GetContextInputsInCS_ReturnValue_Offset), contextInputsInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BED_StateNode_CustomExit");
		GetContextInputsInCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetContextInputsInCS");
		GetContextInputsInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetContextInputsInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetContextInputsInCS_ReturnValue_PropertyAddress, GetContextInputsInCS_FunctionAddress, "ReturnValue");
		GetContextInputsInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetContextInputsInCS_FunctionAddress, "ReturnValue");
		GetContextInputsInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetContextInputsInCS_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetContextInputsInCS_IsValid = GetContextInputsInCS_FunctionAddress != IntPtr.Zero && GetContextInputsInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_StateNode_CustomExit:GetContextInputsInCS", GetContextInputsInCS_IsValid);
	}

	static BED_StateNode_CustomExit()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_StateNode_CustomExit)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_StateNode_CustomExit));
	}
}

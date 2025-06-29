using System;
using System.Collections.Generic;
using b1.Plugins.Calliope;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("CustomEnter")]
[NotBlueprintable]
[USharpPath("/Script/b1-Managed.BED_StateNode_CustomEnter")]
public class BED_StateNode_CustomEnter : BED_StateNode
{
	private static bool GetContextOutputsInCS_IsValid;

	private static IntPtr GetContextOutputsInCS_FunctionAddress;

	private static int GetContextOutputsInCS_ParamsSize;

	private static bool GetContextOutputsInCS_ReturnValue_IsValid;

	private static int GetContextOutputsInCS_ReturnValue_Offset;

	private static FFieldAddress GetContextOutputsInCS_ReturnValue_PropertyAddress;

	public override string GetNodeName()
	{
		return B1CalliopeDef.StateNode.CustomEnter;
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		base.Category = "Notifies";
		base.NodeStyle = ECalliopeNodeStyle.InOut;
		base.InputPins.Clear();
		base.OutputPins.Clear();
	}

	[USharpPath("/Script/b1-Managed.BED_StateNode_CustomEnter:GetContextOutputsInCS")]
	protected override List<FName> GetContextOutputsInCS_Implementation()
	{
		List<FName> list = new List<FName>();
		UCalliopeAsset assetInCS = GetAssetInCS();
		if (assetInCS != null)
		{
			foreach (FName customInput in assetInCS.GetCustomInputs())
			{
				list.Add(customInput);
			}
		}
		return list;
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_StateNode_CustomEnter:GetContextOutputsInCS")]
	private static void GetContextOutputsInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_StateNode_CustomEnter bED_StateNode_CustomEnter = GCHelper.Find<BED_StateNode_CustomEnter>(obj);
		TArrayCopyMarshaler<FName> tArrayCopyMarshaler = new TArrayCopyMarshaler<FName>(1, GetContextOutputsInCS_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
		List<FName> contextOutputsInCS_Implementation = bED_StateNode_CustomEnter.GetContextOutputsInCS_Implementation();
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, GetContextOutputsInCS_ReturnValue_Offset), contextOutputsInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BED_StateNode_CustomEnter");
		GetContextOutputsInCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetContextOutputsInCS");
		GetContextOutputsInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetContextOutputsInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetContextOutputsInCS_ReturnValue_PropertyAddress, GetContextOutputsInCS_FunctionAddress, "ReturnValue");
		GetContextOutputsInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetContextOutputsInCS_FunctionAddress, "ReturnValue");
		GetContextOutputsInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetContextOutputsInCS_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetContextOutputsInCS_IsValid = GetContextOutputsInCS_FunctionAddress != IntPtr.Zero && GetContextOutputsInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_StateNode_CustomEnter:GetContextOutputsInCS", GetContextOutputsInCS_IsValid);
	}

	static BED_StateNode_CustomEnter()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_StateNode_CustomEnter)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_StateNode_CustomEnter));
	}
}

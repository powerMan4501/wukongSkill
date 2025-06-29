using System;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[NotBlueprintable]
[DisplayName("Junction")]
[USharpPath("/Script/b1-Managed.BED_StateNode_Junction")]
public class BED_StateNode_Junction : BED_StateNode
{
	private static bool JunctionState_IsValid;

	private static int JunctionState_Offset;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_StateNode_Junction:JunctionState")]
	public FGameplayTag JunctionState
	{
		get
		{
			CheckDestroyed();
			if (!JunctionState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_StateNode_Junction:JunctionState");
				return default(FGameplayTag);
			}
			return BlittableTypeMarshaler<FGameplayTag>.FromNative(IntPtr.Add(base.Address, JunctionState_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!JunctionState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_StateNode_Junction:JunctionState");
			}
			else
			{
				BlittableTypeMarshaler<FGameplayTag>.ToNative(IntPtr.Add(base.Address, JunctionState_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		SetNodeCategory("Route");
		SetNodeStyle(ECalliopeNodeStyle.Latent);
		base.OutputPins.Clear();
	}

	public override byte[] GetCustomData()
	{
		return new StateCustom_Junction
		{
			JunctionState = JunctionState.TagName.PlainName
		}.ToByteArray();
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.StateNode.Junction;
	}

	[USharpPath("/Script/b1-Managed.BED_StateNode_Junction:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		return "Junction State: " + JunctionState.TagName.PlainName;
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_StateNode_Junction:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_StateNode_Junction bED_StateNode_Junction = GCHelper.Find<BED_StateNode_Junction>(obj);
		string nodeDescriptionInCS_Implementation = bED_StateNode_Junction.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_StateNode_Junction");
		JunctionState_Offset = NativeReflection.GetPropertyOffset(intPtr, "JunctionState");
		JunctionState_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "JunctionState", Classes.FStructProperty);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_StateNode_Junction:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_StateNode_Junction()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_StateNode_Junction)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_StateNode_Junction));
	}
}

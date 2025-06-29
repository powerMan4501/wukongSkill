using System;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("自定义事件")]
[UClass]
[USharpPath("/Script/b1-Managed.BED_MovieNode_CustomEvent")]
internal class BED_MovieNode_CustomEvent : BED_MovieNode
{
	private static bool EventTag_IsValid;

	private static int EventTag_Offset;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[Category("Custom Event")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BED_MovieNode_CustomEvent:EventTag")]
	public FGameplayTag EventTag
	{
		get
		{
			CheckDestroyed();
			if (!EventTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_CustomEvent:EventTag");
				return default(FGameplayTag);
			}
			return BlittableTypeMarshaler<FGameplayTag>.FromNative(IntPtr.Add(base.Address, EventTag_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EventTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_CustomEvent:EventTag");
			}
			else
			{
				BlittableTypeMarshaler<FGameplayTag>.ToNative(IntPtr.Add(base.Address, EventTag_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		base.Initialize(Initializer);
		SetNodeCategory("Route");
		SetNodeStyle(ECalliopeNodeStyle.InOut);
		base.InputPins.Clear();
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.MovieNode.CustomEvent;
	}

	[USharpPath("/Script/b1-Managed.BED_MovieNode_CustomEvent:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		return "Event : " + EventTag.TagName.PlainName;
	}

	public override byte[] GetCustomData()
	{
		return new MovieCustom_CustomEvent
		{
			EventName = EventTag.TagName.PlainName
		}.ToByteArray();
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_MovieNode_CustomEvent:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BED_MovieNode_CustomEvent bED_MovieNode_CustomEvent = GCHelper.Find<b1.BED_MovieNode_CustomEvent>(obj);
		string nodeDescriptionInCS_Implementation = bED_MovieNode_CustomEvent.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_MovieNode_CustomEvent");
		EventTag_Offset = NativeReflection.GetPropertyOffset(intPtr, "EventTag");
		EventTag_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EventTag", Classes.FStructProperty);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_MovieNode_CustomEvent:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_MovieNode_CustomEvent()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BED_MovieNode_CustomEvent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BED_MovieNode_CustomEvent));
	}
}

using System;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("从标记点播放")]
[USharpPath("/Script/b1-Managed.BED_MovieNode_PlayFromMarkedFrame")]
internal class BED_MovieNode_PlayFromMarkedFrame : BED_MovieNode
{
	private static bool MarkedFrameLabel_IsValid;

	private static int MarkedFrameLabel_Offset;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[DisplayName("标记名")]
	[BlueprintReadWrite]
	[Category("Config")]
	[USharpPath("/Script/b1-Managed.BED_MovieNode_PlayFromMarkedFrame:MarkedFrameLabel")]
	public FName MarkedFrameLabel
	{
		get
		{
			CheckDestroyed();
			if (!MarkedFrameLabel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_PlayFromMarkedFrame:MarkedFrameLabel");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, MarkedFrameLabel_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MarkedFrameLabel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_PlayFromMarkedFrame:MarkedFrameLabel");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, MarkedFrameLabel_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		base.Initialize(Initializer);
		SetNodeCategory("Action");
		SetNodeStyle(ECalliopeNodeStyle.Default);
		base.OutputPins.Clear();
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.MovieNode.PlayFromMarkedFrame;
	}

	[USharpPath("/Script/b1-Managed.BED_MovieNode_PlayFromMarkedFrame:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		return MarkedFrameLabel.ToString();
	}

	public override byte[] GetCustomData()
	{
		return new MovieCustom_PlayFromMarkedFrame
		{
			MarkedFrameLabel = MarkedFrameLabel.ToString()
		}.ToByteArray();
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_MovieNode_PlayFromMarkedFrame:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BED_MovieNode_PlayFromMarkedFrame bED_MovieNode_PlayFromMarkedFrame = GCHelper.Find<b1.BED_MovieNode_PlayFromMarkedFrame>(obj);
		string nodeDescriptionInCS_Implementation = bED_MovieNode_PlayFromMarkedFrame.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_MovieNode_PlayFromMarkedFrame");
		MarkedFrameLabel_Offset = NativeReflection.GetPropertyOffset(intPtr, "MarkedFrameLabel");
		MarkedFrameLabel_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MarkedFrameLabel", Classes.FNameProperty);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_MovieNode_PlayFromMarkedFrame:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_MovieNode_PlayFromMarkedFrame()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BED_MovieNode_PlayFromMarkedFrame)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BED_MovieNode_PlayFromMarkedFrame));
	}
}

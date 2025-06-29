using System;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[NotBlueprintable]
[UClass]
[DisplayName("Multi Gate")]
[USharpPath("/Script/b1-Managed.BED_QuestNode_ExecutionMultiGate")]
public class BED_QuestNode_ExecutionMultiGate : BED_QuestNode
{
	private static bool bRandom_IsValid;

	private static int bRandom_Offset;

	private static FFieldAddress bRandom_PropertyAddress;

	private static bool bLoop_IsValid;

	private static int bLoop_Offset;

	private static FFieldAddress bLoop_PropertyAddress;

	private static bool StartIndex_IsValid;

	private static int StartIndex_Offset;

	[UProperty]
	[EditDefaultsOnly]
	[Category("MultiGate")]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_ExecutionMultiGate:bRandom")]
	public bool bRandom
	{
		get
		{
			CheckDestroyed();
			if (!bRandom_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_ExecutionMultiGate:bRandom");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bRandom_Offset), 0, bRandom_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bRandom_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_ExecutionMultiGate:bRandom");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bRandom_Offset), 0, bRandom_PropertyAddress.Address, value);
			}
		}
	}

	[Category("MultiGate")]
	[EditDefaultsOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_ExecutionMultiGate:bLoop")]
	public bool bLoop
	{
		get
		{
			CheckDestroyed();
			if (!bLoop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_ExecutionMultiGate:bLoop");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLoop_Offset), 0, bLoop_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLoop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_ExecutionMultiGate:bLoop");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bLoop_Offset), 0, bLoop_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditDefaultsOnly]
	[Category("MultiGate")]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_ExecutionMultiGate:StartIndex")]
	public int StartIndex
	{
		get
		{
			CheckDestroyed();
			if (!StartIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_ExecutionMultiGate:StartIndex");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, StartIndex_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StartIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_ExecutionMultiGate:StartIndex");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, StartIndex_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		SetNodeCategory("Route");
		SetNodeStyle(ECalliopeNodeStyle.Logic);
		string pinToolTip = "Finish work of this node.\r\nCalling In input will start triggering output pins once again.";
		base.InputPins.Add(new FCalliopePin
		{
			PinName = B1GlobalFNames.Reset,
			PinToolTip = pinToolTip
		});
		SetNumberedOutputPins(0, 1);
	}

	public override byte[] GetCustomData()
	{
		return new QuestCustom_ExecutionMultiGate
		{
			IsRandom = bRandom,
			IsLoop = bLoop,
			StartIndex = StartIndex
		}.ToByteArray();
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.QuestNode.ExecutionMultiGate;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BED_QuestNode_ExecutionMultiGate");
		NativeReflection.GetPropertyRef(ref bRandom_PropertyAddress, unrealStruct, "bRandom");
		bRandom_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bRandom");
		bRandom_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bRandom", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bLoop_PropertyAddress, unrealStruct, "bLoop");
		bLoop_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bLoop");
		bLoop_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bLoop", Classes.FBoolProperty);
		StartIndex_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "StartIndex");
		StartIndex_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "StartIndex", Classes.FIntProperty);
	}

	static BED_QuestNode_ExecutionMultiGate()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_QuestNode_ExecutionMultiGate)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_QuestNode_ExecutionMultiGate));
	}
}

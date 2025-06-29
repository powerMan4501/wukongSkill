using System;
using System.Text;
using b1.Plugins.Calliope;
using Google.Protobuf;
using GurCalliopeFsm;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("Condition_IsInMap")]
[UClass]
[Placeable(true)]
[USharpPath("/Script/b1-Managed.BED_FSMNode_Condition_GI_Loading_IsInMap")]
public class BED_FSMNode_Condition_GI_Loading_IsInMap : BED_FSMNode_ConditionBase
{
	private static bool LevelName_IsValid;

	private static int LevelName_Offset;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[DisplayName("LevelName")]
	[USharpPath("/Script/b1-Managed.BED_FSMNode_Condition_GI_Loading_IsInMap:LevelName")]
	private string LevelName
	{
		get
		{
			CheckDestroyed();
			if (!LevelName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_FSMNode_Condition_GI_Loading_IsInMap:LevelName");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, LevelName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LevelName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_FSMNode_Condition_GI_Loading_IsInMap:LevelName");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, LevelName_Offset), value);
			}
		}
	}

	public override byte[] GetCustomData()
	{
		return new GI_Loading_IsInMap
		{
			LevelName = LevelName
		}.ToByteArray();
	}

	[USharpPath("/Script/b1-Managed.BED_FSMNode_Condition_GI_Loading_IsInMap:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("LevelName:" + LevelName);
		return stringBuilder.ToString();
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		base.OutputPins.Clear();
		base.OutputPins.Add(new FCalliopePin
		{
			PinName = new FName("True")
		});
		base.OutputPins.Add(new FCalliopePin
		{
			PinName = new FName("False")
		});
		SetNodeCategory("GI_Loading Condition");
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_FSMNode_Condition_GI_Loading_IsInMap:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_FSMNode_Condition_GI_Loading_IsInMap bED_FSMNode_Condition_GI_Loading_IsInMap = GCHelper.Find<BED_FSMNode_Condition_GI_Loading_IsInMap>(obj);
		string nodeDescriptionInCS_Implementation = bED_FSMNode_Condition_GI_Loading_IsInMap.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_FSMNode_Condition_GI_Loading_IsInMap");
		LevelName_Offset = NativeReflection.GetPropertyOffset(intPtr, "LevelName");
		LevelName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LevelName", Classes.FStrProperty);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_FSMNode_Condition_GI_Loading_IsInMap:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_FSMNode_Condition_GI_Loading_IsInMap()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_FSMNode_Condition_GI_Loading_IsInMap)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_FSMNode_Condition_GI_Loading_IsInMap));
	}
}

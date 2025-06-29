using System;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("Spawn Boss Trace")]
[USharpPath("/Script/b1-Managed.BED_QuestNode_SpawnBossTrace")]
public class BED_QuestNode_SpawnBossTrace : BED_QuestNode
{
	private static bool SpawnType_IsValid;

	private static int SpawnType_Offset;

	private static FFieldAddress SpawnType_PropertyAddress;

	private static bool TraceEfxPath_IsValid;

	private static int TraceEfxPath_Offset;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_SpawnBossTrace:SpawnType")]
	public ETraceSpawnType SpawnType
	{
		get
		{
			CheckDestroyed();
			if (!SpawnType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_SpawnBossTrace:SpawnType");
				return ETraceSpawnType.None;
			}
			return EnumMarshaler<ETraceSpawnType>.FromNative(IntPtr.Add(base.Address, SpawnType_Offset), 0, SpawnType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SpawnType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_SpawnBossTrace:SpawnType");
			}
			else
			{
				EnumMarshaler<ETraceSpawnType>.ToNative(IntPtr.Add(base.Address, SpawnType_Offset), 0, SpawnType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_SpawnBossTrace:TraceEfxPath")]
	public TSoftObject<BGWDataAsset_B1DBC> TraceEfxPath
	{
		get
		{
			CheckDestroyed();
			if (!TraceEfxPath_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_SpawnBossTrace:TraceEfxPath");
				return default(TSoftObject<BGWDataAsset_B1DBC>);
			}
			return TSoftObjectMarshaler<BGWDataAsset_B1DBC>.FromNative(IntPtr.Add(base.Address, TraceEfxPath_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TraceEfxPath_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_SpawnBossTrace:TraceEfxPath");
			}
			else
			{
				TSoftObjectMarshaler<BGWDataAsset_B1DBC>.ToNative(IntPtr.Add(base.Address, TraceEfxPath_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		SetNodeCategory("Notifies");
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.QuestNode.SpawnBossTrace;
	}

	public override byte[] GetCustomData()
	{
		return new QuestCustom_SpawnBossTrace
		{
			SpawnType = (int)SpawnType,
			TraceEfxPath = TraceEfxPath.AssetPathName
		}.ToByteArray();
	}

	[USharpPath("/Script/b1-Managed.BED_QuestNode_SpawnBossTrace:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		return "";
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_QuestNode_SpawnBossTrace:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_QuestNode_SpawnBossTrace bED_QuestNode_SpawnBossTrace = GCHelper.Find<BED_QuestNode_SpawnBossTrace>(obj);
		string nodeDescriptionInCS_Implementation = bED_QuestNode_SpawnBossTrace.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_QuestNode_SpawnBossTrace");
		NativeReflection.GetPropertyRef(ref SpawnType_PropertyAddress, intPtr, "SpawnType");
		SpawnType_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpawnType");
		SpawnType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpawnType", Classes.FEnumProperty);
		TraceEfxPath_Offset = NativeReflection.GetPropertyOffset(intPtr, "TraceEfxPath");
		TraceEfxPath_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TraceEfxPath", Classes.FSoftObjectProperty);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_QuestNode_SpawnBossTrace:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_QuestNode_SpawnBossTrace()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_QuestNode_SpawnBossTrace)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_QuestNode_SpawnBossTrace));
	}
}

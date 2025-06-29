using System;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("Save Archive")]
[Placeable(false)]
[USharpPath("/Script/b1-Managed.BED_QuestNode_SaveArchive")]
public class BED_QuestNode_SaveArchive : BED_QuestNode
{
	private static bool ArchiveLabel_IsValid;

	private static int ArchiveLabel_Offset;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[DisplayName("存档标记")]
	[Category("Archive")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_SaveArchive:ArchiveLabel")]
	public FName ArchiveLabel
	{
		get
		{
			CheckDestroyed();
			if (!ArchiveLabel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_SaveArchive:ArchiveLabel");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, ArchiveLabel_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ArchiveLabel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_SaveArchive:ArchiveLabel");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, ArchiveLabel_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		SetNodeCategory("Gameplay");
		SetNodeStyle(ECalliopeNodeStyle.Latent);
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.QuestNode.SaveArchive;
	}

	public override byte[] GetCustomData()
	{
		return new QuestCustom_SaveArchive
		{
			ArchiveLabel = ArchiveLabel.PlainName
		}.ToByteArray();
	}

	[USharpPath("/Script/b1-Managed.BED_QuestNode_SaveArchive:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		if (ArchiveLabel != FName.None)
		{
			return ArchiveLabel.PlainName;
		}
		return "";
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_QuestNode_SaveArchive:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_QuestNode_SaveArchive bED_QuestNode_SaveArchive = GCHelper.Find<BED_QuestNode_SaveArchive>(obj);
		string nodeDescriptionInCS_Implementation = bED_QuestNode_SaveArchive.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_QuestNode_SaveArchive");
		ArchiveLabel_Offset = NativeReflection.GetPropertyOffset(intPtr, "ArchiveLabel");
		ArchiveLabel_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ArchiveLabel", Classes.FNameProperty);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_QuestNode_SaveArchive:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_QuestNode_SaveArchive()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_QuestNode_SaveArchive)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_QuestNode_SaveArchive));
	}
}

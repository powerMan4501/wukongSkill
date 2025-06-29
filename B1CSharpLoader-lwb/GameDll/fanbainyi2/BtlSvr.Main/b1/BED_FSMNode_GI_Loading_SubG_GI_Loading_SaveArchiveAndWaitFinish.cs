using System;
using System.Text;
using b1.Plugins.Calliope;
using Google.Protobuf;
using GurCalliopeFsm;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[Placeable(true)]
[DisplayName("SubG_GI_Loading_SaveArchiveAndWaitFinish")]
[USharpPath("/Script/b1-Managed.BED_FSMNode_GI_Loading_SubG_GI_Loading_SaveArchiveAndWaitFinish")]
public class BED_FSMNode_GI_Loading_SubG_GI_Loading_SaveArchiveAndWaitFinish : BED_FSMNode_SubGraph
{
	private static bool ArchiveSaveSource_IsValid;

	private static int ArchiveSaveSource_Offset;

	private static FFieldAddress ArchiveSaveSource_PropertyAddress;

	private static bool OnCreateGraphNodeInCS_IsValid;

	private static IntPtr OnCreateGraphNodeInCS_FunctionAddress;

	private static int OnCreateGraphNodeInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[DisplayName("ArchiveSaveSource")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BED_FSMNode_GI_Loading_SubG_GI_Loading_SaveArchiveAndWaitFinish:ArchiveSaveSource")]
	private EArchiveSaveSource ArchiveSaveSource
	{
		get
		{
			CheckDestroyed();
			if (!ArchiveSaveSource_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_FSMNode_GI_Loading_SubG_GI_Loading_SaveArchiveAndWaitFinish:ArchiveSaveSource");
				return (EArchiveSaveSource)0;
			}
			return EnumMarshaler<EArchiveSaveSource>.FromNative(IntPtr.Add(base.Address, ArchiveSaveSource_Offset), 0, ArchiveSaveSource_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ArchiveSaveSource_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_FSMNode_GI_Loading_SubG_GI_Loading_SaveArchiveAndWaitFinish:ArchiveSaveSource");
			}
			else
			{
				EnumMarshaler<EArchiveSaveSource>.ToNative(IntPtr.Add(base.Address, ArchiveSaveSource_Offset), 0, ArchiveSaveSource_PropertyAddress.Address, value);
			}
		}
	}

	public override byte[] GetCustomData()
	{
		return new GI_Loading_SubG_GI_Loading_SaveArchiveAndWaitFinish
		{
			SubGraphAsset = base.SubGraphAsset.AssetPathName,
			ArchiveSaveSource = (int)ArchiveSaveSource
		}.ToByteArray();
	}

	[USharpPath("/Script/b1-Managed.BED_FSMNode_GI_Loading_SubG_GI_Loading_SaveArchiveAndWaitFinish:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("ArchiveSaveSource:" + UEnum.GetEnum<EArchiveSaveSource>().GetDisplayNameTextStringByIndex((int)ArchiveSaveSource));
		return stringBuilder.ToString();
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		FreshOutputPins();
		SetNodeCategory("GI_Loading SubGraph");
	}

	[USharpPath("/Script/b1-Managed.BED_FSMNode_GI_Loading_SubG_GI_Loading_SaveArchiveAndWaitFinish:OnCreateGraphNodeInCS")]
	protected override void OnCreateGraphNodeInCS_Implementation()
	{
		base.OnCreateGraphNodeInCS_Implementation();
		if (base.SubGraphAsset.IsNull && GetClass().ClassDefaultObject != this)
		{
			string name = GetClass().GetName();
			name = name.Substring(name.LastIndexOf("GI_Loading"));
			string text = "BED_FSMAsset'/Game/00Main/DataAsset/CFSMG/GI_Loading/CFSMG_" + name + ".CFSMG_" + name + "'";
			BED_FSMAsset bED_FSMAsset = UObject.LoadObject<BED_FSMAsset>(this, text);
			if (bED_FSMAsset != null)
			{
				base.SubGraphAsset = new TSoftObject<BED_FSMAsset>(bED_FSMAsset);
			}
			else
			{
				BGW_LogUtil.LogError("Asset is null, AssetPath = " + text);
			}
		}
	}

	private void FreshOutputPins()
	{
		base.OutputPins.Clear();
		if (TryOverrideOutputPins(out var OverrideOutputPins))
		{
			OverrideOutputPins.ForEach(delegate(FCalliopePin item)
			{
				base.OutputPins.Add(item);
			});
			return;
		}
		foreach (EGI_Loading_SubG_GI_Loading_SaveArchiveAndWaitFinish_Return value in Enum.GetValues(typeof(EGI_Loading_SubG_GI_Loading_SaveArchiveAndWaitFinish_Return)))
		{
			base.OutputPins.Add(new FCalliopePin
			{
				PinName = new FName(value.ToString())
			});
		}
	}

	public override void OnAssemblyReload()
	{
		base.OnAssemblyReload();
		FreshOutputPins();
		ExecuteOnReconstructionRequested();
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_FSMNode_GI_Loading_SubG_GI_Loading_SaveArchiveAndWaitFinish:OnCreateGraphNodeInCS")]
	private static void OnCreateGraphNodeInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_FSMNode_GI_Loading_SubG_GI_Loading_SaveArchiveAndWaitFinish bED_FSMNode_GI_Loading_SubG_GI_Loading_SaveArchiveAndWaitFinish = GCHelper.Find<BED_FSMNode_GI_Loading_SubG_GI_Loading_SaveArchiveAndWaitFinish>(obj);
		bED_FSMNode_GI_Loading_SubG_GI_Loading_SaveArchiveAndWaitFinish.OnCreateGraphNodeInCS_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_FSMNode_GI_Loading_SubG_GI_Loading_SaveArchiveAndWaitFinish:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_FSMNode_GI_Loading_SubG_GI_Loading_SaveArchiveAndWaitFinish bED_FSMNode_GI_Loading_SubG_GI_Loading_SaveArchiveAndWaitFinish = GCHelper.Find<BED_FSMNode_GI_Loading_SubG_GI_Loading_SaveArchiveAndWaitFinish>(obj);
		string nodeDescriptionInCS_Implementation = bED_FSMNode_GI_Loading_SubG_GI_Loading_SaveArchiveAndWaitFinish.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_FSMNode_GI_Loading_SubG_GI_Loading_SaveArchiveAndWaitFinish");
		NativeReflection.GetPropertyRef(ref ArchiveSaveSource_PropertyAddress, intPtr, "ArchiveSaveSource");
		ArchiveSaveSource_Offset = NativeReflection.GetPropertyOffset(intPtr, "ArchiveSaveSource");
		ArchiveSaveSource_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ArchiveSaveSource", Classes.FEnumProperty);
		OnCreateGraphNodeInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnCreateGraphNodeInCS");
		OnCreateGraphNodeInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnCreateGraphNodeInCS_FunctionAddress);
		OnCreateGraphNodeInCS_IsValid = OnCreateGraphNodeInCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_FSMNode_GI_Loading_SubG_GI_Loading_SaveArchiveAndWaitFinish:OnCreateGraphNodeInCS", OnCreateGraphNodeInCS_IsValid);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_FSMNode_GI_Loading_SubG_GI_Loading_SaveArchiveAndWaitFinish:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_FSMNode_GI_Loading_SubG_GI_Loading_SaveArchiveAndWaitFinish()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_FSMNode_GI_Loading_SubG_GI_Loading_SaveArchiveAndWaitFinish)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_FSMNode_GI_Loading_SubG_GI_Loading_SaveArchiveAndWaitFinish));
	}
}

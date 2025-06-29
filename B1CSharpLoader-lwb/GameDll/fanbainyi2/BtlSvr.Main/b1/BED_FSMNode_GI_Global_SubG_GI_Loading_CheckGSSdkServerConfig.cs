using System;
using System.Text;
using b1.Plugins.Calliope;
using Google.Protobuf;
using GurCalliopeFsm;
using UnrealEngine.Runtime;

namespace b1;

[Placeable(true)]
[UClass]
[DisplayName("SubG_GI_Loading_CheckGSSdkServerConfig")]
[USharpPath("/Script/b1-Managed.BED_FSMNode_GI_Global_SubG_GI_Loading_CheckGSSdkServerConfig")]
public class BED_FSMNode_GI_Global_SubG_GI_Loading_CheckGSSdkServerConfig : BED_FSMNode_SubGraph
{
	private static bool OnCreateGraphNodeInCS_IsValid;

	private static IntPtr OnCreateGraphNodeInCS_FunctionAddress;

	private static int OnCreateGraphNodeInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	public override byte[] GetCustomData()
	{
		return new GI_Global_SubG_GI_Loading_CheckGSSdkServerConfig
		{
			SubGraphAsset = base.SubGraphAsset.AssetPathName
		}.ToByteArray();
	}

	[USharpPath("/Script/b1-Managed.BED_FSMNode_GI_Global_SubG_GI_Loading_CheckGSSdkServerConfig:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		return new StringBuilder().ToString();
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		FreshOutputPins();
		SetNodeCategory("GI_Global SubGraph");
	}

	[USharpPath("/Script/b1-Managed.BED_FSMNode_GI_Global_SubG_GI_Loading_CheckGSSdkServerConfig:OnCreateGraphNodeInCS")]
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
		foreach (EGI_Global_SubG_GI_Loading_CheckGSSdkServerConfig_Return value in Enum.GetValues(typeof(EGI_Global_SubG_GI_Loading_CheckGSSdkServerConfig_Return)))
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

	[UFunctionInvoker("/Script/b1-Managed.BED_FSMNode_GI_Global_SubG_GI_Loading_CheckGSSdkServerConfig:OnCreateGraphNodeInCS")]
	private static void OnCreateGraphNodeInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_FSMNode_GI_Global_SubG_GI_Loading_CheckGSSdkServerConfig bED_FSMNode_GI_Global_SubG_GI_Loading_CheckGSSdkServerConfig = GCHelper.Find<BED_FSMNode_GI_Global_SubG_GI_Loading_CheckGSSdkServerConfig>(obj);
		bED_FSMNode_GI_Global_SubG_GI_Loading_CheckGSSdkServerConfig.OnCreateGraphNodeInCS_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_FSMNode_GI_Global_SubG_GI_Loading_CheckGSSdkServerConfig:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_FSMNode_GI_Global_SubG_GI_Loading_CheckGSSdkServerConfig bED_FSMNode_GI_Global_SubG_GI_Loading_CheckGSSdkServerConfig = GCHelper.Find<BED_FSMNode_GI_Global_SubG_GI_Loading_CheckGSSdkServerConfig>(obj);
		string nodeDescriptionInCS_Implementation = bED_FSMNode_GI_Global_SubG_GI_Loading_CheckGSSdkServerConfig.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BED_FSMNode_GI_Global_SubG_GI_Loading_CheckGSSdkServerConfig");
		OnCreateGraphNodeInCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnCreateGraphNodeInCS");
		OnCreateGraphNodeInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnCreateGraphNodeInCS_FunctionAddress);
		OnCreateGraphNodeInCS_IsValid = OnCreateGraphNodeInCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_FSMNode_GI_Global_SubG_GI_Loading_CheckGSSdkServerConfig:OnCreateGraphNodeInCS", OnCreateGraphNodeInCS_IsValid);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_FSMNode_GI_Global_SubG_GI_Loading_CheckGSSdkServerConfig:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_FSMNode_GI_Global_SubG_GI_Loading_CheckGSSdkServerConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_FSMNode_GI_Global_SubG_GI_Loading_CheckGSSdkServerConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_FSMNode_GI_Global_SubG_GI_Loading_CheckGSSdkServerConfig));
	}
}

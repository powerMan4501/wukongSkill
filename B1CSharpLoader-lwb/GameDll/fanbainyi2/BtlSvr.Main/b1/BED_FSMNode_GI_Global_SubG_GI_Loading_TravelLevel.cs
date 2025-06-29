using System;
using System.Collections.Generic;
using System.Text;
using b1.Plugins.Calliope;
using Google.Protobuf;
using GurCalliopeFsm;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("SubG_GI_Loading_TravelLevel")]
[UClass]
[Placeable(true)]
[USharpPath("/Script/b1-Managed.BED_FSMNode_GI_Global_SubG_GI_Loading_TravelLevel")]
public class BED_FSMNode_GI_Global_SubG_GI_Loading_TravelLevel : BED_FSMNode_SubGraph
{
	private static bool TravelLevelType_IsValid;

	private static int TravelLevelType_Offset;

	private static FFieldAddress TravelLevelType_PropertyAddress;

	private static bool TargetLevelNetType_IsValid;

	private static int TargetLevelNetType_Offset;

	private static FFieldAddress TargetLevelNetType_PropertyAddress;

	private static bool PostPropertyChanged_IsValid;

	private static IntPtr PostPropertyChanged_FunctionAddress;

	private static int PostPropertyChanged_ParamsSize;

	private static bool PostPropertyChanged_MemberName_IsValid;

	private static int PostPropertyChanged_MemberName_Offset;

	private static FFieldAddress PostPropertyChanged_MemberName_PropertyAddress;

	private static bool PostPropertyChanged_PropertyName_IsValid;

	private static int PostPropertyChanged_PropertyName_Offset;

	private static FFieldAddress PostPropertyChanged_PropertyName_PropertyAddress;

	private static bool OnCreateGraphNodeInCS_IsValid;

	private static IntPtr OnCreateGraphNodeInCS_FunctionAddress;

	private static int OnCreateGraphNodeInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[DisplayName("传送方式")]
	[USharpPath("/Script/b1-Managed.BED_FSMNode_GI_Global_SubG_GI_Loading_TravelLevel:TravelLevelType")]
	private EGlobalTravelLevelType TravelLevelType
	{
		get
		{
			CheckDestroyed();
			if (!TravelLevelType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_FSMNode_GI_Global_SubG_GI_Loading_TravelLevel:TravelLevelType");
				return EGlobalTravelLevelType.None;
			}
			return EnumMarshaler<EGlobalTravelLevelType>.FromNative(IntPtr.Add(base.Address, TravelLevelType_Offset), 0, TravelLevelType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!TravelLevelType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_FSMNode_GI_Global_SubG_GI_Loading_TravelLevel:TravelLevelType");
			}
			else
			{
				EnumMarshaler<EGlobalTravelLevelType>.ToNative(IntPtr.Add(base.Address, TravelLevelType_Offset), 0, TravelLevelType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[DisplayName("目标关卡网络模式")]
	[USharpPath("/Script/b1-Managed.BED_FSMNode_GI_Global_SubG_GI_Loading_TravelLevel:TargetLevelNetType")]
	private ETargetLevelNetType TargetLevelNetType
	{
		get
		{
			CheckDestroyed();
			if (!TargetLevelNetType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_FSMNode_GI_Global_SubG_GI_Loading_TravelLevel:TargetLevelNetType");
				return ETargetLevelNetType.MainMenu;
			}
			return EnumMarshaler<ETargetLevelNetType>.FromNative(IntPtr.Add(base.Address, TargetLevelNetType_Offset), 0, TargetLevelNetType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!TargetLevelNetType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_FSMNode_GI_Global_SubG_GI_Loading_TravelLevel:TargetLevelNetType");
			}
			else
			{
				EnumMarshaler<ETargetLevelNetType>.ToNative(IntPtr.Add(base.Address, TargetLevelNetType_Offset), 0, TargetLevelNetType_PropertyAddress.Address, value);
			}
		}
	}

	protected override bool TryOverrideOutputPins(out List<FCalliopePin> OverrideOutputPins)
	{
		OverrideOutputPins = new List<FCalliopePin>();
		foreach (EGI_Global_SubG_GI_Loading_TravelLevel_Return overrideReturn in GetOverrideReturns())
		{
			OverrideOutputPins.Add(new FCalliopePin
			{
				PinName = new FName(overrideReturn.ToString())
			});
		}
		return true;
	}

	private List<EGI_Global_SubG_GI_Loading_TravelLevel_Return> GetOverrideReturns()
	{
		if (TravelLevelType == EGlobalTravelLevelType.GameIntent)
		{
			return new List<EGI_Global_SubG_GI_Loading_TravelLevel_Return>
			{
				EGI_Global_SubG_GI_Loading_TravelLevel_Return.Finish,
				EGI_Global_SubG_GI_Loading_TravelLevel_Return.ReadArchiveFailed
			};
		}
		List<EGI_Global_SubG_GI_Loading_TravelLevel_Return> list = new List<EGI_Global_SubG_GI_Loading_TravelLevel_Return>();
		EGlobalTravelLevelType travelLevelType = TravelLevelType;
		if (travelLevelType == EGlobalTravelLevelType.StartNewGamePlus || travelLevelType == EGlobalTravelLevelType.ReadArchive)
		{
			list.Add(EGI_Global_SubG_GI_Loading_TravelLevel_Return.ReadArchiveFailed);
		}
		if (TargetLevelNetType == ETargetLevelNetType.Client)
		{
			list.Add(EGI_Global_SubG_GI_Loading_TravelLevel_Return.ClientDisconnect);
		}
		list.Add(EGI_Global_SubG_GI_Loading_TravelLevel_Return.Finish);
		return list;
	}

	[USharpPath("/Script/b1-Managed.BED_FSMNode_GI_Global_SubG_GI_Loading_TravelLevel:PostPropertyChanged")]
	protected override void PostPropertyChanged_Implementation(string MemberName, string PropertyName)
	{
		base.PostPropertyChanged_Implementation(MemberName, PropertyName);
		if (PropertyName.Equals("TargetLevelNetType"))
		{
			FreshOutputPins();
			ExecuteOnReconstructionRequested();
		}
	}

	public override byte[] GetCustomData()
	{
		return new GI_Global_SubG_GI_Loading_TravelLevel
		{
			SubGraphAsset = base.SubGraphAsset.AssetPathName,
			TravelLevelType = (int)TravelLevelType,
			TargetLevelNetType = (int)TargetLevelNetType
		}.ToByteArray();
	}

	[USharpPath("/Script/b1-Managed.BED_FSMNode_GI_Global_SubG_GI_Loading_TravelLevel:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("传送方式:" + UEnum.GetEnum<EGlobalTravelLevelType>().GetDisplayNameTextStringByIndex((int)TravelLevelType));
		stringBuilder.AppendLine();
		stringBuilder.Append("目标关卡网络模式:" + UEnum.GetEnum<ETargetLevelNetType>().GetDisplayNameTextStringByIndex((int)TargetLevelNetType));
		return stringBuilder.ToString();
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		FreshOutputPins();
		SetNodeCategory("GI_Global SubGraph");
	}

	[USharpPath("/Script/b1-Managed.BED_FSMNode_GI_Global_SubG_GI_Loading_TravelLevel:OnCreateGraphNodeInCS")]
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
		foreach (EGI_Global_SubG_GI_Loading_TravelLevel_Return value in Enum.GetValues(typeof(EGI_Global_SubG_GI_Loading_TravelLevel_Return)))
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

	[UFunctionInvoker("/Script/b1-Managed.BED_FSMNode_GI_Global_SubG_GI_Loading_TravelLevel:PostPropertyChanged")]
	private static void PostPropertyChanged__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_FSMNode_GI_Global_SubG_GI_Loading_TravelLevel bED_FSMNode_GI_Global_SubG_GI_Loading_TravelLevel = GCHelper.Find<BED_FSMNode_GI_Global_SubG_GI_Loading_TravelLevel>(obj);
		string memberName = FStringMarshaler.FromNative(IntPtr.Add(buffer, PostPropertyChanged_MemberName_Offset));
		string propertyName = FStringMarshaler.FromNative(IntPtr.Add(buffer, PostPropertyChanged_PropertyName_Offset));
		bED_FSMNode_GI_Global_SubG_GI_Loading_TravelLevel.PostPropertyChanged_Implementation(memberName, propertyName);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_FSMNode_GI_Global_SubG_GI_Loading_TravelLevel:OnCreateGraphNodeInCS")]
	private static void OnCreateGraphNodeInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_FSMNode_GI_Global_SubG_GI_Loading_TravelLevel bED_FSMNode_GI_Global_SubG_GI_Loading_TravelLevel = GCHelper.Find<BED_FSMNode_GI_Global_SubG_GI_Loading_TravelLevel>(obj);
		bED_FSMNode_GI_Global_SubG_GI_Loading_TravelLevel.OnCreateGraphNodeInCS_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_FSMNode_GI_Global_SubG_GI_Loading_TravelLevel:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_FSMNode_GI_Global_SubG_GI_Loading_TravelLevel bED_FSMNode_GI_Global_SubG_GI_Loading_TravelLevel = GCHelper.Find<BED_FSMNode_GI_Global_SubG_GI_Loading_TravelLevel>(obj);
		string nodeDescriptionInCS_Implementation = bED_FSMNode_GI_Global_SubG_GI_Loading_TravelLevel.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_FSMNode_GI_Global_SubG_GI_Loading_TravelLevel");
		NativeReflection.GetPropertyRef(ref TravelLevelType_PropertyAddress, intPtr, "TravelLevelType");
		TravelLevelType_Offset = NativeReflection.GetPropertyOffset(intPtr, "TravelLevelType");
		TravelLevelType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TravelLevelType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref TargetLevelNetType_PropertyAddress, intPtr, "TargetLevelNetType");
		TargetLevelNetType_Offset = NativeReflection.GetPropertyOffset(intPtr, "TargetLevelNetType");
		TargetLevelNetType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TargetLevelNetType", Classes.FEnumProperty);
		PostPropertyChanged_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PostPropertyChanged");
		PostPropertyChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(PostPropertyChanged_FunctionAddress);
		NativeReflection.GetPropertyRef(ref PostPropertyChanged_MemberName_PropertyAddress, PostPropertyChanged_FunctionAddress, "MemberName");
		PostPropertyChanged_MemberName_Offset = NativeReflection.GetPropertyOffset(PostPropertyChanged_FunctionAddress, "MemberName");
		PostPropertyChanged_MemberName_IsValid = NativeReflection.ValidatePropertyClass(PostPropertyChanged_FunctionAddress, "MemberName", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref PostPropertyChanged_PropertyName_PropertyAddress, PostPropertyChanged_FunctionAddress, "PropertyName");
		PostPropertyChanged_PropertyName_Offset = NativeReflection.GetPropertyOffset(PostPropertyChanged_FunctionAddress, "PropertyName");
		PostPropertyChanged_PropertyName_IsValid = NativeReflection.ValidatePropertyClass(PostPropertyChanged_FunctionAddress, "PropertyName", Classes.FStrProperty);
		PostPropertyChanged_IsValid = PostPropertyChanged_FunctionAddress != IntPtr.Zero && PostPropertyChanged_MemberName_IsValid && PostPropertyChanged_PropertyName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_FSMNode_GI_Global_SubG_GI_Loading_TravelLevel:PostPropertyChanged", PostPropertyChanged_IsValid);
		OnCreateGraphNodeInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnCreateGraphNodeInCS");
		OnCreateGraphNodeInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnCreateGraphNodeInCS_FunctionAddress);
		OnCreateGraphNodeInCS_IsValid = OnCreateGraphNodeInCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_FSMNode_GI_Global_SubG_GI_Loading_TravelLevel:OnCreateGraphNodeInCS", OnCreateGraphNodeInCS_IsValid);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_FSMNode_GI_Global_SubG_GI_Loading_TravelLevel:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_FSMNode_GI_Global_SubG_GI_Loading_TravelLevel()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_FSMNode_GI_Global_SubG_GI_Loading_TravelLevel)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_FSMNode_GI_Global_SubG_GI_Loading_TravelLevel));
	}
}

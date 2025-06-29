using System;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("Unit Teleport")]
[USharpPath("/Script/b1-Managed.BED_QuestNode_UnitTeleport")]
public class BED_QuestNode_UnitTeleport : BED_QuestNode
{
	private static bool Unit_IsValid;

	private static int Unit_Offset;

	private static bool SkillBeforeTeleport_IsValid;

	private static int SkillBeforeTeleport_Offset;

	private static bool SkillAfterTeleport_IsValid;

	private static int SkillAfterTeleport_Offset;

	private static bool LocationType_IsValid;

	private static int LocationType_Offset;

	private static FFieldAddress LocationType_PropertyAddress;

	private static bool RotationType_IsValid;

	private static int RotationType_Offset;

	private static bool NotifyUnit_IsValid;

	private static int NotifyUnit_Offset;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_UnitTeleport:Unit")]
	public FGsSmartParam Unit
	{
		get
		{
			CheckDestroyed();
			if (!Unit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_UnitTeleport:Unit");
				return default(FGsSmartParam);
			}
			return FGsSmartParam.FromNative(IntPtr.Add(base.Address, Unit_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Unit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_UnitTeleport:Unit");
			}
			else
			{
				FGsSmartParam.ToNative(IntPtr.Add(base.Address, Unit_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_UnitTeleport:SkillBeforeTeleport")]
	public int SkillBeforeTeleport
	{
		get
		{
			CheckDestroyed();
			if (!SkillBeforeTeleport_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_UnitTeleport:SkillBeforeTeleport");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, SkillBeforeTeleport_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SkillBeforeTeleport_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_UnitTeleport:SkillBeforeTeleport");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, SkillBeforeTeleport_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_UnitTeleport:SkillAfterTeleport")]
	public int SkillAfterTeleport
	{
		get
		{
			CheckDestroyed();
			if (!SkillAfterTeleport_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_UnitTeleport:SkillAfterTeleport");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, SkillAfterTeleport_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SkillAfterTeleport_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_UnitTeleport:SkillAfterTeleport");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, SkillAfterTeleport_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_UnitTeleport:LocationType")]
	public ETeleportLocationType LocationType
	{
		get
		{
			CheckDestroyed();
			if (!LocationType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_UnitTeleport:LocationType");
				return ETeleportLocationType.None;
			}
			return EnumMarshaler<ETeleportLocationType>.FromNative(IntPtr.Add(base.Address, LocationType_Offset), 0, LocationType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!LocationType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_UnitTeleport:LocationType");
			}
			else
			{
				EnumMarshaler<ETeleportLocationType>.ToNative(IntPtr.Add(base.Address, LocationType_Offset), 0, LocationType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_UnitTeleport:RotationType")]
	public int RotationType
	{
		get
		{
			CheckDestroyed();
			if (!RotationType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_UnitTeleport:RotationType");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, RotationType_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RotationType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_UnitTeleport:RotationType");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, RotationType_Offset), value);
			}
		}
	}

	[Category("Deprecated")]
	[VisibleAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_UnitTeleport:NotifyUnit")]
	public TSoftObject<BGUCharacterCS> NotifyUnit
	{
		get
		{
			CheckDestroyed();
			if (!NotifyUnit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_UnitTeleport:NotifyUnit");
				return default(TSoftObject<BGUCharacterCS>);
			}
			return TSoftObjectMarshaler<BGUCharacterCS>.FromNative(IntPtr.Add(base.Address, NotifyUnit_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NotifyUnit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_UnitTeleport:NotifyUnit");
			}
			else
			{
				TSoftObjectMarshaler<BGUCharacterCS>.ToNative(IntPtr.Add(base.Address, NotifyUnit_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		SetNodeCategory("Notifies");
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.QuestNode.UnitTeleport;
	}

	public override byte[] GetCustomData()
	{
		QuestCustom_UnitTeleport questCustom_UnitTeleport = new QuestCustom_UnitTeleport();
		GetAssetInCS().GetParameterActorGuidByConfigGuid(GameplayTagExtension.ConvertToCalliopeGuid(Unit.ConfigGuid), out var OutActorGuid);
		questCustom_UnitTeleport.NotifyActorGuid = OutActorGuid;
		questCustom_UnitTeleport.SkillAfterTeleport = SkillAfterTeleport;
		questCustom_UnitTeleport.SkillBeforeTeleport = SkillBeforeTeleport;
		questCustom_UnitTeleport.LocationType = (int)LocationType;
		questCustom_UnitTeleport.RotationType = RotationType;
		return questCustom_UnitTeleport.ToByteArray();
	}

	[USharpPath("/Script/b1-Managed.BED_QuestNode_UnitTeleport:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		return "";
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_QuestNode_UnitTeleport:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_QuestNode_UnitTeleport bED_QuestNode_UnitTeleport = GCHelper.Find<BED_QuestNode_UnitTeleport>(obj);
		string nodeDescriptionInCS_Implementation = bED_QuestNode_UnitTeleport.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_QuestNode_UnitTeleport");
		Unit_Offset = NativeReflection.GetPropertyOffset(intPtr, "Unit");
		Unit_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Unit", Classes.FStructProperty);
		SkillBeforeTeleport_Offset = NativeReflection.GetPropertyOffset(intPtr, "SkillBeforeTeleport");
		SkillBeforeTeleport_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SkillBeforeTeleport", Classes.FIntProperty);
		SkillAfterTeleport_Offset = NativeReflection.GetPropertyOffset(intPtr, "SkillAfterTeleport");
		SkillAfterTeleport_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SkillAfterTeleport", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref LocationType_PropertyAddress, intPtr, "LocationType");
		LocationType_Offset = NativeReflection.GetPropertyOffset(intPtr, "LocationType");
		LocationType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LocationType", Classes.FEnumProperty);
		RotationType_Offset = NativeReflection.GetPropertyOffset(intPtr, "RotationType");
		RotationType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RotationType", Classes.FIntProperty);
		NotifyUnit_Offset = NativeReflection.GetPropertyOffset(intPtr, "NotifyUnit");
		NotifyUnit_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NotifyUnit", Classes.FSoftObjectProperty);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_QuestNode_UnitTeleport:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_QuestNode_UnitTeleport()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_QuestNode_UnitTeleport)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_QuestNode_UnitTeleport));
	}
}

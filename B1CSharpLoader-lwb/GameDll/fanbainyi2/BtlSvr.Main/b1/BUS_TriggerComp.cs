using System;
using System.Collections.Generic;
using b1.ECS;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_TriggerComp")]
internal class BUS_TriggerComp : UActorEditCompBase
{
	private static bool TriggerType_IsValid;

	private static int TriggerType_Offset;

	private static FFieldAddress TriggerType_PropertyAddress;

	private static bool TriggerCharacter_IsValid;

	private static int TriggerCharacter_Offset;

	private static bool TriggerCharacterGuid_IsValid;

	private static int TriggerCharacterGuid_Offset;

	private static bool TriggerStateWhenTriggerCharacterInvalid_IsValid;

	private static int TriggerStateWhenTriggerCharacterInvalid_Offset;

	private static FFieldAddress TriggerStateWhenTriggerCharacterInvalid_PropertyAddress;

	private static bool bEnableSwitch_IsValid;

	private static int bEnableSwitch_Offset;

	private static FFieldAddress bEnableSwitch_PropertyAddress;

	private static bool CircleRaidus_IsValid;

	private static int CircleRaidus_Offset;

	private static bool bEndOverlapTrigger_IsValid;

	private static int bEndOverlapTrigger_Offset;

	private static FFieldAddress bEndOverlapTrigger_PropertyAddress;

	private static bool BeginEndOverlapTriggerDirectionType_IsValid;

	private static int BeginEndOverlapTriggerDirectionType_Offset;

	private static FFieldAddress BeginEndOverlapTriggerDirectionType_PropertyAddress;

	private static bool bCharacterActiveState_IsValid;

	private static int bCharacterActiveState_Offset;

	private static FFieldAddress bCharacterActiveState_PropertyAddress;

	private static bool bUnitState_IsValid;

	private static int bUnitState_Offset;

	private static FFieldAddress bUnitState_PropertyAddress;

	private static bool UnitState_IsValid;

	private static int UnitState_Offset;

	private static FFieldAddress UnitState_PropertyAddress;

	private static bool bSimpleState_IsValid;

	private static int bSimpleState_Offset;

	private static FFieldAddress bSimpleState_PropertyAddress;

	private static bool SimpleState_IsValid;

	private static int SimpleState_Offset;

	private static FFieldAddress SimpleState_PropertyAddress;

	private static bool AttrFloatType_IsValid;

	private static int AttrFloatType_Offset;

	private static FFieldAddress AttrFloatType_PropertyAddress;

	private static bool CompareType_IsValid;

	private static int CompareType_Offset;

	private static FFieldAddress CompareType_PropertyAddress;

	private static bool bCompareRatio_IsValid;

	private static int bCompareRatio_Offset;

	private static FFieldAddress bCompareRatio_PropertyAddress;

	private static bool CompareValue_IsValid;

	private static int CompareValue_Offset;

	[Category("Trigger Config | Common")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_TriggerComp:TriggerType")]
	public ETriggerType TriggerType
	{
		get
		{
			CheckDestroyed();
			if (!TriggerType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_TriggerComp:TriggerType");
				return ETriggerType.None;
			}
			return EnumMarshaler<ETriggerType>.FromNative(IntPtr.Add(base.Address, TriggerType_Offset), 0, TriggerType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!TriggerType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_TriggerComp:TriggerType");
			}
			else
			{
				EnumMarshaler<ETriggerType>.ToNative(IntPtr.Add(base.Address, TriggerType_Offset), 0, TriggerType_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Trigger Config | Common")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_TriggerComp:TriggerCharacter")]
	public ACharacter TriggerCharacter
	{
		get
		{
			CheckDestroyed();
			if (!TriggerCharacter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_TriggerComp:TriggerCharacter");
				return null;
			}
			return UObjectMarshaler<ACharacter>.FromNative(IntPtr.Add(base.Address, TriggerCharacter_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TriggerCharacter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_TriggerComp:TriggerCharacter");
			}
			else
			{
				UObjectMarshaler<ACharacter>.ToNative(IntPtr.Add(base.Address, TriggerCharacter_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Trigger Config | Common")]
	[USharpPath("/Script/b1-Managed.BUS_TriggerComp:TriggerCharacterGuid")]
	public string TriggerCharacterGuid
	{
		get
		{
			CheckDestroyed();
			if (!TriggerCharacterGuid_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_TriggerComp:TriggerCharacterGuid");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, TriggerCharacterGuid_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TriggerCharacterGuid_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_TriggerComp:TriggerCharacterGuid");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, TriggerCharacterGuid_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[Category("Trigger Config | Common")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_TriggerComp:TriggerStateWhenTriggerCharacterInvalid")]
	public bool TriggerStateWhenTriggerCharacterInvalid
	{
		get
		{
			CheckDestroyed();
			if (!TriggerStateWhenTriggerCharacterInvalid_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_TriggerComp:TriggerStateWhenTriggerCharacterInvalid");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, TriggerStateWhenTriggerCharacterInvalid_Offset), 0, TriggerStateWhenTriggerCharacterInvalid_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!TriggerStateWhenTriggerCharacterInvalid_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_TriggerComp:TriggerStateWhenTriggerCharacterInvalid");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, TriggerStateWhenTriggerCharacterInvalid_Offset), 0, TriggerStateWhenTriggerCharacterInvalid_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Trigger Config | Common")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_TriggerComp:bEnableSwitch")]
	public bool bEnableSwitch
	{
		get
		{
			CheckDestroyed();
			if (!bEnableSwitch_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_TriggerComp:bEnableSwitch");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bEnableSwitch_Offset), 0, bEnableSwitch_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bEnableSwitch_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_TriggerComp:bEnableSwitch");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bEnableSwitch_Offset), 0, bEnableSwitch_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[Category("Trigger Config | Circle Range Config")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_TriggerComp:CircleRaidus")]
	public float CircleRaidus
	{
		get
		{
			CheckDestroyed();
			if (!CircleRaidus_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_TriggerComp:CircleRaidus");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CircleRaidus_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CircleRaidus_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_TriggerComp:CircleRaidus");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CircleRaidus_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Trigger Config | Overlap Config")]
	[USharpPath("/Script/b1-Managed.BUS_TriggerComp:bEndOverlapTrigger")]
	public bool bEndOverlapTrigger
	{
		get
		{
			CheckDestroyed();
			if (!bEndOverlapTrigger_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_TriggerComp:bEndOverlapTrigger");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bEndOverlapTrigger_Offset), 0, bEndOverlapTrigger_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bEndOverlapTrigger_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_TriggerComp:bEndOverlapTrigger");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bEndOverlapTrigger_Offset), 0, bEndOverlapTrigger_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Trigger Config | Overlap Config")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_TriggerComp:BeginEndOverlapTriggerDirectionType")]
	public EBeginEndOverlapTriggerDirectionType BeginEndOverlapTriggerDirectionType
	{
		get
		{
			CheckDestroyed();
			if (!BeginEndOverlapTriggerDirectionType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_TriggerComp:BeginEndOverlapTriggerDirectionType");
				return EBeginEndOverlapTriggerDirectionType.None;
			}
			return EnumMarshaler<EBeginEndOverlapTriggerDirectionType>.FromNative(IntPtr.Add(base.Address, BeginEndOverlapTriggerDirectionType_Offset), 0, BeginEndOverlapTriggerDirectionType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!BeginEndOverlapTriggerDirectionType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_TriggerComp:BeginEndOverlapTriggerDirectionType");
			}
			else
			{
				EnumMarshaler<EBeginEndOverlapTriggerDirectionType>.ToNative(IntPtr.Add(base.Address, BeginEndOverlapTriggerDirectionType_Offset), 0, BeginEndOverlapTriggerDirectionType_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Trigger Config | Character State Config")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_TriggerComp:bCharacterActiveState")]
	public bool bCharacterActiveState
	{
		get
		{
			CheckDestroyed();
			if (!bCharacterActiveState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_TriggerComp:bCharacterActiveState");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bCharacterActiveState_Offset), 0, bCharacterActiveState_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bCharacterActiveState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_TriggerComp:bCharacterActiveState");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bCharacterActiveState_Offset), 0, bCharacterActiveState_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[Category("Trigger Config | Character State Config")]
	[USharpPath("/Script/b1-Managed.BUS_TriggerComp:bUnitState")]
	public bool bUnitState
	{
		get
		{
			CheckDestroyed();
			if (!bUnitState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_TriggerComp:bUnitState");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bUnitState_Offset), 0, bUnitState_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bUnitState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_TriggerComp:bUnitState");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bUnitState_Offset), 0, bUnitState_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[Category("Trigger Config | Character State Config")]
	[UMeta(MDProp.EditCondition, "bUnitState")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_TriggerComp:UnitState")]
	public EBGUUnitState UnitState
	{
		get
		{
			CheckDestroyed();
			if (!UnitState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_TriggerComp:UnitState");
				return EBGUUnitState.None;
			}
			return EnumMarshaler<EBGUUnitState>.FromNative(IntPtr.Add(base.Address, UnitState_Offset), 0, UnitState_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UnitState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_TriggerComp:UnitState");
			}
			else
			{
				EnumMarshaler<EBGUUnitState>.ToNative(IntPtr.Add(base.Address, UnitState_Offset), 0, UnitState_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Trigger Config | Character State Config")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_TriggerComp:bSimpleState")]
	public bool bSimpleState
	{
		get
		{
			CheckDestroyed();
			if (!bSimpleState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_TriggerComp:bSimpleState");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bSimpleState_Offset), 0, bSimpleState_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bSimpleState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_TriggerComp:bSimpleState");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bSimpleState_Offset), 0, bSimpleState_PropertyAddress.Address, value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "bSimpleState")]
	[Category("Trigger Config | Character State Config")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_TriggerComp:SimpleState")]
	public EBGUSimpleState SimpleState
	{
		get
		{
			CheckDestroyed();
			if (!SimpleState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_TriggerComp:SimpleState");
				return EBGUSimpleState.Normal;
			}
			return EnumMarshaler<EBGUSimpleState>.FromNative(IntPtr.Add(base.Address, SimpleState_Offset), 0, SimpleState_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SimpleState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_TriggerComp:SimpleState");
			}
			else
			{
				EnumMarshaler<EBGUSimpleState>.ToNative(IntPtr.Add(base.Address, SimpleState_Offset), 0, SimpleState_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Trigger Config | Character Attr Config")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_TriggerComp:AttrFloatType")]
	public EBGUAttrFloat AttrFloatType
	{
		get
		{
			CheckDestroyed();
			if (!AttrFloatType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_TriggerComp:AttrFloatType");
				return EBGUAttrFloat.None;
			}
			return EnumMarshaler<EBGUAttrFloat>.FromNative(IntPtr.Add(base.Address, AttrFloatType_Offset), 0, AttrFloatType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AttrFloatType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_TriggerComp:AttrFloatType");
			}
			else
			{
				EnumMarshaler<EBGUAttrFloat>.ToNative(IntPtr.Add(base.Address, AttrFloatType_Offset), 0, AttrFloatType_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[Category("Trigger Config | Character Attr Config")]
	[USharpPath("/Script/b1-Managed.BUS_TriggerComp:CompareType")]
	public EValueCompareType CompareType
	{
		get
		{
			CheckDestroyed();
			if (!CompareType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_TriggerComp:CompareType");
				return EValueCompareType.IsEqualTo;
			}
			return EnumMarshaler<EValueCompareType>.FromNative(IntPtr.Add(base.Address, CompareType_Offset), 0, CompareType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CompareType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_TriggerComp:CompareType");
			}
			else
			{
				EnumMarshaler<EValueCompareType>.ToNative(IntPtr.Add(base.Address, CompareType_Offset), 0, CompareType_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Trigger Config | Character Attr Config")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_TriggerComp:bCompareRatio")]
	public bool bCompareRatio
	{
		get
		{
			CheckDestroyed();
			if (!bCompareRatio_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_TriggerComp:bCompareRatio");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bCompareRatio_Offset), 0, bCompareRatio_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bCompareRatio_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_TriggerComp:bCompareRatio");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bCompareRatio_Offset), 0, bCompareRatio_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[Category("Trigger Config | Character Attr Config")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_TriggerComp:CompareValue")]
	public float CompareValue
	{
		get
		{
			CheckDestroyed();
			if (!CompareValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_TriggerComp:CompareValue");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CompareValue_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CompareValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_TriggerComp:CompareValue");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CompareValue_Offset), value);
			}
		}
	}

	public override void OnDataConvert(AActor Owner)
	{
		b1.BUC_TriggerData bUC_TriggerData = RequireWritableData<b1.BUC_TriggerData>();
		bUC_TriggerData.BeginOverlapDir = new Dictionary<Entity, FVector>();
		bUC_TriggerData.TriggerType = TriggerType;
		bUC_TriggerData.TriggerCharacter = TriggerCharacter;
		bUC_TriggerData.TriggerCharacterGuid = TriggerCharacterGuid;
		bUC_TriggerData.TriggerStateWhenTriggerCharacterInvalid = TriggerStateWhenTriggerCharacterInvalid;
		bUC_TriggerData.bEnableSwitch = bEnableSwitch;
		bUC_TriggerData.CircleRadius = CircleRaidus;
		bUC_TriggerData.bEndOverlapTrigger = bEndOverlapTrigger;
		bUC_TriggerData.BeginEndOverlapTriggerDirectionType = BeginEndOverlapTriggerDirectionType;
		bUC_TriggerData.bCharacterActiveState = bCharacterActiveState;
		bUC_TriggerData.bUnitState = bUnitState;
		bUC_TriggerData.UnitState = UnitState;
		bUC_TriggerData.bSimpleState = bSimpleState;
		bUC_TriggerData.SimpleState = SimpleState;
		bUC_TriggerData.AttrFloatType = AttrFloatType;
		bUC_TriggerData.CompareType = CompareType;
		bUC_TriggerData.bCompareRatio = bCompareRatio;
		bUC_TriggerData.CompareValue = CompareValue;
	}

	public void InitDebugCircleRange()
	{
		if (TriggerType == ETriggerType.CircleRangeCharacterDie)
		{
			UBGUDebugCircleComponent componentByClass = GetOwner().GetComponentByClass<UBGUDebugCircleComponent>();
			if (!(componentByClass == null))
			{
				float circleRadius = CircleRaidus / GetOwner().GetActorScale3D().X;
				componentByClass.SetCircleRadius(circleRadius);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_TriggerComp");
		NativeReflection.GetPropertyRef(ref TriggerType_PropertyAddress, unrealStruct, "TriggerType");
		TriggerType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TriggerType");
		TriggerType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TriggerType", Classes.FEnumProperty);
		TriggerCharacter_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TriggerCharacter");
		TriggerCharacter_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TriggerCharacter", Classes.FObjectProperty);
		TriggerCharacterGuid_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TriggerCharacterGuid");
		TriggerCharacterGuid_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TriggerCharacterGuid", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref TriggerStateWhenTriggerCharacterInvalid_PropertyAddress, unrealStruct, "TriggerStateWhenTriggerCharacterInvalid");
		TriggerStateWhenTriggerCharacterInvalid_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TriggerStateWhenTriggerCharacterInvalid");
		TriggerStateWhenTriggerCharacterInvalid_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TriggerStateWhenTriggerCharacterInvalid", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bEnableSwitch_PropertyAddress, unrealStruct, "bEnableSwitch");
		bEnableSwitch_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bEnableSwitch");
		bEnableSwitch_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bEnableSwitch", Classes.FBoolProperty);
		CircleRaidus_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CircleRaidus");
		CircleRaidus_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CircleRaidus", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref bEndOverlapTrigger_PropertyAddress, unrealStruct, "bEndOverlapTrigger");
		bEndOverlapTrigger_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bEndOverlapTrigger");
		bEndOverlapTrigger_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bEndOverlapTrigger", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref BeginEndOverlapTriggerDirectionType_PropertyAddress, unrealStruct, "BeginEndOverlapTriggerDirectionType");
		BeginEndOverlapTriggerDirectionType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BeginEndOverlapTriggerDirectionType");
		BeginEndOverlapTriggerDirectionType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BeginEndOverlapTriggerDirectionType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref bCharacterActiveState_PropertyAddress, unrealStruct, "bCharacterActiveState");
		bCharacterActiveState_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bCharacterActiveState");
		bCharacterActiveState_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bCharacterActiveState", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bUnitState_PropertyAddress, unrealStruct, "bUnitState");
		bUnitState_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bUnitState");
		bUnitState_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bUnitState", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref UnitState_PropertyAddress, unrealStruct, "UnitState");
		UnitState_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "UnitState");
		UnitState_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "UnitState", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref bSimpleState_PropertyAddress, unrealStruct, "bSimpleState");
		bSimpleState_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bSimpleState");
		bSimpleState_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bSimpleState", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref SimpleState_PropertyAddress, unrealStruct, "SimpleState");
		SimpleState_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SimpleState");
		SimpleState_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SimpleState", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref AttrFloatType_PropertyAddress, unrealStruct, "AttrFloatType");
		AttrFloatType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AttrFloatType");
		AttrFloatType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AttrFloatType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref CompareType_PropertyAddress, unrealStruct, "CompareType");
		CompareType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CompareType");
		CompareType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CompareType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref bCompareRatio_PropertyAddress, unrealStruct, "bCompareRatio");
		bCompareRatio_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bCompareRatio");
		bCompareRatio_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bCompareRatio", Classes.FBoolProperty);
		CompareValue_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CompareValue");
		CompareValue_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CompareValue", Classes.FFloatProperty);
	}

	static BUS_TriggerComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BUS_TriggerComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BUS_TriggerComp));
	}
}

using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 268293)]
[BlueprintType]
[UMetaPath("/Script/Engine.AnimNotifyEvent", "Engine", UnrealModuleType.Engine)]
public class FAnimNotifyEvent : StructAsClass
{
	private static bool LinkedMontage_IsValid;

	private static int LinkedMontage_Offset;

	private static bool SlotIndex_IsValid;

	private static int SlotIndex_Offset;

	private static bool SegmentIndex_IsValid;

	private static int SegmentIndex_Offset;

	private static bool LinkMethod_IsValid;

	private static FFieldAddress LinkMethod_PropertyAddress;

	private static int LinkMethod_Offset;

	private static bool CachedLinkMethod_IsValid;

	private static FFieldAddress CachedLinkMethod_PropertyAddress;

	private static int CachedLinkMethod_Offset;

	private static bool SegmentBeginTime_IsValid;

	private static int SegmentBeginTime_Offset;

	private static bool SegmentLength_IsValid;

	private static int SegmentLength_Offset;

	private static bool LinkValue_IsValid;

	private static int LinkValue_Offset;

	private static bool LinkedSequence_IsValid;

	private static int LinkedSequence_Offset;

	private static bool TriggerTimeOffset_IsValid;

	private static int TriggerTimeOffset_Offset;

	private static bool EndTriggerTimeOffset_IsValid;

	private static int EndTriggerTimeOffset_Offset;

	private static bool TriggerWeightThreshold_IsValid;

	private static int TriggerWeightThreshold_Offset;

	private static bool NotifyName_IsValid;

	private static int NotifyName_Offset;

	private static bool Notify_IsValid;

	private static int Notify_Offset;

	private static bool NotifyStateClass_IsValid;

	private static int NotifyStateClass_Offset;

	private static bool Duration_IsValid;

	private static int Duration_Offset;

	private static bool EndLink_IsValid;

	private static int EndLink_Offset;

	private static bool ConvertedFromBranchingPoint_IsValid;

	private static FFieldAddress ConvertedFromBranchingPoint_PropertyAddress;

	private static int ConvertedFromBranchingPoint_Offset;

	private static bool MontageTickType_IsValid;

	private static FFieldAddress MontageTickType_PropertyAddress;

	private static int MontageTickType_Offset;

	private static bool NotifyTriggerChance_IsValid;

	private static int NotifyTriggerChance_Offset;

	private static bool NotifyFilterType_IsValid;

	private static FFieldAddress NotifyFilterType_PropertyAddress;

	private static int NotifyFilterType_Offset;

	private static bool NotifyFilterLOD_IsValid;

	private static int NotifyFilterLOD_Offset;

	private static bool TriggerOnDedicatedServer_IsValid;

	private static FFieldAddress TriggerOnDedicatedServer_PropertyAddress;

	private static int TriggerOnDedicatedServer_Offset;

	private static bool TriggerOnFollower_IsValid;

	private static FFieldAddress TriggerOnFollower_PropertyAddress;

	private static int TriggerOnFollower_Offset;

	private static bool NotifyColor_IsValid;

	private static int NotifyColor_Offset;

	private static bool Guid_IsValid;

	private static int Guid_Offset;

	private static bool TrackIndex_IsValid;

	private static int TrackIndex_Offset;

	private static bool FAnimNotifyEvent_IsValid;

	private static IntPtr FAnimNotifyEvent_StructAddress;

	[UProperty(Flags = (PropFlags)12393764861510144uL)]
	[UMetaPath("/Script/Engine.AnimLinkableElement:LinkedMontage")]
	public UAnimMontage LinkedMontage
	{
		get
		{
			CheckDestroyed();
			if (!LinkedMontage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimLinkableElement:LinkedMontage");
				return null;
			}
			return UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(base.Address, LinkedMontage_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LinkedMontage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimLinkableElement:LinkedMontage");
			}
			else
			{
				UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(base.Address, LinkedMontage_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667521uL)]
	[UMetaPath("/Script/Engine.AnimLinkableElement:SlotIndex")]
	public int SlotIndex
	{
		get
		{
			CheckDestroyed();
			if (!SlotIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimLinkableElement:SlotIndex");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, SlotIndex_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SlotIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimLinkableElement:SlotIndex");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, SlotIndex_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667520uL)]
	[UMetaPath("/Script/Engine.AnimLinkableElement:SegmentIndex")]
	public int SegmentIndex
	{
		get
		{
			CheckDestroyed();
			if (!SegmentIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimLinkableElement:SegmentIndex");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, SegmentIndex_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SegmentIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimLinkableElement:SegmentIndex");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, SegmentIndex_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667521uL)]
	[UMetaPath("/Script/Engine.AnimLinkableElement:LinkMethod")]
	public EAnimLinkMethod LinkMethod
	{
		get
		{
			CheckDestroyed();
			if (!LinkMethod_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimLinkableElement:LinkMethod");
				return EAnimLinkMethod.Absolute;
			}
			return EnumMarshaler<EAnimLinkMethod>.FromNative(IntPtr.Add(base.Address, LinkMethod_Offset), 0, LinkMethod_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!LinkMethod_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimLinkableElement:LinkMethod");
			}
			else
			{
				EnumMarshaler<EAnimLinkMethod>.ToNative(IntPtr.Add(base.Address, LinkMethod_Offset), 0, LinkMethod_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667520uL)]
	[UMetaPath("/Script/Engine.AnimLinkableElement:CachedLinkMethod")]
	public EAnimLinkMethod CachedLinkMethod
	{
		get
		{
			CheckDestroyed();
			if (!CachedLinkMethod_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimLinkableElement:CachedLinkMethod");
				return EAnimLinkMethod.Absolute;
			}
			return EnumMarshaler<EAnimLinkMethod>.FromNative(IntPtr.Add(base.Address, CachedLinkMethod_Offset), 0, CachedLinkMethod_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CachedLinkMethod_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimLinkableElement:CachedLinkMethod");
			}
			else
			{
				EnumMarshaler<EAnimLinkMethod>.ToNative(IntPtr.Add(base.Address, CachedLinkMethod_Offset), 0, CachedLinkMethod_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667520uL)]
	[UMetaPath("/Script/Engine.AnimLinkableElement:SegmentBeginTime")]
	public float SegmentBeginTime
	{
		get
		{
			CheckDestroyed();
			if (!SegmentBeginTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimLinkableElement:SegmentBeginTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SegmentBeginTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SegmentBeginTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimLinkableElement:SegmentBeginTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SegmentBeginTime_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667520uL)]
	[UMetaPath("/Script/Engine.AnimLinkableElement:SegmentLength")]
	public float SegmentLength
	{
		get
		{
			CheckDestroyed();
			if (!SegmentLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimLinkableElement:SegmentLength");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SegmentLength_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SegmentLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimLinkableElement:SegmentLength");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SegmentLength_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667520uL)]
	[UMetaPath("/Script/Engine.AnimLinkableElement:LinkValue")]
	public float LinkValue
	{
		get
		{
			CheckDestroyed();
			if (!LinkValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimLinkableElement:LinkValue");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LinkValue_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LinkValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimLinkableElement:LinkValue");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LinkValue_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)12398162908152321uL)]
	[UMetaPath("/Script/Engine.AnimLinkableElement:LinkedSequence")]
	public UAnimSequenceBase LinkedSequence
	{
		get
		{
			CheckDestroyed();
			if (!LinkedSequence_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimLinkableElement:LinkedSequence");
				return null;
			}
			return UObjectMarshaler<UAnimSequenceBase>.FromNative(IntPtr.Add(base.Address, LinkedSequence_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LinkedSequence_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimLinkableElement:LinkedSequence");
			}
			else
			{
				UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(base.Address, LinkedSequence_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274816uL)]
	[UMetaPath("/Script/Engine.AnimNotifyEvent:TriggerTimeOffset")]
	public float TriggerTimeOffset
	{
		get
		{
			CheckDestroyed();
			if (!TriggerTimeOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimNotifyEvent:TriggerTimeOffset");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, TriggerTimeOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TriggerTimeOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimNotifyEvent:TriggerTimeOffset");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, TriggerTimeOffset_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274816uL)]
	[UMetaPath("/Script/Engine.AnimNotifyEvent:EndTriggerTimeOffset")]
	public float EndTriggerTimeOffset
	{
		get
		{
			CheckDestroyed();
			if (!EndTriggerTimeOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimNotifyEvent:EndTriggerTimeOffset");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, EndTriggerTimeOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EndTriggerTimeOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimNotifyEvent:EndTriggerTimeOffset");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, EndTriggerTimeOffset_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.AnimNotifyEvent:TriggerWeightThreshold")]
	public float TriggerWeightThreshold
	{
		get
		{
			CheckDestroyed();
			if (!TriggerWeightThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimNotifyEvent:TriggerWeightThreshold");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, TriggerWeightThreshold_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TriggerWeightThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimNotifyEvent:TriggerWeightThreshold");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, TriggerWeightThreshold_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.AnimNotifyEvent:NotifyName")]
	public FName NotifyName
	{
		get
		{
			CheckDestroyed();
			if (!NotifyName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimNotifyEvent:NotifyName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, NotifyName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NotifyName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimNotifyEvent:NotifyName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, NotifyName_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)8444319095063053uL)]
	[UMetaPath("/Script/Engine.AnimNotifyEvent:Notify")]
	public UAnimNotify Notify
	{
		get
		{
			CheckDestroyed();
			if (!Notify_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimNotifyEvent:Notify");
				return null;
			}
			return UObjectMarshaler<UAnimNotify>.FromNative(IntPtr.Add(base.Address, Notify_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Notify_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimNotifyEvent:Notify");
			}
			else
			{
				UObjectMarshaler<UAnimNotify>.ToNative(IntPtr.Add(base.Address, Notify_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)8444319095063053uL)]
	[UMetaPath("/Script/Engine.AnimNotifyEvent:NotifyStateClass")]
	public UAnimNotifyState NotifyStateClass
	{
		get
		{
			CheckDestroyed();
			if (!NotifyStateClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimNotifyEvent:NotifyStateClass");
				return null;
			}
			return UObjectMarshaler<UAnimNotifyState>.FromNative(IntPtr.Add(base.Address, NotifyStateClass_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NotifyStateClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimNotifyEvent:NotifyStateClass");
			}
			else
			{
				UObjectMarshaler<UAnimNotifyState>.ToNative(IntPtr.Add(base.Address, NotifyStateClass_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274816uL)]
	[UMetaPath("/Script/Engine.AnimNotifyEvent:Duration")]
	public float Duration
	{
		get
		{
			CheckDestroyed();
			if (!Duration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimNotifyEvent:Duration");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Duration_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Duration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimNotifyEvent:Duration");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Duration_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370496uL)]
	[UMetaPath("/Script/Engine.AnimNotifyEvent:EndLink")]
	public FAnimLinkableElement EndLink
	{
		get
		{
			CheckDestroyed();
			if (!EndLink_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimNotifyEvent:EndLink");
				return default(FAnimLinkableElement);
			}
			return FAnimLinkableElement.FromNative(IntPtr.Add(base.Address, EndLink_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EndLink_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimNotifyEvent:EndLink");
			}
			else
			{
				FAnimLinkableElement.ToNative(IntPtr.Add(base.Address, EndLink_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274816uL)]
	[UMetaPath("/Script/Engine.AnimNotifyEvent:bConvertedFromBranchingPoint")]
	public bool ConvertedFromBranchingPoint
	{
		get
		{
			CheckDestroyed();
			if (!ConvertedFromBranchingPoint_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimNotifyEvent:bConvertedFromBranchingPoint");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ConvertedFromBranchingPoint_Offset), 0, ConvertedFromBranchingPoint_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ConvertedFromBranchingPoint_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimNotifyEvent:bConvertedFromBranchingPoint");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ConvertedFromBranchingPoint_Offset), 0, ConvertedFromBranchingPoint_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.AnimNotifyEvent:MontageTickType")]
	public EMontageNotifyTickType MontageTickType
	{
		get
		{
			CheckDestroyed();
			if (!MontageTickType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimNotifyEvent:MontageTickType");
				return EMontageNotifyTickType.Queued;
			}
			return EnumMarshaler<EMontageNotifyTickType>.FromNative(IntPtr.Add(base.Address, MontageTickType_Offset), 0, MontageTickType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MontageTickType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimNotifyEvent:MontageTickType");
			}
			else
			{
				EnumMarshaler<EMontageNotifyTickType>.ToNative(IntPtr.Add(base.Address, MontageTickType_Offset), 0, MontageTickType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.AnimNotifyEvent:NotifyTriggerChance")]
	public float NotifyTriggerChance
	{
		get
		{
			CheckDestroyed();
			if (!NotifyTriggerChance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimNotifyEvent:NotifyTriggerChance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, NotifyTriggerChance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NotifyTriggerChance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimNotifyEvent:NotifyTriggerChance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, NotifyTriggerChance_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.AnimNotifyEvent:NotifyFilterType")]
	public ENotifyFilterType NotifyFilterType
	{
		get
		{
			CheckDestroyed();
			if (!NotifyFilterType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimNotifyEvent:NotifyFilterType");
				return ENotifyFilterType.NoFiltering;
			}
			return EnumMarshaler<ENotifyFilterType>.FromNative(IntPtr.Add(base.Address, NotifyFilterType_Offset), 0, NotifyFilterType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!NotifyFilterType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimNotifyEvent:NotifyFilterType");
			}
			else
			{
				EnumMarshaler<ENotifyFilterType>.ToNative(IntPtr.Add(base.Address, NotifyFilterType_Offset), 0, NotifyFilterType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.AnimNotifyEvent:NotifyFilterLOD")]
	public int NotifyFilterLOD
	{
		get
		{
			CheckDestroyed();
			if (!NotifyFilterLOD_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimNotifyEvent:NotifyFilterLOD");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, NotifyFilterLOD_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NotifyFilterLOD_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimNotifyEvent:NotifyFilterLOD");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, NotifyFilterLOD_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.AnimNotifyEvent:bTriggerOnDedicatedServer")]
	public bool TriggerOnDedicatedServer
	{
		get
		{
			CheckDestroyed();
			if (!TriggerOnDedicatedServer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimNotifyEvent:bTriggerOnDedicatedServer");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, TriggerOnDedicatedServer_Offset), 0, TriggerOnDedicatedServer_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!TriggerOnDedicatedServer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimNotifyEvent:bTriggerOnDedicatedServer");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, TriggerOnDedicatedServer_Offset), 0, TriggerOnDedicatedServer_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.AnimNotifyEvent:bTriggerOnFollower")]
	public bool TriggerOnFollower
	{
		get
		{
			CheckDestroyed();
			if (!TriggerOnFollower_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimNotifyEvent:bTriggerOnFollower");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, TriggerOnFollower_Offset), 0, TriggerOnFollower_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!TriggerOnFollower_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimNotifyEvent:bTriggerOnFollower");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, TriggerOnFollower_Offset), 0, TriggerOnFollower_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755503594013184uL)]
	[UMetaPath("/Script/Engine.AnimNotifyEvent:NotifyColor")]
	public FColor NotifyColor
	{
		get
		{
			CheckDestroyed();
			if (!NotifyColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimNotifyEvent:NotifyColor");
				return default(FColor);
			}
			return BlittableTypeMarshaler<FColor>.FromNative(IntPtr.Add(base.Address, NotifyColor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NotifyColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimNotifyEvent:NotifyColor");
			}
			else
			{
				BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(base.Address, NotifyColor_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755503594013184uL)]
	[UMetaPath("/Script/Engine.AnimNotifyEvent:Guid")]
	public Guid Guid
	{
		get
		{
			CheckDestroyed();
			if (!Guid_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimNotifyEvent:Guid");
				return default(Guid);
			}
			return BlittableTypeMarshaler<Guid>.FromNative(IntPtr.Add(base.Address, Guid_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Guid_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimNotifyEvent:Guid");
			}
			else
			{
				BlittableTypeMarshaler<Guid>.ToNative(IntPtr.Add(base.Address, Guid_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274816uL)]
	[UMetaPath("/Script/Engine.AnimNotifyEvent:TrackIndex")]
	public int TrackIndex
	{
		get
		{
			CheckDestroyed();
			if (!TrackIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimNotifyEvent:TrackIndex");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, TrackIndex_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TrackIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimNotifyEvent:TrackIndex");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, TrackIndex_Offset), value);
			}
		}
	}

	protected override IntPtr GetStructAddress()
	{
		return FAnimNotifyEvent_StructAddress;
	}

	static FAnimNotifyEvent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnimNotifyEvent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimNotifyEvent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = (FAnimNotifyEvent_StructAddress = NativeReflection.GetStruct("/Script/Engine.AnimNotifyEvent"));
		LinkedMontage_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LinkedMontage");
		LinkedMontage_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LinkedMontage", Classes.FObjectProperty);
		SlotIndex_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SlotIndex");
		SlotIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SlotIndex", Classes.FIntProperty);
		SegmentIndex_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SegmentIndex");
		SegmentIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SegmentIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref LinkMethod_PropertyAddress, intPtr, "LinkMethod");
		LinkMethod_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LinkMethod");
		LinkMethod_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LinkMethod", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref CachedLinkMethod_PropertyAddress, intPtr, "CachedLinkMethod");
		CachedLinkMethod_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CachedLinkMethod");
		CachedLinkMethod_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CachedLinkMethod", Classes.FByteProperty);
		SegmentBeginTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SegmentBeginTime");
		SegmentBeginTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SegmentBeginTime", Classes.FFloatProperty);
		SegmentLength_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SegmentLength");
		SegmentLength_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SegmentLength", Classes.FFloatProperty);
		LinkValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LinkValue");
		LinkValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LinkValue", Classes.FFloatProperty);
		LinkedSequence_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LinkedSequence");
		LinkedSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LinkedSequence", Classes.FObjectProperty);
		TriggerTimeOffset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TriggerTimeOffset");
		TriggerTimeOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TriggerTimeOffset", Classes.FFloatProperty);
		EndTriggerTimeOffset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "EndTriggerTimeOffset");
		EndTriggerTimeOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "EndTriggerTimeOffset", Classes.FFloatProperty);
		TriggerWeightThreshold_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TriggerWeightThreshold");
		TriggerWeightThreshold_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TriggerWeightThreshold", Classes.FFloatProperty);
		NotifyName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NotifyName");
		NotifyName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NotifyName", Classes.FNameProperty);
		Notify_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Notify");
		Notify_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Notify", Classes.FObjectProperty);
		NotifyStateClass_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NotifyStateClass");
		NotifyStateClass_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NotifyStateClass", Classes.FObjectProperty);
		Duration_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Duration");
		Duration_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Duration", Classes.FFloatProperty);
		EndLink_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "EndLink");
		EndLink_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "EndLink", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertedFromBranchingPoint_PropertyAddress, intPtr, "bConvertedFromBranchingPoint");
		ConvertedFromBranchingPoint_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bConvertedFromBranchingPoint");
		ConvertedFromBranchingPoint_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bConvertedFromBranchingPoint", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref MontageTickType_PropertyAddress, intPtr, "MontageTickType");
		MontageTickType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MontageTickType");
		MontageTickType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MontageTickType", Classes.FByteProperty);
		NotifyTriggerChance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NotifyTriggerChance");
		NotifyTriggerChance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NotifyTriggerChance", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref NotifyFilterType_PropertyAddress, intPtr, "NotifyFilterType");
		NotifyFilterType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NotifyFilterType");
		NotifyFilterType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NotifyFilterType", Classes.FByteProperty);
		NotifyFilterLOD_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NotifyFilterLOD");
		NotifyFilterLOD_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NotifyFilterLOD", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref TriggerOnDedicatedServer_PropertyAddress, intPtr, "bTriggerOnDedicatedServer");
		TriggerOnDedicatedServer_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bTriggerOnDedicatedServer");
		TriggerOnDedicatedServer_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bTriggerOnDedicatedServer", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref TriggerOnFollower_PropertyAddress, intPtr, "bTriggerOnFollower");
		TriggerOnFollower_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bTriggerOnFollower");
		TriggerOnFollower_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bTriggerOnFollower", Classes.FBoolProperty);
		NotifyColor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NotifyColor");
		NotifyColor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NotifyColor", Classes.FStructProperty);
		Guid_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Guid");
		Guid_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Guid", Classes.FStructProperty);
		TrackIndex_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TrackIndex");
		TrackIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TrackIndex", Classes.FIntProperty);
		FAnimNotifyEvent_IsValid = intPtr != IntPtr.Zero && TriggerTimeOffset_IsValid && EndTriggerTimeOffset_IsValid && TriggerWeightThreshold_IsValid && NotifyName_IsValid && Notify_IsValid && NotifyStateClass_IsValid && Duration_IsValid && EndLink_IsValid && ConvertedFromBranchingPoint_IsValid && MontageTickType_IsValid && NotifyTriggerChance_IsValid && NotifyFilterType_IsValid && NotifyFilterLOD_IsValid && TriggerOnDedicatedServer_IsValid && TriggerOnFollower_IsValid && NotifyColor_IsValid && Guid_IsValid && TrackIndex_IsValid && LinkedMontage_IsValid && SlotIndex_IsValid && SegmentIndex_IsValid && LinkMethod_IsValid && CachedLinkMethod_IsValid && SegmentBeginTime_IsValid && SegmentLength_IsValid && LinkValue_IsValid && LinkedSequence_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.AnimNotifyEvent", FAnimNotifyEvent_IsValid);
	}
}

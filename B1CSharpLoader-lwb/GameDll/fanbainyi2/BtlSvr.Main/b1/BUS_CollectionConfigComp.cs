using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_CollectionConfigComp")]
public class BUS_CollectionConfigComp : UActorEditCompBase
{
	private static bool CollectionDropID_IsValid;

	private static int CollectionDropID_Offset;

	private static bool GroupID_IsValid;

	private static int GroupID_Offset;

	private static bool UnitClass_IsValid;

	private static int UnitClass_Offset;

	private static bool PlusUnitClass_IsValid;

	private static int PlusUnitClass_Offset;

	private static bool ChiefUnitClass_IsValid;

	private static int ChiefUnitClass_Offset;

	private static bool OverWriterEventId_IsValid;

	private static int OverWriterEventId_Offset;

	private static FFieldAddress OverWriterEventId_PropertyAddress;

	private static bool EventId_IsValid;

	private static int EventId_Offset;

	private static bool PlusEventId_IsValid;

	private static int PlusEventId_Offset;

	private static bool ChiefEventId_IsValid;

	private static int ChiefEventId_Offset;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[Category("CollectionConfig")]
	[USharpPath("/Script/b1-Managed.BUS_CollectionConfigComp:CollectionDropID")]
	public int CollectionDropID
	{
		get
		{
			CheckDestroyed();
			if (!CollectionDropID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_CollectionConfigComp:CollectionDropID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, CollectionDropID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CollectionDropID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_CollectionConfigComp:CollectionDropID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, CollectionDropID_Offset), value);
			}
		}
	}

	[Category("CollectionConfig")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_CollectionConfigComp:GroupID")]
	public int GroupID
	{
		get
		{
			CheckDestroyed();
			if (!GroupID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_CollectionConfigComp:GroupID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, GroupID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GroupID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_CollectionConfigComp:GroupID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, GroupID_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[Category("CollectionConfig")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUS_CollectionConfigComp:UnitClass")]
	public TSubclassOf<AActor> UnitClass
	{
		get
		{
			CheckDestroyed();
			if (!UnitClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_CollectionConfigComp:UnitClass");
				return default(TSubclassOf<AActor>);
			}
			return TSubclassOfMarshaler<AActor>.FromNative(IntPtr.Add(base.Address, UnitClass_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UnitClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_CollectionConfigComp:UnitClass");
			}
			else
			{
				TSubclassOfMarshaler<AActor>.ToNative(IntPtr.Add(base.Address, UnitClass_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[Category("CollectionConfig")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_CollectionConfigComp:PlusUnitClass")]
	public TSubclassOf<AActor> PlusUnitClass
	{
		get
		{
			CheckDestroyed();
			if (!PlusUnitClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_CollectionConfigComp:PlusUnitClass");
				return default(TSubclassOf<AActor>);
			}
			return TSubclassOfMarshaler<AActor>.FromNative(IntPtr.Add(base.Address, PlusUnitClass_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PlusUnitClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_CollectionConfigComp:PlusUnitClass");
			}
			else
			{
				TSubclassOfMarshaler<AActor>.ToNative(IntPtr.Add(base.Address, PlusUnitClass_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("CollectionConfig")]
	[USharpPath("/Script/b1-Managed.BUS_CollectionConfigComp:ChiefUnitClass")]
	public TSubclassOf<AActor> ChiefUnitClass
	{
		get
		{
			CheckDestroyed();
			if (!ChiefUnitClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_CollectionConfigComp:ChiefUnitClass");
				return default(TSubclassOf<AActor>);
			}
			return TSubclassOfMarshaler<AActor>.FromNative(IntPtr.Add(base.Address, ChiefUnitClass_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ChiefUnitClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_CollectionConfigComp:ChiefUnitClass");
			}
			else
			{
				TSubclassOfMarshaler<AActor>.ToNative(IntPtr.Add(base.Address, ChiefUnitClass_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("CollectionConfig")]
	[USharpPath("/Script/b1-Managed.BUS_CollectionConfigComp:OverWriterEventId")]
	public bool OverWriterEventId
	{
		get
		{
			CheckDestroyed();
			if (!OverWriterEventId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_CollectionConfigComp:OverWriterEventId");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, OverWriterEventId_Offset), 0, OverWriterEventId_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!OverWriterEventId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_CollectionConfigComp:OverWriterEventId");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, OverWriterEventId_Offset), 0, OverWriterEventId_PropertyAddress.Address, value);
			}
		}
	}

	[Category("CollectionConfig")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_CollectionConfigComp:EventId")]
	public int EventId
	{
		get
		{
			CheckDestroyed();
			if (!EventId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_CollectionConfigComp:EventId");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, EventId_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EventId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_CollectionConfigComp:EventId");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, EventId_Offset), value);
			}
		}
	}

	[Category("CollectionConfig")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_CollectionConfigComp:PlusEventId")]
	public int PlusEventId
	{
		get
		{
			CheckDestroyed();
			if (!PlusEventId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_CollectionConfigComp:PlusEventId");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, PlusEventId_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PlusEventId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_CollectionConfigComp:PlusEventId");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, PlusEventId_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Category("CollectionConfig")]
	[USharpPath("/Script/b1-Managed.BUS_CollectionConfigComp:ChiefEventId")]
	public int ChiefEventId
	{
		get
		{
			CheckDestroyed();
			if (!ChiefEventId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_CollectionConfigComp:ChiefEventId");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ChiefEventId_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ChiefEventId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_CollectionConfigComp:ChiefEventId");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ChiefEventId_Offset), value);
			}
		}
	}

	public override void OnDataConvert(AActor Owner)
	{
		BUC_CollectionData bUC_CollectionData = RequireWritableData<BUC_CollectionData>();
		bUC_CollectionData.CollectionDropId = CollectionDropID;
		bUC_CollectionData.UnitClass = UnitClass;
		bUC_CollectionData.PlusUnitClass = PlusUnitClass;
		bUC_CollectionData.ChiefUnitClass = ChiefUnitClass;
		if (OverWriterEventId)
		{
			bUC_CollectionData.EventId = EventId;
			bUC_CollectionData.PlusEventId = PlusEventId;
			bUC_CollectionData.ChiefEventId = ChiefEventId;
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_CollectionConfigComp");
		CollectionDropID_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CollectionDropID");
		CollectionDropID_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CollectionDropID", Classes.FIntProperty);
		GroupID_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "GroupID");
		GroupID_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "GroupID", Classes.FIntProperty);
		UnitClass_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "UnitClass");
		UnitClass_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "UnitClass", Classes.FClassProperty);
		PlusUnitClass_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PlusUnitClass");
		PlusUnitClass_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PlusUnitClass", Classes.FClassProperty);
		ChiefUnitClass_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ChiefUnitClass");
		ChiefUnitClass_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ChiefUnitClass", Classes.FClassProperty);
		NativeReflection.GetPropertyRef(ref OverWriterEventId_PropertyAddress, unrealStruct, "OverWriterEventId");
		OverWriterEventId_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "OverWriterEventId");
		OverWriterEventId_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "OverWriterEventId", Classes.FBoolProperty);
		EventId_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EventId");
		EventId_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EventId", Classes.FIntProperty);
		PlusEventId_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PlusEventId");
		PlusEventId_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PlusEventId", Classes.FIntProperty);
		ChiefEventId_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ChiefEventId");
		ChiefEventId_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ChiefEventId", Classes.FIntProperty);
	}

	static BUS_CollectionConfigComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_CollectionConfigComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_CollectionConfigComp));
	}
}

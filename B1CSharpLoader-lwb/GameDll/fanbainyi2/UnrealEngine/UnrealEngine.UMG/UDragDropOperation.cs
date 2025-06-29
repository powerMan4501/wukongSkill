using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;

namespace UnrealEngine.UMG;

[UClass(Flags = (ClassFlags)818938016uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/UMG.DragDropOperation", "UMG", UnrealModuleType.Engine)]
public class UDragDropOperation : UObject
{
	private static bool Tag_IsValid;

	private static int Tag_Offset;

	private static bool Payload_IsValid;

	private static int Payload_Offset;

	private static bool DefaultDragVisual_IsValid;

	private static int DefaultDragVisual_Offset;

	private static bool Pivot_IsValid;

	private static FFieldAddress Pivot_PropertyAddress;

	private static int Pivot_Offset;

	private static bool Offset_IsValid;

	private static int Offset_Offset;

	private static bool OnDrop_IsValid;

	private static int OnDrop_Offset;

	private FOnDragDropMulticast OnDrop_DelegateCached;

	private static bool OnDragCancelled_IsValid;

	private static int OnDragCancelled_Offset;

	private FOnDragDropMulticast OnDragCancelled_DelegateCached;

	private static bool OnDragged_IsValid;

	private static int OnDragged_Offset;

	private FOnDragDropMulticast OnDragged_DelegateCached;

	private static bool Drop_IsValid;

	private IntPtr Drop_InstanceFunctionAddress;

	private static IntPtr Drop_FunctionAddress;

	private static int Drop_ParamsSize;

	private static bool Drop_PointerEvent_IsValid;

	private static FFieldAddress Drop_PointerEvent_PropertyAddress;

	private static int Drop_PointerEvent_Offset;

	private static bool Dragged_IsValid;

	private IntPtr Dragged_InstanceFunctionAddress;

	private static IntPtr Dragged_FunctionAddress;

	private static int Dragged_ParamsSize;

	private static bool Dragged_PointerEvent_IsValid;

	private static FFieldAddress Dragged_PointerEvent_PropertyAddress;

	private static int Dragged_PointerEvent_Offset;

	private static bool DragCancelled_IsValid;

	private IntPtr DragCancelled_InstanceFunctionAddress;

	private static IntPtr DragCancelled_FunctionAddress;

	private static int DragCancelled_ParamsSize;

	private static bool DragCancelled_PointerEvent_IsValid;

	private static FFieldAddress DragCancelled_PointerEvent_PropertyAddress;

	private static int DragCancelled_PointerEvent_Offset;

	[UProperty(Flags = (PropFlags)7036874417766917uL)]
	[UMetaPath("/Script/UMG.DragDropOperation:Tag")]
	public string Tag
	{
		get
		{
			CheckDestroyed();
			if (!Tag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.DragDropOperation:Tag");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, Tag_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Tag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.DragDropOperation:Tag");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, Tag_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)8162844117828101uL)]
	[UMetaPath("/Script/UMG.DragDropOperation:Payload")]
	public UObject Payload
	{
		get
		{
			CheckDestroyed();
			if (!Payload_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.DragDropOperation:Payload");
				return null;
			}
			return UObjectMarshaler<UObject>.FromNative(IntPtr.Add(base.Address, Payload_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Payload_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.DragDropOperation:Payload");
			}
			else
			{
				UObjectMarshaler<UObject>.ToNative(IntPtr.Add(base.Address, Payload_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)8162844118352413uL)]
	[UMetaPath("/Script/UMG.DragDropOperation:DefaultDragVisual")]
	public UWidget DefaultDragVisual
	{
		get
		{
			CheckDestroyed();
			if (!DefaultDragVisual_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.DragDropOperation:DefaultDragVisual");
				return null;
			}
			return UObjectMarshaler<UWidget>.FromNative(IntPtr.Add(base.Address, DefaultDragVisual_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DefaultDragVisual_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.DragDropOperation:DefaultDragVisual");
			}
			else
			{
				UObjectMarshaler<UWidget>.ToNative(IntPtr.Add(base.Address, DefaultDragVisual_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7036944210985477uL)]
	[UMetaPath("/Script/UMG.DragDropOperation:Pivot")]
	public EDragPivot Pivot
	{
		get
		{
			CheckDestroyed();
			if (!Pivot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.DragDropOperation:Pivot");
				return EDragPivot.MouseDown;
			}
			return EnumMarshaler<EDragPivot>.FromNative(IntPtr.Add(base.Address, Pivot_Offset), 0, Pivot_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Pivot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.DragDropOperation:Pivot");
			}
			else
			{
				EnumMarshaler<EDragPivot>.ToNative(IntPtr.Add(base.Address, Pivot_Offset), 0, Pivot_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7041342257496581uL)]
	[UMetaPath("/Script/UMG.DragDropOperation:Offset")]
	public FVector2D Offset
	{
		get
		{
			CheckDestroyed();
			if (!Offset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.DragDropOperation:Offset");
				return default(FVector2D);
			}
			return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(base.Address, Offset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Offset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.DragDropOperation:Offset");
			}
			else
			{
				BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(base.Address, Offset_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/UMG.DragDropOperation:OnDrop")]
	public FOnDragDropMulticast OnDrop
	{
		get
		{
			CheckDestroyed();
			if (!OnDrop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.DragDropOperation:OnDrop");
				return new FOnDragDropMulticast();
			}
			if (OnDrop_DelegateCached == null)
			{
				OnDrop_DelegateCached = new FOnDragDropMulticast();
				OnDrop_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnDrop_Offset));
			}
			return OnDrop_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/UMG.DragDropOperation:OnDragCancelled")]
	public FOnDragDropMulticast OnDragCancelled
	{
		get
		{
			CheckDestroyed();
			if (!OnDragCancelled_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.DragDropOperation:OnDragCancelled");
				return new FOnDragDropMulticast();
			}
			if (OnDragCancelled_DelegateCached == null)
			{
				OnDragCancelled_DelegateCached = new FOnDragDropMulticast();
				OnDragCancelled_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnDragCancelled_Offset));
			}
			return OnDragCancelled_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/UMG.DragDropOperation:OnDragged")]
	public FOnDragDropMulticast OnDragged
	{
		get
		{
			CheckDestroyed();
			if (!OnDragged_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.DragDropOperation:OnDragged");
				return new FOnDragDropMulticast();
			}
			if (OnDragged_DelegateCached == null)
			{
				OnDragged_DelegateCached = new FOnDragDropMulticast();
				OnDragged_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnDragged_Offset));
			}
			return OnDragged_DelegateCached;
		}
	}

	[UFunction(Flags = 138546176u)]
	[UMetaPath("/Script/UMG.DragDropOperation:Drop")]
	public unsafe void Drop(FPointerEvent PointerEvent)
	{
		CheckDestroyed();
		if (!Drop_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.DragDropOperation:Drop");
			return;
		}
		if (Drop_InstanceFunctionAddress == IntPtr.Zero)
		{
			Drop_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "Drop");
		}
		byte* ptr = stackalloc byte[(int)(uint)(Drop_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Drop_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Drop_PointerEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FPointerEvent>.ToNative(IntPtr.Add(intPtr, Drop_PointerEvent_Offset), 0, Drop_PointerEvent_PropertyAddress.Address, PointerEvent);
		NativeReflection.InvokeFunctionOptimized(base.Address, Drop_InstanceFunctionAddress, intPtr, Drop_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Drop_PointerEvent_PropertyAddress.Address, intPtr);
	}

	protected unsafe virtual void Drop_Implementation(FPointerEvent PointerEvent)
	{
		CheckDestroyed();
		if (!Drop_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.DragDropOperation:Drop");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Drop_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Drop_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Drop_PointerEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FPointerEvent>.ToNative(IntPtr.Add(intPtr, Drop_PointerEvent_Offset), 0, Drop_PointerEvent_PropertyAddress.Address, PointerEvent);
		NativeReflection.InvokeFunctionOptimized(base.Address, Drop_FunctionAddress, intPtr, Drop_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Drop_PointerEvent_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 138546176u)]
	[UMetaPath("/Script/UMG.DragDropOperation:Dragged")]
	public unsafe void Dragged(FPointerEvent PointerEvent)
	{
		CheckDestroyed();
		if (!Dragged_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.DragDropOperation:Dragged");
			return;
		}
		if (Dragged_InstanceFunctionAddress == IntPtr.Zero)
		{
			Dragged_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "Dragged");
		}
		byte* ptr = stackalloc byte[(int)(uint)(Dragged_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Dragged_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Dragged_PointerEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FPointerEvent>.ToNative(IntPtr.Add(intPtr, Dragged_PointerEvent_Offset), 0, Dragged_PointerEvent_PropertyAddress.Address, PointerEvent);
		NativeReflection.InvokeFunctionOptimized(base.Address, Dragged_InstanceFunctionAddress, intPtr, Dragged_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Dragged_PointerEvent_PropertyAddress.Address, intPtr);
	}

	protected unsafe virtual void Dragged_Implementation(FPointerEvent PointerEvent)
	{
		CheckDestroyed();
		if (!Dragged_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.DragDropOperation:Dragged");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Dragged_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Dragged_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Dragged_PointerEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FPointerEvent>.ToNative(IntPtr.Add(intPtr, Dragged_PointerEvent_Offset), 0, Dragged_PointerEvent_PropertyAddress.Address, PointerEvent);
		NativeReflection.InvokeFunctionOptimized(base.Address, Dragged_FunctionAddress, intPtr, Dragged_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Dragged_PointerEvent_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 138546176u)]
	[UMetaPath("/Script/UMG.DragDropOperation:DragCancelled")]
	public unsafe void DragCancelled(FPointerEvent PointerEvent)
	{
		CheckDestroyed();
		if (!DragCancelled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.DragDropOperation:DragCancelled");
			return;
		}
		if (DragCancelled_InstanceFunctionAddress == IntPtr.Zero)
		{
			DragCancelled_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "DragCancelled");
		}
		byte* ptr = stackalloc byte[(int)(uint)(DragCancelled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DragCancelled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(DragCancelled_PointerEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FPointerEvent>.ToNative(IntPtr.Add(intPtr, DragCancelled_PointerEvent_Offset), 0, DragCancelled_PointerEvent_PropertyAddress.Address, PointerEvent);
		NativeReflection.InvokeFunctionOptimized(base.Address, DragCancelled_InstanceFunctionAddress, intPtr, DragCancelled_ParamsSize);
		NativeReflection.DestroyValue_InContainer(DragCancelled_PointerEvent_PropertyAddress.Address, intPtr);
	}

	protected unsafe virtual void DragCancelled_Implementation(FPointerEvent PointerEvent)
	{
		CheckDestroyed();
		if (!DragCancelled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.DragDropOperation:DragCancelled");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DragCancelled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DragCancelled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(DragCancelled_PointerEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FPointerEvent>.ToNative(IntPtr.Add(intPtr, DragCancelled_PointerEvent_Offset), 0, DragCancelled_PointerEvent_PropertyAddress.Address, PointerEvent);
		NativeReflection.InvokeFunctionOptimized(base.Address, DragCancelled_FunctionAddress, intPtr, DragCancelled_ParamsSize);
		NativeReflection.DestroyValue_InContainer(DragCancelled_PointerEvent_PropertyAddress.Address, intPtr);
	}

	static UDragDropOperation()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UDragDropOperation)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UDragDropOperation));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/UMG.DragDropOperation");
		Tag_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Tag");
		Tag_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Tag", Classes.FStrProperty);
		Payload_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Payload");
		Payload_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Payload", Classes.FObjectProperty);
		DefaultDragVisual_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DefaultDragVisual");
		DefaultDragVisual_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DefaultDragVisual", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref Pivot_PropertyAddress, intPtr, "Pivot");
		Pivot_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Pivot");
		Pivot_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Pivot", Classes.FEnumProperty);
		Offset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Offset");
		Offset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Offset", Classes.FStructProperty);
		OnDrop_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnDrop");
		OnDrop_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnDrop", Classes.FMulticastDelegateProperty);
		OnDragCancelled_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnDragCancelled");
		OnDragCancelled_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnDragCancelled", Classes.FMulticastDelegateProperty);
		OnDragged_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnDragged");
		OnDragged_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnDragged", Classes.FMulticastDelegateProperty);
		Drop_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Drop");
		Drop_ParamsSize = NativeReflection.GetFunctionParamsSize(Drop_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Drop_PointerEvent_PropertyAddress, Drop_FunctionAddress, "PointerEvent");
		Drop_PointerEvent_Offset = NativeReflectionCached.GetPropertyOffset(Drop_FunctionAddress, "PointerEvent");
		Drop_PointerEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(Drop_FunctionAddress, "PointerEvent", Classes.FStructProperty);
		Drop_IsValid = Drop_FunctionAddress != IntPtr.Zero && Drop_PointerEvent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.DragDropOperation:Drop", Drop_IsValid);
		Dragged_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Dragged");
		Dragged_ParamsSize = NativeReflection.GetFunctionParamsSize(Dragged_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Dragged_PointerEvent_PropertyAddress, Dragged_FunctionAddress, "PointerEvent");
		Dragged_PointerEvent_Offset = NativeReflectionCached.GetPropertyOffset(Dragged_FunctionAddress, "PointerEvent");
		Dragged_PointerEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(Dragged_FunctionAddress, "PointerEvent", Classes.FStructProperty);
		Dragged_IsValid = Dragged_FunctionAddress != IntPtr.Zero && Dragged_PointerEvent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.DragDropOperation:Dragged", Dragged_IsValid);
		DragCancelled_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "DragCancelled");
		DragCancelled_ParamsSize = NativeReflection.GetFunctionParamsSize(DragCancelled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DragCancelled_PointerEvent_PropertyAddress, DragCancelled_FunctionAddress, "PointerEvent");
		DragCancelled_PointerEvent_Offset = NativeReflectionCached.GetPropertyOffset(DragCancelled_FunctionAddress, "PointerEvent");
		DragCancelled_PointerEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(DragCancelled_FunctionAddress, "PointerEvent", Classes.FStructProperty);
		DragCancelled_IsValid = DragCancelled_FunctionAddress != IntPtr.Zero && DragCancelled_PointerEvent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.DragDropOperation:DragCancelled", DragCancelled_IsValid);
	}
}

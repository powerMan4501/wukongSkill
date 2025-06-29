using System;
using System.Collections.Generic;
using b1.Plugins.Calliope;
using UnrealEngine.Runtime;

namespace b1;

[Abstract]
[UClass]
[USharpPath("/Script/b1-Managed.BED_ComboNode_State")]
public class BED_ComboNode_State : BED_ComboNode
{
	private static bool OptionalPins_IsValid;

	private static int OptionalPins_Offset;

	private static FFieldAddress OptionalPins_PropertyAddress;

	private TMapReadWriteMarshaler<FName, bool> OptionalPins_Marshaler;

	private static bool PostLoadInCS_IsValid;

	private static IntPtr PostLoadInCS_FunctionAddress;

	private static int PostLoadInCS_ParamsSize;

	private static bool PostPropertyChanged_IsValid;

	private static IntPtr PostPropertyChanged_FunctionAddress;

	private static int PostPropertyChanged_ParamsSize;

	private static bool PostPropertyChanged_MemberName_IsValid;

	private static int PostPropertyChanged_MemberName_Offset;

	private static FFieldAddress PostPropertyChanged_MemberName_PropertyAddress;

	private static bool PostPropertyChanged_PropertyName_IsValid;

	private static int PostPropertyChanged_PropertyName_Offset;

	private static FFieldAddress PostPropertyChanged_PropertyName_PropertyAddress;

	private static bool GetContextOutputsInCS_IsValid;

	private static IntPtr GetContextOutputsInCS_FunctionAddress;

	private static int GetContextOutputsInCS_ParamsSize;

	private static bool GetContextOutputsInCS_ReturnValue_IsValid;

	private static int GetContextOutputsInCS_ReturnValue_Offset;

	private static FFieldAddress GetContextOutputsInCS_ReturnValue_PropertyAddress;

	[VisibleAnywhere]
	[BlueprintReadWrite]
	[Category("Skill")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_ComboNode_State:OptionalPins")]
	public TMapReadWrite<FName, bool> OptionalPins
	{
		get
		{
			CheckDestroyed();
			if (!OptionalPins_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ComboNode_State:OptionalPins");
				return null;
			}
			if (OptionalPins_Marshaler == null)
			{
				OptionalPins_Marshaler = new TMapReadWriteMarshaler<FName, bool>(1, OptionalPins_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative, CachedMarshalingDelegates<bool, BoolMarshaler>.FromNative, CachedMarshalingDelegates<bool, BoolMarshaler>.ToNative);
			}
			return OptionalPins_Marshaler.FromNative(IntPtr.Add(base.Address, OptionalPins_Offset));
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		base.Category = "General";
		base.NodeStyle = ECalliopeNodeStyle.InOut;
		base.SupportsContextPins = true;
	}

	public BED_ComboAsset GetAssetCS()
	{
		UObject outer = GetOuter();
		if (outer == null)
		{
			return null;
		}
		return outer as BED_ComboAsset;
	}

	[USharpPath("/Script/b1-Managed.BED_ComboNode_State:PostLoadInCS")]
	protected override void PostLoadInCS_Implementation()
	{
		base.PostLoadInCS_Implementation();
		foreach (FName command in BED_ComboAsset.CommandList)
		{
			if (!OptionalPins.ContainsKey(command))
			{
				OptionalPins.Add(command, value: false);
			}
		}
		foreach (FName optionalCommand in BED_ComboAsset.OptionalCommandList)
		{
			if (!OptionalPins.ContainsKey(optionalCommand))
			{
				OptionalPins.Add(optionalCommand, value: false);
			}
		}
		List<FName> list = new List<FName>();
		foreach (KeyValuePair<FName, bool> optionalPin in OptionalPins)
		{
			if (!BED_ComboAsset.CommandList.Contains(optionalPin.Key) && !BED_ComboAsset.OptionalCommandList.Contains(optionalPin.Key))
			{
				list.Add(optionalPin.Key);
			}
		}
		foreach (FName item in list)
		{
			OptionalPins.Remove(item);
		}
	}

	[USharpPath("/Script/b1-Managed.BED_ComboNode_State:GetContextOutputsInCS")]
	protected override List<FName> GetContextOutputsInCS_Implementation()
	{
		List<FName> list = new List<FName>();
		if (OptionalPins.Count == 0)
		{
			foreach (FName command in BED_ComboAsset.CommandList)
			{
				OptionalPins.Add(command, value: true);
			}
			foreach (FName optionalCommand in BED_ComboAsset.OptionalCommandList)
			{
				OptionalPins.Add(optionalCommand, value: false);
			}
		}
		else
		{
			List<FName> list2 = new List<FName>();
			List<FName> list3 = new List<FName>();
			foreach (FName command2 in BED_ComboAsset.CommandList)
			{
				if (!OptionalPins.ContainsKey(command2))
				{
					list3.Add(command2);
				}
				list2.Add(command2);
			}
			List<FName> list4 = new List<FName>();
			foreach (FName optionalCommand2 in BED_ComboAsset.OptionalCommandList)
			{
				if (!OptionalPins.ContainsKey(optionalCommand2))
				{
					list4.Add(optionalCommand2);
				}
				list2.Add(optionalCommand2);
			}
			foreach (FName item in list3)
			{
				OptionalPins.Add(item, value: true);
			}
			foreach (FName item2 in list4)
			{
				OptionalPins.Add(item2, value: false);
			}
			foreach (KeyValuePair<FName, bool> item3 in OptionalPins.ToDictionary())
			{
				if (!list2.Contains(item3.Key))
				{
					OptionalPins.Remove(item3.Key);
				}
			}
		}
		foreach (KeyValuePair<FName, bool> optionalPin in OptionalPins)
		{
			if (optionalPin.Value)
			{
				list.Add(optionalPin.Key);
			}
		}
		return list;
	}

	[USharpPath("/Script/b1-Managed.BED_ComboNode_State:PostPropertyChanged")]
	protected override void PostPropertyChanged_Implementation(string MemberName, string PropertyName)
	{
		if (PropertyName.Equals("OptionalPins"))
		{
			ExecuteOnReconstructionRequested();
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_ComboNode_State:PostLoadInCS")]
	private static void PostLoadInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_ComboNode_State bED_ComboNode_State = GCHelper.Find<BED_ComboNode_State>(obj);
		bED_ComboNode_State.PostLoadInCS_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_ComboNode_State:PostPropertyChanged")]
	private static void PostPropertyChanged__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_ComboNode_State bED_ComboNode_State = GCHelper.Find<BED_ComboNode_State>(obj);
		string memberName = FStringMarshaler.FromNative(IntPtr.Add(buffer, PostPropertyChanged_MemberName_Offset));
		string propertyName = FStringMarshaler.FromNative(IntPtr.Add(buffer, PostPropertyChanged_PropertyName_Offset));
		bED_ComboNode_State.PostPropertyChanged_Implementation(memberName, propertyName);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_ComboNode_State:GetContextOutputsInCS")]
	private static void GetContextOutputsInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_ComboNode_State bED_ComboNode_State = GCHelper.Find<BED_ComboNode_State>(obj);
		TArrayCopyMarshaler<FName> tArrayCopyMarshaler = new TArrayCopyMarshaler<FName>(1, GetContextOutputsInCS_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
		List<FName> contextOutputsInCS_Implementation = bED_ComboNode_State.GetContextOutputsInCS_Implementation();
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, GetContextOutputsInCS_ReturnValue_Offset), contextOutputsInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_ComboNode_State");
		NativeReflection.GetPropertyRef(ref OptionalPins_PropertyAddress, intPtr, "OptionalPins");
		OptionalPins_Offset = NativeReflection.GetPropertyOffset(intPtr, "OptionalPins");
		OptionalPins_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OptionalPins", Classes.FMapProperty);
		PostLoadInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PostLoadInCS");
		PostLoadInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(PostLoadInCS_FunctionAddress);
		PostLoadInCS_IsValid = PostLoadInCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_ComboNode_State:PostLoadInCS", PostLoadInCS_IsValid);
		PostPropertyChanged_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PostPropertyChanged");
		PostPropertyChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(PostPropertyChanged_FunctionAddress);
		NativeReflection.GetPropertyRef(ref PostPropertyChanged_MemberName_PropertyAddress, PostPropertyChanged_FunctionAddress, "MemberName");
		PostPropertyChanged_MemberName_Offset = NativeReflection.GetPropertyOffset(PostPropertyChanged_FunctionAddress, "MemberName");
		PostPropertyChanged_MemberName_IsValid = NativeReflection.ValidatePropertyClass(PostPropertyChanged_FunctionAddress, "MemberName", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref PostPropertyChanged_PropertyName_PropertyAddress, PostPropertyChanged_FunctionAddress, "PropertyName");
		PostPropertyChanged_PropertyName_Offset = NativeReflection.GetPropertyOffset(PostPropertyChanged_FunctionAddress, "PropertyName");
		PostPropertyChanged_PropertyName_IsValid = NativeReflection.ValidatePropertyClass(PostPropertyChanged_FunctionAddress, "PropertyName", Classes.FStrProperty);
		PostPropertyChanged_IsValid = PostPropertyChanged_FunctionAddress != IntPtr.Zero && PostPropertyChanged_MemberName_IsValid && PostPropertyChanged_PropertyName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_ComboNode_State:PostPropertyChanged", PostPropertyChanged_IsValid);
		GetContextOutputsInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetContextOutputsInCS");
		GetContextOutputsInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetContextOutputsInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetContextOutputsInCS_ReturnValue_PropertyAddress, GetContextOutputsInCS_FunctionAddress, "ReturnValue");
		GetContextOutputsInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetContextOutputsInCS_FunctionAddress, "ReturnValue");
		GetContextOutputsInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetContextOutputsInCS_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetContextOutputsInCS_IsValid = GetContextOutputsInCS_FunctionAddress != IntPtr.Zero && GetContextOutputsInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_ComboNode_State:GetContextOutputsInCS", GetContextOutputsInCS_IsValid);
	}

	static BED_ComboNode_State()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_ComboNode_State)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_ComboNode_State));
	}
}

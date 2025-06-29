using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("Notify Self")]
[USharpPath("/Script/b1-Managed.BED_ProcessStateNode_NotifySelf")]
public class BED_ProcessStateNode_NotifySelf : BED_ProcessStateNode
{
	private static bool EventList_IsValid;

	private static int EventList_Offset;

	private static FFieldAddress EventList_PropertyAddress;

	private TMapReadWriteMarshaler<FName, bool> EventList_Marshaler;

	private static bool CurrentEvent_IsValid;

	private static int CurrentEvent_Offset;

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

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[VisibleAnywhere]
	[DisplayName("事件列表")]
	[UProperty]
	[Category("State")]
	[USharpPath("/Script/b1-Managed.BED_ProcessStateNode_NotifySelf:EventList")]
	public TMapReadWrite<FName, bool> EventList
	{
		get
		{
			CheckDestroyed();
			if (!EventList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessStateNode_NotifySelf:EventList");
				return null;
			}
			if (EventList_Marshaler == null)
			{
				EventList_Marshaler = new TMapReadWriteMarshaler<FName, bool>(1, EventList_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative, CachedMarshalingDelegates<bool, BoolMarshaler>.FromNative, CachedMarshalingDelegates<bool, BoolMarshaler>.ToNative);
			}
			return EventList_Marshaler.FromNative(IntPtr.Add(base.Address, EventList_Offset));
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_ProcessStateNode_NotifySelf:CurrentEvent")]
	private FName CurrentEvent
	{
		get
		{
			CheckDestroyed();
			if (!CurrentEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessStateNode_NotifySelf:CurrentEvent");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, CurrentEvent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CurrentEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessStateNode_NotifySelf:CurrentEvent");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, CurrentEvent_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		SetNodeCategory("Notify");
		base.SupportsContextPins = true;
		SyncWithAsset();
	}

	private void SyncWithAsset()
	{
		BED_ProcessAsset bED_ProcessAsset = GetCalliopeAsset() as BED_ProcessAsset;
		if (!(bED_ProcessAsset != null))
		{
			return;
		}
		List<FGameplayTag> gameplayTags = bED_ProcessAsset.EventTags.GameplayTags;
		List<FName> list = new List<FName>();
		foreach (KeyValuePair<FName, bool> KvPair in EventList)
		{
			if (!gameplayTags.Any((FGameplayTag p) => GameplayTagExtension.EqualTo(p, KvPair.Key.PlainName)))
			{
				list.Add(KvPair.Key);
			}
		}
		foreach (FName item in list)
		{
			if (CurrentEvent == item)
			{
				CurrentEvent = FName.None;
			}
			EventList.Remove(item);
		}
		list.Clear();
		foreach (FGameplayTag item2 in gameplayTags)
		{
			FName tagName = item2.TagName;
			if (!EventList.ContainsKey(tagName))
			{
				EventList.Add(tagName, value: false);
			}
		}
	}

	public override string GetNodeName()
	{
		return "Process.State.NotifySelf";
	}

	public override byte[] GetCustomData()
	{
		return new ProcessStateCustom_NotifySelf
		{
			NotifyTagStrings = { CurrentEvent.PlainName }
		}.ToByteArray();
	}

	[USharpPath("/Script/b1-Managed.BED_ProcessStateNode_NotifySelf:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("Event: " + CurrentEvent.PlainName + "\n");
		return stringBuilder.ToString();
	}

	[USharpPath("/Script/b1-Managed.BED_ProcessStateNode_NotifySelf:GetContextOutputsInCS")]
	protected override List<FName> GetContextOutputsInCS_Implementation()
	{
		List<FName> result = new List<FName>();
		SyncWithAsset();
		return result;
	}

	[USharpPath("/Script/b1-Managed.BED_ProcessStateNode_NotifySelf:PostPropertyChanged")]
	protected override void PostPropertyChanged_Implementation(string MemberName, string PropertyName)
	{
		if (!PropertyName.Equals("EventList"))
		{
			return;
		}
		if (CurrentEvent == FName.None)
		{
			foreach (KeyValuePair<FName, bool> @event in EventList)
			{
				if (@event.Value)
				{
					CurrentEvent = @event.Key;
					break;
				}
			}
			return;
		}
		EventList[CurrentEvent] = false;
		bool flag = true;
		foreach (KeyValuePair<FName, bool> event2 in EventList)
		{
			if (event2.Value)
			{
				flag = false;
				CurrentEvent = event2.Key;
				break;
			}
		}
		if (flag)
		{
			EventList[CurrentEvent] = true;
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_ProcessStateNode_NotifySelf:PostPropertyChanged")]
	private static void PostPropertyChanged__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_ProcessStateNode_NotifySelf bED_ProcessStateNode_NotifySelf = GCHelper.Find<BED_ProcessStateNode_NotifySelf>(obj);
		string memberName = FStringMarshaler.FromNative(IntPtr.Add(buffer, PostPropertyChanged_MemberName_Offset));
		string propertyName = FStringMarshaler.FromNative(IntPtr.Add(buffer, PostPropertyChanged_PropertyName_Offset));
		bED_ProcessStateNode_NotifySelf.PostPropertyChanged_Implementation(memberName, propertyName);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_ProcessStateNode_NotifySelf:GetContextOutputsInCS")]
	private static void GetContextOutputsInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_ProcessStateNode_NotifySelf bED_ProcessStateNode_NotifySelf = GCHelper.Find<BED_ProcessStateNode_NotifySelf>(obj);
		TArrayCopyMarshaler<FName> tArrayCopyMarshaler = new TArrayCopyMarshaler<FName>(1, GetContextOutputsInCS_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
		List<FName> contextOutputsInCS_Implementation = bED_ProcessStateNode_NotifySelf.GetContextOutputsInCS_Implementation();
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, GetContextOutputsInCS_ReturnValue_Offset), contextOutputsInCS_Implementation);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_ProcessStateNode_NotifySelf:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_ProcessStateNode_NotifySelf bED_ProcessStateNode_NotifySelf = GCHelper.Find<BED_ProcessStateNode_NotifySelf>(obj);
		string nodeDescriptionInCS_Implementation = bED_ProcessStateNode_NotifySelf.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_ProcessStateNode_NotifySelf");
		NativeReflection.GetPropertyRef(ref EventList_PropertyAddress, intPtr, "EventList");
		EventList_Offset = NativeReflection.GetPropertyOffset(intPtr, "EventList");
		EventList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EventList", Classes.FMapProperty);
		CurrentEvent_Offset = NativeReflection.GetPropertyOffset(intPtr, "CurrentEvent");
		CurrentEvent_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CurrentEvent", Classes.FNameProperty);
		PostPropertyChanged_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PostPropertyChanged");
		PostPropertyChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(PostPropertyChanged_FunctionAddress);
		NativeReflection.GetPropertyRef(ref PostPropertyChanged_MemberName_PropertyAddress, PostPropertyChanged_FunctionAddress, "MemberName");
		PostPropertyChanged_MemberName_Offset = NativeReflection.GetPropertyOffset(PostPropertyChanged_FunctionAddress, "MemberName");
		PostPropertyChanged_MemberName_IsValid = NativeReflection.ValidatePropertyClass(PostPropertyChanged_FunctionAddress, "MemberName", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref PostPropertyChanged_PropertyName_PropertyAddress, PostPropertyChanged_FunctionAddress, "PropertyName");
		PostPropertyChanged_PropertyName_Offset = NativeReflection.GetPropertyOffset(PostPropertyChanged_FunctionAddress, "PropertyName");
		PostPropertyChanged_PropertyName_IsValid = NativeReflection.ValidatePropertyClass(PostPropertyChanged_FunctionAddress, "PropertyName", Classes.FStrProperty);
		PostPropertyChanged_IsValid = PostPropertyChanged_FunctionAddress != IntPtr.Zero && PostPropertyChanged_MemberName_IsValid && PostPropertyChanged_PropertyName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_ProcessStateNode_NotifySelf:PostPropertyChanged", PostPropertyChanged_IsValid);
		GetContextOutputsInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetContextOutputsInCS");
		GetContextOutputsInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetContextOutputsInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetContextOutputsInCS_ReturnValue_PropertyAddress, GetContextOutputsInCS_FunctionAddress, "ReturnValue");
		GetContextOutputsInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetContextOutputsInCS_FunctionAddress, "ReturnValue");
		GetContextOutputsInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetContextOutputsInCS_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetContextOutputsInCS_IsValid = GetContextOutputsInCS_FunctionAddress != IntPtr.Zero && GetContextOutputsInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_ProcessStateNode_NotifySelf:GetContextOutputsInCS", GetContextOutputsInCS_IsValid);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_ProcessStateNode_NotifySelf:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_ProcessStateNode_NotifySelf()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_ProcessStateNode_NotifySelf)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_ProcessStateNode_NotifySelf));
	}
}

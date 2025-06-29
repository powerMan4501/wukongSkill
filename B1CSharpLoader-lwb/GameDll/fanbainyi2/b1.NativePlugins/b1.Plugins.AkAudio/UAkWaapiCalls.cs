using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UClass(Flags = (ClassFlags)810549410uL, Config = "Engine")]
[UMetaPath("/Script/AkAudio.AkWaapiCalls", "AkAudio", UnrealModuleType.GamePlugin)]
public class UAkWaapiCalls : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool Unsubscribe_IsValid;

	private static IntPtr Unsubscribe_FunctionAddress;

	private static int Unsubscribe_ParamsSize;

	private static bool Unsubscribe_SubscriptionId_IsValid;

	private static FFieldAddress Unsubscribe_SubscriptionId_PropertyAddress;

	private static int Unsubscribe_SubscriptionId_Offset;

	private static bool Unsubscribe_UnsubscriptionDone_IsValid;

	private static FFieldAddress Unsubscribe_UnsubscriptionDone_PropertyAddress;

	private static int Unsubscribe_UnsubscriptionDone_Offset;

	private static bool Unsubscribe_ReturnValue_IsValid;

	private static FFieldAddress Unsubscribe_ReturnValue_PropertyAddress;

	private static int Unsubscribe_ReturnValue_Offset;

	private static bool SubscribeToWaapi_IsValid;

	private static IntPtr SubscribeToWaapi_FunctionAddress;

	private static int SubscribeToWaapi_ParamsSize;

	private static bool SubscribeToWaapi_WaapiUri_IsValid;

	private static FFieldAddress SubscribeToWaapi_WaapiUri_PropertyAddress;

	private static int SubscribeToWaapi_WaapiUri_Offset;

	private static bool SubscribeToWaapi_WaapiOptions_IsValid;

	private static FFieldAddress SubscribeToWaapi_WaapiOptions_PropertyAddress;

	private static int SubscribeToWaapi_WaapiOptions_Offset;

	private static bool SubscribeToWaapi_CallBack_IsValid;

	private static FFieldAddress SubscribeToWaapi_CallBack_PropertyAddress;

	private static int SubscribeToWaapi_CallBack_Offset;

	private static bool SubscribeToWaapi_SubscriptionId_IsValid;

	private static FFieldAddress SubscribeToWaapi_SubscriptionId_PropertyAddress;

	private static int SubscribeToWaapi_SubscriptionId_Offset;

	private static bool SubscribeToWaapi_SubscriptionDone_IsValid;

	private static FFieldAddress SubscribeToWaapi_SubscriptionDone_PropertyAddress;

	private static int SubscribeToWaapi_SubscriptionDone_Offset;

	private static bool SubscribeToWaapi_ReturnValue_IsValid;

	private static FFieldAddress SubscribeToWaapi_ReturnValue_PropertyAddress;

	private static int SubscribeToWaapi_ReturnValue_Offset;

	private static bool SetSubscriptionID_IsValid;

	private static IntPtr SetSubscriptionID_FunctionAddress;

	private static int SetSubscriptionID_ParamsSize;

	private static bool SetSubscriptionID_Subscription_IsValid;

	private static FFieldAddress SetSubscriptionID_Subscription_PropertyAddress;

	private static int SetSubscriptionID_Subscription_Offset;

	private static bool SetSubscriptionID_id_IsValid;

	private static FFieldAddress SetSubscriptionID_id_PropertyAddress;

	private static int SetSubscriptionID_id_Offset;

	private static bool RegisterWaapiProjectLoadedCallback_IsValid;

	private static IntPtr RegisterWaapiProjectLoadedCallback_FunctionAddress;

	private static int RegisterWaapiProjectLoadedCallback_ParamsSize;

	private static bool RegisterWaapiProjectLoadedCallback_Callback_IsValid;

	private static FFieldAddress RegisterWaapiProjectLoadedCallback_Callback_PropertyAddress;

	private static int RegisterWaapiProjectLoadedCallback_Callback_Offset;

	private static bool RegisterWaapiProjectLoadedCallback_ReturnValue_IsValid;

	private static FFieldAddress RegisterWaapiProjectLoadedCallback_ReturnValue_PropertyAddress;

	private static int RegisterWaapiProjectLoadedCallback_ReturnValue_Offset;

	private static bool RegisterWaapiConnectionLostCallback_IsValid;

	private static IntPtr RegisterWaapiConnectionLostCallback_FunctionAddress;

	private static int RegisterWaapiConnectionLostCallback_ParamsSize;

	private static bool RegisterWaapiConnectionLostCallback_Callback_IsValid;

	private static FFieldAddress RegisterWaapiConnectionLostCallback_Callback_PropertyAddress;

	private static int RegisterWaapiConnectionLostCallback_Callback_Offset;

	private static bool RegisterWaapiConnectionLostCallback_ReturnValue_IsValid;

	private static FFieldAddress RegisterWaapiConnectionLostCallback_ReturnValue_PropertyAddress;

	private static int RegisterWaapiConnectionLostCallback_ReturnValue_Offset;

	private static bool GetSubscriptionID_IsValid;

	private static IntPtr GetSubscriptionID_FunctionAddress;

	private static int GetSubscriptionID_ParamsSize;

	private static bool GetSubscriptionID_Subscription_IsValid;

	private static FFieldAddress GetSubscriptionID_Subscription_PropertyAddress;

	private static int GetSubscriptionID_Subscription_Offset;

	private static bool GetSubscriptionID_ReturnValue_IsValid;

	private static FFieldAddress GetSubscriptionID_ReturnValue_PropertyAddress;

	private static int GetSubscriptionID_ReturnValue_Offset;

	private static bool Conv_FAkWaapiSubscriptionIdToText_IsValid;

	private static IntPtr Conv_FAkWaapiSubscriptionIdToText_FunctionAddress;

	private static int Conv_FAkWaapiSubscriptionIdToText_ParamsSize;

	private static bool Conv_FAkWaapiSubscriptionIdToText_INAkWaapiSubscriptionId_IsValid;

	private static FFieldAddress Conv_FAkWaapiSubscriptionIdToText_INAkWaapiSubscriptionId_PropertyAddress;

	private static int Conv_FAkWaapiSubscriptionIdToText_INAkWaapiSubscriptionId_Offset;

	private static bool Conv_FAkWaapiSubscriptionIdToText_ReturnValue_IsValid;

	private static FFieldAddress Conv_FAkWaapiSubscriptionIdToText_ReturnValue_PropertyAddress;

	private static int Conv_FAkWaapiSubscriptionIdToText_ReturnValue_Offset;

	private static bool Conv_FAkWaapiSubscriptionIdToString_IsValid;

	private static IntPtr Conv_FAkWaapiSubscriptionIdToString_FunctionAddress;

	private static int Conv_FAkWaapiSubscriptionIdToString_ParamsSize;

	private static bool Conv_FAkWaapiSubscriptionIdToString_INAkWaapiSubscriptionId_IsValid;

	private static FFieldAddress Conv_FAkWaapiSubscriptionIdToString_INAkWaapiSubscriptionId_PropertyAddress;

	private static int Conv_FAkWaapiSubscriptionIdToString_INAkWaapiSubscriptionId_Offset;

	private static bool Conv_FAkWaapiSubscriptionIdToString_ReturnValue_IsValid;

	private static FFieldAddress Conv_FAkWaapiSubscriptionIdToString_ReturnValue_PropertyAddress;

	private static int Conv_FAkWaapiSubscriptionIdToString_ReturnValue_Offset;

	private static bool CallWaapi_IsValid;

	private static IntPtr CallWaapi_FunctionAddress;

	private static int CallWaapi_ParamsSize;

	private static bool CallWaapi_WaapiUri_IsValid;

	private static FFieldAddress CallWaapi_WaapiUri_PropertyAddress;

	private static int CallWaapi_WaapiUri_Offset;

	private static bool CallWaapi_WaapiArgs_IsValid;

	private static FFieldAddress CallWaapi_WaapiArgs_PropertyAddress;

	private static int CallWaapi_WaapiArgs_Offset;

	private static bool CallWaapi_WaapiOptions_IsValid;

	private static FFieldAddress CallWaapi_WaapiOptions_PropertyAddress;

	private static int CallWaapi_WaapiOptions_Offset;

	private static bool CallWaapi_ReturnValue_IsValid;

	private static FFieldAddress CallWaapi_ReturnValue_PropertyAddress;

	private static int CallWaapi_ReturnValue_Offset;

	[UFunction(Flags = 71443465u)]
	[UMetaPath("/Script/AkAudio.AkWaapiCalls:Unsubscribe")]
	public unsafe static FAKWaapiJsonObject Unsubscribe(FAkWaapiSubscriptionId SubscriptionId, out bool UnsubscriptionDone)
	{
		if (!Unsubscribe_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkWaapiCalls:Unsubscribe");
			UnsubscriptionDone = false;
			return default(FAKWaapiJsonObject);
		}
		byte* ptr = stackalloc byte[(int)(uint)(Unsubscribe_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Unsubscribe_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Unsubscribe_SubscriptionId_PropertyAddress.Address, intPtr);
		FAkWaapiSubscriptionId.ToNative(IntPtr.Add(intPtr, Unsubscribe_SubscriptionId_Offset), 0, Unsubscribe_SubscriptionId_PropertyAddress.Address, SubscriptionId);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Unsubscribe_FunctionAddress, intPtr, Unsubscribe_ParamsSize);
		UnsubscriptionDone = BoolMarshaler.FromNative(IntPtr.Add(intPtr, Unsubscribe_UnsubscriptionDone_Offset), 0, Unsubscribe_UnsubscriptionDone_PropertyAddress.Address);
		FAKWaapiJsonObject result = FAKWaapiJsonObject.FromNative(IntPtr.Add(intPtr, Unsubscribe_ReturnValue_Offset), 0, Unsubscribe_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(Unsubscribe_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443465u)]
	[UMetaPath("/Script/AkAudio.AkWaapiCalls:SubscribeToWaapi")]
	public unsafe static FAKWaapiJsonObject SubscribeToWaapi(FAkWaapiUri WaapiUri, FAKWaapiJsonObject WaapiOptions, FOnEventCallback CallBack, out FAkWaapiSubscriptionId SubscriptionId, out bool SubscriptionDone)
	{
		if (!SubscribeToWaapi_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkWaapiCalls:SubscribeToWaapi");
			SubscriptionId = default(FAkWaapiSubscriptionId);
			SubscriptionDone = false;
			return default(FAKWaapiJsonObject);
		}
		byte* ptr = stackalloc byte[(int)(uint)(SubscribeToWaapi_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SubscribeToWaapi_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SubscribeToWaapi_WaapiUri_PropertyAddress.Address, intPtr);
		FAkWaapiUri.ToNative(IntPtr.Add(intPtr, SubscribeToWaapi_WaapiUri_Offset), 0, SubscribeToWaapi_WaapiUri_PropertyAddress.Address, WaapiUri);
		NativeReflection.InitializeValue_InContainer(SubscribeToWaapi_WaapiOptions_PropertyAddress.Address, intPtr);
		FAKWaapiJsonObject.ToNative(IntPtr.Add(intPtr, SubscribeToWaapi_WaapiOptions_Offset), 0, SubscribeToWaapi_WaapiOptions_PropertyAddress.Address, WaapiOptions);
		FDelegateMarshaler<FOnEventCallback>.ToNative(IntPtr.Add(intPtr, SubscribeToWaapi_CallBack_Offset), 0, SubscribeToWaapi_CallBack_PropertyAddress.Address, CallBack);
		NativeReflection.InitializeValue_InContainer(SubscribeToWaapi_SubscriptionId_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SubscribeToWaapi_FunctionAddress, intPtr, SubscribeToWaapi_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SubscribeToWaapi_WaapiUri_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SubscribeToWaapi_WaapiOptions_PropertyAddress.Address, intPtr);
		SubscriptionId = FAkWaapiSubscriptionId.FromNative(IntPtr.Add(intPtr, SubscribeToWaapi_SubscriptionId_Offset), 0, SubscribeToWaapi_SubscriptionId_PropertyAddress.Address);
		SubscriptionDone = BoolMarshaler.FromNative(IntPtr.Add(intPtr, SubscribeToWaapi_SubscriptionDone_Offset), 0, SubscribeToWaapi_SubscriptionDone_PropertyAddress.Address);
		FAKWaapiJsonObject result = FAKWaapiJsonObject.FromNative(IntPtr.Add(intPtr, SubscribeToWaapi_ReturnValue_Offset), 0, SubscribeToWaapi_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(SubscribeToWaapi_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/AkAudio.AkWaapiCalls:SetSubscriptionID")]
	public unsafe static void SetSubscriptionID(FAkWaapiSubscriptionId Subscription, int id)
	{
		if (!SetSubscriptionID_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkWaapiCalls:SetSubscriptionID");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSubscriptionID_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSubscriptionID_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetSubscriptionID_Subscription_PropertyAddress.Address, intPtr);
		FAkWaapiSubscriptionId.ToNative(IntPtr.Add(intPtr, SetSubscriptionID_Subscription_Offset), 0, SetSubscriptionID_Subscription_PropertyAddress.Address, Subscription);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetSubscriptionID_id_Offset), 0, SetSubscriptionID_id_PropertyAddress.Address, id);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetSubscriptionID_FunctionAddress, intPtr, SetSubscriptionID_ParamsSize);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/AkAudio.AkWaapiCalls:RegisterWaapiProjectLoadedCallback")]
	public unsafe static bool RegisterWaapiProjectLoadedCallback(FOnWaapiProjectLoaded Callback)
	{
		if (!RegisterWaapiProjectLoadedCallback_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkWaapiCalls:RegisterWaapiProjectLoadedCallback");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RegisterWaapiProjectLoadedCallback_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RegisterWaapiProjectLoadedCallback_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FDelegateMarshaler<FOnWaapiProjectLoaded>.ToNative(IntPtr.Add(intPtr, RegisterWaapiProjectLoadedCallback_Callback_Offset), 0, RegisterWaapiProjectLoadedCallback_Callback_PropertyAddress.Address, Callback);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RegisterWaapiProjectLoadedCallback_FunctionAddress, intPtr, RegisterWaapiProjectLoadedCallback_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RegisterWaapiProjectLoadedCallback_ReturnValue_Offset), 0, RegisterWaapiProjectLoadedCallback_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/AkAudio.AkWaapiCalls:RegisterWaapiConnectionLostCallback")]
	public unsafe static bool RegisterWaapiConnectionLostCallback(FOnWaapiConnectionLost Callback)
	{
		if (!RegisterWaapiConnectionLostCallback_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkWaapiCalls:RegisterWaapiConnectionLostCallback");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RegisterWaapiConnectionLostCallback_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RegisterWaapiConnectionLostCallback_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FDelegateMarshaler<FOnWaapiConnectionLost>.ToNative(IntPtr.Add(intPtr, RegisterWaapiConnectionLostCallback_Callback_Offset), 0, RegisterWaapiConnectionLostCallback_Callback_PropertyAddress.Address, Callback);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RegisterWaapiConnectionLostCallback_FunctionAddress, intPtr, RegisterWaapiConnectionLostCallback_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RegisterWaapiConnectionLostCallback_ReturnValue_Offset), 0, RegisterWaapiConnectionLostCallback_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/AkAudio.AkWaapiCalls:GetSubscriptionID")]
	public unsafe static int GetSubscriptionID(FAkWaapiSubscriptionId Subscription)
	{
		if (!GetSubscriptionID_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkWaapiCalls:GetSubscriptionID");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSubscriptionID_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSubscriptionID_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetSubscriptionID_Subscription_PropertyAddress.Address, intPtr);
		FAkWaapiSubscriptionId.ToNative(IntPtr.Add(intPtr, GetSubscriptionID_Subscription_Offset), 0, GetSubscriptionID_Subscription_PropertyAddress.Address, Subscription);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetSubscriptionID_FunctionAddress, intPtr, GetSubscriptionID_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetSubscriptionID_ReturnValue_Offset), 0, GetSubscriptionID_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/AkAudio.AkWaapiCalls:Conv_FAkWaapiSubscriptionIdToText")]
	public unsafe static string Conv_FAkWaapiSubscriptionIdToText(FAkWaapiSubscriptionId INAkWaapiSubscriptionId)
	{
		if (!Conv_FAkWaapiSubscriptionIdToText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkWaapiCalls:Conv_FAkWaapiSubscriptionIdToText");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Conv_FAkWaapiSubscriptionIdToText_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Conv_FAkWaapiSubscriptionIdToText_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Conv_FAkWaapiSubscriptionIdToText_INAkWaapiSubscriptionId_PropertyAddress.Address, intPtr);
		FAkWaapiSubscriptionId.ToNative(IntPtr.Add(intPtr, Conv_FAkWaapiSubscriptionIdToText_INAkWaapiSubscriptionId_Offset), 0, Conv_FAkWaapiSubscriptionIdToText_INAkWaapiSubscriptionId_PropertyAddress.Address, INAkWaapiSubscriptionId);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Conv_FAkWaapiSubscriptionIdToText_FunctionAddress, intPtr, Conv_FAkWaapiSubscriptionIdToText_ParamsSize);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, Conv_FAkWaapiSubscriptionIdToText_ReturnValue_Offset), 0, Conv_FAkWaapiSubscriptionIdToText_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(Conv_FAkWaapiSubscriptionIdToText_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/AkAudio.AkWaapiCalls:Conv_FAkWaapiSubscriptionIdToString")]
	public unsafe static string Conv_FAkWaapiSubscriptionIdToString(FAkWaapiSubscriptionId INAkWaapiSubscriptionId)
	{
		if (!Conv_FAkWaapiSubscriptionIdToString_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkWaapiCalls:Conv_FAkWaapiSubscriptionIdToString");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Conv_FAkWaapiSubscriptionIdToString_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Conv_FAkWaapiSubscriptionIdToString_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Conv_FAkWaapiSubscriptionIdToString_INAkWaapiSubscriptionId_PropertyAddress.Address, intPtr);
		FAkWaapiSubscriptionId.ToNative(IntPtr.Add(intPtr, Conv_FAkWaapiSubscriptionIdToString_INAkWaapiSubscriptionId_Offset), 0, Conv_FAkWaapiSubscriptionIdToString_INAkWaapiSubscriptionId_PropertyAddress.Address, INAkWaapiSubscriptionId);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Conv_FAkWaapiSubscriptionIdToString_FunctionAddress, intPtr, Conv_FAkWaapiSubscriptionIdToString_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, Conv_FAkWaapiSubscriptionIdToString_ReturnValue_Offset), 0, Conv_FAkWaapiSubscriptionIdToString_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(Conv_FAkWaapiSubscriptionIdToString_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443465u)]
	[UMetaPath("/Script/AkAudio.AkWaapiCalls:CallWaapi")]
	public unsafe static FAKWaapiJsonObject CallWaapi(FAkWaapiUri WaapiUri, FAKWaapiJsonObject WaapiArgs, FAKWaapiJsonObject WaapiOptions)
	{
		if (!CallWaapi_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkWaapiCalls:CallWaapi");
			return default(FAKWaapiJsonObject);
		}
		byte* ptr = stackalloc byte[(int)(uint)(CallWaapi_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CallWaapi_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(CallWaapi_WaapiUri_PropertyAddress.Address, intPtr);
		FAkWaapiUri.ToNative(IntPtr.Add(intPtr, CallWaapi_WaapiUri_Offset), 0, CallWaapi_WaapiUri_PropertyAddress.Address, WaapiUri);
		NativeReflection.InitializeValue_InContainer(CallWaapi_WaapiArgs_PropertyAddress.Address, intPtr);
		FAKWaapiJsonObject.ToNative(IntPtr.Add(intPtr, CallWaapi_WaapiArgs_Offset), 0, CallWaapi_WaapiArgs_PropertyAddress.Address, WaapiArgs);
		NativeReflection.InitializeValue_InContainer(CallWaapi_WaapiOptions_PropertyAddress.Address, intPtr);
		FAKWaapiJsonObject.ToNative(IntPtr.Add(intPtr, CallWaapi_WaapiOptions_Offset), 0, CallWaapi_WaapiOptions_PropertyAddress.Address, WaapiOptions);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CallWaapi_FunctionAddress, intPtr, CallWaapi_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CallWaapi_WaapiUri_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(CallWaapi_WaapiArgs_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(CallWaapi_WaapiOptions_PropertyAddress.Address, intPtr);
		FAKWaapiJsonObject result = FAKWaapiJsonObject.FromNative(IntPtr.Add(intPtr, CallWaapi_ReturnValue_Offset), 0, CallWaapi_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(CallWaapi_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static UAkWaapiCalls()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAkWaapiCalls)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAkWaapiCalls));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/AkAudio.AkWaapiCalls");
		Unsubscribe_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Unsubscribe");
		Unsubscribe_ParamsSize = NativeReflection.GetFunctionParamsSize(Unsubscribe_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Unsubscribe_SubscriptionId_PropertyAddress, Unsubscribe_FunctionAddress, "SubscriptionId");
		Unsubscribe_SubscriptionId_Offset = NativeReflectionCached.GetPropertyOffset(Unsubscribe_FunctionAddress, "SubscriptionId");
		Unsubscribe_SubscriptionId_IsValid = NativeReflectionCached.ValidatePropertyClass(Unsubscribe_FunctionAddress, "SubscriptionId", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Unsubscribe_UnsubscriptionDone_PropertyAddress, Unsubscribe_FunctionAddress, "UnsubscriptionDone");
		Unsubscribe_UnsubscriptionDone_Offset = NativeReflectionCached.GetPropertyOffset(Unsubscribe_FunctionAddress, "UnsubscriptionDone");
		Unsubscribe_UnsubscriptionDone_IsValid = NativeReflectionCached.ValidatePropertyClass(Unsubscribe_FunctionAddress, "UnsubscriptionDone", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Unsubscribe_ReturnValue_PropertyAddress, Unsubscribe_FunctionAddress, "ReturnValue");
		Unsubscribe_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Unsubscribe_FunctionAddress, "ReturnValue");
		Unsubscribe_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Unsubscribe_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		Unsubscribe_IsValid = Unsubscribe_FunctionAddress != IntPtr.Zero && Unsubscribe_SubscriptionId_IsValid && Unsubscribe_UnsubscriptionDone_IsValid && Unsubscribe_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkWaapiCalls:Unsubscribe", Unsubscribe_IsValid);
		SubscribeToWaapi_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SubscribeToWaapi");
		SubscribeToWaapi_ParamsSize = NativeReflection.GetFunctionParamsSize(SubscribeToWaapi_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SubscribeToWaapi_WaapiUri_PropertyAddress, SubscribeToWaapi_FunctionAddress, "WaapiUri");
		SubscribeToWaapi_WaapiUri_Offset = NativeReflectionCached.GetPropertyOffset(SubscribeToWaapi_FunctionAddress, "WaapiUri");
		SubscribeToWaapi_WaapiUri_IsValid = NativeReflectionCached.ValidatePropertyClass(SubscribeToWaapi_FunctionAddress, "WaapiUri", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SubscribeToWaapi_WaapiOptions_PropertyAddress, SubscribeToWaapi_FunctionAddress, "WaapiOptions");
		SubscribeToWaapi_WaapiOptions_Offset = NativeReflectionCached.GetPropertyOffset(SubscribeToWaapi_FunctionAddress, "WaapiOptions");
		SubscribeToWaapi_WaapiOptions_IsValid = NativeReflectionCached.ValidatePropertyClass(SubscribeToWaapi_FunctionAddress, "WaapiOptions", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SubscribeToWaapi_CallBack_PropertyAddress, SubscribeToWaapi_FunctionAddress, "CallBack");
		SubscribeToWaapi_CallBack_Offset = NativeReflectionCached.GetPropertyOffset(SubscribeToWaapi_FunctionAddress, "CallBack");
		SubscribeToWaapi_CallBack_IsValid = NativeReflectionCached.ValidatePropertyClass(SubscribeToWaapi_FunctionAddress, "CallBack", Classes.FDelegateProperty);
		NativeReflectionCached.GetPropertyRef(ref SubscribeToWaapi_SubscriptionId_PropertyAddress, SubscribeToWaapi_FunctionAddress, "SubscriptionId");
		SubscribeToWaapi_SubscriptionId_Offset = NativeReflectionCached.GetPropertyOffset(SubscribeToWaapi_FunctionAddress, "SubscriptionId");
		SubscribeToWaapi_SubscriptionId_IsValid = NativeReflectionCached.ValidatePropertyClass(SubscribeToWaapi_FunctionAddress, "SubscriptionId", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SubscribeToWaapi_SubscriptionDone_PropertyAddress, SubscribeToWaapi_FunctionAddress, "SubscriptionDone");
		SubscribeToWaapi_SubscriptionDone_Offset = NativeReflectionCached.GetPropertyOffset(SubscribeToWaapi_FunctionAddress, "SubscriptionDone");
		SubscribeToWaapi_SubscriptionDone_IsValid = NativeReflectionCached.ValidatePropertyClass(SubscribeToWaapi_FunctionAddress, "SubscriptionDone", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SubscribeToWaapi_ReturnValue_PropertyAddress, SubscribeToWaapi_FunctionAddress, "ReturnValue");
		SubscribeToWaapi_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SubscribeToWaapi_FunctionAddress, "ReturnValue");
		SubscribeToWaapi_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SubscribeToWaapi_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		SubscribeToWaapi_IsValid = SubscribeToWaapi_FunctionAddress != IntPtr.Zero && SubscribeToWaapi_WaapiUri_IsValid && SubscribeToWaapi_WaapiOptions_IsValid && SubscribeToWaapi_CallBack_IsValid && SubscribeToWaapi_SubscriptionId_IsValid && SubscribeToWaapi_SubscriptionDone_IsValid && SubscribeToWaapi_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkWaapiCalls:SubscribeToWaapi", SubscribeToWaapi_IsValid);
		SetSubscriptionID_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetSubscriptionID");
		SetSubscriptionID_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSubscriptionID_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSubscriptionID_Subscription_PropertyAddress, SetSubscriptionID_FunctionAddress, "Subscription");
		SetSubscriptionID_Subscription_Offset = NativeReflectionCached.GetPropertyOffset(SetSubscriptionID_FunctionAddress, "Subscription");
		SetSubscriptionID_Subscription_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSubscriptionID_FunctionAddress, "Subscription", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSubscriptionID_id_PropertyAddress, SetSubscriptionID_FunctionAddress, "id");
		SetSubscriptionID_id_Offset = NativeReflectionCached.GetPropertyOffset(SetSubscriptionID_FunctionAddress, "id");
		SetSubscriptionID_id_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSubscriptionID_FunctionAddress, "id", Classes.FIntProperty);
		SetSubscriptionID_IsValid = SetSubscriptionID_FunctionAddress != IntPtr.Zero && SetSubscriptionID_Subscription_IsValid && SetSubscriptionID_id_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkWaapiCalls:SetSubscriptionID", SetSubscriptionID_IsValid);
		RegisterWaapiProjectLoadedCallback_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RegisterWaapiProjectLoadedCallback");
		RegisterWaapiProjectLoadedCallback_ParamsSize = NativeReflection.GetFunctionParamsSize(RegisterWaapiProjectLoadedCallback_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RegisterWaapiProjectLoadedCallback_Callback_PropertyAddress, RegisterWaapiProjectLoadedCallback_FunctionAddress, "Callback");
		RegisterWaapiProjectLoadedCallback_Callback_Offset = NativeReflectionCached.GetPropertyOffset(RegisterWaapiProjectLoadedCallback_FunctionAddress, "Callback");
		RegisterWaapiProjectLoadedCallback_Callback_IsValid = NativeReflectionCached.ValidatePropertyClass(RegisterWaapiProjectLoadedCallback_FunctionAddress, "Callback", Classes.FDelegateProperty);
		NativeReflectionCached.GetPropertyRef(ref RegisterWaapiProjectLoadedCallback_ReturnValue_PropertyAddress, RegisterWaapiProjectLoadedCallback_FunctionAddress, "ReturnValue");
		RegisterWaapiProjectLoadedCallback_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RegisterWaapiProjectLoadedCallback_FunctionAddress, "ReturnValue");
		RegisterWaapiProjectLoadedCallback_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RegisterWaapiProjectLoadedCallback_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RegisterWaapiProjectLoadedCallback_IsValid = RegisterWaapiProjectLoadedCallback_FunctionAddress != IntPtr.Zero && RegisterWaapiProjectLoadedCallback_Callback_IsValid && RegisterWaapiProjectLoadedCallback_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkWaapiCalls:RegisterWaapiProjectLoadedCallback", RegisterWaapiProjectLoadedCallback_IsValid);
		RegisterWaapiConnectionLostCallback_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RegisterWaapiConnectionLostCallback");
		RegisterWaapiConnectionLostCallback_ParamsSize = NativeReflection.GetFunctionParamsSize(RegisterWaapiConnectionLostCallback_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RegisterWaapiConnectionLostCallback_Callback_PropertyAddress, RegisterWaapiConnectionLostCallback_FunctionAddress, "Callback");
		RegisterWaapiConnectionLostCallback_Callback_Offset = NativeReflectionCached.GetPropertyOffset(RegisterWaapiConnectionLostCallback_FunctionAddress, "Callback");
		RegisterWaapiConnectionLostCallback_Callback_IsValid = NativeReflectionCached.ValidatePropertyClass(RegisterWaapiConnectionLostCallback_FunctionAddress, "Callback", Classes.FDelegateProperty);
		NativeReflectionCached.GetPropertyRef(ref RegisterWaapiConnectionLostCallback_ReturnValue_PropertyAddress, RegisterWaapiConnectionLostCallback_FunctionAddress, "ReturnValue");
		RegisterWaapiConnectionLostCallback_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RegisterWaapiConnectionLostCallback_FunctionAddress, "ReturnValue");
		RegisterWaapiConnectionLostCallback_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RegisterWaapiConnectionLostCallback_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RegisterWaapiConnectionLostCallback_IsValid = RegisterWaapiConnectionLostCallback_FunctionAddress != IntPtr.Zero && RegisterWaapiConnectionLostCallback_Callback_IsValid && RegisterWaapiConnectionLostCallback_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkWaapiCalls:RegisterWaapiConnectionLostCallback", RegisterWaapiConnectionLostCallback_IsValid);
		GetSubscriptionID_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetSubscriptionID");
		GetSubscriptionID_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSubscriptionID_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSubscriptionID_Subscription_PropertyAddress, GetSubscriptionID_FunctionAddress, "Subscription");
		GetSubscriptionID_Subscription_Offset = NativeReflectionCached.GetPropertyOffset(GetSubscriptionID_FunctionAddress, "Subscription");
		GetSubscriptionID_Subscription_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSubscriptionID_FunctionAddress, "Subscription", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSubscriptionID_ReturnValue_PropertyAddress, GetSubscriptionID_FunctionAddress, "ReturnValue");
		GetSubscriptionID_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSubscriptionID_FunctionAddress, "ReturnValue");
		GetSubscriptionID_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSubscriptionID_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetSubscriptionID_IsValid = GetSubscriptionID_FunctionAddress != IntPtr.Zero && GetSubscriptionID_Subscription_IsValid && GetSubscriptionID_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkWaapiCalls:GetSubscriptionID", GetSubscriptionID_IsValid);
		Conv_FAkWaapiSubscriptionIdToText_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Conv_FAkWaapiSubscriptionIdToText");
		Conv_FAkWaapiSubscriptionIdToText_ParamsSize = NativeReflection.GetFunctionParamsSize(Conv_FAkWaapiSubscriptionIdToText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Conv_FAkWaapiSubscriptionIdToText_INAkWaapiSubscriptionId_PropertyAddress, Conv_FAkWaapiSubscriptionIdToText_FunctionAddress, "INAkWaapiSubscriptionId");
		Conv_FAkWaapiSubscriptionIdToText_INAkWaapiSubscriptionId_Offset = NativeReflectionCached.GetPropertyOffset(Conv_FAkWaapiSubscriptionIdToText_FunctionAddress, "INAkWaapiSubscriptionId");
		Conv_FAkWaapiSubscriptionIdToText_INAkWaapiSubscriptionId_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_FAkWaapiSubscriptionIdToText_FunctionAddress, "INAkWaapiSubscriptionId", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Conv_FAkWaapiSubscriptionIdToText_ReturnValue_PropertyAddress, Conv_FAkWaapiSubscriptionIdToText_FunctionAddress, "ReturnValue");
		Conv_FAkWaapiSubscriptionIdToText_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Conv_FAkWaapiSubscriptionIdToText_FunctionAddress, "ReturnValue");
		Conv_FAkWaapiSubscriptionIdToText_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_FAkWaapiSubscriptionIdToText_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		Conv_FAkWaapiSubscriptionIdToText_IsValid = Conv_FAkWaapiSubscriptionIdToText_FunctionAddress != IntPtr.Zero && Conv_FAkWaapiSubscriptionIdToText_INAkWaapiSubscriptionId_IsValid && Conv_FAkWaapiSubscriptionIdToText_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkWaapiCalls:Conv_FAkWaapiSubscriptionIdToText", Conv_FAkWaapiSubscriptionIdToText_IsValid);
		Conv_FAkWaapiSubscriptionIdToString_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Conv_FAkWaapiSubscriptionIdToString");
		Conv_FAkWaapiSubscriptionIdToString_ParamsSize = NativeReflection.GetFunctionParamsSize(Conv_FAkWaapiSubscriptionIdToString_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Conv_FAkWaapiSubscriptionIdToString_INAkWaapiSubscriptionId_PropertyAddress, Conv_FAkWaapiSubscriptionIdToString_FunctionAddress, "INAkWaapiSubscriptionId");
		Conv_FAkWaapiSubscriptionIdToString_INAkWaapiSubscriptionId_Offset = NativeReflectionCached.GetPropertyOffset(Conv_FAkWaapiSubscriptionIdToString_FunctionAddress, "INAkWaapiSubscriptionId");
		Conv_FAkWaapiSubscriptionIdToString_INAkWaapiSubscriptionId_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_FAkWaapiSubscriptionIdToString_FunctionAddress, "INAkWaapiSubscriptionId", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Conv_FAkWaapiSubscriptionIdToString_ReturnValue_PropertyAddress, Conv_FAkWaapiSubscriptionIdToString_FunctionAddress, "ReturnValue");
		Conv_FAkWaapiSubscriptionIdToString_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Conv_FAkWaapiSubscriptionIdToString_FunctionAddress, "ReturnValue");
		Conv_FAkWaapiSubscriptionIdToString_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_FAkWaapiSubscriptionIdToString_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		Conv_FAkWaapiSubscriptionIdToString_IsValid = Conv_FAkWaapiSubscriptionIdToString_FunctionAddress != IntPtr.Zero && Conv_FAkWaapiSubscriptionIdToString_INAkWaapiSubscriptionId_IsValid && Conv_FAkWaapiSubscriptionIdToString_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkWaapiCalls:Conv_FAkWaapiSubscriptionIdToString", Conv_FAkWaapiSubscriptionIdToString_IsValid);
		CallWaapi_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CallWaapi");
		CallWaapi_ParamsSize = NativeReflection.GetFunctionParamsSize(CallWaapi_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CallWaapi_WaapiUri_PropertyAddress, CallWaapi_FunctionAddress, "WaapiUri");
		CallWaapi_WaapiUri_Offset = NativeReflectionCached.GetPropertyOffset(CallWaapi_FunctionAddress, "WaapiUri");
		CallWaapi_WaapiUri_IsValid = NativeReflectionCached.ValidatePropertyClass(CallWaapi_FunctionAddress, "WaapiUri", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CallWaapi_WaapiArgs_PropertyAddress, CallWaapi_FunctionAddress, "WaapiArgs");
		CallWaapi_WaapiArgs_Offset = NativeReflectionCached.GetPropertyOffset(CallWaapi_FunctionAddress, "WaapiArgs");
		CallWaapi_WaapiArgs_IsValid = NativeReflectionCached.ValidatePropertyClass(CallWaapi_FunctionAddress, "WaapiArgs", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CallWaapi_WaapiOptions_PropertyAddress, CallWaapi_FunctionAddress, "WaapiOptions");
		CallWaapi_WaapiOptions_Offset = NativeReflectionCached.GetPropertyOffset(CallWaapi_FunctionAddress, "WaapiOptions");
		CallWaapi_WaapiOptions_IsValid = NativeReflectionCached.ValidatePropertyClass(CallWaapi_FunctionAddress, "WaapiOptions", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CallWaapi_ReturnValue_PropertyAddress, CallWaapi_FunctionAddress, "ReturnValue");
		CallWaapi_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CallWaapi_FunctionAddress, "ReturnValue");
		CallWaapi_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CallWaapi_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		CallWaapi_IsValid = CallWaapi_FunctionAddress != IntPtr.Zero && CallWaapi_WaapiUri_IsValid && CallWaapi_WaapiArgs_IsValid && CallWaapi_WaapiOptions_IsValid && CallWaapi_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkWaapiCalls:CallWaapi", CallWaapi_IsValid);
	}
}

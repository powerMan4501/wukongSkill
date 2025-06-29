using System.Runtime.CompilerServices;

namespace System;

internal static class AppContextSwitches
{
	private static int _noAsyncCurrentCulture;

	private static int _enforceJapaneseEraYearRanges;

	private static int _formatJapaneseFirstYearAsANumber;

	private static int _enforceLegacyJapaneseDateParsing;

	private static int _throwExceptionIfDisposedCancellationTokenSource;

	private static int _useConcurrentFormatterTypeCache;

	private static int _preserveEventListnerObjectIdentity;

	private static int _useLegacyPathHandling;

	private static int _blockLongPaths;

	private static int _cloneActor;

	private static int _doNotAddrOfCspParentWindowHandle;

	private static int _ignorePortablePDBsInStackTraces;

	private static int _useNewMaxArraySize;

	private static int _useLegacyExecutionContextBehaviorUponUndoFailure;

	private static int _useLegacyFipsThrow;

	private static int _doNotMarshalOutByrefSafeArrayOnInvoke;

	private static int _useNetCoreTimer;

	public static bool NoAsyncCurrentCulture
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return GetCachedSwitchValue(AppContextDefaultValues.SwitchNoAsyncCurrentCulture, ref _noAsyncCurrentCulture);
		}
	}

	public static bool EnforceJapaneseEraYearRanges
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return GetCachedSwitchValue(AppContextDefaultValues.SwitchEnforceJapaneseEraYearRanges, ref _enforceJapaneseEraYearRanges);
		}
	}

	public static bool FormatJapaneseFirstYearAsANumber
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return GetCachedSwitchValue(AppContextDefaultValues.SwitchFormatJapaneseFirstYearAsANumber, ref _formatJapaneseFirstYearAsANumber);
		}
	}

	public static bool EnforceLegacyJapaneseDateParsing
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return GetCachedSwitchValue(AppContextDefaultValues.SwitchEnforceLegacyJapaneseDateParsing, ref _enforceLegacyJapaneseDateParsing);
		}
	}

	public static bool ThrowExceptionIfDisposedCancellationTokenSource
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return GetCachedSwitchValue(AppContextDefaultValues.SwitchThrowExceptionIfDisposedCancellationTokenSource, ref _throwExceptionIfDisposedCancellationTokenSource);
		}
	}

	public static bool UseConcurrentFormatterTypeCache
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return GetCachedSwitchValue(AppContextDefaultValues.SwitchUseConcurrentFormatterTypeCache, ref _useConcurrentFormatterTypeCache);
		}
	}

	public static bool PreserveEventListnerObjectIdentity
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return GetCachedSwitchValue(AppContextDefaultValues.SwitchPreserveEventListnerObjectIdentity, ref _preserveEventListnerObjectIdentity);
		}
	}

	public static bool UseLegacyPathHandling
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return GetCachedSwitchValue(AppContextDefaultValues.SwitchUseLegacyPathHandling, ref _useLegacyPathHandling);
		}
	}

	public static bool BlockLongPaths
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return GetCachedSwitchValue(AppContextDefaultValues.SwitchBlockLongPaths, ref _blockLongPaths);
		}
	}

	public static bool SetActorAsReferenceWhenCopyingClaimsIdentity
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return GetCachedSwitchValue(AppContextDefaultValues.SwitchSetActorAsReferenceWhenCopyingClaimsIdentity, ref _cloneActor);
		}
	}

	public static bool DoNotAddrOfCspParentWindowHandle
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return GetCachedSwitchValue(AppContextDefaultValues.SwitchDoNotAddrOfCspParentWindowHandle, ref _doNotAddrOfCspParentWindowHandle);
		}
	}

	public static bool IgnorePortablePDBsInStackTraces
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return GetCachedSwitchValue(AppContextDefaultValues.SwitchIgnorePortablePDBsInStackTraces, ref _ignorePortablePDBsInStackTraces);
		}
	}

	public static bool UseNewMaxArraySize
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return GetCachedSwitchValue(AppContextDefaultValues.SwitchUseNewMaxArraySize, ref _useNewMaxArraySize);
		}
	}

	public static bool UseLegacyExecutionContextBehaviorUponUndoFailure
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return GetCachedSwitchValue(AppContextDefaultValues.SwitchUseLegacyExecutionContextBehaviorUponUndoFailure, ref _useLegacyExecutionContextBehaviorUponUndoFailure);
		}
	}

	public static bool UseLegacyFipsThrow
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return GetCachedSwitchValue(AppContextDefaultValues.SwitchCryptographyUseLegacyFipsThrow, ref _useLegacyFipsThrow);
		}
	}

	public static bool DoNotMarshalOutByrefSafeArrayOnInvoke
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return GetCachedSwitchValue(AppContextDefaultValues.SwitchDoNotMarshalOutByrefSafeArrayOnInvoke, ref _doNotMarshalOutByrefSafeArrayOnInvoke);
		}
	}

	public static bool UseNetCoreTimer
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return GetCachedSwitchValue(AppContextDefaultValues.SwitchUseNetCoreTimer, ref _useNetCoreTimer);
		}
	}

	private static bool DisableCaching { get; set; }

	static AppContextSwitches()
	{
		if (AppContext.TryGetSwitch("TestSwitch.LocalAppContext.DisableCaching", out var isEnabled))
		{
			DisableCaching = isEnabled;
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static bool GetCachedSwitchValue(string switchName, ref int switchValue)
	{
		if (switchValue < 0)
		{
			return false;
		}
		if (switchValue > 0)
		{
			return true;
		}
		return GetCachedSwitchValueInternal(switchName, ref switchValue);
	}

	private static bool GetCachedSwitchValueInternal(string switchName, ref int switchValue)
	{
		AppContext.TryGetSwitch(switchName, out var isEnabled);
		if (DisableCaching)
		{
			return isEnabled;
		}
		switchValue = (isEnabled ? 1 : (-1));
		return isEnabled;
	}
}

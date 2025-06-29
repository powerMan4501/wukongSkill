using System.Security.Permissions;

namespace System.Net;

internal static class ExceptionHelper
{
	internal static readonly KeyContainerPermission KeyContainerPermissionOpen = new KeyContainerPermission(KeyContainerPermissionFlags.Open);

	internal static readonly WebPermission WebPermissionUnrestricted = new WebPermission(NetworkAccess.Connect);

	internal static readonly SecurityPermission UnmanagedPermission = new SecurityPermission(SecurityPermissionFlag.UnmanagedCode);

	internal static readonly SocketPermission UnrestrictedSocketPermission = new SocketPermission(PermissionState.Unrestricted);

	internal static readonly SecurityPermission InfrastructurePermission = new SecurityPermission(SecurityPermissionFlag.Infrastructure);

	internal static readonly SecurityPermission ControlPolicyPermission = new SecurityPermission(SecurityPermissionFlag.ControlPolicy);

	internal static readonly SecurityPermission ControlPrincipalPermission = new SecurityPermission(SecurityPermissionFlag.ControlPrincipal);

	internal static NotImplementedException MethodNotImplementedException => new NotImplementedException(SR.GetString("net_MethodNotImplementedException"));

	internal static NotImplementedException PropertyNotImplementedException => new NotImplementedException(SR.GetString("net_PropertyNotImplementedException"));

	internal static NotSupportedException MethodNotSupportedException => new NotSupportedException(SR.GetString("net_MethodNotSupportedException"));

	internal static NotSupportedException PropertyNotSupportedException => new NotSupportedException(SR.GetString("net_PropertyNotSupportedException"));

	internal static WebException IsolatedException => new WebException(NetRes.GetWebStatusString("net_requestaborted", WebExceptionStatus.KeepAliveFailure), WebExceptionStatus.KeepAliveFailure, WebExceptionInternalStatus.Isolated, null);

	internal static WebException RequestAbortedException => new WebException(NetRes.GetWebStatusString("net_requestaborted", WebExceptionStatus.RequestCanceled), WebExceptionStatus.RequestCanceled);

	internal static WebException CacheEntryNotFoundException => new WebException(NetRes.GetWebStatusString("net_requestaborted", WebExceptionStatus.CacheEntryNotFound), WebExceptionStatus.CacheEntryNotFound);

	internal static WebException RequestProhibitedByCachePolicyException => new WebException(NetRes.GetWebStatusString("net_requestaborted", WebExceptionStatus.RequestProhibitedByCachePolicy), WebExceptionStatus.RequestProhibitedByCachePolicy);
}

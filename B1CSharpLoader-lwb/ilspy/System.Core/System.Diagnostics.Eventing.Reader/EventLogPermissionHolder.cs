namespace System.Diagnostics.Eventing.Reader;

internal class EventLogPermissionHolder
{
	public static EventLogPermission GetEventLogPermission()
	{
		EventLogPermission eventLogPermission = new EventLogPermission();
		EventLogPermissionEntry value = new EventLogPermissionEntry(EventLogPermissionAccess.Administer, ".");
		eventLogPermission.PermissionEntries.Add(value);
		return eventLogPermission;
	}
}

namespace System.Security.Permissions;

[Serializable]
public class ResourcePermissionBaseEntry
{
	private string[] accessPath;

	private int permissionAccess;

	public int PermissionAccess => permissionAccess;

	public string[] PermissionAccessPath => accessPath;

	public ResourcePermissionBaseEntry()
	{
		permissionAccess = 0;
		accessPath = new string[0];
	}

	public ResourcePermissionBaseEntry(int permissionAccess, string[] permissionAccessPath)
	{
		if (permissionAccessPath == null)
		{
			throw new ArgumentNullException("permissionAccessPath");
		}
		this.permissionAccess = permissionAccess;
		accessPath = permissionAccessPath;
	}
}

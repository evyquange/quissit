public static void ChangeTracking(Repository<TestClass> repo)
{
    // Get the changes made to the repository
    var changes = repo.GetChanges();

    // Iterate over the changes
    foreach (var change in changes)
    {
        // Get the entity and its change type
        var entity = change.Entity;
        var changeType = change.ChangeType;

        // Perform some logic based on the change type
        switch (changeType)
        {
            case ChangeType.Added:
                // Do something when an entity is added
                break;
            case ChangeType.Modified:
                // Do something when an entity is modified
                break;
            case ChangeType.Deleted:
                // Do something when an entity is deleted
                break;
        }
    }
}

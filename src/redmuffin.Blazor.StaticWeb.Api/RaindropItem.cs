namespace redmuffin.Blazor.StaticWeb.Api;

public class RaindropItem
{
	public long Id { get; set; }
	public string? Link { get; set; }
	public string? Title { get; set; }
	public string? Excerpt { get; set; }
	public string? Note { get; set; }
	public string? Type { get; set; }
	public UserReference? User { get; set; }
	public string? Cover { get; set; }
	public IList<MediaItem>? Media { get; set; }
	public IList<string>? Tags { get; set; }
	public bool Important { get; set; }
	public Reminder? Reminder { get; set; }
	public bool Removed { get; set; }
	public DateTime Created { get; set; }
	public CollectionReference? Collection { get; set; }
	public IList<Highlight>? Highlights { get; set; }
}

public class UserReference
{
	public string? Ref { get; set; }
	public long Id { get; set; }
}

public class MediaItem
{
	public string? Link { get; set; }
	public string? Type { get; set; }
}

public class Reminder
{
	public DateTime? Date { get; set; }
}

public class CollectionReference
{
	public string? Ref { get; set; }
	public long Id { get; set; }
	public long Oid { get; set; }
}

public class Highlight
{
	public string? Text { get; set; }
	public string? Note { get; set; }
	public DateTime Created { get; set; }
	public DateTime LastUpdate { get; set; }
	public long CreatorRef { get; set; }
}
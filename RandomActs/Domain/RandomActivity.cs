using System;

namespace RandomActs;

public class RandomActivity
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string? Description { get; set; }

    public DateOnly? AddedOn { get; set; }
    public string? SourceUrl { get; set; }
}
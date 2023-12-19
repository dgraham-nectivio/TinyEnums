using System.ComponentModel.DataAnnotations;

namespace TinyEnums;

public class Thing
{
    [Key] public Guid Id { get; set; }

    public TinyEnum TinyEnum { get; set; }
}
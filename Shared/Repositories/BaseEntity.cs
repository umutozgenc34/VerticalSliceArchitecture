﻿namespace Shared.Repositories;

public class BaseEntity <TId>
{
    public TId Id { get; set; } = default!;
}

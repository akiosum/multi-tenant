﻿namespace UseMultiTenant.Domain.Abstractions;

public abstract class Entity
{
    public long Id { get; private set; }
}
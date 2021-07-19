﻿using System;

namespace DesignPatterns.Singletons.Injectable
{
    public class InjectableSingleton : IInjectableSingleton
    {
        private readonly Guid _guid;

        public InjectableSingleton(Guid guid)
        {
            _guid = guid;
        }

        public Guid AlwaysSameGuid()
        {
            return _guid;
        }
    }
}
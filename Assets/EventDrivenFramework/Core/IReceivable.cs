using System;

namespace EventDrivenFramework.Core
{
    public interface IReceivable
    {
        void Receive(EventArgs eventArgs);
    }
}
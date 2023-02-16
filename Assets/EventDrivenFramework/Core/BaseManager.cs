using System;
using System.Collections.Generic;
using UnityEngine;

namespace EventDrivenFramework.Core
{
    public abstract class BaseManager : MonoBehaviour, IReceivable, IManageable
    {
        protected BaseManager Manager;
        protected IMediator Mediator;

        protected List<IReceivable> Receivables = new List<IReceivable>();
        public void InjectManager(BaseManager manager)
        {
            if (Manager != null)
                Debug.LogError(
                    $"[{nameof(this.Manager)}] already added to [{this.GetType().Name}]");
            else
            {
                Manager = manager;
                Manager.Add(this);
            }
        }

        public void Add(IReceivable receivable)
        {
            if (!Receivables.Contains(receivable))
                Receivables.Add(receivable);
            else
                Debug.LogError(
                    $"[{nameof(this.Receivables)}] already added to [{this.GetType().Name}]");
        }

        public void InjectMediator(IMediator mediator)
        {
            if (Mediator != null)
                Debug.LogError(
                    $"[{nameof(this.Mediator)}] already added to [{this.GetType().Name}]");
            else
            {
                Mediator = mediator;
                Mediator.Add(this);
            }
        }

        public abstract void Receive(EventArgs eventArgs);

        protected virtual void BroadcastUpward(EventArgs eventArgs)
        {
            Manager.Receive(eventArgs);
        }

        protected virtual void Broadcast(EventArgs eventArgs)
        {
            if (Mediator == null)
                Debug.LogWarning($"No {nameof(Mediator)} found for {this.GetType().Name}");
            else
                Mediator.Broadcast(this, eventArgs);
        }

        protected virtual void BroadcastDownward(EventArgs eventArgs)
        {
            foreach (var receivable in Receivables)
                receivable.Receive(eventArgs);
        }
    }
}
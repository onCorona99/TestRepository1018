using System.Collections.Generic;

public class EventDispatcher<T> : IEventDispatcher where T : IEvent
{
    private List<IEventHandler<T>> _handlers = new List<IEventHandler<T>>();
    public void RegistEventHandler(IEventHandler<T> handler)
    {
        _handlers.Add(handler);
    }

    public void SendEvent(T evt)
    {
        foreach (var handler in _handlers)
        {
            handler.ReceiveEvent(evt);
        }
    }
}
public interface IEventHandler<T> where T : IEvent
{
    void ReceiveEvent(T evt);
}
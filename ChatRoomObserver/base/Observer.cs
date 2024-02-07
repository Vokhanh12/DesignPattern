namespace ChatRoomObserver.Notifiers
{
    public abstract class Observer
    {
        protected Subject subject;
        public abstract void Notify(Subject subject, Object obj);

    }
}
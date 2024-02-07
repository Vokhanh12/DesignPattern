
namespace ChatRoomObserver.notifier
{
    public class Subject
    {
        private List<Observer> _Observers = new List<Observer>();

        public void attach(Observer observer)
        {
            _Observers.Add(observer);
        }

        public void dettach(Observer observer)
        {
            _Observers.Remove(observer);
        }

        public void notify(Subject subject, Object agr)
        {
            _Observers.ForEach((observer) => observer.Notify(subject,agr));
        }

    }
}
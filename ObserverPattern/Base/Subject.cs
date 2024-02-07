using System;
namespace ObserverPattern.Notifiers
{
   public class Subject
    {
        private readonly List<Observer> _Observers = new List<Observer>();


        public void attach(Observer observer)
        {
            _Observers.Add(observer);
        }

        public void detach(Observer observer)
        {
            _Observers.Remove(observer);
        }

        public void NotifyObservers(Subject subject,object arg)
        {
            _Observers.ForEach((observer) => observer.Notify(subject,arg));
        }


    }
}
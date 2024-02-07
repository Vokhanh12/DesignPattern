namespace ObserverPattern.Notifiers
{
    public class EmailNotifier : Observer
    {
        public EmailNotifier(Subject subject)
        {
            this.subject = subject;
            this.subject.attach(this);
        }
        public override void Notify(Subject subject, object obj)
        {
            if(subject is WheaterData wheaterData)
            {
                Console.WriteLine(
                    string.Format(
                        $"Notify all subscribers via Email with new data"+
                        "\n\tState:{0}"+
                        "\n\tTemp:{1}"+
                        "\n\tAmount of rain:{2}"+
                        "\nt\tWind:{3}",
                        wheaterData.getState(),
                        wheaterData.getTemp(),
                        wheaterData.getAmountOfRain(),
                        wheaterData.getWind()
                    )
                );


            }


        }
    }
}
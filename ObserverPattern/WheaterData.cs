using System.Diagnostics.Contracts;
using System.Dynamic;
namespace ObserverPattern.Notifiers
{
  public class WheaterData : Subject
    {
        #region Private Properties
        private string _state;
        private int _temp;
        private int _amountOfRain;
        private int _wind;
        #endregion

        #region GetSetProperties
        public string getState() => _state;
        public void SetState(string value)
        {
            _state = value;
            WheaterDataChanged();
        } 
    
        public int getTemp() => _temp;
        public void setTemp(int value)
        {
            _temp = value;
            WheaterDataChanged();
        }
        public int getAmountOfRain() => _amountOfRain;
        public void setAmountOfRain(int value)
        {
            _amountOfRain = value;
            WheaterDataChanged();
        }
        public int getWind() => _wind; 
        public void setWind(int value)
        {
            _wind = value;
            WheaterDataChanged();
        }
        #endregion

        public void WheaterDataChanged()
        {
            var state = getState();
            var temp = getTemp();
            var amountOfRain = getAmountOfRain();
            var wind = getWind();

            NotifyObservers(this,null);
        }


    }
}

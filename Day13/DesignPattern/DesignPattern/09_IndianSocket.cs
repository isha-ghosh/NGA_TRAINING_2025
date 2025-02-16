using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern;

namespace DesignPattern
{
    //what we need i.e requirements
    public interface IndianSocket
    {
        void plugIn();  //this means indian socket need 3 pin plug
    }

    //what we have
   public class AmericanCharger
    {
        void connect()
        {
            Console.WriteLine("Charging with 2 pin");
        }
    }
    class ChargerAdapter : IndianSocket
    {
        private AmericanCharger charger;
        public ChargerAdapter(AmericanCharger charger)
        {
            this.charger = charger;
        }
        public void plugIn()
        {
           // Console.WriteLine("Adapter converts 3-pin socket to 2-pin plug.");
            //charger.connect();
           throw new NotImplementedException();
        }
    }
   public class AdapterExample 

    {
        public static void Main(string[] args)
        {
            AmericanCharger charger = new AmericanCharger();
            // we are making indian to use the american one with an indian socket
            IndianSocket adapter = new ChargerAdapter(charger);
            adapter.plugIn();
        }
    }
}

using System.Text;

namespace Cars
{
    public class Tesla : IElectricCar, ICar
    {
        private string color;
        private string model;
        private int battery; 

        public Tesla(string model, string color, int battery)
        {
            Model = model;
            Color = color;
            Battery = battery;
        }

        public string Color
        {
            get { return color; }
            private set { color = value; }
        }
        public string Model
        {
            get{ return model; }
            private set { model = value; }
        }
        public int Battery
        {
            get { return battery; }
            private set { battery = value; }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Color} Tesla {Model} with {Battery} Bateries");
            sb.AppendLine(Start());
            sb.Append(Stop());
            return sb.ToString();
        }
        public string Start()
        {
            return "Engine start";
        }
        public string Stop()
        {
            return "Breaaak!";
        }
    }
}

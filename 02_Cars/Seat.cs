using System.Text;

namespace Cars
{
    public class Seat : ICar
    {
        private string color;
        private string model;

        public Seat(string model, string color)
        {
            Model = model;
            Color = color;
        }

        public string Color
        {
            get { return color; }
            private set { color = value; }
        }

        public string Model
        {
            get { return model; }
            private set { model = value; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Color} Seat {Model}");
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

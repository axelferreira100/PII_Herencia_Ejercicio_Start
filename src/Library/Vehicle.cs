namespace Library
{
    public abstract class Vehicle
    {
        private string _mark, _model, _color;
        private double _speed = 0.0;
        private bool _status = false;

        public string Mark
        {
            get { return this._mark; }
            private set { this._mark = value; }
        }

        public string Model
        {
            get { return this._model; }
            private set { this._model = value; }
        }

        public string Color
        {
            get { return this._color; }
            private set { this._color = value; }
        }

        public double Speed
        {
            get { return this._speed; }
            private set { this._speed = value; }
        }

        public bool Status
        {
            get { return this._status; }
            private set { this._status = value; }
        }

        public Vehicle(string mark, string model, string color)
        {
            this.Mark = mark;
            this.Model = model;
            this.Color = color;
        }

        public void Start()
        {
            this.Status = true;
        }

        public void Stop()
        {
            this.Status = false;
        }

        public void Accelerate()
        {
            this.Speed += 10.0;
        }

        public void Decelerate()
        {
            this.Speed -= 10.0;
        }
    }
}
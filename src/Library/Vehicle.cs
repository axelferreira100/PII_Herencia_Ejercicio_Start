namespace Library
{
    public abstract class Vehicle
    {
        protected string _mark, _model, _color;
        protected double _speed = 0.0;
        protected bool _engineStatus = false;

        public string Mark
        {
            get { return this._mark; }
            protected set { this._mark = value; }
        }

        public string Model
        {
            get { return this._model; }
            protected set { this._model = value; }
        }

        public string Color
        {
            get { return this._color; }
            protected set { this._color = value; }
        }

        public double Speed
        {
            get { return this._speed; }
            protected set { this._speed = value; }
        }

        public bool EngineStatus
        {
            get { return this._engineStatus; }
            protected set { this._engineStatus = value; }
        }

        public Vehicle(string mark, string model, string color)
        {
            this.Mark = mark;
            this.Model = model;
            this.Color = color;
        }

        public void Start()
        {
            this.EngineStatus = true;
        }

        public void Stop()
        {
            this.EngineStatus = false;
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
namespace Library
{
    public abstract class Vehicle
    {
        protected string _mark, _model, _color;
        protected double _speed = 0.0;
        protected bool _status = false;

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

        public bool Status
        {
            get { return this._status; }
            protected set { this._status = value; }
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